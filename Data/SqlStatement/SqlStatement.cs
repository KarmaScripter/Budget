// <copyright file = "SqlStatement.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using OfficeOpenXml.DataValidation;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.SqlBase" />
    /// <seealso cref="BudgetExecution.ISqlStatement" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class SqlStatement : SqlBase, ISqlStatement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        public SqlStatement( )
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, SQL commandType = SQL.SELECTALL )
            : base( source, provider, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public SqlStatement( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText, SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, string sqlText,
            SQL commandType )
            : base( source, provider, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where"></param>
        /// <param name="commandType"></param>
        public SqlStatement( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL )
            : base( source, provider, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name = "updates" > </param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="where">The arguments.</param>
        /// 
        public SqlStatement( Source source, Provider provider, SQL commandType,
            IDictionary<string, object> where )
            : base( source, provider, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="numerics">The aggregates.</param>
        /// <param name="having">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, IEnumerable<string> columns,
            IEnumerable<string> numerics, IDictionary<string, object> having,
            SQL commandType = SQL.SELECT )
            : base( source, provider, columns, numerics, having,
                commandType )
        {
        }

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public string GetCommandText(  )
        {
            if( Enum.IsDefined( typeof( SQL ), CommandType ) )
            {
                try
                {
                    switch( CommandType )
                    {
                        case SQL.SELECT:
                        case SQL.SELECTALL:
                        {
                            return GetSelectStatement( );
                        }
                        case SQL.INSERT:
                        {
                            return GetInsertStatement( );
                        }
                        case SQL.UPDATE:
                        {
                            return GetUpdateStatement(  );
                        }
                        case SQL.DELETE:
                        {
                            return GetDeleteStatement( );
                        }
                        default:
                        {
                            return GetSelectStatement(  );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }
        
        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public string GetCommandText( IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            if( Criteria?.Any( ) == true
               && Fields?.Any( ) == true
               && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    switch( commandType )
                    {
                        case SQL.SELECT:
                        case SQL.SELECTALL:
                        {
                            return GetSelectStatement( );
                        }
                        case SQL.INSERT:
                        {
                            return GetInsertStatement( );
                        }
                        case SQL.DELETE:
                        {
                            return GetDeleteStatement( );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="having">The having.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public string GetCommandText( IEnumerable<string> columns, IEnumerable<string> numerics,
            IDictionary<string, object> having, SQL commandType = SQL.SELECT )
        {
            if( having?.Any( ) == true
               && columns?.Any( ) == true
               && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    switch( commandType )
                    {
                        case SQL.SELECT:
                        case SQL.SELECTALL:
                        {
                            return GetSelectStatement( );
                        }
                        case SQL.INSERT:
                        {
                            return GetInsertStatement( );
                        }
                        case SQL.DELETE:
                        {
                            return GetDeleteStatement( );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name = "updates" > </param>
        /// <param name = "where" > </param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public string GetCommandText( IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            if( where?.Any( ) == true
               && Enum.IsDefined( typeof( Source ), Source )
               && updates?.Any( ) == true )
            {
                try
                {
                    switch( commandType )
                    {
                        case SQL.SELECT:
                        case SQL.SELECTALL:
                        {
                            return GetSelectStatement( );
                        }
                        case SQL.INSERT:
                        {
                            return GetInsertStatement( );
                        }
                        case SQL.UPDATE:
                        {
                            return GetUpdateStatement( );
                        }
                        case SQL.DELETE:
                        {
                            return GetDeleteStatement( );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }
        
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( CommandText )
                    ? CommandText
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }
    }
}
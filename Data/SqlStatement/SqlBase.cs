// <copyright file = "SqlBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Diagnostics.CodeAnalysis;
    using BudgetExecution;
    using Syncfusion.GridHelperClasses;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IProvider" />
    /// <seealso cref="ISource" />
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    public abstract class SqlBase
    {
        /// <summary>
        /// The extension
        /// </summary>
        public virtual EXT Extension { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public virtual Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public virtual Provider Provider { get; set; }

        /// <summary>
        /// The command type
        /// </summary>
        public virtual SQL CommandType { get; set; }

        /// <summary>
        /// The arguments
        /// </summary>
        public virtual IDictionary<string, object> Criteria { get; set; }

        /// <summary>
        /// Gets or sets the updates.
        /// </summary>
        /// <value>
        /// The updates.
        /// </value>
        public virtual IDictionary<string, object> Updates { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public virtual IEnumerable<string> Fields { get; set; }

        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public virtual IEnumerable<string> Numerics { get; set; }

        /// <summary>
        /// Gets or sets the groups.
        /// </summary>
        /// <value>
        /// The groups.
        /// </value>
        public virtual IEnumerable<string> Groups { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public virtual string TableName { get; set; }

        /// <summary>
        /// The provider path
        /// </summary>
        public virtual string DbPath { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        /// Gets or sets the select statement.
        /// </summary>
        /// <value>
        /// The select statement.
        /// </value>
        public virtual string CommandText { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        protected SqlBase( )
        {
            Criteria = new Dictionary<string, object>( );
            Fields = new List<string>( );
            Numerics = new List<string>( );
            Groups = new List<string>( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, SQL commandType = SQL.SELECTALL ) 
            : this( )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            Criteria = new Dictionary<string, object>( );
            Fields = new List<string>( );
            Numerics = new List<string>( );
            Groups = new List<string>( );
            CommandText = $"SELECT * FROM { source }";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, string sqlText,
            SQL commandType = SQL.SELECT ) 
            : this( )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            CommandType = commandType;
            CommandText = sqlText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name = "where"> </param>
        /// <param name = "commandType" > </param>
        protected SqlBase( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL ) 
            : this( )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Criteria = where;
            CommandText = $"SELECT * FROM { source } WHERE { where.ToCriteria( ) }";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <param name="updates"></param>
        /// <param name="where"></param>
        /// <param name="commandType"></param>
        protected SqlBase( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE ) 
            : this( )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Updates = updates;
            Criteria = where;
            Fields = updates.Keys.ToList( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT ) 
            : this( )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Criteria = where;
            Fields = columns.ToList( );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <param name="columns"></param>
        /// <param name="numerics"></param>
        /// <param name="having"></param>
        /// <param name="commandType"></param>
        protected SqlBase( Source source, Provider provider, IEnumerable<string> columns,
            IEnumerable<string> numerics, IDictionary<string, object> having,
            SQL commandType = SQL.SELECT ) 
            : this( )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Criteria = having;
            Fields = columns.ToList( );
            Numerics = numerics.ToList( );
        }

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        public virtual string GetSelectStatement( )
        {
            if( Fields?.Any( ) == true
               && Criteria?.Any( ) == true )
            {
                try
                {
                    var _criteria = Criteria.ToCriteria( );
                    var _columns = string.Empty;
                    foreach( var col in Fields )
                    {
                        _columns += $"{col}, ";
                    }
                    
                    _columns = _columns.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT DISTINCT { _columns } FROM { Source } "
                        + $"GROUP BY { _columns } HAVING { _criteria };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }
            else if( Fields == null
                    && Criteria?.Any( ) == true )
            {
                var _criteria = Criteria.ToCriteria( );
                return $"SELECT * FROM { Source } WHERE { _criteria };";
            }
            else if( Fields == null
                    && Criteria == null )
            {
                return $"SELECT * FROM { Source };";
            }

            return default( string );
        }

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        /// <param name="where">The dictionary.</param>
        public virtual string CreateSelectStatement( IDictionary<string, object> where )
        {
            if( Enum.IsDefined( typeof( Source ), Source )
               && where?.Any( ) == true )
            {
                try
                {
                    var _criteria = where.ToCriteria( );
                    return $"SELECT * FROM { Source } WHERE { _criteria };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Creates the select statement.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="having">The having.</param>
        /// <returns></returns>
        public virtual string CreateSelectStatement( IEnumerable<string> fields,
            IDictionary<string, object> having )
        {
            if( Enum.IsDefined( typeof( Source ), Source )
               && having?.Any( ) == true
               && fields?.Any( ) == true )
            {
                try
                {
                    var _cols = string.Empty;
                    var _aggr = string.Empty;
                    var _grp = string.Empty;
                    foreach( var name in fields )
                    {
                        _cols += $"{ name }, ";
                    }
                    
                    var _criteria = having.ToCriteria( );
                    var _columns = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT DISTINCT { _columns } FROM { Source } "
                        + $"GROUP BY { _columns } HAVING { _criteria };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }
        
        /// <summary>
        /// Creates the select statement.
        /// </summary>
        /// <param name="fields">The columns.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="having">The having.</param>
        /// <returns></returns>
        public virtual string CreateSelectStatement( IEnumerable<string> fields,
            IEnumerable<string> numerics, IDictionary<string, object> having )
        {
            if( Enum.IsDefined( typeof( Source ), Source )
               && having?.Any( ) == true
               && fields?.Any( ) == true
               && numerics?.Any( ) == true )
            {
                try
                {
                    var _cols = string.Empty;
                    var _aggr = string.Empty;
                    var _grp = string.Empty;
                    foreach( var name in fields )
                    {
                        _cols += $"{ name }, ";
                    }

                    foreach( var _numeric in numerics )
                    {
                        _grp += $"SUM({ _numeric }), ";
                        _aggr += $"SUM({ _numeric }) AS { _numeric }, ";
                    }

                    var _criteria = having.ToCriteria( );
                    var _columns = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                    var _groups = _cols + _grp.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT DISTINCT { _columns } FROM { Source } "
                        + $"GROUP BY { _groups } HAVING { _criteria };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the update statement.
        /// </summary>
        /// <param name="updates">The dictionary.</param>
        /// <param name = "where" > </param>
        public virtual string CreateUpdateStatement( IDictionary<string, object> updates,
            IDictionary<string, object> where )
        {
            if( updates?.Any( ) == true
               && where?.Any( ) == true
               && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _update = string.Empty;
                    if( updates.Count == 1 )
                    {
                        foreach( var kvp in updates )
                        {
                            _update += $"{ kvp.Key } = '{ kvp.Value }'";
                        }
                    }
                    else if( updates.Count > 1 )
                    {
                        foreach( var kvp in updates )
                        {
                            _update += $"{ kvp.Key } = '{ kvp.Value }', ";
                        }
                    }

                    var _criteria = where.ToCriteria( );
                    var _values = _update.TrimEnd( ", ".ToCharArray( ) );
                    return $"UPDATE { Source } SET { _values } WHERE { _criteria };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the insert statement.
        /// </summary>
        /// <param name="updates">The dictionary.</param>
        public virtual string CreateInsertStatement( IDictionary<string, object> updates )
        {
            if( updates?.Any( ) == true
               && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _columns = string.Empty;
                    var _values = string.Empty;
                    if( updates.Count == 1 )
                    {
                        foreach( var kvp in updates )
                        {
                            _columns += $"{ kvp.Key }";
                            _values += $"{ kvp.Value }";
                        }
                    }
                    else if( updates.Count > 1 )
                    {
                        foreach( var kvp in updates )
                        {
                            _columns += $"{ kvp.Key }, ";
                            _values += $"{ kvp.Value }, ";
                        }
                    }

                    var _columnValues = $"({ _columns.TrimEnd( ", ".ToCharArray( ) ) })"
                        + $" VALUES ({ _values.TrimEnd( ", ".ToCharArray( ) ) })";

                    return $"INSERT INTO { Source } { _columnValues };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
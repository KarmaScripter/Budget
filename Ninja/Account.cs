// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class Account : PRC, IAccount, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; } = Source.Accounts;

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string GoalCode { get; set; }
        
        public string ObjectiveCode { get; set; }
        
        public string NpmCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Account"/> class.
        /// </summary>
        public Account( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Account"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public Account( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ $"{ PrimaryKey.AccountsId }" ]?.ToString(  ) );
            NpmCode = Record[ $"{ Field.NpmCode }" ].ToString( );
            ProgramProjectCode = Record[ $"{ Field.ProgramProjectCode }" ].ToString( );
            ActivityCode = Record[ $"{ Field.ActivityCode }" ].ToString( );
            ProgramAreaCode = Record[ $"{ Field.ProgramAreaCode }" ].ToString( );
            GoalCode = Record[ $"{ Field.GoalCode }" ].ToString( );
            ObjectiveCode = Record[ $"{ Field.ObjectiveCode }" ].ToString( );
            ActivityCode = Record[ $"{ Field.ActivityCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Account"/> class.
        /// </summary>
        /// <param name = "dataBuilder" >
        /// The dataBuilder.
        /// </param>
        public Account( IDataModel dataBuilder )
        {
            Record = dataBuilder?.Record;
            ID = int.Parse( Record[ $"{ PrimaryKey.AccountsId }" ]?.ToString(  ) );
            NpmCode = Record?[ $"{ Field.NpmCode }" ].ToString( );
            ProgramProjectCode = Record?[ $"{ Field.ProgramProjectCode }" ].ToString( );
            ActivityCode = Record?[ $"{ Field.ActivityCode }" ].ToString( );
            ProgramAreaCode = Record?[ $"{ Field.ProgramAreaCode }" ].ToString( );
            GoalCode = Record?[ $"{ Field.GoalCode }" ].ToString( );
            ObjectiveCode = Record?[ $"{ Field.ObjectiveCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Account"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public Account( DataRow dataRow )
        {
            Record = dataRow;
            ID = int.Parse( Record[ $"{ PrimaryKey.AccountsId }" ]?.ToString(  ) );
            Code = Record[ $"{ Field.AccountCode }" ].ToString( );
            NpmCode = Record[ $"{ Field.NpmCode }" ].ToString( );
            ProgramProjectCode = Record[ $"{ Field.ProgramProjectCode }" ].ToString( );
            ActivityCode = Record[ $"{ Field.ActivityCode }" ].ToString( );
            ProgramAreaCode = Record[ $"{ Field.ProgramAreaCode }" ].ToString( );
            GoalCode = Record[ $"{ Field.GoalCode }" ].ToString( );
            ObjectiveCode = Record[ $"{ Field.ObjectiveCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Account"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public Account( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = int.Parse( Record[ $"{ PrimaryKey.AccountsId }" ].ToString(  ) );
            Code = Record[ $"{ Field.AccountCode }" ].ToString( );
            NpmCode = Record[ $"{ Field.NpmCode }" ].ToString( );
            ProgramProjectCode = Record[ $"{ Field.ProgramProjectCode }" ].ToString( );
            ActivityCode = Record[ $"{ Field.ActivityCode }" ].ToString( );
            ProgramAreaCode = Record[ $"{ Field.ProgramAreaCode }" ].ToString( );
            GoalCode = Record[ $"{ Field.GoalCode }" ].ToString( );
            ObjectiveCode = Record[ $"{ Field.ObjectiveCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }
        
        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        /// <returns>
        /// </returns>
        private protected IDictionary<string, object> GetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ $"{ Field.Code }" ] = code };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }

        /// <summary>
        /// Gets the account.
        /// </summary>
        /// <returns>
        /// </returns>
        public Account GetAccount( )
        {
            try
            {
                return (Account)MemberwiseClone( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Account );
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Data?.Any( ) == true
                    ? Data
                    : default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }
    }
}
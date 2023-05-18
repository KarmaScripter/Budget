// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary> </summary>
    /// <seealso cref = "BudgetExecution.PRC"/>
    /// <seealso cref = "BudgetExecution.IAccount"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class Account : PRC, IAccount
    {
        /// <summary> Gets or sets the agency activity. </summary>
        /// <value> The agency activity. </value>
        public string AgencyActivity { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Account"/>
        /// class.
        /// </summary>
        public Account( )
        {
            Source = Source.Accounts;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Account"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public Account( IQuery query )
            : base( query )
        {
            Source = Source.Accounts;
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "AccountsId" ]?.ToString( ) );
            NpmCode = Record[ "NpmCode" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ActivityCode = Record[ "ActivityCode" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ActivityCode = Record[ "ActivityCode" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Account"/>
        /// class.
        /// </summary>
        /// <param name = "dataBuilder" > The data builder. </param>
        public Account( IDataModel dataBuilder )
            : base( dataBuilder )
        {
            Source = Source.Accounts;
            Record = dataBuilder?.Record;
            ID = int.Parse( Record?[ "AccountsId" ]?.ToString( ) );
            GoalCode = Record?[ "GoalCode" ].ToString( );
            GoalName = Record?[ "GoalName" ].ToString( );
            ObjectiveCode = Record?[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record?[ "ObjectiveName" ].ToString( );
            NpmCode = Record?[ "NpmCode" ].ToString( );
            NpmName = Record?[ "NpmName" ].ToString( );
            ProgramProjectCode = Record?[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record?[ "ProgramProjectName" ].ToString( );
            ActivityCode = Record?[ "ActivityCode" ].ToString( );
            ActivityName = Record?[ "ActivityName" ].ToString( );
            ProgramAreaCode = Record?[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record?[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Account"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The data row. </param>
        public Account( DataRow dataRow )
        {
            Source = Source.Accounts;
            Record = dataRow;
            ID = int.Parse( Record[ "AccountsId" ]?.ToString( ) );
            GoalCode = dataRow[ "GoalCode" ].ToString( );
            GoalName = dataRow[ "GoalName" ].ToString( );
            ObjectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            ObjectiveName = dataRow[ "ObjectiveName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString( );
            NpmName = dataRow[ "NpmName" ].ToString( );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            ActivityCode = dataRow[ "ActivityCode" ].ToString( );
            ActivityName = dataRow[ "ActivityName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Account"/>
        /// class.
        /// </summary>
        /// <param name = "code" > The code. </param>
        public Account( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "AccountsId" ]?.ToString( ) );
            GoalCode = Record?[ "GoalCode" ].ToString( );
            GoalName = Record?[ "GoalName" ].ToString( );
            ObjectiveCode = Record?[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record?[ "ObjectiveName" ].ToString( );
            NpmCode = Record?[ "NpmCode" ].ToString( );
            NpmName = Record?[ "NpmName" ].ToString( );
            ProgramProjectCode = Record?[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record?[ "ProgramProjectName" ].ToString( );
            ActivityCode = Record?[ "ActivityCode" ].ToString( );
            ActivityName = Record?[ "ActivityName" ].ToString( );
            ProgramAreaCode = Record?[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record?[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        public Account( IAccount account )
        {
            ID = account.ID;
            GoalCode = account.GoalCode;
            GoalName = account.GoalName;
            ObjectiveCode = account.ObjectiveCode;
            ObjectiveName = account.ObjectiveName;
            NpmCode = account.NpmCode;
            NpmName = account.NpmName;
            ProgramProjectCode = account.ProgramProjectCode;
            ProgramProjectName = account.ProgramProjectName;
            ActivityCode = account.ActivityCode;
            ActivityName = account.ActivityName;
            ProgramAreaCode = account.ProgramProjectCode;
            ProgramAreaName = account.ProgramAreaName;
        }

        /// <summary> Gets the account. </summary>
        /// <returns> </returns>
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

        /// <summary> Gets the arguments. </summary>
        /// <param name = "code" > The code. </param>
        /// <returns> </returns>
        private protected IDictionary<string, object> GetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ $"{Field.Code}" ] = code };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }
    }
}
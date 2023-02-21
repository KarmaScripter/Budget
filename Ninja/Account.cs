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
    /// <seealso cref="BudgetExecution.PRC" />
    /// <seealso cref="BudgetExecution.IAccount" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class Account : PRC, IAccount 
    {
        /// <summary>
        /// </summary>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public override string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        public override string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public override string ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public override string ProgramAreaName { get; set; }

        /// <summary>
        /// Gets or sets the name of the activity.
        /// </summary>
        /// <value>
        /// The name of the activity.
        /// </value>
        public override string ActivityName { get; set; }

        /// <summary>
        /// Gets or sets the agency activity.
        /// </summary>
        /// <value>
        /// The agency activity.
        /// </value>
        public string AgencyActivity { get; set; }

        /// <summary>
        /// Gets the field.
        /// </summary>
        public override string Code { get; set; }

        /// <summary>
        /// Gets the goal code.
        /// </summary>
        public override string GoalCode { get; set; }

        /// <summary>
        /// Gets the objective code.
        /// </summary>
        public override string ObjectiveCode { get; set; }

        /// <summary>
        /// Gets the national program code.
        /// </summary>
        public override string NpmCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the NPM.
        /// </summary>
        /// <value>
        /// The name of the NPM.
        /// </value>
        public override string NpmName { get; set; }

        /// <summary>
        /// </summary>
        public override Source Source { get; set; } 

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public override Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        public Account( )
        {
            Source = Source.Accounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Account( IQuery query ) 
            : base( query )
        {
            Source = Source.Accounts;
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "AccountsId" ]?.ToString(  ) );
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
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="dataBuilder">The data builder.</param>
        public Account( IDataModel dataBuilder ) 
            : base( dataBuilder )
        {
            Source = Source.Accounts;
            Record = dataBuilder?.Record;
            ID = int.Parse( Record?[ "AccountsId" ]?.ToString(  ) );
            NpmCode = Record?[ "NpmCode" ].ToString( );
            ProgramProjectCode = Record?[ "ProgramProjectCode" ].ToString( );
            ActivityCode = Record?[ "ActivityCode" ].ToString( );
            ProgramAreaCode = Record?[ "ProgramAreaCode" ].ToString( );
            GoalCode = Record?[ "GoalCode" ].ToString( );
            ObjectiveCode = Record?[ "ObjectiveCode" ].ToString( );
            ActivityCode = Record?[ "ActivityCode" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Account( DataRow dataRow )
        {
            Source = Source.Accounts;
            Record = dataRow;
            ID = int.Parse( Record[ "AccountsId" ]?.ToString(  ) );
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
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        public Account( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "AccountsId" ]?.ToString(  ) );
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
        /// Gets the arguments.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
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
        /// <returns></returns>
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
    }
}
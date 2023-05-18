// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Program Results Codes (PRCs) were established to account for and relate
    /// resources to the Agency's Strategic Plan goals and objectives, national program
    /// offices and responsibilities, and governmental functions. PRCs are created when
    /// the annual EPA Budget is submitted to Congress each February and then formally
    /// established in IFMS with the enactment of EPA's appropriation act. PRCs may be
    /// updated at any time.
    /// </summary>
    /// <seealso cref = "IProgramResultsCode"/>
    /// <seealso cref = "IProgramResultsCode"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class ProgramResultsCode : StatusOfFunds, IProgramResultsCode
    {
        /// <summary> Gets or sets the ID. </summary>
        /// <value> The ID. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        public override string EFY { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        public override string RpioName { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        public override string FundName { get; set; }

        /// <summary> Gets or sets the name of the ah. </summary>
        /// <value> The name of the ah. </value>
        public override string AhName { get; set; }

        /// <summary> Gets or sets the name of the org. </summary>
        /// <value> The name of the org. </value>
        public override string OrgName { get; set; }

        /// <summary> Gets or sets the name of the activity name. </summary>
        /// <value> The name of the activity name. </value>
        public override string ActivityName { get; set; }

        /// <summary> Gets or sets the name of the boc. </summary>
        /// <value> The name of the boc. </value>
        public override string BocName { get; set; }

        /// <summary> Gets or sets the name of the rc. </summary>
        /// <value> The name of the rc. </value>
        public override string RcName { get; set; }

        /// <summary> Gets or sets the NPM code. </summary>
        /// <value> The NPM code. </value>
        public override string NpmCode { get; set; }

        /// <summary> Gets or sets the name of the NPM. </summary>
        /// <value> The name of the NPM. </value>
        public override string NpmName { get; set; }

        /// <summary> Gets or sets the goal code. </summary>
        /// <value> The goal code. </value>
        public override string GoalCode { get; set; }

        /// <summary> Gets or sets the name of the goal. </summary>
        /// <value> The name of the goal. </value>
        public override string GoalName { get; set; }

        /// <summary> Gets or sets the objective code. </summary>
        /// <value> The objective code. </value>
        public override string ObjectiveCode { get; set; }

        /// <summary> Gets or sets the name of the objective. </summary>
        /// <value> The name of the objective. </value>
        public override string ObjectiveName { get; set; }

        /// <summary> Gets or sets the name of the program project. </summary>
        /// <value> The name of the program project. </value>
        public override string ProgramProjectName { get; set; }

        /// <summary> Gets or sets the name of the program area. </summary>
        /// <value> The name of the program area. </value>
        public override string ProgramAreaName { get; set; }

        /// <summary> Gets or sets the Provider. </summary>
        /// <value> The name of the Provider. </value>
        public override Provider Provider { get; set; }

        /// <summary> Gets or sets the Data. </summary>
        /// <value> The Data. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ProgramResultsCode"/>
        /// class.
        /// </summary>
        public ProgramResultsCode( )
        {
            Source = Source.StatusOfFunds;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ProgramResultsCode"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public ProgramResultsCode( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
            NpmName = Record[ "NpmName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ProgramResultsCode"/>
        /// class.
        /// </summary>
        /// <param name = "dataBuilder" > The builder. </param>
        public ProgramResultsCode( IDataModel dataBuilder )
            : this( dataBuilder.Query )
        {
            Record = dataBuilder.Record;
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
            NpmName = Record[ "NpmName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ProgramResultsCode"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The dataRow. </param>
        public ProgramResultsCode( DataRow dataRow )
        {
            Record = dataRow;
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AhCode = dataRow[ "AhCode" ].ToString( );
            AhName = dataRow[ "AhName" ].ToString( );
            OrgCode = dataRow[ "OrgCode" ].ToString( );
            OrgName = dataRow[ "OrgName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString( );
            NpmName = dataRow[ "NpmName" ].ToString( );
            GoalCode = dataRow[ "GoalCode" ].ToString( );
            GoalName = dataRow[ "GoalName" ].ToString( );
            ObjectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            ObjectiveName = dataRow[ "ObjectiveName" ].ToString( );
            Data = dataRow.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ProgramResultsCode"/>
        /// class.
        /// </summary>
        /// <param name = "dict" > </param>
        public ProgramResultsCode( IDictionary<string, object> dict )
        {
            Record = new DataBuilder( Source, dict )?.Record;
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
            NpmName = Record[ "NpmName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <summary> Gets or sets the budget level. </summary>
        /// <value> The budget level. </value>
        public override string BudgetLevel { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        public override string BFY { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        public override string RpioCode { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        public override string FundCode { get; set; }

        /// <summary> Gets or sets the ah code. </summary>
        /// <value> The ah code. </value>
        public override string AhCode { get; set; }

        /// <summary> Gets or sets the org code. </summary>
        /// <value> The org code. </value>
        public override string OrgCode { get; set; }

        /// <summary> Gets or sets the account code. </summary>
        /// <value> The account code. </value>
        public override string AccountCode { get; set; }

        /// <summary> Gets or sets the activity code. </summary>
        /// <value> The activity code. </value>
        public override string ActivityCode { get; set; }

        /// <summary> Gets or sets the boc code. </summary>
        /// <value> The boc code. </value>
        public override string BocCode { get; set; }

        /// <summary> Gets or sets the Amount. </summary>
        /// <value> double. </value>
        public override double Amount { get; set; }

        /// <summary> Gets or sets the rc code. </summary>
        /// <value> The rc code. </value>
        public override string RcCode { get; set; }

        /// <summary> Gets or sets the program project code. </summary>
        /// <value> The program project code. </value>
        public override string ProgramProjectCode { get; set; }

        /// <summary> Gets or sets the program area code. </summary>
        /// <value> The program area code. </value>
        public override string ProgramAreaCode { get; set; }

        /// <summary> Gets or sets the Source . </summary>
        /// <value> The name of the Source. </value>
        public override Source Source { get; set; }

        /// <summary> </summary>
        /// <param name = "dataRow" > </param>
        /// <returns> </returns>
        public override int GetId( DataRow dataRow )
        {
            try
            {
                return dataRow != null
                    ? int.Parse( dataRow[ 0 ].ToString( ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}
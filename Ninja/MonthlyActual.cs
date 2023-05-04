// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.Actual" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class MonthlyActual : Actual
    {
        /// <summary>
        /// Gets or sets the obligations.
        /// </summary>
        /// <value>
        /// The obligations.
        /// </value>
        public double Obligations { get; set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>
        /// The balance.
        /// </value>
        public double NetOutlays { get; set; }

        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public double GrossOutlays { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyActual"/> class.
        /// </summary>
        public MonthlyActual( )
        {
            Source = Source.MonthlyActuals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyActual"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public MonthlyActual( IQuery query )
            : base( query )
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
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            SubAppropriationName = Record[ "SubAppropriationName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            RpioActivityCode = Record[ "RpioActivityCode" ].ToString( );
            RpioActivityName = Record[ "RpioActivityName" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ULO = double.Parse( Record[ "ULO" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Balance = double.Parse( Record[ "Balance" ].ToString( ) ?? "0" );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyActual"/> class.
        /// </summary>
        /// <param name="builder"></param>
        public MonthlyActual( IDataModel builder )
            : base( builder )
        {
            Record = builder.Record;
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            SubAppropriationName = Record[ "SubAppropriationName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            RpioActivityCode = Record[ "RpioActivityCode" ].ToString( );
            RpioActivityName = Record[ "RpioActivityName" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ULO = double.Parse( Record[ "ULO" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Balance = double.Parse( Record[ "Balance" ].ToString( ) ?? "0" );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyActual"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public MonthlyActual( DataRow dataRow )
            : base( dataRow )
        {
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AhCode = dataRow[ "AhCode" ].ToString( );
            AhName = dataRow[ "AhName" ].ToString( );
            AppropriationCode = dataRow[ "AppropriationCode" ].ToString( );
            AppropriationName = dataRow[ "AppropriationName" ].ToString( );
            SubAppropriationCode = dataRow[ "SubAppropriationCode" ].ToString( );
            SubAppropriationName = dataRow[ "SubAppropriationName" ].ToString( );
            OrgCode = dataRow[ "OrgCode" ].ToString( );
            OrgName = dataRow[ "OrgName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            RpioActivityCode = dataRow[ "RpioActivityCode" ].ToString( );
            RpioActivityName = dataRow[ "RpioActivityName" ].ToString( );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            ULO = double.Parse( dataRow[ "ULO" ].ToString( ) ?? "0" );
            Obligations = double.Parse( dataRow[ "Obligations" ].ToString( ) ?? "0" );
            Balance = double.Parse( dataRow[ "Balance" ].ToString( ) ?? "0" );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            GoalCode = dataRow[ "GoalCode" ].ToString( );
            GoalName = dataRow[ "GoalName" ].ToString( );
            ObjectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            ObjectiveName = dataRow[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyActual"/> class.
        /// </summary>
        /// <param name="actual">The actual.</param>
        public MonthlyActual( IActual actual )
        {
            ID = actual.ID;
            BFY = actual.BFY;
            EFY = actual.EFY;
            FundCode = actual.FundCode;
            FundName = actual.FundName;
            RpioCode = actual.RpioCode;
            RpioName = actual.RpioName;
            AhCode = actual.AhCode;
            AhName = actual.AhName;
            AppropriationCode = actual.AppropriationCode;
            AppropriationName = actual.AppropriationName;
            SubAppropriationCode = actual.SubAppropriationCode;
            SubAppropriationName = actual.SubAppropriationName;
            OrgCode = actual.OrgCode;
            OrgName = actual.OrgName;
            AccountCode = actual.AccountCode;
            BocCode = actual.BocCode;
            BocName = actual.BocName;
            RpioActivityCode = actual.RpioActivityCode;
            RpioActivityName = actual.RpioActivityName;
            ProgramProjectCode = actual.ProgramProjectCode;
            ProgramProjectName = actual.ProgramProjectName;
            ULO = actual.ULO;
            Obligations = actual.Obligations;
            Balance = actual.Balance;
            ProgramAreaCode = actual.ProgramAreaCode;
            ProgramAreaName = actual.ProgramAreaName;
            GoalCode = actual.GoalCode;
            GoalName = actual.GoalName;
            ObjectiveCode = actual.ObjectiveCode;
            ObjectiveName = actual.ObjectiveName;
            TreasuryAccountCode = actual.TreasuryAccountCode;
            TreasuryAccountName = actual.TreasuryAccountName;
            BudgetAccountCode = actual.BudgetAccountCode;
            BudgetAccountName = actual.BudgetAccountName;
        }
    }
}
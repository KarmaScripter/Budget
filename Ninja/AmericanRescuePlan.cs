﻿// <copyright file = "AmericanRescuePlan.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// c
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class AmericanRescuePlan : StatusOfFunds
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the status of funds identifier.
        /// </summary>
        /// <value>
        /// The status of funds identifier.
        /// </value>
        public int StatusOfFundsId { get; set; }
        
        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public override string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public override string EFY { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the rpio.
        /// </summary>
        /// <value>
        /// The name of the rpio.
        /// </value>
        public override string RpioName { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the ah.
        /// </summary>
        /// <value>
        /// The name of the ah.
        /// </value>
        public override string AhName { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public override string FundName { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the org.
        /// </summary>
        /// <value>
        /// The name of the org.
        /// </value>
        public override string OrgName { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the boc.
        /// </summary>
        /// <value>
        /// The name of the boc.
        /// </value>
        public override string BocName { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        public override string ProgramProjectName { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public override string ProgramAreaName { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the rc.
        /// </summary>
        /// <value>
        /// The name of the rc.
        /// </value>
        public override string RcName { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public override double Amount { get; set; }

        /// <summary>
        /// Gets or sets the budgeted.
        /// </summary>
        /// <value>
        /// The budgeted.
        /// </value>
        public override double Budgeted { get; set; }

        /// <summary>
        /// Gets or sets the posted.
        /// </summary>
        /// <value>
        /// The posted.
        /// </value>
        public override double Posted { get; set; }

        /// <summary>
        /// Gets or sets the open commitments.
        /// </summary>
        /// <value>
        /// The open commitments.
        /// </value>
        public override double OpenCommitments { get; set; }

        /// <summary>
        /// Gets or sets the ulo.
        /// </summary>
        /// <value>
        /// The ulo.
        /// </value>
        public override double ULO { get; set; }

        /// <summary>
        /// Gets or sets the expenditures.
        /// </summary>
        /// <value>
        /// The expenditures.
        /// </value>
        public override double Expenditures { get; set; }

        /// <summary>
        /// Gets or sets the obligations.
        /// </summary>
        /// <value>
        /// The obligations.
        /// </value>
        public override double Obligations { get; set; }

        /// <summary>
        /// Gets or sets the used.
        /// </summary>
        /// <value>
        /// The used.
        /// </value>
        public override double Used { get; set; }

        /// <summary>
        /// Gets or sets the available.
        /// </summary>
        /// <value>
        /// The available.
        /// </value>
        public override double Available { get; set; }

        /// <summary>
        /// Gets or sets the NPM code.
        /// </summary>
        /// <value>
        /// The NPM code.
        /// </value>
        public override string NpmCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the NPM.
        /// </summary>
        /// <value>
        /// The name of the NPM.
        /// </value>
        public override string NpmName { get; set; }
        
        /// <summary>
        /// Gets or sets the treasury agency code.
        /// </summary>
        /// <value>
        /// The treasury agency code.
        /// </value>
        public override string TreasuryAccountName { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public override string TreasuryAccountCode { get; set; }
        
        /// <summary>
        /// Gets or sets the budget account code.
        /// </summary>
        /// <value>
        /// The budget account code.
        /// </value>
        public override string BudgetAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget account.
        /// </summary>
        /// <value>
        /// The name of the budget account.
        /// </value>
        public override string BudgetAccountName { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; }

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
        /// Initializes a new instance of the <see cref="AmericanRescuePlan"/> class.
        /// </summary>
        public AmericanRescuePlan( )
        {
            Source = Source.AmericanRescuePlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmericanRescuePlan"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AmericanRescuePlan( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "AmericanRescuePlanId" ].ToString(  ) ?? "0" );
            BFY =  Record[ "BFY" ].ToString( );
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
            Amount = double.Parse( Record[ "Amount" ].ToString(  ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString(  ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString(  ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            ULO = double.Parse( Record[ "ULO" ].ToString(  ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString(  ) ?? "0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString(  ) ?? "0" );
            Used = double.Parse( Record[ "Used" ].ToString(  ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString(  ) ?? "0" );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString(  );
            NpmName = Record[ "NpmName" ].ToString(  );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmericanRescuePlan"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public AmericanRescuePlan( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "AmericanRescuePlanId" ].ToString(  ) ?? "0" );
            BFY =  Record[ "BFY" ].ToString( );
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
            Amount = double.Parse( Record[ "Amount" ].ToString(  ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString(  ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString(  ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            ULO = double.Parse( Record[ "ULO" ].ToString(  ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString(  ) ?? "0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString(  ) ?? "0" );
            Used = double.Parse( Record[ "Used" ].ToString(  ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString(  ) ?? "0" );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString(  );
            NpmName = Record[ "NpmName" ].ToString(  );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmericanRescuePlan"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AmericanRescuePlan( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "AmericanRescuePlanId" ].ToString(  ) ?? "0" );
            BFY =  dataRow[ "BFY" ].ToString( );
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
            Amount = double.Parse( dataRow[ "Amount" ].ToString(  ) ?? "0" );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString(  ) ?? "0" );
            Posted = double.Parse( dataRow[ "Posted" ].ToString(  ) ?? "0" );
            OpenCommitments = double.Parse( dataRow[ "OpenCommitments" ].ToString( ) ?? "0" );
            ULO = double.Parse( dataRow[ "ULO" ].ToString(  ) ?? "0" );
            Obligations = double.Parse( dataRow[ "Obligations" ].ToString(  ) ?? "0" );
            Expenditures = double.Parse( dataRow[ "Expenditures" ].ToString(  ) ?? "0" );
            Used = double.Parse( dataRow[ "Used" ].ToString(  ) ?? "0" );
            Available = double.Parse( dataRow[ "Available" ].ToString(  ) ?? "0" );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString(  );
            NpmName = dataRow[ "NpmName" ].ToString(  );
            GoalCode = dataRow[ "GoalCode" ].ToString( );
            GoalName = dataRow[ "GoalName" ].ToString( );
            ObjectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            ObjectiveName = dataRow[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString(  );
        }
    }
}

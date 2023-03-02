// <copyright file = "CompassLevel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class CompassLevel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public string EFY { get; set; }

        /// <summary>
        /// Gets or sets the treasury symbol.
        /// </summary>
        /// <value>
        /// The treasury symbol.
        /// </value>
        public string TreasurySymbol { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public string FundName { get; set; }
        
        /// <summary>
        /// Gets or sets the budget level.
        /// </summary>
        /// <value>
        /// The budget level.
        /// </value>
        public string BudgetLevel { get; set; }

        /// <summary>
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public string RpioCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the rpio.
        /// </summary>
        /// <value>
        /// The name of the rpio.
        /// </value>
        public string RpioName { get; set; }

        /// <summary>
        /// Gets or sets the account code.
        /// </summary>
        /// <value>
        /// The account code.
        /// </value>
        public string AccountCode { get; set; }

        /// <summary>
        /// Gets or sets the program project code.
        /// </summary>
        /// <value>
        /// The program project code.
        /// </value>
        public string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        public string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public string ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public string ProgramAreaName { get; set; }

        /// <summary>
        /// Gets or sets the total authority.
        /// </summary>
        /// <value>
        /// The total authority.
        /// </value>
        public double Authority { get; set; }

        /// <summary>
        /// Gets or sets the total budgetd.
        /// </summary>
        /// <value>
        /// The total budgeted.
        /// </value>
        public double Budgeted { get; set; }

        /// <summary>
        /// Gets or sets the posted amount.
        /// </summary>
        /// <value>
        /// The posted amount.
        /// </value>
        public double Posted { get; set; }

        /// <summary>
        /// Gets or sets the carry in.
        /// </summary>
        /// <value>
        /// The carry in.
        /// </value>
        public double CarryoverIn { get; set; }

        /// <summary>
        /// Gets or sets the carry out.
        /// </summary>
        /// <value>
        /// The carry out.
        /// </value>
        public double CarryoverOut { get; set; }
        
        /// <summary>
        /// Gets or sets the actual recoveries.
        /// </summary>
        /// <value>
        /// The actual recoveries.
        /// </value>
        public double Recoveries { get; set; }

        /// <summary>
        /// Gets or sets the actual reimbursements.
        /// </summary>
        /// <value>
        /// The actual reimbursements.
        /// </value>
        public double Reimbursements { get; set; }

        /// <summary>
        /// Gets or sets the open commitments.
        /// </summary>
        /// <value>
        /// The open commitments.
        /// </value>
        public double OpenCommitments { get; set; }

        /// <summary>
        /// Gets or sets the obligations.
        /// </summary>
        /// <value>
        /// The obligations.
        /// </value>
        public double Obligations { get; set; }

        /// <summary>
        /// Gets or sets the ulo.
        /// </summary>
        /// <value>
        /// The ulo.
        /// </value>
        public double UnliquidatedObligations { get; set; }

        /// <summary>
        /// Gets or sets the expenditures.
        /// </summary>
        /// <value>
        /// The expenditures.
        /// </value>
        public double Expenditures { get; set; }

        /// <summary>
        /// Gets or sets the available.
        /// </summary>
        /// <value>
        /// The available.
        /// </value>
        public double Available { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public  string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the treasury agency code.
        /// </summary>
        /// <value>
        /// The treasury agency code.
        /// </value>
        public  string TreasuryAccountName { get; set; }

        /// <summary>
        /// Gets or sets the budget account code.
        /// </summary>
        /// <value>
        /// The budget account code.
        /// </value>
        public string BudgetAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget account.
        /// </summary>
        /// <value>
        /// The name of the budget account.
        /// </value>
        public  string BudgetAccountName { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassLevel"/> class.
        /// </summary>
        public CompassLevel( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassLevel"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CompassLevel( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CompassLevel" ].ToString(  ) ?? "0" );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString(  );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            Authority = double.Parse( Record[ "Authority" ].ToString(  ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString(  ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString(  ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString(  ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "ULO" ].ToString(  ) ?? "0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString(  ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString(  ) ?? "0" );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassLevel"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CompassLevel( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CompassLevel" ].ToString(  ) ?? "0" );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString(  );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            Authority = double.Parse( Record[ "Authority" ].ToString(  ) ?? "0");
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString(  ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString(  ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString(  ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "ULO" ].ToString(  ) ?? "0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString(  ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString(  ) ?? "0" );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassLevel"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CompassLevel( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CompassLevel" ].ToString(  ) ?? "0" );
            BFY =  dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            BudgetLevel = dataRow[ "BudgetLevel" ].ToString(  );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            Authority = double.Parse( dataRow[ "Authority" ].ToString(  ) ?? "0");
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString(  ) ?? "0" );
            Posted = double.Parse( dataRow[ "Posted" ].ToString(  ) ?? "0" );
            OpenCommitments = double.Parse( dataRow[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( dataRow[ "Obligations" ].ToString(  ) ?? "0" );
            UnliquidatedObligations = double.Parse( dataRow[ "ULO" ].ToString(  ) ?? "0" );
            Expenditures = double.Parse( dataRow[ "Expenditures" ].ToString(  ) ?? "0" );
            Available = double.Parse( dataRow[ "Available" ].ToString(  ) ?? "0" );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString(  );
        }
    }
}
// <copyright file = "CompassOutlay.cs" company = "Terry D. Eppler">
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
    public class CompassOutlay
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
        /// Gets or sets the appropriation code.
        /// </summary>
        /// <value>
        /// The appropriation code.
        /// </value>
        public string AppropriationCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the appropriation.
        /// </summary>
        /// <value>
        /// The name of the appropriation.
        /// </value>
        public string AppropriationName { get; set; }

        /// <summary>
        /// Gets or sets the treasury symbol.
        /// </summary>
        /// <value>
        /// The treasury symbol.
        /// </value>
        public string TreasurySymbol { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the treasury account.
        /// </summary>
        /// <value>
        /// The name of the treasury account.
        /// </value>
        public string TreasuryAccountName { get; set; }

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
        public string BudgetAccountName { get; set; }
        
        /// <summary>
        /// Gets or sets the month processed.
        /// </summary>
        /// <value>
        /// The month processed.
        /// </value>
        public string MonthProcessed { get; set; }

        /// <summary>
        /// Gets or sets the total obligations.
        /// </summary>
        /// <value>
        /// The total obligations.
        /// </value>
        public double TotalObligations { get; set; }

        /// <summary>
        /// Gets or sets the unliquidated obligations.
        /// </summary>
        /// <value>
        /// The unliquidated obligations.
        /// </value>
        public double UnliquidatedObligations { get; set; }

        /// <summary>
        /// Gets or sets the obligations paid.
        /// </summary>
        /// <value>
        /// The obligations paid.
        /// </value>
        public double ObligationsPaid { get; set; }
        
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
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        public CompassOutlay( )
        {
            Source = Source.CompassOutlays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CompassOutlay( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
            MonthProcessed = Record[ "MonthProcessed" ].ToString(  );
            TotalObligations = double.Parse( Record[ "TotalObligations" ].ToString(  ) );
            ObligationsPaid = double.Parse( Record[ "ObligationsPaid" ].ToString(  ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString(  ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CompassOutlay( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
            MonthProcessed = Record[ "MonthProcessed" ].ToString(  );
            TotalObligations = double.Parse( Record[ "TotalObligations" ].ToString(  ) );
            ObligationsPaid = double.Parse( Record[ "ObligationsPaid" ].ToString(  ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString(  ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CompassOutlay( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
            MonthProcessed = Record[ "MonthProcessed" ].ToString(  );
            TotalObligations = double.Parse( Record[ "TotalObligations" ].ToString(  ) );
            ObligationsPaid = double.Parse( Record[ "ObligationsPaid" ].ToString(  ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString(  ) ?? "0" );
        }
    }
}

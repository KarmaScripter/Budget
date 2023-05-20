// <copyright file = "CompassOutlay.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.BudgetUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class CompassOutlay : BudgetUnit 
    {
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
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            MonthProcessed = Record[ "MonthProcessed" ].ToString( );
            TotalObligations = double.Parse( Record[ "TotalObligations" ].ToString( ) ?? "0" );
            ObligationsPaid = double.Parse( Record[ "ObligationsPaid" ].ToString( ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CompassOutlay( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            MonthProcessed = Record[ "MonthProcessed" ].ToString( );
            TotalObligations = double.Parse( Record[ "TotalObligations" ].ToString( ) ?? "0" );
            ObligationsPaid = double.Parse( Record[ "ObligationsPaid" ].ToString( ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CompassOutlay( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            MonthProcessed = Record[ "MonthProcessed" ].ToString( );
            TotalObligations = double.Parse( Record[ "TotalObligations" ].ToString( ) ?? "0" );
            ObligationsPaid = double.Parse( Record[ "ObligationsPaid" ].ToString( ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        /// <param name="outlay">The outlay.</param>
        public CompassOutlay( CompassOutlay outlay )
        {
            ID = outlay.ID;
            BFY = outlay.BFY;
            EFY = outlay.EFY;
            FundCode = outlay.FundCode;
            FundName = outlay.FundName;
            AppropriationCode = outlay.AppropriationCode;
            AppropriationName = outlay.AppropriationName;
            TreasuryAccountCode = outlay.TreasuryAccountCode;
            TreasuryAccountName = outlay.TreasuryAccountName;
            BudgetAccountCode = outlay.BudgetAccountCode;
            BudgetAccountName = outlay.BudgetAccountName;
            MonthProcessed = outlay.MonthProcessed;
            TotalObligations = outlay.TotalObligations;
            ObligationsPaid = outlay.ObligationsPaid;
            UnliquidatedObligations = outlay.UnliquidatedObligations;
        }
    }
}
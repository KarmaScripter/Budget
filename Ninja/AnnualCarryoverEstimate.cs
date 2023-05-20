// <copyright file = "AnnualCarryoverEstimate.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.BudgetUnit" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AnnualCarryoverEstimate : BudgetUnit 
    {
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
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public double Amount { get; set; }

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
        /// Gets or sets the available.
        /// </summary>
        /// <value>
        /// The available.
        /// </value>
        public double Available { get; set; }

        /// <summary>
        /// Gets or sets the estimate.
        /// </summary>
        /// <value>
        /// The estimate.
        /// </value>
        public double Estimate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnualCarryoverEstimate"/> class.
        /// </summary>
        public AnnualCarryoverEstimate( )
        {
            Source = Source.AnnualCarryoverEstimates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnualCarryoverEstimate"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AnnualCarryoverEstimate( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "AnnualCarryoverEstimatesId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnualCarryoverEstimate"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public AnnualCarryoverEstimate( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "AnnualCarryoverEstimatesId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnualCarryoverEstimate"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AnnualCarryoverEstimate( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "AnnualCarryoverEstimatesId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( dataRow[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( dataRow[ "Obligations" ].ToString( ) ?? "0" );
            Available = double.Parse( dataRow[ "Available" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnualCarryoverEstimate"/> class.
        /// </summary>
        /// <param name="carryover">The carryover.</param>
        public AnnualCarryoverEstimate( AnnualCarryoverEstimate carryover )
            : this( )
        {
            ID = carryover.ID;
            BFY = carryover.BFY;
            EFY = carryover.EFY;
            FundCode = carryover.FundCode;
            FundName = carryover.FundName;
            RpioCode = carryover.RpioCode;
            RpioName = carryover.RpioName;
            Amount = carryover.Amount;
            OpenCommitments = carryover.OpenCommitments;
            Obligations = carryover.Obligations;
            Available = carryover.Available;
            TreasuryAccountCode = carryover.TreasuryAccountCode;
            TreasuryAccountName = carryover.TreasuryAccountName;
            BudgetAccountCode = carryover.BudgetAccountCode;
            BudgetAccountName = carryover.BudgetAccountName;
        }
    }
}
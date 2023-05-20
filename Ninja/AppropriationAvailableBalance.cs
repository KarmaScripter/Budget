// <copyright file = "AppropriationAvailableBalance.cs" company = "Terry D.Eppler">
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
    /// <seealso cref="BudgetExecution.PRC" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class AppropriationAvailableBalance : PRC 
    {
        /// <summary>
        /// Gets or sets the authority.
        /// </summary>
        /// <value>
        /// The authority.
        /// </value>
        public double Authority { get; set; }

        /// <summary>
        /// Gets or sets the budgeted.
        /// </summary>
        /// <value>
        /// The budgeted.
        /// </value>
        public double Budgeted { get; set; }

        /// <summary>
        /// Gets or sets the carryover.
        /// </summary>
        /// <value>
        /// The carryover.
        /// </value>
        public double Carryover { get; set; }

        /// <summary>
        /// Gets or sets the reimbursements.
        /// </summary>
        /// <value>
        /// The reimbursements.
        /// </value>
        public double Reimbursements { get; set; }

        /// <summary>
        /// Gets or sets the recoveries.
        /// </summary>
        /// <value>
        /// The recoveries.
        /// </value>
        public double Recoveries { get; set; }

        /// <summary>
        /// Gets or sets the used.
        /// </summary>
        /// <value>
        /// The used.
        /// </value>
        public double Used { get; set; }

        /// <summary>
        /// Gets or sets the available.
        /// </summary>
        /// <value>
        /// The available.
        /// </value>
        public double Available { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationAvailableBalance"/> class.
        /// </summary>
        public AppropriationAvailableBalance( )
        {
            Source = Source.AppropriationAvailableBalances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationAvailableBalance"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AppropriationAvailableBalance( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            Authority = double.Parse( Record[ "Authority" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Carryover = double.Parse( Record[ "Carryover" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationAvailableBalance"/> class.
        /// </summary>
        /// <param name="builder"></param>
        public AppropriationAvailableBalance( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            Authority = double.Parse( Record[ "Authority" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Carryover = double.Parse( Record[ "Carryover" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationAvailableBalance" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AppropriationAvailableBalance( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            Authority = double.Parse( dataRow[ "Authority" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString( ) ?? "0" );
            Carryover = double.Parse( dataRow[ "Carryover" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( dataRow[ "Reimbursements" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( dataRow[ "Recoveries" ].ToString( ) ?? "0" );
            Used = double.Parse( dataRow[ "Used" ].ToString( ) ?? "0" );
            Available = double.Parse( dataRow[ "Available" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationAvailableBalance"/> class.
        /// </summary>
        /// <param name="balance">The balance.</param>
        public AppropriationAvailableBalance( AppropriationAvailableBalance balance )
        {
            ID = balance.ID;
            BFY = balance.BFY;
            EFY = balance.EFY;
            FundCode = balance.FundCode;
            FundName = balance.FundName;
            BudgetAccountCode = balance.BudgetAccountCode;
            BudgetAccountName = balance.BudgetAccountName;
            TreasuryAccountCode = balance.TreasuryAccountCode;
            TreasuryAccountName = balance.TreasuryAccountName;
            Authority = balance.Authority;
            Budgeted = balance.Budgeted;
            Carryover = balance.Carryover;
            Reimbursements = balance.Reimbursements;
            Recoveries = balance.Recoveries;
            Used = balance.Used;
            Available = balance.Available;
        }
    }
}
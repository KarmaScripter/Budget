// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class MonthlyLedgerAccountBalance : BudgetUnit
    {

        /// <summary> Gets or sets the fiscal year. </summary>
        /// <value> The fiscal year. </value>
        public string FiscalYear { get; set; }

        /// <summary> Gets or sets the ledger account. </summary>
        /// <value> The ledger account. </value>
        public string LedgerAccount { get; set; }

        /// <summary> Gets or sets the name of the ledger. </summary>
        /// <value> The name of the ledger. </value>
        public string LedgerName { get; set; }

        /// <summary> Gets or sets the apportionment account code. </summary>
        /// <value> The apportionment account code. </value>
        public string ApportionmentAccountCode { get; set; }

        /// <summary> Gets or sets the fiscal month. </summary>
        /// <value> The fiscal month. </value>
        public string FiscalMonth { get; set; }

        /// <summary> Gets or sets the credit balance. </summary>
        /// <value> The credit balance. </value>
        public double CreditBalance { get; set; }

        /// <summary> Gets or sets the debit balance. </summary>
        /// <value> The debit balance. </value>
        public double DebitBalance { get; set; }

        /// <summary> Gets or sets the year to date amount. </summary>
        /// <value> The year to date amount. </value>
        public double YearToDateAmount { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="MonthlyLedgerAccountBalance"/>
        /// class.
        /// </summary>
        public MonthlyLedgerAccountBalance( )
        {
            Source = Source.MonthlyLedgerAccountBalances;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="MonthlyLedgerAccountBalance"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public MonthlyLedgerAccountBalance( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            LedgerAccount = Record[ "LedgerAccount" ].ToString( );
            LedgerName = Record[ "LedgerName" ].ToString( );
            CreditBalance = double.Parse( Record[ "CreditBalance" ].ToString( ) ?? "0" );
            DebitBalance = double.Parse( Record[ "DebitBalance" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="MonthlyLedgerAccountBalance"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public MonthlyLedgerAccountBalance( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            LedgerAccount = Record[ "LedgerAccount" ].ToString( );
            LedgerName = Record[ "LedgerName" ].ToString( );
            CreditBalance = double.Parse( Record[ "CreditBalance" ].ToString( ) ?? "0" );
            DebitBalance = double.Parse( Record[ "DebitBalance" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="MonthlyLedgerAccountBalance"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public MonthlyLedgerAccountBalance( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            LedgerAccount = dataRow[ "LedgerAccount" ].ToString( );
            LedgerName = dataRow[ "LedgerName" ].ToString( );
            CreditBalance = double.Parse( dataRow[ "CreditBalance" ].ToString( ) ?? "0" );
            DebitBalance = double.Parse( dataRow[ "DebitBalance" ].ToString( ) ?? "0" );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }

        public MonthlyLedgerAccountBalance( MonthlyLedgerAccountBalance account )
        {
            ID = account.ID;
            BFY = account.BFY;
            EFY = account.EFY;
            FundCode = account.FundCode;
            FundName = account.FundName;
            LedgerAccount = account.LedgerAccount;
            LedgerName = account.LedgerName;
            CreditBalance = account.CreditBalance;
            DebitBalance = account.DebitBalance;
            TreasuryAccountCode = account.TreasuryAccountCode;
            TreasuryAccountName = account.TreasuryAccountName;
            BudgetAccountCode = account.BudgetAccountCode;
            BudgetAccountName = account.BudgetAccountName;
        }
    }
}
// <copyright file = "GeneralLedgerAccount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class GeneralLedgerAccount : IGeneralLedgerAccount
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
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string AccountClassification { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public string ShortName { get; set; }
        
        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        /// <value>
        /// The account number.
        /// </value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the name of the account.
        /// </summary>
        /// <value>
        /// The name of the account.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the beginning balance.
        /// </summary>
        /// <value>
        /// The beginning balance.
        /// </value>
        public string NormalBalance { get; set; }

        /// <summary>
        /// Gets or sets the credit balance.
        /// </summary>
        /// <value>
        /// The credit balance.
        /// </value>
        public string RealOrClosingAccount { get; set; }

        /// <summary>
        /// Gets or sets the summary account.
        /// </summary>
        /// <value>
        /// The summary account.
        /// </value>
        public string SummaryAccount { get; set; }

        /// <summary>
        /// Gets or sets the cash account.
        /// </summary>
        /// <value>
        /// The cash account.
        /// </value>
        public string CashAccount { get; set; }

        /// <summary>
        /// Gets or sets the reportable account.
        /// </summary>
        /// <value>
        /// The reportable account.
        /// </value>
        public string ReportableAccount { get; set; }

        /// <summary>
        /// Gets or sets the cost allocation indicator.
        /// </summary>
        /// <value>
        /// The cost allocation indicator.
        /// </value>
        public string CostAllocationIndicator { get; set; }

        /// <summary>
        /// Gets or sets the federal non federal.
        /// </summary>
        /// <value>
        /// The federal non federal.
        /// </value>
        public string FederalNonFederal { get; set; }

        /// <summary>
        /// Gets or sets the attribute value.
        /// </summary>
        /// <value>
        /// The attribute value.
        /// </value>
        public string AttributeValue { get; set; }
        
        /// <summary>
        /// Gets or sets the debit balance.
        /// </summary>
        /// <value>
        /// The debit balance.
        /// </value>
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets the closing amount.
        /// </summary>
        /// <value>
        /// The closing amount.
        /// </value>
        public string Deposit { get; set; }
        
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
        /// Initializes a new instance of the <see cref="GeneralLedgerAccount"/> class.
        /// </summary>
        public GeneralLedgerAccount( )
        {
            Source = Source.GeneralLedgerAccounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralLedgerAccount"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public GeneralLedgerAccount( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "GeneralLedgerAccountsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Number = Record[ "Number" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            NormalBalance = Record[ "NormalBalance" ].ToString( );
            ReportableAccount = Record[ "ReportableAccount" ].ToString( );
            SummaryAccount = Record[ "SummaryAccount" ].ToString( );
            AccountClassification = Record[ "AccountClassification" ].ToString( );
            CashAccount = Record[ "CashAccount" ].ToString( );
            ReportableAccount = Record[ "ReportableAccount" ].ToString( );
            RealOrClosingAccount = Record[ "RealOrClosingAccount" ].ToString( );
            FederalNonFederal = Record[ "FederalNonFederal" ].ToString( );
            AttributeValue = Record[ "AttributeValue" ].ToString( );
            Usage = Record[ "Usage" ].ToString( );
            Deposit = Record[ "Deposit" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralLedgerAccount"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public GeneralLedgerAccount( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "GeneralLedgerAccountsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Number = Record[ "Number" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            NormalBalance = Record[ "NormalBalance" ].ToString( );
            ReportableAccount = Record[ "ReportableAccount" ].ToString( );
            SummaryAccount = Record[ "SummaryAccount" ].ToString( );
            AccountClassification = Record[ "AccountClassification" ].ToString( );
            CashAccount = Record[ "CashAccount" ].ToString( );
            ReportableAccount = Record[ "ReportableAccount" ].ToString( );
            RealOrClosingAccount = Record[ "RealOrClosingAccount" ].ToString( );
            FederalNonFederal = Record[ "FederalNonFederal" ].ToString( );
            AttributeValue = Record[ "AttributeValue" ].ToString( );
            Usage = Record[ "Usage" ].ToString( );
            Deposit = Record[ "Deposit" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralLedgerAccount"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public GeneralLedgerAccount( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "GeneralLedgerAccountsId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            Number = dataRow[ "Number" ].ToString( );
            Name = dataRow[ "Name" ].ToString( );
            ShortName = dataRow[ "ShortName" ].ToString( );
            NormalBalance = dataRow[ "NormalBalance" ].ToString( );
            ReportableAccount = dataRow[ "ReportableAccount" ].ToString( );
            SummaryAccount = dataRow[ "SummaryAccount" ].ToString( );
            AccountClassification = dataRow[ "AccountClassification" ].ToString( );
            CashAccount = dataRow[ "CashAccount" ].ToString( );
            ReportableAccount = dataRow[ "ReportableAccount" ].ToString( );
            RealOrClosingAccount = dataRow[ "RealOrClosingAccount" ].ToString( );
            FederalNonFederal = dataRow[ "FederalNonFederal" ].ToString( );
            AttributeValue = dataRow[ "AttributeValue" ].ToString( );
            Usage = dataRow[ "Usage" ].ToString( );
            Deposit = dataRow[ "Deposit" ].ToString( );
        }
    }
}

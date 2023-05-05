// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IGeneralLedgerAccount
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int ID { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        string BFY { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        string AccountClassification { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        /// <value>
        /// The account number.
        /// </value>
        string Number { get; set; }

        /// <summary>
        /// Gets or sets the name of the account.
        /// </summary>
        /// <value>
        /// The name of the account.
        /// </value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the beginning balance.
        /// </summary>
        /// <value>
        /// The beginning balance.
        /// </value>
        string NormalBalance { get; set; }

        /// <summary>
        /// Gets or sets the credit balance.
        /// </summary>
        /// <value>
        /// The credit balance.
        /// </value>
        string RealOrClosingAccount { get; set; }

        /// <summary>
        /// Gets or sets the summary account.
        /// </summary>
        /// <value>
        /// The summary account.
        /// </value>
        string SummaryAccount { get; set; }

        /// <summary>
        /// Gets or sets the cash account.
        /// </summary>
        /// <value>
        /// The cash account.
        /// </value>
        string CashAccount { get; set; }

        /// <summary>
        /// Gets or sets the reportable account.
        /// </summary>
        /// <value>
        /// The reportable account.
        /// </value>
        string ReportableAccount { get; set; }

        /// <summary>
        /// Gets or sets the cost allocation indicator.
        /// </summary>
        /// <value>
        /// The cost allocation indicator.
        /// </value>
        string CostAllocationIndicator { get; set; }

        /// <summary>
        /// Gets or sets the federal non federal.
        /// </summary>
        /// <value>
        /// The federal non federal.
        /// </value>
        string FederalNonFederal { get; set; }

        /// <summary>
        /// Gets or sets the attribute value.
        /// </summary>
        /// <value>
        /// The attribute value.
        /// </value>
        string AttributeValue { get; set; }

        /// <summary>
        /// Gets or sets the debit balance.
        /// </summary>
        /// <value>
        /// The debit balance.
        /// </value>
        string Usage { get; set; }

        /// <summary>
        /// Gets or sets the closing amount.
        /// </summary>
        /// <value>
        /// The closing amount.
        /// </value>
        string Deposit { get; set; }
    }}

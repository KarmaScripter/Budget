// <copyright file = "ILedgerAccountBalance.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface ILedgerAccountBalance
    {
        /// <summary>
        /// Gets or sets the fiscal year.
        /// </summary>
        /// <value>
        /// The fiscal year.
        /// </value>
        string FiscalYear { get; set; }

        /// <summary>
        /// Gets or sets the ledger account.
        /// </summary>
        /// <value>
        /// The ledger account.
        /// </value>
        string LedgerAccount { get; set; }

        /// <summary>
        /// Gets or sets the name of the ledger.
        /// </summary>
        /// <value>
        /// The name of the ledger.
        /// </value>
        string LedgerName { get; set; }

        /// <summary>
        /// Gets or sets the apportionment account code.
        /// </summary>
        /// <value>
        /// The apportionment account code.
        /// </value>
        string ApportionmentAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the fiscal month.
        /// </summary>
        /// <value>
        /// The fiscal month.
        /// </value>
        string FiscalMonth { get; set; }

        /// <summary>
        /// Gets or sets the credit balance.
        /// </summary>
        /// <value>
        /// The credit balance.
        /// </value>
        double CreditBalance { get; set; }

        /// <summary>
        /// Gets or sets the debit balance.
        /// </summary>
        /// <value>
        /// The debit balance.
        /// </value>
        double DebitBalance { get; set; }

        /// <summary>
        /// Gets or sets the year to date amount.
        /// </summary>
        /// <value>
        /// The year to date amount.
        /// </value>
        double YearToDateAmount { get; set; }

        /// <summary>
        /// </summary>
        int ID { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        string EFY { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        string FundName { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the treasury account.
        /// </summary>
        /// <value>
        /// The name of the treasury account.
        /// </value>
        string TreasuryAccountName { get; set; }

        /// <summary>
        /// Gets or sets the budget account code.
        /// </summary>
        /// <value>
        /// The budget account code.
        /// </value>
        string BudgetAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget account.
        /// </summary>
        /// <value>
        /// The name of the budget account.
        /// </value>
        string BudgetAccountName { get; set; }
    }
}
// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IAppropriationLevelAuthority
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
        /// Gets or sets the budgeted.
        /// </summary>
        /// <value>
        /// The budgeted.
        /// </value>
        double Budgeted { get; set; }

        /// <summary>
        /// Gets or sets the carry over.
        /// </summary>
        /// <value>
        /// The carry over.
        /// </value>
        double Carryover { get; set; }

        /// <summary>
        /// Gets or sets the total reimbursements.
        /// </summary>
        /// <value>
        /// The total reimbursements.
        /// </value>
        double Reimbursements { get; set; }

        /// <summary>
        /// Gets or sets the total recoveries.
        /// </summary>
        /// <value>
        /// The total recoveries.
        /// </value>
        double Recoveries { get; set; }

        /// <summary>
        /// Gets or sets the total authority.
        /// </summary>
        /// <value>
        /// The total authority.
        /// </value>
        double Authority { get; set; }
    }
}
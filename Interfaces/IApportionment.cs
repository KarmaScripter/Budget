// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    public interface IApportionment
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        int ID { get; set; }

        /// <summary> Gets or sets the fiscal year. </summary>
        /// <value> The fiscal year. </value>
        string FiscalYear { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        string EFY { get; set; }

        /// <summary> Gets or sets the treasury appropriation fund symbol. </summary>
        /// <value> The treasury appropriation fund symbol. </value>
        string TreasuryAccountCode { get; set; }

        /// <summary> Gets or sets the name of the treasury appropriation fund symbol. </summary>
        /// <value> The name of the treasury appropriation fund symbol. </value>
        string TreasuryAccountName { get; set; }

        /// <summary> Gets or sets the apportionment account code. </summary>
        /// <value> The apportionment account code. </value>
        string ApportionmentAccountCode { get; set; }

        /// <summary> Gets or sets the name of the apportionment account. </summary>
        /// <value> The name of the apportionment account. </value>
        string ApportionmentAccountName { get; set; }

        /// <summary> Gets or sets the type of the availability. </summary>
        /// <value> The type of the availability. </value>
        string AvailabilityType { get; set; }

        /// <summary> Gets or sets the budget account code. </summary>
        /// <value> The budget account code. </value>
        string BudgetAccountCode { get; set; }

        /// <summary> Gets or sets the name of the budget account. </summary>
        /// <value> The name of the budget account. </value>
        string BudgetAccountName { get; set; }

        /// <summary> Gets or sets the approval date. </summary>
        /// <value> The approval date. </value>
        DateOnly ApprovalDate { get; set; }

        /// <summary> Gets or sets the line number. </summary>
        /// <value> The line number. </value>
        string LineNumber { get; set; }

        /// <summary> Gets or sets the name of the line. </summary>
        /// <value> The name of the line. </value>
        string LineName { get; set; }

        /// <summary> Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        double Amount { get; set; }
    }
}
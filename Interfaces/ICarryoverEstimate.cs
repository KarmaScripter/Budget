// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution;

public interface ICarryoverEstimate
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
    /// Gets or sets the rpio code.
    /// </summary>
    /// <value>
    /// The rpio code.
    /// </value>
    string RpioCode { get; set; }

    /// <summary>
    /// Gets or sets the name of the rpio.
    /// </summary>
    /// <value>
    /// The name of the rpio.
    /// </value>
    string RpioName { get; set; }

    /// <summary>
    /// Gets or sets the amount.
    /// </summary>
    /// <value>
    /// The amount.
    /// </value>
    double Amount { get; set; }

    /// <summary>
    /// Gets or sets the open commitments.
    /// </summary>
    /// <value>
    /// The open commitments.
    /// </value>
    double OpenCommitments { get; set; }

    /// <summary>
    /// Gets or sets the obligations.
    /// </summary>
    /// <value>
    /// The obligations.
    /// </value>
    double Obligations { get; set; }

    /// <summary>
    /// Gets or sets the available.
    /// </summary>
    /// <value>
    /// The available.
    /// </value>
    double Available { get; set; }

    /// <summary>
    /// Gets or sets the estimate.
    /// </summary>
    /// <value>
    /// The estimate.
    /// </value>
    double Estimate { get; set; }

    /// <summary>
    /// Gets or sets the treasury account code.
    /// </summary>
    /// <value>
    /// The treasury account code.
    /// </value>
    string TreasuryAccountCode { get; set; }

    /// <summary>
    /// Gets or sets the treasury agency code.
    /// </summary>
    /// <value>
    /// The treasury agency code.
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

    /// <summary>
    /// Gets or sets the source.
    /// </summary>
    /// <value>
    /// The source.
    /// </value>
    Source Source { get; set; }
}
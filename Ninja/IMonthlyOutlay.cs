// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution;

public interface IMonthlyOutlay
{
    /// <summary>
    /// Gets or sets the fiscal year.
    /// </summary>
    /// <value>
    /// The fiscal year.
    /// </value>
    string FiscalYear { get; set; }

    /// <summary>
    /// Gets or sets the line number.
    /// </summary>
    /// <value>
    /// The line number.
    /// </value>
    string LineNumber { get; set; }

    /// <summary>
    /// Gets or sets the line title.
    /// </summary>
    /// <value>
    /// The line title.
    /// </value>
    string LineTitle { get; set; }

    /// <summary>
    /// Gets or sets the taxation code.
    /// </summary>
    /// <value>
    /// The taxation code.
    /// </value>
    string TaxationCode { get; set; }

    /// <summary>
    /// Gets or sets the treasury agency.
    /// </summary>
    /// <value>
    /// The treasury agency.
    /// </value>
    string TreasuryAgencyCode { get; set; }

    /// <summary>
    /// Gets or sets the treasury bureau code.
    /// </summary>
    /// <value>
    /// The treasury bureau code.
    /// </value>
    string TreasuryBureauCode { get; set; }

    /// <summary>
    /// Gets or sets the budget agency code.
    /// </summary>
    /// <value>
    /// The budget agency code.
    /// </value>
    string BudgetAgencyCode { get; set; }

    /// <summary>
    /// Gets or sets the budget bureau code.
    /// </summary>
    /// <value>
    /// The budget bureau code.
    /// </value>
    string BudgetBureauCode { get; set; }

    /// <summary>
    /// Gets or sets the sub account.
    /// </summary>
    /// <value>
    /// The sub account.
    /// </value>
    string SubAccount { get; set; }

    /// <summary>
    /// Gets or sets the agency sequence.
    /// </summary>
    /// <value>
    /// The agency sequence.
    /// </value>
    string AgencySequence { get; set; }

    /// <summary>
    /// Gets or sets the bureau sequence.
    /// </summary>
    /// <value>
    /// The bureau sequence.
    /// </value>
    string BureauSequence { get; set; }

    /// <summary>
    /// Gets or sets the account sequence.
    /// </summary>
    /// <value>
    /// The account sequence.
    /// </value>
    string AccountSequence { get; set; }

    /// <summary>
    /// Gets or sets the agency title.
    /// </summary>
    /// <value>
    /// The agency title.
    /// </value>
    string AgencyTitle { get; set; }

    /// <summary>
    /// Gets or sets the bureau title.
    /// </summary>
    /// <value>
    /// The bureau title.
    /// </value>
    string BureauTitle { get; set; }

    /// <summary>
    /// Gets or sets the october.
    /// </summary>
    /// <value>
    /// The october.
    /// </value>
    double October { get; set; }

    /// <summary>
    /// Gets or sets the november.
    /// </summary>
    /// <value>
    /// The november.
    /// </value>
    double November { get; set; }

    /// <summary>
    /// Gets or sets the december.
    /// </summary>
    /// <value>
    /// The december.
    /// </value>
    double December { get; set; }

    /// <summary>
    /// Gets or sets the january.
    /// </summary>
    /// <value>
    /// The january.
    /// </value>
    double January { get; set; }

    /// <summary>
    /// Gets or sets the feburary.
    /// </summary>
    /// <value>
    /// The feburary.
    /// </value>
    double February { get; set; }

    /// <summary>
    /// Gets or sets the march.
    /// </summary>
    /// <value>
    /// The march.
    /// </value>
    double March { get; set; }

    /// <summary>
    /// Gets or sets the april.
    /// </summary>
    /// <value>
    /// The april.
    /// </value>
    double April { get; set; }

    /// <summary>
    /// Gets or sets the may.
    /// </summary>
    /// <value>
    /// The may.
    /// </value>
    double May { get; set; }

    /// <summary>
    /// Gets or sets the june.
    /// </summary>
    /// <value>
    /// The june.
    /// </value>
    double June { get; set; }

    /// <summary>
    /// Gets or sets the july.
    /// </summary>
    /// <value>
    /// The july.
    /// </value>
    double July { get; set; }

    /// <summary>
    /// Gets or sets the august.
    /// </summary>
    /// <value>
    /// The august.
    /// </value>
    double August { get; set; }

    /// <summary>
    /// Gets or sets the september.
    /// </summary>
    /// <value>
    /// The september.
    /// </value>
    double September { get; set; }

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
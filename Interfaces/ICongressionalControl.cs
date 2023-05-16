// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface ICongressionalControl
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int ID { get; set; }

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
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        string ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        string ProgramAreaName { get; set; }

        /// <summary>
        /// Gets or sets the program project code.
        /// </summary>
        /// <value>
        /// The program project code.
        /// </value>
        string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the sub project code.
        /// </summary>
        /// <value>
        /// The sub project code.
        /// </value>
        string SubProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the sub project.
        /// </summary>
        /// <value>
        /// The name of the sub project.
        /// </value>
        string SubProjectName { get; set; }

        /// <summary>
        /// Gets or sets the reprogramming restriction.
        /// </summary>
        /// <value>
        /// The reprogramming restriction.
        /// </value>
        string ReprogrammingRestriction { get; set; }

        /// <summary>
        /// Gets or sets the increase restriction.
        /// </summary>
        /// <value>
        /// The increase restriction.
        /// </value>
        string IncreaseRestriction { get; set; }

        /// <summary>
        /// Gets or sets the decrease restriction.
        /// </summary>
        /// <value>
        /// The decrease restriction.
        /// </value>
        string DecreaseRestriction { get; set; }

        /// <summary>
        /// Gets or sets the memo requirement.
        /// </summary>
        /// <value>
        /// The memo requirement.
        /// </value>
        string MemoRequirement { get; set; }
    }
}
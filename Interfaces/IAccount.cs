// <copyright file = "IAccount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAccount  : IDataUnit
    {
        /// <summary>
        /// Gets or sets the NPM code.
        /// </summary>
        /// <value>
        /// The NPM code.
        /// </value>
        public string NpmCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the NPM.
        /// </summary>
        /// <value>
        /// The name of the NPM.
        /// </value>
        public string NpmName { get; set; }

        /// <summary>
        /// Gets or sets the goal code.
        /// </summary>
        /// <value>
        /// The goal code.
        /// </value>
        public string GoalCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the goal.
        /// </summary>
        /// <value>
        /// The name of the goal.
        /// </value>
        public string GoalName { get; set; }

        /// <summary>
        /// Gets or sets the objective code.
        /// </summary>
        /// <value>
        /// The objective code.
        /// </value>
        public string ObjectiveCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the objective.
        /// </summary>
        /// <value>
        /// The name of the objective.
        /// </value>
        public string ObjectiveName { get; set; }

        /// <summary>
        /// Gets or sets the program project code.
        /// </summary>
        /// <value>
        /// The program project code.
        /// </value>
        public string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        public string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public string ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public string ProgramAreaName { get; set; }
        
        /// <summary>
        /// Gets or sets the agency activity.
        /// </summary>
        /// <value>
        /// The agency activity.
        /// </value>
        public string ActivityCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the activity.
        /// </summary>
        /// <value>
        /// The name of the activity.
        /// </value>
        public string ActivityName { get; set; }

        /// <summary>
        /// Gets the field.
        /// </summary>
        public string Code { get; set; }
    }
}

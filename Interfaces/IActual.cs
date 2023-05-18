// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IActual
    {
        /// <summary> </summary>
        int ID { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        string EFY { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        string FundName { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        string RpioCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        string RpioName { get; set; }

        /// <summary> Gets or sets the ah code. </summary>
        /// <value> The ah code. </value>
        string AhCode { get; set; }

        /// <summary> Gets or sets the name of the ah. </summary>
        /// <value> The name of the ah. </value>
        string AhName { get; set; }

        /// <summary> Gets or sets the appropriation code. </summary>
        /// <value> The appropriation code. </value>
        public string AppropriationCode { get; set; }

        /// <summary> Gets or sets the name of the appropriation. </summary>
        /// <value> The name of the appropriation. </value>
        public string AppropriationName { get; set; }

        /// <summary> Gets or sets the appropriation code. </summary>
        /// <value> The appropriation code. </value>
        public string SubAppropriationCode { get; set; }

        /// <summary> Gets or sets the name of the appropriation. </summary>
        /// <value> The name of the appropriation. </value>
        public string SubAppropriationName { get; set; }

        /// <summary> Gets or sets the org code. </summary>
        /// <value> The org code. </value>
        string OrgCode { get; set; }

        /// <summary> Gets or sets the name of the org. </summary>
        /// <value> The name of the org. </value>
        string OrgName { get; set; }

        /// <summary> Gets or sets the account code. </summary>
        /// <value> The account code. </value>
        string AccountCode { get; set; }

        /// <summary> Gets or sets the program project code. </summary>
        /// <value> The program project code. </value>
        string ProgramProjectCode { get; set; }

        /// <summary> Gets or sets the name of the program project. </summary>
        /// <value> The name of the program project. </value>
        string ProgramProjectName { get; set; }

        /// <summary> Gets or sets the rpio activity code. </summary>
        /// <value> The rpio activity code. </value>
        string ActivityCode { get; set; }

        /// <summary> Gets or sets the name of the rpio activity. </summary>
        /// <value> The name of the rpio activity. </value>
        string ActivityName { get; set; }

        /// <summary> Gets or sets the boc code. </summary>
        /// <value> The boc code. </value>
        string BocCode { get; set; }

        /// <summary> Gets or sets the name of the boc. </summary>
        /// <value> The name of the boc. </value>
        string BocName { get; set; }

        /// <summary> Gets or sets the ulo. </summary>
        /// <value> The ulo. </value>
        double Commitments { get; set; }

        /// <summary> Gets or sets the obligations. </summary>
        /// <value> The obligations. </value>
        double Obligations { get; set; }

        /// <summary> Gets or sets the balance. </summary>
        /// <value> The balance. </value>
        double Balance { get; set; }

        /// <summary> Gets or sets the program area code. </summary>
        /// <value> The program area code. </value>
        string ProgramAreaCode { get; set; }

        /// <summary> Gets or sets the name of the program area. </summary>
        /// <value> The name of the program area. </value>
        string ProgramAreaName { get; set; }

        /// <summary> Gets or sets the goal code. </summary>
        /// <value> The goal code. </value>
        string GoalCode { get; set; }

        /// <summary> Gets or sets the name of the goal. </summary>
        /// <value> The name of the goal. </value>
        string GoalName { get; set; }

        /// <summary> Gets or sets the objective code. </summary>
        /// <value> The objective code. </value>
        string ObjectiveCode { get; set; }

        /// <summary> Gets or sets the name of the objective. </summary>
        /// <value> The name of the objective. </value>
        string ObjectiveName { get; set; }

        /// <summary> Gets or sets the budget account code. </summary>
        /// <value> The budget account code. </value>
        string BudgetAccountCode { get; set; }

        /// <summary> Gets or sets the name of the budget account. </summary>
        /// <value> The name of the budget account. </value>
        string BudgetAccountName { get; set; }

        /// <summary> Gets or sets the treasury agency code. </summary>
        /// <value> The treasury agency code. </value>
        string TreasuryAccountName { get; set; }

        /// <summary> Gets or sets the treasury account code. </summary>
        /// <value> The treasury account code. </value>
        string TreasuryAccountCode { get; set; }
    }
}
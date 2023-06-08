﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 05-04-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="IAllocation.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   IAllocation.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    public interface IAllocation
    {
        /// <summary> Gets or sets the appropriation code. </summary>
        /// <value> The appropriation code. </value>
        string AppropriationCode { get; set; }

        /// <summary> Gets or sets the name of the appropriation. </summary>
        /// <value> The name of the appropriation. </value>
        string AppropriationName { get; set; }

        /// <summary> Gets or sets the rpio activity code. </summary>
        /// <value> The rpio activity code. </value>
        string RpioActivityCode { get; set; }

        /// <summary> Gets or sets the name of the rpio activity. </summary>
        /// <value> The name of the rpio activity. </value>
        string RpioActivityName { get; set; }

        /// <summary> Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        double Amount { get; set; }

        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        int ID { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        string Efy { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        string FundName { get; set; }

        /// <summary> Gets or sets the treasury account code. </summary>
        /// <value> The treasury account code. </value>
        string TreasuryAccountCode { get; set; }

        /// <summary> Gets or sets the treasury agency code. </summary>
        /// <value> The treasury agency code. </value>
        string TreasuryAccountName { get; set; }

        /// <summary> Gets or sets the budget account code. </summary>
        /// <value> The budget account code. </value>
        string BudgetAccountCode { get; set; }

        /// <summary> Gets or sets the name of the budget account. </summary>
        /// <value> The name of the budget account. </value>
        string BudgetAccountName { get; set; }

        /// <summary> Gets or sets the budget level. </summary>
        /// <value> The budget level. </value>
        string BudgetLevel { get; set; }

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

        /// <summary> Gets or sets the org code. </summary>
        /// <value> The org code. </value>
        string OrgCode { get; set; }

        /// <summary> Gets or sets the name of the org. </summary>
        /// <value> The name of the org. </value>
        string OrgName { get; set; }

        /// <summary> Gets or sets the account code. </summary>
        /// <value> The account code. </value>
        string AccountCode { get; set; }

        /// <summary> Gets or sets the boc code. </summary>
        /// <value> The boc code. </value>
        string BocCode { get; set; }

        /// <summary> Gets or sets the name of the boc. </summary>
        /// <value> The name of the boc. </value>
        string BocName { get; set; }

        /// <summary> Gets or sets the rc code. </summary>
        /// <value> The rc code. </value>
        string RcCode { get; set; }

        /// <summary> Gets or sets the name of the rc. </summary>
        /// <value> The name of the rc. </value>
        string RcName { get; set; }

        /// <summary> Gets or sets the NPM code. </summary>
        /// <value> The NPM code. </value>
        string NpmCode { get; set; }

        /// <summary> Gets or sets the name of the NPM. </summary>
        /// <value> The name of the NPM. </value>
        string NpmName { get; set; }

        /// <summary> Gets or sets the program project code. </summary>
        /// <value> The program project code. </value>
        string ProgramProjectCode { get; set; }

        /// <summary> Gets or sets the name of the program project. </summary>
        /// <value> The name of the program project. </value>
        string ProgramProjectName { get; set; }

        /// <summary> Gets or sets the program area code. </summary>
        /// <value> The program area code. </value>
        string ProgramAreaCode { get; set; }

        /// <summary> Gets or sets the name of the program area. </summary>
        /// <value> The name of the program area. </value>
        string ProgramAreaName { get; set; }
    }
}
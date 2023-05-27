// <copyright file = "BOC.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    public enum BOC
    {
        /// <summary>
        /// The payroll
        /// </summary>
        Payroll = 10,

        /// <summary>
        /// The fte
        /// </summary>
        FTE = 17,

        /// <summary>
        /// The travel
        /// </summary>
        Travel = 21,

        /// <summary>
        /// The site travel
        /// </summary>
        SiteTravel = 28,

        /// <summary>
        /// The expenses
        /// </summary>
        Expenses = 36,

        /// <summary>
        /// The contracts
        /// </summary>
        Contracts = 37,

        /// <summary>
        /// The WCF
        /// </summary>
        WCF = 38,

        /// <summary>
        /// The grants
        /// </summary>
        Grants = 41
    }
}
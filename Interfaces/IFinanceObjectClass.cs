// <copyright file = "IFinanceObjectClass.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using BudgetExecution.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    public interface IFinanceObjectClass : IDataUnit
    {
        /// <summary>
        /// Gets the finance object class.
        /// </summary>
        /// <returns>
        /// </returns>
        IFinanceObjectClass GetFinanceObjectClass();
    }
}

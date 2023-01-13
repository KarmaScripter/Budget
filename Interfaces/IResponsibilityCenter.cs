// <copyright file = "IResponsibilityCenter.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using BudgetExecution.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    public interface IResponsibilityCenter : IDataUnit
    {
        /// <summary>
        /// Gets the responsibility center.
        /// </summary>
        /// <returns>
        /// </returns>
        IResponsibilityCenter GetResponsibilityCenter();
    }
}

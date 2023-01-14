// <copyright file = "IResponsibilityCenter.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.IDataUnit" />
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

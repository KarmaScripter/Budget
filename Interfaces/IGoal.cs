// <copyright file = "IGoal.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using BudgetExecution.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    public interface IGoal : IDataUnit
    {
        /// <summary>
        /// Gets the goal.
        /// </summary>
        /// <returns>
        /// </returns>
        IGoal GetGoal();
    }

}

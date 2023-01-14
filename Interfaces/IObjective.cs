// <copyright file = "IObjective.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.IDataUnit" />
    public interface IObjective : IDataUnit
    {
        /// <summary>
        /// Gets the objective.
        /// </summary>
        /// <returns>
        /// </returns>
        IObjective GetObjective();
    }
}

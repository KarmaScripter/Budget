// <copyright file="IBudgetObjectClass.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IBudgetObjectClass : IDataUnit
    {
        /// <summary>
        /// The value
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        BOC Category { get; set; }
    }
}

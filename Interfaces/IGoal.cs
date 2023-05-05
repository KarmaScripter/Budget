// <copyright file = "IGoal.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGoal 
    {
        /// <summary>
        /// Gets/sets the ID
        /// </summary>
        int ID { get; set; }
        
        /// <summary>
        /// Gets/sets the Code
        /// </summary>
        string Code { get; set; }
        
        /// <summary>
        /// Gets/sets the Name
        /// </summary>
        string Name { get; set; }
    }
}

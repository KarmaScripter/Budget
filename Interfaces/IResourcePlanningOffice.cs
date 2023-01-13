// <copyright file = "IResourcePlanningOffice.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using BudgetExecution.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    public interface IResourcePlanningOffice : IDataUnit
    {
        /// <summary>
        /// Gets the resource planning office.
        /// </summary>
        /// <returns>
        /// </returns>
        IResourcePlanningOffice GetResourcePlanningOffice();
    }
}

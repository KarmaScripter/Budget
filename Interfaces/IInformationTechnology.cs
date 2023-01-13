// <copyright file = "IInformationTechnology.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using BudgetExecution.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    public interface IInformationTechnology : IDataUnit
    {
        /// <summary>
        /// Gets it code.
        /// </summary>
        /// <returns>
        /// </returns>
        IInformationTechnology GetItCode();
    }
}

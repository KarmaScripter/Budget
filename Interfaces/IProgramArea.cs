// <copyright file = "IProgramArea.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using BudgetExecution.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    public interface IProgramArea : IDataUnit
    {
        /// <summary>
        /// Gets the program area.
        /// </summary>
        /// <returns>
        /// </returns>
        IProgramArea GetProgramArea();
    }
}

// <copyright file = "IInformationTechnology.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.IDataUnit" />
    public interface IInformationTechnology : IDataUnit
    {
        /// <summary>
        /// Gets it code.
        /// </summary>
        /// <returns>
        /// </returns>
        IInformationTechnology GetItCode( );
    }
}

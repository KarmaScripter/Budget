// <copyright file = "ICommandBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data.Common;

    /// <summary>
    /// 
    /// </summary>
    public interface ICommand : ISource, IProvider
    {
        /// <summary>
        /// Sets the command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        DbCommand GetCommand( );
    }
}
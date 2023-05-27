// <copyright file = "ICommandFactory.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data.Common;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ISource" />
    /// <seealso cref="BudgetExecution.IProvider" />
    public interface ICommandFactory : ISource, IProvider
    {
        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <returns></returns>
        DbCommand GetCommand( );
    }
}
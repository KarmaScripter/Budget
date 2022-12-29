// <copyright file = "IQuery.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    /// <seealso cref="BudgetExecution.ISource" />
    /// <seealso cref="BudgetExecution.IProvider" />
    public interface IQuery : IDisposable, ISource, IProvider
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is disposed; otherwise, <c>false</c>.
        /// </value>
        bool IsDisposed { get; set; }

        /// <summary>
        /// Gets or sets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        IDictionary<string, object> Criteria { get; set; }

        /// <summary>
        /// Gets or sets the connection builder.
        /// </summary>
        /// <value>
        /// The connection builder.
        /// </value>
        IConnectionFactory ConnectionFactory { get; set; }

        /// <summary>
        /// Gets or sets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Gets the adapter.
        /// </summary>
        /// <returns>
        /// </returns>
        DbDataAdapter GetAdapter( );
    }
}
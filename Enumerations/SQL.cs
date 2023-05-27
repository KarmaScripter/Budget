// <copyright file = "SQL.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    public enum SQL
    {
        /// <summary>
        /// The select
        /// </summary>
        SELECT,

        /// <summary>
        /// The selectall
        /// </summary>
        SELECTALL,

        /// <summary>
        /// The insert
        /// </summary>
        INSERT,

        /// <summary>
        /// The update
        /// </summary>
        UPDATE,

        /// <summary>
        /// The delete
        /// </summary>
        DELETE,

        /// <summary>
        /// The createdatabase
        /// </summary>
        CREATEDATABASE,

        /// <summary>
        /// The createtable
        /// </summary>
        CREATETABLE,

        /// <summary>
        /// The createview
        /// </summary>
        CREATEVIEW,

        /// <summary>
        /// The drop
        /// </summary>
        DROP,

        /// <summary>
        /// The altertable
        /// </summary>
        ALTERTABLE
    }
}
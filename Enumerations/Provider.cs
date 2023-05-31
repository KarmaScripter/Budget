// <copyright file = "Provider.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    public enum Provider
    {
        /// <summary>
        /// The sq lite
        /// </summary>
        SQLite = 0,

        /// <summary>
        /// The excel
        /// </summary>
        Excel = 1,

        /// <summary>
        /// The SQL server
        /// </summary>
        SqlServer = 2,

        /// <summary>
        /// The SQL ce
        /// </summary>
        SqlCe = 3,

        /// <summary>
        /// The access
        /// </summary>
        Access = 4,

        /// <summary>
        /// The OLE database
        /// </summary>
        OleDb = 5,

        /// <summary>
        /// The CSV
        /// </summary>
        CSV = 6,

        /// <summary>
        /// The text
        /// </summary>
        TXT = 7
    }
}
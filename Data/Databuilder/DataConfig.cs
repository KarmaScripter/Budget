﻿// <copyright file = "DataConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    public abstract class DataConfig
    {
        /// <summary>
        /// Gets or sets a value indicating
        /// whether this instance is compressed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is compressed;
        /// otherwise, <c>false</c>.
        /// </value>
        public bool IsCompressed { get; set; }
        
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// The connection builder
        /// </summary>
        public IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// The arguments
        /// </summary>
        public IDictionary<string, object> Map { get; set; }

        /// <summary>
        /// The SQL statement
        /// </summary>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// The query
        /// </summary>
        public IQuery Query { get; set; }

        /// <summary>
        /// The record
        /// </summary>
        public DataRow Record { get; set; }

        /// <summary>
        /// The Data table
        /// </summary>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public IEnumerable<DataColumn> DataColumns { get; set; }
        
        /// <summary>
        /// Gets or sets the column names.
        /// </summary>
        /// <value>
        /// The column names.
        /// </value>
        public IEnumerable<string> ColumnNames { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the Data set.
        /// </summary>
        /// <value>
        /// The Data set.
        /// </value>
        public DataSet DataSet { get; set; }

        /// <summary>
        /// Gets or sets the name of the data set.
        /// </summary>
        /// <value>
        /// The name of the data set.
        /// </value>
        public string DataSetName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataConfig"/> class.
        /// </summary>
        protected DataConfig( )
        {
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.DataVisualization.Charting.Chart" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ChartControl : ChartBase
    {
        /// <summary>
        /// Gets or sets the measure.
        /// </summary>
        /// <value>
        /// The measure.
        /// </value>
        public STAT Measure { get; set; }
        
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IEnumerable<DataRow> Data { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartControl"/> class.
        /// </summary>
        public ChartControl( )
        {
            SetLegendProperties( );
            SetTitleProperties( );
            SetAreaProperties( );
            SetSeriesProperties( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartControl"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="category">The category.</param>
        /// <param name="values">The values.</param>
        /// <param name="type">The type.</param>
        /// <param name="stat">The stat.</param>
        public ChartControl( BindingSource bindingSource, string category, IEnumerable<string> values,
            SeriesChartType type = SeriesChartType.Column, STAT stat = STAT.Total )
            : this( )
        {
            DataTable = (DataTable)bindingSource.DataSource;
            BindingSource.DataSource = (DataTable)bindingSource.DataSource;
            DataSource = (DataTable)bindingSource.DataSource;
            Data = DataTable.AsEnumerable( );
            Series[ 0 ].ChartType = type;
            Measure = stat;
        }
    }

}
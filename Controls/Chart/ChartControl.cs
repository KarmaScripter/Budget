// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
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
    public class ChartControl : Chart
    {
        public string Category { get; set; }
        
        public string[ ] Values { get; set; }
        
        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the stat.
        /// </summary>
        /// <value>
        /// The stat.
        /// </value>
        public STAT STAT { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

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
            BackColor = Color.FromArgb( 20, 20, 20 );
            BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.White;
            BorderlineColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BackColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.PageColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BorderColor = Color.FromArgb( 20, 20, 20 );
            
            // Chart Area Properties
            ChartAreas[ 0 ].BackColor = Color.FromArgb( 20, 20, 20 );
            ChartAreas[ 0 ].Area3DStyle.Enable3D = true;
            ChartAreas[ 0 ].BorderColor = Color.Transparent;
            ChartAreas[ 0 ].BackSecondaryColor = Color.Transparent;
            ChartAreas[ 0 ].Area3DStyle.PointDepth = 150;
            ChartAreas[ 0 ].Area3DStyle.Inclination = 35;

            // X-Axis Properties
            ChartAreas[ 0 ].AxisX.IsLabelAutoFit = true;
            ChartAreas[ 0 ].AxisX.InterlacedColor = Color.Transparent;
            ChartAreas[ 0 ].AxisX.LineColor = Color.FromArgb( 24, 47, 66 );
            ChartAreas[ 0 ].AxisX.TitleFont = new Font( "Roboto", 8 );
            ChartAreas[ 0 ].AxisX.TitleForeColor = Color.FromArgb( 0, 120, 212 );
            ChartAreas[ 0 ].AxisX.LabelStyle.Font = new Font( "Roboto", 8 );
            ChartAreas[ 0 ].AxisX.LabelStyle.ForeColor = Color.FromArgb( 0, 120, 212 );
            ChartAreas[ 0 ].AxisX.MajorGrid.LineColor = Color.FromArgb( 24, 47, 66 );
            ChartAreas[ 0 ].AxisX.MinorGrid.LineColor = Color.FromArgb( 65, 65, 65 );
            ChartAreas[ 0 ].AxisX.TextOrientation = TextOrientation.Horizontal;
            ChartAreas[ 0 ].AxisX.IsLabelAutoFit = true;
            
            // Y-Axis Properties
            ChartAreas[ 0 ].AxisY.IsLabelAutoFit = true;
            ChartAreas[ 0 ].AxisY.InterlacedColor = Color.Transparent;
            ChartAreas[ 0 ].AxisY.LineColor = Color.FromArgb( 24, 47, 66 );
            ChartAreas[ 0 ].AxisY.TitleFont = new Font( "Roboto", 8 );
            ChartAreas[ 0 ].AxisY.TitleForeColor = Color.FromArgb( 0, 120, 212 );
            ChartAreas[ 0 ].AxisY.LabelStyle.Font = new Font( "Roboto", 8 );
            ChartAreas[ 0 ].AxisY.LabelStyle.Format = "#,";
            ChartAreas[ 0 ].AxisY.LabelStyle.ForeColor = Color.FromArgb( 0, 120, 212 );
            ChartAreas[ 0 ].AxisY.MajorGrid.LineColor = Color.FromArgb( 24, 47, 66 );
            ChartAreas[ 0 ].AxisY.MinorGrid.LineColor = Color.FromArgb( 65, 65, 65 );
            ChartAreas[ 0 ].AxisY.TextOrientation = TextOrientation.Horizontal;
            ChartAreas[ 0 ].AxisY.IsLabelAutoFit = true;
            
            // Legend Properties
            Legends[ 0 ].HeaderSeparatorColor = Color.Transparent;
            Legends[ 0 ].ItemColumnSeparatorColor = Color.Transparent;
            Legends[ 0 ].BorderColor = Color.Transparent;
            Legends[ 0 ].TitleFont = new Font( "Roboto", 8 );
            Legends[ 0 ].TitleForeColor = Color.FromArgb( 0, 120, 212 );
            Legends[ 0 ].TitleBackColor = Color.Transparent;
            
            // Title Properties
            Titles[ 0 ].Font = new Font( "Roboto", 12 );
            Titles[ 0 ].BackColor = Color.Transparent;
            Titles[ 0 ].BorderColor = Color.Transparent;
            Titles[ 0 ].ForeColor = Color.FromArgb( 0, 120, 212 );
            
            // Series Properties
            Series[ 0 ].ChartType = SeriesChartType.Column;
            Series[ 0 ].ChartArea = ChartAreas[ 0 ].Name;
            Series[ 0 ].LabelBorderColor = Color.Transparent;
            Series[ 0 ].LabelBackColor = Color.Transparent;
            Series[ 0 ].LabelForeColor = Color.LightSteelBlue;
            Series[ 0 ].Font = new Font( "Roboto", 8 );
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
            STAT = stat;
            Category = category;
            Values = values.ToArray( );
            DataTable = (DataTable)bindingSource.DataSource;
            BindingSource.DataSource = (DataTable)bindingSource.DataSource;
            DataSource = (DataTable)bindingSource.DataSource;
            Data = DataTable.AsEnumerable( );
            Series[ 0 ].ChartType = type;
        }
    }

}
// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using BudgetExecution.Controls.Chart;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class Chart : ChartBase
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

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
        public STAT Stat { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }
        
        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public STAT STAT { get; set; }

        /// <summary>
        /// Gets or sets the type of the chart.
        /// </summary>
        /// <value>
        /// The type of the chart.
        /// </value>
        public ChartSeriesType SeriesType { get; set; }

        /// <summary>
        /// Gets or sets the x label.
        /// </summary>
        /// <value>
        /// The x label.
        /// </value>
        public string xAxis { get; set; }

        /// <summary>
        /// Gets or sets the y value.
        /// </summary>
        /// <value>
        /// The y value.
        /// </value>
        public IList<string> yValues { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IEnumerable<DataRow> Data { get; set; }
        
        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }
        
        /// <summary>
        /// Gets the data series.
        /// </summary>
        /// <value>
        /// The data series.
        /// </value>
        public ChartSeries ChartSeries { get; set; }

        /// <summary>
        /// Gets or sets the binding model.
        /// </summary>
        /// <value>
        /// The binding model.
        /// </value>
        public ChartDataBindModel BindingModel { get; set; }

        /// <summary>
        /// Gets or sets the axis model.
        /// </summary>
        /// <value>
        /// The axis model.
        /// </value>
        public ChartDataBindAxisLabelModel AxisModel { get; set; }
        
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="Chart"/> class.
        /// </summary>
        public Chart( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="type">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( BindingSource bindingSource, 
            ChartSeriesType type = ChartSeriesType.Column, STAT stat = STAT.SUM )
            : this( )
        {
            STAT = stat;
            SeriesType = type;
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            Data = DataTable.AsEnumerable( );
            BindingModel = new ChartDataBindModel( DataTable );
            AxisModel = new ChartDataBindAxisLabelModel( DataTable );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="category">The names.</param>
        /// <param name="values">The values.</param>
        /// <param name="type">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( BindingSource bindingSource, string category, IList<string> values, 
            ChartSeriesType type = ChartSeriesType.Column, STAT stat = STAT.SUM  )
            : this( )
        {
            STAT = stat;
            SeriesType = type;
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            Data = DataTable.AsEnumerable( );
            BindingModel = new ChartDataBindModel( DataTable );
            AxisModel = new ChartDataBindAxisLabelModel( DataTable );
            xAxis = category;
            yValues = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="type">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( DataTable dataTable, 
            ChartSeriesType type = ChartSeriesType.Column, STAT stat = STAT.SUM  )
            : this( )
        {
            STAT = stat;
            SeriesType = type;
            DataTable = dataTable;
            Data = dataTable.AsEnumerable( );
            BindingSource.DataSource = dataTable;
            BindingModel = new ChartDataBindModel( dataTable );
            AxisModel = new ChartDataBindAxisLabelModel( dataTable );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="category">The names.</param>
        /// <param name="values">The values.</param>
        /// <param name="type">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( DataTable dataTable, string category, IList<string> values, 
            ChartSeriesType type = ChartSeriesType.Column, STAT stat = STAT.SUM  )
            : this( )
        {
            STAT = stat;
            SeriesType = type;
            DataTable = dataTable;
            Data = dataTable.AsEnumerable( );
            BindingSource.DataSource =  dataTable;
            BindingModel = new ChartDataBindModel( dataTable );
            AxisModel = new ChartDataBindAxisLabelModel( dataTable );
            xAxis = category;
            yValues = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <param name="category">The names.</param>
        /// <param name="values">The values.</param>
        /// <param name="type">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( IEnumerable<DataRow> dataRows, string category, IList<string> values,   
            ChartSeriesType type = ChartSeriesType.Column, STAT stat = STAT.SUM  )
            : this( )
        {
            STAT = stat;
            SeriesType = type;
            DataTable = dataRows.CopyToDataTable( );
            Data = dataRows;
            BindingSource.DataSource = dataRows.CopyToDataTable( );
            BindingModel = new ChartDataBindModel( DataTable );
            AxisModel = new ChartDataBindAxisLabelModel( DataTable );
            xAxis = category;
            yValues = values;
        }

        /// <summary>
        /// Creates the series.
        /// </summary>
        /// <returns></returns>
        private void InitSeries( ChartSeries series )
        {
            if( series != null )
            {
                try
                {
                    // Basic Properties
                    series.SmartLabels = true;
                    series.Visible = true;
                    series.ShowTicks = true;
                    series.Rotate = true;
                    series.EnableAreaToolTip = true;
                    series.EnableStyles = true;
                    series.OptimizePiePointPositions = true;
                    series.LegendItemUseSeriesStyle = true;
                    series.SmartLabelsBorderColor = Color.FromArgb( 0, 120, 212 );
                    series.SmartLabelsBorderWidth = 1;
                    series.SmartLabels = true;
                    series.Visible = true;
                    series.ShowTicks = true;
                    series.Rotate = true;
                    series.EnableAreaToolTip = true;
                    series.EnableStyles = true;
                    series.OptimizePiePointPositions = true;
                    series.LegendItemUseSeriesStyle = true;
                    series.SmartLabelsBorderColor = Color.FromArgb( 0, 120, 212 );
                    series.SmartLabelsBorderWidth = 1;

                    // Call out Properties
                    series.Style.DisplayText = true;
                    series.Style.Callout.Enable = true;
                    series.Style.Callout.Position = LabelPosition.Top;
                    series.Style.Callout.DisplayTextAndFormat = "{0} : {2}";
                    series.Style.Callout.Border.Color = Color.FromArgb( 0, 120, 212 );
                    series.Style.Callout.Color = Color.FromArgb( 55, 55, 55 );
                    series.Style.Callout.TextColor = Color.LightSteelBlue;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the primary axis titleInfo.
        /// </summary>
        /// <param name="font"></param>
        /// <param name="color">The color.</param>
        /// <param name = "type" > </param>
        /// <param name = "orientation" > </param>
        public void SetPrimaryAxisProperties( Font font, Color color, ChartValueType type = ChartValueType.Category, 
            ChartOrientation orientation = ChartOrientation.Horizontal )
        {
            if( font != null 
               && color != Color.Empty )
            {
                try
                {
                    PrimaryXAxis.TitleColor = color;
                    PrimaryXAxis.TitleFont = font;
                    PrimaryXAxis.ValueType = type;
                    PrimaryXAxis.IsVisible = true;
                    PrimaryXAxis.Orientation = orientation;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the primary axis title.
        /// </summary>
        /// <param name="title">The text.</param>
        public void SetPrimaryAxisText( string title ) 
        {
            if( !string.IsNullOrEmpty( title ) )
            {
                try
                {
                    PrimaryXAxis.Title = title;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the title.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="foreColor">The color.</param>
        /// <param name = "backColor" > </param>
        public void SetTitleProperties( Font font, Color foreColor, Color backColor )
        {
            if( foreColor != Color.Empty
               && backColor != Color.Empty
               && font != null  )
            {
                try
                {
                    Title.Font = font;
                    Title.ShowBorder = false;
                    Title.BackColor = backColor;
                    Title.ForeColor = foreColor;
                    Title.Visible = true;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the title text.
        /// </summary>
        /// <param name="titleText">The title text.</param>
        public void SetTitleText( string titleText )
        {
            if( !string.IsNullOrEmpty( titleText ) )
            {
                try
                {
                    Title.Text = titleText;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
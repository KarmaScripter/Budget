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
        public ChartSeriesType ChartType { get; set; }

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
        public string yValue { get; set; }

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
        /// <param name="chartType">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( BindingSource bindingSource, 
            ChartSeriesType chartType = ChartSeriesType.Column, STAT stat = STAT.Total )
            : this( )
        {
            STAT = stat;
            ChartType = chartType;
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            BindingModel = new ChartDataBindModel( DataTable );
            AxisModel = new ChartDataBindAxisLabelModel( DataTable );
            Data = DataTable.AsEnumerable(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="names">The names.</param>
        /// <param name="values">The values.</param>
        /// <param name="chartType">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( BindingSource bindingSource, string names, string values, 
            ChartSeriesType chartType = ChartSeriesType.Column, STAT stat = STAT.Total  )
            : this( )
        {
            STAT = stat;
            xAxis = names;
            yValue = values;
            ChartType = chartType;
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            BindingModel = new ChartDataBindModel( DataTable );
            AxisModel = new ChartDataBindAxisLabelModel( DataTable );
            Data = DataTable.AsEnumerable(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="chartType">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( DataTable dataTable, 
            ChartSeriesType chartType = ChartSeriesType.Column, STAT stat = STAT.Total  )
            : this( )
        {
            STAT = stat;
            ChartType = chartType;
            DataTable = dataTable;
            Data = dataTable.AsEnumerable(  );
            BindingSource.DataSource = dataTable;
            BindingModel = new ChartDataBindModel( dataTable );
            AxisModel = new ChartDataBindAxisLabelModel( dataTable );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="names">The names.</param>
        /// <param name="values">The values.</param>
        /// <param name="chartType">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( DataTable dataTable, string names, string values, 
            ChartSeriesType chartType = ChartSeriesType.Column, STAT stat = STAT.Total  )
            : this( )
        {
            STAT = stat;
            xAxis = names;
            yValue = values;
            ChartType = chartType;
            DataTable = dataTable;
            BindingSource.DataSource =  dataTable;
            Data = dataTable.AsEnumerable( );
            BindingModel = new ChartDataBindModel( dataTable );
            AxisModel = new ChartDataBindAxisLabelModel( dataTable );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <param name="names">The names.</param>
        /// <param name="values">The values.</param>
        /// <param name="chartType">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( IEnumerable<DataRow> dataRows, string names, string values,   
            ChartSeriesType chartType = ChartSeriesType.Column, STAT stat = STAT.Total  )
            : this( )
        {
            STAT = stat;
            xAxis = names;
            yValue = values;
            ChartType = chartType;
            DataTable = dataRows.CopyToDataTable( );
            BindingSource.DataSource = dataRows.CopyToDataTable( );
            BindingModel = new ChartDataBindModel( DataTable );
            AxisModel = new ChartDataBindAxisLabelModel( DataTable );
            Data = dataRows;
        }

        /// <summary>
        /// Creates the series.
        /// </summary>
        /// <returns></returns>
        public void DecorateSeries( )
        {
            if( Series != null 
               && BindingModel != null )
            {
                try
                {
                    foreach( ChartSeries _chartSeries in Series )
                    {
                        _chartSeries.SeriesModel = BindingModel;
                        _chartSeries.SmartLabels = true;
                        _chartSeries.Visible = true;
                        _chartSeries.ShowTicks = true;
                        _chartSeries.Rotate = true;
                        _chartSeries.EnableAreaToolTip = true;
                        _chartSeries.EnableStyles = true;
                        _chartSeries.OptimizePiePointPositions = true;
                        _chartSeries.LegendItemUseSeriesStyle = true;
                        _chartSeries.SmartLabelsBorderColor = Color.FromArgb( 0, 120, 212 );
                        _chartSeries.SmartLabelsBorderWidth = 1;

                        // Basic Properties
                        _chartSeries.SmartLabels = true;
                        _chartSeries.Visible = true;
                        _chartSeries.ShowTicks = true;
                        _chartSeries.Rotate = true;
                        _chartSeries.EnableAreaToolTip = true;
                        _chartSeries.EnableStyles = true;
                        _chartSeries.OptimizePiePointPositions = true;
                        _chartSeries.LegendItemUseSeriesStyle = true;
                        _chartSeries.SmartLabelsBorderColor = Color.FromArgb( 0, 120, 212 );
                        _chartSeries.SmartLabelsBorderWidth = 1;

                        // Call out Properties
                        _chartSeries.Style.DisplayText = true;
                        _chartSeries.Style.Callout.Enable = true;
                        _chartSeries.Style.Callout.Position = LabelPosition.Top;
                        _chartSeries.Style.Callout.DisplayTextAndFormat = "{0} : {2}";
                        _chartSeries.Style.Callout.Border.Color = Color.FromArgb( 0, 120, 212 );
                        _chartSeries.Style.Callout.Color = Color.FromArgb( 55, 55, 55 );
                        _chartSeries.Style.Callout.TextColor = Color.LightSteelBlue;
                        _chartSeries.Style.DisplayText = true;
                    }
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
        /// <param name="text">The titleInfo.</param>
        /// <param name="font"></param>
        /// <param name="color">The color.</param>
        public void SetPrimaryAxisTitle( string text, Font font, Color color )
        {
            try
            {
                PrimaryXAxis.Title = text;
                PrimaryXAxis.TitleColor = color;
                PrimaryXAxis.TitleFont = font;
            }
            catch( Exception ex )
            {
                Fail( ex );
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
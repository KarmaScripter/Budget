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
    using Syncfusion.Drawing;
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
            : base( )
        {
            //Basic Control Properties
            Size = new Size( 600, 400 );
            ShowToolbar = true;
            ShowToolTips = true;
            ShowScrollBars = false;
            Font = new Font( "Roboto", 8 );
            EnableMouseRotation = true;
            Padding = new Padding( 1 );
            Margin = new Padding( 3 );
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            AllowGapForEmptyPoints = false;
            AllowGradientPalette = true;
            AllowUserEditStyles = true;
            PrintColorMode = ChartPrintColorMode.CheckPrinter;
            BackInterior = new BrushInfo( Color.FromArgb( 20, 20, 20 ) );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ChartInterior = new BrushInfo( GradientStyle.PathRectangle, Color.LightSteelBlue,
                Color.FromArgb( 20, 20, 20 ) );

            CalcRegions = true;

            //ChartArea Properties
            ChartArea.AdjustPlotAreaMargins = ChartSetMode.AutoSet;
            ChartArea.AutoScale = true;
            ChartArea.BackInterior = new BrushInfo( Color.FromArgb( 20, 20, 20 ) );
            ChartArea.BorderWidth = 1;
            ChartArea.BorderColor = Color.Transparent;
            ChartArea.BorderStyle = BorderStyle.None;
            ChartAreaMargins = new ChartMargins( 3, 3, 3, 3 );

            //ChartSeries Properties
            DropSeriesPoints = false;
            AddRandomSeries = true;
            Series3D = true;
            SeriesHighlight = true;
            SeriesHighlightIndex = -1;
            ShadowWidth = 5;
            ShadowColor = new BrushInfo( GradientStyle.PathRectangle, Color.FromArgb( 20, 20, 20 ),
                Color.FromArgb( 65, 65, 65 ) );

            Depth = 250;
            ElementsSpacing = 10;
            ColumnDrawMode = ChartColumnDrawMode.InDepthMode;
            ColumnFixedWidth = 20;

            //Chart Appearance Setting
            Palette = ChartColorPalette.Metro;
            Skins = Skins.None;
            RealMode3D = true;
            Rotation = 0.1f;
            Spacing = 5;
            AutoHighlight = true;
            SpacingBetweenPoints = 5;
            SpacingBetweenSeries = 5;
            Style3D = true;
            TextAlignment = StringAlignment.Center;
            TextPosition = ChartTextPosition.Top;
            Tilt = 5;
            ScrollPrecision = 100;
            RadarStyle = ChartRadarAxisStyle.Polygon;

            //Chart Legend Setting;
            ShowLegend = true;
            Legend.Font = new Font( "Roboto", 8 );
            Legend.ItemsSize = new Size( 10, 10 );
            Legend.VisibleCheckBox = true;
            Legend.BackInterior = new BrushInfo( Color.FromArgb( 20, 20, 20 ) );
            Legend.ItemsAlignment = StringAlignment.Center;
            Legend.ItemsTextAligment = VerticalAlignment.Center;
            Legend.Orientation = ChartOrientation.Vertical;
            Legend.FloatingAutoSize = true;
            Legend.ShowSymbol = true;
            Legend.ShowItemsShadow = true;
            Legend.ShowBorder = false;
            Legend.Visible = true;

            // Title ("Title") Properties
            Title.Font = new Font( "Roboto", 14 );
            Title.BackColor = Color.FromArgb( 20, 20, 20 );
            Title.ForeColor = Color.FromArgb( 0, 120, 212 );

            // Toolbar Properties
            ToolBar.Orientation = ChartOrientation.Horizontal;
            ToolBar.BackColor = Color.FromArgb( 20, 20, 20 );
            ToolBar.ButtonBackColor = Color.FromArgb( 20, 20, 20 );
            ToolBar.Position = ChartDock.Floating;
            ToolBar.ShowGrip = false;
            ToolBar.ShowBorder = false;
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
        /// Initializes a new instance of the <see cref="Chart" /> class.
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
    }
}
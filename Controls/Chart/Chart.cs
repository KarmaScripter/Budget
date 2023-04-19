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
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public class Chart : Graph
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }
        
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
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Shortcut method that provides access to the
        /// <see cref="T:Syncfusion.Windows.Forms.Chart.ChartSeriesCollection" />
        /// contained in the chart's model.
        /// </summary>
        public ChartSeries DataSeries { get; set; }
        
        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

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
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            AllowGapForEmptyPoints = false;
            AllowGradientPalette = true;
            AllowUserEditStyles = true;
            PrintColorMode = ChartPrintColorMode.CheckPrinter;
            BackInterior = new BrushInfo( Color.FromArgb( 20, 20, 20 ) );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ChartInterior = new BrushInfo( GradientStyle.PathRectangle, Color.LightSteelBlue,
                Color.FromArgb( 20, 20, 20 ) );

            CalcRegions = true;

            // General Appearance Properties
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

            // Toolbar Properties
            ToolBar.Orientation = ChartOrientation.Horizontal;
            ToolBar.BackColor = Color.FromArgb( 20, 20, 20 );
            ToolBar.ButtonBackColor = Color.FromArgb( 20, 20, 20 );
            ToolBar.Position = ChartDock.Floating;
            ToolBar.ShowGrip = false;
            ToolBar.ShowBorder = false;
            
            //ChartSeries Properties
            DropSeriesPoints = false;
            AddRandomSeries = true;
            Series3D = true;
            SeriesHighlight = true;
            SeriesHighlightIndex = -1;
            ShadowWidth = 5;
            Depth = 250;
            ElementsSpacing = 10;
            ColumnDrawMode = ChartColumnDrawMode.InDepthMode;
            ColumnFixedWidth = 20;
            ShowLegend = true;
            ShadowColor = new BrushInfo( GradientStyle.PathRectangle, Color.FromArgb( 20, 20, 20 ),
                Color.FromArgb( 65, 65, 65 ) );
            
            // PrimaryAxis Properties
            PrimaryXAxis.IsVisible = true;
            PrimaryXAxis.AutoSize = true;
            PrimaryXAxis.ShowAxisLabelTooltip = true;
            PrimaryXAxis.TitleColor = Color.DarkGray;
            PrimaryXAxis.TitleFont = new Font( "Roboto", 8 );
            
            // Legend Properties
            Legend.Font = new Font( "Roboto", 7 );
            Legend.ItemsSize = new Size( 10, 10 );
            Legend.BackInterior = new BrushInfo( Color.FromArgb( 20, 20, 20 ) );
            Legend.ItemsAlignment = StringAlignment.Center;
            Legend.ItemsTextAligment = VerticalAlignment.Center;
            Legend.Orientation = ChartOrientation.Vertical;
            Legend.VisibleCheckBox = true;
            Legend.FloatingAutoSize = true;
            Legend.ShowSymbol = true;
            Legend.ShowItemsShadow = true;
            Legend.ShowBorder = false;
            Legend.Visible = true;

            // Chart Area Properties
            ChartArea.AdjustPlotAreaMargins = ChartSetMode.AutoSet;
            ChartArea.AutoScale = true;
            ChartArea.BackInterior = new BrushInfo( Color.FromArgb( 20, 20, 20 ) );
            ChartArea.BorderWidth = 1;
            ChartArea.BorderColor = Color.Transparent;
            ChartArea.BorderStyle = BorderStyle.None;
            ChartAreaMargins = new ChartMargins( 3, 3, 3, 3 );
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="category">The names.</param>
        /// <param name="values">The values.</param>
        /// <param name="type">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( BindingSource bindingSource, string category, IEnumerable<string> values, 
            ChartSeriesType type = ChartSeriesType.Column, STAT stat = STAT.SUM )
            : this( )
        {
            STAT = stat;
            SeriesType = type;
            DataTable = (DataTable)bindingSource.DataSource;
            BindingSource.DataSource = DataTable;
            Data = DataTable.AsEnumerable( );
            BindingModel = new ChartDataBindModel( DataTable );
            BindingModel.XName = DataTable.Columns[ 0 ].ColumnName;
            BindingModel.YNames = values.ToArray( );
            AxisModel = new ChartDataBindAxisLabelModel( DataTable );
            AxisModel.LabelName = category;
            PrimaryXAxis.LabelsImpl = AxisModel;
            PrimaryXAxis.ValueType = ChartValueType.Category;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Chart" /> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="category">The names.</param>
        /// <param name="values">The values.</param>
        /// <param name="type">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( DataTable dataTable, string category, IEnumerable<string> values, 
            ChartSeriesType type = ChartSeriesType.Column, STAT stat = STAT.SUM )
            : this( )
        {
            STAT = stat;
            SeriesType = type;
            DataTable = dataTable;
            Data = dataTable.AsEnumerable( );
            BindingSource.DataSource = dataTable;
            BindingModel = new ChartDataBindModel( dataTable );
            BindingModel.XName = DataTable.Columns[ 0 ].ColumnName;
            BindingModel.YNames = values.ToArray( );
            DataSeries = new ChartSeries( dataTable.TableName );
            DataSeries.SeriesIndexedModelImpl = BindingModel;
            Series.Add( DataSeries );
            AxisModel = new ChartDataBindAxisLabelModel( dataTable );
            AxisModel.LabelName = category;
            PrimaryXAxis.LabelsImpl = AxisModel;
            PrimaryXAxis.ValueType = ChartValueType.Category;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <param name="category">The names.</param>
        /// <param name="values">The values.</param>
        /// <param name="type">Type of the chart.</param>
        /// <param name="stat">The stat.</param>
        public Chart( IEnumerable<DataRow> dataRows, string category, IEnumerable<string> values,   
            ChartSeriesType type = ChartSeriesType.Column, STAT stat = STAT.SUM )
            : this( )
        {
            STAT = stat;
            SeriesType = type;
            DataTable = dataRows.CopyToDataTable( );
            Data = dataRows;
            BindingSource.DataSource = dataRows.CopyToDataTable( );
            BindingModel = new ChartDataBindModel( DataTable );
            BindingModel.XName = DataTable.Columns[ 0 ].ColumnName;
            BindingModel.YNames = values.ToArray( );
            AxisModel = new ChartDataBindAxisLabelModel( DataTable );
            AxisModel.LabelName = category;
            PrimaryXAxis.LabelsImpl = AxisModel;
            PrimaryXAxis.ValueType = ChartValueType.Category;
        }
    }
}
// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{ 
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso
    /// cref="Syncfusion.Windows.Forms.Chart.ChartControl" />
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    public abstract class ChartBase : ChartControl
    {
        /// <summary>
        /// Initializes a new
        /// instance of the <see cref="ChartBase"/> class.
        /// </summary>
        public ChartBase( )
        {
            //Basic Control Properties
            Size = new Size( 600, 400 );
            ShowToolbar = true;
            ShowToolTips = true;
            ShowScrollBars = false;
            EnableMouseRotation = true;
            Padding = new Padding( 1 );
            Margin = new Padding( 3 );
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            AllowGapForEmptyPoints = true;
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
            ChartArea.BorderStyle = BorderStyle.FixedSingle;
            ChartAreaMargins = new ChartMargins( 3, 3, 3, 3 );

            //ChartSeries Properties
            DropSeriesPoints = false;
            AddRandomSeries = true;
            Series3D = true;
            SeriesHighlight = true;
            SeriesHighlightIndex = -1;
            ShadowWidth = 5;
            ShadowColor = new BrushInfo( GradientStyle.PathRectangle, Color.FromArgb( 20, 20, 20 ),
                Color.Silver );

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
            SpacingBetweenSeries = 10;
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
            Title.Font = new Font( "Roboto", 11 );
            Title.BackColor = Color.FromArgb( 20, 20, 20 );
            Title.ForeColor = Color.FromArgb( 0, 120, 212 );
            
            // Toolbar Properties
            ToolBar.Orientation = ChartOrientation.Horizontal;
            ToolBar.BackColor = Color.FromArgb( 20, 20, 20 );
            ToolBar.ButtonBackColor = Color.FromArgb( 20, 20, 20 );
            ToolBar.Position = ChartDock.Bottom;
            ToolBar.ShowGrip = false;
            ToolBar.ShowBorder = false;
        }
    }
}

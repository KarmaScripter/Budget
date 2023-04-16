// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using C1.Util.Win;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Chart.ChartControl" />
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class Graph : ChartControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Graph"/> class.
        /// </summary>
        protected Graph( )
        {
        }

        /// <summary>
        /// Initializes the series.
        /// </summary>
        /// <param name="series">The series.</param>
        protected void InitSeries( ChartSeries series )
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

                    // Call out Properties
                    series.Style.DisplayText = true;
                    series.Style.Callout.Enable = true;
                    series.Style.Callout.Position = LabelPosition.Top;
                    series.Style.Callout.DisplayTextAndFormat = "{0} : {2}";
                    series.Style.Callout.Border.Color = Color.FromArgb( 0, 120, 212 );
                    series.Style.Callout.Color = Color.FromArgb( 55, 55, 55 );
                    series.Style.Callout.TextColor = Color.FromArgb( 0, 120, 212 );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the primary axis.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="type">The type.</param>
        /// <param name="orientation">The orientation.</param>
        public void SetPrimaryAxis( string title, ChartValueType type = ChartValueType.Category,
            ChartOrientation orientation = ChartOrientation.Horizontal )
        {
            if( !string.IsNullOrEmpty( title ) )
            {
                try
                {
                    PrimaryXAxis.IsVisible = true;
                    PrimaryXAxis.AutoSize = true;
                    PrimaryXAxis.ShowAxisLabelTooltip = true;
                    PrimaryXAxis.TitleColor = Color.DarkGray;
                    PrimaryXAxis.TitleFont = new Font( "Roboto", 8 );
                    PrimaryXAxis.ValueType = type;
                    PrimaryXAxis.Title = title;
                    PrimaryXAxis.Orientation = orientation;
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
        /// <param name="title">The title.</param>
        /// <param name="showBorders">if set to <c>true</c> [show borders].</param>
        public void SetTitle( string title, bool showBorders = false )
        {
            if( !string.IsNullOrEmpty( title ) )
            {
                try
                {
                    Title.Visible = !showBorders;
                    Title.ShowBorder = showBorders;
                    Title.Font = new Font( "Roboto", 9 );
                    Title.AutoSize = !showBorders;
                    Title.BackColor = Color.Transparent;
                    Title.ForeColor = Color.FromArgb( 0, 120, 212 );
                    Title.Orientation = ChartOrientation.Horizontal;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the chart area properties.
        /// </summary>
        protected void SetChartAreaProperties( )
        {
            try
            {
                ChartArea.AdjustPlotAreaMargins = ChartSetMode.AutoSet;
                ChartArea.AutoScale = true;
                ChartArea.BackInterior = new BrushInfo( Color.FromArgb( 20, 20, 20 ) );
                ChartArea.BorderWidth = 1;
                ChartArea.BorderColor = Color.Transparent;
                ChartArea.BorderStyle = BorderStyle.None;
                ChartAreaMargins = new ChartMargins( 3, 3, 3, 3 );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the chart toolbar properties.
        /// </summary>
        protected void SetToolbarProperties( )
        {
            try
            {
                ToolBar.Orientation = ChartOrientation.Horizontal;
                ToolBar.BackColor = Color.FromArgb( 20, 20, 20 );
                ToolBar.ButtonBackColor = Color.FromArgb( 20, 20, 20 );
                ToolBar.Position = ChartDock.Floating;
                ToolBar.ShowGrip = false;
                ToolBar.ShowBorder = false;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the legend properties.
        /// </summary>
        protected void SetLegendProperties( )
        {
            try
            {
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
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
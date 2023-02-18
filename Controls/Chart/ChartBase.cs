// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso
    /// cref="ChartControl" />
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ChartBase : ChartControl
    {
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ChartBase"/> class.
        /// </summary>
        protected ChartBase( )
        {
        }
        
        /// <summary>
        /// Creates the series.
        /// </summary>
        /// <returns>
        /// </returns>
        protected void InitSeries( ChartSeries series )
        {
            if( series != null )
            {
                try
                {
                    // Basic Properties
                    series.SmartLabels =
                        true;
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
        /// Sets the primary axis.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        /// <param name="title">The title.</param>
        /// <param name="type">The type.</param>
        /// <param name="orientation">The orientation.</param>
        public void SetPrimaryAxis( Font font, Color color, string title, 
            ChartValueType type = ChartValueType.Category, 
            ChartOrientation orientation = ChartOrientation.Horizontal )
        {
            if( font != null 
               && color != Color.Empty 
               && !string.IsNullOrEmpty( title ) )
            {
                try
                {
                    PrimaryXAxis.TitleColor = color;
                    PrimaryXAxis.TitleFont = font;
                    PrimaryXAxis.ValueType = type;
                    PrimaryXAxis.IsVisible = true;
                    PrimaryXAxis.Title = title;
                    PrimaryXAxis.Orientation = orientation;
                    PrimaryXAxis.AutoSize = true;
                    PrimaryXAxis.ShowAxisLabelTooltip = true;
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
        /// <param name="foreColor">Color of the fore.</param>
        /// <param name="title">The title.</param>
        public void SetTitle( Font font, Color foreColor, string title )
        {
            if( foreColor != Color.Empty
               && !string.IsNullOrEmpty( title )
               && font != null  )
            {
                try
                {
                    Title.Font = font;
                    Title.ShowBorder = false;
                    Title.BackColor = Color.Transparent;
                    Title.ForeColor = foreColor;
                    Title.Visible = true;
                    Title.AutoSize = true;
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

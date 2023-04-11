// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    public class Legend : ChartLegend
    {
        public IList<string> Names { get; set; }

        public Legend( )
        {
            BackColor = Color.Transparent;
            VisibleCheckBox = true;
            ShowBorder = true;
            Font = new Font( "Roboto", 8 );
            BackInterior = new BrushInfo( Color.Transparent );
            Position = ChartDock.Right;
            Alignment = ChartAlignment.Far;
            Behavior = ChartDockingFlags.Movable;
            ForeColor = Color.FromArgb( 0, 120, 212 );
            Spacing = 5;
            RepresentationType = ChartLegendRepresentationType.SeriesType;
            ShowSymbol = true;
        }

        private void SetDefaultItemStyle( )
        {
            try
            {
                if( Items?.Any( ) == true )
                {
                    foreach( var item in Items )
                    {
                        item.Spacing = 5;
                        item.Border.Color = Color.FromArgb( 55, 55, 55 );
                        item.VisibleCheckBox = true;
                        item.IsChecked = true;
                        item.Font = new Font( "Roboto", 8 );
                        item.TextColor = Color.FromArgb( 0, 120, 212 );
                        item.Type = ChartLegendItemType.Triangle;
                        item.ShowSymbol = true;
                        item.ShowIcon = true;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        private void SetItemStyle( Color textColor, Color borderColor, Color insideColor, 
            bool checkBox = true, ChartLegendItemType itemType = ChartLegendItemType.Triangle )
        {
            try
            {
                if( Items?.Any( ) == true )
                {
                    foreach( var item in Items )
                    {
                        item.Spacing = 5;
                        item.Interior = new BrushInfo( insideColor );
                        item.Border.Color = borderColor;
                        item.VisibleCheckBox = checkBox;
                        item.IsChecked = checkBox;
                        item.Font = new Font( "Roboto", 8 );
                        item.TextColor = textColor;
                        item.Type = itemType;
                        item.ShowSymbol = true;
                        item.ShowIcon = true;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        private void SetItemSize( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        private void SetItemText( string name )
        {
            try
            {
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
        private void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
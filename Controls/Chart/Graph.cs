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
        public Graph( )
        {
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
            if( PrimaryXAxis != null 
               && !string.IsNullOrEmpty( title ) )
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
        /// <param name="borders">if set to <c>true</c> [show borders].</param>
        public void SetTitle( string title, bool borders = false )
        {
            if( Title != null 
               && !string.IsNullOrEmpty( title ) )
            {
                try
                {
                    Title.Visible = !borders;
                    Title.ShowBorder = borders;
                    Title.Font = new Font( "Roboto", 9 );
                    Title.AutoSize = !borders;
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
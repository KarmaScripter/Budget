﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    public class ColorConfig
    {
        /// <summary>
        /// The border dark
        /// </summary>
        public static readonly Color DarkBorder = Color.FromArgb( 65, 65, 65 );

        /// <summary>
        /// The border blue
        /// </summary>
        public static readonly Color BlueBorder = Color.FromArgb( 0, 120, 212 );

        /// <summary>
        /// The border red
        /// </summary>
        public static readonly Color RedBorder = Color.FromArgb( 192, 0, 0 );

        /// <summary>
        /// The form dark back color
        /// </summary>
        public static readonly Color DarkBarkGround = Color.FromArgb( 20, 20, 20 );

        /// <summary>
        /// The fore red
        /// </summary>
        public static readonly Color RedForeground = Color.FromArgb( 192, 0, 0 );

        /// <summary>
        /// The fore gray
        /// </summary>
        public static readonly Color GrayForeground = Color.FromArgb( 141, 139, 138 );

        /// <summary>
        /// The fore white
        /// </summary>
        public static readonly Color WhiteForeground = Color.White;

        /// <summary>
        /// The fore black
        /// </summary>
        public static readonly Color BlackForeground = Color.Black;

        /// <summary>
        /// The control interior color
        /// </summary>
        public static readonly Color DarkInterior = Color.FromArgb( 40, 40, 40 );

        /// <summary>
        /// The transparent
        /// </summary>
        public static readonly Color Transparent = Color.Transparent;
        
        /// <summary>
        /// The hover yellow
        /// </summary>
        public static readonly Color HoverYellow = Color.FromArgb( 24, 19, 1 );

        /// <summary>
        /// The hover gray
        /// </summary>
        public static readonly Color HoverGray = Color.FromArgb( 70, 70, 70 );

        /// <summary>
        /// The hover blue
        /// </summary>
        public static readonly Color HoverBlue = Color.FromArgb( 50, 93, 129 );

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorConfig"/> class.
        /// </summary>
        public ColorConfig( )
        {
        }
        
        /// <summary>
        /// Called when [color changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public static void OnColorChanged( object sender, EventArgs e )
        {
            if( sender != null
               && e != null )
            {
                try
                {
                    var message = new Message( "NOT YET IMPLEMENTED" );
                    message?.ShowDialog( );
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
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
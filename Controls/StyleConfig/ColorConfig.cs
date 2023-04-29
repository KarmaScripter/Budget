// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public struct ColorConfig
    {
        /// <summary>
        /// The border dark
        /// </summary>
        public Color DarkBorder { get; set; }

        /// <summary>
        /// The border blue
        /// </summary>
        public Color BlueBorder { get; set; }

        /// <summary>
        /// The border red
        /// </summary>
        public Color RedBorder { get; set; }

        /// <summary>
        /// The form dark back color
        /// </summary>
        public Color DarkBackground { get; set; }

        /// <summary>
        /// The fore red
        /// </summary>
        public Color RedText { get; set; }

        /// <summary>
        /// The fore gray
        /// </summary>
        public Color GrayText { get; set; }

        /// <summary>
        /// The fore white
        /// </summary>
        public Color WhiteText { get; set; }

        /// <summary>
        /// The fore black
        /// </summary>
        public Color BlackText { get; set; }

        /// <summary>
        /// The control interior color
        /// </summary>
        public Color DarkInterior { get; set; }

        /// <summary>
        /// The transparent
        /// </summary>
        public Color Transparent { get; set; }
        
        /// <summary>
        /// The hover gray
        /// </summary>
        public Color HoverGray { get; set; }

        /// <summary>
        /// The hover blue
        /// </summary>
        public Color HoverBlue { get; set; }

        /// <summary>
        /// The hover blue
        /// </summary>
        public Color SteelBlue { get; set; }

        /// <summary>
        /// Initializes a new
        /// instance of the <see cref="ColorConfig"/> class.
        /// </summary>
        public ColorConfig( )
        {
            BlueBorder = Color.FromArgb( 0, 120, 212 );
            HoverBlue = Color.FromArgb( 50, 93, 129 );
            Transparent = Color.Transparent;
            HoverGray = Color.FromArgb( 70, 70, 70 );
            DarkInterior = Color.FromArgb( 40, 40, 40 );
            BlackText = Color.Black;
            WhiteText = Color.White;
            RedText = Color.FromArgb( 192, 0, 0 );
            BlueBorder = Color.FromArgb( 0, 120, 212 );
            RedBorder = Color.FromArgb( 192, 0, 0 );
            DarkBorder = Color.FromArgb( 65, 65, 65 );
            DarkBackground = Color.FromArgb( 20, 20, 20 );
            GrayText = Color.DarkGray;
            SteelBlue = Color.SteelBlue;
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
                    var _msg = "NOT YET IMPLEMENTED!!";
                    var _notification = new Notification( _msg );
                    _notification.Show( );
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
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
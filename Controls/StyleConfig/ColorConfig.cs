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
    public class ColorConfig
    {
        /// <summary>
        /// The border dark
        /// </summary>
        public Color DarkBorder { get; }

        /// <summary>
        /// The border blue
        /// </summary>
        public Color BlueBorder { get; }

        /// <summary>
        /// The border red
        /// </summary>
        public Color RedBorder { get; }

        /// <summary>
        /// The form dark back color
        /// </summary>
        public Color DarkBackground { get; }

        /// <summary>
        /// The fore red
        /// </summary>
        public Color RedText { get; }

        /// <summary>
        /// The fore gray
        /// </summary>
        public Color GrayText { get; }

        /// <summary>
        /// The fore white
        /// </summary>
        public Color WhiteText { get; }

        /// <summary>
        /// The fore black
        /// </summary>
        public Color BlackText { get; }

        /// <summary>
        /// The control interior color
        /// </summary>
        public Color DarkInterior { get; }

        /// <summary>
        /// The transparent
        /// </summary>
        public Color Transparent { get; }
        
        /// <summary>
        /// The hover gray
        /// </summary>
        public Color HoverGray { get; }

        /// <summary>
        /// The hover blue
        /// </summary>
        public Color HoverBlue { get; }

        /// <summary>
        /// The hover blue
        /// </summary>
        public Color SteelBlue { get; }

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
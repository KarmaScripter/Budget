// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ColorConfig.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ColorConfig.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ColorConfig
    {
        /// <summary> The border blue </summary>
        public Color Blue { get; }

        /// <summary> The fore red </summary>
        public Color Red { get; }

        /// <summary> The fore gray </summary>
        public Color Gray { get; }

        /// <summary> The fore white </summary>
        public Color White { get; }

        /// <summary> The fore black </summary>
        public Color Black { get; }

        /// <summary> The transparent </summary>
        public Color Transparent { get; }

        /// <summary> The hover gray </summary>
        public Color HoverGray { get; }

        /// <summary> The hover blue </summary>
        public Color HoverBlue { get; }

        /// <summary> The hover blue </summary>
        public Color SteelBlue { get; }

        /// <summary> Gets the maroon. </summary>
        /// <value> The maroon. </value>
        public Color Maroon { get; }

        /// <summary> Gets the light steel blue. </summary>
        /// <value> The light steel blue. </value>
        public Color LightSteelBlue { get; }

        /// <summary> The control interior color </summary>
        public Color DarkInterior { get; }

        /// <summary> The border dark </summary>
        public Color DarkBorder { get; }

        /// <summary> The form dark back color </summary>
        public Color DarkBackground { get; }

        /// <summary> Gets the dark blue. </summary>
        /// <value> The dark blue. </value>
        public Color DarkBlue { get; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ColorConfig"/>
        /// class.
        /// </summary>
        public ColorConfig( )
        {
            Blue = Color.FromArgb( 0, 120, 212 );
            HoverBlue = Color.FromArgb( 50, 93, 129 );
            Transparent = Color.Transparent;
            HoverGray = Color.FromArgb( 70, 70, 70 );
            DarkInterior = Color.FromArgb( 40, 40, 40 );
            Black = Color.Black;
            White = Color.White;
            Red = Color.FromArgb( 192, 0, 0 );
            DarkBorder = Color.FromArgb( 65, 65, 65 );
            DarkBackground = Color.FromArgb( 20, 20, 20 );
            DarkBlue = Color.FromArgb( 24, 47, 66 );
            Gray = Color.DarkGray;
            SteelBlue = Color.SteelBlue;
            Maroon = Color.Maroon;
            LightSteelBlue = Color.LightSteelBlue;
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
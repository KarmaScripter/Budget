﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="BrowserHotKey.cs" company="Terry D. Eppler">
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
//   BrowserHotKey.cs
// </summary>
// ******************************************************************************************


namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// object for holding hot key data
    /// </summary>
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class BrowserHotKey
    {
        /// <summary>
        /// The alt
        /// </summary>
        public bool Alt;

        /// <summary>
        /// The callback
        /// </summary>
        public Action Callback;

        /// <summary>
        /// The control
        /// </summary>
        public bool Ctrl;

        /// <summary>
        /// The key
        /// </summary>
        public Keys Key;

        /// <summary>
        /// The key code
        /// </summary>
        public int KeyCode;

        /// <summary>
        /// The shift
        /// </summary>
        public bool Shift;

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserHotKey"/> class.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="key">The key.</param>
        /// <param name="ctrl">if set to <c>true</c> [control].</param>
        /// <param name="shift">if set to <c>true</c> [shift].</param>
        /// <param name="alt">if set to <c>true</c> [alt].</param>
        public BrowserHotKey( Action callback, Keys key, bool ctrl = false, bool shift = false,
            bool alt = false )
        {
            Callback = callback;
            Key = key;
            KeyCode = (int)key;
            Ctrl = ctrl;
            Shift = shift;
            Alt = alt;
        }
    }
}
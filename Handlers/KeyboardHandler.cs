// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="KeyboardHandler.cs" company="Terry D. Eppler">
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
//   KeyboardHandler.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using CefSharp;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    internal class KeyboardHandler : IKeyboardHandler
    {
        private WebBrowser _myForm;

        public static List<BrowserHotKey> Hotkeys = new( );

        public KeyboardHandler( WebBrowser form )
        {
            _myForm = form;
        }

        public static void AddHotKey( Form form, Action function, Keys key, bool ctrl = false,
            bool shift = false, bool alt = false )
        {
            WebUtils.AddHotKey( form, function, key, ctrl, shift,
                alt );

            Hotkeys.Add( new BrowserHotKey( function, key, ctrl, shift, alt ) );
        }

        // Summary:
        //     Called before a keyboard event is sent to the renderer. Return true if the event
        //     was handled or false otherwise. If the event will be handled in
        //     CefSharp.IKeyboardHandler.OnKeyEvent(CefSharp.IWebBrowser,CefSharp.IBrowser,CefSharp.KeyType,
        //     System.Int32,System.Int32,CefSharp.CefEventFlags,System.Boolean)
        //     as a keyboard shortcut set isKeyboardShortcut to true and return false.
        //
        // Parameters:
        //   chromiumWebBrowser:
        //     the ChromiumWebBrowser control
        //
        //   browser:
        //     The browser instance.
        //
        //   type:
        //     Whether this was a key up/down/raw/etc...
        //
        //   windowsKeyCode:
        //     The Windows key code for the key event. This value is used by the DOM specification.
        //     Sometimes it comes directly from the event (i.e. on Windows) and sometimes it's
        //     determined using a mapping function. See WebCore/platform/chromium/KeyboardCodes.h
        //     for the list of values.
        //
        //   nativeKeyCode:
        //     The native key code. On Windows this appears to be in the format of WM_KEYDOWN/WM_KEYUP/etc...
        //     lParam data.
        //
        //   modifiers:
        //     What other modifier keys are currently down: Shift/Control/Alt/OS X Command/etc...
        //
        //   isSystemKey:
        //     Indicates whether the event is considered a "system key"
        //     event (see http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx
        //     for details).
        //
        //   isKeyboardShortcut:
        //     See the summary for an explanation of when to set this to true.
        //
        // Returns:
        //     Returns true if the event was handled or false otherwise.
        public bool OnPreKeyEvent( IWebBrowser browserControl, IBrowser browser, KeyType type,
            int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey,
            ref bool isKeyboardShortcut )
        {
            return false;
        }

        //
        // Summary:
        //     Called after the renderer and JavaScript in the page has had a chance to handle
        //     the event. Return true if the keyboard event was handled or false otherwise.
        //
        // Parameters:
        //   chromiumWebBrowser:
        //     the ChromiumWebBrowser control
        //
        //   browser:
        //     The browser instance.
        //
        //   type:
        //     Whether this was a key up/down/raw/etc...
        //
        //   windowsKeyCode:
        //     The Windows key code for the key event. This value is used by the DOM specification.
        //     Sometimes it comes directly from the event (i.e. on Windows) and sometimes it's
        //     determined using a mapping function. See WebCore/platform/chromium/KeyboardCodes.h
        //     for the list of values.
        //
        //   nativeKeyCode:
        //     The native key code. On Windows this appears to be in the format of WM_KEYDOWN/WM_KEYUP/etc...
        //     lParam data.
        //
        //   modifiers:
        //     What other modifier keys are currently down: Shift/Control/Alt/OS X Command/etc...
        //
        //   isSystemKey:
        //     Indicates whether the event is considered a "system key" event
        //     (see http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx
        //     for details).
        //
        // Returns:
        //     Return true if the keyboard event was handled or false otherwise.
        public bool OnKeyEvent( IWebBrowser browserControl, IBrowser browser, KeyType type,
            int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey )
        {
            if( type == KeyType.RawKeyDown )
            {
                var mod = (int)modifiers;
                var ctrlDown = mod.IsBitmaskOn( (int)CefEventFlags.ControlDown );
                var shiftDown = mod.IsBitmaskOn( (int)CefEventFlags.ShiftDown );
                var altDown = mod.IsBitmaskOn( (int)CefEventFlags.AltDown );

                foreach( var key in Hotkeys )
                {
                    if( key.KeyCode == windowsKeyCode )
                    {
                        if( key.Ctrl == ctrlDown
                           && key.Shift == shiftDown
                           && key.Alt == altDown )
                        {
                            _myForm.InvokeOnParent( delegate
                            {
                                key.Callback( );
                            } );
                        }
                    }
                }

                //Debug.WriteLine(String.Format("OnKeyEvent: KeyType: {0} 0x{1:X} Modifiers: {2}", type, windowsKeyCode, modifiers));
            }

            return false;
        }
    }
}
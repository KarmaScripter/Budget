// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-03-2023
// ******************************************************************************************
// <copyright file="ContextMenuHandler.cs" company="Terry D. Eppler">
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
//   ContextMenuHandler.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using CefSharp;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CefSharp.IContextMenuHandler" />
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    internal class ContextMenuHandler : IContextMenuHandler
    {
        /// <summary>
        /// The last sel text
        /// </summary>
        private string _lastSelText = "";

        /// <summary>
        /// My form
        /// </summary>
        private readonly WebBrowser _browser;

        /// <summary>
        /// The show dev tools
        /// </summary>
        private const int ShowDevTools = 26501;

        /// <summary>
        /// The close dev tools
        /// </summary>
        private const int CloseDevTools = 26502;

        /// <summary>
        /// The save image as
        /// </summary>
        private const int SaveImageAs = 26503;

        /// <summary>
        /// The save as PDF
        /// </summary>
        private const int SaveAsPdf = 26504;

        /// <summary>
        /// The save link as
        /// </summary>
        private const int SaveLinkAs = 26505;

        /// <summary>
        /// The copy link address
        /// </summary>
        private const int CopyLinkAddress = 26506;

        /// <summary>
        /// The open link in new tab
        /// </summary>
        private const int OpenLinkInNewTab = 26507;

        /// <summary>
        /// The close tab
        /// </summary>
        private const int CloseTab = 40007;

        /// <summary>
        /// The refresh tab
        /// </summary>
        private const int RefreshTab = 40008;

        /// <summary>
        /// The print
        /// </summary>
        private const int Print = 26508;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ContextMenuHandler"/> class.
        /// </summary>
        /// <param name="form">
        /// The form.
        /// </param>
        public ContextMenuHandler( WebBrowser form )
        {
            _browser = form;
        }

        /// <summary>
        /// Called before a context menu is displayed. The model can be cleared to show no
        /// context menu or modified to show a custom menu.
        /// </summary>
        /// <param name="browserControl">
        /// The browser control.
        /// </param>
        /// <param name="browser">
        /// The browser.
        /// </param>
        /// <param name="frame">
        /// The frame.
        /// </param>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <param name="model">
        /// The model.
        /// </param>
        public void OnBeforeContextMenu( IWebBrowser browserControl, IBrowser browser, IFrame frame,
            IContextMenuParams parameters, IMenuModel model )
        {
            model.Clear( );
            _lastSelText = parameters.SelectionText;
            if( parameters.SelectionText.CheckIfValid( ) )
            {
                model.AddItem( CefMenuCommand.Copy, "Copy" );
                model.AddSeparator( );
            }

            if( parameters.LinkUrl != "" )
            {
                model.AddItem( (CefMenuCommand)OpenLinkInNewTab,
                    "Open link in new tab" );

                model.AddItem( (CefMenuCommand)CopyLinkAddress, "Copy link" );
                model.AddSeparator( );
            }

            if( parameters.HasImageContents
               && parameters.SourceUrl.CheckIfValid( ) )
            {
                // RIGHT CLICKED ON IMAGE
            }

            if( parameters.SelectionText != null )
            {
                // TEXT IS SELECTED
            }

            model.AddItem( (CefMenuCommand)ShowDevTools, "Developer tools" );
            model.AddItem( CefMenuCommand.ViewSource, "View source" );
            model.AddSeparator( );
            model.AddItem( (CefMenuCommand)RefreshTab, "Refresh tab" );
            model.AddItem( (CefMenuCommand)CloseTab, "Close tab" );
            model.AddSeparator( );
            model.AddItem( (CefMenuCommand)SaveAsPdf, "Save as PDF" );
            model.AddItem( (CefMenuCommand)Print, "Print Page" );
        }

        /// <summary>
        /// Called to execute a command selected from the context menu. See cef_menu_id_t
        /// for the command ids that have default implementations. All user-defined command
        /// ids should be between MENU_ID_USER_FIRST and MENU_ID_USER_LAST.
        /// </summary>
        /// <param name="browserControl">The browser control.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="commandId">The command identifier.</param>
        /// <param name="eventFlags">The event flags.</param>
        /// <returns>
        /// Return true if the command was handled
        /// or false for the default implementation.
        /// </returns>
        public bool OnContextMenuCommand( IWebBrowser browserControl, IBrowser browser,
            IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId,
            CefEventFlags eventFlags )
        {
            var id = (int)commandId;
            switch( id )
            {
                case ShowDevTools:
                {
                    browser.ShowDevTools( );
                    break;
                }
                case CloseDevTools:
                {
                    browser.CloseDevTools( );
                    break;
                }
                case SaveImageAs:
                {
                    browser.GetHost( ).StartDownload( parameters.SourceUrl );
                    break;
                }
                case SaveLinkAs:
                {
                    browser.GetHost( ).StartDownload( parameters.LinkUrl );
                    break;
                }
                case OpenLinkInNewTab:
                {
                    var _tab = _browser.AddNewBrowserTab( parameters.LinkUrl, false,
                        browser.MainFrame.Url );

                    break;
                }
                case CopyLinkAddress:
                {
                    Clipboard.SetText( parameters.LinkUrl );
                    break;
                }
                case CloseTab:
                {
                    _browser.InvokeOnParent( delegate
                    {
                        _browser.CloseActiveTab( );
                    } );

                    break;
                }
                case RefreshTab:
                {
                    _browser.InvokeOnParent( delegate
                    {
                        _browser.RefreshActiveTab( );
                    } );

                    break;
                }
                case SaveAsPdf:
                {
                    var sfd = new SaveFileDialog( );
                    sfd.Filter = "PDF Files | *.pdf";
                    if( sfd.ShowDialog( ) == DialogResult.OK )
                    {
                        browser.PrintToPdfAsync( sfd.FileName, new PdfPrintSettings( )
                        {
                            PrintBackground = true
                        } );
                    }

                    break;
                }
                case Print:
                {
                    browser.Print( );
                    break;
                }
            }

            return false;
        }

        /// <summary>
        /// Called when the context menu is dismissed
        /// irregardless of whether the menu was
        /// empty or a command was selected.
        /// </summary>
        /// <param name="browserControl">
        /// The browser control.
        /// </param>
        /// <param name="browser">
        /// The browser.
        /// </param>
        /// <param name="frame">
        /// The frame.
        /// </param>
        public void OnContextMenuDismissed( IWebBrowser browserControl, IBrowser browser,
            IFrame frame )
        {
        }

        /// <summary>
        /// Called to allow custom display of the context menu. For custom display return
        /// true and execute callback either synchronously or asynchronously with the selected
        /// command Id. For default display return false. Do not keep references to parameters
        /// or model outside of this callback.
        /// </summary>
        /// <param name="browserControl">The browser control.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="model">The model.</param>
        /// <param name="callback">The callback.</param>
        /// <returns>
        /// For custom display return true and
        /// execute callback either synchronously or asynchronously
        /// with the selected command ID.
        /// </returns>
        public bool RunContextMenu( IWebBrowser browserControl, IBrowser browser, IFrame frame,
            IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback )
        {
            // show default menu
            return false;
        }
    }
}
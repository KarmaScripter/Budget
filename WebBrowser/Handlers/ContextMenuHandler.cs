// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
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
    using System.Windows.Forms;

    internal class ContextMenuHandler : IContextMenuHandler
    {
        private string _lastSelText = "";

        private readonly WebBrowser _myForm;

        private const int ShowDevTools = 26501;

        private const int CloseDevTools = 26502;

        private const int SaveImageAs = 26503;

        private const int SaveAsPdf = 26504;

        private const int SaveLinkAs = 26505;

        private const int CopyLinkAddress = 26506;

        private const int OpenLinkInNewTab = 26507;

        private const int CloseTab = 40007;

        private const int RefreshTab = 40008;

        private const int Print = 26508;

        public ContextMenuHandler( WebBrowser form )
        {
            _myForm = form;
        }

        //
        // Summary:
        //     Called before a context menu is displayed. The model can be cleared to show no
        //     context menu or modified to show a custom menu.
        //
        // Parameters:
        //   chromiumWebBrowser:
        //     the ChromiumWebBrowser control
        //
        //   browser:
        //     the browser object
        //
        //   frame:
        //     The frame the request is coming from
        //
        //   parameters:
        //     provides information about the context menu state
        //
        //   model:
        //     initially contains the default context menu
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
                model.AddItem( (CefMenuCommand)ContextMenuHandler.OpenLinkInNewTab,
                    "Open link in new tab" );

                model.AddItem( (CefMenuCommand)ContextMenuHandler.CopyLinkAddress, "Copy link" );
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

            model.AddItem( (CefMenuCommand)ContextMenuHandler.ShowDevTools, "Developer tools" );
            model.AddItem( CefMenuCommand.ViewSource, "View source" );
            model.AddSeparator( );
            model.AddItem( (CefMenuCommand)ContextMenuHandler.RefreshTab, "Refresh tab" );
            model.AddItem( (CefMenuCommand)ContextMenuHandler.CloseTab, "Close tab" );
            model.AddSeparator( );
            model.AddItem( (CefMenuCommand)ContextMenuHandler.SaveAsPdf, "Save as PDF" );
            model.AddItem( (CefMenuCommand)ContextMenuHandler.Print, "Print Page" );
        }

        //
        // Summary:
        //     Called to execute a command selected from the context menu. See cef_menu_id_t
        //     for the command ids that have default implementations. All user-defined command
        //     ids should be between MENU_ID_USER_FIRST and MENU_ID_USER_LAST.
        //
        // Parameters:
        //   chromiumWebBrowser:
        //     the ChromiumWebBrowser control
        //
        //   browser:
        //     the browser object
        //
        //   frame:
        //     The frame the request is coming from
        //
        //   parameters:
        //     will have the same values as what was passed to
        //
        //   commandId:
        //     menu command id
        //
        //   eventFlags:
        //     event flags
        //
        // Returns:
        //     Return true if the command was handled or false for the default implementation.
        public bool OnContextMenuCommand( IWebBrowser browserControl, IBrowser browser,
            IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId,
            CefEventFlags eventFlags )
        {
            var id = (int)commandId;

            switch( id )
            {
                case ContextMenuHandler.ShowDevTools:

                    browser.ShowDevTools( );
                    break;
                case ContextMenuHandler.CloseDevTools:

                    browser.CloseDevTools( );
                    break;
                case ContextMenuHandler.SaveImageAs:

                    browser.GetHost( ).StartDownload( parameters.SourceUrl );
                    break;
                case ContextMenuHandler.SaveLinkAs:

                    browser.GetHost( ).StartDownload( parameters.LinkUrl );
                    break;

                case ContextMenuHandler.OpenLinkInNewTab:

                {
                    var newBrowser = _myForm.AddNewBrowserTab( parameters.LinkUrl, false,
                        browser.MainFrame.Url );

                    break;
                }

                case ContextMenuHandler.CopyLinkAddress:

                    Clipboard.SetText( parameters.LinkUrl );
                    break;
                case ContextMenuHandler.CloseTab:

                    _myForm.InvokeOnParent( delegate
                    {
                        _myForm.CloseActiveTab( );
                    } );

                    break;
                case ContextMenuHandler.RefreshTab:

                    _myForm.InvokeOnParent( delegate
                    {
                        _myForm.RefreshActiveTab( );
                    } );

                    break;

                case ContextMenuHandler.SaveAsPdf:

                {
                    var sfd = new SaveFileDialog( );
                    sfd.Filter = "PDF Files | *.pdf";

                    if( sfd.ShowDialog( ) == DialogResult.OK )
                    {
                        //string path = Path.GetFileName(sfd.FileName);
                        browser.PrintToPdfAsync( sfd.FileName, new PdfPrintSettings( )
                        {
                            BackgroundsEnabled = true
                        } );
                    }

                    break;
                }

                case ContextMenuHandler.Print:

                    browser.Print( );
                    break;
            }

            return false;
        }

        //
        // Summary:
        //     Called when the context menu is dismissed irregardless of whether the menu was
        //     empty or a command was selected.
        //
        // Parameters:
        //   chromiumWebBrowser:
        //     the ChromiumWebBrowser control
        //
        //   browser:
        //     the browser object
        //
        //   frame:
        //     The frame the request is coming from
        public void OnContextMenuDismissed( IWebBrowser browserControl, IBrowser browser,
            IFrame frame )
        {
        }

        //
        // Summary:
        //     Called to allow custom display of the context menu. For custom display return
        //     true and execute callback either synchronously or asynchronously with the selected
        //     command Id. For default display return false. Do not keep references to parameters
        //     or model outside of this callback.
        //
        // Parameters:
        //   chromiumWebBrowser:
        //     the ChromiumWebBrowser control
        //
        //   browser:
        //     the browser object
        //
        //   frame:
        //     The frame the request is coming from
        //
        //   parameters:
        //     provides information about the context menu state
        //
        //   model:
        //     contains the context menu model resulting from OnBeforeContextMenu
        //
        //   callback:
        //     the callback to execute for custom display
        //
        // Returns:
        //     For custom display return true and execute callback either synchronously or asynchronously
        //     with the selected command ID.
        public bool RunContextMenu( IWebBrowser browserControl, IBrowser browser, IFrame frame,
            IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback )
        {
            // show default menu
            return false;
        }
    }
}
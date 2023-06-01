// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="DownloadHandler.cs" company="Terry D. Eppler">
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
//   DownloadHandler.cs
// </summary>
// ******************************************************************************************

using CefSharp;

namespace BudgetExecution
{
    internal class DownloadHandler : IDownloadHandler
    {
        private readonly WebBrowser myForm;

        public DownloadHandler( WebBrowser form )
        {
            myForm = form;
        }

        //
        // Summary:
        //     Called before a download begins in response to a user-initiated action (e.g.
        //     alt + link click or link click that returns a `Content-Disposition: attachment`
        //     response from the server).
        //
        // Parameters:
        //   chromiumWebBrowser:
        //     the ChromiumWebBrowser control
        //
        //   browser:
        //     The browser instance
        //
        //   url:
        //     is the target download URL
        //
        //   requestMethod:
        //     is the target method (GET, POST, etc)
        //
        // Returns:
        //     Return true to proceed with the download or false to cancel the download.
        public bool CanDownload( IWebBrowser chromiumWebBrowser, IBrowser browser, string url,
            string requestMethod )
        {
            return true;
        }

        //
        // Summary:
        //     Called before a download begins.
        //
        // Parameters:
        //   chromiumWebBrowser:
        //     the ChromiumWebBrowser control
        //
        //   browser:
        //     The browser instance
        //
        //   downloadItem:
        //     Represents the file being downloaded.
        //
        //   callback:
        //     Callback interface used to asynchronously continue a download.
        public void OnBeforeDownload( IWebBrowser webBrowser, IBrowser browser, DownloadItem item,
            IBeforeDownloadCallback callback )
        {
            if( !callback.IsDisposed )
            {
                using( callback )
                {
                    myForm.UpdateDownloadItem( item );

                    // ask browser what path it wants to save the file into
                    var path = myForm.CalcDownloadPath( item );

                    // if file should not be saved, path will be null, so skip file
                    if( path == null )
                    {
                        // skip file
                        callback.Continue( path, false );
                    }
                    else
                    {
                        // open the downloads tab
                        myForm.OpenDownloadsTab( );
                        callback.Continue( path, true );
                    }
                }
            }
        }

        //
        // Summary:
        //     Called when a download's status or progress information has been updated. This
        //     may be called multiple times before and after CefSharp.IDownloadHandler.OnBeforeDownload(CefSharp.IWebBrowser,CefSharp.IBrowser,CefSharp.DownloadItem,CefSharp.IBeforeDownloadCallback).
        //
        // Parameters:
        //   chromiumWebBrowser:
        //     the ChromiumWebBrowser control
        //
        //   browser:
        //     The browser instance
        //
        //   downloadItem:
        //     Represents the file being downloaded.
        //
        //   callback:
        //     The callback used to Cancel/Pause/Resume the process
        public void OnDownloadUpdated( IWebBrowser webBrowser, IBrowser browser,
            DownloadItem downloadItem, IDownloadItemCallback callback )
        {
            myForm.UpdateDownloadItem( downloadItem );

            if( downloadItem.IsInProgress
               && myForm.CancelRequests.Contains( downloadItem.Id ) )
            {
                callback.Cancel( );
            }

            //Console.WriteLine(downloadItem.Url + " %" + downloadItem.PercentComplete + " complete");
        }
    }
}
﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-03-2023
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

namespace BudgetExecution
{
    using CefSharp;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CefSharp.IDownloadHandler" />
    public class DownloadHandler : IDownloadHandler
    {
        /// <summary>
        /// The browser
        /// </summary>
        private readonly WebBrowser _browser;

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadHandler"/> class.
        /// </summary>
        /// <param name="form">The form.</param>
        public DownloadHandler( WebBrowser form )
        {
            _browser = form;
        }

        /// <summary>
        /// Determines whether this instance can download the specified chromium WebBrowser.
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="url">The URL.</param>
        /// <param name="requestMethod">The request method.</param>
        /// <returns>
        ///   <c>true</c> if this instance can download the specified chromium WebBrowser; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDownload( IWebBrowser chromiumWebBrowser, IBrowser browser, string url,
            string requestMethod )
        {
            return true;
        }

        /// <summary>
        /// Called when [before download].
        /// </summary>
        /// <param name="webBrowser">The web browser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="item">The item.</param>
        /// <param name="callback">The callback.</param>
        public void OnBeforeDownload( IWebBrowser webBrowser, IBrowser browser, DownloadItem item,
            IBeforeDownloadCallback callback )
        {
            if( !callback.IsDisposed )
            {
                using( callback )
                {
                    _browser.UpdateDownloadItem( item );
                    var path = _browser.GetDownloadPath( item );

                    if( path == null )
                    {
                        callback.Continue( path, false );
                    }
                    else
                    {
                        _browser.OpenDownloadsTab( );
                        callback.Continue( path, true );
                    }
                }
            }
        }

        /// <summary>
        /// Called when [download updated].
        /// </summary>
        /// <param name="webBrowser">The web browser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="downloadItem">The download item.</param>
        /// <param name="callback">The callback.</param>
        public void OnDownloadUpdated( IWebBrowser webBrowser, IBrowser browser,
            DownloadItem downloadItem, IDownloadItemCallback callback )
        {
            _browser.UpdateDownloadItem( downloadItem );

            if( downloadItem.IsInProgress
               && _browser.CancelRequests.Contains( downloadItem.Id ) )
            {
                callback.Cancel( );
            }
        }
    }
}
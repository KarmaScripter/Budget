// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="HostHandler.cs" company="Terry D. Eppler">
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
//   HostHandler.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// functions in this class are accessible by JS using the code `host.X()`
    /// </summary>
    [SuppressMessage( "ReSharper", "InconsistentlySynchronizedField" ) ]
    public class HostHandler
    {
        /// <summary>
        /// The browser
        /// </summary>
        private readonly WebBrowser _browser;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostHandler"/> class.
        /// </summary>
        /// <param name="form">The form.</param>
        public HostHandler( WebBrowser form )
        {
            _browser = form;
        }

        /// <summary>
        /// Adds the new browser tab.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="focusNewTab">if set to <c>true</c> [focus new tab].</param>
        public void AddNewBrowserTab( string url, bool focusNewTab = true )
        {
            _browser.AddNewBrowserTab( url, focusNewTab );
        }

        /// <summary>
        /// Gets the downloads.
        /// </summary>
        /// <returns></returns>
        public string GetDownloads( )
        {
            lock( _browser.Downloads )
            {
                var x = JSON.Instance.ToJSON( _browser.Downloads );
                return x;
            }
        }

        /// <summary>
        /// Cancels the download.
        /// </summary>
        /// <param name="downloadId">The download identifier.</param>
        /// <returns></returns>
        public bool CancelDownload( int downloadId )
        {
            lock( _browser.CancelRequests )
            {
                if( !_browser.CancelRequests.Contains( downloadId ) )
                {
                    _browser.CancelRequests.Add( downloadId );
                }
            }

            return true;
        }

        /// <summary>
        /// Refreshes the active tab.
        /// </summary>
        public void RefreshActiveTab( )
        {
            _browser.RefreshActiveTab( );
        }
    }
}
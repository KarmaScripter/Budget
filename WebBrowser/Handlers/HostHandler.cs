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
    [ SuppressMessage( "ReSharper", "InconsistentlySynchronizedField" ) ]
    internal class HostHandler
    {
        private readonly WebBrowser _myForm;

        public HostHandler( WebBrowser form )
        {
            _myForm = form;
        }

        public void AddNewBrowserTab( string url, bool focusNewTab = true )
        {
            _myForm.AddNewBrowserTab( url, focusNewTab );
        }

        public string GetDownloads( )
        {
            lock( _myForm.downloads )
            {
                var x = JSON.Instance.ToJSON( _myForm.downloads );
                return x;
            }
        }

        public bool CancelDownload( int downloadId )
        {
            lock( _myForm.DownloadCancelRequests )
            {
                if( !_myForm.DownloadCancelRequests.Contains( downloadId ) )
                {
                    _myForm.DownloadCancelRequests.Add( downloadId );
                }
            }

            return true;
        }

        public void RefreshActiveTab( )
        {
            _myForm.RefreshActiveTab( );
        }
    }
}
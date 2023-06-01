// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="BrowserConfig.cs" company="Terry D. Eppler">
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
//   BrowserConfig.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution.Browser
{
    using CefSharp;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    internal static class BrowserConfig
    {
        public static string Branding = "Budget Browser";

        public static string AcceptLanguage = "en-US,en;q=0.9";

        public static string UserAgent =
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.5112.102 Safari/537.36 /CefSharp Browser"
            + Cef.CefSharpVersion;// UserAgent to fix issue with Google account authentication		

        public static string HomepageURL = "https://www.google.com";

        public static string NewTabURL = "about:blank";

        public static string InternalURL = "budgetbrowser";

        public static string DownloadsURL = "budgetbrowser://storage/downloads.html";

        public static string FileNotFoundURL = "budgetbrowser://storage/errors/notFound.html";

        public static string CannotConnectURL = "budgetbrowser://storage/errors/cannotConnect.html";

        public static string SearchURL = "https://www.google.com/search?q=";

        public static bool WebSecurity = true;

        public static bool CrossDomainSecurity = true;

        public static bool WebGL = true;

        public static bool ApplicationCache = true;

        public static bool Proxy = false;

        public static string ProxyIP = "123.123.123.123";

        public static int ProxyPort = 123;

        public static string ProxyUsername = "username";

        public static string ProxyPassword = "pass";

        public static string ProxyBypassList = "";
    }
}
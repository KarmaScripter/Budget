namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;
    using CefSharp;
    using System.Windows.Forms;
    using System.Drawing;
    using CefSharp.Callback;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CefSharp.IResourceRequestHandler" />
    internal class ResourceRequestHandler : IResourceRequestHandler
    {
        /// <summary>
        /// The browser
        /// </summary>
        private readonly WebBrowser _browser;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceRequestHandler"/> class.
        /// </summary>
        /// <param name="form">The form.</param>
        public ResourceRequestHandler( WebBrowser form )
        {
            _browser = form;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose( )
        {
        }

        /// <summary>
        /// Gets the cookie access filter.
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public ICookieAccessFilter GetCookieAccessFilter( IWebBrowser chromiumWebBrowser,
            IBrowser browser, IFrame frame, IRequest request )
        {
            return null;
        }

        /// <summary>
        /// Gets the resource handler.
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public IResourceHandler GetResourceHandler( IWebBrowser chromiumWebBrowser,
            IBrowser browser, IFrame frame, IRequest request )
        {
            return null;
        }

        /// <summary>
        /// Gets the resource response filter.
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <param name="response">The response.</param>
        /// <returns></returns>
        public IResponseFilter GetResourceResponseFilter( IWebBrowser chromiumWebBrowser,
            IBrowser browser, IFrame frame, IRequest request, IResponse response )
        {
            return null;
        }

        /// <summary>
        /// Called when [before resource load].
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <param name="callback">The callback.</param>
        /// <returns></returns>
        public CefReturnValue OnBeforeResourceLoad( IWebBrowser chromiumWebBrowser,
            IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback )
        {
            var tab = _browser.GetTabByBrowser( chromiumWebBrowser );

            if( tab != null
               && tab.ReferringUrl != null )
            {
                request.SetReferrer( tab.ReferringUrl, ReferrerPolicy.Default );
            }

            return CefReturnValue.Continue;
        }

        /// <summary>
        /// Called when [protocol execution].
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public bool OnProtocolExecution( IWebBrowser chromiumWebBrowser, IBrowser browser,
            IFrame frame, IRequest request )
        {
            return true;
        }

        /// <summary>
        /// Called when [resource load complete].
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <param name="response">The response.</param>
        /// <param name="status">The status.</param>
        /// <param name="receivedContentLength">Length of the received content.</param>
        public void OnResourceLoadComplete( IWebBrowser chromiumWebBrowser, IBrowser browser,
            IFrame frame, IRequest request, IResponse response, UrlRequestStatus status,
            long receivedContentLength )
        {
            var code = response.StatusCode;

            if( !frame.IsValid )
            {
                return;
            }

            if( code == 404 )
            {
                if( !request.Url.IsLocalhost( ) )
                {
                    frame.LoadUrl( "http://web.archive.org/web/*/" + request.Url );
                }
                else
                {
                    frame.LoadUrl( BrowserConfig.FileNotFoundURL
                        + "?path="
                        + request.Url.UrlEncode( ) );
                }
            }

            else if( request.Url.IsFileOffline( ) )
            {
                var path = request.Url.FileURLToPath( );

                if( path.FileNotExists( ) )
                {
                    frame.LoadUrl( BrowserConfig.FileNotFoundURL + "?path=" + path.UrlEncode( ) );
                }
            }
            else
            {
                if( code == 444
                   || code >= 500 && code <= 599 )
                {
                    frame.LoadUrl( BrowserConfig.CannotConnectURL );
                }
            }
        }

        /// <summary>
        /// Called when [resource redirect].
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <param name="response">The response.</param>
        /// <param name="newUrl">The new URL.</param>
        public void OnResourceRedirect( IWebBrowser chromiumWebBrowser, IBrowser browser,
            IFrame frame, IRequest request, IResponse response, ref string newUrl )
        {
        }

        /// <summary>
        /// Called when [resource response].
        /// </summary>
        /// <param name="chromiumWebBrowser">The chromium WebBrowser.</param>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="request">The request.</param>
        /// <param name="response">The response.</param>
        /// <returns></returns>
        public bool OnResourceResponse( IWebBrowser chromiumWebBrowser, IBrowser browser,
            IFrame frame, IRequest request, IResponse response )
        {
            return false;
        }
    }
}
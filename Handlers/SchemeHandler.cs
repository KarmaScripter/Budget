﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-04-2023
// ******************************************************************************************
// <copyright file="SchemeHandler.cs" company="Terry D. Eppler">
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
//   SchemeHandler.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;
    using CefSharp;
    using System.Windows.Forms;
    using CefSharp.Callback;
    using System.Diagnostics.CodeAnalysis;
    using Cookie = CefSharp.Cookie;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CefSharp.IResourceHandler" />
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    internal class SchemeHandler : IResourceHandler
    {
        /// <summary>
        /// The file name
        /// </summary>
        private string _fileName;

        /// <summary>
        /// The MIME type
        /// </summary>
        private string _mimeType;

        /// <summary>
        /// The browser
        /// </summary>
        private WebBrowser _browser;

        /// <summary>
        /// The stream
        /// </summary>
        private Stream _stream;

        /// <summary>
        /// The URI
        /// </summary>
        private Uri _uri;

        /// <summary>
        /// The application path
        /// </summary>
        private static readonly string _path = Path.GetDirectoryName( Application.ExecutablePath ) + @"\";

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SchemeHandler"/> class.
        /// </summary>
        /// <param name="form">The form.</param>
        public SchemeHandler( WebBrowser form )
        {
            _browser = form;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing,
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose( )
        {
        }

        /// <summary>
        /// Opens the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="handleRequest">if set to <c>true</c> [handle request].</param>
        /// <param name="callBack">The callBack.</param>
        /// <returns></returns>
        public bool Open( IRequest request, out bool handleRequest, ICallback callBack )
        {
            _uri = new Uri( request.Url );
            _fileName = _uri.AbsolutePath;
            switch( _uri.Host )
            {
                case "storage":
                {
                    _fileName = _path + _uri.Host + _fileName;
                    if( File.Exists( _fileName ) )
                    {
                        Task.Factory.StartNew( ( ) =>
                        {
                            using( callBack )
                            {
                                var _fileStream = new FileStream( _fileName, FileMode.Open,
                                    FileAccess.Read );

                                _mimeType =
                                    ResourceHandler.GetMimeType( Path.GetExtension( _fileName ) );

                                _stream = _fileStream;
                                callBack.Continue( );
                            }
                        } );

                        handleRequest = false;
                        return true;
                    }

                    break;
                }
                case "fileicon":
                {
                    Task.Factory.StartNew( ( ) =>
                    {
                        using( callBack )
                        {
                            _stream = FileIconUtils.GetFileIcon( _fileName, FileIconSize.Large );
                            _mimeType = ResourceHandler.GetMimeType( ".png" );
                            callBack.Continue( );
                        }
                    } );

                    handleRequest = false;
                    return true;
                }
            }

            callBack.Dispose( );
            handleRequest = true;
            return false;
        }

        /// <summary>
        /// Gets the response headers.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="responseLength">Length of the response.</param>
        /// <param name="redirectUrl">The redirect URL.</param>
        public void GetResponseHeaders( IResponse response, out long responseLength,
            out string redirectUrl )
        {
            responseLength = _stream?.Length ?? 0;
            redirectUrl = null;
            response.StatusCode = (int)HttpStatusCode.OK;
            response.StatusText = "OK";
            response.MimeType = _mimeType;
        }

        /// <summary>
        /// Reads the response.
        /// </summary>
        /// <param name="dataOut">The data out.</param>
        /// <param name="bytesRead">The bytes read.</param>
        /// <param name="callback">The callBack.</param>
        /// <returns></returns>
        public bool ReadResponse( Stream dataOut, out int bytesRead, ICallback callback )
        {
            callback.Dispose( );
            if( _stream == null )
            {
                bytesRead = 0;
                return false;
            }

            var _buffer = new byte[ dataOut.Length ];
            bytesRead = _stream.Read( _buffer, 0, _buffer.Length );
            dataOut.Write( _buffer, 0, _buffer.Length );
            return bytesRead > 0;
        }

        /// <summary>
        /// Reads the specified data out.
        /// </summary>
        /// <param name="dataOut">The data out.</param>
        /// <param name="bytesRead">The bytes read.</param>
        /// <param name="callback">The callBack.</param>
        /// <returns></returns>
        public bool Read( Stream dataOut, out int bytesRead, IResourceReadCallback callback )
        {
            bytesRead = -1;
            return false;
        }

        /// <summary>
        /// Skips the specified bytes to skip.
        /// </summary>
        /// <param name="bytesToSkip">The bytes to skip.</param>
        /// <param name="bytesSkipped">The bytes skipped.</param>
        /// <param name="callback">The callBack.</param>
        /// <returns></returns>
        public bool Skip( long bytesToSkip, out long bytesSkipped, IResourceSkipCallback callback )
        {
            bytesSkipped = -2;
            return false;
        }

        /// <summary>
        /// Cancels this instance.
        /// </summary>
        public void Cancel( )
        {
        }

        /// <summary>
        /// Determines whether this instance [can get cookie] the specified cookie.
        /// </summary>
        /// <param name="cookie">The cookie.</param>
        /// <returns>
        ///   <c>true</c> if this instance [can get cookie] the specified cookie; otherwise, <c>false</c>.
        /// </returns>
        public bool CanGetCookie( Cookie cookie )
        {
            return true;
        }

        /// <summary>
        /// Determines whether this instance [can set cookie] the specified cookie.
        /// </summary>
        /// <param name="cookie">The cookie.</param>
        /// <returns>
        ///   <c>true</c> if this instance [can set cookie] the specified cookie; otherwise, <c>false</c>.
        /// </returns>
        public bool CanSetCookie( Cookie cookie )
        {
            return true;
        }

        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="callback">The callBack.</param>
        /// <returns></returns>
        public bool ProcessRequest( IRequest request, ICallback callback )
        {
            return false;
        }
    }
}
// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
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
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;
    using CefSharp;
    using System.Windows.Forms;
    using System.Drawing;
    using CefSharp.Callback;
    using System.Diagnostics.CodeAnalysis;
    using Cookie = CefSharp.Cookie;

    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    internal class SchemeHandler : IResourceHandler, IDisposable
    {
        private string _fileName;

        private string _mimeType;

        private WebBrowser _myForm;

        private Stream _stream;

        private Uri _uri;

        private static string _appPath = Path.GetDirectoryName( Application.ExecutablePath ) + @"\";

        public SchemeHandler( WebBrowser form )
        {
            _myForm = form;
        }

        public void Dispose( )
        {
        }

        //
        // Summary:
        //     Open the response stream. - To handle the request immediately set handleRequest
        //     to true and return true. - To decide at a later time set handleRequest to false,
        //     return true, and execute callback to continue or cancel the request. - To cancel
        //     the request immediately set handleRequest to true and return false. This method
        //     will be called in sequence but not from a dedicated thread. For backwards compatibility
        //     set handleRequest to false and return false and the CefSharp.IResourceHandler.ProcessRequest(CefSharp.IRequest,CefSharp.ICallback)
        //     method will be called.
        //
        // Parameters:
        //   request:
        //     request
        //
        //   handleRequest:
        //     see main summary
        //
        //   callback:
        //     callback
        //
        // Returns:
        //     see main summary
        public bool Open( IRequest request, out bool handleRequest, ICallback callback )
        {
            _uri = new Uri( request.Url );
            _fileName = _uri.AbsolutePath;

            switch( _uri.Host )
            {
                case "storage":

                {
                    _fileName = SchemeHandler._appPath + _uri.Host + _fileName;

                    if( File.Exists( _fileName ) )
                    {
                        Task.Factory.StartNew( ( ) =>
                        {
                            using( callback )
                            {
                                var fStream = new FileStream( _fileName, FileMode.Open,
                                    FileAccess.Read );

                                _mimeType =
                                    ResourceHandler.GetMimeType( Path.GetExtension( _fileName ) );

                                _stream = fStream;
                                callback.Continue( );
                            }
                        } );

                        handleRequest = false;
                        return true;
                    }

                    break;
                }

                case "fileicon":

                    Task.Factory.StartNew( ( ) =>
                    {
                        using( callback )
                        {
                            _stream = FileIconUtils.GetFileIcon( _fileName, FileIconSize.Large );
                            _mimeType = ResourceHandler.GetMimeType( ".png" );
                            callback.Continue( );
                        }
                    } );

                    handleRequest = false;
                    return true;
            }

            callback.Dispose( );
            handleRequest = true;
            return false;
        }

        //
        // Summary:
        //     Retrieve response header information. If the response length is not known
        //     set responseLength to -1 and ReadResponse() will be called until it returns
        //     false. If the response length is known set responseLength to a positive value
        //     and ReadResponse() will be called until it returns false or the specified
        //     number of bytes have been read. If an error occured while setting up the
        //     request you can set CefSharp.IResponse.ErrorCode to indicate the error condition.
        //
        // Parameters:
        //   response:
        //     Use the response object to set the mime type, http status code and other
        //     optional header values.
        //
        //   responseLength:
        //     If the response length is not known set responseLength to -1
        //
        //   redirectUrl:
        //     To redirect the request to a new URL set redirectUrl to the new Url.
        public void GetResponseHeaders( IResponse response, out long responseLength,
            out string redirectUrl )
        {
            responseLength = _stream?.Length ?? 0;
            redirectUrl = null;
            response.StatusCode = (int)HttpStatusCode.OK;
            response.StatusText = "OK";
            response.MimeType = _mimeType;
        }

        //
        // Summary:
        //     Read response data. If data is available immediately copy to dataOut, set
        //     bytesRead to the number of bytes copied, and return true.  To read the data
        //     at a later time set bytesRead to 0, return true and call ICallback.Continue()
        //     when the data is available. To indicate response completion return false.
        //
        // Parameters:
        //   dataOut:
        //     Stream to write to
        //
        //   bytesRead:
        //     Number of bytes copied to the stream
        //
        //   callback:
        //     The callback used to Continue or Cancel the request (async).
        //
        // Returns:
        //     If data is available immediately copy to dataOut, set bytesRead to the number
        //     of bytes copied, and return true.To indicate response completion return false.
        //
        // Remarks:
        //     Depending on this size of your response this method may be called multiple
        //     times
        public bool ReadResponse( Stream dataOut, out int bytesRead, ICallback callback )
        {
            callback.Dispose( );

            if( _stream == null )
            {
                bytesRead = 0;
                return false;
            }

            var buffer = new byte[ dataOut.Length ];
            bytesRead = _stream.Read( buffer, 0, buffer.Length );
            dataOut.Write( buffer, 0, buffer.Length );
            return bytesRead > 0;
        }

        //
        // Summary:
        //     Read response data. If data is available immediately copy up to dataOut.Length
        //     bytes into dataOut, set bytesRead to the number of bytes copied, and return true.
        //     To read the data at a later time keep a pointer to dataOut, set bytesRead to
        //     0, return true and execute callback when the data is available (dataOut will
        //     remain valid until the callback is executed). To indicate response completion
        //     set bytesRead to 0 and return false. To indicate failure set bytesRead to < 0
        //     (e.g. -2 for ERR_FAILED) and return false. This method will be called in sequence
        //     but not from a dedicated thread. For backwards compatibility set bytesRead to
        //     -1 and return false and the ReadResponse method will be called.
        //
        // Parameters:
        //   dataOut:
        //     If data is available immediately copy up to System.IO.Stream.Length bytes into
        //     dataOut.
        //
        //   bytesRead:
        //     To indicate response completion set bytesRead to 0 and return false.
        //
        //   callback:
        //     set bytesRead to 0, return true and execute callback when the data is available
        //     (dataOut will remain valid until the callback is executed). If you have no need
        //     of the callback then Dispose of it immeduately.
        //
        // Returns:
        //     return true or false depending on the criteria, see summary.
        public bool Read( Stream dataOut, out int bytesRead, IResourceReadCallback callback )
        {
            // For backwards compatibility set bytesRead to
            //     -1 and return false and the ReadResponse method will be called.
            bytesRead = -1;
            return false;
        }

        //
        // Summary:
        //     Skip response data when requested by a Range header. Skip over and discard bytesToSkip
        //     bytes of response data. - If data is available immediately set bytesSkipped to
        //     the number of of bytes skipped and return true. - To read the data at a later
        //     time set bytesSkipped to 0, return true and execute callback when the data is
        //     available. - To indicate failure set bytesSkipped to < 0 (e.g. -2 for ERR_FAILED)
        //     and return false. This method will be called in sequence but not from a dedicated
        //     thread.
        //
        // Parameters:
        //   bytesToSkip:
        //     number of bytes to be skipped
        //
        //   bytesSkipped:
        //     If data is available immediately set bytesSkipped to the number of of bytes skipped
        //     and return true. To read the data at a later time set bytesSkipped to 0, return
        //     true and execute callback when the data is available.
        //
        //   callback:
        //     To read the data at a later time set bytesSkipped to 0, return true and execute
        //     callback when the data is available.
        //
        // Returns:
        //     See summary
        public bool Skip( long bytesToSkip, out long bytesSkipped, IResourceSkipCallback callback )
        {
            // To indicate failure set bytesSkipped to < 0 (e.g. -2 for ERR_FAILED)
            //     and return false.
            bytesSkipped = -2;
            return false;
        }

        // Summary:
        //     Request processing has been canceled.
        public void Cancel( )
        {
        }

        //
        // Summary:
        //     Return true if the specified cookie can be sent with the request or false
        //     otherwise. If false is returned for any cookie then no cookies will be sent
        //     with the request.
        public bool CanGetCookie( Cookie cookie )
        {
            return true;
        }

        //
        // Summary:
        //     Return true if the specified cookie returned with the response can be set
        //     or false otherwise.
        public bool CanSetCookie( Cookie cookie )
        {
            return true;
        }

        //
        // Summary:
        //     Begin processing the request.
        //
        // Parameters:
        //   request:
        //     The request object.
        //
        //   callback:
        //     The callback used to Continue or Cancel the request (async).
        //
        // Returns:
        //     To handle the request return true and call CefSharp.ICallback.Continue once the
        //     response header information is available CefSharp.ICallback.Continue can also
        //     be called from inside this method if header information is available immediately).
        //     To cancel the request return false.
        public bool ProcessRequest( IRequest request, ICallback callback )
        {
            return false;
        }
    }
}
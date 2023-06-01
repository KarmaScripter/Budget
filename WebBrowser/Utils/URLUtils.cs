// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="URLUtils.cs" company="Terry D. Eppler">
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
//   URLUtils.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    internal static class URLUtils
    {
        public static string PathToURL( this string filePath, string removeBaseDir = null )
        {
            if( !filePath.CheckIfValid( ) )
            {
                return "";
            }

            return @"file:///" + filePath.Replace( @"\", "/" );
        }

        /// <summary>
        /// checks if URL starts with file:
        /// </summary>
        public static bool IsURLOfflineFile( this string url )
        {
            return url.StartsWith( "file://", StringComparison.Ordinal );
        }

        /// <summary>
        /// checks if URL is localhost
        /// </summary>
        public static bool IsURLLocalhost( this string url )
        {
            return url.BeginsWith( "http://localhost" ) || url.BeginsWith( "localhost" );
        }

        /// <summary>
        /// UrlDecodes a string
        /// </summary>
        public static string DecodeURL( this string url )
        {
            if( url == null )
            {
                return null;
            }

            var length = url.Length;
            var decoder = new UrlDecoder( length, Encoding.UTF8 );

            for( var i = 0; i < length; i++ )
            {
                var ch = url[ i ];

                if( ch == '+' )
                {
                    ch = ' ';
                }
                else if( ch == '%'
                        && i < length - 2 )
                {
                    if( url[ i + 1 ] == 'u'
                       && i < length - 5 )
                    {
                        var num3 = url[ i + 2 ].HexToInt( );
                        var num4 = url[ i + 3 ].HexToInt( );
                        var num5 = url[ i + 4 ].HexToInt( );
                        var num6 = url[ i + 5 ].HexToInt( );

                        if( num3 < 0
                           || num4 < 0
                           || num5 < 0
                           || num6 < 0 )
                        {
                            goto Label_010B;
                        }

                        ch = (char)( num3 << 12 | num4 << 8 | num5 << 4 | num6 );
                        i += 5;
                        decoder.AddChar( ch );
                        continue;
                    }

                    var num7 = url[ i + 1 ].HexToInt( );
                    var num8 = url[ i + 2 ].HexToInt( );

                    if( num7 >= 0
                       && num8 >= 0 )
                    {
                        var b = (byte)( num7 << 4 | num8 );
                        i += 2;
                        decoder.AddByte( b );
                        continue;
                    }
                }

                Label_010B:

                if( ( ch & 0xff80 ) == 0 )
                {
                    decoder.AddByte( (byte)ch );
                }
                else
                {
                    decoder.AddChar( ch );
                }
            }

            return decoder.GetString( );
        }

        public static int HexToInt( this char hex )
        {
            if( hex >= '0'
               && hex <= '9' )
            {
                return hex - '0';
            }

            if( hex >= 'a'
               && hex <= 'f' )
            {
                return hex - 'a' + 10;
            }

            if( hex >= 'A'
               && hex <= 'F' )
            {
                return hex - 'A' + 10;
            }

            return -1;
        }

        /// <summary>
        /// UrlDecodes a string except chars forbidden in Windows file paths
        /// </summary>
        public static string DecodeURLForFilepath( this string url )
        {
            if( url == null )
            {
                return null;
            }

            var length = url.Length;
            var decoder = new UrlDecoder( length * 10, Encoding.UTF8 );
            decoder.ForFilePaths = true;

            for( var i = 0; i < length; i++ )
            {
                var ch = url[ i ];

                if( ch == '+' )
                {
                    ch = ' ';
                }
                else if( ch == '%'
                        && i < length - 2 )
                {
                    if( url[ i + 1 ] == 'u'
                       && i < length - 5 )
                    {
                        var num3 = url[ i + 2 ].HexToInt( );
                        var num4 = url[ i + 3 ].HexToInt( );
                        var num5 = url[ i + 4 ].HexToInt( );
                        var num6 = url[ i + 5 ].HexToInt( );

                        if( num3 < 0
                           || num4 < 0
                           || num5 < 0
                           || num6 < 0 )
                        {
                            goto Label_010B;
                        }

                        ch = (char)( num3 << 12 | num4 << 8 | num5 << 4 | num6 );
                        i += 5;
                        decoder.FlushBytes( false );
                        decoder.AddChar( ch, true );
                        continue;
                    }

                    // ascii char (2 digit hex)
                    var num7 = url[ i + 1 ].HexToInt( );
                    var num8 = url[ i + 2 ].HexToInt( );

                    if( num7 >= 0
                       && num8 >= 0 )
                    {
                        var b = (byte)( num7 << 4 | num8 );
                        i += 2;
                        decoder.FlushBytes( false );
                        decoder.AddByte( b );

                        if( i + 1 < length - 2
                           && url[ i + 1 ] == '%' )
                        {
                            num7 = url[ i + 1 ].HexToInt( );
                            num8 = url[ i + 2 ].HexToInt( );

                            if( num7 >= 0
                               && num8 >= 0 )
                            {
                                b = (byte)( num7 << 4 | num8 );
                                i += 2;
                                decoder.AddByte( b );
                                decoder.FlushBytes( true );
                            }
                        }
                        else
                        {
                            decoder.FlushBytes( true );
                        }

                        continue;
                    }
                }

                Label_010B:

                if( ( ch & 0xff80 ) == 0 )
                {
                    decoder.AddByte( (byte)ch );
                }
                else
                {
                    decoder.AddChar( ch, false );
                }
            }

            return decoder.GetString( );
        }

        /// <summary>
        /// UrlEncodes a string without the requirement for System.Web
        /// </summary>
        public static string EncodeURL( this string text )
        {
            return Uri.EscapeDataString( text );
        }

        private class UrlDecoder
        {
            private int _bufferSize;

            private byte[ ] _byteBuffer;

            private char[ ] _charBuffer;

            private Encoding _encoding;

            private int _numBytes;

            private int _numChars;

            public bool ForFilePaths;

            internal UrlDecoder( int bufferSize, Encoding encoding )
            {
                _bufferSize = bufferSize;
                _encoding = encoding;
                _charBuffer = new char[ bufferSize ];
            }

            public void FlushBytes( bool checkChar = false )
            {
                if( _numBytes > 0 )
                {
                    if( checkChar && ForFilePaths )
                    {
                        var newChars = _encoding.GetChars( _byteBuffer, 0, _numBytes );
                        _numBytes = 0;

                        foreach( var ch in newChars )
                        {
                            AddChar( ch );
                        }
                    }
                    else
                    {
                        _numChars += _encoding.GetChars( _byteBuffer, 0, _numBytes, _charBuffer,
                            _numChars );

                        _numBytes = 0;
                    }
                }
            }

            internal void AddByte( byte b )
            {
                if( _byteBuffer == null )
                {
                    _byteBuffer = new byte[ _bufferSize ];
                }

                _byteBuffer[ _numBytes++ ] = b;
            }

            internal void AddChar( char ch, bool checkChar = false )
            {
                if( _numBytes > 0 )
                {
                    FlushBytes( );
                }

                if( checkChar && ForFilePaths )
                {
                    if( !ch.SupportedInFilePath( ) )
                    {
                        AddChar( '_' );
                        AddString( "0x" + ( (int)ch ).ToString( "X" ) );
                        AddChar( '_' );
                        return;
                    }
                }

                _charBuffer[ _numChars++ ] = ch;
            }

            internal void AddString( string str )
            {
                if( _numBytes > 0 )
                {
                    FlushBytes( );
                }

                foreach( var ch in str )
                {
                    _charBuffer[ _numChars++ ] = ch;
                }
            }

            internal string GetString( )
            {
                if( _numBytes > 0 )
                {
                    FlushBytes( );
                }

                return _numChars > 0
                    ? new string( _charBuffer, 0, _numChars )
                    : string.Empty;
            }
        }
    }
}
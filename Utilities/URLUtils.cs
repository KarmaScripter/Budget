// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-04-2023
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
    public static class URLUtils
    {
        /// <summary>
        /// Paths to URL.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="removeBaseDir">The remove base dir.</param>
        /// <returns></returns>
        public static string PathToURL( this string filePath, string removeBaseDir = null )
        {
            if( !filePath.CheckIfValid( ) )
            {
                return "";
            }

            return @"file:///" + filePath.Replace( @"\", "/" );
        }

        /// <summary>
        /// Determines whether [is file offline].
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        ///   <c>true</c> if [is file offline] [the specified URL]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsFileOffline( this string url )
        {
            return url.StartsWith( "file://", StringComparison.Ordinal );
        }

        /// <summary>
        /// Determines whether this instance is localhost.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        ///   <c>true</c> if the specified URL is localhost; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLocalhost( this string url )
        {
            return url.BeginsWith( "http://localhost" ) || url.BeginsWith( "localhost" );
        }

        /// <summary>
        /// URLs the decode.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static string UrlDecode( this string url )
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

        /// <summary>
        /// Hexadecimals to int.
        /// </summary>
        /// <param name="hex">The hexadecimal.</param>
        /// <returns></returns>
        public static int HexToInt( this char hex )
        {
            return hex switch
            {
                >= '0' and <= '9' => hex - '0',
                >= 'a' and <= 'f' => hex - 'a' + 10,
                >= 'A' and <= 'F' => hex - 'A' + 10,
                var _ => -1
            };
        }

        /// <summary>
        /// Decodes the URL for filepath.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static string DecodeUrlForFilepath( this string url )
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
        /// URLs the encode.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string UrlEncode( this string text )
        {
            return Uri.EscapeDataString( text );
        }
    }
}
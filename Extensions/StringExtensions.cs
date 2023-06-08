﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="StringExtensions.cs" company="Terry D. Eppler">
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
//   StringExtensions.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Xml;

    /// <summary> </summary>
    public static class StringExtensions
    {
        /// <summary> The SplitPascal </summary>
        /// <returns>
        /// The
        /// <see cref="string"/>
        /// </returns>
        /// <param name="text"> The text. </param>
        /// <returns> </returns>
        public static string SplitPascal( this string text )
        {
            try
            {
                if( !string.IsNullOrEmpty( text )
                   && ( text.Length > 4 ) )
                {
                    var _pascal = Regex.Replace( text, "([A-Z])", " $1", RegexOptions.Compiled )?.Trim( );
                    if( _pascal.StartsWith( "Rpio " ) )
                    {
                        return _pascal?.Replace( "Rpio ", "RPIO " );
                    }
                    else if( _pascal.StartsWith( "Npm " ) )
                    {
                        return _pascal?.Replace( "Npm ", "NPM " );
                    }
                    else if( _pascal.StartsWith( "Boc " ) )
                    {
                        return _pascal?.Replace( "Boc ", "BOC " );
                    }
                    else if( _pascal.StartsWith( "Foc " ) )
                    {
                        return _pascal?.Replace( "Foc ", "FOC " );
                    }
                    else if( _pascal.StartsWith( "Org " ) )
                    {
                        return _pascal?.Replace( "Org ", "ORG " );
                    }
                    else if( _pascal.StartsWith( "Omb " ) )
                    {
                        return _pascal?.Replace( "Omb ", "OMB " );
                    }
                    else if( _pascal.StartsWith( "Prc " ) )
                    {
                        return _pascal?.Replace( "Prc ", "PRC " );
                    }
                    else if( _pascal.StartsWith( "Ah " ) )
                    {
                        return _pascal?.Replace( "Ah ", "AH " );
                    }
                    else if( _pascal.StartsWith( "Rc " ) )
                    {
                        return _pascal?.Replace( "Rc ", "RC " );
                    }
                    else if( _pascal.EndsWith( " Id" ) )
                    {
                        return _pascal?.Replace( " Id", " ID" );
                    }
                    else
                    {
                        return _pascal;
                    }
                }

                return text;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary> The IfNullThen </summary>
        /// <param name="text">
        /// The text
        /// <see cref="string"/>
        /// </param>
        /// <param name="alt">
        /// The alt
        /// <see cref="string"/>
        /// </param>
        /// <returns>
        /// The
        /// <see cref="string"/>
        /// </returns>
        public static string IfNullThen( this string text, string alt )
        {
            try
            {
                return text ?? alt ?? string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary> </summary>
        /// <param name="text"> </param>
        /// <param name="values"> The value list to compare with the object. </param>
        /// <returns> true if the values list contains the object, else false. </returns>
        public static bool In( this string text, params string[ ] values )
        {
            try
            {
                return Array.IndexOf( values, text ) != -1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary> The Right </summary>
        /// <param name="text">
        /// The text
        /// <see cref="string"/>
        /// </param>
        /// <param name="length">
        /// The length
        /// <see cref="int"/>
        /// </param>
        /// <returns>
        /// The
        /// <see cref="string"/>
        /// </returns>
        public static string Last( this string text, int length )
        {
            try
            {
                return text?.Length > length
                    ? text.Substring( text.Length - length )
                    : text;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary> The Left </summary>
        /// <param name="text">
        /// The text
        /// <see cref="string"/>
        /// </param>
        /// <param name="length">
        /// The length
        /// <see cref="int"/>
        /// </param>
        /// <returns>
        /// The
        /// <see cref="string"/>
        /// </returns>
        public static string First( this string text, int length )
        {
            try
            {
                return text?.Length > length
                    ? text[ ..length ]
                    : text;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary> The FirstToUpper </summary>
        /// <param name="text">
        /// The theString
        /// <see cref="string"/>
        /// </param>
        /// <returns>
        /// The
        /// <see cref="string"/>
        /// </returns>
        public static string FirstToUpper( this string text )
        {
            try
            {
                if( !string.IsNullOrEmpty( text ) )
                {
                    var _letters = text.ToCharArray( );
                    _letters[ 0 ] = char.ToUpper( _letters[ 0 ] );
                    return new string( _letters );
                }
                else
                {
                    return default( string );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary> The ToDateTime </summary>
        /// <param name="text">
        /// The text
        /// <see cref="string"/>
        /// </param>
        /// <returns>
        /// The
        /// <see/>
        /// </returns>
        public static DateTime ToDateTime( this string text )
        {
            if( !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    var _date = DateTime.TryParse( text, out var _dateTime );
                    return _date
                        ? _dateTime
                        : default( DateTime );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DateTime );
                }
            }

            return default( DateTime );
        }

        /// <summary> The ToStream </summary>
        /// <param name="text">
        /// The source
        /// <see cref="string"/>
        /// </param>
        /// <returns>
        /// The
        /// <see cref="MemoryStream"/>
        /// </returns>
        public static MemoryStream ToMemoryStream( this string text )
        {
            try
            {
                var _buffer = Encoding.UTF8.GetBytes( text );
                return new MemoryStream( _buffer );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( MemoryStream );
            }
        }

        /// <summary>
        /// A string extension method that converts the str to an XmlDocument.
        /// </summary>
        /// <param name="xml"> </param>
        /// <returns> str as an XmlDocument. </returns>
        public static XmlDocument ToXmlDocument( this string xml )
        {
            try
            {
                var _document = new XmlDocument( );
                _document.LoadXml( xml );
                return _document;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( XmlDocument );
            }
        }

        /// <summary>
        /// A string extension method that converts the str to a byte array.
        /// </summary>
        /// <param name="text"> The str to act on. </param>
        /// <returns> str as a byte[]. </returns>
        public static byte[ ] ToByteArray( this string text )
        {
            try
            {
                Encoding _encoding = Activator.CreateInstance<ASCIIEncoding>( );
                return _encoding.GetBytes( text );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( byte[ ] );
            }
        }

        /// <summary> The WordCount </summary>
        /// <param name="text">
        /// The input
        /// <see cref="string"/>
        /// </param>
        /// <returns>
        /// The
        /// <see cref="int"/>
        /// </returns>
        public static int WordCount( this string text )
        {
            var _count = 0;
            try
            {
                var _re = new Regex( @"[^\text]+" );
                var _matches = _re.Matches( text );
                _count = _matches.Count;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return _count;
            }

            return _count;
        }

        /// <summary> Writes out a text to a file. </summary>
        /// <param name="text"> The complete file path to write to. </param>
        /// <param name="path"> A String containing text to be written to the file. </param>
        public static void WriteToFile( this string text, string path )
        {
            if( !string.IsNullOrEmpty( text )
               && !string.IsNullOrEmpty( path ) )
            {
                try
                {
                    using var _writer = new StreamWriter( text, false );
                    _writer.Write( path );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Send an email using the supplied string. </summary>
        /// <param name="body"> String that will be used i the body of the email. </param>
        /// <param name="subject"> Subject of the email. </param>
        /// <param name="sender"> The email address from which the message was sent. </param>
        /// <param name="recipient"> The receiver of the email. </param>
        /// <param name="server"> The server from which the email will be sent. </param>
        /// <returns> A boolean value indicating the success of the email send. </returns>
        public static bool Email( this string body, string subject, string sender, string recipient,
            string server )
        {
            try
            {
                var _message = new MailMessage( );
                _message.To.Add( recipient );
                var _address = new MailAddress( sender );
                _message.From = _address;
                _message.Subject = subject;
                _message.Body = body;
                var _client = new SmtpClient( server );
                var _credentials = new NetworkCredential( );
                _client.Credentials = _credentials;
                _client.Send( _message );
                return true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// remove space, not line end Useful when parsing user input such phone, price int.Parse("1 000
        /// 000".RemoveSpaces(),.....
        /// </summary>
        /// <param name="text"> </param>
        public static string RemoveSpaces( this string text )
        {
            if( !string.IsNullOrEmpty( text )
               && text.Contains( ' ' ) )
            {
                try
                {
                    return text.Replace( " ", "" );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return text;
                }
            }

            return text;
        }

        /// <summary> Determines whether [is valid email address]. </summary>
        /// <param name="s"> The s. </param>
        /// <returns>
        /// <c> true </c>
        /// if [is valid email address] [the specified s]; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        public static bool IsValidEmailAddress( this string s )
        {
            try
            {
                var _regex = new Regex( @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" );
                return _regex.IsMatch( s );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
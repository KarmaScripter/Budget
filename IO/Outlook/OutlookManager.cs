// <copyright file = "OutlookManager.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Mail;
    using System.Net.Mime;
    using System.Text;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class OutlookManager
    {
        public string HostName { get; set; }

        public OutlookManager( )
        {
        }

        public OutlookManager( string hostName )
        {
            HostName = hostName;
        }

        public void SendMail( OutlookConfig config, EmailContent content )
        {
            if( config != null && content != null )
            {
                try
                {
                    var _message = ConstructEmailMessage( config, content );
                    Send( _message, config );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        private MailMessage ConstructEmailMessage( OutlookConfig config, EmailContent content )
        {
            if( config != null
               && content != null )
            {
                try
                {
                    var _message = new MailMessage( );
                    for( var j = 0; j < config.TOs.Length; j++ )
                    {
                        var to = config.TOs[ j ];
                        if( !string.IsNullOrEmpty( to ) )
                        {
                            _message.To.Add( to );
                        }
                    }

                    for( var i = 0; i < config.CCs.Length; i++ )
                    {
                        var _cc = config.CCs[ i ];
                        if( !string.IsNullOrEmpty( _cc ) )
                        {
                            _message.CC.Add( _cc );
                        }
                    }

                    _message.From = new MailAddress( config.From, config.FromDisplayName,
                        Encoding.UTF8 );

                    _message.IsBodyHtml = content.IsHtml;
                    _message.Body = content.Content;
                    _message.Priority = config.Priority;
                    _message.Subject = config.Subject;
                    _message.BodyEncoding = Encoding.UTF8;
                    _message.SubjectEncoding = Encoding.UTF8;
                    if( content.AttachFileName != null )
                    {
                        var _data = new Attachment( content.AttachFileName,
                            MediaTypeNames.Application.Zip );

                        _message.Attachments.Add( _data );
                    }

                    return _message;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( MailMessage );
                }
            }

            return default( MailMessage );
        }

        private void Send( MailMessage message, OutlookConfig config )
        {
            if( message != null 
               && config != null )
            {
                try
                {
                    var _client = new SmtpClient( );
                    _client.UseDefaultCredentials = false;
                    _client.Credentials = new NetworkCredential( config.ClientCredentialUserName,
                        config.ClientCredentialPassword );

                    _client.Host = HostName;
                    _client.Port = 25;  
                    _client.EnableSsl = true; 
                    _client.Send( message );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    message.Dispose( );
                }
            }
        }

        /// <summary>
        /// Get ErrorDialog Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
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

        public void SendMail( OutlookConfig OutlookConfig, EmailContent content )
        {
            var msg = ConstructEmailMessage( OutlookConfig, content );
            Send( msg, OutlookConfig );
        }

        // Put the properties of the email including "to", "cc", "from", "subject" and "email body"  
        private MailMessage ConstructEmailMessage( OutlookConfig OutlookConfig, 
            EmailContent content )
        {
            var msg = new MailMessage( );
            for( var j = 0; j < OutlookConfig.TOs.Length; j++ )
            {
                var to = OutlookConfig.TOs[ j ];
                if( !string.IsNullOrEmpty( to ) )
                {
                    msg.To.Add( to );
                }
            }

            for( var i = 0; i < OutlookConfig.CCs.Length; i++ )
            {
                var cc = OutlookConfig.CCs[ i ];
                if( !string.IsNullOrEmpty( cc ) )
                {
                    msg.CC.Add( cc );
                }
            }

            msg.From = new MailAddress( OutlookConfig.From, OutlookConfig.FromDisplayName,
                Encoding.UTF8 );

            msg.IsBodyHtml = content.IsHtml;
            msg.Body = content.Content;
            msg.Priority = OutlookConfig.Priority;
            msg.Subject = OutlookConfig.Subject;
            msg.BodyEncoding = Encoding.UTF8;
            msg.SubjectEncoding = Encoding.UTF8;
            if( content.AttachFileName != null )
            {
                var data = new Attachment( content.AttachFileName, MediaTypeNames.Application.Zip );
                msg.Attachments.Add( data );
            }

            return msg;
        }

        //Send the email using the SMTP server  
        private void Send( MailMessage message, OutlookConfig OutlookConfig )
        {
            var client = new SmtpClient( );
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential( OutlookConfig.ClientCredentialUserName,
                OutlookConfig.ClientCredentialPassword );

            client.Host = HostName;
            client.Port = 25;  
            client.EnableSsl = true; 
            try
            {
                client.Send( message );
            }
            catch( Exception e )
            {
                Console.WriteLine( "Error in Send email: {0}", e.Message );
                throw;
            }

            message.Dispose( );
        }
    }
}
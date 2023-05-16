// <copyright file = "OutlookConfig.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Net.Mail;
    using System.Net.Mime;  
    
    public class OutlookConfig
    {
        public string[ ] TOs { get; set; }  

        public string[ ] CCs { get; set; }  

        public string From { get; set; }  

        public string FromDisplayName { get; set; }  

        public string Subject { get; set; }  

        public MailPriority Priority { get; set; }  

        public string ClientCredentialUserName { get; set; } 

        public string ClientCredentialPassword { get; set; }
    
        public OutlookConfig( )
        {
        }
    }
}
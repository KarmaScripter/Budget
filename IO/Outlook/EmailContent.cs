// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

    public class EmailContent
    {
        public bool IsHtml { get; set; }

        public string Content { get; set; }

        public string AttachFileName { get; set; }
        
        public EmailContent( )
        {
        }
    }
}
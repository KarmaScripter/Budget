﻿// <copyright file = "Contacts.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Contacts
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Contacts( )
        {
        }
        
        public Contacts( IQuery query )
        {
        }

        public Contacts( IDataModel builder )
        {
        }

        public Contacts( DataRow dataRow )
        {
        }
    }
}

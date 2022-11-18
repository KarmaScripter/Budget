// <copyright file = "AccountingEvent.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class AccountingEvent
    {
        public int ID { get; set; }

        public string Code { get; set; }

        public Source Source { get; set; }

        public AccountingEvent( )
        {
        }

        public AccountingEvent( IQuery query )
        {
            
        }

        public AccountingEvent( IDataModel builder )
        {
            
        }

        public AccountingEvent( DataRow dataRow )
        {
            
        }
    }
}

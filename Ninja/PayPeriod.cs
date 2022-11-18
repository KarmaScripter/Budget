// <copyright file = "PayPeriod.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class PayPeriod
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public PayPeriod( )
        {
        }
        
        public PayPeriod( IQuery query )
        {
        }

        public PayPeriod( IDataModel builder )
        {
        }

        public PayPeriod( DataRow dataRow )
        {
        }
    }
}

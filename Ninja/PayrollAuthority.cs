// <copyright file = "PayrollAuthority.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class PayrollAuthority
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public PayrollAuthority( )
        {
        }
        
        public PayrollAuthority( IQuery query )
        {
        }

        public PayrollAuthority( IDataModel builder )
        {
        }

        public PayrollAuthority( DataRow dataRow )
        {
        }
    }
}

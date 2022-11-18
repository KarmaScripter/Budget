// <copyright file = "PayrollActivity.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class PayrollActivity
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public PayrollActivity( )
        {
        }


        public PayrollActivity( IQuery query )
        {
        }

        public PayrollActivity( IDataModel builder )
        {
        }

        public PayrollActivity( DataRow dataRow )
        {
        }
    }
}

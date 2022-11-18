// <copyright file = "PayrollRequest.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class PayrollRequest
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public PayrollRequest( )
        {
        }
        
        public PayrollRequest( IQuery query )
        {
        }

        public PayrollRequest( IDataModel builder )
        {
        }

        public PayrollRequest( DataRow dataRow )
        {
        }
    }
}

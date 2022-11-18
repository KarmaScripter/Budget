// <copyright file = "AnnualReimbursableEstimate.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class AnnualReimbursableEstimate
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public AnnualReimbursableEstimate( )
        {
        }
        
        public AnnualReimbursableEstimate( IQuery query )
        {
        }

        public AnnualReimbursableEstimate( IDataModel builder )
        {
        }

        public AnnualReimbursableEstimate( DataRow dataRow )
        {
        }
    }
}

// <copyright file = "ReimbursableFund.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ReimbursableFund
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ReimbursableFund( )
        {
        }
        
        public ReimbursableFund( IQuery query )
        {
        }

        public ReimbursableFund( IDataModel builder )
        {
        }

        public ReimbursableFund( DataRow dataRow )
        {
        }
    }
}

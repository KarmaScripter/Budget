// <copyright file = "ReimbursableAgreement.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ReimbursableAgreement
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ReimbursableAgreement( )
        {
        }
        
        public ReimbursableAgreement( IQuery query )
        {
        }

        public ReimbursableAgreement( IDataModel builder )
        {
        }

        public ReimbursableAgreement( DataRow dataRow )
        {
        }
    }
}

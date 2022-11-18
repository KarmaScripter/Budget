// <copyright file = "StatusOfJobsActFunding.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class StatusOfJobsActFunding
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public StatusOfJobsActFunding( )
        {
        }

        public StatusOfJobsActFunding( IQuery query )
        {
        }

        public StatusOfJobsActFunding( IDataModel builder )
        {
        }

        public StatusOfJobsActFunding( DataRow dataRow )
        {
        }
    }
}

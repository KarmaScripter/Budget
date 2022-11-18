// <copyright file = "JobsActCarryoverEstimates.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class JobsActCarryoverEstimates
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public JobsActCarryoverEstimates( )
        {
        }
        
        public JobsActCarryoverEstimates( IQuery query )
        {
        }

        public JobsActCarryoverEstimates( IDataModel builder )
        {
        }

        public JobsActCarryoverEstimates( DataRow dataRow )
        {
        }
    }
}

// <copyright file = "OperatingPlan.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class OperatingPlan
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public OperatingPlan( )
        {
        }
        
        public OperatingPlan( IQuery query )
        {
        }

        public OperatingPlan( IDataModel builder )
        {
        }

        public OperatingPlan( DataRow dataRow )
        {
        }
    }
}

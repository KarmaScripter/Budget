// <copyright file = "OperatingPlanUpdate.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class OperatingPlanUpdate
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public OperatingPlanUpdate( )
        {
        }
        
        public OperatingPlanUpdate( IQuery query )
        {
        }

        public OperatingPlanUpdate( IDataModel builder )
        {
        }

        public OperatingPlanUpdate( DataRow dataRow )
        {
        }
    }
}

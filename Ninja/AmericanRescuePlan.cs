// <copyright file = "AmericanRescuePlan.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class AmericanRescuePlan
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public AmericanRescuePlan( )
        {
        }
        
        public AmericanRescuePlan( IQuery query )
        {
        }

        public AmericanRescuePlan( IDataModel builder )
        {
        }

        public AmericanRescuePlan( DataRow dataRow )
        {
        }
    }
}

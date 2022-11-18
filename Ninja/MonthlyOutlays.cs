// <copyright file = "MonthlyOutlays.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class MonthlyOutlays
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public MonthlyOutlays( )
        {
        }
        
        public MonthlyOutlays( IQuery query )
        {
        }

        public MonthlyOutlays( IDataModel builder )
        {
        }

        public MonthlyOutlays( DataRow dataRow )
        {
        }
    }
}

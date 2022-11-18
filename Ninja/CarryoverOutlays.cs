// <copyright file = "CarryoverOutlays.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class CarryoverOutlays
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public CarryoverOutlays( )
        {
        }
        
        public CarryoverOutlays( IQuery query )
        {
        }

        public CarryoverOutlays( IDataModel builder )
        {
        }

        public CarryoverOutlays( DataRow dataRow )
        {
        }
    }
}

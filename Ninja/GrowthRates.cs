// <copyright file = "GrowthRates.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class GrowthRates
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public GrowthRates( )
        {
        }
        
        public GrowthRates( IQuery query )
        {
        }

        public GrowthRates( IDataModel builder )
        {
        }

        public GrowthRates( DataRow dataRow )
        {
        }
    }
}

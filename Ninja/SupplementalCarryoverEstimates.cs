// <copyright file = "SupplementalCarryoverEstimates.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class SupplementalCarryoverEstimates
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public SupplementalCarryoverEstimates( )
        {
        }
        
        public SupplementalCarryoverEstimates( IQuery query )
        {
        }

        public SupplementalCarryoverEstimates( IDataModel builder )
        {
        }

        public SupplementalCarryoverEstimates( DataRow dataRow )
        {
        }
    }
}

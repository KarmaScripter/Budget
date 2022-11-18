// <copyright file = "AnnualCarryoverEstimate.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class AnnualCarryoverEstimate
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public AnnualCarryoverEstimate( )
        {
        }
        
        public AnnualCarryoverEstimate( IQuery query )
        {
        }

        public AnnualCarryoverEstimate( IDataModel builder )
        {
        }

        public AnnualCarryoverEstimate( DataRow dataRow )
        {
        }
    }
}

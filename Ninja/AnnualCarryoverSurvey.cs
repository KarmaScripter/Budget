// <copyright file = "AnnualCarryoverSurvey.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class AnnualCarryoverSurvey
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public AnnualCarryoverSurvey( )
        {
        }
        
        public AnnualCarryoverSurvey( IQuery query )
        {
        }

        public AnnualCarryoverSurvey( IDataModel builder )
        {
        }

        public AnnualCarryoverSurvey( DataRow dataRow )
        {
        }
    }
}
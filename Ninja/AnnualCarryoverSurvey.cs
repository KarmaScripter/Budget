// <copyright file = "AnnualCarryoverSurvey.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    public class AnnualCarryoverSurvey
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public DataRow Record { get; set; }

        public IDictionary<string, object> Data { get; set; }

        public AnnualCarryoverSurvey( )
        {
        }
        
        public AnnualCarryoverSurvey( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        public AnnualCarryoverSurvey( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        public AnnualCarryoverSurvey( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
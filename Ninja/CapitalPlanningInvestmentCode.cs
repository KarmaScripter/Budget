﻿// <copyright file = "CapitalPlanningInvestmentCode.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class CapitalPlanningInvestmentCode
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public DataRow Record { get; set; }
        
        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        public CapitalPlanningInvestmentCode( )
        {
        }
        
        public CapitalPlanningInvestmentCode( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        public CapitalPlanningInvestmentCode( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        public CapitalPlanningInvestmentCode( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

﻿// <copyright file = "FederalHoliday.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class FederalHolidays
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

        public FederalHolidays( )
        {
        }
        
        public FederalHolidays( IQuery query )
        {
        }

        public FederalHolidays( IDataModel builder )
        {
        }

        public FederalHolidays( DataRow dataRow )
        {
        }
    }
}

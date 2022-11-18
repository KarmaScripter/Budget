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

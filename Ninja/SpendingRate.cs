// <copyright file = "SpendingRate.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class SpendingRate
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

        public SpendingRate( )
        {
        }
        
        public SpendingRate( IQuery query )
        {
        }

        public SpendingRate( IDataModel builder )
        {
        }

        public SpendingRate( DataRow dataRow )
        {
        }
    }
}

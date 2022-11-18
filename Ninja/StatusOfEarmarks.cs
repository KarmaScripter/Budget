// <copyright file = "StatusOfEarmarks.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class StatusOfEarmarks
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

        public StatusOfEarmarks( )
        {
        }
        
        public StatusOfEarmarks( IQuery query )
        {
        }

        public StatusOfEarmarks( IDataModel builder )
        {
        }

        public StatusOfEarmarks( DataRow dataRow )
        {
        }
    }
}

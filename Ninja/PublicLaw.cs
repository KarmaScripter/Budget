// <copyright file = "PublicLaw.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class PublicLaw
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

        public PublicLaw( )
        {
        }
        
        public PublicLaw( IQuery query )
        {
        }

        public PublicLaw( IDataModel builder )
        {
        }

        public PublicLaw( DataRow dataRow )
        {
        }
    }
}

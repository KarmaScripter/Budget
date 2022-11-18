// <copyright file = "SchemaType.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class SchemaTypes
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

        public SchemaTypes( )
        {
        }
        
        public SchemaTypes( IQuery query )
        {
        }

        public SchemaTypes( IDataModel builder )
        {
        }

        public SchemaTypes( DataRow dataRow )
        {
        }
    }
}

// <copyright file = "DocumentControlNumber.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class DocumentControlNumber
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

        public DocumentControlNumber( )
        {
        }
        
        public DocumentControlNumber( IQuery query )
        {
        }

        public DocumentControlNumber( IDataModel builder )
        {
        }

        public DocumentControlNumber( DataRow dataRow )
        {
        }
    }
}

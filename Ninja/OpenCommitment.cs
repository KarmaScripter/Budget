// <copyright file = "OpenCommitment.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class OpenCommitment
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

        public OpenCommitment( )
        {
        }
        
        public OpenCommitment( IQuery query )
        {
        }

        public OpenCommitment( IDataModel builder )
        {
        }

        public OpenCommitment( DataRow dataRow )
        {
        }
    }
}

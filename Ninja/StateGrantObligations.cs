// <copyright file = "StateGrantObligation.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class StateGrantObligations
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

        public StateGrantObligations( )
        {
        }
        
        public StateGrantObligations( IQuery query )
        {
        }

        public StateGrantObligations( IDataModel builder )
        {
        }

        public StateGrantObligations( DataRow dataRow )
        {
        }
    }
}

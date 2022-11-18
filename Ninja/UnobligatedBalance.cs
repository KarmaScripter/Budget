// <copyright file = "UnobligatedBalance.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class UnobligatedBalance
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

        public UnobligatedBalance( )
        {
        }
        
        public UnobligatedBalance( IQuery query )
        {
        }

        public UnobligatedBalance( IDataModel builder )
        {
        }

        public UnobligatedBalance( DataRow dataRow )
        {
        }
    }
}

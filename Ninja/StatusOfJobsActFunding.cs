// <copyright file = "StatusOfJobsActFunding.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class StatusOfJobsActFunding
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

        public StatusOfJobsActFunding( )
        {
        }

        public StatusOfJobsActFunding( IQuery query )
        {
        }

        public StatusOfJobsActFunding( IDataModel builder )
        {
        }

        public StatusOfJobsActFunding( DataRow dataRow )
        {
        }
    }
}

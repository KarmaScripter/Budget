// <copyright file = "SiteProjectCode.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class SiteProjectCode
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

        public SiteProjectCode( )
        {
        }
        
        public SiteProjectCode( IQuery query )
        {
        }

        public SiteProjectCode( IDataModel builder )
        {
        }

        public SiteProjectCode( DataRow dataRow )
        {
        }
    }
}

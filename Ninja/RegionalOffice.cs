// <copyright file = "RegionalOffice.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class RegionalOffice : ResourcePlanningOffice
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

        public RegionalOffice( )
        {
        }
        
        public RegionalOffice( IQuery query )
        {
        }

        public RegionalOffice( IDataModel builder )
        {
        }

        public RegionalOffice( DataRow dataRow )
        {
        }
    }
}

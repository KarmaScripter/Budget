﻿// <copyright file = "Document.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    public class Documents
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

        public Documents( )
        {
        }
        
        public Documents( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        public Documents( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        public Documents( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

﻿// <copyright file = "Messages.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Messages
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

        public Messages( )
        {
        }
        
        public Messages( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        public Messages( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        public Messages( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

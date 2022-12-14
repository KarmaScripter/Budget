// <copyright file = "AmericanRescuePlan.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// c
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AmericanRescuePlan
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="AmericanRescuePlan"/> class.
        /// </summary>
        public AmericanRescuePlan( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmericanRescuePlan"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AmericanRescuePlan( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmericanRescuePlan"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public AmericanRescuePlan( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmericanRescuePlan"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AmericanRescuePlan( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

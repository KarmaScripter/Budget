// <copyright file = "PublicLaw.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DataUnit" />
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class PublicLaw : DataUnit
    {
        /// <summary>
        /// Gets or sets the law number.
        /// </summary>
        /// <value>
        /// The law number.
        /// </value>
        public string LawNumber { get; set; }

        /// <summary>
        /// Gets or sets the bill title.
        /// </summary>
        /// <value>
        /// The bill title.
        /// </value>
        public string BillTitle { get; set; }

        /// <summary>
        /// Gets or sets the enacted date.
        /// </summary>
        /// <value>
        /// The enacted date.
        /// </value>
        public string EnactedDate { get; set; }

        /// <summary>
        /// Gets or sets the congress.
        /// </summary>
        /// <value>
        /// The congress.
        /// </value>
        public string Congress { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public string BFY { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLaw"/> class.
        /// </summary>
        public PublicLaw( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLaw"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public PublicLaw( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLaw"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public PublicLaw( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLaw"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public PublicLaw( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
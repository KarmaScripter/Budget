// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.ResourcePlanningOffice"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class RegionalOffice : ResourcePlanningOffice
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the resource planning offices identifier. </summary>
        /// <value> The resource planning offices identifier. </value>
        public int ResourcePlanningOfficesId { get; set; }

        /// <summary> Gets the code. </summary>
        public override string Code { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        public override string Name { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public IDictionary<string, object> Map { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RegionalOffice"/>
        /// class.
        /// </summary>
        public RegionalOffice( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RegionalOffice"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public RegionalOffice( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RegionalOffice"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public RegionalOffice( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RegionalOffice"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public RegionalOffice( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
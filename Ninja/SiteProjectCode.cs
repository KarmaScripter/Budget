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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class SiteProjectCode : DataUnit
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        public string RpioCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        public string RpioName { get; set; }

        /// <summary> Gets or sets the state. </summary>
        /// <value> The state. </value>
        public string State { get; set; }

        /// <summary> Gets or sets the congressional district. </summary>
        /// <value> The congressional district. </value>
        public string CongressionalDistrict { get; set; }

        /// <summary> Gets or sets the epa site identifier. </summary>
        /// <value> The epa site identifier. </value>
        public string EpaSiteId { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        public override string Name { get; set; }

        /// <summary> Gets or sets the code. </summary>
        /// <value> The code. </value>
        public override string Code { get; set; }

        /// <summary> Gets or sets the ssid. </summary>
        /// <value> The ssid. </value>
        public string SSID { get; set; }

        /// <summary> Gets or sets the action code. </summary>
        /// <value> The action code. </value>
        public string ActionCode { get; set; }

        /// <summary> Gets or sets the operable unit. </summary>
        /// <value> The operable unit. </value>
        public string OperableUnit { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SiteProjectCode"/>
        /// class.
        /// </summary>
        public SiteProjectCode( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SiteProjectCode"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public SiteProjectCode( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SiteProjectCode"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public SiteProjectCode( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SiteProjectCode"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public SiteProjectCode( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
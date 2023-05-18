// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AccountingEvent : DataUnit, IAccountingEvent
    {
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
        /// <see cref = "AccountingEvent"/>
        /// class.
        /// </summary>
        public AccountingEvent( )
        {
            Source = Source.AccountingEvents;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AccountingEvent"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public AccountingEvent( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            ID = int.Parse( Record[ "AccountingEventsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AccountingEvent"/>
        /// class.
        /// </summary>
        /// <param name = "builder" > The builder. </param>
        public AccountingEvent( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            ID = int.Parse( Record[ "AccountingEventsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AccountingEvent"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The data row. </param>
        public AccountingEvent( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "AccountingEventsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = dataRow.ToDictionary( );
        }

        public AccountingEvent( IAccountingEvent accountingEvent )
        {
            ID = accountingEvent.ID;
            Code = accountingEvent.Code;
            Name = accountingEvent.Name;
        }

        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the code. </summary>
        /// <value> The code. </value>
        public override string Code { get; set; }

        /// <summary> </summary>
        public override string Name { get; set; }
    }
}
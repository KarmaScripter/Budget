// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AccountingEvent : DataUnit 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingEvent"/> class.
        /// </summary>
        public AccountingEvent( )
        {
            Source = Source.AccountingEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingEvent"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
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
        /// Initializes a new instance of the <see cref="AccountingEvent"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
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
        /// Initializes a new instance of the <see cref="AccountingEvent"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AccountingEvent( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "AccountingEventsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = dataRow.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingEvent"/> class.
        /// </summary>
        /// <param name="accountingEvent">The accounting event.</param>
        public AccountingEvent( AccountingEvent accountingEvent )
        {
            ID = accountingEvent.ID;
            Code = accountingEvent.Code;
            Name = accountingEvent.Name;
        }
    }
}
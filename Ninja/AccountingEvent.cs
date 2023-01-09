// <copyright file = "AccountingEvent.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AccountingEvent
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        public string Name { get; set; }
        
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
        /// Initializes a new instance of the <see cref="AccountingEvent"/> class.
        /// </summary>
        public AccountingEvent( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingEvent"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AccountingEvent( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            ID = int.Parse( Record[ $"{ PrimaryKey.AccountingEventsId }" ].ToString( ) );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingEvent"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public AccountingEvent( IDataModel builder )
        {
            Record = builder.Record;
            ID = int.Parse( Record[ $"{ PrimaryKey.AccountingEventsId }" ].ToString( ) );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingEvent"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AccountingEvent( DataRow dataRow )
        {
            Record = dataRow;
            ID = int.Parse( Record[ $"{ PrimaryKey.AccountingEventsId }" ].ToString( ) );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Data = dataRow.ToDictionary( );
        }
        
        
    }
}

// <copyright file = "Contact.cs" company = "Terry D.Eppler">
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
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class Contact : DataUnit
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the rpio.
        /// </summary>
        /// <value>
        /// The rpio.
        /// </value>
        public string RPIO { get; set; }

        /// <summary>
        /// Gets or sets the section.
        /// </summary>
        /// <value>
        /// The section.
        /// </value>
        public string Section { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact( )
        {
            Source = Source.Contacts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Contact( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ContactsId" ].ToString( ) ?? "0" );
            FirstName = Record[ "FirstName" ].ToString( );
            LastName = Record[ "LastName" ].ToString( );
            FullName = Record[ "FullName" ].ToString( );
            RPIO = Record[ "RPIO" ].ToString( );
            EmailAddress = Record[ "EmailAddress" ].ToString( );
            Section = Record[ "Section" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public Contact( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ContactsId" ].ToString( ) ?? "0" );
            FirstName = Record[ "FirstName" ].ToString( );
            LastName = Record[ "LastName" ].ToString( );
            FullName = Record[ "FullName" ].ToString( );
            RPIO = Record[ "RPIO" ].ToString( );
            EmailAddress = Record[ "EmailAddress" ].ToString( );
            Section = Record[ "Section" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Contact( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "ContactsId" ].ToString( ) ?? "0" );
            FirstName = dataRow[ "FirstName" ].ToString( );
            LastName = dataRow[ "LastName" ].ToString( );
            FullName = dataRow[ "FullName" ].ToString( );
            RPIO = dataRow[ "RPIO" ].ToString( );
            EmailAddress = dataRow[ "EmailAddress" ].ToString( );
            Section = dataRow[ "Section" ].ToString( );
        }
    }
}
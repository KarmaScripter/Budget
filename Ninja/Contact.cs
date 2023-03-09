// <copyright file = "Contacts.cs" company = "Terry D. Eppler">
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
    public class Contact : DataUnit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the First Name property
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Gets or sets the Last Name property
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Gets or sets the Full Name  property
        /// </summary>
        public string FullName { get; set; }
        
        /// <summary>
        /// Gets or sets the Email Address property
        /// </summary>
        public string EmailAddress { get; set; }
        
        /// <summary>
        /// Gets or sets the RPIO property
        /// </summary>
        public string RPIO { get; set; }
        
        /// <summary>
        /// Gets or sets the Section property
        /// </summary>
        public string Section { get; set; }
        
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; }
        
        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public override Provider Provider { get; set; }
        
        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

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
            ID = int.Parse( Record[ "ContactsId" ].ToString(  ) ?? "0" );
            FirstName = Record[ "FirstName" ].ToString(  );
            LastName = Record[ "LastName" ].ToString(  );
            FullName = Record[ "FullName" ].ToString(  );
            RPIO = Record[ "RPIO" ].ToString(  );
            EmailAddress = Record[ "EmailAddress" ].ToString(  );
            Section = Record[ "Section" ].ToString(  );
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
            ID = int.Parse( Record[ "ContactsId" ].ToString(  ) ?? "0" );
            FirstName = Record[ "FirstName" ].ToString(  );
            LastName = Record[ "LastName" ].ToString(  );
            FullName = Record[ "FullName" ].ToString(  );
            RPIO = Record[ "RPIO" ].ToString(  );
            EmailAddress = Record[ "EmailAddress" ].ToString(  );
            Section = Record[ "Section" ].ToString(  );
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
            ID = int.Parse( Record[ "ContactsId" ].ToString(  ) ?? "0" );
            FirstName = Record[ "FirstName" ].ToString(  );
            LastName = Record[ "LastName" ].ToString(  );
            FullName = Record[ "FullName" ].ToString(  );
            RPIO = Record[ "RPIO" ].ToString(  );
            EmailAddress = Record[ "EmailAddress" ].ToString(  );
            Section = Record[ "Section" ].ToString(  );
        }
    }
}

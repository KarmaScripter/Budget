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
    public class SchemaType
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> </summary>
        /// <value> </value>
        public string TypeName { get; set; }

        /// <summary> </summary>
        /// <value> </value>
        public string Database { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SchemaType"/>
        /// class.
        /// </summary>
        public SchemaType( )
        {
            Source = Source.SchemaTypes;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SchemaType"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public SchemaType( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "SchemaTypesId" ].ToString( ) ?? "0" );
            TypeName = Record[ "TypeName" ].ToString( );
            Database = Record[ "Database" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SchemaType"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public SchemaType( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "SchemaTypesId" ].ToString( ) ?? "0" );
            TypeName = Record[ "TypeName" ].ToString( );
            Database = Record[ "Database" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SchemaType"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public SchemaType( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "SchemaTypesId" ].ToString( ) ?? "0" );
            TypeName = dataRow[ "TypeName" ].ToString( );
            Database = dataRow[ "Database" ].ToString( );
        }
    }
}
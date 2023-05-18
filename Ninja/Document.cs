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
    public class Document : DataUnit, IDocument
    {
        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary> Gets or sets the category. </summary>
        /// <value> The category. </value>
        public string Category { get; set; }

        /// <summary> Gets or sets the system. </summary>
        /// <value> The system. </value>
        public string System { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Document"/>
        /// class.
        /// </summary>
        public Document( )
        {
            Source = Source.Documents;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Document"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Document( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "DocumentsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Category = Record[ "Category" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            System = Record[ "System" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Document"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public Document( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "DocumentsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Category = Record[ "Category" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            System = Record[ "System" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Document"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public Document( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "DocumentsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Category = Record[ "Category" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            System = Record[ "System" ].ToString( );
        }

        public Document( IDocument doc )
        {
            ID = doc.ID;
            Code = doc.Code;
            Name = doc.Name;
            System = doc.System;
            Category = doc.Category;
        }
    }
}
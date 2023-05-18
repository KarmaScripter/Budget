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
    public class DocumentControlNumber : IDocumentControlNumber
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

        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        public string RpioCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        public string RpioName { get; set; }

        /// <summary> Gets or sets the type of the document. </summary>
        /// <value> The type of the document. </value>
        public string DocumentType { get; set; }

        /// <summary> Gets or sets the document number. </summary>
        /// <value> The document number. </value>
        public string DocumentNumber { get; set; }

        /// <summary> Gets or sets the document prefix. </summary>
        /// <value> The document prefix. </value>
        public string DocumentPrefix { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DocumentControlNumber"/>
        /// class.
        /// </summary>
        public DocumentControlNumber( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DocumentControlNumber"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public DocumentControlNumber( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DocumentControlNumber"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public DocumentControlNumber( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DocumentControlNumber"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public DocumentControlNumber( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }

        public DocumentControlNumber( IDocumentControlNumber dcn )
        {
            ID = dcn.ID;
            RpioCode = dcn.RpioCode;
            RpioName = dcn.RpioName;
            DocumentType = dcn.DocumentType;
            DocumentPrefix = dcn.DocumentPrefix;
            DocumentNumber = dcn.DocumentNumber;
        }
    }
}
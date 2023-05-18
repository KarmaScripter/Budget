// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Change : DataUnit
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the name of the table. </summary>
        /// <value> The name of the table. </value>
        public string TableName { get; set; }

        /// <summary> Gets or sets the name of the field. </summary>
        /// <value> The name of the field. </value>
        public string FieldName { get; set; }

        /// <summary> Gets or sets the type of the action. </summary>
        /// <value> The type of the action. </value>
        public string ActionType { get; set; }

        /// <summary> Gets or sets the old value. </summary>
        /// <value> The old value. </value>
        public string OldValue { get; set; }

        /// <summary> Creates new value. </summary>
        /// <value> The new value. </value>
        public string NewValue { get; set; }

        /// <summary> Gets or sets the change date. </summary>
        /// <value> The change date. </value>
        public DateOnly ChangeDate { get; set; }

        /// <summary> Gets or sets the message. </summary>
        /// <value> The message. </value>
        public string Message { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public override Provider Provider { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Change"/>
        /// class.
        /// </summary>
        public Change( )
        {
            Source = Source.Changes;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Change"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public Change( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Change"/>
        /// class.
        /// </summary>
        /// <param name = "builder" > The builder. </param>
        public Change( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Change"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The data row. </param>
        public Change( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
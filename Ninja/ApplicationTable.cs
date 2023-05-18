﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ApplicationTable
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> Gets or sets the name of the table. </summary>
        /// <value> The name of the table. </value>
        public string TableName { get; set; }

        /// <summary> Gets or sets the model. </summary>
        /// <value> The model. </value>
        public string Model { get; set; }

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
        /// <see cref = "ApplicationTable"/>
        /// class.
        /// </summary>
        public ApplicationTable( )
        {
            Source = Source.ApplicationTables;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ApplicationTable"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public ApplicationTable( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ApplicationTablesId" ].ToString( ) ?? "0" );
            TableName = Record[ "TableName" ].ToString( );
            Model = Record[ "Model" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ApplicationTable"/>
        /// class.
        /// </summary>
        /// <param name = "builder" > The builder. </param>
        public ApplicationTable( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ApplicationTablesId" ].ToString( ) ?? "0" );
            TableName = Record[ "TableName" ].ToString( );
            Model = Record[ "Model" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ApplicationTable"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The data row. </param>
        public ApplicationTable( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "ApplicationTablesId" ].ToString( ) ?? "0" );
            TableName = dataRow[ "TableName" ].ToString( );
            Model = dataRow[ "Model" ].ToString( );
        }
    }
}
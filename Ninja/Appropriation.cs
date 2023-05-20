// <copyright file = "Appropriation.cs" company = "Terry D.Eppler">
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
    public class Appropriation : DataUnit 
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Appropriation"/>
        /// class.
        /// </summary>
        public Appropriation( )
        {
            Source = Source.Appropriations;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Appropriation"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Appropriation( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "AppropriationsId" ].ToString( ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Appropriation"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public Appropriation( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "AppropriationsId" ].ToString( ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Appropriation"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public Appropriation( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "AppropriationsId" ].ToString( ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        public Appropriation( Appropriation appropriation )
        {
            ID = appropriation.ID;
            Code = appropriation.Code;
            Name = appropriation.Name;
        }
    }
}
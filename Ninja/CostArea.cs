// <copyright file = "CostArea.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class CostArea : DataUnit
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CostArea"/>
        /// class.
        /// </summary>
        public CostArea( )
        {
            Source = Source.CostAreas;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CostArea"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public CostArea( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CostArea"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public CostArea( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CostArea"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public CostArea( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            Code = dataRow[ "Code" ].ToString( );
            Name = dataRow[ "Name" ].ToString( );
        }
    }
}
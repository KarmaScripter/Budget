// <copyright file = "SubAppropriation.cs" company = "Terry D.Eppler">
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
    public class SubAppropriation : DataUnit
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SubAppropriation"/>
        /// class.
        /// </summary>
        public SubAppropriation( )
        {
            Source = Source.SubAppropriations;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SubAppropriation"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public SubAppropriation( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SubAppropriation"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public SubAppropriation( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SubAppropriation"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public SubAppropriation( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            Code = dataRow[ "Code" ].ToString( );
            Name = dataRow[ "Name" ].ToString( );
        }

        public SubAppropriation( SubAppropriation subapprop )
        {
            ID = subapprop.ID;
            Code = subapprop.Code;
            Name = subapprop.Name;
        }
    }
}
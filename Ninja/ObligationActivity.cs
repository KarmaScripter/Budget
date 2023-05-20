// <copyright file = "ObligationActivity.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

// ReSharper disable All

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading;

    /// <summary> </summary>
    public class ObligationActivity : Obligation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ObligationActivity"/>
        /// class.
        /// </summary>
        public ObligationActivity( )
        {
            Source = Source.ObligationActivity;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ObligationActivity"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ObligationActivity( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ObligationActivity"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public ObligationActivity( IDataModel builder )
            : this( builder.Query )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ObligationActivity"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public ObligationActivity( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
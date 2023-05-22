// <copyright file = "TransferActivity.cs" company = "Terry D.Eppler">
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
    public class TransferActivity : Transfer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TransferActivity"/>
        /// class.
        /// </summary>
        public TransferActivity( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TransferActivity"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public TransferActivity( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TransferActivity"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public TransferActivity( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TransferActivity"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public TransferActivity( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
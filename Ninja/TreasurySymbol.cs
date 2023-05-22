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
    public class TreasurySymbol : Fund
    {
        /// <summary> Gets or sets the short key. </summary>
        /// <value> The short key. </value>
        public string ShortKey { get; set; }

        /// <summary> Gets or sets the lapsed. </summary>
        /// <value> The lapsed. </value>
        public string Lapsed { get; set; }

        /// <summary> Gets or sets the use cancelled year spending accounts. </summary>
        /// <value> The use cancelled year spending accounts. </value>
        public string UseCancelledYearSpendingAccounts { get; set; }

        /// <summary> Gets or sets the agency treasury symbol. </summary>
        /// <value> The agency treasury symbol. </value>
        public string AgencyTreasurySymbol { get; set; }

        /// <summary> Gets or sets the in use. </summary>
        /// <value> The in use. </value>
        public string InUse { get; set; }

        /// <summary> Gets or sets the prevent new use. </summary>
        /// <value> The prevent new use. </value>
        public string PreventNewUse { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TreasurySymbol"/>
        /// class.
        /// </summary>
        public TreasurySymbol( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TreasurySymbol"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public TreasurySymbol( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TreasurySymbol"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public TreasurySymbol( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TreasurySymbol"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public TreasurySymbol( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
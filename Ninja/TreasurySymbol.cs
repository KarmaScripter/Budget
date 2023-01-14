// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution 
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using BudgetExecution;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class TreasurySymbol : DataUnit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the short key.
        /// </summary>
        /// <value>
        /// The short key.
        /// </value>
        public string ShortKey { get; set; }

        /// <summary>
        /// Gets or sets the allocation transfer agency.
        /// </summary>
        /// <value>
        /// The allocation transfer agency.
        /// </value>
        public string AllocationTransferAgency { get; set; }

        /// <summary>
        /// Gets or sets the agency identifier.
        /// </summary>
        /// <value>
        /// The agency identifier.
        /// </value>
        public string AgencyIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the beginning period of availability.
        /// </summary>
        /// <value>
        /// The beginning period of availability.
        /// </value>
        public string BeginningPeriodOfAvailability { get; set; }

        /// <summary>
        /// Gets or sets the ending period of availability.
        /// </summary>
        /// <value>
        /// The ending period of availability.
        /// </value>
        public string EndingPeriodOfAvailability { get; set; }

        /// <summary>
        /// Gets or sets the type of the availability.
        /// </summary>
        /// <value>
        /// The type of the availability.
        /// </value>
        public string AvailabilityType { get; set; }

        /// <summary>
        /// Gets or sets the main account.
        /// </summary>
        /// <value>
        /// The main account.
        /// </value>
        public string MainAccount { get; set; }

        /// <summary>
        /// Gets or sets the sub account.
        /// </summary>
        /// <value>
        /// The sub account.
        /// </value>
        public string SubAccount { get; set; }

        /// <summary>
        /// Gets or sets the lapsed.
        /// </summary>
        /// <value>
        /// The lapsed.
        /// </value>
        public string Lapsed { get; set; }

        /// <summary>
        /// Gets or sets the use cancelled year spending accounts.
        /// </summary>
        /// <value>
        /// The use cancelled year spending accounts.
        /// </value>
        public string UseCancelledYearSpendingAccounts { get; set; }

        /// <summary>
        /// Gets or sets the agency treasury symbol.
        /// </summary>
        /// <value>
        /// The agency treasury symbol.
        /// </value>
        public string AgencyTreasurySymbol { get; set; }

        /// <summary>
        /// Gets or sets the in use.
        /// </summary>
        /// <value>
        /// The in use.
        /// </value>
        public string InUse { get; set; }

        /// <summary>
        /// Gets or sets the prevent new use.
        /// </summary>
        /// <value>
        /// The prevent new use.
        /// </value>
        public string PreventNewUse { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasurySymbol"/> class.
        /// </summary>
        public TreasurySymbol( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasurySymbol"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public TreasurySymbol( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasurySymbol"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public TreasurySymbol( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasurySymbol"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public TreasurySymbol( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

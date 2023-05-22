// <copyright file = "ReimbursableFund.cs" company = "Terry D.Eppler">
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
    public class ReimbursableFund : PRC
    {
        /// <summary> Gets or sets the document control number. </summary>
        /// <value> The document control number. </value>
        public string DocumentControlNumber { get; set; }

        /// <summary> Gets or sets the agreement number. </summary>
        /// <value> The agreement number. </value>
        public string AgreementNumber { get; set; }

        /// <summary> Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        public double Amount { get; set; }

        /// <summary> Gets or sets the open commitments. </summary>
        /// <value> The open commitments. </value>
        public double OpenCommitments { get; set; }

        /// <summary> Gets or sets the obligations. </summary>
        /// <value> The obligations. </value>
        public double Obligations { get; set; }

        /// <summary> Gets or sets the ulo. </summary>
        /// <value> The ulo. </value>
        public double ULO { get; set; }

        /// <summary> Gets or sets the available. </summary>
        /// <value> The available. </value>
        public double Available { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ReimbursableFund"/>
        /// class.
        /// </summary>
        public ReimbursableFund( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ReimbursableFund"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ReimbursableFund( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ReimbursableFund"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public ReimbursableFund( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ReimbursableFund"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public ReimbursableFund( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
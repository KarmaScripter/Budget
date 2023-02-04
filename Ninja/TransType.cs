// <copyright file = "TransType.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class TransType : DataUnit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public string EFY { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        public string DocType { get; set; }

        /// <summary>
        /// Gets or sets the appropriation bill.
        /// </summary>
        /// <value>
        /// The appropriation bill.
        /// </value>
        public string AppropriationBill { get; set; }

        /// <summary>
        /// Gets or sets the continuing resolution.
        /// </summary>
        /// <value>
        /// The continuing resolution.
        /// </value>
        public string ContinuingResolution { get; set; }

        /// <summary>
        /// Gets or sets the rescission current year.
        /// </summary>
        /// <value>
        /// The rescission current year.
        /// </value>
        public string RescissionCurrentYear { get; set; }

        /// <summary>
        /// Gets or sets the rescission prior year.
        /// </summary>
        /// <value>
        /// The rescission prior year.
        /// </value>
        public string RescissionPriorYear { get; set; }

        /// <summary>
        /// Gets or sets the sequester reduction.
        /// </summary>
        /// <value>
        /// The sequester reduction.
        /// </value>
        public string SequesterReduction { get; set; }

        /// <summary>
        /// Gets or sets the sequester return.
        /// </summary>
        /// <value>
        /// The sequester return.
        /// </value>
        public string SequesterReturn { get; set; }
        
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransType"/> class.
        /// </summary>
        public TransType( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransType"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public TransType( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransType"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public TransType( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransType"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public TransType( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

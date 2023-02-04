// <copyright file = "AppropriationAvailableBalance.cs" company = "Terry D. Eppler">
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
    public class AppropriationAvailableBalance : PRC
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
        public override string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public override string EFY { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public override string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public override string FundName { get; set; }

        /// <summary>
        /// Gets or sets the budget account code.
        /// </summary>
        /// <value>
        /// The budget account code.
        /// </value>
        public string BudgetAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget account.
        /// </summary>
        /// <value>
        /// The name of the budget account.
        /// </value>
        public string BudgetAccountName { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the treasury account.
        /// </summary>
        /// <value>
        /// The name of the treasury account.
        /// </value>
        public string TreasuryAccountName { get; set; }

        /// <summary>
        /// Gets or sets the total authority.
        /// </summary>
        /// <value>
        /// The total authority.
        /// </value>
        public double TotalAuthority { get; set; }

        /// <summary>
        /// Gets or sets the budgeted.
        /// </summary>
        /// <value>
        /// The budgeted.
        /// </value>
        public double Budgeted { get; set; }

        /// <summary>
        /// Gets or sets the carry over.
        /// </summary>
        /// <value>
        /// The carry over.
        /// </value>
        public double CarryOver { get; set; }

        /// <summary>
        /// Gets or sets the total reimbursements.
        /// </summary>
        /// <value>
        /// The total reimbursements.
        /// </value>
        public double TotalReimbursements { get; set; }

        /// <summary>
        /// Gets or sets the total recoveries.
        /// </summary>
        /// <value>
        /// The total recoveries.
        /// </value>
        public double TotalRecoveries { get; set; }

        /// <summary>
        /// Gets or sets the total used.
        /// </summary>
        /// <value>
        /// The total used.
        /// </value>
        public double TotalUsed { get; set; }

        /// <summary>
        /// Gets or sets the total available.
        /// </summary>
        /// <value>
        /// The total available.
        /// </value>
        public double TotalAvailable { get; set; }
        
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
        /// Initializes a new instance of the <see cref="AppropriationAvailableBalance"/> class.
        /// </summary>
        public AppropriationAvailableBalance( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationAvailableBalance"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AppropriationAvailableBalance( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationAvailableBalance"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public AppropriationAvailableBalance( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationAvailableBalance"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AppropriationAvailableBalance( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

// <copyright file = "UnobligatedAuthority.cs" company = "Terry D. Eppler">
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
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class UnobligatedAuthority
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the report year.
        /// </summary>
        /// <value>
        /// The report year.
        /// </value>
        public string ReportYear { get; set; }

        /// <summary>
        /// Gets or sets the agency code.
        /// </summary>
        /// <value>
        /// The agency code.
        /// </value>
        public string AgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the agency.
        /// </summary>
        /// <value>
        /// The name of the agency.
        /// </value>
        public string AgencyName { get; set; }

        /// <summary>
        /// Gets or sets the bureau code.
        /// </summary>
        /// <value>
        /// The bureau code.
        /// </value>
        public string BureauCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the bureau.
        /// </summary>
        /// <value>
        /// The name of the bureau.
        /// </value>
        public string BureauName { get; set; }

        /// <summary>
        /// Gets or sets the account code.
        /// </summary>
        /// <value>
        /// The account code.
        /// </value>
        public string AccountCode { get; set; }

        /// <summary>
        /// Gets or sets the omb account.
        /// </summary>
        /// <value>
        /// The omb account.
        /// </value>
        public string OmbAccount { get; set; }

        /// <summary>
        /// Gets or sets the name of the omb account.
        /// </summary>
        /// <value>
        /// The name of the omb account.
        /// </value>
        public string OmbAccountName { get; set; }

        /// <summary>
        /// Gets or sets the name of the line.
        /// </summary>
        /// <value>
        /// The name of the line.
        /// </value>
        public string LineName { get; set; }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        /// <value>
        /// The line number.
        /// </value>
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the budget year.
        /// </summary>
        /// <value>
        /// The budget year.
        /// </value>
        public double BudgetYear { get; set; }

        /// <summary>
        /// Gets or sets the prior year.
        /// </summary>
        /// <value>
        /// The prior year.
        /// </value>
        public double PriorYear { get; set; }

        /// <summary>
        /// Gets or sets the current year.
        /// </summary>
        /// <value>
        /// The current year.
        /// </value>
        public double CurrentYear { get; set; }
        
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnobligatedAuthority"/> class.
        /// </summary>
        public UnobligatedAuthority( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnobligatedAuthority"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public UnobligatedAuthority( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnobligatedAuthority"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public UnobligatedAuthority( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnobligatedAuthority"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public UnobligatedAuthority( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

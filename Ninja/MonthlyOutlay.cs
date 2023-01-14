// <copyright file = "MonthlyOutlays.cs" company = "Terry D. Eppler">
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
    public class MonthlyOutlay
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the fiscal year.
        /// </summary>
        /// <value>
        /// The fiscal year.
        /// </value>
        public string FiscalYear { get; set; }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        /// <value>
        /// The line number.
        /// </value>
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the line title.
        /// </summary>
        /// <value>
        /// The line title.
        /// </value>
        public string LineTitle { get; set; }

        /// <summary>
        /// Gets or sets the taxation code.
        /// </summary>
        /// <value>
        /// The taxation code.
        /// </value>
        public string TaxationCode { get; set; }

        /// <summary>
        /// Gets or sets the treasury agency.
        /// </summary>
        /// <value>
        /// The treasury agency.
        /// </value>
        public string TreasuryAgency { get; set; }

        /// <summary>
        /// Gets or sets the treasury account.
        /// </summary>
        /// <value>
        /// The treasury account.
        /// </value>
        public string TreasuryAccount { get; set; }

        /// <summary>
        /// Gets or sets the sub account.
        /// </summary>
        /// <value>
        /// The sub account.
        /// </value>
        public string SubAccount { get; set; }

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
        /// Gets or sets the omb agency.
        /// </summary>
        /// <value>
        /// The omb agency.
        /// </value>
        public string OmbAgency { get; set; }

        /// <summary>
        /// Gets or sets the omb bureau.
        /// </summary>
        /// <value>
        /// The omb bureau.
        /// </value>
        public string OmbBureau { get; set; }

        /// <summary>
        /// Gets or sets the omb account.
        /// </summary>
        /// <value>
        /// The omb account.
        /// </value>
        public string OmbAccount { get; set; }

        /// <summary>
        /// Gets or sets the agency sequence.
        /// </summary>
        /// <value>
        /// The agency sequence.
        /// </value>
        public string AgencySequence { get; set; }

        /// <summary>
        /// Gets or sets the bureau sequence.
        /// </summary>
        /// <value>
        /// The bureau sequence.
        /// </value>
        public string BureauSequence { get; set; }

        /// <summary>
        /// Gets or sets the account sequence.
        /// </summary>
        /// <value>
        /// The account sequence.
        /// </value>
        public string AccountSequence { get; set; }

        /// <summary>
        /// Gets or sets the agency title.
        /// </summary>
        /// <value>
        /// The agency title.
        /// </value>
        public string AgencyTitle { get; set; }

        /// <summary>
        /// Gets or sets the bureau title.
        /// </summary>
        /// <value>
        /// The bureau title.
        /// </value>
        public string BureauTitle { get; set; }

        /// <summary>
        /// Gets or sets the omb account title.
        /// </summary>
        /// <value>
        /// The omb account title.
        /// </value>
        public string OmbAccountTitle { get; set; }

        /// <summary>
        /// Gets or sets the treasury account title.
        /// </summary>
        /// <value>
        /// The treasury account title.
        /// </value>
        public string TreasuryAccountTitle { get; set; }

        /// <summary>
        /// Gets or sets the october.
        /// </summary>
        /// <value>
        /// The october.
        /// </value>
        public double October { get; set; }

        /// <summary>
        /// Gets or sets the november.
        /// </summary>
        /// <value>
        /// The november.
        /// </value>
        public double November { get; set; }

        /// <summary>
        /// Gets or sets the december.
        /// </summary>
        /// <value>
        /// The december.
        /// </value>
        public double December { get; set; }

        /// <summary>
        /// Gets or sets the january.
        /// </summary>
        /// <value>
        /// The january.
        /// </value>
        public double January { get; set; }

        /// <summary>
        /// Gets or sets the feburary.
        /// </summary>
        /// <value>
        /// The feburary.
        /// </value>
        public double February { get; set; }

        /// <summary>
        /// Gets or sets the march.
        /// </summary>
        /// <value>
        /// The march.
        /// </value>
        public double March { get; set; }

        /// <summary>
        /// Gets or sets the april.
        /// </summary>
        /// <value>
        /// The april.
        /// </value>
        public double April { get; set; }

        /// <summary>
        /// Gets or sets the may.
        /// </summary>
        /// <value>
        /// The may.
        /// </value>
        public double May { get; set; }

        /// <summary>
        /// Gets or sets the june.
        /// </summary>
        /// <value>
        /// The june.
        /// </value>
        public double June { get; set; }

        /// <summary>
        /// Gets or sets the july.
        /// </summary>
        /// <value>
        /// The july.
        /// </value>
        public double July { get; set; }

        /// <summary>
        /// Gets or sets the august.
        /// </summary>
        /// <value>
        /// The august.
        /// </value>
        public double August { get; set; }

        /// <summary>
        /// Gets or sets the september.
        /// </summary>
        /// <value>
        /// The september.
        /// </value>
        public double September { get; set; }
        
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
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        public MonthlyOutlay( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public MonthlyOutlay( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public MonthlyOutlay( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public MonthlyOutlay( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

// <copyright file = "CarryoverOutlays.cs" company = "Terry D. Eppler">
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
    public class CarryoverOutlay
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
        /// Gets or sets the name of the agency.
        /// </summary>
        /// <value>
        /// The name of the agency.
        /// </value>
        public string AgencyName { get; set; }

        /// <summary>
        /// Gets or sets the name of the omb account.
        /// </summary>
        /// <value>
        /// The name of the omb account.
        /// </value>
        public string OmbAccountName { get; set; }

        /// <summary>
        /// Gets or sets the line.
        /// </summary>
        /// <value>
        /// The line.
        /// </value>
        public string Line { get; set; }

        /// <summary>
        /// Gets or sets the carryover.
        /// </summary>
        /// <value>
        /// The carryover.
        /// </value>
        public double Carryover { get; set; }

        /// <summary>
        /// Gets or sets the carryover outlays.
        /// </summary>
        /// <value>
        /// The carryover outlays.
        /// </value>
        public double CarryoverOutlays { get; set; }

        /// <summary>
        /// Gets or sets the delta.
        /// </summary>
        /// <value>
        /// The delta.
        /// </value>
        public double Delta { get; set; }

        /// <summary>
        /// Gets or sets the available balance.
        /// </summary>
        /// <value>
        /// The available balance.
        /// </value>
        public double AvailableBalance { get; set; }

        /// <summary>
        /// Gets or sets the ulo.
        /// </summary>
        /// <value>
        /// The ulo.
        /// </value>
        public double ULO { get; set; }

        /// <summary>
        /// Gets or sets the current year adjustment.
        /// </summary>
        /// <value>
        /// The current year adjustment.
        /// </value>
        public double CurrentYearAdjustment { get; set; }

        /// <summary>
        /// Gets or sets the budget year adjustment.
        /// </summary>
        /// <value>
        /// The budget year adjustment.
        /// </value>
        public double BudgetYearAdjustment { get; set; }

        /// <summary>
        /// Gets or sets the current year.
        /// </summary>
        /// <value>
        /// The current year.
        /// </value>
        public double CurrentYear { get; set; }

        /// <summary>
        /// Gets or sets the budget year.
        /// </summary>
        /// <value>
        /// The budget year.
        /// </value>
        public double BudgetYear { get; set; }

        /// <summary>
        /// Gets or sets the out year1.
        /// </summary>
        /// <value>
        /// The out year1.
        /// </value>
        public double OutYear1 { get; set; }

        /// <summary>
        /// Gets or sets the out year2.
        /// </summary>
        /// <value>
        /// The out year2.
        /// </value>
        public double OutYear2 { get; set; }

        /// <summary>
        /// Gets or sets the out year3.
        /// </summary>
        /// <value>
        /// The out year3.
        /// </value>
        public double OutYear3 { get; set; }

        /// <summary>
        /// Gets or sets the out year4.
        /// </summary>
        /// <value>
        /// The out year4.
        /// </value>
        public double OutYear4 { get; set; }

        /// <summary>
        /// Gets or sets the out year5.
        /// </summary>
        /// <value>
        /// The out year5.
        /// </value>
        public double OutYear5 { get; set; }

        /// <summary>
        /// Gets or sets the out year6.
        /// </summary>
        /// <value>
        /// The out year6.
        /// </value>
        public double OutYear6 { get; set; }

        /// <summary>
        /// Gets or sets the out year7.
        /// </summary>
        /// <value>
        /// The out year7.
        /// </value>
        public double OutYear7 { get; set; }

        /// <summary>
        /// Gets or sets the out year8.
        /// </summary>
        /// <value>
        /// The out year8.
        /// </value>
        public double OutYear8 { get; set; }

        /// <summary>
        /// Gets or sets the out year9.
        /// </summary>
        /// <value>
        /// The out year9.
        /// </value>
        public double OutYear9 { get; set; }
        
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
        /// Initializes a new instance of the <see cref="CarryoverOutlay"/> class.
        /// </summary>
        public CarryoverOutlay( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverOutlay"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CarryoverOutlay( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverOutlay"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CarryoverOutlay( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverOutlay"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CarryoverOutlay( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

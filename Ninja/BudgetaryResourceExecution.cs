// <copyright file = "BudgetaryResourceExecution.cs" company = "Terry D. Eppler">
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
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BudgetaryResourceExecution
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
        /// Gets or sets the last update.
        /// </summary>
        /// <value>
        /// The last update.
        /// </value>
        public string LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the treasury symbol.
        /// </summary>
        /// <value>
        /// The treasury symbol.
        /// </value>
        public string TreasurySymbol { get; set; }

        /// <summary>
        /// Gets or sets the omb account.
        /// </summary>
        /// <value>
        /// The omb account.
        /// </value>
        public string OmbAccount { get; set; }

        /// <summary>
        /// Gets or sets the treasury agency code.
        /// </summary>
        /// <value>
        /// The treasury agency code.
        /// </value>
        public string TreasuryAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the stat.
        /// </summary>
        /// <value>
        /// The stat.
        /// </value>
        public string STAT { get; set; }

        /// <summary>
        /// Gets or sets the credit indicator.
        /// </summary>
        /// <value>
        /// The credit indicator.
        /// </value>
        public string CreditIndicator { get; set; }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        /// <value>
        /// The line number.
        /// </value>
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the line description.
        /// </summary>
        /// <value>
        /// The line description.
        /// </value>
        public string LineDescription { get; set; }

        /// <summary>
        /// Gets or sets the name of the section.
        /// </summary>
        /// <value>
        /// The name of the section.
        /// </value>
        public string SectionName { get; set; }

        /// <summary>
        /// Gets or sets the section number.
        /// </summary>
        /// <value>
        /// The section number.
        /// </value>
        public string SectionNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the line.
        /// </summary>
        /// <value>
        /// The type of the line.
        /// </value>
        public string LineType { get; set; }

        /// <summary>
        /// Gets or sets the financing accounts.
        /// </summary>
        /// <value>
        /// The financing accounts.
        /// </value>
        public string FinancingAccounts { get; set; }

        /// <summary>
        /// Gets or sets the november.
        /// </summary>
        /// <value>
        /// The november.
        /// </value>
        public double November { get; set; }

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
        /// Gets or sets the august.
        /// </summary>
        /// <value>
        /// The august.
        /// </value>
        public double August { get; set; }

        /// <summary>
        /// Gets or sets the october.
        /// </summary>
        /// <value>
        /// The october.
        /// </value>
        public double October { get; set; }

        /// <summary>
        /// Gets or sets the amount1.
        /// </summary>
        /// <value>
        /// The amount1.
        /// </value>
        public double Amount1 { get; set; }

        /// <summary>
        /// Gets or sets the amount2.
        /// </summary>
        /// <value>
        /// The amount2.
        /// </value>
        public double Amount2 { get; set; }

        /// <summary>
        /// Gets or sets the amount3.
        /// </summary>
        /// <value>
        /// The amount3.
        /// </value>
        public double Amount3 { get; set; }

        /// <summary>
        /// Gets or sets the amount4.
        /// </summary>
        /// <value>
        /// The amount4.
        /// </value>
        public double Amount4 { get; set; }

        /// <summary>
        /// Gets or sets the agency.
        /// </summary>
        /// <value>
        /// The agency.
        /// </value>
        public string Agency { get; set; }

        /// <summary>
        /// Gets or sets the bureau.
        /// </summary>
        /// <value>
        /// The bureau.
        /// </value>
        public string Bureau { get; set; }
        
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
        /// Initializes a new instance of the <see cref="BudgetaryResourceExecution"/> class.
        /// </summary>
        public BudgetaryResourceExecution( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetaryResourceExecution"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetaryResourceExecution( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetaryResourceExecution"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public BudgetaryResourceExecution( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetaryResourceExecution"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetaryResourceExecution( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

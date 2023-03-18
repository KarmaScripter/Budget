﻿// <copyright file = "MonthlyOutlays.cs" company = "Terry D. Eppler">
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
    public class MonthlyOutlay : BudgetUnit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

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
        public string TreasuryAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the treasury bureau code.
        /// </summary>
        /// <value>
        /// The treasury bureau code.
        /// </value>
        public string TreasuryBureauCode { get; set; }

        /// <summary>
        /// Gets or sets the budget agency code.
        /// </summary>
        /// <value>
        /// The budget agency code.
        /// </value>
        public string BudgetAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the budget bureau code.
        /// </summary>
        /// <value>
        /// The budget bureau code.
        /// </value>
        public string BudgetBureauCode { get; set; }
        
        /// <summary>
        /// Gets or sets the treasury account.
        /// </summary>
        /// <value>
        /// The treasury account.
        /// </value>
        public override string TreasuryAccountCode { get; set; }

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
        public override string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public override string EFY { get; set; }
        
        /// <summary>
        /// Gets or sets the omb account.
        /// </summary>
        /// <value>
        /// The omb account.
        /// </value>
        public override string BudgetAccountCode { get; set; }

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
        public override string BudgetAccountName { get; set; }

        /// <summary>
        /// Gets or sets the treasury account title.
        /// </summary>
        /// <value>
        /// The treasury account title.
        /// </value>
        public override string TreasuryAccountName { get; set; }

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
            ID = int.Parse( Record[ "MonthlyOutlaysId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FiscalYear = Record[ "FiscalYear" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            LineTitle = Record[ "LineTitle" ].ToString( );
            TaxationCode = Record[ "TaxationCode" ].ToString( );
            TreasuryAgencyCode = Record[ "TreasuryAgency" ].ToString( );
            TreasuryBureauCode = Record[ "TreasuryBureauCode" ].ToString( );
            BudgetAgencyCode = Record[ "BudgetAgencyCode" ].ToString( );
            TreasuryAgencyCode = Record[ "TreasuryAgencyCode" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            October = double.Parse( Record[ "October" ].ToString( ) ?? "0" );
            November = double.Parse( Record[ "November" ].ToString( ) ?? "0" );
            December = double.Parse( Record[ "December" ].ToString( ) ?? "0" );
            January = double.Parse( Record[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( Record[ "February" ].ToString( ) ?? "0" );
            March = double.Parse( Record[ "March" ].ToString( ) ?? "0" );
            April = double.Parse( Record[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( Record[ "May" ].ToString( ) ?? "0" );
            June = double.Parse( Record[ "June" ].ToString( ) ?? "0" );
            July = double.Parse( Record[ "July" ].ToString( ) ?? "0" );
            August = double.Parse( Record[ "August" ].ToString( ) ?? "0" );
            September = double.Parse( Record[ "September" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public MonthlyOutlay( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "MonthlyOutlaysId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FiscalYear = Record[ "FiscalYear" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            LineTitle = Record[ "LineTitle" ].ToString( );
            TaxationCode = Record[ "TaxationCode" ].ToString( );
            TreasuryAgencyCode = Record[ "TreasuryAgency" ].ToString( );
            TreasuryBureauCode = Record[ "TreasuryBureauCode" ].ToString( );
            BudgetAgencyCode = Record[ "BudgetAgencyCode" ].ToString( );
            TreasuryAgencyCode = Record[ "TreasuryAgencyCode" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            October = double.Parse( Record[ "October" ].ToString( ) ?? "0" );
            November = double.Parse( Record[ "November" ].ToString( ) ?? "0" );
            December = double.Parse( Record[ "December" ].ToString( ) ?? "0" );
            January = double.Parse( Record[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( Record[ "February" ].ToString( ) ?? "0" );
            March = double.Parse( Record[ "March" ].ToString( ) ?? "0" );
            April = double.Parse( Record[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( Record[ "May" ].ToString( ) ?? "0" );
            June = double.Parse( Record[ "June" ].ToString( ) ?? "0" );
            July = double.Parse( Record[ "July" ].ToString( ) ?? "0" );
            August = double.Parse( Record[ "August" ].ToString( ) ?? "0" );
            September = double.Parse( Record[ "September" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public MonthlyOutlay( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "MonthlyOutlaysId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FiscalYear = dataRow[ "FiscalYear" ].ToString( );
            LineNumber = dataRow[ "LineNumber" ].ToString( );
            LineTitle = dataRow[ "LineTitle" ].ToString( );
            TaxationCode = dataRow[ "TaxationCode" ].ToString( );
            TreasuryAgencyCode = dataRow[ "TreasuryAgency" ].ToString( );
            TreasuryBureauCode = dataRow[ "TreasuryBureauCode" ].ToString( );
            BudgetAgencyCode = dataRow[ "BudgetAgencyCode" ].ToString( );
            TreasuryAgencyCode = dataRow[ "TreasuryAgencyCode" ].ToString( );
            SubAccount = dataRow[ "SubAccount" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            October = double.Parse( dataRow[ "October" ].ToString( ) ?? "0" );
            November = double.Parse( dataRow[ "November" ].ToString( ) ?? "0" );
            December = double.Parse( dataRow[ "December" ].ToString( ) ?? "0" );
            January = double.Parse( dataRow[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( dataRow[ "February" ].ToString( ) ?? "0" );
            March = double.Parse( dataRow[ "March" ].ToString( ) ?? "0" );
            April = double.Parse( dataRow[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( dataRow[ "May" ].ToString( ) ?? "0" );
            June = double.Parse( dataRow[ "June" ].ToString( ) ?? "0" );
            July = double.Parse( dataRow[ "July" ].ToString( ) ?? "0" );
            August = double.Parse( dataRow[ "August" ].ToString( ) ?? "0" );
            September = double.Parse( dataRow[ "September" ].ToString( ) ?? "0" );
        }
    }
}

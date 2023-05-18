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
    public class BudgetOutlay : DataUnit
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the report year. </summary>
        /// <value> The report year. </value>
        public string ReportYear { get; set; }

        /// <summary> Gets or sets the name of the agency. </summary>
        /// <value> The name of the agency. </value>
        public string AgencyName { get; set; }

        /// <summary> Gets or sets the omb account. </summary>
        /// <value> The omb account. </value>
        public string BudgetAccountName { get; set; }

        /// <summary> Gets or sets the line. </summary>
        /// <value> The line. </value>
        public string Line { get; set; }

        /// <summary> Gets or sets the line number. </summary>
        /// <value> The line number. </value>
        public string LineNumber { get; set; }

        /// <summary> Gets or sets the line section. </summary>
        /// <value> The line section. </value>
        public string LineSection { get; set; }

        /// <summary> Gets or sets the name of the line. </summary>
        /// <value> The name of the line. </value>
        public string LineName { get; set; }

        /// <summary> Gets or sets the bea category. </summary>
        /// <value> The bea category. </value>
        public string Category { get; set; }

        /// <summary> Gets or sets the name of the bea category. </summary>
        /// <value> The name of the bea category. </value>
        public string CategoryName { get; set; }

        /// <summary> Gets or sets the line category. </summary>
        /// <value> The line category. </value>
        public string LineCategory { get; set; }

        /// <summary> Gets or sets the prior year. </summary>
        /// <value> The prior year. </value>
        public double PriorYear { get; set; }

        /// <summary> Gets or sets the current year. </summary>
        /// <value> The current year. </value>
        public double CurrentYear { get; set; }

        /// <summary> Gets or sets the budget year. </summary>
        /// <value> The budget year. </value>
        public double BudgetYear { get; set; }

        /// <summary> Gets or sets the out year1. </summary>
        /// <value> The out year1. </value>
        public double OutYear1 { get; set; }

        /// <summary> Gets or sets the out year2. </summary>
        /// <value> The out year2. </value>
        public double OutYear2 { get; set; }

        /// <summary> Gets or sets the out year3. </summary>
        /// <value> The out year3. </value>
        public double OutYear3 { get; set; }

        /// <summary> Gets or sets the out year4. </summary>
        /// <value> The out year4. </value>
        public double OutYear4 { get; set; }

        /// <summary> Gets or sets the out year5. </summary>
        /// <value> The out year5. </value>
        public double OutYear5 { get; set; }

        /// <summary> Gets or sets the out year6. </summary>
        /// <value> The out year6. </value>
        public double OutYear6 { get; set; }

        /// <summary> Gets or sets the out year7. </summary>
        /// <value> The out year7. </value>
        public double OutYear7 { get; set; }

        /// <summary> Gets or sets the out year8. </summary>
        /// <value> The out year8. </value>
        public double OutYear8 { get; set; }

        /// <summary> Gets or sets the out year9. </summary>
        /// <value> The out year9. </value>
        public double OutYear9 { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public override Provider Provider { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetOutlay"/>
        /// class.
        /// </summary>
        public BudgetOutlay( )
        {
            Source = Source.BudgetOutlays;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetOutlay"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public BudgetOutlay( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            ID = int.Parse( Record[ "BudgetAuthorityAndOutlaysId" ].ToString( ) ?? "0" );
            ReportYear = Record[ "ReportYear" ].ToString( );
            AgencyName = Record[ "AgencyName" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            LineSection = Record[ "LineSection" ].ToString( );
            LineName = Record[ "LineName" ].ToString( );
            LineCategory = Record[ "LineCategory" ].ToString( );
            PriorYear = double.Parse( Record[ "PriorYear" ].ToString( ) ?? "0" );
            CurrentYear = double.Parse( Record[ "CurrentYear" ].ToString( ) ?? "0" );
            BudgetYear = Double.Parse( Record[ "BudgetYear" ].ToString( ) ?? "0" );
            OutYear1 = double.Parse( Record[ "OutYear1" ].ToString( ) ?? "0" );
            OutYear2 = double.Parse( Record[ "OutYear2" ].ToString( ) ?? "0" );
            OutYear3 = double.Parse( Record[ "OutYear3" ].ToString( ) ?? "0" );
            OutYear4 = double.Parse( Record[ "OutYear4" ].ToString( ) ?? "0" );
            OutYear5 = double.Parse( Record[ "OutYear5" ].ToString( ) ?? "0" );
            OutYear6 = double.Parse( Record[ "OutYear6" ].ToString( ) ?? "0" );
            OutYear7 = double.Parse( Record[ "OutYear7" ].ToString( ) ?? "0" );
            OutYear8 = double.Parse( Record[ "OutYear8" ].ToString( ) ?? "0" );
            OutYear9 = double.Parse( Record[ "OutYear9" ].ToString( ) ?? "0" );
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetOutlay"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public BudgetOutlay( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            ID = int.Parse( Record[ "BudgetAuthorityAndOutlaysId" ].ToString( ) ?? "0" );
            ReportYear = Record[ "ReportYear" ].ToString( );
            AgencyName = Record[ "AgencyName" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            LineSection = Record[ "LineSection" ].ToString( );
            LineName = Record[ "LineName" ].ToString( );
            LineCategory = Record[ "LineCategory" ].ToString( );
            PriorYear = double.Parse( Record[ "PriorYear" ].ToString( ) ?? "0" );
            CurrentYear = double.Parse( Record[ "CurrentYear" ].ToString( ) ?? "0" );
            BudgetYear = Double.Parse( Record[ "BudgetYear" ].ToString( ) ?? "0" );
            OutYear1 = double.Parse( Record[ "OutYear1" ].ToString( ) ?? "0" );
            OutYear2 = double.Parse( Record[ "OutYear2" ].ToString( ) ?? "0" );
            OutYear3 = double.Parse( Record[ "OutYear3" ].ToString( ) ?? "0" );
            OutYear4 = double.Parse( Record[ "OutYear4" ].ToString( ) ?? "0" );
            OutYear5 = double.Parse( Record[ "OutYear5" ].ToString( ) ?? "0" );
            OutYear6 = double.Parse( Record[ "OutYear6" ].ToString( ) ?? "0" );
            OutYear7 = double.Parse( Record[ "OutYear7" ].ToString( ) ?? "0" );
            OutYear8 = double.Parse( Record[ "OutYear8" ].ToString( ) ?? "0" );
            OutYear9 = double.Parse( Record[ "OutYear9" ].ToString( ) ?? "0" );
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetOutlay"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public BudgetOutlay( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( dataRow[ "BudgetAuthorityAndOutlaysId" ].ToString( ) ?? "0" );
            ReportYear = dataRow[ "ReportYear" ].ToString( );
            AgencyName = dataRow[ "AgencyName" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            Line = dataRow[ "Line" ].ToString( );
            LineSection = dataRow[ "LineSection" ].ToString( );
            LineName = dataRow[ "LineName" ].ToString( );
            LineCategory = dataRow[ "LineCategory" ].ToString( );
            PriorYear = double.Parse( dataRow[ "PriorYear" ].ToString( ) ?? "0" );
            CurrentYear = double.Parse( dataRow[ "CurrentYear" ].ToString( ) ?? "0" );
            BudgetYear = Double.Parse( dataRow[ "BudgetYear" ].ToString( ) ?? "0" );
            OutYear1 = double.Parse( dataRow[ "OutYear1" ].ToString( ) ?? "0" );
            OutYear2 = double.Parse( dataRow[ "OutYear2" ].ToString( ) ?? "0" );
            OutYear3 = double.Parse( dataRow[ "OutYear3" ].ToString( ) ?? "0" );
            OutYear4 = double.Parse( dataRow[ "OutYear4" ].ToString( ) ?? "0" );
            OutYear5 = double.Parse( dataRow[ "OutYear5" ].ToString( ) ?? "0" );
            OutYear6 = double.Parse( dataRow[ "OutYear6" ].ToString( ) ?? "0" );
            OutYear7 = double.Parse( dataRow[ "OutYear7" ].ToString( ) ?? "0" );
            OutYear8 = double.Parse( dataRow[ "OutYear8" ].ToString( ) ?? "0" );
            OutYear9 = double.Parse( dataRow[ "OutYear9" ].ToString( ) ?? "0" );
            Data = dataRow.ToDictionary( );
        }
    }
}
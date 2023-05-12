// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
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
    public class CarryoverOutlay : BudgetUnit
    {
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
        public string BudgetAccountName { get; set; }

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
        public override Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public override Provider Provider { get; set; }

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
        /// Initializes a new instance of the <see cref="CarryoverOutlay"/> class.
        /// </summary>
        public CarryoverOutlay( )
        {
            Source = Source.CarryoverOutlays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverOutlay"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CarryoverOutlay( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverOutlaysId" ].ToString( ) ?? "0" );
            ReportYear = Record[ "ReportYear" ].ToString( );
            AgencyName = Record[ "AgencyName" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            Carryover = double.Parse( Record[ "Carryover" ].ToString( ) ?? "0" );
            CarryoverOutlays = double.Parse( Record[ "CarryoverOutlays" ].ToString( ) ?? "0" );
            Delta = double.Parse( Record[ "Delta" ].ToString( ) ?? "0" );
            AvailableBalance = double.Parse( Record[ "AvailableBalance" ].ToString( ) ?? "0" );
            ULO = double.Parse( Record[ "ULO" ].ToString( ) ?? "0" );
            CurrentYearAdjustment = 
                double.Parse( Record[ "CurrentYearAdjustment" ].ToString( ) ?? "0" );

            BudgetYearAdjustment =
                double.Parse( Record[ "BudgetYearAdjustment" ].ToString( ) ?? "0" );

            CurrentYear = double.Parse( Record[ "CurrentYear" ].ToString( ) ?? "0" );
            BudgetYear = double.Parse( Record[ "BudgetYear" ].ToString( ) ?? "0" );
            OutYear1 = double.Parse( Record[ "OutYear1" ].ToString( ) ?? "0" );
            OutYear2 = double.Parse( Record[ "OutYear2" ].ToString( ) ?? "0" );
            OutYear3 = double.Parse( Record[ "OutYear3" ].ToString( ) ?? "0" );
            OutYear4 = double.Parse( Record[ "OutYear4" ].ToString( ) ?? "0" );
            OutYear5 = double.Parse( Record[ "OutYear5" ].ToString( ) ?? "0" );
            OutYear6 = double.Parse( Record[ "OutYear6" ].ToString( ) ?? "0" );
            OutYear7 = double.Parse( Record[ "OutYear7" ].ToString( ) ?? "0" );
            OutYear8 = double.Parse( Record[ "OutYear8" ].ToString( ) ?? "0" );
            OutYear9 = double.Parse( Record[ "OutYear9" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverOutlay"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CarryoverOutlay( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverOutlaysId" ].ToString( ) ?? "0" );
            ReportYear = Record[ "ReportYear" ].ToString( );
            AgencyName = Record[ "AgencyName" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            Carryover = double.Parse( Record[ "Carryover" ].ToString( ) ?? "0" );
            CarryoverOutlays = double.Parse( Record[ "CarryoverOutlays" ].ToString( ) ?? "0" );
            Delta = double.Parse( Record[ "Delta" ].ToString( ) ?? "0" );
            AvailableBalance = double.Parse( Record[ "AvailableBalance" ].ToString( ) ?? "0" );
            ULO = double.Parse( Record[ "ULO" ].ToString( ) ?? "0" );
            CurrentYearAdjustment =
                double.Parse( Record[ "CurrentYearAdjustment" ].ToString( ) ?? "0" );

            BudgetYearAdjustment =
                double.Parse( Record[ "BudgetYearAdjustment" ].ToString( ) ?? "0" );

            CurrentYear = double.Parse( Record[ "CurrentYear" ].ToString( ) ?? "0" );
            BudgetYear = double.Parse( Record[ "BudgetYear" ].ToString( ) ?? "0" );
            OutYear1 = double.Parse( Record[ "OutYear1" ].ToString( ) ?? "0" );
            OutYear2 = double.Parse( Record[ "OutYear2" ].ToString( ) ?? "0" );
            OutYear3 = double.Parse( Record[ "OutYear3" ].ToString( ) ?? "0" );
            OutYear4 = double.Parse( Record[ "OutYear4" ].ToString( ) ?? "0" );
            OutYear5 = double.Parse( Record[ "OutYear5" ].ToString( ) ?? "0" );
            OutYear6 = double.Parse( Record[ "OutYear6" ].ToString( ) ?? "0" );
            OutYear7 = double.Parse( Record[ "OutYear7" ].ToString( ) ?? "0" );
            OutYear8 = double.Parse( Record[ "OutYear8" ].ToString( ) ?? "0" );
            OutYear9 = double.Parse( Record[ "OutYear9" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverOutlay"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CarryoverOutlay( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CarryoverOutlaysId" ].ToString( ) ?? "0" );
            ReportYear = dataRow[ "ReportYear" ].ToString( );
            AgencyName = dataRow[ "AgencyName" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            Carryover = double.Parse( dataRow[ "Carryover" ].ToString( ) ?? "0" );
            CarryoverOutlays = double.Parse( dataRow[ "CarryoverOutlays" ].ToString( ) ?? "0" );
            Delta = double.Parse( dataRow[ "Delta" ].ToString( ) ?? "0" );
            AvailableBalance = double.Parse( dataRow[ "AvailableBalance" ].ToString( ) ?? "0" );
            ULO = double.Parse( dataRow[ "ULO" ].ToString( ) ?? "0" );
            CurrentYearAdjustment =
                double.Parse( dataRow[ "CurrentYearAdjustment" ].ToString( ) ?? "0" );

            BudgetYearAdjustment =
                double.Parse( dataRow[ "BudgetYearAdjustment" ].ToString( ) ?? "0" );

            CurrentYear = double.Parse( dataRow[ "CurrentYear" ].ToString( ) ?? "0" );
            BudgetYear = double.Parse( dataRow[ "BudgetYear" ].ToString( ) ?? "0" );
            OutYear1 = double.Parse( dataRow[ "OutYear1" ].ToString( ) ?? "0" );
            OutYear2 = double.Parse( dataRow[ "OutYear2" ].ToString( ) ?? "0" );
            OutYear3 = double.Parse( dataRow[ "OutYear3" ].ToString( ) ?? "0" );
            OutYear4 = double.Parse( dataRow[ "OutYear4" ].ToString( ) ?? "0" );
            OutYear5 = double.Parse( dataRow[ "OutYear5" ].ToString( ) ?? "0" );
            OutYear6 = double.Parse( dataRow[ "OutYear6" ].ToString( ) ?? "0" );
            OutYear7 = double.Parse( dataRow[ "OutYear7" ].ToString( ) ?? "0" );
            OutYear8 = double.Parse( dataRow[ "OutYear8" ].ToString( ) ?? "0" );
            OutYear9 = double.Parse( dataRow[ "OutYear9" ].ToString( ) ?? "0" );
        }
    }
}
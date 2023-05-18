﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class ApportionmentData : DataUnit, IApportionment
    {
        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ApportionmentData"/>
        /// class.
        /// </summary>
        public ApportionmentData( )
        {
            Source = Source.ApportionmentData;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ApportionmentData"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public ApportionmentData( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
            ApportionmentAccountName = Record[ "ApportionmentAccountName" ].ToString( );
            AvailabilityType = Record[ "AvailabilityType" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            LineName = Record[ "LineName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ApportionmentData"/>
        /// class.
        /// </summary>
        /// <param name = "builder" > The builder. </param>
        public ApportionmentData( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
            ApportionmentAccountName = Record[ "ApportionmentAccountName" ].ToString( );
            AvailabilityType = Record[ "AvailabilityType" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            LineName = Record[ "LineName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ApportionmentData"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The data row. </param>
        public ApportionmentData( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            ApportionmentAccountCode = dataRow[ "ApportionmentAccountCode" ].ToString( );
            ApportionmentAccountName = dataRow[ "ApportionmentAccountName" ].ToString( );
            AvailabilityType = dataRow[ "AvailabilityType" ].ToString( );
            LineNumber = dataRow[ "LineNumber" ].ToString( );
            LineName = dataRow[ "LineName" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
        }

        public ApportionmentData( IApportionment omb )
        {
            ID = omb.ID;
            FiscalYear = omb.FiscalYear;
            BFY = omb.BFY;
            EFY = omb.EFY;
            BudgetAccountCode = omb.BudgetAccountCode;
            BudgetAccountName = omb.BudgetAccountName;
            TreasuryAccountCode = omb.TreasuryAccountCode;
            TreasuryAccountName = omb.TreasuryAccountName;
            ApportionmentAccountCode = omb.ApportionmentAccountCode;
            ApportionmentAccountName = omb.ApportionmentAccountName;
            AvailabilityType = omb.AvailabilityType;
            LineNumber = omb.LineNumber;
            LineName = omb.LineName;
            Amount = omb.Amount;
        }

        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the fiscal year. </summary>
        /// <value> The fiscal year. </value>
        public string FiscalYear { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        public string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        public string EFY { get; set; }

        /// <summary> Gets or sets the treasury appropriation fund symbol. </summary>
        /// <value> The treasury appropriation fund symbol. </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary> Gets or sets the name of the treasury appropriation fund symbol. </summary>
        /// <value> The name of the treasury appropriation fund symbol. </value>
        public string TreasuryAccountName { get; set; }

        /// <summary> Gets or sets the apportionment account code. </summary>
        /// <value> The apportionment account code. </value>
        public string ApportionmentAccountCode { get; set; }

        /// <summary> Gets or sets the name of the apportionment account. </summary>
        /// <value> The name of the apportionment account. </value>
        public string ApportionmentAccountName { get; set; }

        /// <summary> Gets or sets the type of the availability. </summary>
        /// <value> The type of the availability. </value>
        public string AvailabilityType { get; set; }

        /// <summary> Gets or sets the budget account code. </summary>
        /// <value> The budget account code. </value>
        public string BudgetAccountCode { get; set; }

        /// <summary> Gets or sets the name of the budget account. </summary>
        /// <value> The name of the budget account. </value>
        public string BudgetAccountName { get; set; }

        /// <summary> Gets or sets the approval date. </summary>
        /// <value> The approval date. </value>
        public DateOnly ApprovalDate { get; set; }

        /// <summary> Gets or sets the line number. </summary>
        /// <value> The line number. </value>
        public string LineNumber { get; set; }

        /// <summary> Gets or sets the name of the line. </summary>
        /// <value> The name of the line. </value>
        public string LineName { get; set; }

        /// <summary> Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        public double Amount { get; set; }
    }
}
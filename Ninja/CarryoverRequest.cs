// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
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
    public class CarryoverRequest : AdministrativeRequest
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the Analysts. </summary>
        /// <value> The Analyst </value>
        public override string Analyst { get; set; }

        /// <summary> Gets or sets the DocumentTitle. </summary>
        /// <value> The DocumentTitle. </value>
        public override string DocumentTitle { get; set; }

        /// <summary> Gets or sets the Amount. </summary>
        /// <value> The Amount. </value>
        public override double Amount { get; set; }

        /// <summary> Gets or sets the Fund. </summary>
        /// <value> The Fund </value>
        public override string FundCode { get; set; }

        /// <summary> Gets or sets the Status </summary>
        /// <value> The Status. </value>
        public override string Status { get; set; }

        /// <summary> Gets or sets the Original Request Date. </summary>
        /// <value> The Original Request Date. </value>
        public DateOnly OriginalRequestDate { get; set; }

        /// <summary> Gets or sets the Last Activity Date. </summary>
        /// <value> The Last Activity Date. </value>
        public DateOnly LastActivityDate { get; set; }

        /// <summary> Gets or sets the BFS. </summary>
        /// <value> The BFS. </value>
        public override string BudgetFormulationSystem { get; set; }

        /// <summary> Gets or sets the Comments. </summary>
        /// <value> The Comments. </value>
        public override string Comments { get; set; }

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
        /// <see cref = "CarryoverRequest"/>
        /// class.
        /// </summary>
        public CarryoverRequest( )
        {
            Source = Source.CarryoverRequests;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "CarryoverRequest"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public CarryoverRequest( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverRequestsId" ].ToString( ) ?? "0" );
            Analyst = Record[ "Analyst" ].ToString( );
            DocumentTitle = Record[ "DocumentTitle" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            FundCode = Record[ "FundCode" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            BudgetFormulationSystem = Record[ "BudgetFormulationSystem" ].ToString( );
            Comments = Record[ "Comments" ].ToString( );
            OriginalRequestDate = DateOnly.Parse( Record[ "OriginalRequestDate" ].ToString( ) ?? "" );
            LastActivityDate = DateOnly.Parse( Record[ "LastActivityDate" ].ToString( ) ?? "" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "CarryoverRequest"/>
        /// class.
        /// </summary>
        /// <param name = "builder" > The builder. </param>
        public CarryoverRequest( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverRequestsId" ].ToString( ) ?? "0" );
            Analyst = Record[ "Analyst" ].ToString( );
            DocumentTitle = Record[ "DocumentTitle" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            FundCode = Record[ "FundCode" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            BudgetFormulationSystem = Record[ "BudgetFormulationSystem" ].ToString( );
            Comments = Record[ "Comments" ].ToString( );
            OriginalRequestDate = DateOnly.Parse( Record[ "OriginalRequestDate" ].ToString( ) ?? "" );
            LastActivityDate = DateOnly.Parse( Record[ "LastActivityDate" ].ToString( ) ?? "" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "CarryoverRequest"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The data row. </param>
        public CarryoverRequest( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CarryoverRequestsId" ].ToString( ) ?? "0" );
            Analyst = dataRow[ "Analyst" ].ToString( );
            DocumentTitle = dataRow[ "DocumentTitle" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
            FundCode = dataRow[ "FundCode" ].ToString( );
            Status = dataRow[ "Status" ].ToString( );
            BudgetFormulationSystem = dataRow[ "BudgetFormulationSystem" ].ToString( );
            Comments = dataRow[ "Comments" ].ToString( );
            OriginalRequestDate = DateOnly.Parse( dataRow[ "OriginalRequestDate" ].ToString( ) ?? "" );
            LastActivityDate = DateOnly.Parse( dataRow[ "LastActivityDate" ].ToString( ) ?? "" );
        }
    }
}
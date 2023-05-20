// <copyright file = "CarryoverRequest.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.AdministrativeRequest" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class CarryoverRequest : AdministrativeRequest
    {
        /// <summary>
        /// Gets or sets the original request date.
        /// </summary>
        /// <value>
        /// The original request date.
        /// </value>
        public DateOnly OriginalRequestDate { get; set; }

        /// <summary>
        /// Gets or sets the last activity date.
        /// </summary>
        /// <value>
        /// The last activity date.
        /// </value>
        public DateOnly LastActivityDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverRequest"/> class.
        /// </summary>
        public CarryoverRequest( )
        {
            Source = Source.CarryoverRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverRequest"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
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
        /// Initializes a new instance of the <see cref="CarryoverRequest"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
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
        /// Initializes a new instance of the <see cref="CarryoverRequest"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
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
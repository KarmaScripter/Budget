// <copyright file = "CarryoverRequest.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class CarryoverRequest
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the Analysts.
        /// </summary>
        /// <value>
        /// The Analyst
        /// </value>
        public string Analyst { get; set; }
        
        /// <summary>
        /// Gets or sets the DocumentTitle.
        /// </summary>
        /// <value>
        /// The DocumentTitle.
        /// </value>
        public string DocumentTitle { get; set; }
        
        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        /// <value>
        /// The Amount.
        /// </value>
        public double Amount { get; set; }
        
        /// <summary>
        /// Gets or sets the Fund.
        /// </summary>
        /// <value>
        /// The Fund
        /// </value>
        public string Fund { get; set; }
        
        /// <summary>
        /// Gets or sets the Status
        /// </summary>
        /// <value>
        /// The Status.
        /// </value>
        public string Status { get; set; }
        
        /// <summary>
        /// Gets or sets the Original Request Date.
        /// </summary>
        /// <value>
        /// The Original Request Date.
        /// </value>
        public DateOnly OriginalRequestDate { get; set; }
        
        /// <summary>
        /// Gets or sets the Last Activity Date.
        /// </summary>
        /// <value>
        /// The Last Activity Date.
        /// </value>
        public DateOnly LastActivityDate { get; set; }
        
        /// <summary>
        /// Gets or sets the BFS.
        /// </summary>
        /// <value>
        /// The BFS.
        /// </value>
        public string BudgetFormulationSystem { get; set; }
        
        /// <summary>
        /// Gets or sets the Comments.
        /// </summary>
        /// <value>
        /// The Comments.
        /// </value>
        public string Comments { get; set; }
        
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
            ID = int.Parse( Record[ "CarryoverRequestsId" ].ToString(  ) ?? "0" );
            Analyst = Record[ "Analyst" ].ToString(  );
            DocumentTitle = Record[ "DocumentTitle" ].ToString(  );
            Amount = double.Parse( Record[ "Amount" ].ToString(  ) ?? "0" );
            Fund = Record[ "Fund" ].ToString(  );
            Status = Record[ "Status" ].ToString(  );
            BudgetFormulationSystem = Record[ "BudgetFormulationSystem" ].ToString(  );
            Comments = Record[ "Comments" ].ToString(  );
            OriginalRequestDate =
                DateOnly.Parse( Record[ "OriginalRequestDate" ].ToString(  ) ?? "" );
            LastActivityDate =
                DateOnly.Parse( Record[ "LastActivityDate" ].ToString(  ) ?? "" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverRequest"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CarryoverRequest( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverRequestsId" ].ToString(  ) ?? "0" );
            Analyst = Record[ "Analyst" ].ToString(  );
            DocumentTitle = Record[ "DocumentTitle" ].ToString(  );
            Amount = double.Parse( Record[ "Amount" ].ToString(  ) ?? "0" );
            Fund = Record[ "Fund" ].ToString(  );
            Status = Record[ "Status" ].ToString(  );
            BudgetFormulationSystem = Record[ "BudgetFormulationSystem" ].ToString(  );
            Comments = Record[ "Comments" ].ToString(  );
            OriginalRequestDate =
                DateOnly.Parse( Record[ "OriginalRequestDate" ].ToString(  ) ?? "" );
            LastActivityDate =
                DateOnly.Parse( Record[ "LastActivityDate" ].ToString(  ) ?? "" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverRequest"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CarryoverRequest( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CarryoverRequestsId" ].ToString(  ) ?? "0" );
            Analyst = dataRow[ "Analyst" ].ToString(  );
            DocumentTitle = dataRow[ "DocumentTitle" ].ToString(  );
            Amount = double.Parse(dataRow[ "Amount" ].ToString(  ) ?? "0" );
            Fund = dataRow[ "Fund" ].ToString(  );
            Status = dataRow[ "Status" ].ToString(  );
            BudgetFormulationSystem = dataRow[ "BudgetFormulationSystem" ].ToString(  );
            Comments = dataRow[ "Comments" ].ToString(  );
            OriginalRequestDate =
                DateOnly.Parse( dataRow[ "OriginalRequestDate" ].ToString(  ) ?? "" );
            LastActivityDate =
                DateOnly.Parse( dataRow[ "LastActivityDate" ].ToString(  ) ?? "" );
        }
    }
}

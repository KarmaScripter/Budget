// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class AdministrativeRequest
    {
        public int ID { get; set; }
        
        public string Analyst { get; set; }
        
        public string RpioCode { get; set; }
        
        public string DocumentTitle { get; set; }

        public double Amount { get; set; }
        
        public string FundCode { get; set; }
        
        public string BFY { get; set; }
        
        public string Status { get; set; }

        public DateOnly OriginalActionDate { get; set; }
        
        public DateOnly LastActionDate { get; set; }

        public double Duration { get; set; }
        
        public string BudgetFormulationSystem  { get; set; }
        
        public string Comments { get; set; }
        
        public string RequestType { get; set; }
        
        public string TypeCode { get; set; }
        
        public string Decision { get; set; }

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

        public AdministrativeRequest( )
        {
            Source = Source.AdministrativeRequests;
        }

        public AdministrativeRequest( IQuery query ) 
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            Data = Record.ToDictionary(  );
            ID = int.Parse( Record[ "AdministrativeRequestsId" ].ToString(  ) ?? "0" );
            Analyst = Record[ "Analyst" ].ToString(  );
            RpioCode = Record[ "RpioCode" ].ToString(  );
            DocumentTitle = Record[ "DocumentTitle" ].ToString(  );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0"  );
            FundCode = Record[ "FundCode" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            Status = Record[ "Status" ].ToString( );
            Duration = double.Parse( Record[ "Duration" ].ToString(  ) ?? "0" );
            BudgetFormulationSystem = Record[ "BudgetFormulationSystem" ].ToString(  );
            Comments = Record[ "Comments" ].ToString(  );
            RequestType = Record[ "RequestType" ].ToString(  );
            TypeCode = Record[ "TypeCode" ].ToString(  );
            Decision = Record[ "Decision" ].ToString(  );
            OriginalActionDate 
                = DateOnly.Parse( Record[ "OriginalActionDate" ].ToString(  ) ?? string.Empty );
            LastActionDate 
                = DateOnly.Parse( Record[ "LastActionDate" ].ToString(  ) ?? string.Empty );
        }

        public AdministrativeRequest( IDataModel builder ) 
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary(  );
            ID = int.Parse( Record[ "AdministrativeRequestsId" ].ToString(  ) ?? "0" );
            Analyst = Record[ "Analyst" ].ToString(  );
            RpioCode = Record[ "RpioCode" ].ToString(  );
            DocumentTitle = Record[ "DocumentTitle" ].ToString(  );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0"  );
            FundCode = Record[ "FundCode" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            Status = Record[ "Status" ].ToString( );
            Duration = double.Parse( Record[ "Duration" ].ToString(  ) ?? "0" );
            BudgetFormulationSystem = Record[ "BudgetFormulationSystem" ].ToString(  );
            Comments = Record[ "Comments" ].ToString(  );
            RequestType = Record[ "RequestType" ].ToString(  );
            TypeCode = Record[ "TypeCode" ].ToString(  );
            Decision = Record[ "Decision" ].ToString(  );
            OriginalActionDate 
                = DateOnly.Parse( Record[ "OriginalActionDate" ].ToString(  ) ?? string.Empty );
            LastActionDate 
                = DateOnly.Parse( Record[ "LastActionDate" ].ToString(  ) ?? string.Empty );
        }

        public AdministrativeRequest( DataRow dataRow ) 
            : this( )
        {
            Record = dataRow;
            Data = Record.ToDictionary(  );
            ID = int.Parse( Record[ "AdministrativeRequestsId" ].ToString(  ) ?? "0" );
            Analyst = Record[ "Analyst" ].ToString(  );
            RpioCode = Record[ "RpioCode" ].ToString(  );
            DocumentTitle = Record[ "DocumentTitle" ].ToString(  );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0"  );
            FundCode = Record[ "FundCode" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            Status = Record[ "Status" ].ToString( );
            Duration = double.Parse( Record[ "Duration" ].ToString(  ) ?? "0" );
            BudgetFormulationSystem = Record[ "BudgetFormulationSystem" ].ToString(  );
            Comments = Record[ "Comments" ].ToString(  );
            RequestType = Record[ "RequestType" ].ToString(  );
            TypeCode = Record[ "TypeCode" ].ToString(  );
            Decision = Record[ "Decision" ].ToString(  );
            OriginalActionDate 
                = DateOnly.Parse( Record[ "OriginalActionDate" ].ToString(  ) ?? string.Empty );
            LastActionDate 
                = DateOnly.Parse( Record[ "LastActionDate" ].ToString(  ) ?? string.Empty );
        }
    }
}

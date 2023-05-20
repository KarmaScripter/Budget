// <copyright file = "CongressionalReprogramming.cs" company = "Terry D.Eppler">
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
    /// <seealso cref="BudgetExecution.Reprogramming" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class CongressionalReprogramming : Reprogramming
    {
        /// <summary>
        /// Gets or sets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public string ActivityCode { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the extended description.
        /// </summary>
        /// <value>
        /// The extended description.
        /// </value>
        public string ExtendedDescription { get; set; }

        /// <summary>
        /// Gets or sets the cycle.
        /// </summary>
        /// <value>
        /// The cycle.
        /// </value>
        public string Cycle { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalReprogramming"/> class.
        /// </summary>
        public CongressionalReprogramming( )
        {
            Source = Source.CongressionalReprogrammings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalReprogramming"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CongressionalReprogramming( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CongressionalReprogrammingId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            FromTo = Record[ "FromTo" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = Record[ "ResourceType" ].ToString( );
            ProcessedDate = DateOnly.Parse( Record[ "ProcessedDate" ].ToString( ) );
            Quarter = Record[ "Quarter" ].ToString( );
            ReprogrammingNumber = Record[ "ReprogrammingNumber" ].ToString( );
            ControlNumber = Record[ "ControlNumber" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            Subline = Record[ "Subline" ].ToString( );
            Purpose = Record[ "Purpose" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalReprogramming"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CongressionalReprogramming( IDataModel builder )
            : base( builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CongressionalReprogrammingId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            FromTo = Record[ "FromTo" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = Record[ "ResourceType" ].ToString( );
            ProcessedDate = DateOnly.Parse( Record[ "ProcessedDate" ].ToString( ) );
            Quarter = Record[ "Quarter" ].ToString( );
            ReprogrammingNumber = Record[ "ReprogrammingNumber" ].ToString( );
            ControlNumber = Record[ "ControlNumber" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            Subline = Record[ "Subline" ].ToString( );
            Purpose = Record[ "Purpose" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalReprogramming"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CongressionalReprogramming( DataRow dataRow )
            : base( dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CongressionalReprogrammingId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            BudgetLevel = dataRow[ "BudgetLevel" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AhCode = dataRow[ "AhCode" ].ToString( );
            AhName = dataRow[ "AhName" ].ToString( );
            OrgCode = dataRow[ "OrgCode" ].ToString( );
            OrgName = dataRow[ "OrgName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            FromTo = dataRow[ "FromTo" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = dataRow[ "ResourceType" ].ToString( );
            ProcessedDate = DateOnly.Parse( dataRow[ "ProcessedDate" ].ToString( ) );
            Quarter = dataRow[ "Quarter" ].ToString( );
            ReprogrammingNumber = dataRow[ "ReprogrammingNumber" ].ToString( );
            ControlNumber = dataRow[ "ControlNumber" ].ToString( );
            Line = dataRow[ "Line" ].ToString( );
            Subline = dataRow[ "Subline" ].ToString( );
            Purpose = dataRow[ "Purpose" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString( );
        }
    }
}
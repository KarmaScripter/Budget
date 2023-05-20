// <copyright file = "CapitalPlanningInvestmentCode.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class CapitalPlanningInvestmentCode : DataUnit
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapitalPlanningInvestmentCode"/> class.
        /// </summary>
        public CapitalPlanningInvestmentCode( )
        {
            Source = Source.CapitalPlanningInvestmentCodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapitalPlanningInvestmentCode"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CapitalPlanningInvestmentCode( IQuery query )
            : this( )
        {
            Source = Source.CapitalPlanningInvestmentCodes;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CapitalPlanningInvestmentCodesId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Type = Record[ "Type" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapitalPlanningInvestmentCode"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CapitalPlanningInvestmentCode( IDataModel builder )
        {
            Source = Source.CapitalPlanningInvestmentCodes;
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CapitalPlanningInvestmentCodesId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Type = Record[ "Type" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapitalPlanningInvestmentCode"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CapitalPlanningInvestmentCode( DataRow dataRow )
        {
            Source = Source.CapitalPlanningInvestmentCodes;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CapitalPlanningInvestmentCodesId" ].ToString( ) ?? "0" );
            Code = dataRow[ "Code" ].ToString( );
            Name = dataRow[ "Name" ].ToString( );
            Type = dataRow[ "Type" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapitalPlanningInvestmentCode"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        public CapitalPlanningInvestmentCode( CapitalPlanningInvestmentCode code )
        {
            Source = Source.CapitalPlanningInvestmentCodes;
            ID = code.ID;
            Code = code.Code;
            Name = code.Name;
            Type = code.Type;
        }
    }
}
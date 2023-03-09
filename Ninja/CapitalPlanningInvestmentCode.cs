// <copyright file = "CapitalPlanningInvestmentCode.cs" company = "Terry D. Eppler">
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
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class CapitalPlanningInvestmentCode : DataUnit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public override string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public override Provider Provider { get; set; }

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
            : this( )
        {
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
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CapitalPlanningInvestmentCodesId" ].ToString( ) ?? "0" );
            Code = dataRow[ "Code" ].ToString( );
            Name = dataRow[ "Name" ].ToString( );
            Type = dataRow[ "Type" ].ToString( );
        }
    }
}

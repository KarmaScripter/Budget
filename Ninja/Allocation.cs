// <copyright file = "Allocation.cs" company = "Terry D. Eppler">
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
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Allocation : DataUnit
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        public string BFY { get; set; }

        public string EFY  { get; set; }

        public string FundCode { get; set; }
        
        public string FundName { get; set; }
        
        public string RpioCode { get; set; }
        
        public string RpioName { get; set; }
        
        public string AhCode { get; set; }
        
        public string AhName { get; set; }
        
        public string AppropriationCode { get; set; }
        
        public string AppropriationName { get; set; }

        public string OrgCode { get; set; }
        
        public string OrgName { get; set; }
        
        public string AccountCode { get; set; }
        
        public string ProgramProjectCode { get; set; }
        
        public string ProgramProjectName { get; set; }
        
        public string RpioActivityCode { get; set; }
        
        public string RpioActivityName { get; set; }
        
        public string BocCode { get; set; }
        
        public string BocName { get; set; }
        
        public double ULO { get; set; }
        
        public double Obligations { get; set; }
        
        public double Balance { get; set; }
        
        public string ProgramAreaCode { get; set; }
        
        public string ProgramAreaName { get; set; }

        public string NpmCode { get; set; }

        public string GoalCode { get; set; }
        
        public string GoalName { get; set; }
        
        public string ObjectiveCode { get; set; }
        
        public string ObjectiveName  { get; set; }

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
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation"/> class.
        /// </summary>
        public Allocation( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Allocation( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public Allocation( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Allocation( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

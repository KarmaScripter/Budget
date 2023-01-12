// <copyright file = "Actuals.cs" company = "Terry D. Eppler">
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
    public class Actual: DataUnit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BFY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EFY  { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FundCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FundName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RpioCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RpioName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string AhCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string AhName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string AppropriationCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string AppropriationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OrgCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OrgName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string AccountCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ProgramProjectCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ProgramProjectName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RpioActivityCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RpioActivityName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BocCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BocName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public double ULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public double Obligations { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public double Balance { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ProgramAreaCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ProgramAreaName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GoalCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GoalName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ObjectiveCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ObjectiveName  { get; set; }
        
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
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Actual"/> class.
        /// </summary>
        public Actual( )
        {
            Source = Source.Actuals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Actual"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Actual( IQuery query ) 
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Actual"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public Actual( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Actual"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Actual( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

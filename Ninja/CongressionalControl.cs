﻿// <copyright file = "CongressionalControl.cs" company = "Terry D. Eppler">
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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class CongressionalControl
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public string ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public string ProgramAreaName { get; set; }

        /// <summary>
        /// Gets or sets the program project code.
        /// </summary>
        /// <value>
        /// The program project code.
        /// </value>
        public string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        public string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the sub project code.
        /// </summary>
        /// <value>
        /// The sub project code.
        /// </value>
        public string SubProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the sub project.
        /// </summary>
        /// <value>
        /// The name of the sub project.
        /// </value>
        public string SubProjectName { get; set; }

        /// <summary>
        /// Gets or sets the reprogramming restriction.
        /// </summary>
        /// <value>
        /// The reprogramming restriction.
        /// </value>
        public string ReprogrammingRestriction { get; set; }

        /// <summary>
        /// Gets or sets the increase restriction.
        /// </summary>
        /// <value>
        /// The increase restriction.
        /// </value>
        public string IncreaseRestriction { get; set; }

        /// <summary>
        /// Gets or sets the decrease restriction.
        /// </summary>
        /// <value>
        /// The decrease restriction.
        /// </value>
        public string DecreaseRestriction { get; set; }

        /// <summary>
        /// Gets or sets the memo requirement.
        /// </summary>
        /// <value>
        /// The memo requirement.
        /// </value>
        public string MemoRequirement { get; set; }
        
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
        /// Initializes a new instance of the <see cref="CongressionalControl"/> class.
        /// </summary>
        public CongressionalControl( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalControl"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CongressionalControl( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalControl"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CongressionalControl( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalControl"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CongressionalControl( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

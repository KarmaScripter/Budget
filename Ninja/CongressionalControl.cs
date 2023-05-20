// <copyright file = "CongressionalControl.cs" company = "Terry D.Eppler">
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
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class CongressionalControl : DataUnit 
    {
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
        /// Initializes a new instance of the <see cref="CongressionalControl"/> class.
        /// </summary>
        public CongressionalControl( )
        {
            Source = Source.CongressionalControls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalControl"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CongressionalControl( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CongressionalControlsId" ].ToString( ) ?? "0" );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            SubProjectCode = Record[ "SubProjectCode" ].ToString( );
            SubProjectName = Record[ "SubProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            ReprogrammingRestriction = Record[ "ReprogrammingRestriction" ].ToString( );
            IncreaseRestriction = Record[ "IncreaseRestriction" ].ToString( );
            DecreaseRestriction = Record[ "DecreaseRestriction" ].ToString( );
            MemoRequirement = Record[ "MemoRequirement" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalControl"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CongressionalControl( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CongressionalControlsId" ].ToString( ) ?? "0" );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            SubProjectCode = Record[ "SubProjectCode" ].ToString( );
            SubProjectName = Record[ "SubProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            ReprogrammingRestriction = Record[ "ReprogrammingRestriction" ].ToString( );
            IncreaseRestriction = Record[ "IncreaseRestriction" ].ToString( );
            DecreaseRestriction = Record[ "DecreaseRestriction" ].ToString( );
            MemoRequirement = Record[ "MemoRequirement" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalControl"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CongressionalControl( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CongressionalControlsId" ].ToString( ) ?? "0" );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            SubProjectCode = dataRow[ "SubProjectCode" ].ToString( );
            SubProjectName = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            ReprogrammingRestriction = dataRow[ "ReprogrammingRestriction" ].ToString( );
            IncreaseRestriction = dataRow[ "IncreaseRestriction" ].ToString( );
            DecreaseRestriction = dataRow[ "DecreaseRestriction" ].ToString( );
            MemoRequirement = dataRow[ "MemoRequirement" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CongressionalControl"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        public CongressionalControl( CongressionalControl control )
        {
            ID = control.ID;
            FundCode = control.FundCode;
            FundName = control.FundName;
            ProgramProjectCode = control.ProgramProjectCode;
            ProgramProjectName = control.ProgramProjectName;
            SubProjectCode = control.SubProjectCode;
            SubProjectName = control.SubProjectName;
            ProgramAreaCode = control.ProgramAreaCode;
            ProgramAreaName = control.ProgramAreaName;
            ReprogrammingRestriction = control.ReprogrammingRestriction;
            IncreaseRestriction = control.IncreaseRestriction;
            DecreaseRestriction = control.DecreaseRestriction;
            MemoRequirement = control.MemoRequirement;
        }
    }
}
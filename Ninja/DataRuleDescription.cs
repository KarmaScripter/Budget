// <copyright file = "DataRuleDescription.cs" company = "Terry D.Eppler">
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
    /// <seealso cref="BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class DataRuleDescription : DataUnit
    {
        /// <summary>
        /// Gets or sets the schedule.
        /// </summary>
        /// <value>
        /// The schedule.
        /// </value>
        public string Schedule { get; set; }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        /// <value>
        /// The line number.
        /// </value>
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the rule number.
        /// </summary>
        /// <value>
        /// The rule number.
        /// </value>
        public string RuleNumber { get; set; }

        /// <summary>
        /// Gets or sets the rule description.
        /// </summary>
        /// <value>
        /// The rule description.
        /// </value>
        public string RuleDescription { get; set; }

        /// <summary>
        /// Gets or sets the schedule order.
        /// </summary>
        /// <value>
        /// The schedule order.
        /// </value>
        public string ScheduleOrder { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRuleDescription"/> class.
        /// </summary>
        public DataRuleDescription( )
        {
            Source = Source.DataRuleDescriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRuleDescription"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public DataRuleDescription( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            Schedule = Record[ "Schedule" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            RuleNumber = Record[ "RuleNumber" ].ToString( );
            ScheduleOrder = Record[ "ScheduleOrder" ].ToString( );
            RuleDescription = Record[ "RuleDescription" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRuleDescription"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public DataRuleDescription( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            Schedule = Record[ "Schedule" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            RuleNumber = Record[ "RuleNumber" ].ToString( );
            ScheduleOrder = Record[ "ScheduleOrder" ].ToString( );
            RuleDescription = Record[ "RuleDescription" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRuleDescription"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public DataRuleDescription( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            Schedule = dataRow[ "Schedule" ].ToString( );
            LineNumber = dataRow[ "LineNumber" ].ToString( );
            RuleNumber = dataRow[ "RuleNumber" ].ToString( );
            ScheduleOrder = dataRow[ "ScheduleOrder" ].ToString( );
            RuleDescription = dataRow[ "RuleDescription" ].ToString( );
        }
    }
}
// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using BudgetExecution;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public class DataRuleDescription : DataUnit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

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
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public override IDictionary<string, object> Map { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRuleDescription"/> class.
        /// </summary>
        public DataRuleDescription( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRuleDescription"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public DataRuleDescription( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Map = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRuleDescription"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public DataRuleDescription( IDataModel builder )
        {
            Record = builder.Record;
            Map = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRuleDescription"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public DataRuleDescription( DataRow dataRow )
        {
            Record = dataRow;
            Map = dataRow.ToDictionary( );
        }
    }
}


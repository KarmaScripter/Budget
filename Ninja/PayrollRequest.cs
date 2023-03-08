// <copyright file = "PayrollRequest.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class PayrollRequest : AdministrativeRequest
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the Analysts.
        /// </summary>
        /// <value>
        /// The Analyst
        /// </value>
        public override string Analyst { get; set; }
        
        /// <summary>
        /// Gets or sets the DocumentTitle.
        /// </summary>
        /// <value>
        /// The DocumentTitle.
        /// </value>
        public override string DocumentTitle { get; set; }
        
        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        /// <value>
        /// The Amount.
        /// </value>
        public override double Amount { get; set; }
        
        /// <summary>
        /// Gets or sets the Fund.
        /// </summary>
        /// <value>
        /// The Fund
        /// </value>
        public override string FundCode { get; set; }
        
        /// <summary>
        /// Gets or sets the Status
        /// </summary>
        /// <value>
        /// The Status.
        /// </value>
        public override string Status { get; set; }
        
        /// <summary>
        /// Gets or sets the Original Request Date.
        /// </summary>
        /// <value>
        /// The Original Request Date.
        /// </value>
        public virtual DateOnly OriginalRequestDate { get; set; }
        
        /// <summary>
        /// Gets or sets the Last Activity Date.
        /// </summary>
        /// <value>
        /// The Last Activity Date.
        /// </value>
        public virtual DateOnly LastActivityDate { get; set; }
        
        /// <summary>
        /// Gets or sets the BFS.
        /// </summary>
        /// <value>
        /// The BFS.
        /// </value>
        public override string BudgetFormulationSystem { get; set; }
        
        /// <summary>
        /// Gets or sets the Comments.
        /// </summary>
        /// <value>
        /// The Comments.
        /// </value>
        public override string Comments { get; set; }
        
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
    }
}

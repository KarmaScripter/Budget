// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class AdministrativeRequest : DataUnit
    {
        /// <summary>
        /// Gets or sets the analyst.
        /// </summary>
        /// <value>
        /// The analyst.
        /// </value>
        public virtual string Analyst { get; set; }

        /// <summary>
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public virtual string RpioCode { get; set; }

        /// <summary>
        /// Gets or sets the document title.
        /// </summary>
        /// <value>
        /// The document title.
        /// </value>
        public virtual string DocumentTitle { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public virtual double Amount { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public virtual string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public virtual string BFY { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public virtual string Status { get; set; }

        /// <summary>
        /// Gets or sets the original action date.
        /// </summary>
        /// <value>
        /// The original action date.
        /// </value>
        public virtual DateOnly OriginalActionDate { get; set; }

        /// <summary>
        /// Gets or sets the last action date.
        /// </summary>
        /// <value>
        /// The last action date.
        /// </value>
        public virtual DateOnly LastActionDate { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public virtual double Duration { get; set; }

        /// <summary>
        /// Gets or sets the budget formulation system.
        /// </summary>
        /// <value>
        /// The budget formulation system.
        /// </value>
        public virtual string BudgetFormulationSystem { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        public virtual string Comments { get; set; }

        /// <summary>
        /// Gets or sets the type of the request.
        /// </summary>
        /// <value>
        /// The type of the request.
        /// </value>
        public virtual string RequestType { get; set; }

        /// <summary>
        /// Gets or sets the type code.
        /// </summary>
        /// <value>
        /// The type code.
        /// </value>
        public virtual string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets the decision.
        /// </summary>
        /// <value>
        /// The decision.
        /// </value>
        public virtual string Decision { get; set; }
    }
}
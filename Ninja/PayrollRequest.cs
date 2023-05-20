// <copyright file = "PayrollRequest.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.AdministrativeRequest" />
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class PayrollRequest : AdministrativeRequest
    {
        /// <summary>
        /// Gets or sets the original request date.
        /// </summary>
        /// <value>
        /// The original request date.
        /// </value>
        public virtual DateOnly OriginalRequestDate { get; set; }

        /// <summary>
        /// Gets or sets the last activity date.
        /// </summary>
        /// <value>
        /// The last activity date.
        /// </value>
        public virtual DateOnly LastActivityDate { get; set; }
    }
}
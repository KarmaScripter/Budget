﻿// <copyright file = "Heading.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.Grid" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Heading : Grid
    {
        /// <summary>
        /// Gets or sets the span.
        /// </summary>
        /// <value>
        /// The span.
        /// </value>
        public int Span { get; set; }

        /// <summary>
        /// Gets or sets the anchor.
        /// </summary>
        /// <value>
        /// The anchor.
        /// </value>
        public (int Row, int Column) Anchor { get; set; }

        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        /// <value>
        /// The caption.
        /// </value>
        public IDictionary<int, string> Caption { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heading"/> class.
        /// </summary>
        public Heading( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heading"/> class.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public Heading( IGrid grid )
        {
            Worksheet = grid.Worksheet;
            Range = grid.Range;
            Address = grid.Address;
            From = ( Range.Start.Row, Range.Start.Column );
            To = ( Range.Start.Row, Range.End.Column );
            Anchor = ( From.Row, From.Column );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heading"/> class.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="caption">The caption.</param>
        public Heading( IGrid grid, IDictionary<int, string> caption )
            : this( grid )
        {
            Caption = caption;
            Span = Range.Columns;
        }
    }
}
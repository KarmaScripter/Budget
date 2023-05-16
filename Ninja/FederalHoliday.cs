// <copyright file = "FederalHoliday.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class FederalHoliday : IFederalHoliday
    {
        /// <summary>
        /// Gets or sets the columbus.
        /// </summary>
        /// <value>
        /// The columbus.
        /// </value>
        public virtual DateOnly ColumbusDay { get; set; }

        /// <summary>
        /// Gets or sets the veterans.
        /// </summary>
        /// <value>
        /// The veterans.
        /// </value>
        public virtual DateOnly VeteransDay { get; set; }

        /// <summary>
        /// Gets or sets the thanksgiving.
        /// </summary>
        /// <value>
        /// The thanksgiving.
        /// </value>
        public virtual DateOnly ThanksgivingDay { get; set; }

        /// <summary>
        /// Gets or sets the christmas.
        /// </summary>
        /// <value>
        /// The christmas.
        /// </value>
        public virtual DateOnly ChristmasDay { get; set; }

        /// <summary>
        /// Creates new years.
        /// </summary>
        /// <value>
        /// The new years.
        /// </value>
        public virtual DateOnly NewYearsDay { get; set; }


        /// <summary>
        /// Gets or sets the martin luther king.
        /// </summary>
        /// <value>
        /// The martin luther king.
        /// </value>
        public virtual DateOnly MartinLutherKingsDay { get; set; }

        /// <summary>
        /// Gets or sets the washingtons.
        /// </summary>
        /// <value>
        /// The washingtons.
        /// </value>
        public virtual DateOnly WashingtonsDay { get; set; }

        /// <summary>
        /// Gets or sets the memorial.
        /// </summary>
        /// <value>
        /// The memorial.
        /// </value>
        public virtual DateOnly MemorialDay { get; set; }

        /// <summary>
        /// Gets or sets the juneteenth.
        /// </summary>
        /// <value>
        /// The juneteenth.
        /// </value>
        public virtual DateOnly JuneteenthDay { get; set; }

        /// <summary>
        /// Gets or sets the independence.
        /// </summary>
        /// <value>
        /// The independence.
        /// </value>
        public virtual DateOnly IndependenceDay { get; set; }

        /// <summary>
        /// Gets or sets the labor.
        /// </summary>
        /// <value>
        /// The labor.
        /// </value>
        public virtual DateOnly LaborDay { get; set; }
        
        /// <summary>
        /// Get ErrorDialog Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}

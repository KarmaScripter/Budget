// <copyright file = "FederalHoliday.cs" company = "Terry D.Eppler">
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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class FederalHoliday  
    {
        /// <summary>
        /// Columbus Day, the second Monday in October.
        /// </summary>
        /// <value>
        /// Columbus Day, the second Monday in October.
        /// </value>
        public virtual DateOnly ColumbusDay { get; set; }

        /// <summary>
        /// Veterans Day, November 11.
        /// </summary>
        /// <value>
        /// Veterans Day, November 11.
        /// </value>
        public virtual DateOnly VeteransDay { get; set; }

        /// <summary>
        /// Thanksgiving Day, the fourth Thursday in November.
        /// </summary>
        /// <value>
        /// Thanksgiving Day, the fourth Thursday in November.
        /// </value>
        public virtual DateOnly ThanksgivingDay { get; set; }

        /// <summary>
        /// Christmas Day, December 25.
        /// </summary>
        /// <value>
        /// Christmas Day, December 25.
        /// </value>
        public virtual DateOnly ChristmasDay { get; set; }

        /// <summary>
        /// New Year’s Day, January 1.
        /// </summary>
        /// <value>
        /// New Year’s Day, January 1.
        /// </value>
        public virtual DateOnly NewYearsDay { get; set; }

        /// <summary>
        /// Birthday of Martin Luther King, Jr., the third Monday in January.
        /// </summary>
        /// <value>
        /// Birthday of Martin Luther King, Jr., the third Monday in January.
        /// </value>
        public virtual DateOnly MartinLutherKingDay { get; set; }

        /// <summary>
        /// Washington’s Birthday, the third Monday in February.
        /// </summary>
        /// <value>
        /// Washington’s Birthday, the third Monday in February.
        /// </value>
        public virtual DateOnly PresidentsDay { get; set; }

        /// <summary>
        /// Memorial Day, the last Monday in May.
        /// </summary>
        /// <value>
        /// Memorial Day, the last Monday in May.
        /// </value>
        public virtual DateOnly MemorialDay { get; set; }

        /// <summary>
        /// Juneteenth National Independence Day, June 19.
        /// </summary>
        /// <value>
        /// Juneteenth National Independence Day, June 19.
        /// </value>
        public virtual DateOnly JuneteenthDay { get; set; }

        /// <summary>
        /// Independence Day, July 4.
        /// </summary>
        /// <value>
        /// Independence Day, July 4.
        /// </value>
        public virtual DateOnly IndependenceDay { get; set; }

        /// <summary>
        /// Labor Day, the first Monday in September.
        /// </summary>
        /// <value>
        /// Labor Day, the first Monday in September.
        /// </value>
        public virtual DateOnly LaborDay { get; set; }

        /// <summary>
        /// Get ErrorDialog Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        static protected private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
// <copyright file = "IFederalHoliday.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public interface IFederalHoliday
    {
        /// <summary>
        /// Creates new years.
        /// </summary>
        /// <value>
        /// The new years.
        /// </value>
        public DateOnly NewYearsDay { get; set; }

        /// <summary>
        /// Gets or sets the martin luther king.
        /// </summary>
        /// <value>
        /// The martin luther king.
        /// </value>
        public DateOnly MartinLutherKingsDay { get; set; }

        /// <summary>
        /// Gets or sets the presidents.
        /// </summary>
        /// <value>
        /// The presidents.
        /// </value>
        public DateOnly WashingtonsDay { get; set; }

        /// <summary>
        /// Gets or sets the memorial.
        /// </summary>
        /// <value>
        /// The memorial.
        /// </value>
        public DateOnly MemorialDay { get; set; }

        /// <summary>
        /// Gets or sets the veterans.
        /// </summary>
        /// <value>
        /// The veterans.
        /// </value>
        public DateOnly VeteransDay { get; set; }

        /// <summary>
        /// Gets or sets the labor.
        /// </summary>
        /// <value>
        /// The labor.
        /// </value>
        public DateOnly LaborDay { get; set; }

        /// <summary>
        /// Gets or sets the independence.
        /// </summary>
        /// <value>
        /// The independence.
        /// </value>
        public DateOnly IndependenceDay { get; set; }

        /// <summary>
        /// Gets or sets the Juneteenth day.
        /// </summary>
        /// <value>
        /// The Juneteenth day.
        /// </value>
        public DateOnly JuneteenthDay { get; set; }

        /// <summary>
        /// Gets or sets the columbus.
        /// </summary>
        /// <value>
        /// The columbus.
        /// </value>
        public DateOnly ColumbusDay { get; set; }

        /// <summary>
        /// Gets or sets the thanksgiving.
        /// </summary>
        /// <value>
        /// The thanksgiving.
        /// </value>
        public DateOnly ThanksgivingDay { get; set; }

        /// <summary>
        /// Gets or sets the christmas.
        /// </summary>
        /// <value>
        /// The christmas.
        /// </value>
        public DateOnly ChristmasDay { get; set; }
    }
}

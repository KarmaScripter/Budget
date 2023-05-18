// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    /// <summary> </summary>
    public interface IFederalHoliday
    {
        /// <summary> New Year’s Day, January 1. </summary>
        /// <value> New Year’s Day, January 1. </value>
        public DateOnly NewYearsDay { get; set; }

        /// <summary> Birthday of Martin Luther King, Jr., the third Monday in January. </summary>
        /// <value> Birthday of Martin Luther King, Jr., the third Monday in January. </value>
        public DateOnly MartinLutherKingDay { get; set; }

        /// <summary> Washington’s Birthday, the third Monday in February. </summary>
        /// <value> Washington’s Birthday, the third Monday in February. </value>
        public DateOnly PresidentsDay { get; set; }

        /// <summary> Memorial Day, the last Monday in May. </summary>
        /// <value> Memorial Day, the last Monday in May. </value>
        public DateOnly MemorialDay { get; set; }

        /// <summary> Veterans Day, November 11. </summary>
        /// <value> Veterans Day, November 11. </value>
        public DateOnly VeteransDay { get; set; }

        /// <summary> Labor Day, the first Monday in September. </summary>
        /// <value> TLabor Day, the first Monday in September. </value>
        public DateOnly LaborDay { get; set; }

        /// <summary> Independence Day, July 4. </summary>
        /// <value> Independence Day, July 4. </value>
        public DateOnly IndependenceDay { get; set; }

        /// <summary> Juneteenth National Independence Day, June 19. </summary>
        /// <value> Juneteenth National Independence Day, June 19. </value>
        public DateOnly JuneteenthDay { get; set; }

        /// <summary> Columbus Day, the second Monday in October. </summary>
        /// <value> Columbus Day, the second Monday in October. </value>
        public DateOnly ColumbusDay { get; set; }

        /// <summary> Thanksgiving Day, the fourth Thursday in November. </summary>
        /// <value> Thanksgiving Day, the fourth Thursday in November. </value>
        public DateOnly ThanksgivingDay { get; set; }

        /// <summary> Christmas Day, December 25. </summary>
        /// <value> Christmas Day, December 25. </value>
        public DateOnly ChristmasDay { get; set; }
    }
}
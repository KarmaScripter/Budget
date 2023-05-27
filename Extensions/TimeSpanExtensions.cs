// <copyright file = "TimeSpanExtensions.cs" company = "Terry D.Eppler">
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
    [SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// The average days in a year
        /// </summary>
        public const double AvgDaysInAYear = 365.2425d;

        /// <summary>
        /// The average days in a month
        /// </summary>
        public const double AvgDaysInAMonth = 30.436875d;

        /// <summary>
        /// Gets the years.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static int GetYears( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays / AvgDaysInAYear );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1;
            }
        }

        /// <summary>
        /// Gets the total years.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static double GetTotalYears( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.TotalDays / AvgDaysInAYear;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary>
        /// Gets the months.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static int GetMonths( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays % AvgDaysInAYear / AvgDaysInAMonth );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1;
            }
        }

        /// <summary>
        /// Gets the total months.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static double GetTotalMonths( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.TotalDays / AvgDaysInAMonth;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary>
        /// Gets the weeks.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static int GetWeeks( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays % AvgDaysInAYear % AvgDaysInAMonth / 7d );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1;
            }
        }

        /// <summary>
        /// Gets the total weeks.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static double GetTotalWeeks( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.TotalDays / 7d;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary>
        /// Gets the days.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static int GetDays( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays % 7d );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1;
            }
        }

        /// <summary>
        /// Gets the microseconds.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static double GetMicroseconds( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.Ticks / 10d;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary>
        /// Gets the nanoseconds.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static double GetNanoseconds( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.Ticks / 100d;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary>
        /// Rounds the specified rounding interval.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <param name="interval">The rounding interval.</param>
        /// <param name="rounding">The rounding type.</param>
        /// <returns></returns>
        public static TimeSpan Round( this TimeSpan timeSpan, TimeSpan interval, 
            MidpointRounding rounding = MidpointRounding.ToEven )
        {
            try
            {
                var _time = Math.Round( timeSpan.Ticks / (double)interval.Ticks, rounding ); 
                return new TimeSpan( Convert.ToInt64( Math.Round( _time ) * interval.Ticks ) );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( TimeSpan );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
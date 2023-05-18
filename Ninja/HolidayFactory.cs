// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class HolidayFactory : FederalHoliday
    {
        public IDictionary<string, object> Args { get; set; }

        /// <summary> Gets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the Record. </summary>
        /// <value> The data row. </value>
        public DataRow Record { get; set; }

        /// <summary> </summary>
        public HolidayFactory( )
        {
        }

        /// <summary> </summary>
        /// <param name="dataRow"> </param>
        public HolidayFactory( DataRow dataRow )
        {
            Record = dataRow;
            NewYearsDay = DateOnly.Parse( dataRow[ "NewYearsDay" ].ToString( ) );
            MartinLutherKingDay = DateOnly.Parse( dataRow[ "MartinLutherKingDay" ].ToString( ) );
            PresidentsDay = DateOnly.Parse( dataRow[ "PresidentsDay" ].ToString( ) );
            MemorialDay = DateOnly.Parse( dataRow[ "MemorialDay" ].ToString( ) );
            VeteransDay = DateOnly.Parse( dataRow[ "VeteransDay" ].ToString( ) );
            LaborDay = DateOnly.Parse( dataRow[ "LaborDay" ].ToString( ) );
            IndependenceDay = DateOnly.Parse( dataRow[ "IndependenceDay" ].ToString( ) );
            ColumbusDay = DateOnly.Parse( dataRow[ "ColumbusDay" ].ToString( ) );
            ThanksgivingDay = DateOnly.Parse( dataRow[ "ThanksgivingDay" ].ToString( ) );
            ChristmasDay = DateOnly.Parse( dataRow[ "ChristmasDay" ].ToString( ) );
            Args = Record?.ToDictionary( );
        }

        /// <summary> Gets the federal holidays. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public IDictionary<string, DateTime> GetFederalHolidays( IDictionary<string, string> dict )
        {
            try
            {
                var _holiday = new Dictionary<string, DateTime>( );
                foreach( var kvp in dict )
                {
                    _holiday.Add( kvp.Key, DateTime.Parse( kvp.Value ) );
                }

                return _holiday.Any( )
                    ? _holiday
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary> Gets the national holidays. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public IDictionary<string, DateTime> GetNationalHolidays( IDictionary<string, string> dict )
        {
            try
            {
                var _holiday = new Dictionary<string, DateTime>( );
                foreach( var kvp in dict )
                {
                    _holiday.Add( kvp.Key, DateTime.Parse( kvp.Value ) );
                }

                return _holiday.Any( )
                    ? _holiday
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary> Converts to dictionary. </summary>
        /// <returns> </returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Args.Count > 0
                    ? Args
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}
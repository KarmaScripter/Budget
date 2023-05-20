// <copyright file = "BudgetFiscalYear.cs" company = "Terry D.Eppler">
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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.FiscalYear" />
    /// <seealso cref="BudgetExecution.IBudgetFiscalYear" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    public class BudgetFiscalYear : FiscalYear, IBudgetFiscalYear
    {
        /// <summary>
        /// Gets or sets the availability.
        /// </summary>
        /// <value>
        /// The availability.
        /// </value>
        public string Availability { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the holidays.
        /// </summary>
        /// <value>
        /// The holidays.
        /// </value>
        public HolidayFactory Holidays { get; set; }

        /// <summary>
        /// Gets or sets the federal holidays.
        /// </summary>
        /// <value>
        /// The federal holidays.
        /// </value>
        public IDictionary<Holiday, DateOnly> FederalHolidays { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        public BudgetFiscalYear( )
        {
            Source = Source.FiscalYears;
            CurrentDate = DateTime.Today;
            CurrentYear = DateTime.Now.Year;
            CurrentMonth = DateTime.Now.Month;
            CurrentDay = DateTime.Now.Day;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="bfy">The bfy.</param>
        public BudgetFiscalYear( string bfy )
            : this( )
        {
            InputYear = bfy;
            Record = new DataBuilder( Source, SetArgs( bfy ) )?.Record;
            ID = int.Parse( Record[ "FiscalYearId" ].ToString( ) );
            FirstYear = Record[ "FirstYear" ].ToString( );
            LastYear = Record[ "LastYEar" ].ToString( );
            Availability = Record[ "Availability" ].ToString( );
            WorkDays = double.Parse( Record[ "WorkDays" ].ToString( ) );
            WeekDays = double.Parse( Record[ "WeekDays" ].ToString( ) );
            WeekEnds = double.Parse( Record[ "WeekEnds" ].ToString( ) );
            ExpiringYear = Record[ "ExpiringYear" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            CancellationDate = DateOnly.Parse( Record[ "CancellationDate" ].ToString( ) );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetFiscalYear( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "FiscalYearId" ].ToString( ) );
            FirstYear = Record[ "FirstYear" ].ToString( );
            LastYear = Record[ "LastYEar" ].ToString( );
            Availability = Record[ "Availability" ].ToString( );
            WorkDays = double.Parse( Record[ "WorkDays" ].ToString( ) );
            WeekDays = double.Parse( Record[ "WeekDays" ].ToString( ) );
            WeekEnds = double.Parse( Record[ "WeekEnds" ].ToString( ) );
            ExpiringYear = Record[ "ExpiringYear" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            CancellationDate = DateOnly.Parse( Record[ "CancellationDate" ].ToString( ) );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="dataBuilder">The data builder.</param>
        public BudgetFiscalYear( IDataModel dataBuilder )
            : this( )
        {
            Record = dataBuilder.Record;
            ID = int.Parse( Record[ "FiscalYearsId" ].ToString( ) );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FirstYear = Record[ "FirstYear" ].ToString( );
            LastYear = Record[ "LastYEar" ].ToString( );
            Availability = Record?[ "Availability" ].ToString( );
            WorkDays = double.Parse( Record[ "WorkDays" ].ToString( ) );
            WeekDays = double.Parse( Record[ "WeekDays" ].ToString( ) );
            WeekEnds = double.Parse( Record[ "WeekEnds" ].ToString( ) );
            ExpiringYear = Record[ "ExpiringYear" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            CancellationDate = DateOnly.Parse( Record[ "CancellationDate" ].ToString( ) );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetFiscalYear( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            InputYear = dataRow[ "BFY" ].ToString( );
            ID = int.Parse( dataRow[ "FiscalYearsId" ].ToString( ) );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FirstYear = dataRow[ "FirstYear" ].ToString( );
            LastYear = dataRow[ "LastYEar" ].ToString( );
            Availability = dataRow[ "Availability" ].ToString( );
            WorkDays = double.Parse( dataRow[ "WorkDays" ].ToString( ) );
            WeekDays = double.Parse( dataRow[ "WeekDays" ].ToString( ) );
            WeekEnds = double.Parse( dataRow[ "WeekEnds" ].ToString( ) );
            ExpiringYear = dataRow[ "ExpiringYear" ].ToString( );
            StartDate = DateOnly.Parse( dataRow[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( dataRow[ "EndDate" ].ToString( ) );
            CancellationDate = DateOnly.Parse( dataRow[ "CancellationDate" ].ToString( ) );
            Holidays = new HolidayFactory( dataRow );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="fiscalYear">The fiscal year.</param>
        public BudgetFiscalYear( BudgetFiscalYear fiscalYear )
            : this( )
        {
            ID = fiscalYear.ID;
            BFY = fiscalYear.BFY;
            EFY = fiscalYear.EFY;
            FirstYear = fiscalYear.FirstYear;
            LastYear = fiscalYear.LastYear;
            WorkDays = fiscalYear.WorkDays;
            WeekDays = fiscalYear.WeekDays;
            WeekEnds = fiscalYear.WeekEnds;
            ExpiringYear = fiscalYear.ExpiringYear;
            StartDate = fiscalYear.StartDate;
            EndDate = fiscalYear.EndDate;
            CancellationDate = fiscalYear.CancellationDate;
        }

        /// <summary>
        /// Gets the federal holidays.
        /// </summary>
        /// <returns></returns>
        public IDictionary<Holiday, DateOnly> GetFederalHolidays( )
        {
            try
            {
                var _holidays = new Dictionary<Holiday, DateOnly>( );
                var _day = new HolidayFactory( Record );
                _holidays.Add( Holiday.NewYearsDay, _day.ChristmasDay );
                _holidays.Add( Holiday.MartinLutherKingsDay, _day.MartinLutherKingDay );
                _holidays.Add( Holiday.MemorialDay, _day.MemorialDay );
                _holidays.Add( Holiday.WashingtonsDay, _day.PresidentsDay );
                _holidays.Add( Holiday.VeteransDay, _day.VeteransDay );
                _holidays.Add( Holiday.LaborDay, _day.LaborDay );
                _holidays.Add( Holiday.JuneteenthDay, _day.JuneteenthDay );
                _holidays.Add( Holiday.IndependenceDay, _day.IndependenceDay );
                _holidays.Add( Holiday.ColumbusDay, _day.ColumbusDay );
                _holidays.Add( Holiday.ThanksgivingDay, _day.ThanksgivingDay );
                _holidays.Add( Holiday.ChristmasDay, _day.ChristmasDay );
                return ( _holidays?.Any( ) == true )
                    ? _holidays
                    : default( IDictionary<Holiday, DateOnly> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<Holiday, DateOnly> );
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <returns></returns>
        public int GetId( DataRow dataRow )
        {
            try
            {
                return dataRow != null
                    ? int.Parse( dataRow[ 0 ].ToString( ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        public int GetId( DataRow dataRow, PrimaryKey primaryKey )
        {
            try
            {
                return Enum.IsDefined( typeof( PrimaryKey ), primaryKey ) && dataRow != null
                    ? int.Parse( dataRow[ $"{primaryKey}" ].ToString( ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Record?.ItemArray?.Length > 0
                    ? Record.ToDictionary( )
                    : default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( FirstYear )
                    ? FirstYear
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the budget fiscal year.
        /// </summary>
        /// <returns></returns>
        public IBudgetFiscalYear GetBudgetFiscalYear( )
        {
            try
            {
                return MemberwiseClone( ) as IBudgetFiscalYear;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IBudgetFiscalYear );
            }
        }
    }
}
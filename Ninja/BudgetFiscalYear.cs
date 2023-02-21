// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.FiscalYear" />
    /// <seealso cref="BudgetExecution.IBudgetFiscalYear" />
    /// <seealso cref="BudgetExecution.ISource" />
    /// <seealso cref="FiscalYear" />
    /// <seealso cref="IBudgetFiscalYear" />
    /// <seealso cref="ISource" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    public class BudgetFiscalYear : FiscalYear, IBudgetFiscalYear, ISource
    {
        /// <summary>
        /// Gets or sets the fiscal year identifier.
        /// </summary>
        /// <value>
        /// The fiscal year identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public override string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public string EFY { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public override DateOnly StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public override DateOnly EndDate { get; set; }

        /// <summary>
        /// Gets or sets the columbus.
        /// </summary>
        /// <value>
        /// The columbus.
        /// </value>
        public DateOnly Columbus { get; set; }

        /// <summary>
        /// Gets or sets the christmas.
        /// </summary>
        /// <value>
        /// The christmas.
        /// </value>
        public DateOnly Christmas { get; set; }

        /// <summary>
        /// Gets or sets the thanksgiving.
        /// </summary>
        /// <value>
        /// The thanksgiving.
        /// </value>
        public DateOnly Thanksgiving { get; set; }

        /// <summary>
        /// Gets or sets the veterans.
        /// </summary>
        /// <value>
        /// The veterans.
        /// </value>
        public DateOnly Veterans { get; set; }

        /// <summary>
        /// Gets or sets the labor.
        /// </summary>
        /// <value>
        /// The labor.
        /// </value>
        public DateOnly Labor { get; set; }

        /// <summary>
        /// Gets or sets the independence.
        /// </summary>
        /// <value>
        /// The independence.
        /// </value>
        public DateOnly Independence { get; set; }

        /// <summary>
        /// Gets or sets the juneteenth.
        /// </summary>
        /// <value>
        /// The juneteenth.
        /// </value>
        public DateOnly Juneteenth { get; set; }

        /// <summary>
        /// Gets or sets the memorial.
        /// </summary>
        /// <value>
        /// The memorial.
        /// </value>
        public DateOnly Memorial { get; set; }

        /// <summary>
        /// Gets or sets the washingtons.
        /// </summary>
        /// <value>
        /// The washingtons.
        /// </value>
        public DateOnly Washingtons { get; set; }

        /// <summary>
        /// Gets or sets the martin luther king.
        /// </summary>
        /// <value>
        /// The martin luther king.
        /// </value>
        public DateOnly MartinLutherKing { get; set; }

        /// <summary>
        /// Creates new years.
        /// </summary>
        /// <value>
        /// The new years.
        /// </value>
        public DateOnly NewYears { get; set; }

        /// <summary>
        /// Gets or sets the expiring year.
        /// </summary>
        /// <value>
        /// The expiring year.
        /// </value>
        public override string ExpiringYear { get; set; }

        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        /// <value>
        /// The expiration date.
        /// </value>
        public DateOnly ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the cancellation date.
        /// </summary>
        /// <value>
        /// The cancellation date.
        /// </value>
        public override DateOnly CancellationDate { get; set; }

        /// <summary>
        /// Gets or sets the work days.
        /// </summary>
        /// <value>
        /// The work days.
        /// </value>
        public override double WorkDays { get; set; }

        /// <summary>
        /// Gets or sets the week days.
        /// </summary>
        /// <value>
        /// The week days.
        /// </value>
        public override double WeekDays { get; set; }

        /// <summary>
        /// Gets or sets the week ends.
        /// </summary>
        /// <value>
        /// The week ends.
        /// </value>
        public override double WeekEnds { get; set; }

        /// <summary>
        /// Gets or sets the availability.
        /// </summary>
        /// <value>
        /// The availability.
        /// </value>
        public string Availability { get; set; }
        
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; } 

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
        /// Initializes a new instance of the <see cref="BudgetFiscalYear" /> class.
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
        /// Initializes a new instance of the <see cref="BudgetFiscalYear" /> class.
        /// </summary>
        /// <param name="bfy">The bfy.</param>
        public BudgetFiscalYear( string bfy ) 
            : this( )
        {
            InputYear = bfy;
            Record = new DataBuilder( Source, SetArgs( bfy ) )?.Record;
            ID = int.Parse( Record[ "FiscalYeardId" ].ToString( ) );
            FirstYear = Record[ $"{ Field.FirstYear }" ].ToString( );
            LastYear = Record[ $"{ Field.LastYear }" ].ToString( );
            Availability = Record[ $"{ Field.Availability }" ].ToString( );
            WorkDays = double.Parse( Record[ $"{ Field.WorkDays }" ].ToString( ) );
            WeekDays = double.Parse( Record[ $"{ Field.WeekDays }" ].ToString( ) );
            WeekEnds = double.Parse( Record[ $"{ Field.WeekEnds }" ].ToString( ) );
            ExpiringYear = Record[ $"{ Field.ExpiringYear }" ].ToString( );
            StartDate = DateOnly.Parse( Record[ $"{ Field.StartDate }" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ $"{ Field.EndDate }" ].ToString( ) );
            CancellationDate = DateOnly.Parse( Record[ $"{ Field.CancellationDate }" ].ToString( ) );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetFiscalYear( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "FiscalYeardId" ].ToString( ) );
            FirstYear = Record[ $"{ Field.FirstYear }" ].ToString( );
            LastYear = Record[ $"{ Field.LastYear }" ].ToString( );
            Availability = Record[ $"{ Field.Availability }" ].ToString( );
            WorkDays = double.Parse( Record[ $"{ Field.WorkDays }" ].ToString( ) );
            WeekDays = double.Parse( Record[ $"{ Field.WeekDays }" ].ToString( ) );
            WeekEnds = double.Parse( Record[ $"{ Field.WeekEnds }" ].ToString( ) );
            ExpiringYear = Record[ $"{ Field.ExpiringYear }" ].ToString( );
            StartDate = DateOnly.Parse( Record[ $"{ Field.StartDate }" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ $"{ Field.EndDate }" ].ToString( ) );
            CancellationDate = DateOnly.Parse( Record[ $"{ Field.CancellationDate }" ].ToString( ) );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear" /> class.
        /// </summary>
        /// <param name="dataBuilder">The data builder.</param>
        public BudgetFiscalYear( IDataModel dataBuilder )
            : this( )
        {
            Record = dataBuilder?.Record;
            ID = int.Parse( Record?[ "FiscalYeardId" ].ToString( ) );
            FirstYear = Record?[ $"{ Field.FirstYear }" ].ToString( );
            LastYear = Record?[ $"{ Field.LastYear }" ].ToString( );
            Availability = Record?[ $"{ Field.Availability }" ].ToString( );
            WorkDays = double.Parse( Record?[ $"{ Field.WorkDays }" ].ToString( ) );
            WeekDays = double.Parse( Record?[ $"{ Field.WeekDays }" ].ToString( ) );
            WeekEnds = double.Parse( Record?[ $"{ Field.WeekEnds }" ].ToString( ) );
            ExpiringYear = Record?[ $"{ Field.ExpiringYear }" ].ToString( );
            StartDate = DateOnly.Parse( Record?[ $"{ Field.StartDate }" ].ToString( ) );
            EndDate = DateOnly.Parse( Record?[ $"{ Field.EndDate }" ].ToString( ) );
            CancellationDate = DateOnly.Parse( Record?[ $"{ Field.CancellationDate }" ].ToString( ) );
            Holidays = new HolidayFactory( Record );
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetFiscalYear( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            InputYear = dataRow[ $"{ Field.BFY }" ].ToString( );
            ID = int.Parse( Record?[ "FiscalYeardId" ].ToString( ) );
            FirstYear = dataRow[ $"{ Field.FirstYear }" ].ToString( );
            LastYear = dataRow[ $"{ Field.LastYear }" ].ToString( );
            Availability = dataRow[ $"{ Field.Availability }" ].ToString( );
            WorkDays = double.Parse( Record?[ $"{ Field.WorkDays }" ].ToString( ) );
            WeekDays = double.Parse( Record?[ $"{ Field.WeekDays }" ].ToString( ) );
            WeekEnds = double.Parse( Record?[ $"{ Field.WeekEnds }" ].ToString( ) );
            ExpiringYear = Record?[ $"{ Field.ExpiringYear }" ].ToString( );
            StartDate = DateOnly.Parse( Record?[ $"{ Field.StartDate }" ].ToString( ) );
            EndDate = DateOnly.Parse( Record?[ $"{ Field.EndDate }" ].ToString( ) );
            CancellationDate = DateOnly.Parse( Record?[ $"{ Field.CancellationDate }" ].ToString( ) );
            Holidays = new HolidayFactory( dataRow );
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
                _holidays.Add( Holiday.NewYears, _day.ChristmasDay );
                _holidays.Add( Holiday.MartinLutherKing, _day.MartinLutherKingDay );
                _holidays.Add( Holiday.Memorial, _day.MemorialDay );
                _holidays.Add( Holiday.Presidents, _day.PresidentsDay );
                _holidays.Add( Holiday.Veterans, _day.VeteransDay );
                _holidays.Add( Holiday.Labor, _day.LaborDay );
                _holidays.Add( Holiday.Juneteenth, _day.JuneteenthDay );
                _holidays.Add( Holiday.Independence, _day.IndependenceDay );
                _holidays.Add( Holiday.Columbus, _day.ColumbusDay );
                _holidays.Add( Holiday.Thanksgiving, _day.ThanksgivingDay );
                _holidays.Add( Holiday.Christmas, _day.ChristmasDay );
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
                    ? int.Parse( dataRow[ 0 ].ToString(  ) )
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
                    ? int.Parse( dataRow[ $"{ primaryKey }" ].ToString(  ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
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
                return MemberwiseClone( ) as BudgetFiscalYear;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IBudgetFiscalYear );
            }
        }
    }
}
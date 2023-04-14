// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class Calendar : MonthCalendarAdv
    {
        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataSet AnnualData { get; set; }

        /// <summary>
        /// Gets or sets the holidays.
        /// </summary>
        /// <value>
        /// The holidays.
        /// </value>
        public DataTable Holidays { get; set; }

        /// <summary>
        /// Gets or sets the fiscal years.
        /// </summary>
        /// <value>
        /// The fiscal years.
        /// </value>
        public DataTable FiscalYears { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Calendar"/> class.
        /// </summary>
        public Calendar( )
        {
            Border3DStyle = Border3DStyle.Flat;
            GridBackColor = Color.DarkGray;
            FirstDayOfWeek = Day.Monday;
            HeaderFont = new Font( "Roboto", 10 );
            HeaderStartColor = SystemColors.ActiveCaption;
            HeaderEndColor = SystemColors.ActiveCaption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Calendar"/> class.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        public Calendar( DateTime dateTime ) 
            : this( )
        {
            Value = dateTime;
        }
        
        /// <summary>
        /// Gets the federal holidays.
        /// </summary>
        /// <returns></returns>
        private DataTable GetFederalHolidays( )
        {
            try
            {
                var _data = new DataBuilder( Source.FederalHolidays, Provider.Access );
                var _table = _data.DataTable;
                return _table.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// Gets the fiscal years.
        /// </summary>
        /// <returns></returns>
        private DataTable GetFiscalYears( )
        {
            try
            {
                var _data = new DataBuilder( Source.FiscalYears, Provider.Access );
                var _table = _data.DataTable;
                return _table.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}

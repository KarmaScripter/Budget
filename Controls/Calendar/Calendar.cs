// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.CellGrid.Helpers;
    using Syncfusion.Windows.Forms.Tools;
    using ContentAlignment = System.Drawing.ContentAlignment;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class Calendar : MonthCalendarAdv
    {
        /// <summary>
        /// Gets or sets the date selected.
        /// </summary>
        /// <value>
        /// The date selected.
        /// </value>
        public string Selection { get; set; }
        
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
            GridBackColor = SystemColors.GradientActiveCaption;
            BackColor = Color.FromArgb( 30, 30, 30 );
            FirstDayOfWeek = Day.Monday;
            Font = new Font( "Roboto", 9 );
            HeaderFont = new Font( "Roboto", 10, FontStyle.Bold );
            DaysFont = new Font( "Roboto", 9 );
            DayNamesFont = new Font( "Roboto", 9, FontStyle.Bold );
            DayNamesHeight = 22;
            MetroColor = Color.FromArgb( 0, 120, 212 );
            HeaderHeight = 34;
            HeadForeColor = Color.White;
            HeaderStartColor = Color.FromArgb( 50, 93, 129 );
            HeaderEndColor = Color.FromArgb( 50, 93, 129 );
            DayNamesColor = Color.Black;
            DaysColor = Color.Black;
            InactiveMonthColor = SystemColors.GrayText;
            TodayButton.Appearance = ButtonAppearance.Metro;
            TodayButton.BackColor = Color.FromArgb( 20, 20, 20 );
            TodayButton.ForeColor = Color.LightGray;
            TodayButton.Font = new Font( "Roboto", 8 );
            TodayButton.TextAlign = ContentAlignment.MiddleLeft;
            TodayButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            TodayButton.FlatAppearance.MouseOverBackColor = Color.FromArgb( 50, 93, 129 );
            TodayButton.Size = new Size( 287, 30 );
            NoneButton.Appearance = ButtonAppearance.Metro;
            NoneButton.BackColor = Color.FromArgb( 20, 20, 20 );
            NoneButton.ForeColor = Color.LightGray;
            NoneButton.Font = new Font( "Roboto", 8 );
            NoneButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            NoneButton.FlatAppearance.MouseOverBackColor = Color.FromArgb( 50, 93, 129 );
            NoneButton.Text = "Close";
            NoneButton.Size = new Size( 140, 30 );
            HighlightColor = Color.White;
            BottomHeight = 30;
            SelectionChanged += OnSelectionChanged;
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
        /// Called when [selection changed].
        /// </summary>
        /// <param name="sender">
        /// The sender.</param>
        /// <param name="e">The
        /// <see cref="SelectionChangedEventArgs"/>
        /// instance containing the event data.</param>
        private void OnSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                Selection = Value.ToString( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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

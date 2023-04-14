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
    using Syncfusion.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class DateControl : UserControl
    {
        /// <summary>
        /// Gets or sets the selected date.
        /// </summary>
        /// <value>
        /// The selected date.
        /// </value>
        public string DateSelected { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataSet AnnualData { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public DateTime Value { get; set; }

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
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        /// 
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateControl"/> class.
        /// </summary>
        public DateControl( )
        {
            InitializeComponent( );

            // Calendar Properties
            Calendar.Border3DStyle = Border3DStyle.Flat;
            Calendar.GridBackColor = Color.FromArgb( 30, 30, 30 );
            Calendar.BackColor = Color.FromArgb( 30, 30, 30 );
            Calendar.FirstDayOfWeek = Day.Monday;
            Calendar.Font = new Font( "Roboto", 9 );
            Calendar.HeaderFont = new Font( "Roboto", 10, FontStyle.Bold );
            Calendar.DaysFont = new Font( "Roboto", 9 );
            Calendar.DayNamesFont = new Font( "Roboto", 9, FontStyle.Bold );
            Calendar.MetroColor = Color.FromArgb( 0, 120, 212 );
            Calendar.HeadForeColor = Color.White;
            Calendar.HeaderStartColor = Color.FromArgb( 50, 93, 129 );
            Calendar.HeaderEndColor = Color.FromArgb( 50, 93, 129 );
            Calendar.DayNamesColor = Color.Black;
            Calendar.DaysColor = Color.White;
            Calendar.InactiveMonthColor = Color.Gray;
            Calendar.TodayButton.Appearance = ButtonAppearance.Metro;
            Calendar.TodayButton.ForeColor = Color.LightGray;
            Calendar.TodayButton.Font = new Font( "Roboto", 9, FontStyle.Bold );
            Calendar.TodayButton.BackColor = Color.FromArgb( 50, 93, 129 );
            Calendar.NoneButton.Appearance = ButtonAppearance.Metro;
            Calendar.NoneButton.ForeColor = Color.LightGray;
            Calendar.NoneButton.Font = new Font( "Roboto", 9, FontStyle.Bold );
            Calendar.NoneButton.BackColor = Color.FromArgb( 50, 93, 129 );
            Calendar.HighlightColor = Color.White;
            Calendar.BottomHeight = 30;
            Calendar.ForeColor = Color.LightGray;
            Calendar.ClearSelectionOnNone = true;
            Value = Calendar.Value;
            Calendar.SelectionChanged += OnDateSelected;
        }

        public DateControl( DateTime dateTime )
            : this( )
        {
            DateSelected = dateTime.ToString( );
            Calendar.Value = dateTime;
        }

        /// <summary>
        /// Called when [selection changed].
        /// </summary>
        /// <param name="sender">
        /// The sender.</param>
        /// <param name="e">The
        /// instance containing the event data.</param>
        public void OnDateSelected( object sender, EventArgs e )
        {
            try
            {
                if( sender is DateControl _calendar )
                {
                    var _date = _calendar.Value;
                    Value = Calendar.Value;
                    DateSelected = _date.ToString( );
                }
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

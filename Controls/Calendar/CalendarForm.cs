// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.CellGrid.Helpers;
    using Syncfusion.WinForms.Input;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public partial class CalendarForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the selected date.
        /// </summary>
        /// <value>
        /// The selected date.
        /// </value>
        public string DateSelected { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CalendarForm"/> class.
        /// </summary>
        public CalendarForm( )
        {
            InitializeComponent( );

            // Basic Properties
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Size = new Size( 584, 406 );
            MinimumSize = new Size( 584, 406 );
            MaximumSize = new Size( 584, 406 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.DarkGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = false;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;

            // Close Button
            CloseButton.NormalTextColor = Color.FromArgb( 20, 20, 20 );
            CloseButton.HoverTextColor = Color.White;
            CloseButton.HoverBorderColor = Color.FromArgb( 0, 120, 212 );
            CloseButton.Text = "Close";
            CloseButton.HoverText = "Close Calendar";

            // HeaderLabel Settings
            HeaderLabel.Font = new Font( "Roboto", 11 );
            HeaderLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Event Wiring
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="CalendarForm"/> class.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        public CalendarForm( DateTime dateTime )
            : this( )
        {
            DateSelected = dateTime.ToString( );
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                CloseButton.ForeColor = Color.FromArgb( 20, 20, 20 );
                CloseButton.Click += OnCloseButtonClicked;
                Calendar.SelectionChanged += OnSelectionChanged;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCloseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                var _date = Calendar.SelectedDate;
                DateSelected = _date.ToString( );
                Close( );
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
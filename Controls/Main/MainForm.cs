// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using OfficeOpenXml.Drawing.Slicer;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    public partial class MainForm : MetroForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1400, 800 );
            MaximumSize = new Size( 1400, 800 );
            MinimumSize = new Size( 1400, 750 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            FormBorderStyle = FormBorderStyle.Sizable;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = false;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.LightSteelBlue;
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.Red;
            MinimizeBox = false;
            MaximizeBox = false;
            
            // Event Wiring
            ExitButton.Click += null;
            DatabaseTile.Click += OnDatabaseTileClicked;
            UtilityTile.Click += OnUtilityTileClicked;
            ReportingTile.Click += OnReportingTileClicked;
            ClientTile.Click += OnClientTileClicked;
            GuidanceTile.Click += OnGuidanceTileClicked;
            ToolTile.Click += OnToolTileClicked;
            Load += OnLoad;
        }

        /// <summary>
        /// Sets the tile titles.
        /// </summary>
        private void SetTileTitles( )
        {
            try
            {
                DatabaseTile.Title.Text = "Data Management";
                DatabaseTile.Body.Text = "Data Tables - Providers - Schema - SQL Editor";
                UtilityTile.Title.Text = "Utilities";
                UtilityTile.Body.Text = "Calculators - Calendars - Spreadsheets - Web Browsers";
                ReportingTile.Title.Text = "Reporting";
                ReportingTile.Body.Text = "Charts and Visualizations";
                ClientTile.Title.Text = "DB Clients";
                ClientTile.Body.Text = "SQLite - SQL Compact - MS Access - SQL Server";
                GuidanceTile.Title.Text = "Guidance";
                GuidanceTile.Body.Text = "OMB A-11, Resource Management Directives - Money & Finance - Appropriations Law";
                ToolTile.Title.Text = "Data Tools";
                ToolTile.Body.Text = string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SetTileTitles(  );
                ExitButton.Click += OnExitButtonClicked;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Called when [database tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnDatabaseTileClicked( object sender, EventArgs e )
        {
            try
            {
                var _dataGridForm = new DataGridForm( );
                _dataGridForm.StartPosition = FormStartPosition.CenterParent;
                _dataGridForm.Show(  );
                Visible = false;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [reporting tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnReportingTileClicked( object sender, EventArgs e )
        {
            try
            {
                var _dialog = new FilterDialog( BindingSource );
                _dialog.TabControl.SelectedTab = _dialog.TableTab;
                BindingSource = _dialog.BindingSource;
                _dialog.ShowDialog(  );
                var _chartForm = new ChartForm( BindingSource );
                _chartForm.StartPosition = FormStartPosition.CenterParent;
                _chartForm.ShowDialog( );
                Visible = false;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [client tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnClientTileClicked( object sender, EventArgs e )
        {
            try
            {
                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                var _notification = new Notification( _msg );
                _notification.Show( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [utility tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnUtilityTileClicked( object sender, EventArgs e )
        {
            try
            {
                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                var _notification = new Notification( _msg );
                _notification.Show( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [guidance tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnGuidanceTileClicked( object sender, EventArgs e )
        {
            try
            {
                var _pdf = new PdfForm( );
                _pdf.StartPosition = FormStartPosition.CenterParent;
                _pdf.Show( );
                Visible = false;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [tool tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnToolTileClicked( object sender, EventArgs e )
        {
            try
            {
                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                var _notification = new Notification( _msg );
                _notification.Show( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [exit button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnExitButtonClicked( object sender, EventArgs e )
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
        /// Get Error Dialog.
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
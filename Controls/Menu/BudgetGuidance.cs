// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.BudgetGuidance" />
    public partial class BudgetGuidance : MetroForm
    {
        /// <summary>
        /// Gets or sets the tiles.
        /// </summary>
        /// <value>
        /// The tiles.
        /// </value>
        public IEnumerable<Tile> Tiles { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetGuidance"/> class.
        /// </summary>
        public BudgetGuidance( )
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
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;
            
            // Event Wiring
            CloseButton.Click += null;
            FundsControlManualTile.Click += OnDatabaseTileClicked;
            AntiDeficiencyActTile.Click += OnUtilityTileClicked;
            OmbCircularTile.Click += OnReportingTileClicked;
            MoneyAndFinanceTile.Click += OnClientTileClicked;
            AppropriationsLawVolumeOneTile.Click += OnGuidanceTileClicked;
            AppropriationsLawVolumeTwoTile.Click += OnWebTileClicked;
            CloseButton.Click += OnCloseButtonClicked;
            Load += OnLoad;
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
                Tiles = GetTiles( );
                SetTileProperties( );
                SetTileText(  );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the tiles.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Tile> GetTiles( )
        {
            try
            {
                var _tiles = new List<Tile>( );
                for( var _index = 0; _index < Controls.Count; _index++ )
                {
                    var control = Controls[ _index ];
                    if( control.GetType( ) == typeof( Tile ) )
                    {
                        var _tile = control as Tile;
                        _tiles.Add( _tile );
                    }
                }

                return _tiles?.Any( ) == true
                    ? _tiles
                    : Enumerable.Empty<Tile>( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<Tile> );
            }
        }
        
        /// <summary>
        /// Sets the tile titles.
        /// </summary>
        private void SetTileText( )
        {
            try
            {
                FundsControlManualTile.Title.Text = "Funds Control Manual";
                FundsControlManualTile.Body.Text = "RMDS 2520";
                FundsControlManualTile.Banner.Text = "US EPA";
                AntiDeficiencyActTile.Title.Text = "Anti-Deficiency Act";
                AntiDeficiencyActTile.Body.Text = "Public Law 97-258";
                AntiDeficiencyActTile.Banner.Text = "US Congress";
                OmbCircularTile.Title.Text = "OMB Circular A-11";
                OmbCircularTile.Body.Text = "Budget Execution & Formulation";
                OmbCircularTile.Banner.Text = "OMB";
                MoneyAndFinanceTile.Title.Text = "Money & Finance";
                MoneyAndFinanceTile.Body.Text = "US Code Title 31";
                MoneyAndFinanceTile.Banner.Text = "US GPO";
                AppropriationsLawVolumeOneTile.Title.Text =  "Federal Appropriation's Law";
                AppropriationsLawVolumeOneTile.Body.Text = "Volume I";
                AppropriationsLawVolumeOneTile.Banner.Text = "US GPO";
                AppropriationsLawVolumeTwoTile.Title.Text = "Federal Appropriation's Law";
                AppropriationsLawVolumeTwoTile.Body.Text = "Volume II";
                AppropriationsLawVolumeTwoTile.Banner.Text = "US GPO";
                ObjectClassManualTile.Title.Text = "Object Class Manual";
                ObjectClassManualTile.Body.Text = "RMDS 2590";
                ObjectClassManualTile.Banner.Text = "US EPA";
                OfficialTravelTile.Title.Text = "Official Travel";
                OfficialTravelTile.Body.Text = "RMDS 2550-B";
                OfficialTravelTile.Banner.Text = "US EPA";
                AdviceOfAllowanceTile.Title.Text = "Advice of Allowance";
                AdviceOfAllowanceTile.Body.Text = "OCFO Memorandum";
                AdviceOfAllowanceTile.Banner.Text = "US EPA";
                SuperfundGuidanceTile.Title.Text = "Superfund Guidance Menu";
                SuperfundGuidanceTile.Body.Text = "Superfund Program";
                SuperfundGuidanceTile.Banner.Text = "US EPA";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tile properties.
        /// </summary>
        private void SetTileProperties( )
        {
            try
            {
                if( Tiles?.Any( ) == true )
                {
                    foreach( var tile in Tiles )
                    {
                        tile.Size = new Size( 292, 140 );
                        tile.Title.Font = new Font( "Roboto", 12, FontStyle.Regular );
                        tile.Body.Font = new Font( "Roboto", 10, FontStyle.Regular );
                        tile.Footer.Font = new Font( "Roboto", 9, FontStyle.Regular );
                        tile.Banner.Font = new Font( "Roboto", 8, FontStyle.Regular );
                        tile.TurnLiveTileOn = true;
                    }
                }
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
                _dataGridForm.Owner = this;
                _dataGridForm.StartPosition = FormStartPosition.CenterScreen;
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
                var _chartForm = new ChartForm( );
                _chartForm.Owner = this;
                _chartForm.StartPosition = FormStartPosition.CenterScreen;
                _chartForm.Show( );
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
                var _minion = new MinionSelector(  );
                _minion.ShowDialog(  );
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
                _pdf.Owner = this;
                _pdf.StartPosition = FormStartPosition.CenterScreen;
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
        private void OnWebTileClicked( object sender, EventArgs e )
        {
            try
            {
                var _web = new WebPage( );
                _web.Owner = this;
                _web.StartPosition = FormStartPosition.CenterScreen;
                _web.Show( );
                Visible = false;
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
                if( Owner != null 
                   && Owner.Visible == false )
                {
                    Owner.Visible = true;
                }
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
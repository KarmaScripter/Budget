// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class SuperfundGuidance : MetroForm
    {
        /// <summary>
        /// Gets or sets the tiles.
        /// </summary>
        /// <value>
        /// The tiles.
        /// </value>
        public IEnumerable<Tile> Tiles { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuperfundGuidance"/> class.
        /// </summary>
        public SuperfundGuidance( )
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
            GeneralInformationTile.Click += OnGeneralInformationTileClicked;
            SuperfundPayrollTile.Click += OnSuperfundPayrollTileClicked;
            IntroductionTile.Click += OnIntroductionTileClicked;
            DirectChargingTile.Click += OnDirectChargingTileClicked;
            CostAccountingTile.Click += OnCostAccountingTileClicked;
            SuperfundBudgetingTile.Click += OnSuperfundBudgetingTileClicked;
            CostRecoveryTile.Click += OnCostRecoveryTileClicked;
            SpecialAccountsTile.Click += OnSpecialAccountsTileClicked;
            InteragencyAgreementTile.Click += OnInteragencyAgreementsTileClicked;
            BudgetGuidanceTile.Click += OnBudgetGuidanceTileClicked;
            CloseButton.Click += OnCloseButtonClicked;
            Load += OnLoad;
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
        /// Sets the tile text.
        /// </summary>
        private void SetTileText( )
        {
            try
            {
                GeneralInformationTile.Title.Text = "General Information";
                GeneralInformationTile.Body.Text = "Superfund Program";
                GeneralInformationTile.Banner.Text = "US EPA";
                SuperfundPayrollTile.Title.Text =  "Utilities";
                SuperfundPayrollTile.Body.Text = "Superfund Program";
                SuperfundPayrollTile.Banner.Text = "US EPA";
                IntroductionTile.Title.Text = "Program Introduction";
                IntroductionTile.Body.Text = "Superfund Program";
                IntroductionTile.Banner.Text = "US EPA";
                DirectChargingTile.Title.Text = "Direct Charging";
                DirectChargingTile.Body.Text = "Superfund Program";
                DirectChargingTile.Banner.Text = "US EPA";
                CostAccountingTile.Title.Text =  "Cost Accounting";
                CostAccountingTile.Body.Text = "Superfund Program";
                CostAccountingTile.Banner.Text = "US EPA";
                SuperfundBudgetingTile.Title.Text = "Superfund Budgeting";
                SuperfundBudgetingTile.Body.Text = "Superfund Program";
                SuperfundBudgetingTile.Banner.Text = "US EPA";
                CostRecoveryTile.Title.Text = "Cost Recovery";
                CostRecoveryTile.Body.Text = "Superfund Program";
                CostRecoveryTile.Banner.Text = "US EPA";
                SpecialAccountsTile.Title.Text = "Special Accounts";
                SpecialAccountsTile.Body.Text = "Superfund Program";
                SpecialAccountsTile.Banner.Text = "US EPA";
                InteragencyAgreementTile.Title.Text = "Inter Agency Agreement";
                InteragencyAgreementTile.Body.Text = "Superfund Program";
                InteragencyAgreementTile.Banner.Text = "US EPA";
                BudgetGuidanceTile.Title.Text = "Budget Guidance";
                BudgetGuidanceTile.Body.Text = "Office Of Budget";
                BudgetGuidanceTile.Banner.Text = "US EPA";
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
        /// Called when [general information tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnGeneralInformationTileClicked( object sender, EventArgs e )
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
        /// Called when [introduction tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnIntroductionTileClicked( object sender, EventArgs e )
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
        /// Called when [interagency agreements tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnInteragencyAgreementsTileClicked( object sender, EventArgs e )
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
        /// Called when [direct charging tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnDirectChargingTileClicked( object sender, EventArgs e )
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
        /// Called when [superfund payroll tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSuperfundPayrollTileClicked( object sender, EventArgs e )
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
        /// Called when [budget guidance tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnBudgetGuidanceTileClicked( object sender, EventArgs e )
        {
            try
            {
                if( Owner != null
                   && Owner.Visible == false )
                {
                    Owner.Visible = true;
                    Close( );
                }
                else
                {
                    var _budget = new BudgetGuidance(  );
                    _budget.Owner = this;
                    _budget.Show( );
                    Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [cost accounting tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCostAccountingTileClicked( object sender, EventArgs e )
        {
            try
            {
                var _guidance = new BudgetGuidance( );
                _guidance.Owner = this;
                _guidance.StartPosition = FormStartPosition.CenterScreen;
                _guidance.Show( );
                Visible = false;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [superfund budgeting tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSuperfundBudgetingTileClicked( object sender, EventArgs e )
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
        /// Called when [cost recovery tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCostRecoveryTileClicked( object sender, EventArgs e )
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
        /// Called when [special accounts tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSpecialAccountsTileClicked( object sender, EventArgs e )
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
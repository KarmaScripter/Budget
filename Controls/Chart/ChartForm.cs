// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class ChartForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        public ChartForm( )
        {
            InitializeComponent( );

            // Basic Properties
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size( 1400, 750 );
            MaximumSize = new Size( 1400, 800 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;
            
            // Label Properties
            FirstFilterLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            SecondFilterLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            ThirdFilterLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            
            // Chart Properties
            Chart.Title.Text = string.Empty;
            
            // Event Wiring
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ChartForm( BindingSource bindingSource )
            : this( )
        {
            BindingSource = bindingSource;
            ToolStrip.BindingSource = bindingSource;
            ToolStrip.BindingSource.DataSource = bindingSource.DataSource;
            Chart.BindingSource = BindingSource;
            Chart.Dock = DockStyle.Fill;
            Controls.Add( Chart );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public ChartForm( DataTable dataTable )
            : this( )
        {
            BindingSource.DataSource = dataTable;
            ToolStrip.BindingSource = BindingSource;
            ToolStrip.BindingSource.DataSource = BindingSource.DataSource;
            Chart.BindingSource = BindingSource;
            Chart.Dock = DockStyle.Fill;
            Controls.Add( Chart );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRows"></param>
        public ChartForm( IEnumerable<DataRow> dataRows )
            : this( )
        {
            BindingSource.DataSource = dataRows.CopyToDataTable( );
            ToolStrip.BindingSource = BindingSource;
            ToolStrip.BindingSource.DataSource = BindingSource.DataSource;
            Chart.BindingSource = BindingSource;
            Chart.Dock = DockStyle.Fill;
            Controls.Add( Chart );
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">
        /// The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                BackButton.Click += null;
                BackButton.Click += OnBackButtonClicked;
                ToolStrip.Office12Mode = true;
                ToolStrip.Text = string.Empty;
                Chart.ChartArea.BorderStyle = BorderStyle.None;
                PopulateToolBarDropDownItems( );
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Populates the tool bar drop down items.
        /// </summary>
        public void PopulateToolBarDropDownItems( )
        {
            try
            {
                var _names = Enum.GetNames( typeof( ChartSeriesType ) );
                for( var _i = 0; _i < _names.Length; _i++ )
                {
                    var name = _names[ _i ];
                    if( name != "NS" )
                    {
                        DropDown.Items.Add( name );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [back button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnBackButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button 
                   && _button.ToolType == ToolType.BackButton )
                {
                    Close(  );
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
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
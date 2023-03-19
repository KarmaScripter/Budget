// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Data;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" )]
    public partial class ProgramProjectDialog : MetroForm
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary>
        /// Gets or sets the selected value.
        /// </summary>
        /// <value>
        /// The selected value.
        /// </value>
        public string SelectedValue { get; set; }

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

        /// <summary>
        /// Gets or sets the select project.
        /// </summary>
        /// <value>
        /// The select project.
        /// </value>
        public string SelectedProgram { get; set; }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public DataRow Current { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramProjectDialog"/> class.
        /// </summary>
        public ProgramProjectDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Size = new Size( 982, 614 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightSteelBlue;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            FormFilter = new Dictionary<string, object>( );

            // Bind DataSource
            Source = Source.ProgramProjectDescriptions;
            Provider = Provider.Access;

            // Event Wiring
            Load += OnLoad;
            NextButton.Click += OnNextButtonClicked;
            PreviousButton.Click += OnPreviousButtonClicked;
            CloseButton.Click += OnCloseButtonClicked;
            ProgramListBox.SelectedValueChanged += OnListBoxItemSelected;
            BindingSource.CurrentChanged += UpdateHeaderTitle;
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="ProgramProjectDialog"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        public ProgramProjectDialog( string code )
            : this( )
        {
            SelectedProgram = code;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                DataModel = new DataBuilder( Source, Provider );
                DataTable = DataModel.DataTable;
                BindingSource.DataSource = DataTable;
                Current = BindingSource.GetCurrentDataRow( );
                ProgramListBox.ShowScrollBar = true;
                Text = Current[ "ProgramTitle" ].ToString( );
                if( !string.IsNullOrEmpty( SelectedProgram ) )
                {
                    FormFilter.Add( "Code", SelectedProgram );
                    BindingSource.Filter = FormFilter.ToCriteria( );
                }

                PopulateListBoxItems( );
                CreateBindings( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the ComboBox items.
        /// </summary>
        private void PopulateListBoxItems( )
        {
            try
            {
                var _data = DataModel.DataElements;
                var _codes = _data[ "Name" ];
                foreach( var code in _codes )
                {
                    if( !string.IsNullOrEmpty( code ) )
                    {
                        ProgramListBox.Items.Add( code );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the current program title.
        /// </summary>
        private void UpdateHeaderTitle( object sender, EventArgs e )
        {
            try
            {
                var _data = BindingSource.GetCurrentDataRow( );
                Text = _data[ "ProgramTitle" ].ToString( );
                ProgramAreaLabel.Text = "Program Area - " + _data[ "ProgramAreaCode" ];
                ProgramProjectLabel.Text = "Program Project - " + _data[ "Code" ];
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Creates the bindings.
        /// </summary>
        private void CreateBindings( )
        {
            if( BindingSource != null )
            {
                try
                {
                    var _programAreaName = new Binding( "Text", BindingSource, "ProgramAreaName" );
                    ProgramAreaNameTextBox.DataBindings.Add( _programAreaName );
                    var _programProjectName = new Binding( "Text", BindingSource, "Name" );
                    ProgramProjectNameTextBox.DataBindings.Add( _programProjectName );
                    var _laws = new Binding( "Text", BindingSource, "Laws" );
                    StatutoryAuthorityTextBox.DataBindings.Add( _laws );
                    var _description = new Binding( "Text", BindingSource, "Description" );
                    ProgramDescriptionTextBox.DataBindings.Add( _description );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnCloseButtonClicked( object sender, EventArgs e )
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
        /// Called when [previous button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnPreviousButtonClicked( object sender, EventArgs e )
        {
            try
            {
                BindingSource.MovePrevious( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [next button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnNextButtonClicked( object sender, EventArgs e )
        {
            try
            {
                BindingSource.MoveNext( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    SelectedProgram = _listBox.SelectedValue?.ToString( );
                    if( !string.IsNullOrEmpty( SelectedProgram ) )
                    {
                        var _current = BindingSource.Find( "Name", SelectedProgram );
                        BindingSource.Position = _current;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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
﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System;
    using Syncfusion.Windows.Forms;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public partial class DataGridForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> FormFilter { get; set; }
        
        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable { get; set; }

        /// <summary>
        /// Gets or sets the selected column.
        /// </summary>
        /// <value>
        /// The selected column.
        /// </value>
        public string SelectedColumn { get; set; }

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
        /// Initializes a new instance of the <see cref="DataGridForm"/> class.
        /// </summary>
        public DataGridForm( )
        {
            InitializeComponent( );

            // Basic Properties
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
            CaptionFont = new Font( "Roboto", 12, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.Red;
            StaticGridLabel.Font = new Font( "Roboto", 9, FontStyle.Bold  );
            StaticGridLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            StaticTableLabel.Font = new Font( "Roboto", 9, FontStyle.Bold  );
            StaticTableLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            StaticColumnLabel.Font = new Font( "Roboto", 9, FontStyle.Bold  );
            StaticColumnLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            StaticValueLabel.Font = new Font( "Roboto", 9, FontStyle.Bold  );
            StaticValueLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            MinimizeBox = false;
            MaximizeBox = false;

            // Event Wiring
            Load += OnLoad;
            TableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            ColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
            ValueListBox.SelectedValueChanged += OnValueListBoxSelectionChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridForm"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public DataGridForm( Source source, Provider provider ) 
            : this( )
        {
            InitializeComponent( );
            Load += OnLoad;
            TableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            ColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
            ValueListBox.SelectedValueChanged += OnValueListBoxSelectionChanged;
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
                FormFilter = new Dictionary<string, object>
                {
                    { "BFY", "2023" },
                    { "FundCode", "B" }
                };

                DataModel = new DataBuilder( Source.StatusOfFunds, Provider.Access, FormFilter );
                BindingSource.DataSource = DataModel.DataTable;
                DataGrid.DataSource = BindingSource;
                PopulateTableListBoxItems( );
                PopulateToolBarDropDownItems( );
                ToolStrip.Office12Mode = true;
                TableLabel.Text = TableListBox.Items.Count.ToString( );
                ColumnLabel.Text = string.Empty;
                ValueLabel.Text = string.Empty;
                DataSourceLabel.Text = DataModel.DataTable.TableName.SplitPascal( );
                SelectedTable = string.Empty;
                SelectedColumn = string.Empty;
                SelectedValue = string.Empty;
                SqlQuery = string.Empty;
                LeftHeaderLabel.Text = string.Empty;
                RightHeaderLabel.Text = string.Empty;
                ToolStripLabel.Text = "Provider: " + DataModel.Provider;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Populates the ListBox items.
        /// </summary>
        public void PopulateTableListBoxItems( )
        {
            try
            {
                TableListBox.Items.Clear( );
                var _names = Enum.GetNames( typeof( Source ) );
                for( var _i = 0; _i < _names?.Length; _i++ )
                {
                    var name = _names[ _i ];
                    if( name != "NS" )
                    {
                        TableListBox.Items.Add( name );
                    }
                }
            }
            catch( Exception ex )
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
                var _names = Enum.GetNames( typeof( SQL ) );
                for( var _i = 0; _i < _names.Length; _i++ )
                {
                    var name = _names[ _i ];

                    if( name != "NS" )
                    {
                        ToolStrip.DropDown?.Items.Add( name );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [table ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnTableListBoxSelectionChanged( object sender )
        {
            try
            {
                FormFilter.Clear( );
                SqlQuery = string.Empty;
                LeftHeaderLabel.Text = string.Empty;
                ColumnListBox.Items.Clear( );
                ValueListBox.Items.Clear( );
                ColumnPanel.Text = string.Empty;
                ValuePanel.Text = string.Empty;
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedValue.ToString( );
                SelectedTable = _value;
                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                    DataSourceLabel.Text = DataModel.DataTable.TableName?.SplitPascal( );
                    var _columns = DataModel.GetDataColumns( );
                    foreach( var col in _columns )
                    {
                        ColumnListBox.Items.Add( col.ColumnName );
                    }

                    ColumnLabel.Text = ColumnListBox.Items.Count.ToString( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [column ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>\
        public void OnColumnListBoxSelectionChanged( object sender )
        {
            try
            {
                ValueListBox.Items.Clear( );
                SqlQuery = string.Empty;
                LeftHeaderLabel.Text = string.Empty;
                var _listBox = sender as ListBox;
                var _column = _listBox?.SelectedValue?.ToString( );
                var _series = DataModel.DataElements;
                if( !string.IsNullOrEmpty( _column ) )
                {
                    SelectedColumn = _column?.Trim( );
                    foreach( var item in _series[ _column ] )
                    {
                        ValueListBox.Items.Add( item );
                    }
                }

                ValueLabel.Text = ValueListBox.Items.Count.ToString( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [value ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnValueListBoxSelectionChanged( object sender )
        {
            try
            {
                SqlQuery = string.Empty;
                LeftHeaderLabel.Text = string.Empty;
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedValue?.ToString( );
                SelectedValue = _value?.Trim( );
                var _query = string.Empty;
                if( !string.IsNullOrEmpty( SelectedTable )
                   & !string.IsNullOrEmpty( SelectedColumn ) )
                {
                    FormFilter.Add( SelectedColumn, SelectedValue );
                    _query = $"SELECT * FROM { SelectedTable } "
                        + $"WHERE { SelectedColumn } = '{ SelectedValue }';";
                }

                SqlQuery = _query;
                LeftHeaderLabel.Text = SqlQuery;
                ValueLabel.Text = ValueListBox.Items.Count.ToString( );
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
// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System;
    using Syncfusion.Windows.Forms;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
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
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size( 1400, 800 );
            MaximumSize = new Size( 1400, 800 );
            MinimumSize = new Size( 1400, 750  );
            FormBorderStyle = FormBorderStyle.Sizable;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            
            // Label Properties
            DataGridLabel.Font = new Font( "Roboto", 8 );
            DataGridLabel.ForeColor = Color.LightGray;
            FirstLabel.Font = new Font( "Roboto", 8 );
            FirstLabel.ForeColor = Color.LightGray;
            SecondLabel.Font = new Font( "Roboto", 8 );
            SecondLabel.ForeColor = Color.LightGray;
            ThirdLabel.Font = new Font( "Roboto", 8 );
            ThirdLabel.ForeColor = Color.LightGray;
            
            // ToolStrip Properties
            ToolStrip.Text = string.Empty;
            ToolStrip.Office12Mode = true;
            ToolStrip.TextBox.ForeColor = Color.LightSteelBlue;
            ToolStrip.TextBox.TextBoxTextAlign = HorizontalAlignment.Center;
            ToolStrip.TextBox.Text = DateTime.Today.ToShortDateString(  );

            // Event Wiring
            ExitButton.Click += null;
            FirstListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            SecondListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
            ThirdListBox.SelectedValueChanged += OnValueListBoxSelectionChanged;
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridForm"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public DataGridForm( Source source, Provider provider ) 
            : this( )
        {
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
                FormFilter = new Dictionary<string, object>( );
                FormFilter.Add( "BFY", "2022" );
                FormFilter.Add( "FundCode", "B" );
                BindDataSource( Source.StatusOfFunds, Provider.Access, FormFilter );
                SetLabelText(  );
                PopulateTableListBoxItems( );
                PopulateToolStripComboBoxItems( );
                ClearSelections(  );
                Text = DataModel.Provider + " Data: " + DataModel.Source.ToString( ).SplitPascal( );
                ExitButton.Click += OnExitButtonClicked;
                SearchButton.Click += OnSearchButtonClicked;
                TestButton.Click += OnTestButtonClicked;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        private void BindDataSource( Source source, Provider provider, IDictionary<string, object> where )
        {
            if( Enum.IsDefined( typeof( Source ), source ) 
               && Enum.IsDefined( typeof( Provider ), provider ) 
               && where?.Any( ) == true )
            {
                try
                {
                    DataModel = new DataBuilder( source, provider, where );
                    BindingSource.DataSource = DataModel.DataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                } 
            } 
        }
        
        /// <summary>
        /// Sets the label configuration.
        /// </summary>
        private void SetLabelText( )
        {
            try
            {
                FirstLabel.Text = "Tables: " + FirstListBox.Items.Count;
                SecondLabel.Text = "Columns: " + SecondListBox.Items?.Count;
                ThirdLabel.Text = "Values: " + ThirdListBox.Items.Count;
                DataGridLabel.Text = "Data Source:  " + DataModel.Source.ToString( ).SplitPascal( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                SelectedTable = string.Empty;
                SelectedColumn = string.Empty;
                SelectedValue = string.Empty;
                SqlQuery = string.Empty;
                if( FormFilter?.Keys?.Count > 0 )
                {
                    FormFilter.Clear( );
                }
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
                FirstListBox.Items.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData(  );
                var _names = _data
                    ?.Where( dr => dr.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.Select( dr => dr.Field<string>( "TableName" ) )
                    ?.ToList(  );
                
                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var name = _names[ _i ];
                    FirstListBox.Items.Add( name );
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
        public void PopulateToolStripComboBoxItems( )
        {
            try
            {
                var _names = Enum.GetNames( typeof( SQL ) );
                for( var _i = 0; _i < _names.Length; _i++ )
                {
                    var name = _names[ _i ];
                    if( name != "NS" )
                    {
                        ComboBox.Items.Add( name );
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
                if( FormFilter?.Keys?.Count > 0 )
                {
                    FormFilter.Clear( );
                }
                
                BindingSource.DataSource = null;
                SqlQuery = string.Empty;
                SecondListBox.Items.Clear( );
                ThirdListBox.Items.Clear( );
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedValue?.ToString( );
                if( !string.IsNullOrEmpty( _value ) )
                {
                    SelectedTable = _value;
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                    SelectedTable = DataModel.DataTable.TableName;
                    var _text = "Data Source:  " + SelectedTable.SplitPascal( );
                    DataGridLabel.Text = _text + DataModel.DataTable.Rows.Count;
                    foreach( var col in DataModel.DataColumns )
                    {
                        SecondListBox.Items?.Add( col?.ColumnName );
                    }
                }
                
                SetLabelText(  );
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
            if( sender is ListBox _listBox )
            {
                try
                {
                    ThirdListBox.Items.Clear( );
                    SqlQuery = string.Empty;
                    var _column = _listBox?.SelectedValue?.ToString( );
                    var _elements = DataModel.DataElements;
                    if( !string.IsNullOrEmpty( _column ) )
                    {
                        SelectedColumn = _column?.Trim( );
                        foreach( var item in _elements[ _column ] )
                        {
                            ThirdListBox.Items.Add( item );
                        }
                    }

                    ThirdLabel.Text = "Values: " + ThirdListBox.Items.Count;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [value ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnValueListBoxSelectionChanged( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    SqlQuery = string.Empty;
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
                    ThirdLabel.Text = "Values: " + ThirdListBox.Items.Count;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [test button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnTestButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _program = new ProgramProjectDialog( );
                _program.ShowDialog(  );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [search button clicked].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnSearchButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _source = DataModel.Source;
                var _provider = DataModel.Provider;
                var _dialog = new FilterDialog( _source, _provider );
                _dialog.ShowDialog( );
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
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnExitButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button 
                   && _button.ToolType == ToolType.ExitButton )
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
        /// Clears the filter selections.
        /// </summary>
        private void ClearFilterSelections( )
        {
            try
            {
                if( FormFilter?.Any( ) == true )
                {
                    FormFilter.Clear(  );
                }
                
                FirstButton.Visible = !FirstButton.Visible;
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
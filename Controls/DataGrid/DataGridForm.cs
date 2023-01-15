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
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBoolCompare" ) ]
    public partial class DataGridForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable { get; set; }

        /// <summary>
        /// Gets or sets the first selected item.
        /// </summary>
        /// <value>
        /// The first selected item.
        /// </value>
        public string FirstCategory { get; set; }

        /// <summary>
        /// Gets or sets the first value.
        /// </summary>
        /// <value>
        /// The first value.
        /// </value>
        public string FirstValue { get; set; }

        /// <summary>
        /// Gets or sets the second selected item.
        /// </summary>
        /// <value>
        /// The second selected item.
        /// </value>
        public string SecondCategory { get; set; }

        /// <summary>
        /// Gets or sets the second value.
        /// </summary>
        /// <value>
        /// The second value.
        /// </value>
        public string SecondValue { get; set; }

        /// <summary>
        /// Gets or sets the third selected item.
        /// </summary>
        /// <value>
        /// The third selected item.
        /// </value>
        public string ThirdCategory { get; set; }

        /// <summary>
        /// Gets or sets the third value.
        /// </summary>
        /// <value>
        /// The third value.
        /// </value>
        public string ThirdValue { get; set; }

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields { get; set; }

        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics { get; set; }

        /// <summary>
        /// Gets or sets the selected columns.
        /// </summary>
        /// <value>
        /// The selected columns.
        /// </value>
        public IList<string> SelectedColumns { get; set; }

        /// <summary>
        /// Gets or sets the selected columns.
        /// </summary>
        /// <value>
        /// The selected columns.
        /// </value>
        public IList<string> SelectedFields { get; set; }

        /// <summary>
        /// Gets or sets the selected columns.
        /// </summary>
        /// <value>
        /// The selected columns.
        /// </value>
        public IList<string> SelectedNumerics { get; set; }

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
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

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
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            FirstHeaderLabel.Font = new Font( "Roboto", 8 );
            FirstHeaderLabel.ForeColor = Color.DarkGray;
            SecondHeaderLabel.Font = new Font( "Roboto", 8 );
            SecondHeaderLabel.ForeColor = Color.DarkGray;
            SecondHeaderLabel.Text = string.Empty;
            ThirdHeaderLabel.Font = new Font( "Roboto", 8 );
            ThirdHeaderLabel.ForeColor = Color.DarkGray;
            ThirdHeaderLabel.Text = string.Empty;
            FourthHeaderLabel.Font = new Font( "Roboto", 8 );
            FourthHeaderLabel.ForeColor = Color.DarkGray;
            FourthHeaderLabel.Text = string.Empty;
            
            // TabPage Properties
            TabControl.ActiveTabForeColor = Color.FromArgb( 20, 20, 20 );
            TableTabPage.TabForeColor = Color.FromArgb( 20, 20, 20 );
            FilterTabPage.TabForeColor = Color.FromArgb( 20, 20, 20 );
            FoldTabPage.TabForeColor = Color.FromArgb( 20, 20, 20 );
            
            // ToolStrip Properties
            ToolStrip.Text = string.Empty;
            ToolStrip.Office12Mode = true;
            ToolStrip.TextBox.ForeColor = Color.LightSteelBlue;
            ToolStrip.TextBox.TextBoxTextAlign = HorizontalAlignment.Center;
            ToolStrip.TextBox.Text = DateTime.Today.ToShortDateString(  );
            
            // RadioButton Properties
            ResetButton.Visible = false;
            FilterButton.Visible = false;
            FoldButton.Visible = false;
            
            // Initialize Default Provider
            Provider = Provider.Access;

            // Event Wiring
            TableListBox.SelectedValueChanged += OnTableListBoxItemSelected;
            ReferenceListBox.SelectedValueChanged += OnTableListBoxItemSelected;
            FirstComboBox.SelectedValueChanged += OnFirstComboBoxItemSelected;
            FirstListBox.SelectedValueChanged += OnFirstListBoxItemSelected;
            SecondComboBox.SelectedValueChanged += OnSecondComboBoxItemSelected;
            SecondListBox.SelectedValueChanged += OnSecondListBoxItemSelected;
            ThirdComboBox.SelectedValueChanged += OnThirdComboBoxItemSelected;
            ThirdListBox.SelectedValueChanged += OnThirdListBoxItemSelected;
            FieldListBox.SelectedValueChanged += OnFieldListBoxSelectedValueChanged;
            NumericListBox.SelectedValueChanged += OnNumericListBoxSelectedValueChanged;
            ExitButton.Click += null;
            MenuButton.Click += null;
            ChartButton.Click += null;
            RemoveFiltersButton.Click += null;
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
            Source = source;
            Provider = provider;
            DataModel = new DataBuilder( source, provider );
            DataTable = DataModel.DataTable;
            BindingSource.DataSource = DataTable;
            Fields = DataModel.Fields;
            Numerics = DataModel.Numerics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridForm"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        public DataGridForm( Source source, Provider provider, IDictionary<string, object> where )
            : this( )
        {
            Source = source;
            Provider = provider;
            FormFilter = where;
            DataModel = new DataBuilder( source, provider, where );
            DataTable = DataModel.DataTable;
            BindingSource.DataSource = DataTable;
            Fields = DataModel.Fields;
            Numerics = DataModel.Numerics;
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
                SelectedColumns = new List<string>( );
                SelectedFields = new List<string>( );
                SelectedNumerics = new List<string>( );
                TableTabPage.TabVisible = true;
                FilterTabPage.TabVisible = false;
                FoldTabPage.TabVisible = false;
                ResetButton.Visible = false;
                FilterButton.Visible = false;
                FoldButton.Visible = false;
                FirstTable.Visible = false;
                SecondTable.Visible = false;
                ThirdTable.Visible = false;
                PopulateTableListBoxItems( );
                PopulateToolStripComboBoxItems( );
                ClearSelections(  );
                ClearHeaderText( );
                ExitButton.Click += OnExitButtonClicked;
                RemoveFiltersButton.Click += OnRemoveFilterButtonClicked;
                SearchButton.Click += OnSearchButtonClicked;
                TestButton.Click += OnTestButtonClicked;
                MenuButton.Click += OnMainMenuButtonClicked;
                ChartButton.Click += OnChartButtonClicked;
                ResetButton.Click += OnResetButtonClicked;
                FilterButton.Click += OnFilterButtonClicked;
                FoldButton.Click += OnFoldButtonClicked;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="where">The where.</param>
        private void BindDataSource( IDictionary<string, object> where )
        {
            if( Enum.IsDefined( typeof( Source ), Source ) 
               && Enum.IsDefined( typeof( Provider ), Provider ) 
               && where?.Any( ) == true )
            {
                try
                {
                    DataModel = new DataBuilder( Source, Provider, where );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                } 
            } 
        }

        /// <summary>
        /// Binds the data source.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        private void BindDataSource( IEnumerable<string> fields, IEnumerable<string> numerics, 
            IDictionary<string, object> where )
        {
            if( Enum.IsDefined( typeof( Source ), Source )
               && Enum.IsDefined( typeof( Provider ), Provider )
               && where?.Any( ) == true
               && fields?.Any( ) == true )
            {
                try
                {
                    DataModel = new DataBuilder( Source, Provider, fields,
                        numerics, where, SQL.SELECT );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Creates the SQL text.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IDictionary<string, object> where )
        {
            if( where?.Any( ) == true )
            {
                try
                {
                    return $"SELECT * FROM { Source } " 
                        + $"WHERE { where.ToCriteria(  ) };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Creates the SQL text.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IEnumerable<string> columns, IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && columns?.Any( ) == true )
            {
                try
                {
                    var _array = columns.ToArray( );
                    var _span = _array.Length;
                    var _cols = string.Empty;
                    var _aggr = string.Empty;
                    var _grp = string.Empty;
                    var _pack = new List<string>( );
                    for( var n = 0; n < _span; n++ )
                    {
                        if( Fields.Contains( _array[ n ] ) )
                        {
                            _cols += $"{ _array[ n ] }, ";
                            _pack.Add( _array[ n ] );
                        }
                        
                        if( Numerics.Contains( _array[ n ] ) )
                        {
                            _grp += $"SUM({ _array[ n ] }), ";
                            _aggr += $"SUM({ _array[ n ] }) AS { _array[ n ] }, ";
                            _pack.Add( _array[ n ] ); 
                        }
                    }
                    
                    var _criteria = where.ToCriteria( );
                    var _columns = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                    var _groups = _cols + _grp.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT DISTINCT { _columns } FROM { Source } "
                        + $"WHERE { _criteria } " + $"GROUP BY { _groups };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }
        
        /// <summary>
        /// Clears the label text.
        /// </summary>
        private void ClearHeaderText( )
        {
            try
            {
                Text = "Database ";
                FirstHeaderLabel.Text = $"Source : ";
                SecondHeaderLabel.Text = string.Empty;
                ThirdHeaderLabel.Text = string.Empty;
                FourthHeaderLabel.Text = string.Empty;
                Header.Text = string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the label configuration.
        /// </summary>
        private void UpdateHeaderText( )
        {
            try
            {
                if( DataTable != null )
                {
                    Text = $"{ Provider } Data ";
                    FirstHeaderLabel.Text = $"Source :  { Source.ToString( ).SplitPascal( ) }";
                    SecondHeaderLabel.Text = $"Records : { DataTable.Rows.Count } ";
                    ThirdHeaderLabel.Text = $"Fields : { Fields.ToArray(  ).Length } ";
                    FourthHeaderLabel.Text = $"Measures : { Numerics.ToArray(  ).Length } ";
                }
                else
                {
                    Text = $"{ Provider } Data ";
                    FirstHeaderLabel.Text = $"Source :  { Source.ToString( ).SplitPascal( ) }";
                    SecondHeaderLabel.Text = $"Records : ";
                    ThirdHeaderLabel.Text = $"Fields : ";
                    FourthHeaderLabel.Text = $"Measures : ";
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Clears the selected filter values.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                SqlQuery = string.Empty;
                if( FormFilter.Keys.Count > 0 )
                {
                    FormFilter.Clear( );
                }

                if( SelectedColumns.Count > 0 )
                {
                    SelectedColumns.Clear( );
                }

                if( !string.IsNullOrEmpty( ThirdValue ) 
                   || ThirdTable.Visible )
                {
                    ThirdComboBox.Items.Clear( );
                    ThirdListBox.Items.Clear( );
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    ThirdTable.Visible = false;
                }

                if( !string.IsNullOrEmpty( SecondValue )
                   || SecondTable.Visible )
                {
                    SecondComboBox.Items.Clear( );
                    SecondListBox.Items.Clear( );
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    SecondTable.Visible = false;
                }

                if( !string.IsNullOrEmpty( FirstValue )
                   || FirstTable.Visible )
                {
                    FirstComboBox.Items.Clear( );
                    FirstListBox.Items.Clear( );
                    FirstCategory = string.Empty;
                    FirstValue = string.Empty;
                    FirstTable.Visible = false;
                }

                ClearHeaderText( );
                DataGrid.DataSource = null;
                TableTabPage.TabVisible = true;
                FilterTabPage.TabVisible = false;
                FoldTabPage.TabVisible = false;
                ResetButton.Visible = false;
                FoldButton.Visible = false;
                FilterButton.Visible = false;
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
        /// Populates the ListBox items.
        /// </summary>
        public void PopulateTableListBoxItems( )
        {
            try
            {
                TableListBox.Items.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData(  );
                var _names = _data
                    ?.Where( dr => dr.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.Select( dr => dr.Field<string>( "TableName" ) )
                    ?.ToList(  );
                
                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var name = _names[ _i ];
                    TableListBox.Items.Add( name );
                }

                var _references = _data
                    ?.Where( dr => dr.Field<string>( "Model" ).Equals( "REFERENCE" ) )
                    ?.Select( dr => dr.Field<string>( "TableName" ) )
                    ?.ToList(  );

                for( var _i = 0; _i < _references?.Count - 1; _i++ )
                {
                    var name = _references[ _i ];
                    ReferenceListBox.Items.Add( name );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [table ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnTableListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    SelectedTable = _listBox.SelectedValue?.ToString( );
                    if( !string.IsNullOrEmpty( SelectedTable ) )
                    {
                        Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
                        DataModel = new DataBuilder( Source, Provider );
                        DataTable = DataModel.DataTable;
                        BindingSource.DataSource = DataModel.DataTable;
                        DataGrid.DataSource = BindingSource;
                        ToolStrip.BindingSource = BindingSource;
                        Fields = DataModel.Fields;
                        Numerics = DataModel.Numerics;
                        TableTabPage.TabVisible = !TableTabPage.TabVisible;
                        FilterTabPage.TabVisible = !FilterTabPage.TabVisible;
                        ResetButton.Visible = !ResetButton.Visible;
                    }

                    UpdateHeaderText( );
                    PopulateFirstComboBoxItems( );
                    if( FirstTable.Visible == false )
                    {
                        FirstTable.Visible = true;
                    }

                    if( SecondTable.Visible == true )
                    {
                        SecondTable.Visible = false;
                    }

                    if( ThirdTable.Visible == true )
                    {
                        ThirdTable.Visible = false;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Populates the first como box items.
        /// </summary>
        public void PopulateFirstComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( FirstComboBox.Items?.Count > 0 )
                    {
                        FirstComboBox.Items.Clear( );
                    }
                    
                    foreach( var item in Fields )
                    {
                        FirstComboBox.Items.Add( item );
                    }

                    if( FirstListBox.Items?.Count > 0 )
                    {
                        FirstListBox.Items.Clear( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [first ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnFirstComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    FirstCategory = string.Empty;
                    FirstValue = string.Empty;
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    if( FirstListBox.Items?.Count > 0 )
                    {
                        FirstListBox.Items.Clear(  );
                    }

                    FirstCategory = _comboBox.SelectedItem?.ToString(  );
                    if( !string.IsNullOrEmpty( FirstCategory ) )
                    {
                        var _data = DataModel.DataElements[ FirstCategory ];
                        foreach( var item in _data )
                        {
                            FirstListBox?.Items?.Add( item );
                        }
                    }

                    if( SecondTable.Visible == true )
                    {
                        SecondTable.Visible = false;
                    }

                    if( ThirdTable.Visible == true )
                    {
                        ThirdTable.Visible = false;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [first item selected].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        public void OnFirstListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    FirstValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    PopulateSecondComboBoxItems( );
                    if( SecondTable.Visible == false )
                    {
                        SecondTable.Visible = true;
                    }

                    if( ThirdTable.Visible == true )
                    {
                        ThirdTable.Visible = false;
                    }

                    BindDataSource( FormFilter );
                    ClearHeaderText( );
                    UpdateHeaderText( );
                    SqlQuery = CreateSqlText( FormFilter );
                    FoldButton.Visible = true;
                    Header.Text = SqlQuery;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Populates the second como box items.
        /// </summary>
        public void PopulateSecondComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( FirstValue ) )
                    {
                        foreach( var item in Fields )
                        {
                            if( !item.Equals( FirstCategory ) )
                            {
                                SecondComboBox.Items.Add( item );
                            }
                        }
                    }
                    else
                    {
                        foreach( var item in Fields )
                        {
                            SecondComboBox.Items.Add( item );
                        }
                    }

                    SecondComboBox.SelectedIndex = -1;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [second item selected].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnSecondComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    if( SecondListBox.Items.Count > 0 )
                    {
                        SecondListBox.Items.Clear(  );
                    }

                    SecondCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( SecondCategory ) )
                    {
                        var _data = DataModel.DataElements[ SecondCategory ];
                        foreach( var item in _data )
                        {
                            SecondListBox.Items.Add( item );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [second ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        public void OnSecondListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys?.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    SecondValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue  );
                    PopulateThirdComboBoxItems(  );
                    if( ThirdTable.Visible  == false )
                    {
                        ThirdTable.Visible = true;
                    }

                    BindDataSource( FormFilter );
                    ClearHeaderText( );
                    UpdateHeaderText( );
                    SqlQuery = CreateSqlText( FormFilter );
                    Header.Text = SqlQuery;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Populates the third como box items.
        /// </summary>
        public void PopulateThirdComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( FirstValue ) 
                       && !string.IsNullOrEmpty( SecondValue ) )
                    {
                        foreach( var item in Fields )
                        {
                            if( !item.Equals( FirstCategory ) 
                               && !item.Equals( SecondCategory ) )
                            {
                                ThirdComboBox.Items.Add( item );
                            }
                        }

                        ThirdComboBox.SelectedIndex = -1;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [third item selected].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnThirdComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    if( ThirdListBox.Items.Count > 0 )
                    {
                        ThirdListBox.Items.Clear(  );
                    }

                    ThirdCategory = _comboBox.SelectedItem?.ToString(  );
                    if( !string.IsNullOrEmpty( ThirdCategory ) )
                    {
                        var _data = DataModel.DataElements[ ThirdCategory ];
                        foreach( var item in _data )
                        {
                            ThirdListBox.Items.Add( item );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [third ListBox item selected].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        public void OnThirdListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    ThirdValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue  );
                    FormFilter.Add( ThirdCategory, ThirdValue );
                    BindDataSource( FormFilter );
                    ClearHeaderText( );
                    UpdateHeaderText( );
                    SqlQuery = CreateSqlText( FormFilter );
                    Header.Text = SqlQuery;
                    TabControl.SelectedTab = FoldTabPage;
                    PopulateFieldListBox( );
                    PopulateNumericListBox( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Populates the column ListBox.
        /// </summary>
        private void PopulateFieldListBox( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    foreach( var _item in Fields )
                    {
                        FieldListBox.Items.Add( _item );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [column ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnFieldListBoxSelectedValueChanged( object sender )
        {
            try
            {
                var _selectedItem = FieldListBox.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedColumns.Add( _selectedItem );
                }
                
                UpdateHeaderText(  );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the numeric ListBox.
        /// </summary>
        private void PopulateNumericListBox( )
        {
            if( Numerics?.Any( ) == true )
            {
                try
                {
                    for( var _i = 0; _i < Numerics.Count; _i++ )
                    {
                        if( !string.IsNullOrEmpty( Numerics[ _i ] ) )
                        {
                            NumericListBox.Items.Add( Numerics[ _i ] );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [numeric ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnNumericListBoxSelectedValueChanged( object sender )
        {
            try
            {
                var _selectedItem = NumericListBox.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedColumns.Add( _selectedItem );
                }
                
                UpdateHeaderText(  );
                SqlQuery = CreateSqlText( SelectedColumns, FormFilter );
                Header.Text = SqlQuery;
            }
            catch( Exception ex )
            {
                Fail( ex );
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
        /// Called when [reset button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnResetButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is Button _filterButton )
                {
                    SelectedColumns.Clear( );
                    FormFilter.Clear( );
                    ClearSelections( );
                    TableTabPage.TabVisible = true;
                    FilterTabPage.TabVisible = false;
                    FoldTabPage.TabVisible = false;
                    FoldButton.Enabled = false;
                    FilterButton.Enabled = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [filter button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnFilterButtonClicked( object sender, EventArgs e )
        { 
            try
            {
                if( sender is Button  )
                {
                    SelectedColumns.Clear( );
                    FormFilter.Clear( );
                    ClearSelections( );
                    FilterTabPage.TabVisible = true;
                    TableTabPage.TabVisible = false;
                    FoldTabPage.TabVisible = false;
                    FoldButton.Enabled = false;
                    ResetButton.Enabled = true;
                    FilterButton.Enabled = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [fold button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnFoldButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is Button  )
                {
                    SelectedColumns.Clear( );
                    FormFilter.Clear( );
                    PopulateFieldListBox( );
                    PopulateNumericListBox( );
                    FoldTabPage.TabVisible = true;
                    FilterTabPage.TabVisible = false;
                    TableTabPage.TabVisible = false;
                    FilterButton.Visible = false;
                    ResetButton.Visible = true;
                    FoldButton.Visible = false;
                }
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
                    Close( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnMainMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.MenuButton )
                {
                    Close( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Called when [remove filter button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnRemoveFilterButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.RemoveFiltersButton )
                {
                    ClearSelections( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [chart button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnChartButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.ChartButton )
                {
                    var _chart = new ChartForm( );
                    _chart.BindingSource = BindingSource;
                    Close( );
                    _chart.Show( );
                }
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
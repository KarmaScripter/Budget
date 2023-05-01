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
    using System.Linq;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "UnusedVariable" )]
    [SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" )]
    [SuppressMessage( "ReSharper", "RedundantBoolCompare" )]
    [SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" )]
    [SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" )]
    [SuppressMessage( "ReSharper", "UnusedParameter.Global" )]
    [SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" )]
    [SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" )]
    [SuppressMessage( "ReSharper", "FunctionComplexityOverflow" )]
    public partial class ChartDataForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// 
        /// The count.
        /// </value>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable { get; set; }

        /// <summary>
        /// Gets or sets the first category.
        /// </summary>
        /// <value>
        /// The first category.
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
        /// Gets or sets the second category.
        /// </summary>
        /// <value>
        /// The second category.
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
        /// Gets or sets the third category.
        /// </summary>
        /// <value>
        /// The third category.
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
        /// Gets or sets the fourth category.
        /// </summary>
        /// <value>
        /// The fourth category.
        /// </value>
        public string FourthCategory { get; set; }

        /// <summary>
        /// Gets or sets the fourth value.
        /// </summary>
        /// <value>
        /// The fourth value.
        /// </value>
        public string FourthValue { get; set; }

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

        /// <summary>
        /// Gets or sets the x axis.
        /// </summary>
        /// <value>
        /// The x axis.
        /// </value>
        public string xAxis { get; set; }

        /// <summary>
        /// Gets or sets the y axis.
        /// </summary>
        /// <value>
        /// The y axis.
        /// </value>
        public IList<string> yValues { get; set; }

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
        /// Gets or sets the selected fields.
        /// </summary>
        /// <value>
        /// The selected fields.
        /// </value>
        public IList<string> SelectedFields { get; set; }

        /// <summary>
        /// Gets or sets the selected numerics.
        /// </summary>
        /// <value>
        /// The selected numerics.
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
        /// Initializes a new instance of the <see cref="ChartDataForm"/> class.
        /// </summary>
        public ChartDataForm( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 2;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = false;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            SizeGripStyle = SizeGripStyle.Auto;
            MinimizeBox = false;
            MaximizeBox = false;

            // Initialize Default Provider
            Provider = Provider.Access;

            // Event Wiring
            ExitButton.Click += null;
            BackButton.Click += null;
            MenuButton.Click += null;
            ExcelButton.Click += null;
            RemoveFiltersButton.Click += null;
            TableButton.Click += null;
            TableListBox.SelectedValueChanged += OnTableListBoxItemSelected;
            FirstComboBox.SelectedValueChanged += OnFirstComboBoxItemSelected;
            FirstListBox.SelectedValueChanged += OnFirstListBoxItemSelected;
            SecondComboBox.SelectedValueChanged += OnSecondComboBoxItemSelected;
            SecondListBox.SelectedValueChanged += OnSecondListBoxItemSelected;
            ThirdComboBox.SelectedValueChanged += OnThirdComboBoxItemSelected;
            ThirdListBox.SelectedValueChanged += OnThirdListBoxItemSelected;
            FieldListBox.SelectedValueChanged += OnFieldListBoxSelectedValueChanged;
            NumericListBox.SelectedValueChanged += OnNumericListBoxSelectedValueChanged;
            TabControl.SelectedIndexChanged += OnActiveTabChanged;
            BackButton.Click += OnBackButtonClicked;
            ExitButton.Click += OnExitButtonClicked;
            MenuButton.Click += OnMainMenuButtonClicked;
            GroupButton.Click += OnGroupButtonClicked;
            RemoveFiltersButton.Click += OnRemoveFiltersButtonClicked;
            ExcelButton.Click += OnExcelExportButtonClicked;
            TableButton.Click += OnTableButtonClick;
            MouseClick += OnRightClick;
            Load += OnLoad;
            Shown += OnShown;
            Closing += OnClose;
        }

        public ChartDataForm( BindingSource bindingSource )
            : this( )
        {
            DataTable = (DataTable)bindingSource.DataSource;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            SelectedTable = DataTable.TableName;
            DataModel = new DataBuilder( Source, Provider );
            BindingSource.DataSource = DataModel.DataTable;
            DataGrid.DataSource = BindingSource;
            Chart.DataSource = BindingSource.DataSource;
            ToolStrip.BindingSource = BindingSource;
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartDataForm"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public ChartDataForm( Source source, Provider provider )
            : this( )
        {
            Source = source;
            Provider = provider;
            DataModel = new DataBuilder( source, provider );
            DataTable = DataModel.DataTable;
            SelectedTable = DataTable.TableName;
            BindingSource.DataSource = DataTable;
            DataGrid.DataSource = BindingSource;
            ToolStrip.BindingSource = BindingSource;
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartDataForm"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        public ChartDataForm( Source source, Provider provider, IDictionary<string, object> where )
            : this( )
        {
            Source = source;
            Provider = provider;
            FormFilter = where;
            DataModel = new DataBuilder( Source, Provider, FormFilter );
            DataTable = DataModel.DataTable;
            SelectedTable = DataTable.TableName;
            BindingSource.DataSource = DataTable;
            DataGrid.DataSource = BindingSource;
            ToolStrip.BindingSource.DataSource = DataTable;
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
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
                SetToolStripProperties( );
                FormFilter = new Dictionary<string, object>( );
                SelectedColumns = new List<string>( );
                SelectedFields = new List<string>( );
                SelectedNumerics = new List<string>( );
                NumericListBox.MultiSelect = true;
                FieldListBox.MultiSelect = true;
                Text = string.Empty;
                ToolStrip.Visible = true;
                SetChartProperties( );
                SetAreaProperties( );
                SetLegendProperties( );
                SetTitleProperties( );
                if( string.IsNullOrEmpty( SelectedTable ) )
                {
                    TabControl.SelectedIndex = 0;
                    TableTabPage.TabVisible = true;
                    FilterTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    PopulateExecutionTables( );
                }
                else if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    TabControl.SelectedIndex = 1;
                    FilterTabPage.TabVisible = true;
                    TableTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    LabelTable.Visible = true;
                    BindChart( );
                    PopulateFirstComboBoxItems( );
                    ResetComboBoxVisibility( );
                    UpdateLabelText( );
                }

                PopulateToolBarDropDownItems( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                    return $"SELECT * FROM {SelectedTable} " + $"WHERE {where.ToCriteria( )};";
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
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && fields?.Any( ) == true
               && numerics?.Any( ) == true )
            {
                try
                {
                    var _cols = string.Empty;
                    var _aggr = string.Empty;
                    foreach( var name in fields )
                    {
                        _cols += $"{name}, ";
                    }

                    foreach( var metric in numerics )
                    {
                        _aggr += $"SUM({metric}) AS {metric}, ";
                    }

                    var _groups = _cols.TrimEnd( ", ".ToCharArray( ) );
                    var _criteria = where.ToCriteria( );
                    var _columns = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_columns} FROM {Source} " + $"WHERE {_criteria} "
                        + $"GROUP BY {_groups};";
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
        private string CreateSqlText( IEnumerable<string> columns,
            IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && columns?.Any( ) == true )
            {
                try
                {
                    var _cols = string.Empty;
                    foreach( var name in columns )
                    {
                        _cols += $"{name}, ";
                    }

                    var _criteria = where.ToCriteria( );
                    var _names = _cols.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_names} FROM {Source} " + $"WHERE {_criteria} "
                        + $"GROUP BY {_names};";
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
        /// Binds the data source.
        /// </summary>
        /// <param name="sqlText">The SQL text.</param>
        private void ResetData( string sqlText )
        {
            if( !string.IsNullOrEmpty( sqlText ) )
            {
                try
                {
                    SqlQuery = sqlText;
                    DataModel = new DataBuilder( Source, Provider, SqlQuery );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataModel?.DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel?.Fields;
                    Numerics = DataModel?.Numerics;
                    Chart.Series[ 0 ].Points.Clear( );
                    Chart.ChartAreas[ 0 ].RecalculateAxesScale( );
                    Chart.DataSource = DataTable;
                    Chart.Series[ 0 ].XValueMember = DataTable.Columns[ 0 ].ColumnName;
                    Chart.Series[ 0 ].IsXValueIndexed = true;
                    Chart.Series[ 0 ].YValueMembers = Numerics.First( );
                    SetSeriesProperties( );
                    Chart.Titles[ 0 ].Text = SelectedTable.SplitPascal( );
                    Chart.Update( );
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
        /// <param name="where">The where.</param>
        private void ResetData( IDictionary<string, object> where )
        {
            if( where?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    Chart.Series[ 0 ].Points.Clear( );
                    Chart.ChartAreas[ 0 ].RecalculateAxesScale( );
                    Chart.DataSource = DataTable;
                    Chart.Series[ 0 ].XValueMember = DataTable.Columns[ 0 ].ColumnName;
                    Chart.Series[ 0 ].IsXValueIndexed = true;
                    Chart.Series[ 0 ].YValueMembers = Numerics.First( );
                    SetSeriesProperties( );
                    Chart.Titles[ 0 ].Text = SelectedTable.SplitPascal( );
                    Chart.Update( );
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
        /// <param name="cols">The cols.</param>
        /// <param name="where">The where.</param>
        private void ResetData( IEnumerable<string> cols, IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && cols?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( cols, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    Chart.Series[ 0 ].Points.Clear( );
                    Chart.ChartAreas[ 0 ].RecalculateAxesScale( );
                    Chart.DataSource = DataTable;
                    Chart.Series[ 0 ].XValueMember = DataTable.Columns[ 0 ].ColumnName;
                    Chart.Series[ 0 ].IsXValueIndexed = true;
                    Chart.Series[ 0 ].YValueMembers = Numerics.First( );
                    SetSeriesProperties( );
                    Chart.Titles[ 0 ].Text = SelectedTable.SplitPascal( );
                    Chart.Update( );
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
        private void ResetData( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && numerics?.Any( ) == true
               && fields?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( fields, numerics, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    Chart.Series[ 0 ].Points.Clear( );
                    Chart.ChartAreas[ 0 ].RecalculateAxesScale( );
                    Chart.DataSource = DataTable;
                    SetSeriesProperties( );
                    Chart.Series[ 0 ].XValueMember = Fields.Last( );
                    Chart.Series[ 0 ].IsXValueIndexed = true;
                    Chart.Series[ 0 ].YValueMembers = Numerics.First( );
                    Chart.Titles[ 0 ].Text = SelectedTable.SplitPascal( );
                    Chart.Update( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Binds the chart.
        /// </summary>
        private void BindChart( )
        {
            try
            {
                if( SelectedFields?.Any( ) == true
                   && SelectedNumerics?.Any( ) == true )
                {
                    Chart.Series[ 0 ].Points.Clear( );
                    Chart.ChartAreas[ 0 ].RecalculateAxesScale( );
                    Chart.DataSource = DataTable;
                    Chart.Series[ 0 ].XValueMember = SelectedFields.Last( );
                    Chart.Series[ 0 ].YValueMembers = SelectedNumerics.First( );
                    SetSeriesProperties( );
                    Chart.Titles[ 0 ].Text = SelectedTable.SplitPascal( );
                    Chart.Update( );
                }
                else
                {
                    Chart.Series[ 0 ].Points.Clear( );
                    Chart.ChartAreas[ 0 ].RecalculateAxesScale( );
                    Chart.DataSource = DataTable;
                    Chart.Series[ 0 ].XValueMember = DataTable.Columns[ 0 ].ColumnName;
                    Chart.Series[ 0 ].IsXValueIndexed = true;
                    Chart.Series[ 0 ].YValueMembers = Numerics.First( );
                    SetSeriesProperties( );
                    Chart.Titles[ 0 ].Text = SelectedTable.SplitPascal( );
                    Chart.Update( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [active tab changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnActiveTabChanged( object sender, EventArgs e )
        {
            try
            {
                switch( TabControl.SelectedIndex )
                {
                    case 0:
                    {
                        ClearSelections( );
                        ClearCollections( );
                        TableTabPage.TabVisible = true;
                        FilterTabPage.TabVisible = false;
                        GroupTabPage.TabVisible = false;
                        PopulateExecutionTables( );
                        break;
                    }
                    case 1:
                    {
                        TableTabPage.TabVisible = false;
                        FilterTabPage.TabVisible = true;
                        GroupTabPage.TabVisible = false;
                        PopulateFirstComboBoxItems( );
                        ResetComboBoxVisibility( );
                        break;
                    }
                    case 2:
                    {
                        TableTabPage.TabVisible = false;
                        FilterTabPage.TabVisible = false;
                        GroupTabPage.TabVisible = true;
                        PopulateFieldListBox( );
                        PopulateNumericListBox( );
                        break;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Updates the label text.
        /// </summary>
        private void UpdateLabelText( )
        {
            try
            {
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    var _table = SelectedTable?.SplitPascal( ) ?? string.Empty;
                    var _records = DataTable.Rows?.Count.ToString( "#,###" ) ?? "0";
                    var _filters = FormFilter.Keys?.Count;
                    var _fields = Fields?.Count ?? 0;
                    var _numerics = Numerics?.Count ?? 0;
                    var _selectedFields = SelectedFields?.Count ?? 0;
                    var _selectedNumerics = SelectedNumerics?.Count ?? 0;
                    FirstDataLabel.Text = $"Data Records:  {_records}";
                    SecondDataLabel.Text = $"Total Fields:  {_fields}";
                    ThirdDataLabel.Text = $"Total Measures:  {_numerics}";
                    FourthDataLabel.Text = $"Active Filters:  {_filters}";
                    FifthDataLabel.Text = $"Selected Fields:  {_selectedFields}";
                    SixthDataLabel.Text = $"Selected Measures:  {_selectedNumerics}";
                    SeventhDataLabel.Text = string.Empty;
                    EightDataLabel.Text = string.Empty;
                    NinthDataLabel.Text = string.Empty;
                }
                else
                {
                    FirstDataLabel.Text = "Data Records: 0.0";
                    SecondDataLabel.Text = "Total Fields: 0.0";
                    ThirdDataLabel.Text = "Total Measures: 0.0";
                    FourthDataLabel.Text = "Active Filters: 0.0";
                    FifthDataLabel.Text = "Selected Fields: 0.0";
                    SixthDataLabel.Text = "Selected Measures: 0.0";
                    SeventhDataLabel.Text = string.Empty;
                    EightDataLabel.Text = string.Empty;
                    NinthDataLabel.Text = string.Empty;
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
        private void PopulateToolBarDropDownItems( )
        {
            try
            {
                DropDown.Items.Clear( );
                var _names = Enum.GetNames( typeof( SeriesChartType ) );
                for( var i = 0; i < _names.Length; i++ )
                {
                    var name = _names[ i ];
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
        /// Populates the first ComboBox items.
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

                    if( FirstListBox.Items?.Count > 0 )
                    {
                        FirstListBox.Items?.Clear( );
                    }

                    foreach( var item in Fields )
                    {
                        FirstComboBox.Items?.Add( item );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Populates the second ComboBox items.
        /// </summary>
        public void PopulateSecondComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( SecondComboBox.Items?.Count > 0 )
                    {
                        SecondComboBox.Items.Clear( );
                    }

                    if( SecondListBox.Items?.Count > 0 )
                    {
                        SecondListBox.Items?.Clear( );
                    }

                    if( !string.IsNullOrEmpty( FirstValue ) )
                    {
                        foreach( var item in Fields )
                        {
                            if( !item.Equals( FirstCategory ) )
                            {
                                SecondComboBox.Items?.Add( item );
                            }
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
        /// Populates the third ComboBox items.
        /// </summary>
        public void PopulateThirdComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( ThirdComboBox.Items?.Count > 0 )
                    {
                        ThirdComboBox.Items.Clear( );
                    }

                    if( ThirdListBox.Items?.Count > 0 )
                    {
                        ThirdListBox.Items?.Clear( );
                    }

                    if( !string.IsNullOrEmpty( FirstValue )
                       && !string.IsNullOrEmpty( SecondValue ) )
                    {
                        foreach( var item in Fields )
                        {
                            if( !item.Equals( FirstCategory )
                               && !item.Equals( SecondCategory ) )
                            {
                                ThirdComboBox.Items?.Add( item );
                            }
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
        /// Populates the execution tables.
        /// </summary>
        private void PopulateExecutionTables( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data?.Where( r => r.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.OrderBy( r => r.Field<string>( "Title" ) )
                    ?.Select( r => r.Field<string>( "Title" ) )?.ToList( );

                if( _names?.Any( ) == true )
                {
                    foreach( var name in _names )
                    {
                        TableListBox.Items?.Add( name );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the field ListBox.
        /// </summary>
        private void PopulateFieldListBox( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( FieldListBox.Items.Count > 0 )
                    {
                        FieldListBox.Items.Clear( );
                    }

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
        /// Populates the numeric ListBox.
        /// </summary>
        private void PopulateNumericListBox( )
        {
            if( Numerics?.Any( ) == true )
            {
                try
                {
                    if( NumericListBox.Items.Count > 0 )
                    {
                        NumericListBox.Items.Clear( );
                    }

                    for( var i = 0; i < Numerics.Count; i++ )
                    {
                        if( !string.IsNullOrEmpty( Numerics[ i ] ) )
                        {
                            NumericListBox.Items.Add( Numerics[ i ] );
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
        /// Opens the main form.
        /// </summary>
        private void OpenMainForm( )
        {
            try
            {
                if( Owner != null
                   && Owner.Visible == false
                   && Owner.GetType( ) == typeof( MainForm ) )
                {
                    Owner.Visible = true;
                    Close( );
                }
                else if( Owner != null
                        && Owner.Visible == false
                        && Owner.GetType( ) != typeof( MainForm ) )
                {
                    var _mainForm = Program.Windows[ "Main" ];
                    _mainForm.Refresh( );
                    _mainForm.Visible = true;
                    Owner.Close( );
                    Close( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Opens the excel data form.
        /// </summary>
        private void OpenExcelDataForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( _forms?.Any( f => f.GetType( ) == typeof( ExcelDataForm ) ) == true )
                {
                    var _excelDataForm = _forms
                        ?.Where( f => f.GetType( ) == typeof( ExcelDataForm ) == true )?.First( );

                    _excelDataForm.Visible = true;
                }
                else
                {
                    var _excelDataForm = new ExcelDataForm( BindingSource );
                    _excelDataForm.Owner = this;
                    _excelDataForm.Show( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Opens the data grid form.
        /// </summary>
        private void OpenDataGridForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( _forms?.Any( f => f.GetType( ) == typeof( DataGridForm ) ) == true )
                {
                    var _dataGridForm = _forms
                        ?.Where( f => f.GetType( ) == typeof( DataGridForm ) == true )?.First( );

                    _dataGridForm.Visible = true;
                }
                else
                {
                    var _dataGridForm = new DataGridForm( BindingSource );
                    _dataGridForm.Owner = this;
                    _dataGridForm.Show( );
                }
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
                if( FormFilter.Keys.Count > 0 )
                {
                    FormFilter.Clear( );
                }

                FourthCategory = string.Empty;
                FourthValue = string.Empty;
                ThirdCategory = string.Empty;
                ThirdValue = string.Empty;
                SecondCategory = string.Empty;
                SecondValue = string.Empty;
                FirstCategory = string.Empty;
                FirstValue = string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Clears the collections.
        /// </summary>
        private void ClearCollections( )
        {
            try
            {
                if( SelectedColumns?.Any( ) == true )
                {
                    SelectedColumns.Clear( );
                }

                if( SelectedFields?.Any( ) == true )
                {
                    SelectedFields.Clear( );
                }

                if( SelectedNumerics?.Any( ) == true )
                {
                    SelectedNumerics.Clear( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Resets the ComboBox visibility.
        /// </summary>
        private void ResetComboBoxVisibility( )
        {
            try
            {
                if( FirstTable?.Visible == false )
                {
                    FirstTable.Visible = true;
                }

                if( SecondTable?.Visible == true )
                {
                    SecondTable.Visible = false;
                }

                if( ThirdTable?.Visible == true )
                {
                    ThirdTable.Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tool strip properties.
        /// </summary>
        private void SetToolStripProperties( )
        {
            try
            {
                ToolStrip.Visible = true;
                ToolStrip.Text = string.Empty;
                ToolStrip.Office12Mode = true;
                ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
                ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                ToolStrip.LauncherStyle = LauncherStyle.Office12;
                ToolStrip.ImageSize = new Size( 16, 16 );
                ToolStrip.ImageScalingSize = new Size( 16, 16 );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the chart title.
        /// </summary>
        private void SetTitleText( )
        {
            try
            {
                Chart.Titles[ 0 ].Text = string.Empty;
                var _text = DataTable?.TableName?.SplitPascal( );
                if( !string.IsNullOrEmpty( _text ) )
                {
                    Chart.Titles[ 0 ].Text = _text;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the chart properties.
        /// </summary>
        private void SetChartProperties( )
        {
            try
            {
                Chart.BackColor = Color.FromArgb( 20, 20, 20 );
                Chart.BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
                Chart.ForeColor = Color.White;
                Chart.BorderlineColor = Color.FromArgb( 20, 20, 20 );
                Chart.BorderSkin.BackColor = Color.FromArgb( 20, 20, 20 );
                Chart.BorderSkin.BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
                Chart.BorderSkin.PageColor = Color.FromArgb( 20, 20, 20 );
                Chart.BorderSkin.BorderColor = Color.FromArgb( 20, 20, 20 );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the axis titles.
        /// </summary>
        /// <param name="xTitle">The xaxis.</param>
        /// <param name="yTitle">The yaxis.</param>
        private void SetAxisTitles( string xTitle, string yTitle )
        {
            if( !string.IsNullOrEmpty( xTitle )
               && !string.IsNullOrEmpty( yTitle ) )
            {
                try
                {
                    Chart.ChartAreas[ 0 ].AxisX.Title = xTitle;
                    Chart.ChartAreas[ 0 ].AxisY.Title = yTitle;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the area properties.
        /// </summary>
        private void SetAreaProperties( )
        {
            try
            {
                var _black = Color.FromArgb( 20, 20, 20 );
                var _gray = Color.FromArgb( 65, 65, 65 );
                var _transparent = Color.Transparent;
                var _blue = Color.FromArgb( 0, 120, 212 );
                var _shadow = Color.FromArgb( 24, 47, 66 );

                // General Area Properties
                Chart.ChartAreas[ 0 ].BackColor = _black;
                Chart.ChartAreas[ 0 ].Area3DStyle.Enable3D = true;
                Chart.ChartAreas[ 0 ].BorderColor = _shadow;
                Chart.ChartAreas[ 0 ].BackSecondaryColor = _black;
                Chart.ChartAreas[ 0 ].Area3DStyle.PointDepth = 150;
                Chart.ChartAreas[ 0 ].Area3DStyle.Inclination = 35;

                // Horizontal Axis Properties
                Chart.ChartAreas[ 0 ].AxisX.IsLabelAutoFit = true;
                Chart.ChartAreas[ 0 ].AxisX.InterlacedColor = _transparent;
                Chart.ChartAreas[ 0 ].AxisX.LineColor = _shadow;
                Chart.ChartAreas[ 0 ].AxisX.TitleFont = new Font( "Roboto", 7 );
                Chart.ChartAreas[ 0 ].AxisX.TitleForeColor = _blue;
                Chart.ChartAreas[ 0 ].AxisX.LabelStyle.Font = new Font( "Roboto", 7 );
                Chart.ChartAreas[ 0 ].AxisX.LabelStyle.ForeColor = _blue;
                Chart.ChartAreas[ 0 ].AxisX.MajorGrid.LineColor = _shadow;
                Chart.ChartAreas[ 0 ].AxisX.MinorGrid.LineColor = _gray;
                Chart.ChartAreas[ 0 ].AxisX.TextOrientation = TextOrientation.Auto;
                Chart.ChartAreas[ 0 ].AxisX.IsLabelAutoFit = true;

                // Vertical Axis Properties
                Chart.ChartAreas[ 0 ].AxisY.IsLabelAutoFit = true;
                Chart.ChartAreas[ 0 ].AxisY.InterlacedColor = _transparent;
                Chart.ChartAreas[ 0 ].AxisY.LineColor = _shadow;
                Chart.ChartAreas[ 0 ].AxisY.TitleFont = new Font( "Roboto", 7 );
                Chart.ChartAreas[ 0 ].AxisY.TitleForeColor = _blue;
                Chart.ChartAreas[ 0 ].AxisY.LabelStyle.Font = new Font( "Roboto", 7 );
                Chart.ChartAreas[ 0 ].AxisY.LabelStyle.Format = "#,";
                Chart.ChartAreas[ 0 ].AxisY.LabelStyle.ForeColor = _blue;
                Chart.ChartAreas[ 0 ].AxisY.MajorGrid.LineColor = _shadow;
                Chart.ChartAreas[ 0 ].AxisY.MinorGrid.LineColor = _gray;
                Chart.ChartAreas[ 0 ].AxisY.TextOrientation = TextOrientation.Auto;
                Chart.ChartAreas[ 0 ].AxisY.IsLabelAutoFit = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the title properties.
        /// </summary>
        private void SetTitleProperties( )
        {
            try
            {
                Chart.Titles[ 0 ].Font = new Font( "Roboto", 10 );
                Chart.Titles[ 0 ].BackColor = Color.FromArgb( 20, 20, 20 );
                Chart.Titles[ 0 ].BorderColor = Color.FromArgb( 20, 20, 20 );
                Chart.Titles[ 0 ].ForeColor = Color.FromArgb( 0, 120, 212 );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the legend properties.
        /// </summary>
        private void SetLegendProperties( int i = 0, bool enabled = false )
        {
            try
            {
                Chart.Legends[ i ].HeaderSeparatorColor = Color.FromArgb( 20, 20, 20 );
                Chart.Legends[ i ].ItemColumnSeparatorColor = Color.FromArgb( 20, 20, 20 );
                Chart.Legends[ i ].BorderColor = Color.FromArgb( 20, 20, 20 );
                Chart.Legends[ i ].TitleFont = new Font( "Roboto", 7 );
                Chart.Legends[ i ].TitleForeColor = Color.FromArgb( 0, 120, 212 );
                Chart.Legends[ i ].TitleBackColor = Color.FromArgb( 20, 20, 20 );
                Chart.Legends[ i ].Enabled = enabled;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Initializes the series.
        /// </summary>
        private void SetSeriesProperties( int i = 0 )
        {
            try
            {
                Chart.Series[ i ].ChartType = SeriesChartType.Column;
                Chart.Series[ i ].IsValueShownAsLabel = true;
                Chart.Series[ i ].IsVisibleInLegend = true;
                Chart.Series[ i ].LabelBorderColor = Color.Transparent;
                Chart.Series[ i ].LabelBackColor = Color.Transparent;
                Chart.Series[ i ].LabelForeColor = Color.White;
                Chart.Series[ i ].LabelFormat = "N0";
                Chart.Series[ i ].MarkerColor = Color.Yellow;
                Chart.Series[ i ].MarkerStyle = MarkerStyle.Triangle;
                Chart.Series[ i ].Font = new Font( "Roboto", 7 );
                Chart.Series[ i ].XValueType = ChartValueType.Auto;
                Chart.Series[ i ].YValueType = ChartValueType.Auto;
                Chart.Series[ i ].SmartLabelStyle.CalloutBackColor = Color.Transparent;
                Chart.Series[ i ].SmartLabelStyle.CalloutLineColor = Color.FromArgb( 65, 65, 65 );
                Chart.Series[ i ].SmartLabelStyle.CalloutStyle = LabelCalloutStyle.Underlined;
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
                    FormFilter.Clear( );
                    var _title = _listBox.SelectedValue?.ToString( );
                    SelectedTable = _title?.Replace( " ", "" );
                    if( !string.IsNullOrEmpty( SelectedTable ) )
                    {
                        Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
                        DataModel = new DataBuilder( Source, Provider );
                        DataTable = DataModel.DataTable;
                        BindingSource.DataSource = DataModel.DataTable;
                        ToolStrip.BindingSource = BindingSource;
                        Fields = DataModel.Fields;
                        Numerics = DataModel.Numerics;
                        TabControl.SelectedIndex = 1;
                    }

                    UpdateLabelText( );
                    PopulateFirstComboBoxItems( );
                    ResetComboBoxVisibility( );
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
        private void OnFirstComboBoxItemSelected( object sender, EventArgs e )
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
                    FirstListBox.Items.Clear( );
                    FirstCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( FirstCategory ) )
                    {
                        var _data = DataModel.DataElements[ FirstCategory ];
                        foreach( var item in _data )
                        {
                            FirstListBox.Items?.Add( item );
                        }
                    }

                    SecondTable.Visible = false;
                    ThirdTable.Visible = false;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [first ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnFirstListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Count > 0 )
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

                    if( GroupButton.Visible == false )
                    {
                        GroupButton.Visible = true;
                    }

                    ResetData( FormFilter );
                    UpdateLabelText( );
                    SqlQuery = CreateSqlText( FormFilter );
                    SqlHeader.Text = SqlQuery;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [second ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
                    if( SecondListBox.Items?.Count > 0 )
                    {
                        SecondListBox.Items?.Clear( );
                    }

                    SecondCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( SecondCategory ) )
                    {
                        var _data = DataModel.DataElements[ SecondCategory ];
                        foreach( var item in _data )
                        {
                            SecondListBox.Items?.Add( item );
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
        /// <param name="sender">The sender.</param>
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
                    FormFilter.Add( SecondCategory, SecondValue );
                    PopulateThirdComboBoxItems( );
                    if( ThirdTable.Visible == false )
                    {
                        ThirdTable.Visible = true;
                    }

                    ResetData( FormFilter );
                    UpdateLabelText( );
                    SqlQuery = CreateSqlText( FormFilter );
                    SqlHeader.Text = SqlQuery;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [third ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnThirdComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    if( ThirdListBox.Items?.Count > 0 )
                    {
                        ThirdListBox.Items?.Clear( );
                    }

                    ThirdCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( ThirdCategory ) )
                    {
                        var _data = DataModel?.DataElements[ ThirdCategory ];
                        if( _data?.Any( ) == true )
                        {
                            foreach( var item in _data )
                            {
                                ThirdListBox.Items?.Add( item );
                            }
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
        /// <param name="sender">The sender.</param>
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

                    if( FieldListBox.Items.Count > 0 )
                    {
                        FieldListBox.Items.Clear( );
                    }

                    ThirdValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue );
                    FormFilter.Add( ThirdCategory, ThirdValue );
                    ResetData( FormFilter );
                    UpdateLabelText( );
                    SqlQuery = CreateSqlText( FormFilter );
                    SqlHeader.Text = SqlQuery;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [field ListBox selected value changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnFieldListBoxSelectedValueChanged( object sender )
        {
            try
            {
                var _selectedItem = FieldListBox.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedFields.Add( _selectedItem );
                    SelectedColumns.Add( _selectedItem );
                }

                SqlQuery = CreateSqlText( SelectedColumns, FormFilter );
                SqlHeader.Text = SqlQuery;
                UpdateLabelText( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [numeric ListBox selected value changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnNumericListBoxSelectedValueChanged( object sender )
        {
            try
            {
                SelectedNumerics.Clear( );
                var _selectedItem = NumericListBox?.SelectedText;
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedNumerics.Add( _selectedItem );
                }

                SqlQuery = CreateSqlText( SelectedFields, SelectedNumerics, FormFilter );
                SqlHeader.Text = SqlQuery;
                ResetData( SelectedFields, SelectedNumerics, FormFilter );
                UpdateLabelText( );
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
        public void OnExitButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Application.Exit( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [main menu button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnMainMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                OpenMainForm( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [refresh data button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnRefreshDataButtonClicked( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 0;
                SelectedTable = string.Empty;
                BindingSource.DataSource = null;
                ClearSelections( );
                ClearCollections( );
                UpdateLabelText( );
                PopulateExecutionTables( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [group button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnGroupButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( FormFilter.Count > 0 )
                {
                    TabControl.SelectedIndex = 2;
                    PopulateFieldListBox( );
                    PopulateNumericListBox( );
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
        public void OnRemoveFiltersButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    ClearSelections( );
                    ClearCollections( );
                    DataModel = new DataBuilder( Source, Provider );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    TabControl.SelectedIndex = 1;
                    BindChart( );
                    UpdateLabelText( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [table button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTableButtonClick( object sender, EventArgs e )
        {
            try
            {
                OpenDataGridForm( );
                Visible = false;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [excel export button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnExcelExportButtonClicked( object sender, EventArgs e )
        {
            try
            {
                OpenExcelDataForm( );
                Visible = false;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    ContextMenu.Show( this, e.Location );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [back button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnBackButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( Owner != null
                   && Owner.Visible == false )
                {
                    Owner.Visible = true;
                    Owner.Refresh( );
                    ClearSelections( );
                    ClearCollections( );
                    SelectedTable = string.Empty;
                    Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [binding source changed].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/> instance
        /// containing the event data.
        /// </param>
        public void OnBindingSourceChanged( object sender, EventArgs e )
        {
            if( sender is BindingSource bindingSource )
            {
                try
                {
                    var _curIndex = bindingSource.CurrencyManager.Position;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [shown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnShown( object sender, EventArgs e )
        {
            try
            {
                if( !Program.Windows.ContainsKey( Name ) )
                {
                    Program.Windows.Add( Name, this );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Raises the Close event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnClose( object sender, EventArgs e )
        {
            try
            {
                if( Program.Windows.ContainsKey( Name ) )
                {
                    Program.Windows.Remove( Name );
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
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
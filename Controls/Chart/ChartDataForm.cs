// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using DocumentFormat.OpenXml.Drawing.Charts;
    using Syncfusion.Data.Extensions;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.Tools;
    using DataTable = System.Data.DataTable;
    using Size = System.Drawing.Size;

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
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public partial class ChartDataForm : MetroForm, IChartSeriesModel
    {
        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
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
        /// Occurs when [changed].
        /// </summary>
        public event ListChangedEventHandler Changed;

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
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
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

            // Initialize Default Provider
            Provider = Provider.Access;

            // Event Wiring
            ExitButton.Click += null;
            BackButton.Click += null;
            MenuButton.Click += null;
            RemoveFiltersButton.Click += null;
            TableButton.Click += null;
            MouseClick += OnRightClick;
            Load += OnLoad;
        }

        public ChartDataForm( BindingSource bindingSource )
            : this( )
        {
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            SelectedTable = DataTable.TableName;
            DataModel = new DataBuilder( Source, Provider );
            BindingSource.DataSource = DataModel.DataTable;
            ToolStrip.BindingSource = bindingSource;
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
                ClearLabelText( );
                SetToolStripProperties( );
                FormFilter = new Dictionary<string, object>( );
                SelectedColumns = new List<string>( );
                SelectedFields = new List<string>( );
                SelectedNumerics = new List<string>( );
                if( string.IsNullOrEmpty( SelectedTable ) )
                {
                    TabControl.SelectedIndex = 0;
                    TableTabPage.TabVisible = true;
                    FilterTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    Chart.Title.Font = new Font( "Roboto", 14, FontStyle.Bold );
                    Chart.Title.Text = "Select Data Table";
                    PopulateExecutionTables( );
                }
                else if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    TabControl.SelectedIndex = 1;
                    FilterTabPage.TabVisible = true;
                    TableTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    LabelTable.Visible = true;
                    Chart.Title.Font = new Font( "Roboto", 9 );
                    Chart.Title.Text = $"{SelectedTable.SplitPascal( )}";
                    PopulateFirstComboBoxItems( );
                    ResetComboBoxVisibility( );
                    UpdateLabelText( );
                }

                PopulateToolBarDropDownItems( );
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
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the y.
        /// </summary>
        /// <param name="xIndex">The xIndex.</param>
        /// <returns></returns>
        public double[ ] GetY( int xIndex )
        {
            try
            {
                var _row = DataTable.Rows[ xIndex ];
                var _values = new List<double>( );
                foreach( var num in SelectedNumerics )
                {
                    var _col = _row[ num ].ToString( );
                    if( !string.IsNullOrEmpty( _col ) )
                    {
                        var _val = double.Parse( _col );
                        _values.Add( _val );
                    }
                }

                return _values?.Any( ) == true
                    ? _values.ToArray( )
                    : default( double[ ] );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( double[ ] );
            }
        }

        /// <summary>
        /// Gets the x.
        /// </summary>
        /// <param name="xIndex">The xIndex.</param>
        /// <returns></returns>
        public double GetX( int xIndex )
        {
            try
            {
                var _row = DataTable.Rows[ xIndex ];
                var _col = _row[ xIndex ].ToString( );
                if( !string.IsNullOrEmpty( _col ) )
                {
                    var _val = double.Parse( _col );
                    return _val;
                }

                return default( double );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( double );
            }
        }

        /// <summary>
        /// Gets the empty.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool GetEmpty( int index )
        {
            try
            {
                return false;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
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
                    return $"SELECT * FROM {Source} "
                        + $"WHERE {where.ToCriteria( )};";
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
                    return $"SELECT {_columns} FROM {Source} "
                        + $"WHERE {_criteria} "
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
                    DataTable = DataModel?.DataTable;
                    BindingSource.DataSource = DataModel?.DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel?.Fields;
                    Numerics = DataModel?.Numerics;
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
                    var _series = new ChartSeries( );
                    for( var i = 0; i < DataTable.Rows.Count; i++ )
                    {
                        var _list = new List<double>( );
                        var _point = new ChartPoint( );
                        _point.X = (double)i;
                        foreach( var num in numerics )
                        {
                            var _value = DataTable.Rows[ i ][ num ].ToString( );
                            _list.Add( double.Parse( _value ) );
                        }
                        
                        _series.Points.Add( _point );
                        Chart.Series.Add( _series );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Initializes the series.
        /// </summary>
        /// <param name="series">The series.</param>
        protected void InitSeries( ChartSeries series )
        {
            if( series != null )
            {
                try
                {
                    // Basic Properties
                    series.SmartLabels = true;
                    series.Visible = true;
                    series.ShowTicks = true;
                    series.Rotate = true;
                    series.EnableAreaToolTip = true;
                    series.EnableStyles = true;
                    series.OptimizePiePointPositions = true;
                    series.LegendItemUseSeriesStyle = true;
                    series.SmartLabelsBorderColor = Color.FromArgb( 0, 120, 212 );
                    series.SmartLabelsBorderWidth = 1;

                    // Call out Properties
                    series.Style.DisplayText = true;
                    series.Style.Callout.Enable = true;
                    series.Style.Callout.Position = LabelPosition.Top;
                    series.Style.Callout.DisplayTextAndFormat = "{0} : {2}";
                    series.Style.Callout.Border.Color = Color.FromArgb( 0, 120, 212 );
                    series.Style.Callout.Color = Color.FromArgb( 55, 55, 55 );
                    series.Style.Callout.TextColor = Color.FromArgb( 0, 120, 212 );
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
            if( SelectedFields?.Any( ) == true
               && SelectedNumerics?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( SelectedFields, SelectedNumerics, FormFilter );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
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
                        SelectedTable = string.Empty;
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
                        SelectedFields.Clear( );
                        SelectedNumerics.Clear( );
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
        /// Clears the label text.
        /// </summary>
        private void ClearLabelText( )
        {
            try
            {
                Text = string.Empty;
                FirstDataLabel.Text = string.Empty;
                SecondDataLabel.Text = string.Empty;
                ThirdDataLabel.Text = string.Empty;
                FourthDataLabel.Text = string.Empty;
                FifthDataLabel.Text = string.Empty;
                SixthDataLabel.Text = string.Empty;
                SeventhDataLabel.Text = string.Empty;
                EightDataLabel.Text = string.Empty;
                NinthDataLabel.Text = string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the label text.
        /// </summary>
        private void ResetLabelText( )
        {
            try
            {
                FirstDataLabel.Text = "Data Records: 0.0";
                SecondDataLabel.Text = "Total Fields: 0.0";
                ThirdDataLabel.Text = "Total Measures: 0.0";
                FourthDataLabel.Text = "Active Filters: 0.0";
                FifthDataLabel.Text = "Selected Fields: 0.0";
                SixthDataLabel.Text = "Selected Numerics: 0.0";
                SeventhDataLabel.Text = string.Empty;
                EightDataLabel.Text = string.Empty;
                NinthDataLabel.Text = string.Empty;
                SqlHeader.Text = string.Empty;
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
                    var _records = DataTable.Rows.Count.ToString( "#,###" ) ?? "0";
                    var _filters = FormFilter.Keys.Count;
                    var _fields = Fields?.Count ?? 0;
                    var _numerics = Numerics?.Count ?? 0;
                    var _selectedFields = SelectedFields?.Count ?? 0;
                    var _selectedNumerics = SelectedNumerics?.Count ?? 0;
                    FirstDataLabel.Text = $"Data Records:  {_records} ";
                    SecondDataLabel.Text = $"Total Fields:  {_fields} ";
                    ThirdDataLabel.Text = $"Total Measures:  {_numerics} ";
                    FourthDataLabel.Text = $"Active Filters:  {_filters} ";
                    FifthDataLabel.Text = $"Selected Fields:  {_selectedFields}";
                    SixthDataLabel.Text = $"Selected Numerics:  {_selectedNumerics}";
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
                    SixthDataLabel.Text = "Selected Numerics: 0.0";
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
                var _names = Enum.GetNames( typeof( ChartSeriesType ) );
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

                    foreach( var item in Fields )
                    {
                        FirstComboBox.Items.Add( item );
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
        /// Opens the excel data form.
        /// </summary>
        private void OpenExcelDataForm( )
        {
            try
            {
                var _excel = new ExcelDataForm( BindingSource );
                _excel.Owner = Owner;
                _excel.Show( );
                Close( );
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
                var _data = new DataGridForm( BindingSource );
                _data.Owner = Owner;
                _data.Show( );
                Close( );
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
                if( FormFilter?.Any( ) == true )
                {
                    FormFilter.Clear( );
                }

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
                    ToolStrip.Visible = true;
                    var _title = _listBox.SelectedValue?.ToString( );
                    SelectedTable = _title?.Replace( " ", "" );
                    if( !string.IsNullOrEmpty( SelectedTable ) )
                    {
                        Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
                        DataModel = new DataBuilder( Source, Provider );
                        DataTable = DataModel.DataTable;
                        BindingSource.DataSource = DataModel.DataTable;
                        Chart.BindingSource.DataSource = DataModel.DataTable;
                        ToolStrip.BindingSource = BindingSource;
                        Fields = DataModel.Fields;
                        Numerics = DataModel.Numerics;
                        TabControl.SelectedIndex = 1;
                    }

                    ResetLabelText( );
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

                    ResetLabelText( );
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

                    ResetLabelText( );
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
                    ResetLabelText( );
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
                ResetLabelText( );
                var _selectedItem = FieldListBox.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedFields.Add( _selectedItem );
                    SelectedColumns.Add( _selectedItem );
                }

                UpdateLabelText( );
                SqlQuery = CreateSqlText( SelectedColumns, FormFilter );
                SqlHeader.Text = SqlQuery;
                ResetData( SelectedColumns, FormFilter );
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
                ResetLabelText( );
                var _selectedItem = NumericListBox.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedNumerics.Add( _selectedItem );
                }

                UpdateLabelText( );
                SqlQuery = CreateSqlText( SelectedFields, SelectedNumerics, FormFilter );
                SqlHeader.Text = SqlQuery;
                ResetData( SelectedFields, SelectedNumerics, FormFilter );
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
        /// Called when [main menu button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnMainMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.MenuButton )
                {
                    if( Owner != null
                       && Owner.Visible == false )
                    {
                        Owner.Visible = true;
                    }

                    Visible = false;
                }
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
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.RefreshDataButton )
                {
                    TabControl.SelectedIndex = 0;
                    SelectedTable = string.Empty;
                    BindingSource.DataSource = null;
                    ClearSelections( );
                    ClearCollections( );
                    ResetLabelText( );
                    PopulateExecutionTables( );
                }
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
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.GroupButton
                   && FormFilter.Count > 0 )
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
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.RemoveFiltersButton
                   && !string.IsNullOrEmpty( SelectedTable ) )
                {
                    ClearSelections( );
                    ClearCollections( );
                    ResetLabelText( );
                    DataModel = new DataBuilder( Source, Provider );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    TabControl.SelectedIndex = 1;
                    PopulateFirstComboBoxItems( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnSourceButtonClick( object sender, EventArgs e )
        {
            try
            {
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
                if( !string.IsNullOrEmpty( SelectedTable )
                   && ( Owner?.Name.Equals( "DataGridForm" ) == true
                       || Owner?.Name.Equals( "ExcelDataForm" ) == true
                       || Owner?.Name.Equals( "MainForm" ) == true ) )
                {
                    Owner.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _dataForm = new DataGridForm( BindingSource );
                    _dataForm.Owner = this;
                    _dataForm.Show( );
                }

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
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.BackButton
                   && ( Owner?.Name.Equals( "DataGridForm" ) == true
                       || Owner?.Name.Equals( "MainForm" ) == true
                       || Owner?.Name.Equals( "ExcelDataForm" ) == true ) )
                {
                    if( Owner != null
                       && Owner.Visible == false )
                    {
                        Owner.Visible = true;
                    }

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
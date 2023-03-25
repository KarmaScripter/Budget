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
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "UnusedVariable" )]
    [SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" )]
    [SuppressMessage( "ReSharper", "RedundantBoolCompare" )]
    public partial class ChartForm : MetroForm
    {
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
        public IEnumerable<string> yAxis { get; set; }

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
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        public ChartForm( )
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

            // ToolStrip Properties
            ToolStrip.Visible = true;
            ToolStrip.Text = string.Empty;
            ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
            ToolStrip.Office12Mode = true;
            ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
            ToolStrip.LauncherStyle = LauncherStyle.Office12;
            ToolStrip.ImageSize = new Size( 16, 16 );
            ToolStrip.ImageScalingSize = new Size( 16, 16 );
            ToolStripTextBox.Size = new Size( 190, 28 );
            ToolStripTextBox.ForeColor = Color.LightSteelBlue;
            ToolStripTextBox.TextBoxTextAlign = HorizontalAlignment.Center;
            ToolStripTextBox.Text = DateTime.Today.ToShortDateString( );

            // Event Wiring
            MouseClick += OnRightClick;
            ExitButton.Click += null;
            BackButton.Click += null;
            MenuButton.Click += null;
            FilterButton.Click += null;
            TableButton.Click += null;
            ChartTable.MouseClick += OnRightClick;
            FirstTable.MouseClick += OnRightClick;
            FirstListBoxPanel.MouseClick += OnRightClick;
            SecondTable.MouseClick += OnRightClick;
            SecondListBoxPanel.MouseClick += OnRightClick;
            ExitButton.Click += OnExitButtonClicked;
            BackButton.Click += OnBackButtonClicked;
            MenuButton.Click += OnMainMenuButtonClicked;
            FilterButton.Click += OnRemoveFilterButtonClicked;
            FilterButton.Click += OnRemoveFilterButtonClicked;
            TableButton.Click += OnTableButtonClick;
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
            DataTable = (DataTable)bindingSource.DataSource;
            BindingSource.DataSource = DataTable;
            SelectedTable = DataTable.TableName;
            Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
            DataModel = new DataBuilder( Source, Provider );
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public ChartForm( Source source, Provider provider )
            : this( )
        {
            Source = source;
            Provider = provider;
            DataModel = new DataBuilder( source, provider );
            DataTable = DataModel?.DataTable;
            SelectedTable = DataTable?.TableName;
            BindingSource.DataSource = DataTable;
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        public ChartForm( Source source, Provider provider, IDictionary<string, object> where )
            : this( )
        {
            Source = source;
            Provider = provider;
            FormFilter = where;
            DataModel = new DataBuilder( source, provider, where );
            DataTable = DataModel?.DataTable;
            BindingSource.DataSource = DataTable;
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
                Chart.BindingSource = BindingSource;
                Chart.Title.Text = string.Empty;
                SetToolStripProperties( );
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
                    Text = $"{SelectedTable.SplitPascal( )}";
                    Chart.Title.Text = string.Empty;
                    Chart.ToolBar.Visible = false;
                    LabelTable.Visible = true;
                    TableButton.Visible = true;
                    PopulateFirstComboBoxItems( );
                    UpdateLabelText( );
                }
                else if( string.IsNullOrEmpty( SelectedTable ) )
                {
                    LabelTable.Visible = false;
                    TableButton.Visible = false;
                    Text = "Visualization";
                    Chart.Title.Text = "Select Data Table";
                    Chart.ToolBar.Visible = false;
                }

                FormFilter = new Dictionary<string, object>( );
                SelectedColumns = new List<string>( );
                SelectedFields = new List<string>( );
                SelectedNumerics = new List<string>( );
                Chart.ChartArea.BorderStyle = BorderStyle.None;
                PopulateToolBarDropDownItems( );
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
            if( ToolStrip.TextBox != null )
            {
                try
                {
                    ToolStrip.Visible = true;
                    ToolStrip.Text = string.Empty;
                    ToolStrip.Office12Mode = true;
                    ToolStrip.TextBox.ForeColor = Color.LightSteelBlue;
                    ToolStrip.TextBox.TextBoxTextAlign = HorizontalAlignment.Center;
                    ToolStrip.TextBox.Text = DateTime.Today.ToShortDateString( );
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
        private void BindDataSource( IDictionary<string, object> where )
        {
            if( Enum.IsDefined( typeof( Source ), Source )
               && Enum.IsDefined( typeof( Provider ), Provider )
               && where?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    BindingSource.DataSource = DataTable;
                    Chart.BindingSource = BindingSource;
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
        /// <param name="cols">The cols.</param>
        /// <param name="where">The where.</param>
        private void BindDataSource( IEnumerable<string> cols, IDictionary<string, object> where )
        {
            if( Enum.IsDefined( typeof( Source ), Source )
               && Enum.IsDefined( typeof( Provider ), Provider )
               && where?.Any( ) == true
               && cols?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( cols, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    BindingSource.DataSource = DataTable;
                    Chart.BindingSource = BindingSource;
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
                    var _sql = CreateSqlText( fields, numerics, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    BindingSource.DataSource = DataTable;
                    Chart.BindingSource = BindingSource;
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
        /// Clears the selections.
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
                    return $"SELECT * FROM {Source} " + $"WHERE {where.ToCriteria( )};";
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
               && columns?.Any( ) == true
               && !string.IsNullOrEmpty( SelectedTable ) )
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
                    return $"SELECT {_names} FROM {SelectedTable} " + $"WHERE {_criteria} "
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
        /// Clears the label text.
        /// </summary>
        private void ClearLabelText( )
        {
            try
            {
                Text = string.Empty;
                FirstHeaderLabel.Text = string.Empty;
                SecondHeaderLabel.Text = string.Empty;
                ThirdHeaderLabel.Text = string.Empty;
                FourthHeaderLabel.Text = string.Empty;
                NumericsLabel.Text = string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the label text.
        /// </summary>
        private void SetLabelText( )
        {
            try
            {
                FirstHeaderLabel.Text = string.Empty;
                SecondHeaderLabel.Text = string.Empty;
                ThirdHeaderLabel.Text = string.Empty;
                FourthHeaderLabel.Text = string.Empty;
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
                    Text = $"{Provider} Database ";
                    var _table = SelectedTable?.SplitPascal( ) ?? string.Empty;
                    var _records = DataTable.Rows.Count.ToString( "#,###" ) ?? "0";
                    var _fields = Fields?.Count ?? 0;
                    var _numerics = Numerics?.Count ?? 0;
                    FirstHeaderLabel.Text = $"Source :  {_table}";
                    SecondHeaderLabel.Text = $"Records : {_records} ";
                    ThirdHeaderLabel.Text = $"Fields : {_fields} ";
                    FourthHeaderLabel.Text = $"Measures : {_numerics} ";
                    ThirdHeaderLabel.Text = $"Fields : {_fields} ";
                    NumericsLabel.Text = $"Measures : {_numerics} ";
                }
                else
                {
                    Text = $"{Provider} Database ";
                    FirstHeaderLabel.Text = "Source :  ";
                    SecondHeaderLabel.Text = "Records : ";
                    ThirdHeaderLabel.Text = "Fields : ";
                    FourthHeaderLabel.Text = "Measures : ";
                    ThirdHeaderLabel.Text = "Fields : ";
                    NumericsLabel.Text = "Measures : ";
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
        /// Populates the first ComboBox items.
        /// </summary>
        private void PopulateFirstComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
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
        private void PopulateSecondComboBoxItems( )
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
                            }
                        }
                    }
                    else
                    {
                        foreach( var item in Fields )
                        {
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
        private void PopulateThirdComboBoxItems( )
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

        private void OpenFilterDialog( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OpenGroupDialog( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OpenTableDialog( )
        {
            try
            {
                var _form = new FilterDialog( BindingSource );
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
                    foreach( var _item in Fields )
                    {
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
                    for( var _i = 0; _i < Numerics.Count; _i++ )
                    {
                        if( !string.IsNullOrEmpty( Numerics[ _i ] ) )
                        {
                            SecondListBox.Items.Add( Numerics[ _i ] );
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
        /// Binds the data source.
        /// </summary>
        /// <param name="sqlText">The SQL text.</param>
        private void BindDataSource( string sqlText )
        {
            if( Enum.IsDefined( typeof( Source ), Source )
               && Enum.IsDefined( typeof( Provider ), Provider )
               && !string.IsNullOrEmpty( sqlText ) )
            {
                try
                {
                    SqlQuery = sqlText;
                    DataModel = new DataBuilder( Source, Provider, SqlQuery );
                    DataTable = DataModel?.DataTable;
                    BindingSource.DataSource = DataModel?.DataTable;
                    Chart.BindingSource = BindingSource;
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
        /// Called when [second ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSecondComboBoxItemSelected( object sender, EventArgs e )
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
                    var _filter = _comboBox.SelectedItem.ToString( );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        SecondCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
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
        private void OnSecondListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    SecondValue = _listBox.SelectedValue.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue );
                    PopulateThirdComboBoxItems( );
                    SqlQuery = CreateSqlText( FormFilter );
                    BindDataSource( SqlQuery );
                    UpdateLabelText( );
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
        private void OnThirdComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    var _filter = _comboBox?.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        ThirdCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
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
        private void OnThirdListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    ThirdValue = _listBox?.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue );
                    FormFilter.Add( ThirdCategory, ThirdValue );
                    SqlQuery = CreateSqlText( FormFilter );
                    BindDataSource( SqlQuery );
                    UpdateLabelText( );
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
                var _selectedItem = SecondListBox.SelectedItem?.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedColumns?.Add( _selectedItem );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                    SqlQuery = string.Empty;
                    FirstCategory = string.Empty;
                    FirstValue = string.Empty;
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    var _filter = _comboBox.SelectedItem.ToString( );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        FirstCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
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
        /// Called when [first ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnFirstListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    FirstValue = _listBox?.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    PopulateSecondComboBoxItems( );
                    SqlQuery = CreateSqlText( FormFilter );
                    BindDataSource( SqlQuery );
                    UpdateLabelText( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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

                    var _title = _listBox.SelectedValue?.ToString( );
                    SelectedTable = _title?.Replace( " ", "" );
                    if( !string.IsNullOrEmpty( SelectedTable ) )
                    {
                        TableButton.Visible = true;
                        Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
                        DataModel = new DataBuilder( Source, Provider );
                        DataTable = DataModel?.DataTable;
                        SelectedTable = DataTable?.TableName;
                        Text = SelectedTable.SplitPascal( );
                        Chart.Title.Text = string.Empty;
                        BindingSource.DataSource = DataModel?.DataTable;
                        Chart.BindingSource = BindingSource;
                        ToolStrip.BindingSource = BindingSource;
                        Fields = DataModel?.Fields;
                        Numerics = DataModel?.Numerics;
                        PopulateFirstComboBoxItems( );
                        UpdateLabelText( );
                        LabelTable.Visible = true;
                    }
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
                   && _button.ToolType == ToolType.BackButton )
                {
                    if( Owner != null
                       && Owner.Visible == false )
                    {
                        Owner.Visible = true;
                    }

                    ClearSelections( );
                    Visible = false;
                }
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
                    SelectedTable = string.Empty;
                    Chart.BindingSource.DataSource = null;
                    ClearSelections( );
                    ClearCollections( );
                    ClearLabelText( );
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
                   && _button.ToolType == ToolType.GroupButton )
                {
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
        /// Called when [start date selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnStartDateSelected( object sender, EventArgs e )
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
        /// Called when [end date selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnEndDateSelected( object sender, EventArgs e )
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
                    ClearCollections( );
                    ClearLabelText( );
                    Chart.BindingSource.DataSource = null;
                    DataModel = new DataBuilder( Source, Provider );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    Chart.BindingSource.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
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

        private void OnFilterButtonClick( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnGroupButtonClick( object sender, EventArgs e )
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
                       || Owner?.Name.Equals( "ChartForm" ) == true ) )
                {
                    Visible = false;
                    Owner.Visible = true;
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
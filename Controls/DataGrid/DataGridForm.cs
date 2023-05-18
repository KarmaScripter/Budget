// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBoolCompare" ) ]
    [ SuppressMessage( "ReSharper", "ReturnValueOfPureMethodIsNotUsed" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    public partial class DataGridForm : MetroForm
    {
        /// <summary> Gets or sets the selected table. </summary>
        /// <value> The selected table. </value>
        public string SelectedTable { get; set; }

        /// <summary> Gets or sets the first category. </summary>
        /// <value> The first category. </value>
        public string FirstCategory { get; set; }

        /// <summary> Gets or sets the first value. </summary>
        /// <value> The first value. </value>
        public string FirstValue { get; set; }

        /// <summary> Gets or sets the second category. </summary>
        /// <value> The second category. </value>
        public string SecondCategory { get; set; }

        /// <summary> Gets or sets the second value. </summary>
        /// <value> The second value. </value>
        public string SecondValue { get; set; }

        /// <summary> Gets or sets the third category. </summary>
        /// <value> The third category. </value>
        public string ThirdCategory { get; set; }

        /// <summary> Gets or sets the third value. </summary>
        /// <value> The third value. </value>
        public string ThirdValue { get; set; }

        /// <summary> Gets or sets the SQL query. </summary>
        /// <value> The SQL query. </value>
        public string SqlQuery { get; set; }

        /// <summary> Gets or sets the form filter. </summary>
        /// <value> The form filter. </value>
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary> Gets or sets the fields. </summary>
        /// <value> The fields. </value>
        public IList<string> Fields { get; set; }

        /// <summary> Gets or sets the numerics. </summary>
        /// <value> The numerics. </value>
        public IList<string> Numerics { get; set; }

        /// <summary> Gets or sets the selected columns. </summary>
        /// <value> The selected columns. </value>
        public IList<string> SelectedColumns { get; set; }

        /// <summary> Gets or sets the selected fields. </summary>
        /// <value> The selected fields. </value>
        public IList<string> SelectedFields { get; set; }

        /// <summary> Gets or sets the selected numerics. </summary>
        /// <value> The selected numerics. </value>
        public IList<string> SelectedNumerics { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public Provider Provider { get; set; }

        /// <summary> Gets or sets the data table. </summary>
        /// <value> The data table. </value>
        public DataTable DataTable { get; set; }

        /// <summary> Gets or sets the data model. </summary>
        /// <value> The data model. </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGridForm"/>
        /// class.
        /// </summary>
        public DataGridForm( )
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
            ForeColor = Color.DarkGray;
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Regular );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            SizeGripStyle = SizeGripStyle.Auto;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;

            // Label Properties
            FirstGridLabel.Font = new Font( "Roboto", 8 );
            FirstGridLabel.ForeColor = Color.DarkGray;
            SecondGridLabel.Font = new Font( "Roboto", 8 );
            SecondGridLabel.ForeColor = Color.DarkGray;
            SecondGridLabel.Text = string.Empty;
            ThirdGridLabel.Font = new Font( "Roboto", 8 );
            ThirdGridLabel.ForeColor = Color.DarkGray;
            ThirdGridLabel.Text = string.Empty;
            FourthGridLabel.Font = new Font( "Roboto", 8 );
            FourthGridLabel.ForeColor = Color.DarkGray;
            FourthGridLabel.Text = string.Empty;

            // Header Properties
            HeaderLabel.Font = new Font( "Roboto", 10 );
            HeaderLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;

            // TabPage Properties
            TabControl.ActiveTabForeColor = Color.FromArgb( 20, 20, 20 );
            TableTabPage.TabForeColor = Color.FromArgb( 20, 20, 20 );
            FilterTabPage.TabForeColor = Color.FromArgb( 20, 20, 20 );
            GroupTabPage.TabForeColor = Color.FromArgb( 20, 20, 20 );

            // Table Layout Properties
            FirstTable.Visible = false;
            SecondTable.Visible = false;
            ThirdTable.Visible = false;

            // Initialize Default Provider
            Provider = Provider.Access;

            // Control Event Wiring
            ExcelExportButton.Click += null;
            ExitButton.Click += null;
            BackButton.Click += null;
            MenuButton.Click += null;
            ChartButton.Click += null;
            EditSqlButton.Click += null;
            RefreshDataButton.Click += null;
            RemoveFiltersButton.Click += null;
            GroupButton.Click += null;
            CalendarButton.Click += null;
            TabControl.SelectedIndexChanged += OnActiveTabChanged;
            GridPanel.MouseClick += OnRightClick;
            TableListBox.SelectedValueChanged += OnTableListBoxItemSelected;
            FirstComboBox.SelectedValueChanged += OnFirstComboBoxItemSelected;
            FirstListBox.SelectedValueChanged += OnFirstListBoxItemSelected;
            SecondComboBox.SelectedValueChanged += OnSecondComboBoxItemSelected;
            SecondListBox.SelectedValueChanged += OnSecondListBoxItemSelected;
            ThirdComboBox.SelectedValueChanged += OnThirdComboBoxItemSelected;
            ThirdListBox.SelectedValueChanged += OnThirdListBoxItemSelected;
            FieldListBox.SelectedValueChanged += OnFieldListBoxSelectedValueChanged;
            NumericListBox.SelectedValueChanged += OnNumericListBoxSelectedValueChanged;
            TableComboBox.SelectedValueChanged += OnTableComboBoxItemSelected;
            AccessRadioButton.CheckedChanged += OnRadioButtonChecked;
            SQLiteRadioButton.CheckedChanged += OnRadioButtonChecked;
            SqlServerRadioButton.CheckedChanged += OnRadioButtonChecked;
            SqlCeRadioButton.CheckedChanged += OnRadioButtonChecked;
            ExcelExportButton.Click += OnExcelButtonClicked;
            ChartButton.Click += OnChartButtonClicked;
            ExitButton.Click += OnExitButtonClicked;
            BackButton.Click += OnBackButtonClicked;
            MenuButton.Click += OnMainMenuButtonClicked;
            RemoveFiltersButton.Click += OnRemoveFilterButtonClicked;
            RefreshDataButton.Click += OnRefreshDataButtonClicked;
            GroupButton.Click += OnGroupButtonClicked;
            CalendarButton.Click += OnCalendarButtonClicked;
            FirstCalendar.SelectionChanged += OnStartDateSelected;
            SecondCalendar.SelectionChanged += OnEndDateSelected;
            EditSqlButton.Click += OnSqlButtonClick;
            EditRecordButton.Click += OnEditRecordButtonClicked;
            EditColumnButton.Click += OnEditColumnButtonClicked;

            // Form Event Wiring
            Load += OnLoad;
            Shown += OnShown;
            Closing += OnClose;
            MouseClick += OnRightClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGridForm"/>
        /// class.
        /// </summary>
        /// <param name="bindingSource"> The binding source. </param>
        public DataGridForm( BindingSource bindingSource )
            : this( )
        {
            SelectedTable = ( (DataTable)bindingSource.DataSource ).TableName;
            Source = DataBuilder.GetSource( SelectedTable );
            DataModel = new DataBuilder( Source, Provider );
            DataTable = DataModel.DataTable;
            BindingSource.DataSource = DataModel?.DataTable;
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
            DataGrid.DataSource = BindingSource?.DataSource;
            ToolStrip.BindingSource = BindingSource;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGridForm"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        public DataGridForm( Source source, Provider provider )
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
            DataGrid.DataSource = BindingSource?.DataSource;
            ToolStrip.BindingSource = BindingSource;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGridForm"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The where. </param>
        public DataGridForm( Source source, Provider provider, IDictionary<string, object> where )
            : this( )
        {
            Source = source;
            Provider = provider;
            FormFilter = where;
            DataModel = new DataBuilder( source, provider, where );
            DataTable = DataModel?.DataTable;
            SelectedTable = DataTable?.TableName;
            BindingSource.DataSource = DataTable;
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
            DataGrid.DataSource = BindingSource?.DataSource;
            ToolStrip.BindingSource = BindingSource;
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                ClearSelections( );
                InitRadioButtons( );
                SetFormIcon( );
                SetToolStripProperties( );
                FormFilter = new Dictionary<string, object>( );
                SelectedColumns = new List<string>( );
                SelectedFields = new List<string>( );
                SelectedNumerics = new List<string>( );
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    TabControl.SelectedIndex = 1;
                    FilterTabPage.TabVisible = true;
                    TableTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    CalendarTabPage.TabVisible = false;
                    LabelTable.Visible = true;
                    PopulateFirstComboBoxItems( );
                    ResetFilterTableVisibility( );
                }
                else if( string.IsNullOrEmpty( SelectedTable ) )
                {
                    TabControl.SelectedIndex = 0;
                    TableTabPage.TabVisible = true;
                    FilterTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    CalendarTabPage.TabVisible = false;
                    TableComboBox.SelectionStart = 0;
                }

                DataGrid.PascalizeHeaders( );
                DataGrid.FormatColumns( );
                UpdateLabelText( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Populates the first ComboBox items. </summary>
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

        /// <summary> Populates the second ComboBox items. </summary>
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

        /// <summary> Populates the third ComboBox items. </summary>
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

        /// <summary> Called when [table ListBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
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
                        DataGrid.DataSource = BindingSource;
                        DataGrid.PascalizeHeaders( );
                        DataGrid.FormatColumns( );
                        ToolStrip.BindingSource = BindingSource;
                        Fields = DataModel.Fields;
                        Numerics = DataModel.Numerics;
                        TabControl.SelectedIndex = 1;
                    }

                    UpdateLabelText( );
                    PopulateFirstComboBoxItems( );
                    ResetFilterTableVisibility( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [first ComboBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
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

        /// <summary> Called when [first ListBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
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
                        GroupSeparator.Visible = true;
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

        /// <summary> Called when [second ComboBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
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

        /// <summary> Called when [second ListBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
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
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [third ComboBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
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

        /// <summary> Called when [third ListBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
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

        /// <summary> Called when [test button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnTestButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _program = new ProgramProjectDialog( );
                _program.ShowDialog( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [exit button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
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

        /// <summary> Called when [main menu button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
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

        /// <summary> Called when [remove filter button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnRemoveFilterButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    ClearSelections( );
                    ClearCollections( );
                    DataGrid.DataSource = null;
                    DataModel = new DataBuilder( Source, Provider );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    TabControl.SelectedIndex = 1;
                    PopulateFirstComboBoxItems( );
                    UpdateLabelText( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [chart button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnChartButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( BindingSource.DataSource != null )
                {
                    OpenChartDataForm( );
                    Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [excel button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnExcelButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( BindingSource.DataSource != null )
                {
                    OpenExcelDataForm( );
                    Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Resets the data. </summary>
        /// <param name="where"> The where. </param>
        private void ResetData( IDictionary<string, object> where )
        {
            if( where?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    SelectedTable = DataTable?.TableName;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
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

        /// <summary> Resets the data. </summary>
        /// <param name="cols"> The cols. </param>
        /// <param name="where"> The where. </param>
        private void ResetData( IEnumerable<string> cols, IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && cols?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( cols, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    SelectedTable = DataTable?.TableName;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
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

        /// <summary> Resets the data. </summary>
        /// <param name="fields"> The fields. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="where"> The where. </param>
        private void ResetData( IEnumerable<string> fields, IEnumerable<string> numerics, IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && fields?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( fields, numerics, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    SelectedTable = DataTable?.TableName;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
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

        /// <summary> Sets the form icon. </summary>
        private void SetFormIcon( )
        {
            try
            {
                var _path = ConfigurationManager.AppSettings[ "Providers" ];
                if( !string.IsNullOrEmpty( _path ) )
                {
                    var _files = Directory.GetFiles( _path );
                    if( _files?.Any( ) == true )
                    {
                        var _extension = Provider.ToString( );
                        var _file = _files?.Where( f => f.Contains( _extension ) )?.First( );
                        if( !string.IsNullOrEmpty( _file )
                           && File.Exists( _file ) )
                        {
                            var _img = Image.FromFile( _file );
                            PictureBox.Image = _img;
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the dialog icon. </summary>
        /// <param name="type"> The type. </param>
        private void SetDialogIcon( ToolType type )
        {
            try
            {
                var _path = ConfigurationManager.AppSettings[ "Dialogs" ];
                if( !string.IsNullOrEmpty( _path ) )
                {
                    var _files = Directory.GetFiles( _path );
                    if( _files?.Any( ) == true )
                    {
                        switch( type )
                        {
                            case ToolType.AddTableButton:
                            case ToolType.DeleteTableButton:
                            case ToolType.EditRecordButton:
                            case ToolType.DeleteRecordButton:
                            case ToolType.EditColumnButton:
                            case ToolType.DeleteColumnButton:
                            case ToolType.EditSqlButton:
                            {
                                var _tool = type.ToString( );
                                var _file = _files?.Where( f => f.Contains( _tool ) )?.First( );
                                if( !string.IsNullOrEmpty( _file )
                                   && File.Exists( _file ) )
                                {
                                    var _img = Image.FromFile( _file );
                                    PictureBox.Image = _img;
                                }

                                break;
                            }
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Resets the filter table visibility. </summary>
        private void ResetFilterTableVisibility( )
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

        /// <summary> Creates the SQL text. </summary>
        /// <param name="where"> The where. </param>
        /// <returns> </returns>
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

        /// <summary> Creates the SQL text. </summary>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The where. </param>
        /// <returns> </returns>
        private string CreateSqlText( IEnumerable<string> columns, IDictionary<string, object> where )
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
                    return $"SELECT {_names} FROM {SelectedTable} " + $"WHERE {_criteria} " + $"GROUP BY {_names} ;";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary> Creates the SQL text. </summary>
        /// <param name="fields"> The fields. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="where"> The where. </param>
        /// <returns> </returns>
        private string CreateSqlText( IEnumerable<string> fields, IEnumerable<string> numerics, IDictionary<string, object> where )
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
                    return $"SELECT {_columns} FROM {Source} " + $"WHERE {_criteria} " + $"GROUP BY {_groups};";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary> Initializes the radio buttons. </summary>
        private void InitRadioButtons( )
        {
            try
            {
                SQLiteRadioButton.Tag = "SQLite";
                SQLiteRadioButton.HoverText = "SQLite Provider";
                AccessRadioButton.Tag = "Access";
                AccessRadioButton.HoverText = "MS Access Provider";
                AccessRadioButton.Checked = true;
                SqlCeRadioButton.Tag = "SqlCe";
                SqlCeRadioButton.HoverText = "SQL Compact Provider";
                SqlServerRadioButton.Tag = "SqlServer";
                SqlServerRadioButton.HoverText = "Sql Server Provider";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Gets the radio buttons. </summary>
        /// <returns> </returns>
        private IEnumerable<RadioButton> GetRadioButtons( )
        {
            try
            {
                var _buttons = new List<RadioButton>
                {
                    SQLiteRadioButton,
                    AccessRadioButton,
                    SqlCeRadioButton,
                    SqlServerRadioButton
                };

                return _buttons?.Any( ) == true
                    ? _buttons
                    : default( IEnumerable<RadioButton> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<RadioButton> );
            }
        }

        /// <summary> Sets the tool strip properties. </summary>
        private void SetToolStripProperties( )
        {
            try
            {
                ToolStrip.Visible = true;
                ToolStrip.Text = string.Empty;
                ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
                ToolStrip.Office12Mode = true;
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

        /// <summary> Updates the label text. </summary>
        private void UpdateLabelText( )
        {
            try
            {
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    var _table = SelectedTable?.SplitPascal( ) ?? string.Empty;
                    var _records = DataTable.Rows.Count.ToString( "#,###" ) ?? "0";
                    var _columns = DataTable.Columns.Count.ToString( ) ?? "--";
                    var _fields = Fields?.Count ?? 0;
                    var _numerics = Numerics?.Count ?? 0;
                    var _selectedFields = SelectedFields?.Count ?? 0;
                    var _selectedNumerics = SelectedNumerics?.Count ?? 0;
                    HeaderLabel.Text = $"{_table} ";
                    FirstGridLabel.Text = $"Data Provider: {Provider}";
                    SecondGridLabel.Text = $"Records: {_records}";
                    ThirdGridLabel.Text = $"Total Fields: {_fields}";
                    FourthGridLabel.Text = $"Total Measures: {_numerics}";
                    FieldsTable.CaptionText = $"Selected Fields: {_selectedFields}";
                    NumericsTable.CaptionText = $"Selected Measures: {_selectedNumerics}";
                    FirstCalendarTable.CaptionText = $"Start Date: {FirstCalendar.SelectedDate}";
                    SecondCalendarTable.CaptionText = $"End Date: {SecondCalendar.SelectedDate}";
                }
                else
                {
                    HeaderLabel.Text = $"{Provider} Database ";
                    FirstGridLabel.Text = $"Provider:  {Provider}";
                    SecondGridLabel.Text = "Total Records: 0.0";
                    ThirdGridLabel.Text = "Total Fields: 0.0";
                    FourthGridLabel.Text = "Total Measures: 0.0";
                    FieldsTable.CaptionText = "Selected Fields: 0.0";
                    NumericsTable.CaptionText = "Selected Measures: 0.0";
                    FirstCalendarTable.CaptionText = "Start Date: --";
                    SecondCalendarTable.CaptionText = "End Date: --";
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Clears the selections. </summary>
        private void ClearSelections( )
        {
            try
            {
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
                    PopulateFirstComboBoxItems( );
                    FirstTable.Visible = true;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Clears the collections. </summary>
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

        /// <summary> Populates the field ListBox. </summary>
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

        /// <summary> Populates the numeric ListBox. </summary>
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

        /// <summary> Populates the reference tables. </summary>
        private void PopulateReferenceTables( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data?.Where( r => r.Field<string>( "Model" ).Equals( "REFERENCE" ) )?.OrderBy( r => r.Field<string>( "Title" ) )?.Select( r => r.Field<string>( "Title" ) )?.ToList( );
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

        /// <summary> Populates the maintenance tables. </summary>
        private void PopulateMaintenanceTables( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data?.Where( r => r.Field<string>( "Model" ).Equals( "MAINTENANCE" ) )?.OrderBy( r => r.Field<string>( "Title" ) )?.Select( r => r.Field<string>( "Title" ) )?.ToList( );
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

        /// <summary> Populates the execution tables. </summary>
        private void PopulateExecutionTables( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data?.Where( r => r.Field<string>( "Model" ).Equals( "EXECUTION" ) )?.OrderBy( r => r.Field<string>( "Title" ) )?.Select( r => r.Field<string>( "Title" ) )?.ToList( );
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

        /// <summary> Opens the main form. </summary>
        private void OpenMainForm( )
        {
            try
            {
                if( Owner != null
                   && Owner.Visible == false
                   && Owner.GetType( ) == typeof( MainForm ) )
                {
                    Owner.Visible = true;
                    Visible = false;
                }
                else if( Owner != null
                        && Owner.Visible == false
                        && Owner.GetType( ) != typeof( MainForm ) )
                {
                    Owner.Close( );
                    var _mainForm = Program.Windows[ "Main" ];
                    _mainForm.Refresh( );
                    _mainForm.Visible = true;
                    Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Opens the excel data form. </summary>
        private void OpenExcelDataForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( _forms?.Any( f => f.GetType( ) == typeof( ExcelDataForm ) ) == true )
                {
                    var _excelDataForm = _forms?.Where( f => f.GetType( ) == typeof( ExcelDataForm ) == true )?.First( );
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

        /// <summary> Opens the chart data form. </summary>
        private void OpenChartDataForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( _forms?.Any( f => f.GetType( ) == typeof( ChartDataForm ) ) == true )
                {
                    var _chartDataForm = _forms?.Where( f => f.GetType( ) == typeof( ChartDataForm ) == true )?.First( );
                    _chartDataForm.Visible = true;
                }
                else
                {
                    var _chartDataForm = new ChartDataForm( BindingSource );
                    _chartDataForm.Owner = this;
                    _chartDataForm.Show( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [table ComboBox item selected]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnTableComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _tableComboBox )
            {
                try
                {
                    var _type = _tableComboBox.SelectedItem.ToString( );
                    switch( _type?.ToUpper( ) )
                    {
                        case "EXECUTION":
                        {
                            PopulateExecutionTables( );
                            break;
                        }
                        case "REFERENCE":
                        {
                            PopulateReferenceTables( );
                            break;
                        }
                        case "MAINTENANCE":
                        {
                            PopulateMaintenanceTables( );
                            break;
                        }
                        default:
                        {
                            PopulateExecutionTables( );
                            break;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [field ListBox selected value changed]. </summary>
        /// <param name="sender"> The sender. </param>
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
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [numeric ListBox selected value changed]. </summary>
        /// <param name="sender"> The sender. </param>
        private void OnNumericListBoxSelectedValueChanged( object sender )
        {
            try
            {
                var _selectedItem = NumericListBox.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedNumerics.Add( _selectedItem );
                }

                SqlQuery = CreateSqlText( SelectedFields, SelectedNumerics, FormFilter );
                SqlHeader.Text = SqlQuery;
                ResetData( SelectedFields, SelectedNumerics, FormFilter );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [active tab changed]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnActiveTabChanged( object sender, EventArgs e )
        {
            try
            {
                switch( TabControl.SelectedIndex )
                {
                    case 0:
                    {
                        TableTabPage.TabVisible = true;
                        FilterTabPage.TabVisible = false;
                        GroupTabPage.TabVisible = false;
                        CalendarTabPage.TabVisible = false;
                        ProviderTable.Visible = true;
                        SetFormIcon( );
                        PopulateExecutionTables( );
                        break;
                    }
                    case 1:
                    {
                        FilterTabPage.TabVisible = true;
                        TableTabPage.TabVisible = false;
                        GroupTabPage.TabVisible = false;
                        CalendarTabPage.TabVisible = false;
                        ProviderTable.Visible = false;
                        ResetFilterTableVisibility( );
                        break;
                    }
                    case 2:
                    {
                        GroupTabPage.TabVisible = true;
                        TableTabPage.TabVisible = false;
                        FilterTabPage.TabVisible = false;
                        CalendarTabPage.TabVisible = false;
                        ProviderTable.Visible = false;
                        break;
                    }
                    case 3:
                    {
                        CalendarTabPage.TabVisible = true;
                        GroupTabPage.TabVisible = false;
                        TableTabPage.TabVisible = false;
                        FilterTabPage.TabVisible = false;
                        ProviderTable.Visible = false;
                        break;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [group button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
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

        /// <summary> Called when [calendar button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCalendarButtonClicked( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 3;
                FirstCalendarTable.CaptionText = $"Start Date: {FirstCalendar.SelectedDate}";
                SecondCalendarTable.CaptionText = $"End Date: {SecondCalendar.SelectedDate}";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [edit record button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnEditRecordButtonClicked( object sender, EventArgs e )
        {
            if( sender is ToolStripButton button )
            {
                try
                {
                    SetDialogIcon( button.ToolType );
                    var _dialog = new EditDialog( button.ToolType, BindingSource );
                    _dialog?.ShowDialog( this );
                    SetFormIcon( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [edit column button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnEditColumnButtonClicked( object sender, EventArgs e )
        {
            if( sender is ToolStripButton button )
            {
                try
                {
                    SetDialogIcon( button.ToolType );
                    var _dialog = new DefinitionDialog( button.ToolType, BindingSource );
                    _dialog?.ShowDialog( this );
                    SetFormIcon( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [right click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
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

        /// <summary> Called when [SQL button click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnSqlButtonClick( object sender, EventArgs e )
        {
            if( !string.IsNullOrEmpty( SqlQuery )
               && sender is ToolStripButton _button )
            {
                try
                {
                    SetDialogIcon( _button.ToolType );
                    var _dialog = new SqlDialog( BindingSource );
                    _dialog.SqlEditor.Text = SqlQuery;
                    _dialog.ShowDialog( this );
                    SetFormIcon( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [start date selected]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnStartDateSelected( object sender, EventArgs e )
        {
            try
            {
                FirstCalendarTable.CaptionText = string.Empty;
                FirstCalendarTable.CaptionText = $"Start Date: {FirstCalendar?.SelectedDate}";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [end date selected]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnEndDateSelected( object sender, EventArgs e )
        {
            try
            {
                SecondCalendarTable.CaptionText = string.Empty;
                SecondCalendarTable.CaptionText = $"End Date: {SecondCalendar?.SelectedDate}";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [refresh data button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnRefreshDataButtonClicked( object sender, EventArgs e )
        {
            try
            {
                SelectedTable = string.Empty;
                DataGrid.DataSource = null;
                ClearSelections( );
                ClearCollections( );
                TabControl.SelectedIndex = 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [back button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnBackButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( Owner != null
                   && Owner.Visible == false )
                {
                    Owner.Visible = true;
                    Owner.Refresh( );
                    Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [RadioButton checked]. </summary>
        /// <param name="sender"> The sender. </param>
        private void OnRadioButtonChecked( object sender )
        {
            if( sender is RadioButton button )
            {
                try
                {
                    var _name = button.Tag?.ToString( );
                    if( !string.IsNullOrEmpty( _name ) )
                    {
                        Provider = (Provider)Enum.Parse( typeof( Provider ), _name );
                        SetFormIcon( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Called when [shown]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnShown( object sender, EventArgs e )
        {
            try
            {
                if( !Program.Windows.ContainsKey( "DataGridForm" ) )
                {
                    Program.Windows.Add( "DataGridForm", this );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Raises the Close event. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnClose( object sender, EventArgs e )
        {
            try
            {
                if( Program.Windows.ContainsKey( "DataGridForm" ) )
                {
                    Program.Windows.Remove( "DataGridForm" );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        static private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
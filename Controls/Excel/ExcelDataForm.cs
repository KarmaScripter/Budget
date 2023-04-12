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
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.CellGrid.Helpers;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.XlsIO;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "PossibleNullReferenceException" )]
    public partial class ExcelDataForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> FormFilter { get; set; }

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
        /// Gets or sets the row count.
        /// </summary>
        /// <value>
        /// The row count.
        /// </value>
        public int RowCount { get; set; }

        /// <summary>
        /// Gets or sets the col count.
        /// </summary>
        /// <value>
        /// The col count.
        /// </value>
        public int ColCount { get; set; }

        /// <summary>
        /// Gets or sets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        public SpreadsheetGrid Grid { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public SpreadsheetGridModel Model { get; set; }

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
        /// 
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ExcelDataForm( )
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
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;

            // Ribbon Properties
            Ribbon.Spreadsheet = Spreadsheet;

            // Event Wiring
            Load += OnLoad;
            RemoveFiltersButton.Click += null;
            TableButton.Click += null;
            LookupButton.Click += null;
            UploadButton.Click += null;
            MenuButton.Click += null;
            RemoveFiltersButton.Click += null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelDataForm"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public ExcelDataForm( string filePath )
            : this( )
        {
            Spreadsheet.Open( filePath );
            FilePath = filePath;
            FileName = Path.GetFileName( filePath );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelDataForm"/> class.
        /// </summary>
        /// <param name="fileStream">The file.</param>
        public ExcelDataForm( Stream fileStream )
            : this( )
        {
            Spreadsheet.Open( fileStream );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelDataForm"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ExcelDataForm( BindingSource bindingSource )
            : this( )
        {
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            Header.Text = $"{DataTable.TableName.SplitPascal( )} ";
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ExcelDataForm"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public ExcelDataForm( DataTable dataTable )
            : this( )
        {
            DataTable = dataTable;
            BindingSource.DataSource = dataTable;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            Header.Text = $"{DataTable.TableName.SplitPascal( )} ";
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The
        /// <see cref="System.EventArgs"/>
        /// instance containing the event data.</param>
        /// <returns></returns>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Header.ForeColor = Color.FromArgb( 0, 120, 212 );
                Header.Font = new Font( "Roboto", 12, FontStyle.Bold );
                Header.TextAlign = ContentAlignment.TopCenter;
                Header.MouseClick += OnRightClick;
                PictureBox.MouseClick += OnRightClick;
                RemoveFiltersButton.Click += OnRemoveFilterButtonClicked;
                LookupButton.Click += OnLookupButtonClicked;
                MenuButton.Click += OnMenuButtonClicked;
                UploadButton.Click += OnUploadButtonClicked;
                Ribbon.Spreadsheet = Spreadsheet;
                SetToolStripProperties( );
                SetTableProperties( DataTable );
                SetWorksheetProperties( );
                SetActiveGridProperties( );
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
                ToolStrip.Margin = new Padding( 1, 1, 1, 3 );
                ToolStrip.Visible = true;
                ToolStrip.Text = string.Empty;
                ToolStrip.Office12Mode = true;
                ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
                ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                ToolStrip.LauncherStyle = LauncherStyle.Office12;
                ToolStrip.ShowCaption = false;
                ToolStrip.ImageSize = new Size( 16, 16 );
                ToolStrip.ImageScalingSize = new Size( 16, 16 );
                ToolStripTextBox.Size = new Size( 190, 28 );
                ToolStripTextBox.ForeColor = Color.LightSteelBlue;
                ToolStripTextBox.Font = new Font( "Roboto", 8 );
                ToolStripTextBox.ForeColor = Color.White;
                ToolStripTextBox.TextBoxTextAlign = HorizontalAlignment.Center;
                ToolStripTextBox.Text = DateTime.Today.ToShortDateString( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the table properties.
        /// </summary>
        private void SetTableProperties( DataTable table )
        {
            if( table != null
               && table?.Rows?.Count > 0 )
            {
                try
                {
                    Spreadsheet?.SetActiveSheet( "Sheet1" );
                    Spreadsheet?.RenameSheet( "Sheet1", "Data" );
                    Spreadsheet?.SetZoomFactor( "Data", 100 );
                    Spreadsheet?.ActiveSheet?.ImportDataTable( table, true, 1, 1 );
                    Spreadsheet?.SetGridLinesVisibility( false );
                    var _activeSheet = Spreadsheet?.Workbook?.ActiveSheet;
                    var _usedRange = _activeSheet?.UsedRange;
                    var _table = _activeSheet?.ListObjects?.Create( table.TableName, _usedRange );
                    _usedRange.CellStyle.Font.FontName = "Roboto";
                    _usedRange.CellStyle.Font.Size = 10;
                    _usedRange.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    _usedRange.CellStyle.VerticalAlignment = ExcelVAlign.VAlignBottom;
                    var _topRow = _activeSheet?.Range[ 1, 1, 1, 60 ];
                    RowCount = DataTable.Rows.Count;
                    ColCount = DataTable.Columns.Count;
                    ToolStripTextBox.Text = $"  Rows: {RowCount}  Columns: {ColCount}";
                    _topRow?.FreezePanes( );
                    _table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium16;
                    Spreadsheet?.ActiveGrid?.InvalidateCells( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the worksheet properties.
        /// </summary>
        private void SetWorksheetProperties( )
        {
            try
            {
                Spreadsheet.DisplayAlerts = false;
                Spreadsheet.Font = new Font( "Roboto", 9 );
                Spreadsheet.AllowCellContextMenu = true;
                Spreadsheet.CanApplyTheme = true;
                Spreadsheet.CanOverrideStyle = true;
                Spreadsheet.Margin = new Padding( 1 );
                Spreadsheet.Padding = new Padding( 1 );
                Spreadsheet.ForeColor = Color.Black;
                Spreadsheet.DefaultColumnCount = 50;
                Spreadsheet.DefaultRowCount = 100;
                Spreadsheet.AllowZooming = true;
                Spreadsheet.AllowFiltering = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the active grid properties.
        /// </summary>
        private void SetActiveGridProperties( )
        {
            try
            {
                Spreadsheet.ActiveGrid.ContextMenuStrip = ContextMenu;
                Spreadsheet.ActiveGrid.FrozenRows = 2;
                Spreadsheet.ActiveGrid.AllowSelection = true;
                Spreadsheet.ActiveGrid.CanOverrideStyle = true;
                Spreadsheet.ActiveGrid.CanApplyTheme = true;
                Spreadsheet.ActiveGrid.BackColor = SystemColors.GradientInactiveCaption;
                Spreadsheet.ActiveGrid.MetroScrollBars = true;
                Spreadsheet.ActiveGrid.MetroColorTable = new MetroColorTable( );
                Spreadsheet.ActiveGrid.MetroColorTable.ScrollerBackground =
                    SystemColors.ControlDarkDark;
                Spreadsheet.ActiveGrid.MetroColorTable.ArrowNormalBackGround =
                    Color.FromArgb( 17, 69, 97 );

                Spreadsheet.ActiveGrid.MetroColorTable.ArrowPushed = Color.Green;
                Spreadsheet.ActiveGrid.MetroColorTable.ArrowNormalBorderColor = Color.Green;
                Spreadsheet.ActiveGrid.MetroColorTable.ThumbNormalBorderColor
                    = Color.LightSteelBlue;

                Spreadsheet.ActiveGrid.MetroColorTable.ThumbNormal
                    = Color.FromArgb( 17, 69, 97 );

                Spreadsheet.ActiveGrid.MetroColorTable.ThumbPushed
                    = Color.FromArgb( 17, 69, 97 );

                Spreadsheet.ActiveGrid.Font = new Font( "Roboto", 9 );
                Spreadsheet.ActiveGrid.ForeColor = Color.Black;
                Spreadsheet.ActiveGrid.ColumnCount = ColCount;
                Spreadsheet.ActiveGrid.RowCount = RowCount;
                Spreadsheet.ActiveGrid.DefaultColumnWidth = 110;
                Spreadsheet.ActiveGrid.DefaultRowHeight = 22;
                Spreadsheet.ActiveGrid.CellClick += OnCellClick;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void ShowFilterDialog( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void ShowGroupDialog( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void ShowTableDialog( )
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

        private void OpenChartDataForm( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OpenDataGridForm( )
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
                if( Owner?.Name.Equals( "DataGridForm" ) == true
                   || Owner?.Name.Equals( "ChartForm" ) == true )
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
                    var _chart = new ChartForm( BindingSource );
                    _chart.Show( );
                    Close( );
                }
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
        public void OnRightClick( object sender, MouseEventArgs e )
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
        /// Called when [lookup button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLookupButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.LookupButton )
                {
                    var _dialog = new FilterDialog( );
                    _dialog.TabControl.SelectedIndex = 0;
                    _dialog.ShowDialog( this );
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
                    var _filter = new FilterDialog( Source, Provider );
                    _filter.TabControl.SelectedIndex = 1;
                    _filter.ShowDialog( this );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [menu button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.MenuButton )
                {
                    if( Parent != null
                       && Parent.Name == "MainForm"
                       && Parent.Visible == false )
                    {
                        Parent.Visible = true;
                        Close( );
                    }
                    else
                    {
                        var _form = new MainForm( );
                        _form.Show( );
                        Close( );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [upload button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnUploadButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button
                   && _button.ToolType == ToolType.UploadButton )
                {
                    var _dialog = new LoadingForm( Status.Waiting );
                    _dialog.ShowDialog( this );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [cell enter].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnCellClick( object sender, GridCellClickEventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( Spreadsheet.CurrentCellValue ) )
                {
                    DateOnly _do;
                    DateTime _dt;
                    DateTimeOffset _dto;
                    double _numeric;
                    var _contents = Spreadsheet.CurrentCellValue;
                    var _chars = Spreadsheet.CurrentCellValue.ToCharArray( );
                    if( _contents.Length >= 6
                       && _contents.Length <= 9 )
                    {
                        if( _contents.Substring( 0, 3 ) == "000" )
                        {
                            var _code = _contents.Substring( 4, 2 );
                            var _dialog = new ProgramProjectDialog( _code );
                            _dialog.ShowDialog( );
                        }
                        else if( _chars.All( c => char.IsNumber( c ) ) )
                        {
                            var _value = double.TryParse( _contents, out _numeric );
                            var _calculator = new CalculationForm( _numeric );
                            _calculator.ShowDialog( );
                            Grid.SetCellValue( Spreadsheet.CurrentCellRange, 
                                _numeric.ToString( "N" ) );
                        }
                        else if( _contents.Length <= 20 
                                && ( _contents.EndsWith( "AM" )
                                    || _contents.EndsWith( "PM" ) ) )
                        {
                            if( DateTime.TryParse( _contents, out _dt ) )
                            {
                                var _calendar = new CalendarForm( );
                                _calendar.Calendar.SelectedDate = _dt;
                                _calendar.ShowDialog( );
                                Grid.SetCellValue( Spreadsheet.CurrentCellRange, 
                                    _dt.ToShortDateString( ) );
                            }
                            else if( DateTimeOffset.TryParse( _contents, out _dto ) )
                            {
                                var _calendar = new CalendarForm( );
                                _calendar.Calendar.SelectedDate = _dto.DateTime;
                                _calendar.ShowDialog( );
                                Grid.SetCellValue( Spreadsheet.CurrentCellRange,
                                    _dto.DateTime.ToShortDateString( ) );
                            }
                            else if( DateOnly.TryParse( _contents, out _do ) )
                            {
                                var _calendar = new CalendarForm( );
                                var _tm = new DateTime( _do.Year, _do.Month, _do.Day );
                                _calendar.Calendar.SelectedDate = _tm;
                                _calendar.ShowDialog( );
                                Grid.SetCellValue( Spreadsheet.CurrentCellRange,
                                    _tm.ToShortDateString( ) );
                            }
                        }
                        else if( _contents.Contains( "-" ) 
                                && _contents.Length >= 8 
                                && _contents.Length <= 10 )
                        {
                            if( DateTime.TryParse( _contents, out _dt ) )
                            {
                                var _calendar = new CalendarForm( );
                                _calendar.Calendar.SelectedDate = _dt;
                                _calendar.ShowDialog( );
                                Grid.SetCellValue( Spreadsheet.CurrentCellRange,
                                    _dt.ToShortDateString( ) );
                            }
                            else if( DateTimeOffset.TryParse( _contents, out _dto ) )
                            {
                                var _calendar = new CalendarForm( );
                                _calendar.Calendar.SelectedDate = _dto.DateTime;
                                _calendar.ShowDialog( );
                                Grid.SetCellValue( Spreadsheet.CurrentCellRange,
                                    _dto.DateTime.ToShortDateString( ) );
                            }
                            else if( DateOnly.TryParse( _contents, out _do ) )
                            {
                                var _calendar = new CalendarForm( );
                                var _tm = new DateTime( _do.Year, _do.Month, _do.Day );
                                _calendar.Calendar.SelectedDate = _tm;
                                _calendar.ShowDialog( );
                                Grid.SetCellValue( Spreadsheet.CurrentCellRange,
                                    _tm.ToShortDateString( ) );
                            }
                        }
                        else if( _contents.Contains( "//" ) 
                                && _contents.Length <= 20 )
                        {
                            if( DateTime.TryParse( _contents, out _dt ) )
                            {
                                var _calendar = new CalendarForm( );
                                _calendar.Calendar.SelectedDate = _dt;
                                _calendar.ShowDialog( );
                                Grid.SetCellValue( Spreadsheet.CurrentCellRange,
                                    _dt.ToShortDateString( ) );
                            }
                            else if( DateTimeOffset.TryParse( _contents, out _dto ) )
                            {
                                var _calendar = new CalendarForm( );
                                _calendar.Calendar.SelectedDate = _dto.DateTime;
                                _calendar.ShowDialog( );
                                Grid.SetCellValue( Spreadsheet.CurrentCellRange,
                                    _dto.DateTime.ToShortDateString( ) );
                            }
                            else if( DateOnly.TryParse( _contents, out _do ) )
                            {
                                var _calendar = new CalendarForm( );
                                var _tm = new DateTime( _do.Year, _do.Month, _do.Day );
                                _calendar.Calendar.SelectedDate = _tm;
                                _calendar.ShowDialog( );
                                Grid.SetCellValue( Spreadsheet.CurrentCellRange,
                                    _tm.ToShortDateString( ) );
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
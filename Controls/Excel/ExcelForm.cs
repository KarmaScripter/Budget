// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.XlsIO;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public partial class ExcelForm : MetroForm
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
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ExcelForm( )
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
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;
            ToolStripTextBox.Font = new Font( "Roboto", 8 );
            ToolStripTextBox.ForeColor = Color.White;

            // Ribbon Properties
            Ribbon.Spreadsheet = Spreadsheet;

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

            // Spreadsheet Properties
            Spreadsheet.AllowCellContextMenu = true;
            Spreadsheet.CanApplyTheme = true;
            Spreadsheet.CanOverrideStyle = true;
            Spreadsheet.Margin = new Padding( 1 );
            Spreadsheet.Padding = new Padding( 1 );
            Spreadsheet.Font = new Font( "Roboto", 8, FontStyle.Regular );
            Spreadsheet.ForeColor = Color.Black;
            Spreadsheet.DefaultColumnCount = 40;
            Spreadsheet.DefaultRowCount = 60;
            Spreadsheet.AllowZooming = true;
            Spreadsheet.AllowFiltering = true;

            // Event Wiring
            Load += OnLoad;
            LookupButton.Click += null;
            TableButton.Click += null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelForm"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public ExcelForm( string filePath )
            : this( )
        {
            Spreadsheet.Open( filePath );
            FilePath = filePath;
            FileName = Path.GetFileName( filePath );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelForm"/> class.
        /// </summary>
        /// <param name="fileStream">The file.</param>
        public ExcelForm( Stream fileStream )
            : this( )
        {
            Spreadsheet.Open( fileStream );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelForm"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ExcelForm( BindingSource bindingSource )
            : this( )
        {
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            Header.Text = $"{DataTable.TableName.SplitPascal( )} ";
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ExcelForm"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public ExcelForm( DataTable dataTable )
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
                BackButton.Click += OnBackButtonClicked;
                LookupButton.Click += OnLookupButtonClicked;
                Spreadsheet.MouseClick += OnRightClick;
                ToolStrip.Office12Mode = true;
                ToolStrip.Margin = new Padding( 1, 1, 1, 3 );
                Ribbon.Spreadsheet = Spreadsheet;
                SetTableProperties( DataTable );
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
                    Spreadsheet?.ActiveSheet?.ImportDataTable( DataTable, true, 1, 1 );
                    Spreadsheet?.SetGridLinesVisibility( false );
                    RowCount = DataTable.Rows.Count;
                    ColCount = DataTable.Columns.Count;
                    ToolStripTextBox.Text = $"  Rows: {RowCount}  Columns: {ColCount}";
                    var _activeSheet = Spreadsheet?.Workbook?.ActiveSheet;
                    var _name = table.TableName ?? "DataTable";
                    var _usedRange = _activeSheet?.UsedRange;
                    var _table = _activeSheet?.ListObjects?.Create( _name, _usedRange );
                    var _topRow = _activeSheet?.Range[ 1, 1, 1, 60 ];
                    if( _topRow != null )
                    {
                        _topRow.AutofitColumns( );
                        _topRow.FreezePanes( );
                    }

                    var _activeGrid = Spreadsheet?.ActiveGrid;
                    if( _activeGrid != null )
                    {
                        _activeGrid.FrozenRows = 2;
                    }

                    if( _table != null )
                    {
                        _table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium16;
                    }

                    Spreadsheet?.ActiveGrid?.InvalidateCells( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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
                    if( Owner?.Visible == false )
                    {
                        Owner.Visible = true;
                    }

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
                    var _dialog = new FilterDialog( BindingSource );
                    _dialog.ShowDialog( this );
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
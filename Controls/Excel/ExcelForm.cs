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
    using Syncfusion.XlsIO;
    using Size = System.Drawing.Size;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
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
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ExcelForm( )
        {
            InitializeComponent( );

            // Basic Properties
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size( 1400, 800 );
            MaximumSize = new Size( 1400, 800 );
            MinimumSize = new Size( 1400, 750  );
            FormBorderStyle = FormBorderStyle.Sizable;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            FormBorderStyle = FormBorderStyle.Sizable;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = true;
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;
            ToolStrip.Label.Margin = new Padding( 1, 1, 1, 3 );
            ToolStrip.Text = string.Empty;
            
            // Ribbon Properties
            Ribbon.Spreadsheet = Spreadsheet;
            
            // Spreadsheet Properties
            Spreadsheet.AllowCellContextMenu = true;
            Spreadsheet.CanApplyTheme = true;
            Spreadsheet.CanOverrideStyle = true;
            Spreadsheet.Margin = new Padding( 1 );
            Spreadsheet.Padding = new Padding( 1 );
            Spreadsheet.Font = new Font( "Roboto", 9, FontStyle.Regular );
            Spreadsheet.ForeColor = Color.Black;
            Spreadsheet.DefaultColumnCount = 40;
            Spreadsheet.DefaultRowCount = 60;
            Spreadsheet.AllowZooming = true;
            Spreadsheet.AllowFiltering = true;
            
            // Event Wiring
            Load += OnLoad;
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
                Text = @"Excel Document";
                BackButton.Click += OnBackButtonClicked;
                ToolStrip.Office12Mode = true;
                ToolStrip.Label.ForeColor = Color.Black;
                ToolStrip.Margin = new Padding( 1, 1, 1, 3 );
                ToolStrip.Label.Text = $"{ DataTable?.TableName?.SplitPascal( ) }";
                Ribbon.Spreadsheet = Spreadsheet;
                PopulateToolBarDropDownItems( );
                SetTableProperties( DataTable );
            }
            catch ( Exception ex )
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
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData(  );
                var _names = _data
                    ?.Where( dr => dr.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.Select( dr => dr.Field<string>( "TableName" ) )
                    ?.ToList(  );
                
                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var name = _names[ _i ];
                    DropDown.Items.Add( name );
                }
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
                    Spreadsheet?.ActiveSheet?.ImportDataTable( DataTable, true, 1, 1 );
                    Spreadsheet?.SetZoomFactor( "Sheet1", 100 );
                    Spreadsheet?.SetGridLinesVisibility( false );
                    RowCount = DataTable.Rows.Count;
                    ColCount = DataTable.Columns.Count;
                    var _activeSheet = Spreadsheet?.Workbook?.ActiveSheet;
                    var _name = table.TableName ?? "DataTable";
                    var _usedRange = _activeSheet?.UsedRange;
                    var _table = _activeSheet?.ListObjects?.Create( _name, _usedRange );
                    var _topRow = _activeSheet?.Range[ 1, 1, 1, 60 ];
                    _topRow?.AutofitColumns(  );
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
                    Close(  );
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
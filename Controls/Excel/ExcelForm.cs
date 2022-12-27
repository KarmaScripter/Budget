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
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Size = System.Drawing.Size;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class ExcelForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the icon path.
        /// </summary>
        /// <value>
        /// The icon path.
        /// </value>
        public string IconPath { get; set; }

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
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size( 1400, 750 );
            MaximumSize = new Size( 1400, 800 );
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
            CaptionButtonHoverColor = Color.Red;
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
            Spreadsheet.DefaultColumnCount = 26;
            Spreadsheet.DefaultRowCount = 55;
            Spreadsheet.AllowZooming = true;
            
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
                ToolStrip.Office12Mode = true;
                ToolStrip.Label.ForeColor = Color.Black;
                ToolStrip.Margin = new Padding( 1, 1, 1, 3 );
                Ribbon.Spreadsheet = Spreadsheet;
                if( DataTable != null )
                {
                    ToolStrip.Label.Text = $"{ DataTable.TableName.SplitPascal( ) }";
                    Spreadsheet.SetActiveSheet( "Sheet1" );
                    Spreadsheet.ActiveSheet.ImportDataTable( DataTable, true, 1, 1 );
                    Spreadsheet.SetZoomFactor( "Sheet1", 100 );
                }
            }
            catch ( Exception ex )
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
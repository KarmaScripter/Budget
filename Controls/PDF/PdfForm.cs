// <copyright file = "PdfForm.cs" company = "Terry D.Eppler">
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
    using Syncfusion.Pdf.Parsing;
    using Syncfusion.Windows.Forms;

    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" )]
    [SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" )]
    public partial class PdfForm : MetroForm
    {
        public string FilePath { get; set; }

        public string DirectoryPath { get; set; }

        public string FileName { get; set; }

        public PdfLoadedDocument Document { get; set; }

        public DataTable DataTable { get; set; }

        public PdfForm( )
        {
            InitializeComponent( );

            // Basic Properties
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderThickness = 2;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            StartPosition = FormStartPosition.CenterScreen;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = false;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarHeight = 5;
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;

            // Event Wiring
            CloseButton.Click += OnCloseButtonClick;
            MenuButton.Click += OnMainMenuButtonClicked;
            BackButton.Click += OnBackButtonClicked;
            DataGridButton.Click += OnDataGridButtonClick;
            ChartButton.Click += OnChartButtonClick;
            ExcelButton.Click += OnExcelButtonClick;
            ListBox.SelectedValueChanged += OnListBoxItemSelected;
            Load += OnLoad;
            Shown += OnShown;
            Closing += OnClosing;
        }

        public PdfForm( string filePath )
            : this( )
        {
            FilePath = filePath;
            FileName = Path.GetFileName( filePath );
        }

        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                DirectoryPath = ConfigurationManager.AppSettings[ "Documents" ];
                var _path = DirectoryPath + @"\\ApplicationLandingDocument.pdf";
                HeaderLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
                HeaderLabel.Text = "Budget Guidance";
                DataTable = new DataBuilder( Source.Resources, Provider.Access ).DataTable;
                Document = new PdfLoadedDocument( _path );
                DocViewer.Load( Document );
                PopulateItems( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

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

        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }

        private void PopulateItems( )
        {
            try
            {
                var _criteria = new Dictionary<string, object>( );
                _criteria.Add( "FileExtension", "PDF" );
                var _dataRows = DataTable.Filter( _criteria );
                foreach( var row in _dataRows )
                {
                    var _name = row[ "Caption" ].ToString( );
                    ListBox.Items.Add( _name );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OpenMainForm( )
        {
            try
            {
                if( ( Owner != null )
                   && ( Owner.Visible == false )
                   && ( Owner.GetType( ) == typeof( MainForm ) ) )
                {
                    Owner.Visible = true;
                    Close( );
                }
                else if( ( Owner != null )
                        && ( Owner.Visible == false )
                        && ( Owner.GetType( ) != typeof( MainForm ) ) )
                {
                    var _mainForm = Program.Windows[ "MainForm" ];
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

        private void OpenExcelDataForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( _forms?.Any( f => f.GetType( ) == typeof( ExcelDataForm ) ) == true )
                {
                    var _excelDataForm = _forms?.Where( f => f.GetType( ) == typeof( ExcelDataForm ) )?.First( );
                    _excelDataForm.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _excelDataForm = new ExcelDataForm( BindingSource );
                    _excelDataForm.Owner = this;
                    _excelDataForm.Show( );
                    Visible = false;
                }
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
                var _forms = Program.Windows.Values;
                if( _forms?.Any( f => f.GetType( ) == typeof( DataGridForm ) ) == true )
                {
                    var _dataGridForm = _forms?.Where( f => f.GetType( ) == typeof( DataGridForm ) )?.First( );
                    _dataGridForm.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _dataGridForm = new DataGridForm( );
                    _dataGridForm.Owner = this;
                    _dataGridForm.Show( );
                    Visible = false;
                }
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
                var _forms = Program.Windows.Values;
                if( _forms?.Any( f => f.GetType( ) == typeof( ChartDataForm ) ) == true )
                {
                    var _chartDataForm = _forms?.Where( f => f.GetType( ) == typeof( ChartDataForm ) )?.First( );
                    _chartDataForm.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _chartDataForm = new ChartDataForm( BindingSource );
                    _chartDataForm.Owner = this;
                    _chartDataForm.Show( );
                    Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnDataGridButtonClick( object sender, EventArgs e )
        {
            try
            {
                OpenDataGridForm( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnExcelButtonClick( object sender, EventArgs e )
        {
            try
            {
                OpenExcelDataForm( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnChartButtonClick( object sender, EventArgs e )
        {
            try
            {
                OpenChartDataForm( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnCloseButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( ( Owner != null )
                   && ( Owner.Visible == false ) )
                {
                    Owner.Visible = true;
                    Owner.Refresh( );
                    Close( );
                }
                else
                {
                    Close( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnBackButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( ( Owner != null )
                   && ( Owner.Visible == false ) )
                {
                    Owner.Visible = true;
                    Owner.Refresh( );
                    Visible = false;
                }
                else
                {
                    Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnShown( object sender, EventArgs e )
        {
            try
            {
                if( !Program.Windows.ContainsKey( "PdfForm" ) )
                {
                    Program.Windows.Add( "PdfForm", this );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnClosing( object sender, EventArgs e )
        {
            try
            {
                if( Program.Windows.ContainsKey( "PdfForm" ) )
                {
                    Program.Windows.Remove( "PdfForm" );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void OnListBoxItemSelected( object sender )
        {
            if( sender is ListBox listBox
               && ( DataTable != null ) )
            {
                try
                {
                    var _data = DataTable.AsEnumerable( );
                    var _caption = listBox.SelectedValue.ToString( );
                    var _file = _data?.Where( p => p.Field<string>( "Caption" ).Equals( _caption ) )?.Select( p => p.Field<string>( "Location" ) )?.Single( );
                    var _prefix = @"C:\Users\terry\source\repos\Budget\";
                    HeaderLabel.Text = _caption;
                    var _path = _prefix + _file;
                    Document = new PdfLoadedDocument( _path );
                    DocViewer.Load( Document );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
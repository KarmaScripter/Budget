// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Pdf;
    using Syncfusion.Pdf.Parsing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.PdfViewer;
    using Syncfusion.Windows.Forms.Spreadsheet;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class PdfForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the directory path.
        /// </summary>
        /// <value>
        /// The directory path.
        /// </value>
        public string DirectoryPath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        public PdfLoadedDocument Document { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfForm"/> class.
        /// </summary>
        public PdfForm( )
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
            ShowMouseOver = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 12 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.Red;
            MinimizeBox = false;
            MaximizeBox = false;
            ToolStrip.Text = string.Empty;
            
            // Event Wiring
            Load += OnLoad;
            ToolStrip.DropDown.SelectedIndexChanged += OnDropDownItemSelected;
        }

        /// <summary>
        /// Initializes a new
        /// instance of the <see cref="PdfForm"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public PdfForm( string filePath ) 
            : this( )
        {
            FilePath = filePath;
            FileName = Path.GetFileName( filePath );
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Text = @"PDF Document";
                BackButton.Click += OnBackButtonClicked;
                ToolStrip.Office12Mode = true;
                ToolStrip.Label.ForeColor = Color.Black;
                ToolStrip.Label.Margin = new Padding( 1, 1, 1, 3 );
                ToolStrip.ShowCaption = false;
                ToolStrip.Label.Text = "Guidance Documents";
                DirectoryPath = ConfigurationManager.AppSettings[ "Documents" ];
                var _path = DirectoryPath + @"\\ApplicationLandingDocument.pdf";
                Document = new PdfLoadedDocument( _path );
                DocViewer.Load( Document );
                LoadDocuments(  );
            }
            catch ( Exception ex )
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
                    Close(  );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the document name list.
        /// </summary>
        /// <returns></returns>
        private void LoadDocuments( )
        {
            try
            {
                if( !string.IsNullOrEmpty( DirectoryPath )
                   && Directory.Exists( DirectoryPath ) )
                {
                    var _names = Directory.GetFiles( DirectoryPath );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _file = _names[ _i ];
                        var _name = Path.GetFileNameWithoutExtension( _file );
                        if( !string.IsNullOrEmpty( _name ) 
                           && _name != "ApplicationLandingDocument" )
                        {
                            ToolStrip.DropDown.Items.Add( _name.SplitPascal(  ) );
                        }
                    }
                }
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [drop down item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnDropDownItemSelected( object sender, EventArgs e )
        {
            try
            {
                var _index = ToolStrip.DropDown.SelectedIndex;
                var _item = ToolStrip.DropDown.Items[ _index ].ToString( );
                var _name = _item?.Replace( " ", "" );
                var _path = DirectoryPath + $"\\{ _name }" + ".pdf";
                Document = new PdfLoadedDocument( _path );
                DocViewer.Load( Document );
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
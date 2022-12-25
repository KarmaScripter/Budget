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
    using Syncfusion.Windows.Forms;

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
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfForm"/> class.
        /// </summary>
        public PdfForm( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1400, 750 );
            MaximumSize = new Size( 1400, 800 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            FormBorderStyle = FormBorderStyle.Sizable;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = true;
            ShowInTaskbar = true;
            ShowMouseOver = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
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
                ToolStrip.Office12Mode = true;
                ToolStrip.Label.ForeColor = Color.Black;
                ToolStrip.Label.Margin = new Padding( 1, 1, 1, 3 );
                ToolStrip.ShowCaption = true;
                if( !string.IsNullOrEmpty( FileName ) )
                {
                    ToolStrip.Label.Text = FileName;
                }
                LoadDocuments(  );
            }
            catch ( Exception ex )
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
                var _documentPath = ConfigurationManager.AppSettings[ "Documents" ];

                if( !string.IsNullOrEmpty( _documentPath )
                   && Directory.Exists( _documentPath ) )
                {
                    var _names = Directory.GetFiles( _documentPath );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _file = _names[ _i ];
                        var _name = Path.GetFileNameWithoutExtension( _file );
                        ToolStrip.DropDown.Items.Add( _name );
                    }
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
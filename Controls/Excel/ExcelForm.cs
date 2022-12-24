﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using DataTable = DocumentFormat.OpenXml.Drawing.Charts.DataTable;
    using Size = System.Drawing.Size;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class ExcelForm : MetroForm
    {
        /// <summary>
        /// 
        /// </summary>
        public ExcelForm( )
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
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20);
            CaptionFont = new Font( "Roboto", 12 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.Red;
            ShowMouseOver = true;
            MinimizeBox = false;
            MaximizeBox = false;
            
            // Event Wiring
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelForm"/> class.
        /// </summary>
        /// <param name="bindingSource">
        /// The binding source.
        /// </param>
        public ExcelForm( BindingSource bindingSource ) 
            : this( )
        {
            BindingSource = bindingSource;
            ToolStrip.BindingSource = bindingSource;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelForm"/> class.
        /// </summary>
        /// <param name="dataTable">
        /// The data table.</param>
        public ExcelForm( DataTable dataTable ) 
            : this( )
        {
            BindingSource.DataSource = dataTable;
            ToolStrip.BindingSource = BindingSource;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelForm"/> class.
        /// </summary>
        /// <param name="dataRows">
        /// The data rows.</param>
        public ExcelForm( IEnumerable<DataRow> dataRows ) 
            : this( )
        {
            BindingSource.DataSource = dataRows.CopyToDataTable( );
            ToolStrip.BindingSource = BindingSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelForm"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public ExcelForm( string filePath ) 
            : this( )
        {
            Spreadsheet.Open( filePath );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelForm"/> class.
        /// </summary>
        /// <param name="file">The file.</param>
        public ExcelForm( FileStream file ) 
            : this( )
        {
            Spreadsheet.Open( file );
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
                ToolStrip.Office12Mode = true;
                ToolStrip.Label.ForeColor = Color.Black;
                Ribbon.Spreadsheet = Spreadsheet;
                Spreadsheet.DefaultColumnCount = 12;
                Spreadsheet.DefaultRowCount = 55;
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
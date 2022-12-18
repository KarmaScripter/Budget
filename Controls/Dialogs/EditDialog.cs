﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class EditDialog : EditBase
    {
        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public DataRow Current { get; set; }

        /// <summary>
        /// Gets or sets the frames.
        /// </summary>
        /// <value>
        /// The frames.
        /// </value>
        public IEnumerable<Frame> Frames { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        public EditDialog( )
        {
            InitializeComponent( );
            
            // Basic Properties
            Size = new Size( 1380, 600 );
            TabPage.TabFont = new Font( "Roboto", 9, FontStyle.Bold );
            TabPage.TabForeColor = Color.FromArgb( 0, 120, 212 );
            SelectButton.Text = "Save";
            CloseButton.Text = "Exit";
            Frames = GetFrames( );
            TabPages = GetTabPages( );
            
            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="bindingSource">The binding source.</param>
        public EditDialog( ToolType toolType, BindingSource bindingSource ) 
            : this( )
        {
            ToolType = toolType;
            BindingSource = bindingSource;
            DataTable = BindingSource.GetDataTable(  );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataModel = new DataBuilder( Source, Provider.Access );
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="dataModel">The data model.</param>
        public EditDialog( ToolType toolType, DataBuilder dataModel )
            : this( )
        {
            ToolType = toolType;
            DataModel = dataModel;
            Provider = dataModel.Provider;
            Source = dataModel.Source;
            CommandType = dataModel.SqlStatement.CommandType;
            BindingSource.DataSource = dataModel.DataTable;
            DataTable = dataModel.DataTable;
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public EditDialog( ToolType toolType, Source source, Provider provider = Provider.Access )
            : this( )
        {
            ToolType = toolType;
            Provider = provider;
            Source = source;
            DataModel = new DataBuilder( source, provider );
            DataTable = DataModel.DataTable;
            BindingSource.DataSource = DataModel.DataTable;
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SetActiveTab( );
                SetTableLocation( );
                SetFrameColors( );
                SetFrameDockStyle( );
                BindRecordData( );
                SetFrameVisibility( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the activet tab.
        /// </summary>
        public void SetActiveTab( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    switch( ToolType )
                    {
                        case ToolType.CopyButton:
                        {
                            TabPage.Text = "Copy Data";
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.AddRecordButton:
                        {
                            TabPage.Text = "Add Record";
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.AddButton:
                        {
                            TabPage.Text = "Add Data";
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.EditRecordButton:
                        {
                            TabPage.Text = "Edit Record";
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.DeleteRecordButton:
                        {
                            TabPage.Text = "Delete Data";
                            ActiveTab = TabPage;
                            SelectButton.Text = "Delete";
                            break;
                        }
                        default:
                        {
                            TabPage.Text = "Edit Data";
                            ActiveTab = TabPage;
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

        /// <summary>
        /// Sets the frame visibility.
        /// </summary>
        public void SetFrameVisibility( )
        {
            if( Frames?.Any( ) == true )
            {
                try
                {
                    var _cols = Columns.ToArray( );
                    foreach( var frame in Frames )
                    {
                        if( frame.Index >= _cols.Length )
                        {
                            frame.Visible = false;
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
        /// Sets the frame dock style.
        /// </summary>
        public void SetFrameDockStyle( )
        {
            if( Frames?.Any( ) == true )
            {
                try
                {
                    foreach( var _frame in Frames )
                    {
                        _frame.Dock = DockStyle.Fill;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the frame colors.
        /// </summary>
        public void SetFrameColors( )
        {
            if( Frames?.Any( ) == true )
            {
                foreach( var frame in Frames )
                {
                    frame.Label.ForeColor = Color.LightSteelBlue;
                    frame.TextBox.ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Sets the row location.
        /// </summary>
        public void SetTableLocation( )
        {
            if( FrameTable != null
               && Columns?.Any( ) == true )
            {
                try
                {
                    var _cols = Columns.ToArray( );
                    switch( _cols.Length )
                    {
                        case >= 43:
                        case < 43 and >= 35:
                            FrameTable.Location = new Point( 12, 25 );
                            break;
                        case < 35 and >= 28:
                        case < 28 and >= 21:
                        case < 21 and >= 14:
                        case < 14 and > 7:
                        case <= 7:
                            FrameTable.Location = new Point( 12, 81 );
                            break;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Binds the record data.
        /// </summary>
        public void BindRecordData( )
        {
            if( Current != null
               && Frames?.Any( ) == true
               && Columns?.Any( ) == true )
            {
                try
                {
                    var _items = Current.ItemArray;
                    var _frames = Frames.OrderBy( f => f.Index ).ToArray( );
                    var _cols = Columns.ToArray( );
                    for( var i = 0; i < _cols.Length; i++ )
                    {
                        _frames[ i ].Label.Text = _cols[ i ].SplitPascal( );
                        _frames[ i ].TextBox.Text = _items[ i ]?.ToString( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, TabPageAdv> GetTabPages( )
        {
            if( TabControl?.TabPages?.Count > 0 )
            {
                try
                {
                    var _tabPages = new Dictionary<string, TabPageAdv>( );
                    foreach( TabPageAdv tabpage in TabControl.TabPages )
                    {
                        if( tabpage != null )
                        {
                            _tabPages.Add( tabpage.Name, tabpage );
                        }
                    }
                    return _tabPages?.Any( ) == true
                        ? _tabPages
                        : default( IDictionary<string, TabPageAdv> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the frames.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Frame> GetFrames( )
        {
            try
            {
                var _frames = new List<Frame>( );
                for( var _i = 0; _i < FrameTable.Controls.Count; _i++ )
                {
                    var _control = FrameTable.Controls[ _i ];
                    if( _control.GetType( ) == typeof( Frame ) )
                    {
                        if( _control is Frame _frame )
                        {
                            _frame.BindingSource = BindingSource;
                            _frames.Add( _frame );
                        }
                    }
                }

                return _frames?.Any( ) == true
                    ? _frames.OrderBy( f => f.Index ).ToArray( )
                    : default( IEnumerable<Frame> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}
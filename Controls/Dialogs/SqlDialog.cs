﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using System.IO;
    using System.Linq;
    using CheckState = MetroSet_UI.Enums.CheckState;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class SqlDialog : EditBase
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
        /// Gets or sets the database folder.
        /// </summary>
        /// <value>
        /// The database folder.
        /// </value>
        public string DatabaseDirectory { get; set; }
        
        public string SelectedCommand { get; set; }

        public string SelectedQuery { get; set; }
        
        public IList<string> Commands { get; set; }

        public IDictionary<string, object> Statements { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDialog"/> class.
        /// </summary>
        public SqlDialog( )
        {
            InitializeComponent( );
            
            // Basic Properties
            Size = new Size( 1380, 675 );
            TabPage.TabForeColor = Color.FromArgb( 0, 120, 212 );
            FirstButton.Text = "Save";
            ThirdButton.Text = "Exit";
            DatabaseDirectory = @"C:\Users\terry\source\repos\Budget\Data\Database\";
            
            // Event Wiring
            ThirdButton.Click += OnCloseButtonClicked;
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDialog"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="provider">The provider.</param>
        public SqlDialog( BindingSource bindingSource, Provider provider = Provider.Access )
            : this( )
        {
            ToolType = ToolType.EditSqlButton;
            BindingSource = bindingSource;
            Provider = provider;
            DataTable = BindingSource.GetDataTable(  );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataModel = new DataBuilder( Source, Provider );
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
            Commands = new List<string>( );
            Statements = new Dictionary<string, object>( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="provider">The provider.</param>
        public SqlDialog( ToolType toolType, BindingSource bindingSource,
            Provider provider = Provider.Access  ) 
            : this( )
        {
            ToolType = toolType;
            BindingSource = bindingSource;
            Provider = provider;
            DataTable = BindingSource.GetDataTable(  );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataModel = new DataBuilder( Source, Provider );
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public SqlDialog( ToolType toolType, Source source, Provider provider = Provider.Access )
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                AccessRadioButton.Checked = true;
                Commands = new List<string>( );
                Statements = new Dictionary<string, object>( );
                AccessRadioButton.Click += OnRadioButtonChecked;
                SQLiteRadioButton.Click += OnRadioButtonChecked;
                SqlCeRadioButton.Click += OnRadioButtonChecked;
                SqlServerRadioButton.Click += OnRadioButtonChecked;
                SqlComboBox.SelectedValueChanged += OnComboBoxItemSelected;
                SqlListBox.SelectedValueChanged += OnListBoxItemSelected;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the provider.
        /// </summary>
        /// <param name="provider">The provider.</param>
        private void SetProvider( string provider )
        {
            if( !string.IsNullOrEmpty( provider ) )
            {
                try
                {
                    var _provider = (Provider)Enum.Parse( typeof( Provider ), provider );
                    if( Enum.IsDefined( typeof( Provider ), _provider ) )
                    {
                        Commands.Clear( );
                        switch( _provider )
                        {
                            case Provider.Access:
                            {
                                Provider = Provider.Access;
                                AccessRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            case Provider.SQLite:
                            {
                                Provider = Provider.SQLite;
                                SQLiteRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            case Provider.SqlCe:
                            {
                                Provider = Provider.SqlCe;
                                SqlCeRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            case Provider.SqlServer:
                            {
                                Provider = Provider.SqlServer;
                                SqlServerRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            default:
                            {
                                Provider = Provider.Access;
                                AccessRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
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

        /// <summary>
        /// Populates the SQL ComboBox.
        /// </summary>
        /// <param name="list">The list.</param>
        private void PopulateSqlComboBox( IList<string> list )
        {
            if( list?.Any( ) == true )
            {
                try
                {
                    var _commands = Enum.GetNames( typeof( SQL ) );
                    SqlComboBox.Items.Clear( );
                    SqlListBox.Items.Clear( );
                    for( var _i = 0; _i < list.Count; _i++ )
                    {
                        if( _commands.Contains( list[ _i ] ) 
                           && list[ _i ].Equals( $"{ SQL.CREATEDATABASE }" ) )
                        {
                            SqlComboBox.Items.Add( "CREATE DATABASE" );
                        }
                        else if( _commands.Contains( list[ _i ] ) 
                                && list[ _i ].Equals( $"{ SQL.CREATETABLE }" ) )
                        {
                            SqlComboBox.Items.Add( "CREATE TABLE"  );
                        }
                        else if( _commands.Contains( list[ _i ] ) 
                                && list[ _i ].Equals( $"{ SQL.ALTERTABLE }" ) )
                        {
                            SqlComboBox.Items.Add( "ALTER TABLE"  );
                        }
                        else if( _commands.Contains( list[ _i ] ) 
                                && list[ _i ].Equals( $"{ SQL.CREATEVIEW }" ) )
                        {
                            SqlComboBox.Items.Add( "CREATE VIEW"  );
                        }
                        else if( _commands.Contains( list[ _i ] ) 
                                && list[ _i ].Equals( $"{ SQL.SELECTALL }" ) )
                        {
                            SqlComboBox.Items.Add( "SELECT ALL"  );
                        }
                        else if( _commands.Contains( list[ _i ] ) )
                        {
                            SqlComboBox.Items.Add( list[ _i ]  );
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
        /// Gets the command list.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private IList<string> CreateCommandList( Provider provider )
        {
            try
            {
                if( Enum.IsDefined( typeof( Provider ), provider ) )
                {
                    var _path = DatabaseDirectory + @$"\{ provider }\DataModels\";
                    var _names = Directory.GetDirectories( _path );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = Directory.CreateDirectory( _names[ _i ] ).Name;
                        if( !string.IsNullOrEmpty( _folder ) )
                        {
                            _list.Add( _folder );
                        }
                    }

                    return _list?.Count > 0
                        ? _list
                        : default( IList<string> );
                }
                
                return default( IList<string> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Creates the query list.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private IList<string> CreateQueryList( Provider provider )
        {
            try
            {
                if( Enum.IsDefined( typeof( Provider ), provider ) )
                {
                    var _path = DatabaseDirectory + @$"\{ provider }\DataModels\";
                    var _names = Directory.GetDirectories( _path );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = Directory.CreateDirectory( _names[ _i ] ).Name;
                        if( !string.IsNullOrEmpty( _folder ) )
                        {
                            _list.Add( _folder );
                        }
                    }

                    return _list?.Count > 0
                        ? _list
                        : default( IList<string> );
                }

                return default( IList<string> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IList<string> );
            }
        }

        private string GetQueryText( )
        {
            try
            {
                return string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Called when [RadioButton checked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnRadioButtonChecked( object sender, EventArgs e )
        {
            if( sender is RadioButton _button )
            {
                try
                {
                    var _tag = _button.Tag?.ToString(  );
                    if( !string.IsNullOrEmpty( _tag ) )
                    {
                        SetProvider( _tag );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SelectedCommand = _comboBox.SelectedItem?.ToString( );
                    SqlListBox.Items.Clear(  );
                    if( SelectedCommand?.Contains( " " ) == true )
                    {
                        var _folder = SelectedCommand.Replace( " ", "" );
                        var _path = DatabaseDirectory + @$"\{ Provider }\DataModels\{ _folder }";
                        var _files = Directory.GetFiles( _path );
                        for( var _i = 0; _i < _files.Length; _i++ )
                        {
                            var _item = Path.GetFileNameWithoutExtension( _files[ _i ] );
                            var _caption = _item?.SplitPascal(  );
                            SqlListBox.Items.Add( _caption );
                        }
                    }
                    else
                    {
                        var _path = DatabaseDirectory + @$"\{ Provider }\DataModels\{ SelectedCommand }";
                        var _names = Directory.GetFiles( _path );
                        for( var _i = 0; _i < _names.Length; _i++ )
                        {
                            var _item = Path.GetFileNameWithoutExtension( _names[ _i ] );
                            var _caption = _item?.SplitPascal(  );
                            SqlListBox.Items.Add( _caption );
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
        /// Called when [ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    Editor.Text = string.Empty;
                    SelectedQuery = _listBox.SelectedItem?.ToString( );
                    if( SelectedQuery?.Contains( " " ) == true 
                       || SelectedCommand?.Contains( " " ) == true )
                    {
                        var _command = SelectedCommand?.Replace( " ", "" );
                        var _query = SelectedQuery?.Replace( " ", "" );
                        var _filePath = DatabaseDirectory 
                            + @$"\{ Provider }\DataModels\{ _command }\{ _query }.sql";
                        var _stream = File.OpenRead( _filePath );
                        var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        Editor.Text = _text;
                    }
                    else
                    {
                        var _path = DatabaseDirectory 
                            + @$"\{ Provider }\DataModels\{ SelectedCommand }\{ SelectedQuery }.sql";
                        var _stream = File.OpenRead( _path );
                        var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        Editor.Text = _text;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}

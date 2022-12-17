﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="EditBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class DefinitionDialog : EditBase
    {
        /// <summary>
        /// Gets or sets the sqlite data types.
        /// </summary>
        /// <value>
        /// The sqlite data types.
        /// </value>
        public override IEnumerable<string> DataTypes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinitionDialog"/> class.
        /// </summary>
        public DefinitionDialog( )
        {
            InitializeComponent( );
            TabPages = GetTabPages( );
            Panels = GetPanels( );
            ListBoxes = GetListBoxes( );
            RadioButtons = GetRadioButtons( );
            ComboBoxes = GetComboBoxes( );
            TabControl.TabPanelBackColor = Color.FromArgb( 15, 15, 15 );
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of 
        /// the <see cref="DefinitionDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        public DefinitionDialog( ToolType toolType )
            : this( )
        {
            Provider = Provider.Access;
            ToolType = toolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinitionDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="bindingSource">The binding source.</param>
        public DefinitionDialog( ToolType toolType, BindingSource bindingSource )
            : this( toolType )
        {
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            BindingSource.DataSource = DataTable;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            Columns = DataTable.GetColumnNames( );
        }
        
        /// <summary>
        /// Called when [visible].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SetRadioButtonProperties( );
                PopulateTableListBoxItems( );
                PopulateComboBoxes( );
                SetActiveTab( );
                CloseButton.Text = "Exit";
                DataTypes = GetDataTypes( Provider );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the table ListBox items.
        /// </summary>
        public void PopulateTableListBoxItems( )
        {
            try
            {
                var _names = Enum.GetNames( typeof( Source ) );
                for( var i = 0; i < _names?.Length; i++ )
                {
                    if( _names[ i ] != "NS" )
                    {
                        EditColumnTableNameListBox.Items.Add( _names[ i ] );
                        DeleteColumnTableListBox.Items.Add( _names[ i ] );
                        DeleteTableTablesListBox.Items.Add( _names[ i ] );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the data type combo boxes.
        /// </summary>
        public void PopulateComboBoxes( )
        {
            if( DataTypes?.Any( ) == true )
            {
                try
                {
                    EditColumnDataTypeComboBox.SelectedText = string.Empty;
                    CreateTableDataTypeComboBox.SelectedText = string.Empty;
                    EditColumnDataTypeComboBox.Items.Clear( );
                    CreateTableDataTypeComboBox.Items.Clear( );
                    var _types = DataTypes.ToArray( );
                    for( var i = 0; i < _types?.Length; i++ )
                    {
                        if ( !string.IsNullOrEmpty( _types[ i ] ) )
                        {
                            EditColumnDataTypeComboBox.Items.Add( _types[ i ] );
                            CreateTableDataTypeComboBox.Items.Add( _types[ i ] );
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
        /// Called when [provider button checked].
        /// </summary>
        /// <param name="sender">The sender.</param> 
        public virtual void OnProviderButtonChecked( object sender )
        {
            if( sender is RadioButton button )
            {
                try
                {
                    var _name = button.Tag?.ToString( );
                    if ( !string.IsNullOrEmpty( _name ) )
                    {
                        Provider = (Provider)Enum.Parse( typeof( Provider ), _name );
                    }

                    DataTypes = GetDataTypes( Provider );
                    PopulateComboBoxes( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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
                        case ToolType.AddColumnButton:
                        {
                            EditColumnTabPage.Text = "Add Column";
                            ActiveTab = EditColumnTabPage;
                            Provider = Provider.Access;
                            EditColumnAccessRadioButton.Checked = true;
                            EditColumnAccessRadioButton.CheckedChanged += OnProviderButtonChecked;
                            EditColumnSqlServerRadioButton.CheckedChanged += OnProviderButtonChecked;
                            EditColumnSqliteRadioButton.CheckedChanged += OnProviderButtonChecked;
                            DeleteTableTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;
                            CreateTableTabPage.TabVisible = false;
                            break;
                        }
                        case ToolType.AddDatabaseButton:
                        {
                            CreateTableTabPage.Text = "Add Database";
                            ActiveTab = CreateTableTabPage;
                            Provider = Provider.Access;
                            AccessRadioButton.Checked = true;
                            EditColumnTabPage.TabVisible = false;
                            DeleteTableTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;
                            break;
                        }
                        case ToolType.AddTableButton:
                        {
                            CreateTableTabPage.Text = "Add Table";
                            ActiveTab = CreateTableTabPage;
                            Provider = Provider.Access;
                            AccessRadioButton.Checked = true;
                            AccessRadioButton.Checked = true;
                            AccessRadioButton.CheckedChanged += OnProviderButtonChecked;
                            SqlServerRadioButton.CheckedChanged += OnProviderButtonChecked;
                            SqliteRadioButton.CheckedChanged += OnProviderButtonChecked;
                            EditColumnTabPage.TabVisible = false;
                            DeleteTableTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;
                            break;
                        }
                        case ToolType.EditColumnButton:
                        {
                            EditColumnTabPage.Text = "Edit Column";
                            ActiveTab = EditColumnTabPage;
                            Provider = Provider.Access;
                            EditColumnAccessRadioButton.Checked = true;
                            EditColumnAccessRadioButton.CheckedChanged += OnProviderButtonChecked;
                            EditColumnSqlServerRadioButton.CheckedChanged += OnProviderButtonChecked;
                            EditColumnSqliteRadioButton.CheckedChanged += OnProviderButtonChecked;
                            CreateTableTabPage.TabVisible = false;
                            DeleteTableTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;
                            break;
                        }
                        case ToolType.DeleteColumnButton:
                        {
                            DeleteColumnTabPage.Text = "Delete Column";
                            ActiveTab = DeleteColumnTabPage;
                            CreateTableTabPage.TabVisible = false;
                            DeleteTableTabPage.TabVisible = false;
                            EditColumnTabPage.TabVisible = false;
                            break;
                        }
                        case ToolType.DeleteTableButton:
                        {
                            DeleteTableTabPage.Text = "Delete Table";
                            ActiveTab = DeleteTableTabPage;
                            CreateTableTabPage.TabVisible = false;
                            EditColumnTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;
                            break;
                        }
                        case ToolType.DeleteDatabaseButton:
                        {
                            DeleteTableTabPage.Text = "Delete Database";
                            ActiveTab = DeleteTableTabPage;
                            CreateTableTabPage.TabVisible = false;
                            EditColumnTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;
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
                    foreach( TabPageAdv page in TabControl.TabPages )
                    {
                        if( page != null 
                           && !string.IsNullOrEmpty( page.Name ))
                        {
                            _tabPages.Add( page.Name, page );
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
    }
}
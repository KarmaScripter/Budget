﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="LookupDialog.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   LookupDialog.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.EditBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public partial class LookupDialog : EditBase
    {
        /// <summary>
        /// Gets the table prefix.
        /// </summary>
        /// <value>
        /// The table prefix.
        /// </value>
        public string TablePrefix { get; } = " Tables : ";

        /// <summary>
        /// Gets the column prefix.
        /// </summary>
        /// <value>
        /// The column prefix.
        /// </value>
        public string ColumnPrefix { get; } = " Columns : ";

        /// <summary>
        /// Gets the value prefix.
        /// </summary>
        /// <value>
        /// The value prefix.
        /// </value>
        public string ValuePrefix { get; } = " Values : ";

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupDialog"/> class.
        /// </summary>
        public LookupDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1310, 646 );
            Panels = GetPanels( );
            RadioButtons = GetRadioButtons( );
            TabControl.TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
            TableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            ColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                FormFilter = new Dictionary<string, object>
                {
                    { "BFY", "2022" },
                    { "FundCode", "B" }
                };

                DataModel = new DataBuilder( Source.StatusOfFunds, Provider.Access, FormFilter );
                BindingSource.DataSource = DataModel.DataTable;
                PopulateTableListBoxItems( );
                SourceTable.CaptionText = TablePrefix + TableListBox.Items.Count;
                ColumnTable.CaptionText = ColumnPrefix;
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
                TableListBox.Items.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data
                    ?.Where( dr => dr.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.Select( dr => dr.Field<string>( "TableName" ) )
                    ?.ToList( );
                
                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var name = _names[ _i ];
                    TableListBox.Items.Add( name );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [table ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnTableListBoxSelectionChanged( object sender )
        {
            try
            {
                FormFilter.Clear( );
                ColumnListBox.Items.Clear( );
                ValueListBox.Items.Clear( );
                ColumnTable.CaptionText = string.Empty;
                ValueTable.CaptionText = string.Empty;
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    var _columns = DataModel.GetDataColumns( );
                    foreach( var col in _columns )
                    {
                        ColumnListBox.Items.Add( col.ColumnName );
                    }

                    ColumnTable.CaptionText = ColumnPrefix + ColumnListBox.Items.Count;
                    ValueTable.CaptionText = ValuePrefix;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [column ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnColumnListBoxSelectionChanged( object sender )
        {
            try
            {
                ValueListBox.Items.Clear( );
                var _listBox = sender as ListBox;
                var _column = _listBox?.SelectedItem?.ToString( );
                var _series = DataModel.DataElements;
                if( !string.IsNullOrEmpty( _column ) )
                {
                    foreach( var item in _series[ _column ] )
                    {
                        ValueListBox.Items.Add( item );
                    }
                }

                ValueTable.CaptionText = ValuePrefix + ValueListBox.Items.Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}
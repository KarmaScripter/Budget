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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DataGridView" />
    /// <seealso/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public class DataGrid : DataGridView, IDataGrid
    {
        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public SmallTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGrid" />
        /// class.
        /// </summary>
        public DataGrid( )
        {
            EnableHeadersVisualStyles = false;
            ForeColor = Color.LightSteelBlue;
            Font = new Font( "Roboto", 8 );
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Size = new Size( 906, 527 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            BackColor = Color.FromArgb( 45, 45, 45 );
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            BackgroundColor = Color.FromArgb( 45, 45, 45 );
            GridColor = Color.FromArgb( 141, 139, 138 );
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            AllowUserToOrderColumns = true;
            AllowUserToResizeColumns = true;
            AllowUserToResizeRows = true;
            MultiSelect = false;

            // Default Cell Style
            DefaultCellStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            DefaultCellStyle.ForeColor = Color.LightSteelBlue;
            DefaultCellStyle.SelectionBackColor = Color.FromArgb( 17, 53, 84 );
            DefaultCellStyle.SelectionForeColor = Color.White;
            DefaultCellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );

            // Column SeriesConfiguration
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ColumnHeadersHeight = 30;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb( 17, 53, 84 );
            ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.Font = new Font( "Roboto", 9, FontStyle.Regular );

            // Row SeriesConfiguration
            RowHeadersWidth = 20;
            RowTemplate.Height = 28;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            RowHeadersDefaultCellStyle.BackColor = Color.FromArgb( 50, 50, 50 );
            RowHeadersDefaultCellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );
            RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb( 17, 53, 84 );
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            RowsDefaultCellStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            RowsDefaultCellStyle.Font = new Font( "Roboto", 8 );
            RowsDefaultCellStyle.ForeColor = Color.LightSteelBlue;
            RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb( 17, 53, 84 );
            RowsDefaultCellStyle.SelectionForeColor = Color.White;
            RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb( 50, 50, 50 );
            AlternatingRowsDefaultCellStyle.ForeColor = Color.LightSteelBlue;
            AlternatingRowsDefaultCellStyle.Font = new Font( "Roboto", 8 );
            AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb( 17, 53, 84 );
            AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Epilog
            Visible = true;
            Enabled = true;
            ColumnHeaderMouseClick += OnRightClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGrid" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public DataGrid( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataGrid"/> class.
        /// </summary>
        /// <param name="dataGrid">The dataGrid.</param>
        public DataGrid( DataGridView dataGrid )
            : this( dataGrid.Size, dataGrid.Location )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGrid" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public DataGrid( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = parent;
        }
        
        /// <summary>
        /// Gets the filter values.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public string GetFilterValues( IDictionary<string, object> dict )
        {
            {
                if( dict?.Any( ) == true )
                {
                    try
                    {
                        var _vals = string.Empty;
                        foreach( var _kvp in dict )
                        {
                            _vals += $"{ _kvp.Key } = '{ _kvp.Value }' AND ";
                        }

                        return _vals.Trim( ).Substring( 0, _vals.Length - 4 );
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

        /// <summary>
        /// Gets the current data row.
        /// </summary>
        /// <returns></returns>
        public DataRow GetCurrentDataRow( )
        {
            if( BindingSource.DataSource != null )
            {
                try
                {
                    var _dataRow = BindingSource.GetCurrentDataRow(  );
                    return _dataRow?.ItemArray?.Length > 0
                        ? _dataRow
                        : default( DataRow );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataRow );
                }
            }
            
            return default( DataRow );
        }

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="DataGridViewCellMouseEventArgs" /> instance containing the event data.</param>
        public void OnRightClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    var _columnConfiguration = new ColumnConfiguration( this );
                    _columnConfiguration.Location = PointToScreen( new Point( e.X, e.Y ) );
                    _columnConfiguration.ColumnListBox?.Items?.Clear( );
                    for( var _i = 0; _i < Columns.Count; _i++ )
                    {
                        var c = Columns[ _i ];
                        _columnConfiguration.ColumnListBox?.Items.Add( c.HeaderText, c.Visible );
                    }

                    _columnConfiguration.TopMost = true;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the column configuration.
        /// </summary>
        public void SetColumnConfiguration( )
        {
            try
            {
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle( );
                ColumnHeadersDefaultCellStyle.Font = new Font( "Roboto", 9, FontStyle.Regular );
                ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the row configuration.
        /// </summary>
        public void SetRowConfiguration( )
        {
            try
            {
                RowHeadersDefaultCellStyle = new DataGridViewCellStyle( );
                RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                RowHeadersDefaultCellStyle.ForeColor = Color.Black;
                RowHeadersDefaultCellStyle.Font = new Font( "Roboto", 9, FontStyle.Bold );
                RowHeadersDefaultCellStyle.BackColor = Color.FromArgb( 141, 139, 138 );
                RowsDefaultCellStyle = new DataGridViewCellStyle( );
                RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                RowsDefaultCellStyle.SelectionBackColor = SystemColors.ControlLight;
                RowsDefaultCellStyle.ForeColor = Color.Black;
                RowsDefaultCellStyle.Font = new Font( "Roboto", 9 );
                RowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
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
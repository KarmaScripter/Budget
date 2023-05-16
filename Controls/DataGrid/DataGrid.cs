// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution;

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

/// <summary> </summary>
/// <seealso cref = "DataGridView"/>
/// <seealso/>
[ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
[ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
[ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
[ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
public class DataGrid : DataGridView, IDataGrid
{
    /// <summary>
    /// Initializes a new instance of the
    /// <see cref = "DataGrid"/>
    /// class.
    /// </summary>
    public DataGrid( )
    {
        EnableHeadersVisualStyles = false;
        ForeColor = Color.LightGray;
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
        DefaultCellStyle.ForeColor = Color.LightGray;
        DefaultCellStyle.SelectionBackColor = Color.FromArgb( 26, 79, 125 );
        DefaultCellStyle.SelectionForeColor = Color.White;
        DefaultCellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );

        // Column SeriesConfiguration
        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ColumnHeadersHeight = 22;
        ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
        ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb( 26, 79, 125 );
        ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
        ColumnHeadersDefaultCellStyle.Font = new Font( "Roboto", 9, FontStyle.Regular );

        // Row SeriesConfiguration
        RowHeadersWidth = 20;
        RowTemplate.Height = 22;
        RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        RowHeadersDefaultCellStyle.BackColor = Color.FromArgb( 50, 50, 50 );
        RowHeadersDefaultCellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );
        RowHeadersDefaultCellStyle.ForeColor = Color.Black;
        RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb( 17, 53, 84 );
        CellBorderStyle = DataGridViewCellBorderStyle.None;
        RowsDefaultCellStyle.BackColor = Color.FromArgb( 45, 45, 45 );
        RowsDefaultCellStyle.Font = new Font( "Roboto", 8 );
        RowsDefaultCellStyle.ForeColor = Color.LightGray;
        RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb( 26, 79, 125 );
        RowsDefaultCellStyle.SelectionForeColor = Color.White;
        RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb( 50, 50, 50 );
        AlternatingRowsDefaultCellStyle.ForeColor = Color.LightGray;
        AlternatingRowsDefaultCellStyle.Font = new Font( "Roboto", 8 );
        AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb( 26, 79, 125 );
        AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

        // Epilog
        Visible = true;
        Enabled = true;
        ColumnHeaderMouseClick += OnRightClick;
        CellMouseClick += OnCellEnter;
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref = "DataGrid"/>
    /// class.
    /// </summary>
    /// <param name = "size" > The size. </param>
    /// <param name = "location" > The location. </param>
    public DataGrid( Size size, Point location )
        : this( )
    {
        Size = size;
        Location = location;
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref = "DataGrid"/>
    /// class.
    /// </summary>
    /// <param name = "dataGrid" > The dataGrid. </param>
    public DataGrid( Control dataGrid )
        : this( dataGrid.Size, dataGrid.Location )
    {
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref = "DataGrid"/>
    /// class.
    /// </summary>
    /// <param name = "size" > The size. </param>
    /// <param name = "location" > The location. </param>
    /// <param name = "parent" > The parent. </param>
    public DataGrid( Size size, Point location, Control parent )
        : this( size, location )
    {
        Parent = parent;
    }

    /// <summary> Gets or sets the hover text. </summary>
    /// <value> The hover text. </value>
    public string HoverText { get; set; }

    /// <summary> Gets or sets the tool tip. </summary>
    /// <value> The tool tip. </value>
    public SmallTip ToolTip { get; set; }

    /// <summary> Gets or sets the binding source. </summary>
    /// <value> The binding source. </value>
    public BindingSource BindingSource { get; set; }

    /// <summary> Gets or sets the filter. </summary>
    /// <value> The filter. </value>
    public IDictionary<string, object> DataFilter { get; set; }

    /// <summary> Gets the filter values. </summary>
    /// <param name = "dict" > The dictionary. </param>
    /// <returns> </returns>
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
                        _vals += $"{_kvp.Key} = '{_kvp.Value}' AND ";
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

    /// <summary> Gets the current data row. </summary>
    /// <returns> </returns>
    public DataRow GetCurrentDataRow( )
    {
        if( BindingSource.DataSource != null )
        {
            try
            {
                var _dataRow = BindingSource.GetCurrentDataRow( );
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

    /// <summary> Called when [right click]. </summary>
    /// <param name = "sender" > The sender. </param>
    /// <param name = "e" >
    /// The
    /// <see cref = "DataGridViewCellMouseEventArgs"/>
    /// instance containing the event data.
    /// </param>
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

    /// <summary> Called when [cell enter]. </summary>
    /// <param name = "sender" > The sender. </param>
    /// <param name = "e" >
    /// The
    /// <see cref = "EventArgs"/>
    /// instance containing the event data.
    /// </param>
    public void OnCellEnter( object sender, EventArgs e )
    {
        try
        {
            if( CurrentCell.ValueType == typeof( string ) )
            {
                var _cellValue = CurrentCell?.Value?.ToString( );
                if( _cellValue?.Length >= 6
                   && _cellValue.Length <= 9 )
                {
                    var _code = _cellValue.Substring( 4, 2 );
                    var _dialog = new ProgramProjectDialog( _code );
                    _dialog.ShowDialog( );
                }
            }
            else if( CurrentCell.ValueType == typeof( double ) )
            {
                var _cellValue = double.Parse( CurrentCell.Value.ToString( ) );
                var _form = new CalculationForm( _cellValue );
                _form.ShowDialog( );
                CurrentCell.Value = _form.Calculator.Value.ToDouble( );
            }
            else if( CurrentCell.ValueType == typeof( decimal ) )
            {
                var _cellValue = double.Parse( CurrentCell.Value.ToString( ) );
                var _form = new CalculationForm( _cellValue );
                _form.ShowDialog( );
                CurrentCell.Value = _form.Calculator.Value.ToDecimal( );
            }
            else if( CurrentCell.ValueType == typeof( DateOnly ) )
            {
                var _cellValue = DateTime.Parse( CurrentCell.Value.ToString( ) );
                var _form = new CalendarDialog( _cellValue );
                _form.ShowDialog( );
                CurrentCell.Value = _form.Calendar.SelectedDate;
            }
            else if( CurrentCell.ValueType == typeof( DateTime ) )
            {
                var _cellValue = DateTime.Parse( CurrentCell.Value.ToString( ) );
                var _form = new CalendarDialog( _cellValue );
                _form.ShowDialog( );
                CurrentCell.Value = _form.Calendar.SelectedDate;
            }
            else if( CurrentCell.ValueType == typeof( DateTimeOffset ) )
            {
                var _cellValue = DateTime.Parse( CurrentCell.Value.ToString( ) );
                var _form = new CalendarDialog( _cellValue );
                _form.ShowDialog( );
                CurrentCell.Value = _form.Calendar.SelectedDate;
            }
        }
        catch( Exception ex )
        {
            Fail( ex );
        }
    }

    /// <summary> Get ErrorDialog Dialog. </summary>
    /// <param name = "ex" > The ex. </param>
    protected static void Fail( Exception ex )
    {
        using var _error = new ErrorDialog( ex );
        _error?.SetText( );
        _error?.ShowDialog( );
    }
}
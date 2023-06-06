﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="EditDialog.cs" company="Terry D. Eppler">
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
//   EditDialog.cs
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
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.EditBase" />
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
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
            Size = new Size( 1310, 646 );
            TabPage.TabFont = new Font( "Roboto", 8, FontStyle.Regular );
            TabPage.TabForeColor = Color.FromArgb( 0, 120, 212 );
            SelectButton.Text = "Save";
            CloseButton.Text = "Exit";
            Frames = GetFrames( );
            TabPages = GetTabPages( );

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
            MouseClick += OnRightClick;
            TabPage.MouseClick += OnRightClick;
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
            DataTable = BindingSource.GetDataTable( );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataModel = new DataBuilder( Source, Provider.Access );
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
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
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
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
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
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
                    var _frames = Frames.ToArray( );
                    for( var _i = 0; _i < _frames.Length; _i++ )
                    {
                        var frame = _frames[ _i ];
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
                    return default( IDictionary<string, TabPageAdv> );
                }
            }

            return default( IDictionary<string, TabPageAdv> );
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
                return default( IEnumerable<Frame> );
            }
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
                SetActiveTab( );
                SetTableLocation( );
                SetFrameColors( );
                SetFrameDockStyle( );
                BindRecordData( );
                SetFrameVisibility( );
                SetTextBoxHandlers( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the active tab.
        /// </summary>
        private void SetActiveTab( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    switch( ToolType )
                    {
                        case ToolType.CopyButton:
                        {
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.AddRecordButton:
                        {
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.AddButton:
                        {
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.EditRecordButton:
                        {
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.DeleteRecordButton:
                        {
                            ActiveTab = TabPage;
                            SelectButton.Text = "Delete";
                            break;
                        }
                        default:
                        {
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
        /// Sets the frame dock style.
        /// </summary>
        private void SetFrameDockStyle( )
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
        private void SetFrameColors( )
        {
            if( Frames?.Any( ) == true )
            {
                foreach( var frame in Frames )
                {
                    frame.Label.ForeColor = Color.LightSteelBlue;
                    frame.TextBox.ForeColor = Color.DarkGray;
                    frame.TextBox.BorderColor = Color.FromArgb( 70, 70, 70 );
                    frame.TextBox.HoverColor = Color.FromArgb( 70, 70, 70 );
                }
            }
        }

        private void SetTextBoxHandlers( )
        {
            if( Frames?.Any( ) == true )
            {
                foreach( var frame in Frames )
                {
                    frame.TextBox.MouseEnter += OnMouseOver;
                    frame.TextBox.MouseLeave += OnMouseLeave;
                    frame.TextBox.MouseClick += OnTextBoxMouseEnter;
                }
            }
        }

        /// <summary>
        /// Sets the table location.
        /// </summary>
        private void SetTableLocation( )
        {
            if( ( FrameTable != null )
               && ( Columns?.Any( ) == true ) )
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
        private void BindRecordData( )
        {
            if( ( Current != null )
               && ( Frames?.Any( ) == true )
               && ( Columns?.Any( ) == true ) )
            {
                try
                {
                    var _items = Current.ItemArray;
                    var _frames = Frames.OrderBy( f => f.Index ).ToArray( );
                    var _cols = Columns.ToArray( );
                    for( var i = 0; i < _cols.Length; i++ )
                    {
                        _frames[ i ].Label.Text = _cols[ i ].SplitPascal( );
                        var _text = _items[ i ]?.ToString( );
                        if( ( Numerics?.Contains( _cols[ i ] ) == true )
                           && !string.IsNullOrEmpty( _text ) )
                        {
                            var _value = double.Parse( _text );
                            _frames[ i ].TextBox.Text = _value.ToString( "N2" );
                            _frames[ i ].TextBox.TextAlign = HorizontalAlignment.Right;
                        }
                        else
                        {
                            _frames[ i ].TextBox.Text = _items[ i ]?.ToString( );
                            _frames[ i ].TextBox.TextAlign = HorizontalAlignment.Left;
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
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    ContextMenu.Show( this, e.Location );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        public virtual void OnTextBoxMouseEnter( object sender, EventArgs e )
        {
            if( sender is TextBox textBox
               && !string.IsNullOrEmpty( textBox.Text ) )
            {
                try
                {
                    double _double;
                    decimal _decimal;
                    if( double.TryParse( textBox.Text, out _double ) )
                    {
                        var _value = double.Parse( textBox.Text );
                        var _form = new CalculationForm( _value );
                        _form.ShowDialog( );
                        textBox.Text = _form.Calculator.Value.ToString( );
                    }
                    else if( decimal.TryParse( textBox.Text, out _decimal ) )
                    {
                        var _decimalValue = double.Parse( textBox.Text );
                        var _form = new CalculationForm( _decimalValue );
                        _form.ShowDialog( );
                        textBox.Text = _form.Calculator.Value.ToString( );
                    }
                    else
                    {
                        return;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public virtual void OnMouseOver( object sender, EventArgs e )
        {
            var _textBox = sender as TextBox;
            try
            {
                if( !string.IsNullOrEmpty( _textBox.Text ) )
                {
                    var _hoverText = _textBox.Text;
                    ToolTip = new SmallTip( _textBox, _hoverText );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( sender is TextBox _textBox
                   && ( ToolTip?.Active == true ) )
                {
                    ToolTip.RemoveAll( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

    }
}
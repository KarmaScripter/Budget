// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-03-2023
// ******************************************************************************************
// <copyright file="BrowserTabStrip.cs" company="Terry D. Eppler">
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
//   BrowserTabStrip.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.BaseStyledPanel" />
    /// <seealso cref="T:System.ComponentModel.ISupportInitialize" />
    /// <seealso cref="T:System.IDisposable" />
    [ DefaultEvent( "TabStripItemSelectionChanged" ) ]
    [ DefaultProperty( "Items" ) ]
    [ ToolboxItem( true ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    public class BrowserTabStrip : BaseStyledPanel, ISupportInitialize, IDisposable
    {
        /// <summary>
        /// The text left margin
        /// </summary>
        private const int TEXT_LEFT_MARGIN = 15;

        /// <summary>
        /// The text right margin
        /// </summary>
        private const int TEXT_RIGHT_MARGIN = 10;

        /// <summary>
        /// The definition header height
        /// </summary>
        private const int DEF_HEADER_HEIGHT = 28;

        /// <summary>
        /// The definition button height
        /// </summary>
        private const int DEF_BUTTON_HEIGHT = 28;

        /// <summary>
        /// The definition glyph width
        /// </summary>
        private const int DEF_GLYPH_WIDTH = 40;

        /// <summary>
        /// The close button
        /// </summary>
        private BrowserTabStripCloseButton _closeButton;

        /// <summary>
        /// The definition start position
        /// </summary>
        private int _defStartPos = 10;

        /// <summary>
        /// The format
        /// </summary>
        private StringFormat _format;

        /// <summary>
        /// The is initializing
        /// </summary>
        private bool _isInitializing;

        /// <summary>
        /// The menu
        /// </summary>
        private readonly ContextMenuStrip _menu;

        /// <summary>
        /// The is open
        /// </summary>
        private bool _isOpen;

        /// <summary>
        /// The selected item
        /// </summary>
        private BrowserTabStripItem _selectedItem;

        /// <summary>
        /// The strip button rect
        /// </summary>
        private Rectangle _stripButtonRect = Rectangle.Empty;

        /// <summary>
        /// The add button width
        /// </summary>
        public int AddButtonWidth = 40;

        /// <summary>
        /// The maximum tab size
        /// </summary>
        public int MaxTabSize = 200;

        /// <summary>
        /// The font
        /// </summary>
        private static Font _font = new("Roboto", 8, FontStyle.Regular);

        /// <summary>
        /// The dark background
        /// </summary>
        private Color _dark = Color.FromArgb( 20, 20, 20 );

        /// <summary>
        /// Gets or sets the selected item.
        /// </summary>
        /// <value>
        /// The selected item.
        /// </value>
        [ RefreshProperties( RefreshProperties.All ) ]
        [ DefaultValue( null ) ]
        public BrowserTabStripItem SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                if( _selectedItem == value )
                {
                    return;
                }

                if( value == null
                   && Items.Count > 0 )
                {
                    var fATabStripItem = Items[ 0 ];
                    if( fATabStripItem.Visible )
                    {
                        _selectedItem = fATabStripItem;
                        _selectedItem.IsSelected = true;
                        _selectedItem.Dock = DockStyle.Fill;
                    }
                }
                else
                {
                    _selectedItem = value;
                }

                foreach( BrowserTabStripItem item in Items )
                {
                    if( item == _selectedItem )
                    {
                        SelectItem( item );
                        item.Dock = DockStyle.Fill;
                        item.Show( );
                    }
                    else
                    {
                        UnSelectItem( item );
                        item.Hide( );
                    }
                }

                SelectItem( _selectedItem );
                Invalidate( );
                if( !_selectedItem.IsDrawn )
                {
                    Items.MoveTo( 0, _selectedItem );
                    Invalidate( );
                }

                OnTabStripItemChanged( new TabStripItemChangedEventArgs( _selectedItem,
                    BrowserTabStripItemChangeTypes.SelectionChanged ) );
            }
        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [ DesignerSerializationVisibility( DesignerSerializationVisibility.Content ) ]
        public BrowserTabStripItemCollection Items { get; }

        /// <summary>
        /// Gets or sets the height and width of the control.
        /// </summary>
        [ DefaultValue( typeof( Size ), "350,200" ) ]
        public new Size Size
        {
            get
            {
                return base.Size;
            }
            set
            {
                if( !( base.Size == value ) )
                {
                    base.Size = value;
                    UpdateLayout( );
                }
            }
        }

        /// <summary>
        /// Gets the collection of controls contained within the control.
        /// </summary>
        [ DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden ) ]
        public new ControlCollection Controls
        {
            get
            {
                return base.Controls;
            }
        }

        /// <summary>
        /// Occurs when [tab strip item closing].
        /// </summary>
        public event TabStripItemClosingHandler TabStripItemClosing;

        /// <summary>
        /// Occurs when [tab strip item selection changed].
        /// </summary>
        public event TabStripItemChangedHandler TabStripItemSelectionChanged;

        /// <summary>
        /// Occurs when [menu items loading].
        /// </summary>
        public event HandledEventHandler MenuItemsLoading;

        /// <summary>
        /// Occurs when [menu items loaded].
        /// </summary>
        public event EventHandler MenuItemsLoaded;

        /// <summary>
        /// Occurs when [tab strip item closed].
        /// </summary>
        public event EventHandler TabStripItemClosed;

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserTabStrip"/> class.
        /// </summary>
        public BrowserTabStrip( )
        {
            BeginInit( );
            SetStyle( ControlStyles.ContainerControl, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.Selectable, true );
            Items = new BrowserTabStripItemCollection( );
            Items.CollectionChanged += OnCollectionChanged;
            BackColor = _dark;
            base.Size = new Size( 350, 200 );
            _menu = new ContextMenuStrip( );
            _menu.BackColor = _dark;
            _menu.Renderer = ToolStripRenderer;
            _menu.ItemClicked += OnMenuItemClicked;
            _menu.VisibleChanged += OnMenuVisibleChanged;
            _closeButton = new BrowserTabStripCloseButton( ToolStripRenderer );
            Font = _font;
            _format = new StringFormat( );
            EndInit( );
            UpdateLayout( );
        }

        /// <summary>
        /// Hits the test.
        /// </summary>
        /// <param name="pt">The pt.</param>
        /// <returns></returns>
        public HitTestResult HitTest( Point pt )
        {
            if( _closeButton.IsVisible
               && _closeButton.Rect.Contains( pt ) )
            {
                return HitTestResult.CloseButton;
            }

            return GetTabItemByPoint( pt ) != null
                ? HitTestResult.TabItem
                : HitTestResult.None;
        }

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="tabItem">The tab item.</param>
        public void AddTab( BrowserTabStripItem tabItem )
        {
            AddTab( tabItem, false );
        }

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="tabItem">The tab item.</param>
        /// <param name="autoSelect">if set to <c>true</c> [automatic select].</param>
        public void AddTab( BrowserTabStripItem tabItem, bool autoSelect )
        {
            tabItem.Dock = DockStyle.Fill;
            Items.Add( tabItem );
            if( autoSelect && tabItem.Visible
               || tabItem.Visible && Items.DrawnCount < 1 )
            {
                SelectedItem = tabItem;
                SelectItem( tabItem );
            }
        }

        /// <summary>
        /// Removes the tab.
        /// </summary>
        /// <param name="tabItem">The tab item.</param>
        public void RemoveTab( BrowserTabStripItem tabItem )
        {
            var num = Items.IndexOf( tabItem );
            if( num >= 0 )
            {
                UnSelectItem( tabItem );
                Items.Remove( tabItem );
            }

            if( Items.Count > 0 )
            {
                if( Items[ num - 1 ] != null )
                {
                    SelectedItem = Items[ num - 1 ];
                }
                else
                {
                    SelectedItem = Items.FirstVisible;
                }
            }
        }

        /// <summary>
        /// Gets the tab item by point.
        /// </summary>
        /// <param name="pt">The pt.</param>
        /// <returns></returns>
        public BrowserTabStripItem GetTabItemByPoint( Point pt )
        {
            BrowserTabStripItem result = null;
            var flag = false;
            for( var i = 0; i < Items.Count; i++ )
            {
                var fATabStripItem = Items[ i ];
                if( fATabStripItem.StripRect.Contains( pt )
                   && fATabStripItem.Visible
                   && fATabStripItem.IsDrawn )
                {
                    result = fATabStripItem;
                    flag = true;
                }

                if( flag )
                {
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Shows the menu.
        /// </summary>
        public virtual void ShowMenu( )
        {
        }

        /// <summary>
        /// Should serialize font.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeFont( )
        {
            if( Font != null )
            {
                return !Font.Equals( _font );
            }

            return false;
        }

        /// <summary>
        /// Should serialize selected item.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeSelectedItem( )
        {
            return true;
        }

        /// <summary>
        /// Should serialize items.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeItems( )
        {
            return Items.Count > 0;
        }

        /// <summary>
        /// Resets the <see cref="P:System.Windows.Forms.Control.Font" />
        /// property to its default value.
        /// </summary>
        public new void ResetFont( )
        {
            Font = _font;
        }

        /// <summary>
        /// Signals the object that initialization is starting.
        /// </summary>
        public void BeginInit( )
        {
            _isInitializing = true;
        }

        /// <summary>
        /// Signals the object that initialization is complete.
        /// </summary>
        public void EndInit( )
        {
            _isInitializing = false;
        }

        /// <summary>
        /// Updates the layout.
        /// </summary>
        private void UpdateLayout( )
        {
            _format.Trimming = StringTrimming.EllipsisCharacter;
            _format.FormatFlags |= StringFormatFlags.NoWrap;
            _format.FormatFlags &= StringFormatFlags.DirectionRightToLeft;
            _stripButtonRect = new Rectangle( 0, 0, ClientSize.Width - 40 - 2, 10 );
            DockPadding.Top = 29;
            DockPadding.Bottom = 1;
            DockPadding.Right = 1;
            DockPadding.Left = 1;
        }

        /// <summary>
        /// Uns the draw all.
        /// </summary>
        internal void UnDrawAll( )
        {
            for( var i = 0; i < Items.Count; i++ )
            {
                Items[ i ].IsDrawn = false;
            }
        }

        /// <summary>
        /// Selects the item.
        /// </summary>
        /// <param name="tabItem">The tab item.</param>
        internal void SelectItem( BrowserTabStripItem tabItem )
        {
            tabItem.Dock = DockStyle.Fill;
            tabItem.Visible = true;
            tabItem.IsSelected = true;
        }

        /// <summary>
        /// Uns the select item.
        /// </summary>
        /// <param name="tabItem">The tab item.</param>
        internal void UnSelectItem( BrowserTabStripItem tabItem )
        {
            tabItem.IsSelected = false;
        }

        /// <summary>
        /// Sets the default selected.
        /// </summary>
        private void SetDefaultSelection( )
        {
            if( _selectedItem == null
               && Items.Count > 0 )
            {
                _selectedItem = Items[ 0 ];
            }

            for( var i = 0; i < Items.Count; i++ )
            {
                var fATabStripItem = Items[ i ];
                fATabStripItem.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:TabStripItemClosing" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabStripItemClosingEventArgs"/> instance containing the event data.</param>
        internal protected virtual void OnTabStripItemClosing( TabStripItemClosingEventArgs e )
        {
            TabStripItemClosing?.Invoke( e );
        }

        /// <summary>
        /// Raises the <see cref="E:TabStripItemClosed" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        internal protected virtual void OnTabStripItemClosed( EventArgs e )
        {
            _selectedItem = null;
            TabStripItemClosed?.Invoke( this, e );
        }

        /// <summary>
        /// Raises the <see cref="E:MenuItemsLoading" /> event.
        /// </summary>
        /// <param name="e">The <see cref="HandledEventArgs"/> instance containing the event data.</param>
        protected virtual void OnMenuItemsLoading( HandledEventArgs e )
        {
            MenuItemsLoading?.Invoke( this, e );
        }

        /// <summary>
        /// Raises the <see cref="E:MenuItemsLoaded" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnMenuItemsLoaded( EventArgs e )
        {
            MenuItemsLoaded?.Invoke( this, e );
        }

        /// <summary>
        /// Raises the <see cref="E:TabStripItemChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabStripItemChangedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnTabStripItemChanged( TabStripItemChangedEventArgs e )
        {
            TabStripItemSelectionChanged?.Invoke( e );
        }

        /// <summary>
        /// Raises the <see cref="E:MenuItemsLoad" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnMenuItemsLoad( EventArgs e )
        {
            _menu.RightToLeft = RightToLeft;
            _menu.Items.Clear( );
            for( var i = 0; i < Items.Count; i++ )
            {
                var fATabStripItem = Items[ i ];
                if( fATabStripItem.Visible )
                {
                    var toolStripMenuItem = new ToolStripMenuItem( fATabStripItem.Title );
                    toolStripMenuItem.Tag = fATabStripItem;
                    toolStripMenuItem.Image = fATabStripItem.Image;
                    _menu.Items.Add( toolStripMenuItem );
                }
            }

            OnMenuItemsLoaded( EventArgs.Empty );
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.RightToLeftChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnRightToLeftChanged( EventArgs e )
        {
            base.OnRightToLeftChanged( e );
            UpdateLayout( );
            Invalidate( );
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint( PaintEventArgs e )
        {
            SetDefaultSelection( );
            var _brush = new SolidBrush( _dark );
            var _pen = new Pen( _brush );
            var _client = ClientRectangle;
            _client.Width--;
            _client.Height--;
            _defStartPos = 10;
            e.Graphics.DrawRectangle( _pen, _client );
            e.Graphics.FillRectangle( _brush, _client );
            e.Graphics.FillRectangle( _brush,
                new Rectangle( _client.X, _client.Y, _client.Width, 28 ) );

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            for( var i = 0; i < Items.Count; i++ )
            {
                var fATabStripItem = Items[ i ];
                if( fATabStripItem.Visible || DesignMode )
                {
                    OnCalculateTabPage( e.Graphics, fATabStripItem );
                    fATabStripItem.IsDrawn = false;
                    OnDrawTabButton( e.Graphics, fATabStripItem );
                }
            }

            if( _selectedItem != null )
            {
                OnDrawTabButton( e.Graphics, _selectedItem );
            }

            if( Items.DrawnCount == 0
               || Items.VisibleCount == 0 )
            {
                e.Graphics.DrawLine( _pen, new Point( 0, 28 ),
                    new Point( ClientRectangle.Width, 28 ) );
            }
            else if( SelectedItem != null
                    && SelectedItem.IsDrawn )
            {
                var _num = (int)( SelectedItem.StripRect.Height / 4f );
                var _point = new Point( (int)SelectedItem.StripRect.Left - _num, 28 );
                e.Graphics.DrawLine( _pen, new Point( 0, 28 ), _point );
                _point.X += (int)SelectedItem.StripRect.Width + _num * 2;
                e.Graphics.DrawLine( _pen, _point, new Point( ClientRectangle.Width, 28 ) );
            }

            if( SelectedItem != null
               && SelectedItem.CanClose )
            {
                _closeButton.IsVisible = true;
                _closeButton.CalculateBounds( _selectedItem );
                _closeButton.Draw( e.Graphics );
            }
            else
            {
                _closeButton.IsVisible = false;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseDown( MouseEventArgs e )
        {
            base.OnMouseDown( e );
            var hitTestResult = HitTest( e.Location );
            if( hitTestResult == HitTestResult.TabItem )
            {
                var tabItemByPoint = GetTabItemByPoint( e.Location );
                if( tabItemByPoint != null )
                {
                    SelectedItem = tabItemByPoint;
                    Invalidate( );
                }
            }
            else
            {
                if( e.Button != MouseButtons.Left
                   || hitTestResult != 0 )
                {
                    return;
                }

                if( SelectedItem != null )
                {
                    var tabStripItemClosingEventArgs =
                        new TabStripItemClosingEventArgs( SelectedItem );

                    OnTabStripItemClosing( tabStripItemClosingEventArgs );
                    if( !tabStripItemClosingEventArgs.Cancel
                       && SelectedItem.CanClose )
                    {
                        RemoveTab( SelectedItem );
                        OnTabStripItemClosed( EventArgs.Empty );
                    }
                }

                Invalidate( );
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseMove( MouseEventArgs e )
        {
            base.OnMouseMove( e );
            if( _closeButton.IsVisible )
            {
                if( _closeButton.Rect.Contains( e.Location ) )
                {
                    _closeButton.IsMouseOver = true;
                    Invalidate( _closeButton.RedrawRect );
                }
                else if( _closeButton.IsMouseOver )
                {
                    _closeButton.IsMouseOver = false;
                    Invalidate( _closeButton.RedrawRect );
                }
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnMouseLeave( EventArgs e )
        {
            base.OnMouseLeave( e );
            _closeButton.IsMouseOver = false;
            if( _closeButton.IsVisible )
            {
                Invalidate( _closeButton.RedrawRect );
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnSizeChanged( EventArgs e )
        {
            base.OnSizeChanged( e );
            if( !_isInitializing )
            {
                UpdateLayout( );
            }
        }

        /// <summary>
        /// Called when [menu item clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ToolStripItemClickedEventArgs"/> instance containing the event data.</param>
        private void OnMenuItemClicked( object sender, ToolStripItemClickedEventArgs e )
        {
            var fATabStripItem2 = SelectedItem = (BrowserTabStripItem)e.ClickedItem.Tag;
        }

        /// <summary>
        /// Called when [menu visible changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnMenuVisibleChanged( object sender, EventArgs e )
        {
            if( !_menu.Visible )
            {
                _isOpen = false;
            }
        }

        /// <summary>
        /// Called when [calculate tab page].
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="currentItem">The current item.</param>
        private void OnCalculateTabPage( Graphics g, BrowserTabStripItem currentItem )
        {
            _ = Font;
            var num = 0;
            if( currentItem.Title == "+" )
            {
                num = AddButtonWidth;
            }
            else
            {
                num = ( Width - ( AddButtonWidth + 20 ) ) / ( Items.Count - 1 );
                if( num > MaxTabSize )
                {
                    num = MaxTabSize;
                }
            }

            var rectangleF2 = currentItem.StripRect = new RectangleF( _defStartPos, 3f, num, 28f );
            _defStartPos += num;
        }

        /// <summary>
        /// Measures the width of the tab.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="currentItem">The current item.</param>
        /// <param name="currentFont">The current font.</param>
        /// <returns></returns>
        private SizeF MeasureTabWidth( Graphics g, BrowserTabStripItem currentItem,
            Font currentFont )
        {
            var result = g.MeasureString( currentItem.Title, currentFont, new SizeF( 200f, 28f ),
                _format );

            result.Width += 25f;
            return result;
        }

        /// <summary>
        /// Called when [draw tab button].
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="currentItem">The current item.</param>
        private void OnDrawTabButton( Graphics g, BrowserTabStripItem currentItem )
        {
            Items.IndexOf( currentItem );
            var font = Font;
            var _brush = new SolidBrush( _dark );
            var stripRect = currentItem.StripRect;
            var graphicsPath = new GraphicsPath( );
            var left = stripRect.Left;
            var right = stripRect.Right;
            var num = 3f;
            var num2 = stripRect.Bottom - 1f;
            var num3 = stripRect.Width;
            var num4 = stripRect.Height;
            var num5 = num4 / 4f;
            graphicsPath.AddLine( left - num5, num2, left + num5, num );
            graphicsPath.AddLine( right - num5, num, right + num5, num2 );
            graphicsPath.CloseFigure( );
            var brush = new SolidBrush( currentItem == SelectedItem
                ? _brush.Color
                : Color.SteelBlue );

            g.FillPath( brush, graphicsPath );
            g.DrawPath( SystemPens.ControlDark, graphicsPath );
            if( currentItem == SelectedItem )
            {
                g.DrawLine( new Pen( brush ), left - 9f, num4 + 2f, left + num3 - 1f, num4 + 2f );
            }

            var location = new PointF( left + 15f, 5f );
            var layoutRectangle = stripRect;
            layoutRectangle.Location = location;
            layoutRectangle.Width = num3 - ( layoutRectangle.Left - left ) - 4f;
            if( currentItem == _selectedItem )
            {
                layoutRectangle.Width -= 15f;
            }

            layoutRectangle.Height = 23f;
            if( currentItem == SelectedItem )
            {
                g.DrawString( currentItem.Title, font, new SolidBrush( ForeColor ), layoutRectangle,
                    _format );
            }
            else
            {
                g.DrawString( currentItem.Title, font, new SolidBrush( ForeColor ), layoutRectangle,
                    _format );
            }

            currentItem.IsDrawn = true;
        }

        /// <summary>
        /// Called when [collection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="CollectionChangeEventArgs"/>
        /// instance containing the event data.</param>
        private void OnCollectionChanged( object sender, CollectionChangeEventArgs e )
        {
            var fATabStripItem = (BrowserTabStripItem)e.Element;
            if( e.Action == CollectionChangeAction.Add )
            {
                Controls.Add( fATabStripItem );
                OnTabStripItemChanged( new TabStripItemChangedEventArgs( fATabStripItem,
                    BrowserTabStripItemChangeTypes.Added ) );
            }
            else if( e.Action == CollectionChangeAction.Remove )
            {
                Controls.Remove( fATabStripItem );
                OnTabStripItemChanged( new TabStripItemChangedEventArgs( fATabStripItem,
                    BrowserTabStripItemChangeTypes.Removed ) );
            }
            else
            {
                OnTabStripItemChanged( new TabStripItemChangedEventArgs( fATabStripItem,
                    BrowserTabStripItemChangeTypes.Changed ) );
            }

            UpdateLayout( );
            Invalidate( );
        }

        /// <summary>
        /// Releases the unmanaged resources
        /// used by the <see cref="T:System.Windows.Forms.Control" />
        /// and its child controls and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing"><see langword="true" /> to release
        /// both managed and unmanaged resources; <see langword="false" />
        /// to release only unmanaged resources.
        /// </param>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                Items.CollectionChanged -= OnCollectionChanged;
                _menu.ItemClicked -= OnMenuItemClicked;
                _menu.VisibleChanged -= OnMenuVisibleChanged;
                foreach( BrowserTabStripItem item in Items )
                {
                    if( item != null
                       && !item.IsDisposed )
                    {
                        item.Dispose( );
                    }
                }

                if( _menu != null
                   && !_menu.IsDisposed )
                {
                    _menu.Dispose( );
                }

                _format?.Dispose( );
            }

            base.Dispose( disposing );
        }
    }
}
// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
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

    [ DefaultEvent( "TabStripItemSelectionChanged" ) ]
    [ DefaultProperty( "Items" ) ]
    [ ToolboxItem( true ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    public class BrowserTabStrip : BaseStyledPanel, ISupportInitialize
    {
        private BrowserTabStripCloseButton _closeButton;

        private int _defStartPos = 10;

        private StringFormat _format;

        private bool _isIniting;

        private readonly ContextMenuStrip _menu;

        private bool _menuOpen;

        private BrowserTabStripItem _selectedItem;

        private Rectangle _stripButtonRect = Rectangle.Empty;

        public int AddButtonWidth = 40;

        public int MaxTabSize = 200;

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
                        _selectedItem.Selected = true;
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

        [ DesignerSerializationVisibility( DesignerSerializationVisibility.Content ) ]
        public BrowserTabStripItemCollection Items { get; }

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

        [ DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden ) ]
        public new ControlCollection Controls
        {
            get
            {
                return base.Controls;
            }
        }

        private const int TEXT_LEFT_MARGIN = 15;

        private const int TEXT_RIGHT_MARGIN = 10;

        private const int DEF_HEADER_HEIGHT = 28;

        private const int DEF_BUTTON_HEIGHT = 28;

        private const int DEF_GLYPH_WIDTH = 40;

        private static Font defaultFont = new("Tahoma", 8.25f, FontStyle.Regular);

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
            base.Size = new Size( 350, 200 );
            _menu = new ContextMenuStrip( );
            _menu.Renderer = ToolStripRenderer;
            _menu.ItemClicked += OnMenuItemClicked;
            _menu.VisibleChanged += OnMenuVisibleChanged;
            _closeButton = new BrowserTabStripCloseButton( ToolStripRenderer );
            Font = BrowserTabStrip.defaultFont;
            _format = new StringFormat( );
            EndInit( );
            UpdateLayout( );
        }

        public event TabStripItemClosingHandler TabStripItemClosing;

        public event TabStripItemChangedHandler TabStripItemSelectionChanged;

        public event HandledEventHandler MenuItemsLoading;

        public event EventHandler MenuItemsLoaded;

        public event EventHandler TabStripItemClosed;

        public HitTestResult HitTest( Point pt )
        {
            if( _closeButton.IsVisible
               && _closeButton.Rect.Contains( pt ) )
            {
                return HitTestResult.CloseButton;
            }

            if( GetTabItemByPoint( pt ) != null )
            {
                return HitTestResult.TabItem;
            }

            return HitTestResult.None;
        }

        public void AddTab( BrowserTabStripItem tabItem )
        {
            AddTab( tabItem, false );
        }

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

        public virtual void ShowMenu( )
        {
        }

        public bool ShouldSerializeFont( )
        {
            if( Font != null )
            {
                return !Font.Equals( BrowserTabStrip.defaultFont );
            }

            return false;
        }

        public bool ShouldSerializeSelectedItem( )
        {
            return true;
        }

        public bool ShouldSerializeItems( )
        {
            return Items.Count > 0;
        }

        public new void ResetFont( )
        {
            Font = BrowserTabStrip.defaultFont;
        }

        public void BeginInit( )
        {
            _isIniting = true;
        }

        public void EndInit( )
        {
            _isIniting = false;
        }

        internal protected virtual void OnTabStripItemClosing( TabStripItemClosingEventArgs e )
        {
            TabStripItemClosing?.Invoke( e );
        }

        internal protected virtual void OnTabStripItemClosed( EventArgs e )
        {
            _selectedItem = null;
            TabStripItemClosed?.Invoke( this, e );
        }

        protected virtual void OnMenuItemsLoading( HandledEventArgs e )
        {
            MenuItemsLoading?.Invoke( this, e );
        }

        protected virtual void OnMenuItemsLoaded( EventArgs e )
        {
            MenuItemsLoaded?.Invoke( this, e );
        }

        protected virtual void OnTabStripItemChanged( TabStripItemChangedEventArgs e )
        {
            TabStripItemSelectionChanged?.Invoke( e );
        }

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

        protected override void OnRightToLeftChanged( EventArgs e )
        {
            base.OnRightToLeftChanged( e );
            UpdateLayout( );
            Invalidate( );
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            SetDefaultSelected( );
            var clientRectangle = ClientRectangle;
            clientRectangle.Width--;
            clientRectangle.Height--;
            _defStartPos = 10;
            e.Graphics.DrawRectangle( SystemPens.ControlDark, clientRectangle );
            e.Graphics.FillRectangle( Brushes.White, clientRectangle );

            e.Graphics.FillRectangle( SystemBrushes.GradientInactiveCaption,
                new Rectangle( clientRectangle.X, clientRectangle.Y, clientRectangle.Width, 28 ) );

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            for( var i = 0; i < Items.Count; i++ )
            {
                var fATabStripItem = Items[ i ];

                if( fATabStripItem.Visible || DesignMode )
                {
                    OnCalcTabPage( e.Graphics, fATabStripItem );
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
                e.Graphics.DrawLine( SystemPens.ControlDark, new Point( 0, 28 ),
                    new Point( ClientRectangle.Width, 28 ) );
            }
            else if( SelectedItem != null
                    && SelectedItem.IsDrawn )
            {
                var num = (int)( SelectedItem.StripRect.Height / 4f );
                var point = new Point( (int)SelectedItem.StripRect.Left - num, 28 );
                e.Graphics.DrawLine( SystemPens.ControlDark, new Point( 0, 28 ), point );
                point.X += (int)SelectedItem.StripRect.Width + num * 2;

                e.Graphics.DrawLine( SystemPens.ControlDark, point,
                    new Point( ClientRectangle.Width, 28 ) );
            }

            if( SelectedItem != null
               && SelectedItem.CanClose )
            {
                _closeButton.IsVisible = true;
                _closeButton.CalcBounds( _selectedItem );
                _closeButton.Draw( e.Graphics );
            }
            else
            {
                _closeButton.IsVisible = false;
            }
        }

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

        protected override void OnMouseLeave( EventArgs e )
        {
            base.OnMouseLeave( e );
            _closeButton.IsMouseOver = false;

            if( _closeButton.IsVisible )
            {
                Invalidate( _closeButton.RedrawRect );
            }
        }

        protected override void OnSizeChanged( EventArgs e )
        {
            base.OnSizeChanged( e );

            if( !_isIniting )
            {
                UpdateLayout( );
            }
        }

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

        internal void UnDrawAll( )
        {
            for( var i = 0; i < Items.Count; i++ )
            {
                Items[ i ].IsDrawn = false;
            }
        }

        internal void SelectItem( BrowserTabStripItem tabItem )
        {
            tabItem.Dock = DockStyle.Fill;
            tabItem.Visible = true;
            tabItem.Selected = true;
        }

        internal void UnSelectItem( BrowserTabStripItem tabItem )
        {
            tabItem.Selected = false;
        }

        private void SetDefaultSelected( )
        {
            if( _selectedItem == null
               && Items.Count > 0 )
            {
                SelectedItem = Items[ 0 ];
            }

            for( var i = 0; i < Items.Count; i++ )
            {
                var fATabStripItem = Items[ i ];
                fATabStripItem.Dock = DockStyle.Fill;
            }
        }

        private void OnMenuItemClicked( object sender, ToolStripItemClickedEventArgs e )
        {
            var fATabStripItem2 = SelectedItem = (BrowserTabStripItem)e.ClickedItem.Tag;
        }

        private void OnMenuVisibleChanged( object sender, EventArgs e )
        {
            if( !_menu.Visible )
            {
                _menuOpen = false;
            }
        }

        private void OnCalcTabPage( Graphics g, BrowserTabStripItem currentItem )
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

        private SizeF MeasureTabWidth( Graphics g, BrowserTabStripItem currentItem,
            Font currentFont )
        {
            var result = g.MeasureString( currentItem.Title, currentFont, new SizeF( 200f, 28f ),
                _format );

            result.Width += 25f;
            return result;
        }

        private void OnDrawTabButton( Graphics g, BrowserTabStripItem currentItem )
        {
            Items.IndexOf( currentItem );
            var font = Font;
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
                ? Color.White
                : SystemColors.GradientInactiveCaption );

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
    }
}
// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="BrowserTabStripItem.cs" company="Terry D. Eppler">
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
//   BrowserTabStripItem.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    [ ToolboxItem( false ) ]
    [ DefaultProperty( "Title" ) ]
    [ DefaultEvent( "Changed" ) ]
    public class BrowserTabStripItem : Panel
    {
        private bool isDrawn;

        private bool selected;

        private string title = string.Empty;

        private bool visible = true;

        [ Browsable( false ) ]
        [ EditorBrowsable( EditorBrowsableState.Never ) ]
        public new Size Size
        {
            get
            {
                return base.Size;
            }
            set
            {
                base.Size = value;
            }
        }

        [ DefaultValue( true ) ]
        public new bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                if( visible != value )
                {
                    visible = value;
                    OnChanged( );
                }
            }
        }

        internal RectangleF StripRect { get; set; } = Rectangle.Empty;

        [ DefaultValue( false ) ]
        [ EditorBrowsable( EditorBrowsableState.Never ) ]
        [ Browsable( false ) ]
        public bool IsDrawn
        {
            get
            {
                return isDrawn;
            }
            set
            {
                if( isDrawn != value )
                {
                    isDrawn = value;
                }
            }
        }

        [ DefaultValue( null ) ]
        public Image Image { get; set; }

        [ DefaultValue( true ) ]
        public bool CanClose { get; set; } = true;

        [ DefaultValue( "Name" ) ]
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if( !( title == value ) )
                {
                    title = value;
                    OnChanged( );
                }
            }
        }

        [ DefaultValue( false ) ]
        [ Browsable( false ) ]
        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                if( selected != value )
                {
                    selected = value;
                }
            }
        }

        [ Browsable( false ) ]
        public string Caption
        {
            get
            {
                return Title;
            }
        }

        public BrowserTabStripItem( )
            : this( string.Empty, null )
        {
        }

        public BrowserTabStripItem( Control displayControl )
            : this( string.Empty, displayControl )
        {
        }

        public BrowserTabStripItem( string caption, Control displayControl )
        {
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.ContainerControl, true );
            selected = false;
            Visible = true;
            UpdateText( caption, displayControl );

            if( displayControl != null )
            {
                Controls.Add( displayControl );
            }
        }

        public event EventHandler Changed;

        public bool ShouldSerializeIsDrawn( )
        {
            return false;
        }

        public bool ShouldSerializeDock( )
        {
            return false;
        }

        public bool ShouldSerializeControls( )
        {
            if( Controls != null )
            {
                return Controls.Count > 0;
            }

            return false;
        }

        public bool ShouldSerializeVisible( )
        {
            return true;
        }

        public void Assign( BrowserTabStripItem item )
        {
            Visible = item.Visible;
            Text = item.Text;
            CanClose = item.CanClose;
            Tag = item.Tag;
        }

        public override string ToString( )
        {
            return Caption;
        }

        internal protected virtual void OnChanged( )
        {
            Changed?.Invoke( this, EventArgs.Empty );
        }

        protected override void Dispose( bool disposing )
        {
            base.Dispose( disposing );

            if( disposing && Image != null )
            {
                Image.Dispose( );
            }
        }

        private void UpdateText( string caption, Control displayControl )
        {
            if( caption.Length <= 0
               && displayControl != null )
            {
                Title = displayControl.Text;
            }
            else if( caption != null )
            {
                Title = caption;
            }
            else
            {
                Title = string.Empty;
            }
        }
    }
}
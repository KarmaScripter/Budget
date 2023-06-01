// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="BrowserTabStripCloseButton.cs" company="Terry D. Eppler">
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
//   BrowserTabStripCloseButton.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System.Drawing;
    using System.Windows.Forms;

    internal class BrowserTabStripCloseButton
    {
        public bool IsMouseOver;

        public bool IsVisible;

        public Rectangle Rect = Rectangle.Empty;

        public Rectangle RedrawRect = Rectangle.Empty;

        public ToolStripProfessionalRenderer Renderer;

        internal BrowserTabStripCloseButton( ToolStripProfessionalRenderer renderer )
        {
            Renderer = renderer;
        }

        public void CalcBounds( BrowserTabStripItem tab )
        {
            Rect = new Rectangle( (int)tab.StripRect.Right - 20, (int)tab.StripRect.Top + 5, 15,
                15 );

            RedrawRect = new Rectangle( Rect.X - 2, Rect.Y - 2, Rect.Width + 4, Rect.Height + 4 );
        }

        public void Draw( Graphics g )
        {
            if( IsVisible )
            {
                var color = IsMouseOver
                    ? Color.White
                    : Color.DarkGray;

                g.FillRectangle( Brushes.White, Rect );

                if( IsMouseOver )
                {
                    g.FillEllipse( Brushes.IndianRed, Rect );
                }

                var num = 4;
                var pen = new Pen( color, 1.6f );

                g.DrawLine( pen, Rect.Left + num, Rect.Top + num, Rect.Right - num,
                    Rect.Bottom - num );

                g.DrawLine( pen, Rect.Right - num, Rect.Top + num, Rect.Left + num,
                    Rect.Bottom - num );

                pen.Dispose( );
            }
        }
    }
}
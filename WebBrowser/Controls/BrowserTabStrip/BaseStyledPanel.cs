// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="BaseStyledPanel.cs" company="Terry D. Eppler">
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
//   BaseStyledPanel.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;

    [ ToolboxItem( false ) ]
    public class BaseStyledPanel : ContainerControl
    {
        [ Browsable( false ) ]
        public ToolStripProfessionalRenderer ToolStripRenderer
        {
            get
            {
                return BaseStyledPanel.renderer;
            }
        }

        [ Browsable( false ) ]
        [ DefaultValue( true ) ]
        public bool UseThemes
        {
            get
            {
                if( VisualStyleRenderer.IsSupported
                   && VisualStyleInformation.IsSupportedByOS )
                {
                    return Application.RenderWithVisualStyles;
                }

                return false;
            }
        }

        private static ToolStripProfessionalRenderer renderer;

        static BaseStyledPanel( )
        {
            BaseStyledPanel.renderer = new ToolStripProfessionalRenderer( );
        }

        public BaseStyledPanel( )
        {
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
            SetStyle( ControlStyles.UserPaint, true );
        }

        public event EventHandler ThemeChanged;

        protected override void OnSystemColorsChanged( EventArgs e )
        {
            base.OnSystemColorsChanged( e );
            UpdateRenderer( );
            Invalidate( );
        }

        protected virtual void OnThemeChanged( EventArgs e )
        {
            ThemeChanged?.Invoke( this, e );
        }

        private void UpdateRenderer( )
        {
            if( !UseThemes )
            {
                BaseStyledPanel.renderer.ColorTable.UseSystemColors = true;
            }
            else
            {
                BaseStyledPanel.renderer.ColorTable.UseSystemColors = false;
            }
        }
    }
}
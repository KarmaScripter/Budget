// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary> </summary>
    /// <seealso cref="ChartControl"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class GraphBase : ChartControl
    {
        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public virtual ToolTip ToolTip { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        public virtual string HoverText { get; set; }

        /// <summary> Gets or sets the filter. </summary>
        /// <value> The filter. </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary> Sets the legend configuration. </summary>
        /// <param name="font"> The font. </param>
        /// <param name="size"> The size. </param>
        /// <param name="backColor"> The back color. </param>
        public virtual void SetLegend( Font font, Size size, Color backColor )
        {
            try
            {
                ShowLegend = true;
                Legend.Font = font;
                Legend.ItemsSize = size;
                Legend.VisibleCheckBox = true;
                Legend.BackInterior = new BrushInfo( backColor );
                Legend.ItemsAlignment = StringAlignment.Center;
                Legend.ItemsTextAligment = VerticalAlignment.Center;
                Legend.Orientation = ChartOrientation.Vertical;
                Legend.FloatingAutoSize = true;
                Legend.ShowSymbol = true;
                Legend.ShowItemsShadow = true;
                Legend.ShowBorder = false;
                Legend.Visible = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Get Error Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        static protected private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GraphBase"/>
        /// class.
        /// </summary>
        protected GraphBase( )
        {
        }
    }
}
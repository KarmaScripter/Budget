// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution.Controls.TabControl
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    public class TabControl : TabControlAdv
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public SmallTip ToolTip { get; set; }

        /// <summary>
        /// Initializes a new
        /// instance of the <see cref="TabControl"/> class.
        /// </summary>
        public TabControl( )
        {
            BackColor = Color.FromArgb( 20, 20, 20 );
            Size = new Size( 350, 500 );
            Font = new Font( "Roboto", 8 );
            ForeColor = Color.LightGray;
            FixedSingleBorderColor = Color.FromArgb( 20, 20, 20 );
            SeparatorColor = Color.FromArgb( 65, 65, 65 );
            InactiveCloseButtonForeColor = Color.FromArgb( 20, 20, 20 );
            InActiveTabForeColor = Color.FromArgb( 20, 20, 20 );
            InactiveTabColor = Color.FromArgb( 20, 20, 20 );
            ActiveTabForeColor = Color.FromArgb( 0, 120, 212 );
            BorderStyle = BorderStyle.FixedSingle;
            CloseButtonBackColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonForeColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonHoverForeColor = Color.FromArgb( 20, 20, 20 );
            CloseButtonPressedForeColor = Color.FromArgb( 20, 20, 20 );
            ActiveTabFont = new Font( "Roboto", 8  );
            ActiveTabColor = Color.FromArgb( 0, 120, 212 );
            ActiveTabForeColor = Color.White;
        }
    }
}
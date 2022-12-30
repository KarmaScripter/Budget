// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution.Controls.TabControl
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;

    /// <summary>
    /// 
    /// </summary>
    public class TabControl : MetroSetTabControl
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
            BackgroundColor = Color.FromArgb( 20, 20, 20 );
            Appearance = TabAppearance.FlatButtons;
            Size = new Size( 350, 500 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightGray;
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            SelectedTextColor = Color.White;
            UnselectedTextColor = Color.FromArgb( 65, 65, 65 );
            Speed = 100;
            AnimateTime = 200;
            AnimateEasingType = EasingType.Linear;
            Appearance = TabAppearance.FlatButtons;
        }
    }
}


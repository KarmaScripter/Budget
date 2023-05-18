// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref = "BudgetExecution.CurrencyBase"/>
    public class CurrencyBox : CurrencyBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "CurrencyBox"/>
        /// class.
        /// </summary>
        /// <remarks>
        /// The CurrencyEdit class also creates the controls that it hosts such as the
        /// <see cref = "T:Syncfusion.Windows.Forms.Tools.CurrencyTextBox"/>
        /// control and the
        /// <see cref = "T:Syncfusion.Windows.Forms.Tools.PopupCalculator"/>
        /// control.
        /// </remarks>
        public CurrencyBox( )
        {
            // Basic Properties
            Size = new Size( 140, 30 );
            Location = new Point( 1, 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.White;
            Enabled = true;
            Visible = true;
            Text = string.Empty;
            Border3DStyle = Border3DStyle.Flat;
            PopupCalculatorAlignment = CalculatorPopupAlignment.Right;
            FlatStyle = FlatStyle.Flat;
            ShowCalculator = true;
            TextAlign = HorizontalAlignment.Center;

            // TextBox Properties
            TextBox.CurrencyDecimalDigits = 2;
            TextBox.NegativeColor = Color.Red;
            TextBox.PositiveColor = Color.LightSteelBlue;
            TextBox.BackGroundColor = Color.FromArgb( 30, 30, 30 );
            TextBox.Border3DStyle = Border3DStyle.Flat;
            TextBox.ThemeStyle = CurrencyTextBoxVisualStyle.DefaultStyle;
            TextBox.BorderColor = Color.FromArgb( 65, 65, 65 );
            TextBox.BorderStyle = BorderStyle.None;
            TextBox.CurrencyDecimalSeparator = ".";
            TextBox.CurrencyGroupSeparator = ",";
            TextBox.FocusBorderColor = Color.FromArgb( 0, 120, 212 );
            TransferFromCalculator = true;
            TransferToCalculator = true;

            // TextBox ThemeStyle Properties
            ThemeStyle.BackColor = Color.FromArgb( 30, 30, 30 );
            ThemeStyle.BorderColor = Color.FromArgb( 65, 65, 65 );
            ThemeStyle.DisabledBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.DisabledBorderColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.HoverBorderColor = Color.FromArgb( 50, 93, 129 );
            ThemeStyle.FocusedBorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.PressedBorderColor = Color.FromArgb( 0, 120, 212 );
        }
    }
}
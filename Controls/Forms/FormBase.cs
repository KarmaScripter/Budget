// <copyright file = "FormBase.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using MetroSet_UI.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    public partial class FormBase : MetroSetForm
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="FormBase"/>
        /// class.
        /// </summary>
        public FormBase( )
        {
            InitializeComponent( );
            Font = new Font( "Roboto", 9 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ShowIcon = false;
            ShowInTaskbar = true;
            BorderThickness = 1;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Size = new Size( 1400, 800 );
            StartPosition = FormStartPosition.CenterScreen;
            Text = string.Empty;
        }
    }
}
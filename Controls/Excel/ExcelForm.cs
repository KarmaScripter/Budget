// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class ExcelForm : MetroForm
    {
        /// <summary>
        /// 
        /// </summary>
        public ExcelForm( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1400, 750 );
            MaximumSize = new Size( 1400, 800 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            FormBorderStyle = FormBorderStyle.Sizable;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = true;
            MetroColor = Color.FromArgb( 20, 20, 20);
            CaptionFont = new Font( "Roboto", 12 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.Red;
            MinimizeBox = false;
            MaximizeBox = false;
            
            // Event Wiring
            Load += OnLoad;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The
        /// <see cref="System.EventArgs"/>
        /// instance containing the event data.</param>
        /// <returns></returns>
        public void OnLoad( object sender, EventArgs e )
        {
            if( ToolStrip != null )
            {
                try
                {
                    ToolStrip.Office12Mode = true;
                    ToolStrip.Label.ForeColor = Color.Black;
                }
                catch ( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
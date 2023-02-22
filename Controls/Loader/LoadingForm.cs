// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Microsoft.Win32;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class LoadingForm : MetroForm
    {
        /// <summary>
        /// The image path
        /// </summary>
        public string ImagePath =
            @"C:\Users\terry\source\repos\Budget\Resources\Images\Loader\Loading.gif";

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <value>
        /// The picture.
        /// </value>
        public Image Picture { get; set; }

        /// <summary>
        /// Gets or sets the loader.
        /// </summary>
        /// <value>
        /// The loader.
        /// </value>
        public Bitmap Loader { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadingForm"/> class.
        /// </summary>
        public LoadingForm( )
        {
            InitializeComponent( );

            // Basic Form Properties
            Size = new Size( 1345, 745 );
            BackColor = Color.Black;
            CaptionBarColor = Color.Black;
            MetroColor = Color.Black;
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            BorderColor = Color.FromArgb( 0, 120, 212 );

            // Image Configuration
            // Loader = new Bitmap( Picture, new Size( 800, 600 ) );

            // Timer Configuration
            Timer.Enabled = true;
            Timer.Interval = 5000;
            Timer.Tick += OnTick;
            Timer.Start( );

            // Event Wiring
            Load += OnLoad;
            FormClosed += OnClose;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnTick( object sender, EventArgs e )
        {
            try
            {
                Timer.Stop( );
                Close( );
            }
            catch ( Exception ex )
            {
                Fail( ex  );
            }
        }

        /// <summary>
        /// Raises the Close event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnClose( object sender, EventArgs e )
        {
            try
            {
                if( Timer != null )
                {
                    Timer.Dispose(  );
                }
            }
            catch ( Exception ex )
            {
                Fail( ex  );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
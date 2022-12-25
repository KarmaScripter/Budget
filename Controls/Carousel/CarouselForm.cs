// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Data.Extensions;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class CarouselForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        /// <value>
        /// The image path.
        /// </value>
        public string ImagePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CarouselForm( )
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
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionFont = new Font( "Roboto", 11 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.LightSteelBlue;
            CaptionButtonColor = Color.FromArgb( 65, 65, 65 );
            CaptionButtonHoverColor = Color.Red;
            MinimizeBox = false;
            MaximizeBox = false;
            
            // Event Wiring
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="CarouselForm"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public CarouselForm( string filePath )
        {
            ImagePath = filePath;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            var _path = @"C:\Users\terry\source\repos\Budget\Resource\Images\Carousel\Provider\";
            Carousel.FilePath = _path;
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
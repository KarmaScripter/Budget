﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class Error : MetroForm
    {
        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public virtual Exception Exception { get; set; }

        /// <summary>
        /// Gets or sets the icon path.
        /// </summary>
        /// <value>
        /// The icon path.
        /// </value>
        public virtual string IconPath { get; set; }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="Error"/> class.
        /// </summary>
        public Error( )
        {
            InitializeComponent( );

            // Form Property Values
            BackColor = Color.FromArgb( 20, 20, 20 );
            BorderThickness = 1;
            BorderColor = Color.FromArgb( 192, 0, 0 );
            Size = new Size( 700, 550 );
            Font = new Font( "Roboto", 9 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 26;
            CaptionButtonColor = Color.FromArgb( 80, 80, 80 );
            CaptionButtonHoverColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 9 );
            MetroColor = Color.FromArgb( 20, 20, 20 );
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = new Icon( IconPath, 33, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = new Padding( 1 );
            Text = string.Empty;
            Size = new Size( 812, 486 );

            // TextBox Properties
            TextBox.BackColor = Color.FromArgb( 20, 20, 20 );
            TextBox.Parent = BackPanel;
            TextBox.Dock = DockStyle.Fill;
            BackPanel.BackColor = Color.FromArgb( 20, 20, 20 );
            BackPanel.Parent = this;
            BackPanel.Location = new Point( 61, 48 );
            BackPanel.Controls.Add( TextBox );
            Controls.Add( BackPanel );
            CloseButton.Click += OnClick;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="ext">The ext.</param>
        public Error( Exception ext )
        {
            InitializeComponent( );
            Exception = ext;
            Text = ext.ToLogString( Exception?.Message );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public Error( string message )
        {
            InitializeComponent( );
            Exception = null;
            TextBox.Text = message;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public void SetText( )
        {
            try
            {
                var _logString = Exception.ToLogString( "" );
                TextBox.Text = _logString;
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.StackTrace );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public void SetText( Exception exc )
        {
            try
            {
                var _logString = exc?.ToLogString( "" );
                TextBox.Text = _logString;
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.StackTrace );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public void SetText( string msg = "" )
        {
            TextBox.Text = msg;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                HeaderLabel.ForeColor = Color.Red;
                RenderIcon(  );
            }
            catch ( Exception ex )
            {
                Console.WriteLine( ex );
                throw;
            }
        }

        /// <summary>
        /// Renders the icon.
        /// </summary>
        public void RenderIcon( )
        {
            try
            {
                var _path = @"C:\Users\terry\source\repos\Budget\Resource\Images\Dialog\Error.png";
                Picture.Image = new Bitmap( _path );
            }
            catch ( Exception ex )
            {
                Console.WriteLine( ex );
                throw;
            }
        }
        
        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnClick( object sender, EventArgs e )
        {
            if( sender is Button )
            {
                Close( );
            }
        }
    }
}
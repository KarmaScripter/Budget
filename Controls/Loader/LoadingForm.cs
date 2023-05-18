﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref = "Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantEmptySwitchSection" ) ]
    public partial class LoadingForm : MetroForm
    {
        /// <summary> The loading path </summary>
        public readonly string LoadingPath =
            @"C:\Users\terry\source\repos\Budget\Resource\Images\Loader\Loading.gif";

        /// <summary> The processing path </summary>
        public readonly string ProcessingPath =
            @"C:\Users\terry\source\repos\Budget\Resource\Images\Loader\Processing.gif";

        /// <summary> The waiting path </summary>
        public readonly string WaitingPath =
            @"C:\Users\terry\source\repos\Budget\Resource\Images\Loader\Waiting.gif";

        /// <summary> Gets or sets the picture. </summary>
        /// <value> The picture. </value>
        public Image Picture { get; set; }

        /// <summary> Gets or sets the loader. </summary>
        /// <value> The loader. </value>
        public Bitmap Loader { get; set; }

        /// <summary> Gets or sets the status. </summary>
        /// <value> The status. </value>
        public Status Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "LoadingForm"/>
        /// class.
        /// </summary>
        public LoadingForm( )
        {
            InitializeComponent( );

            // Basic Form Properties
            Font = new Font( "Roboto", 9 );
            Size = new Size( 1345, 745 );
            MaximumSize = new Size( 1345, 745 );
            MinimumSize = new Size( 1345, 745 );
            BackColor = Color.Black;
            CaptionBarColor = Color.Black;
            MetroColor = Color.Black;
            ForeColor = Color.Black;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.None;
            BorderColor = Color.Transparent;

            // Timer Configuration
            Timer.Enabled = true;
            Timer.Interval = 5000;
            Timer.Tick += OnTick;
            Timer.Start( );

            // Event Wiring
            Load += OnLoad;
            Closing += OnClose;
            Shown += OnShown;
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "LoadingForm"/>
        /// class.
        /// </summary>
        /// <param name = "status" > The status. </param>
        public LoadingForm( Status status )
            : this( )
        {
            Status = status;
        }

        /// <summary> Called when [load]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                ShowImage( );
                CloseButton.Text = "Close Window";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [tick]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnTick( object sender, EventArgs e )
        {
            try
            {
                Timer?.Stop( );
                Close( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Shows the image. </summary>
        public void ShowImage( )
        {
            try
            {
                if( Enum.IsDefined( typeof( Status ), Status ) )
                {
                    PictureBox.Image = Status switch
                    {
                        Status.Loading => Image.FromFile( LoadingPath ),
                        Status.Processing => Image.FromFile( ProcessingPath ),
                        Status.Waiting => Image.FromFile( WaitingPath ),
                        _ => Image.FromFile( LoadingPath )
                    };
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Raises the Close event. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnClose( object sender, EventArgs e )
        {
            try
            {
                Timer?.Dispose( );
                if( Program.Windows.ContainsKey( Name ) )
                {
                    Program.Windows.Remove( Name );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [close button clicked]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnCloseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [shown]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnShown( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name = "ex" > The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
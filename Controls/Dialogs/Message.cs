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
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public partial class Message : MetroForm
    {
        /// <summary>
        /// 
        /// </summary>
        public Message( )
        {
            InitializeComponent( );
            Size = new Size( 700, 400 );
            MinimumSize = new Size( 700, 400 );
            MaximumSize = new Size( 700, 400 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OpenButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OpenButton.Text = "Open";
            OpenButton.ForeColor = Color.FromArgb( 0, 120, 212 );
            OpenButton.BackColor = Color.FromArgb( 20, 20, 20 );
            CloseButton.Text = "Close";
            CloseButton.ForeColor = Color.FromArgb( 0, 120, 212 );
            CloseButton.BackColor = Color.FromArgb( 20, 20, 20 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            TextBox.BackColor = Color.FromArgb( 40, 40, 40 );
            StartPosition = FormStartPosition.CenterScreen;
            CloseButton.Focus( );

            //Event Wiring
            CloseButton.Click += OnCloseButtonClick;
            OpenButton.Click += OnOpenButtonClick;
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="text">The text displayed by the control.</param>
        public Message( string text )
            : this( )
        {
            TextBox.Text = Environment.NewLine + text;
            CloseButton.Focus( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        public Message( string text, string caption )
            : this( text )
        {
            Header.Text = caption;
            CloseButton.Focus( );
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e"> instance containing the event data.
        /// </param>
        public virtual void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Header.ForeColor = Color.FromArgb( 0, 120, 212 );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnCloseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
               && !string.IsNullOrEmpty( _button?.Name ) )
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
        }

        /// <summary>
        /// Called when [open button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnOpenButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
               && !string.IsNullOrEmpty( _button?.Name ) )
            {
                try
                {
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
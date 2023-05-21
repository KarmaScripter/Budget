// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Threading;

    public class SizeConfig
    {
        /// <summary>
        /// Gets or sets the size of the client.
        /// </summary>
        /// <value>
        /// The size of the client.
        /// </value>
        public Size ClientSize { get; set; }

        /// <summary>
        /// Gets or sets the bounds.
        /// </summary>
        /// <value>
        /// The bounds.
        /// </value>
        public Size Bounds { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// The form normal
        /// </summary>
        public static readonly Size FormNormal = new Size( 1200, 750 );

        /// <summary>
        /// The form maximum
        /// </summary>
        public static readonly Size FormMaximum = new Size( 1500, 820 );

        /// <summary>
        /// The form minimum
        /// </summary>
        public static readonly Size FormMinimum = new Size( 600, 400 );

        /// <summary>
        /// The dialog normal
        /// </summary>
        public static readonly Size DialogNormal = new Size( 680, 530 );

        /// <summary>
        /// The dialog minimum
        /// </summary>
        public static readonly Size DialogMinimum = new Size( 300, 300 );

        /// <summary>
        /// The dialog maximum
        /// </summary>
        public static readonly Size DialogMaximum = new Size( 800, 800 );

        /// <summary>
        /// The context menu normal
        /// </summary>
        public static readonly Size ContextMenuNormal = new Size( 250, 350 );

        /// <summary>
        /// The image small
        /// </summary>
        public static readonly Size ImageSmall = new Size( 12, 12 );

        /// <summary>
        /// The image medium
        /// </summary>
        public static readonly Size ImageMedium = new Size( 16, 16 );

        /// <summary>
        /// The image large
        /// </summary>
        public static readonly Size ImageLarge = new Size( 20, 20 );

        /// <summary>
        /// The image huge
        /// </summary>
        public static readonly Size ImageHuge = new Size( 250, 250 );

        /// <summary>
        /// Initializes a new instance of the <see cref="SizeConfig"/> class.
        /// </summary>
        public SizeConfig( )
        {
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public static Size GetSize( int width = 1, int height = 1 )
        {
            try
            {
                return width > 0 && height > 0
                    ? new Size( width, height )
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public static Size GetSize( Size size )
        {
            if( size.Width > -1
               && size.Height > -1 )
            {
                try
                {
                    return size;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default;
        }

        /// <summary>
        /// Called when [size changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public static void OnSizeChanged( object sender, EventArgs e )
        {
            if( sender != null
               && e != null )
            {
                try
                {
                    var message = new Message( "NOT YET IMPLEMENTED" );
                    message?.ShowDialog( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        static private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

/// <summary> </summary>
/// <seealso cref = "Syncfusion.Windows.Forms.MetroForm"/>
[ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
[ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
[ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
public partial class MinionSelector : MetroForm
{
    /// <summary>
    /// Initializes a new instance of the
    /// <see cref = "MinionSelector"/>
    /// class.
    /// </summary>
    public MinionSelector( )
    {
        InitializeComponent( );

        // Basic Properties
        Size = new Size( 1200, 600 );
        MaximumSize = new Size( 1200, 600 );
        MinimumSize = new Size( 1200, 600 );
        BackColor = Color.FromArgb( 20, 20, 20 );
        ForeColor = Color.LightGray;
        Font = new Font( "Roboto", 9 );
        FormBorderStyle = FormBorderStyle.FixedSingle;
        BorderColor = Color.FromArgb( 20, 20, 20 );
        Dock = DockStyle.None;
        Anchor = AnchorStyles.Top | AnchorStyles.Left;
        ShowIcon = false;
        ShowInTaskbar = true;
        ShowMouseOver = true;
        MetroColor = Color.FromArgb( 20, 20, 20 );
        CaptionFont = new Font( "Roboto", 11 );
        CaptionBarColor = Color.FromArgb( 20, 20, 20 );
        CaptionForeColor = Color.FromArgb( 20, 20, 20 );
        CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
        CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
        MinimizeBox = false;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterParent;

        // Header Properties
        Header.Font = new Font( "Roboto", 16, FontStyle.Regular );
        Header.ForeColor = Color.FromArgb( 0, 120, 212 );

        // Panel Properties
        SelectionPanel.BorderColor = Color.Transparent;

        // Event Wiring
        Carousel.OnCarouselItemSelectionChanged += OnItemSelected;
        CloseButton.Click += OnCloseButtonClicked;
        Load += OnLoad;
    }

    /// <summary> Gets or sets the image path. </summary>
    /// <value> The image path. </value>
    public string ImagePath { get; set; } =
        @"C:\Users\terry\source\repos\Budget\Resource\Images\Carousel\Minion";

    /// <summary> Called when [load]. </summary>
    /// <param name = "sender" > The sender. </param>
    /// <param name = "e" >
    /// The
    /// <see cref = "EventArgs"/>
    /// instance containing the event data.
    /// </param>
    public void OnLoad( object sender, EventArgs e )
    {
        if( !string.IsNullOrEmpty( ImagePath ) )
        {
            try
            {
                var _files = Directory.GetFiles( ImagePath );
                for( var _i = 0; _i < _files.Length; _i++ )
                {
                    var _path = _files[ _i ];
                    if( !string.IsNullOrEmpty( _files[ _i ] )
                       && File.Exists( _files[ _i ] ) )
                    {
                        var _name = Path.GetFileNameWithoutExtension( _path );
                        using var _stream = File.Open( _path, FileMode.Open );
                        var _image = new Bitmap( _stream );
                        _image.Tag = _name;
                        var _carouselImage = new CarouselImage( );
                        _carouselImage.ItemImage = _image;
                        Carousel.ImageListCollection.Add( _carouselImage );
                    }
                }

                Carousel.FilePath = ImagePath;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }

    /// <summary> Called when [item selected]. </summary>
    /// <param name = "sender" > The sender. </param>
    /// <param name = "e" >
    /// The
    /// <see cref = "EventArgs"/>
    /// instance containing the event data.
    /// </param>
    public void OnItemSelected( object sender, EventArgs e )
    {
        if( sender is Selector _carousel )
        {
            try
            {
                var _tag = _carousel?.ActiveImage?.Tag?.ToString( );
                var _provider = DataBuilder.GetProvider( _tag );
                switch( _provider )
                {
                    case Provider.SQLite:
                    {
                        Minion.OpenSQLite( );
                        Close( );
                        break;
                    }
                    case Provider.SqlCe:
                    {
                        Minion.OpenSqlCe( );
                        Close( );
                        break;
                    }
                    case Provider.SqlServer:
                    {
                        Minion.OpenSqlCe( );
                        Close( );
                        break;
                    }
                    case Provider.Access:
                    {
                        Minion.OpenAccess( );
                        Close( );
                        break;
                    }
                    case Provider.Excel:
                    {
                        Minion.OpenExcel( );
                        Close( );
                        break;
                    }
                    default:
                    {
                        Minion.OpenSQLite( );
                        Close( );
                        break;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }

    /// <summary> Called when [close button clicked]. </summary>
    /// <param name = "sender" > The sender. </param>
    /// <param name = "e" >
    /// The
    /// <see cref = "EventArgs"/>
    /// instance containing the event data.
    /// </param>
    private void OnCloseButtonClicked( object sender, EventArgs e )
    {
        if( sender is Button _button )
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

    /// <summary> Fails the specified ex. </summary>
    /// <param name = "ex" > The ex. </param>
    private static void Fail( Exception ex )
    {
        using var _error = new ErrorDialog( ex );
        _error?.SetText( );
        _error?.ShowDialog( );
    }
}
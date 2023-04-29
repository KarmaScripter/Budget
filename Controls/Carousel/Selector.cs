// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public class Selector : Carousel
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public virtual List<Image> Images { get; set; }
        
        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        public Size ImageSize { get; set; }
        
        /// <summary>
        /// Gets or sets the fund path.
        /// </summary>
        /// <value>
        /// The fund path.
        /// </value>
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="Selector"/> class.
        /// </summary>
        public Selector( )
        {
            // Basic Carousel Properties
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.White;
            Font = new Font( "Roboto", 8 );
            CarouselPath = CarouselPath.Default;
            ImageSlides = true;
            PadX = 0;
            PadY = 0;
            Perspective = 4;
            RotateAlways = false;
            ShowImagePreview = true;
            ShowImageShadow = true;
            TransitionSpeed = 2;
            UseOriginalImageinPreview = true;
            UseCustomBounds = false;
            CanOverrideStyle = true;
            VisualStyle = CarouselVisualStyle.Metro;
            HighlightColor = Color.FromArgb( 0, 120, 212 );

            // ThemeStyle Properties
            ThemeStyle.BackColor = Color.Transparent;
            ThemeStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.ForeColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HoverImageBorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HoverImageBorderThickness = 3;
            ThemeStyle.ImageShadeColor = Color.FromArgb( 18, 18, 18 );

            // User Properties
            ImageSize = new Size( 250, 250 );
        }
        
        /// <summary>
        /// Get ErrorDialog Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
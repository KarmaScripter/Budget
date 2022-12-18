﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Grid.GridDataBoundGrid" />
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    public abstract class DataGridBase : GridDataBoundGrid
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGridBase"/> class.
        /// </summary>
        /// <overload>
        /// Initializes a new instance of
        /// <see cref="T:Syncfusion.Windows.Forms.Grid.GridDataBoundGrid" />.
        /// </overload>
        public DataGridBase( )
        {
            // Basic Properties
            ForeColor = Color.LightGray;
            BackColor = Color.FromArgb( 20, 20, 20 );
            Font = new Font( "Roboto", 9 );
            Margin = new Padding( 0 );
            Padding = new Padding( 0 );
            Size = new Size( 700, 400 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Font = new Font( "Roboto", 9 );
            Visible = true;
            Enabled = true;

            // Model Properties
            Model.Rows.DefaultSize = 22;
            Model.ActiveGridView.PdfExport = true;
            Model.Properties.ThemedHeader = false;
            Model.Properties.GridLineColor = Color.FromArgb( 64, 64, 64 );

            // Style Properties
            ThemesEnabled = true;
            ApplyVisualStyles = true;
            EnableAddNew = true;
            EnableEdit = true;
            EnableRemove = true;
            AllowResizeToFit = true;
            ExcelLikeSelectionFrame = true;
            ExcelLikeAlignment = true;
            AlphaBlendSelectionColor = Color.FromArgb( 0, 120, 212 );
            Properties.BackgroundColor = Color.FromArgb( 40, 40, 40 );
            Properties.CenterHorizontal = true;
            Properties.CenterVertical = true;
            Properties.ColHeaders = true;
            Properties.RowHeaders = true;
            Properties.Buttons3D = true;

            // Table Style Properties
            TableStyle.Themed = true;
            TableStyle.WrapText = false;
            TableStyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            TableStyle.AutoFit = AutoFitOptions.Both;
            TableStyle.Font.Facename = "Roboto";
            TableStyle.Font.Size = 9;
        }
    }
}
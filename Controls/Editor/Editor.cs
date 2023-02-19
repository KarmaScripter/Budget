// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.HTMLUI.Base;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Edit;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Edit.EditControl" />
    public class Editor : EditControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Editor"/> class.
        /// </summary>
        public Editor( )
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AlwaysShowScrollers = true;
            BackColor = Color.FromArgb( 5, 5, 5 );
            BackgroundColor = new BrushInfo( SystemColors.ControlLight );
            BorderStyle = BorderStyle.FixedSingle;
            CanOverrideStyle = true;
            CanApplyTheme = true;
            ColumnGuidesMeasuringFont = new Font( "Roboto", 8 );
            ContextChoiceFont = new Font( "Roboto", 8 );
            ContextChoiceForeColor = Color.DarkGray;
            ContextChoiceBackColor = Color.FromArgb( 30, 30, 30 );
            ContextPromptBorderColor = Color.FromArgb( 0, 120, 212 );
            ContextPromptBackgroundBrush = new BrushInfo( Color.FromArgb( 30, 30, 30 ) );
            ContextTooltipBackgroundBrush = new BrushInfo( Color.FromArgb( 30, 30, 30 ) );
            ContextTooltipBorderColor = Color.FromArgb( 0, 120, 212 );
            EndOfLineBackColor = Color.FromArgb( 5, 5, 5 );
            EndOfLineForeColor = Color.DimGray;
            HighlightCurrentLine = true;
            IndentationBlockBorderColor = Color.FromArgb( 0, 120, 212 );
            IndentLineColor = Color.FromArgb( 0, 120, 212 );
            IndicatorMarginBackColor = Color.FromArgb( 30, 30, 30 );
            CurrentLineHighlightColor = Color.FromArgb( 50, 93, 129 );
            Font = new Font( "Source Code Pro", 12  );
            ForeColor = Color.LightGray;
            LineNumbersColor = Color.DimGray;
            LineNumbersFont = new Font( "Hack", 8, FontStyle.Bold );
            ScrollVisualStyle = ScrollBarCustomDrawStyles.Office2016;
            ScrollColorScheme = Office2007ColorScheme.Black;
            SelectionTextColor = Color.White;
            ShowEndOfLine = false;
            Style = EditControlStyle.Office2016Black;
            TabSize = 4;
            TextAreaWidth = 400;
            WordWrap = true;
            WordWrapColumn = 80;
        }
    }
}
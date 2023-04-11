namespace BudgetExecution
{
    using System.Windows.Forms;


    partial class PdfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            components =  new System.ComponentModel.Container( ) ;
            var messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings( );
            var pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( PdfForm ) );
            var textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings( );
            ToolStrip =  new ToolStrip( ) ;
            DropDown =  new ToolStripDropDown( ) ;
            ToolTip =  new SmallTip( ) ;
            HomeButton =  new ToolStripButton( ) ;
            Separator1 =  new ToolSeparator( ) ;
            Label =  new ToolStripLabel( ) ;
            BindingSource =  new BindingSource( components ) ;
            Separator2 =  new ToolSeparator( ) ;
            Separator3 =  new ToolSeparator( ) ;
            LookupButton =  new ToolStripButton( ) ;
            Separator6 =  new ToolSeparator( ) ;
            DatabaseButton =  new ToolStripButton( ) ;
            Separator4 =  new ToolSeparator( ) ;
            BackButton =  new ToolStripButton( ) ;
            toolSeparator7 =  new ToolSeparator( ) ;
            Separator5 =  new ToolSeparator( ) ;
            toolSeparator1 =  new ToolSeparator( ) ;
            ToolSeparator =  new ToolSeparator( ) ;
            toolSeparator3 =  new ToolSeparator( ) ;
            DocViewer =  new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl( ) ;
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            SuspendLayout( );
            // 
            // ToolStrip
            // 
            ToolStrip.AddButton =  null ;
            ToolStrip.AddColumnButton =  null ;
            ToolStrip.AddTableButton =  null ;
            ToolStrip.BackColor =  System.Drawing.Color.Transparent ;
            ToolStrip.BindingSource =  null ;
            ToolStrip.BorderStyle =  Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge ;
            ToolStrip.CalculatorButton =  null ;
            ToolStrip.CanOverrideStyle =  true ;
            ToolStrip.CaptionAlignment =  Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near ;
            ToolStrip.CaptionFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ToolStrip.CaptionStyle =  Syncfusion.Windows.Forms.Tools.CaptionStyle.Top ;
            ToolStrip.CaptionTextStyle =  Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain ;
            ToolStrip.ChartButton =  null ;
            ToolStrip.DataFilter =  null ;
            ToolStrip.DeleteButton =  null ;
            ToolStrip.DeleteColumnButton =  null ;
            ToolStrip.DeleteRecordButton =  null ;
            ToolStrip.DeleteTableButton =  null ;
            ToolStrip.Dock =  DockStyle.Bottom ;
            ToolStrip.DropDown =  DropDown ;
            ToolStrip.EditButton =  null ;
            ToolStrip.EditColumnButton =  null ;
            ToolStrip.EditRecordButton =  null ;
            ToolStrip.EditSqlButton =  null ;
            ToolStrip.ExcelButton =  null ;
            ToolStrip.FilterDataButton =  null ;
            ToolStrip.FirstButton =  null ;
            ToolStrip.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ToolStrip.ForeColor =  System.Drawing.Color.MidnightBlue ;
            ToolStrip.GripStyle =  ToolStripGripStyle.Hidden ;
            ToolStrip.HomeButton =  HomeButton ;
            ToolStrip.Image =  null ;
            ToolStrip.ImageDirectory =  null ;
            ToolStrip.ImageScalingSize =  new System.Drawing.Size( 20, 20 ) ;
            ToolStrip.ImageSize =  new System.Drawing.Size( 0, 0 ) ;
            ToolStrip.Items.AddRange( new ToolStripItem[ ] { Separator1, Label, Separator2, DropDown, Separator3, LookupButton, Separator6, DatabaseButton, Separator4, BackButton, toolSeparator7, HomeButton, Separator5 } );
            ToolStrip.Label =  Label ;
            ToolStrip.LastButton =  null ;
            ToolStrip.LauncherStyle =  Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12 ;
            ToolStrip.Location =  new System.Drawing.Point( 0, 664 ) ;
            ToolStrip.Margin =  new Padding( 1 ) ;
            ToolStrip.Name =  "ToolStrip" ;
            ToolStrip.NextButton =  null ;
            ToolStrip.Office12Mode =  false ;
            ToolStrip.OfficeColorScheme =  Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black ;
            ToolStrip.Padding =  new Padding( 1 ) ;
            ToolStrip.PreviousButton =  null ;
            ToolStrip.ProgressBar =  null ;
            ToolStrip.RefreshButton =  null ;
            ToolStrip.SaveButton =  null ;
            ToolStrip.SearchCriteriaLabel =  null ;
            ToolStrip.SearchEngineLabel =  null ;
            ToolStrip.Separators =  null ;
            ToolStrip.ShowCaption =  true ;
            ToolStrip.ShowLauncher =  true ;
            ToolStrip.Size =  new System.Drawing.Size( 1388, 50 ) ;
            ToolStrip.TabIndex =  1 ;
            ToolStrip.Text =  "toolStrip1" ;
            ToolStrip.TextBox =  null ;
            ToolStrip.ThemeName =  "Office2016DarkGray" ;
            ToolStrip.ThemeStyle.ArrowColor =  System.Drawing.Color.SteelBlue ;
            ToolStrip.ThemeStyle.BackColor =  System.Drawing.Color.Transparent ;
            ToolStrip.ThemeStyle.BottomToolStripBackColor =  System.Drawing.Color.Transparent ;
            ToolStrip.ThemeStyle.CaptionBackColor =  System.Drawing.Color.FromArgb(   28  ,   28  ,   28   ) ;
            ToolStrip.ThemeStyle.CaptionForeColor =  System.Drawing.Color.Black ;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor =  System.Drawing.Color.SteelBlue ;
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor =  System.Drawing.Color.FromArgb(   40  ,   40  ,   40   ) ;
            ToolStrip.ThemeStyle.HoverItemBackColor =  System.Drawing.Color.SteelBlue ;
            ToolStrip.ThemeStyle.HoverItemForeColor =  System.Drawing.Color.White ;
            ToolStrip.UseWaitCursor =  true ;
            ToolStrip.VisualStyle =  Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray ;
            // 
            // DropDown
            // 
            DropDown.AllowDrop =  true ;
            DropDown.BindingSource =  null ;
            DropDown.DataFilter =  null ;
            DropDown.DropDownStyle =  ComboBoxStyle.DropDownList ;
            DropDown.Field =  Field.AccountCode ;
            DropDown.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            DropDown.ForeColor =  System.Drawing.Color.FromArgb(   218  ,   218  ,   218   ) ;
            DropDown.HoverText =  "Select Document" ;
            DropDown.Margin =  new Padding( 1 ) ;
            DropDown.MaxDropDownItems =  100 ;
            DropDown.MaxLength =  32767 ;
            DropDown.Name =  "DropDown" ;
            DropDown.Numeric =  Numeric.Accepted ;
            DropDown.Padding =  new Padding( 1 ) ;
            DropDown.Size =  new System.Drawing.Size( 352, 32 ) ;
            DropDown.Style =  Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black ;
            DropDown.Tag =  "Make Selection" ;
            DropDown.ToolTip =  ToolTip ;
            DropDown.ToolTipText =  "Make Selection" ;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay =  5000 ;
            ToolTip.BackColor =  System.Drawing.Color.FromArgb(   5  ,   5  ,   5   ) ;
            ToolTip.BindingSource =  null ;
            ToolTip.BorderColor =  System.Drawing.SystemColors.Highlight ;
            ToolTip.ForeColor =  System.Drawing.Color.White ;
            ToolTip.InitialDelay =  500 ;
            ToolTip.IsDerivedStyle =  true ;
            ToolTip.Name =  null ;
            ToolTip.OwnerDraw =  true ;
            ToolTip.ReshowDelay =  100 ;
            ToolTip.Style =  MetroSet_UI.Enums.Style.Custom ;
            ToolTip.StyleManager =  null ;
            ToolTip.ThemeAuthor =  "Terry D. Eppler" ;
            ToolTip.ThemeName =  "Budget Execution" ;
            ToolTip.TipIcon =  ToolTipIcon.Info ;
            ToolTip.TipText =  null ;
            ToolTip.TipTitle =  null ;
            // 
            // HomeButton
            // 
            HomeButton.AutoToolTip =  false ;
            HomeButton.BackColor =  System.Drawing.Color.Transparent ;
            HomeButton.BindingSource =  null ;
            HomeButton.DataFilter =  null ;
            HomeButton.DisplayStyle =  ToolStripItemDisplayStyle.Image ;
            HomeButton.Field =  Field.AccountCode ;
            HomeButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            HomeButton.ForeColor =  System.Drawing.Color.LightGray ;
            HomeButton.HoverText =  "Main Menu" ;
            HomeButton.Image =  Properties.Resources.HomeButton ;
            HomeButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            HomeButton.Margin =  new Padding( 1 ) ;
            HomeButton.Name =  "HomeButton" ;
            HomeButton.Padding =  new Padding( 1 ) ;
            HomeButton.Size =  new System.Drawing.Size( 26, 32 ) ;
            HomeButton.Text =  "toolStripButton1" ;
            HomeButton.ToolTip =  null ;
            HomeButton.ToolType =  ToolType.HomeButton ;
            // 
            // Separator1
            // 
            Separator1.ForeColor =  System.Drawing.Color.Black ;
            Separator1.Margin =  new Padding( 1 ) ;
            Separator1.Name =  "Separator1" ;
            Separator1.Padding =  new Padding( 1 ) ;
            Separator1.Size =  new System.Drawing.Size( 6, 32 ) ;
            // 
            // Label
            // 
            Label.BackColor =  System.Drawing.Color.FromArgb(   45  ,   45  ,   45   ) ;
            Label.BindingSource =  BindingSource ;
            Label.DataFilter =  null ;
            Label.Field =  Field.AccountCode ;
            Label.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Label.ForeColor =  System.Drawing.Color.White ;
            Label.HoverText =  null ;
            Label.Margin =  new Padding( 1 ) ;
            Label.Name =  "Label" ;
            Label.Padding =  new Padding( 1 ) ;
            Label.Size =  new System.Drawing.Size( 125, 32 ) ;
            Label.Tag =  "" ;
            Label.Text =  "Guidance Documents" ;
            Label.ToolTip =  ToolTip ;
            // 
            // Separator2
            // 
            Separator2.ForeColor =  System.Drawing.Color.Black ;
            Separator2.Margin =  new Padding( 1 ) ;
            Separator2.Name =  "Separator2" ;
            Separator2.Padding =  new Padding( 1 ) ;
            Separator2.Size =  new System.Drawing.Size( 6, 32 ) ;
            // 
            // Separator3
            // 
            Separator3.ForeColor =  System.Drawing.Color.Black ;
            Separator3.Margin =  new Padding( 1 ) ;
            Separator3.Name =  "Separator3" ;
            Separator3.Padding =  new Padding( 1 ) ;
            Separator3.Size =  new System.Drawing.Size( 6, 32 ) ;
            // 
            // LookupButton
            // 
            LookupButton.AutoToolTip =  false ;
            LookupButton.BackColor =  System.Drawing.Color.Transparent ;
            LookupButton.BindingSource =  null ;
            LookupButton.DataFilter =  null ;
            LookupButton.DisplayStyle =  ToolStripItemDisplayStyle.Image ;
            LookupButton.Field =  Field.AccountCode ;
            LookupButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            LookupButton.ForeColor =  System.Drawing.Color.LightGray ;
            LookupButton.HoverText =  "Browse Documents" ;
            LookupButton.Image =  Properties.Resources.LookupButton ;
            LookupButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            LookupButton.Margin =  new Padding( 1 ) ;
            LookupButton.Name =  "LookupButton" ;
            LookupButton.Padding =  new Padding( 1 ) ;
            LookupButton.Size =  new System.Drawing.Size( 26, 32 ) ;
            LookupButton.Text =  "toolStripButton1" ;
            LookupButton.ToolTip =  null ;
            LookupButton.ToolType =  ToolType.LookupButton ;
            // 
            // Separator6
            // 
            Separator6.ForeColor =  System.Drawing.Color.Black ;
            Separator6.Margin =  new Padding( 1 ) ;
            Separator6.Name =  "Separator6" ;
            Separator6.Padding =  new Padding( 1 ) ;
            Separator6.Size =  new System.Drawing.Size( 6, 32 ) ;
            // 
            // DatabaseButton
            // 
            DatabaseButton.AutoToolTip =  false ;
            DatabaseButton.BackColor =  System.Drawing.Color.Transparent ;
            DatabaseButton.BindingSource =  null ;
            DatabaseButton.DataFilter =  null ;
            DatabaseButton.DisplayStyle =  ToolStripItemDisplayStyle.Image ;
            DatabaseButton.Field =  Field.AccountCode ;
            DatabaseButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            DatabaseButton.ForeColor =  System.Drawing.Color.LightGray ;
            DatabaseButton.HoverText =  "View Databases" ;
            DatabaseButton.Image =  Properties.Resources.DatabaseButton ;
            DatabaseButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            DatabaseButton.Margin =  new Padding( 1 ) ;
            DatabaseButton.Name =  "DatabaseButton" ;
            DatabaseButton.Padding =  new Padding( 1 ) ;
            DatabaseButton.Size =  new System.Drawing.Size( 26, 32 ) ;
            DatabaseButton.Text =  "toolStripButton1" ;
            DatabaseButton.ToolTip =  null ;
            DatabaseButton.ToolType =  ToolType.DatabaseButton ;
            // 
            // Separator4
            // 
            Separator4.ForeColor =  System.Drawing.Color.Black ;
            Separator4.Margin =  new Padding( 1 ) ;
            Separator4.Name =  "Separator4" ;
            Separator4.Padding =  new Padding( 1 ) ;
            Separator4.Size =  new System.Drawing.Size( 6, 32 ) ;
            // 
            // BackButton
            // 
            BackButton.AutoToolTip =  false ;
            BackButton.BackColor =  System.Drawing.Color.Transparent ;
            BackButton.BindingSource =  BindingSource ;
            BackButton.DataFilter =  null ;
            BackButton.DisplayStyle =  ToolStripItemDisplayStyle.Image ;
            BackButton.Field =  Field.AccountCode ;
            BackButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            BackButton.ForeColor =  System.Drawing.Color.LightGray ;
            BackButton.HoverText =  "Go Back" ;
            BackButton.Image =  Properties.Resources.BackButton ;
            BackButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            BackButton.Margin =  new Padding( 3 ) ;
            BackButton.Name =  "BackButton" ;
            BackButton.Padding =  new Padding( 1 ) ;
            BackButton.Size =  new System.Drawing.Size( 26, 28 ) ;
            BackButton.Text =  "toolStripButton1" ;
            BackButton.ToolTip =  null ;
            BackButton.ToolType =  ToolType.BackButton ;
            // 
            // toolSeparator7
            // 
            toolSeparator7.ForeColor =  System.Drawing.Color.Black ;
            toolSeparator7.Margin =  new Padding( 1 ) ;
            toolSeparator7.Name =  "toolSeparator7" ;
            toolSeparator7.Padding =  new Padding( 1 ) ;
            toolSeparator7.Size =  new System.Drawing.Size( 6, 32 ) ;
            // 
            // Separator5
            // 
            Separator5.ForeColor =  System.Drawing.Color.Black ;
            Separator5.Margin =  new Padding( 1 ) ;
            Separator5.Name =  "Separator5" ;
            Separator5.Padding =  new Padding( 1 ) ;
            Separator5.Size =  new System.Drawing.Size( 6, 32 ) ;
            // 
            // toolSeparator1
            // 
            toolSeparator1.ForeColor =  System.Drawing.Color.Black ;
            toolSeparator1.Margin =  new Padding( 1 ) ;
            toolSeparator1.Name =  "toolSeparator1" ;
            toolSeparator1.Padding =  new Padding( 1 ) ;
            toolSeparator1.Size =  new System.Drawing.Size( 6, 30 ) ;
            // 
            // ToolSeparator
            // 
            ToolSeparator.ForeColor =  System.Drawing.Color.Black ;
            ToolSeparator.Margin =  new Padding( 1 ) ;
            ToolSeparator.Name =  "ToolSeparator" ;
            ToolSeparator.Padding =  new Padding( 1 ) ;
            ToolSeparator.Size =  new System.Drawing.Size( 6, 26 ) ;
            // 
            // toolSeparator3
            // 
            toolSeparator3.ForeColor =  System.Drawing.Color.Black ;
            toolSeparator3.Margin =  new Padding( 1 ) ;
            toolSeparator3.Name =  "toolSeparator3" ;
            toolSeparator3.Padding =  new Padding( 1 ) ;
            toolSeparator3.Size =  new System.Drawing.Size( 6, 26 ) ;
            // 
            // DocViewer
            // 
            DocViewer.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            DocViewer.CursorMode =  Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool ;
            DocViewer.Dock =  DockStyle.Fill ;
            DocViewer.EnableContextMenu =  true ;
            DocViewer.EnableNotificationBar =  true ;
            DocViewer.HorizontalScrollOffset =  0 ;
            DocViewer.IsBookmarkEnabled =  true ;
            DocViewer.IsTextSearchEnabled =  true ;
            DocViewer.IsTextSelectionEnabled =  true ;
            DocViewer.Location =  new System.Drawing.Point( 0, 0 ) ;
            messageBoxSettings1.EnableNotification =  true ;
            DocViewer.MessageBoxSettings =  messageBoxSettings1 ;
            DocViewer.MinimumZoomPercentage =  50 ;
            DocViewer.Name =  "DocViewer" ;
            DocViewer.PageBorderThickness =  1 ;
            pdfViewerPrinterSettings1.Copies =  1 ;
            pdfViewerPrinterSettings1.PageOrientation =  Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto ;
            pdfViewerPrinterSettings1.PageSize =  Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize ;
            pdfViewerPrinterSettings1.PrintLocation =  (System.Drawing.PointF) resources.GetObject( "pdfViewerPrinterSettings1.PrintLocation" )  ;
            pdfViewerPrinterSettings1.ShowPrintStatusDialog =  true ;
            DocViewer.PrinterSettings =  pdfViewerPrinterSettings1 ;
            DocViewer.ReferencePath =  null ;
            DocViewer.ScrollDisplacementValue =  0 ;
            DocViewer.ShowHorizontalScrollBar =  true ;
            DocViewer.ShowToolBar =  true ;
            DocViewer.ShowVerticalScrollBar =  true ;
            DocViewer.Size =  new System.Drawing.Size( 1388, 664 ) ;
            DocViewer.SpaceBetweenPages =  8 ;
            DocViewer.TabIndex =  2 ;
            DocViewer.Text =  "pdfViewerControl1" ;
            textSearchSettings1.CurrentInstanceColor =  System.Drawing.Color.FromArgb(   127  ,   255  ,   171  ,   64   ) ;
            textSearchSettings1.HighlightAllInstance =  true ;
            textSearchSettings1.OtherInstanceColor =  System.Drawing.Color.FromArgb(   127  ,   254  ,   255  ,   0   ) ;
            DocViewer.TextSearchSettings =  textSearchSettings1 ;
            DocViewer.ThemeName =  "Office2016Black" ;
            DocViewer.UseWaitCursor =  true ;
            DocViewer.VerticalScrollOffset =  0 ;
            DocViewer.VisualStyle =  Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Black ;
            DocViewer.ZoomMode =  Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitWidth ;

            // 
            // PdfForm
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   15  ,   15  ,   15   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionAlign =  HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 1388, 714 ) ;
            Controls.Add( DocViewer );
            Controls.Add( ToolStrip );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            Name =  "PdfForm" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            ShowMouseOver =  true ;
            StartPosition =  FormStartPosition.CenterParent ;
            Text =  "PDF Document" ;
            UseWaitCursor =  true ;
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion
        public ToolSeparator Separator1;
        public ToolStrip ToolStrip;
        public ToolSeparator ToolSeparator;
        public ToolSeparator Separator2;
        public ToolStripDropDown DropDown;
        public ToolSeparator Separator3;
        public ToolStripLabel Label;
        public ToolStripButton LookupButton;
        public ToolSeparator toolSeparator3;
        public ToolSeparator Separator4;

        public ToolStripButton DatabaseButton;
        private ToolSeparator toolSeparator7;
        public ToolSeparator Separator6;
        public ToolSeparator Separator5;
        public ToolStripButton HomeButton;
        public BindingSource BindingSource;
        public SmallTip ToolTip;
        public Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl DocViewer;
        public ToolStripButton BackButton;
        private ToolSeparator toolSeparator1;
    }
}
﻿namespace BudgetExecution
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
            ToolTip =  new SmallTip( ) ;
            BindingSource =  new BindingSource( components ) ;
            DocViewer =  new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl( ) ;
            PdfTable =  new TableLayoutPanel( ) ;
            PictureBox =  new PictureBox( ) ;
            HeaderLabel =  new Label( ) ;
            DocumentPanel =  new Layout( ) ;
            ButtonTable =  new TableLayoutPanel( ) ;
            CloseButtonTable =  new TableLayoutPanel( ) ;
            MenuButton =  new Button( ) ;
            CloseButton =  new Button( ) ;
            BackButton =  new Button( ) ;
            ListBoxTable =  new HeaderPanel( ) ;
            ListBoxPanel =  new Layout( ) ;
            FlowPanel =  new FlowLayoutPanel( ) ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            PdfTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            DocumentPanel.SuspendLayout( );
            CloseButtonTable.SuspendLayout( );
            ListBoxTable.SuspendLayout( );
            ListBoxPanel.SuspendLayout( );
            SuspendLayout( );
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
            // DocViewer
            // 
            DocViewer.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            DocViewer.CursorMode =  Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool ;
            DocViewer.EnableContextMenu =  true ;
            DocViewer.EnableNotificationBar =  true ;
            DocViewer.HorizontalScrollOffset =  0 ;
            DocViewer.IsBookmarkEnabled =  true ;
            DocViewer.IsTextSearchEnabled =  true ;
            DocViewer.IsTextSelectionEnabled =  true ;
            DocViewer.Location =  new System.Drawing.Point( 19, 14 ) ;
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
            DocViewer.Size =  new System.Drawing.Size( 946, 636 ) ;
            DocViewer.SpaceBetweenPages =  8 ;
            DocViewer.TabIndex =  2 ;
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
            // PdfTable
            // 
            PdfTable.ColumnCount =  4 ;
            PdfTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 78.125F ) );
            PdfTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 21.875F ) );
            PdfTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 990F ) );
            PdfTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 298F ) );
            PdfTable.Controls.Add( PictureBox, 0, 0 );
            PdfTable.Controls.Add( HeaderLabel, 2, 0 );
            PdfTable.Controls.Add( DocumentPanel, 2, 1 );
            PdfTable.Controls.Add( ButtonTable, 2, 2 );
            PdfTable.Controls.Add( CloseButtonTable, 3, 2 );
            PdfTable.Controls.Add( ListBoxTable, 3, 1 );
            PdfTable.Dock =  DockStyle.Fill ;
            PdfTable.Location =  new System.Drawing.Point( 0, 0 ) ;
            PdfTable.Name =  "PdfTable" ;
            PdfTable.RowCount =  3 ;
            PdfTable.RowStyles.Add( new RowStyle( SizeType.Percent, 4.700855F ) );
            PdfTable.RowStyles.Add( new RowStyle( SizeType.Percent, 95.29915F ) );
            PdfTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 36F ) );
            PdfTable.Size =  new System.Drawing.Size( 1338, 739 ) ;
            PdfTable.TabIndex =  3 ;
            PdfTable.UseWaitCursor =  true ;
            // 
            // PictureBox
            // 
            PictureBox.Image =  Properties.Resources.EPA ;
            PictureBox.Location =  new System.Drawing.Point( 3, 3 ) ;
            PictureBox.Name =  "PictureBox" ;
            PictureBox.Size =  new System.Drawing.Size( 33, 17 ) ;
            PictureBox.SizeMode =  PictureBoxSizeMode.StretchImage ;
            PictureBox.TabIndex =  5 ;
            PictureBox.TabStop =  false ;
            PictureBox.UseWaitCursor =  true ;
            // 
            // HeaderLabel
            // 
            HeaderLabel.BindingSource =  null ;
            HeaderLabel.DataFilter =  null ;
            HeaderLabel.Dock =  DockStyle.Fill ;
            HeaderLabel.FlatStyle =  FlatStyle.Flat ;
            HeaderLabel.Font =  new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            HeaderLabel.HoverText =  null ;
            HeaderLabel.IsDerivedStyle =  true ;
            HeaderLabel.Location =  new System.Drawing.Point( 52, 3 ) ;
            HeaderLabel.Margin =  new Padding( 3 ) ;
            HeaderLabel.Name =  "HeaderLabel" ;
            HeaderLabel.Padding =  new Padding( 1 ) ;
            HeaderLabel.Size =  new System.Drawing.Size( 984, 27 ) ;
            HeaderLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
            HeaderLabel.StyleManager =  null ;
            HeaderLabel.TabIndex =  7 ;
            HeaderLabel.Text =  "Title" ;
            HeaderLabel.TextAlign =  System.Drawing.ContentAlignment.MiddleCenter ;
            HeaderLabel.ThemeAuthor =  "Terry D. Eppler" ;
            HeaderLabel.ThemeName =  "Budget Execution" ;
            HeaderLabel.ToolTip =  null ;
            HeaderLabel.UseWaitCursor =  true ;
            // 
            // DocumentPanel
            // 
            DocumentPanel.BackColor =  System.Drawing.Color.Transparent ;
            DocumentPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            DocumentPanel.BindingSource =  null ;
            DocumentPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            DocumentPanel.BorderThickness =  1 ;
            DocumentPanel.Children =  null ;
            DocumentPanel.Controls.Add( DocViewer );
            DocumentPanel.DataFilter =  null ;
            DocumentPanel.Dock =  DockStyle.Fill ;
            DocumentPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            DocumentPanel.ForeColor =  System.Drawing.Color.Transparent ;
            DocumentPanel.HoverText =  null ;
            DocumentPanel.IsDerivedStyle =  true ;
            DocumentPanel.Location =  new System.Drawing.Point( 52, 36 ) ;
            DocumentPanel.Name =  "DocumentPanel" ;
            DocumentPanel.Padding =  new Padding( 1 ) ;
            DocumentPanel.Size =  new System.Drawing.Size( 984, 663 ) ;
            DocumentPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            DocumentPanel.StyleManager =  null ;
            DocumentPanel.TabIndex =  4 ;
            DocumentPanel.ThemeAuthor =  "Terry D. Eppler" ;
            DocumentPanel.ThemeName =  "Budget Execution" ;
            DocumentPanel.ToolTip =  null ;
            DocumentPanel.UseWaitCursor =  true ;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount =  10 ;
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 10F ) );
            ButtonTable.Dock =  DockStyle.Fill ;
            ButtonTable.GrowStyle =  TableLayoutPanelGrowStyle.FixedSize ;
            ButtonTable.Location =  new System.Drawing.Point( 52, 705 ) ;
            ButtonTable.Name =  "ButtonTable" ;
            ButtonTable.RowCount =  1 ;
            ButtonTable.RowStyles.Add( new RowStyle( SizeType.Percent, 100F ) );
            ButtonTable.Size =  new System.Drawing.Size( 984, 31 ) ;
            ButtonTable.TabIndex =  6 ;
            ButtonTable.UseWaitCursor =  true ;
            // 
            // CloseButtonTable
            // 
            CloseButtonTable.ColumnCount =  4 ;
            CloseButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            CloseButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            CloseButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 82F ) );
            CloseButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 11F ) );
            CloseButtonTable.Controls.Add( MenuButton, 2, 0 );
            CloseButtonTable.Controls.Add( CloseButton, 1, 0 );
            CloseButtonTable.Controls.Add( BackButton, 0, 0 );
            CloseButtonTable.Dock =  DockStyle.Fill ;
            CloseButtonTable.GrowStyle =  TableLayoutPanelGrowStyle.FixedSize ;
            CloseButtonTable.Location =  new System.Drawing.Point( 1042, 705 ) ;
            CloseButtonTable.Name =  "CloseButtonTable" ;
            CloseButtonTable.RowCount =  1 ;
            CloseButtonTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            CloseButtonTable.Size =  new System.Drawing.Size( 293, 31 ) ;
            CloseButtonTable.TabIndex =  8 ;
            CloseButtonTable.UseWaitCursor =  true ;
            // 
            // MenuButton
            // 
            MenuButton.BindingSource =  null ;
            MenuButton.DataFilter =  null ;
            MenuButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            MenuButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            MenuButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            MenuButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            MenuButton.ForeColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            MenuButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            MenuButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            MenuButton.HoverText =  null ;
            MenuButton.HoverTextColor =  System.Drawing.Color.White ;
            MenuButton.IsDerivedStyle =  true ;
            MenuButton.Location =  new System.Drawing.Point( 203, 3 ) ;
            MenuButton.Name =  "MenuButton" ;
            MenuButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            MenuButton.NormalColor =  System.Drawing.Color.Transparent ;
            MenuButton.NormalTextColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            MenuButton.Padding =  new Padding( 1 ) ;
            MenuButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            MenuButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            MenuButton.PressTextColor =  System.Drawing.Color.White ;
            MenuButton.Size =  new System.Drawing.Size( 75, 25 ) ;
            MenuButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            MenuButton.StyleManager =  null ;
            MenuButton.TabIndex =  5 ;
            MenuButton.Text =  "Home" ;
            MenuButton.ThemeAuthor =  "Terry D. Eppler" ;
            MenuButton.ThemeName =  "Budget Execution" ;
            MenuButton.ToolTip =  null ;
            MenuButton.UseWaitCursor =  true ;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource =  null ;
            CloseButton.DataFilter =  null ;
            CloseButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            CloseButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CloseButton.ForeColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            CloseButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            CloseButton.HoverText =  null ;
            CloseButton.HoverTextColor =  System.Drawing.Color.White ;
            CloseButton.IsDerivedStyle =  true ;
            CloseButton.Location =  new System.Drawing.Point( 103, 3 ) ;
            CloseButton.Name =  "CloseButton" ;
            CloseButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalTextColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            CloseButton.Padding =  new Padding( 1 ) ;
            CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressTextColor =  System.Drawing.Color.White ;
            CloseButton.Size =  new System.Drawing.Size( 75, 25 ) ;
            CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            CloseButton.StyleManager =  null ;
            CloseButton.TabIndex =  3 ;
            CloseButton.Text =  "Close" ;
            CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
            CloseButton.ThemeName =  "Budget Execution" ;
            CloseButton.ToolTip =  null ;
            CloseButton.UseWaitCursor =  true ;
            // 
            // BackButton
            // 
            BackButton.BindingSource =  null ;
            BackButton.DataFilter =  null ;
            BackButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            BackButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            BackButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            BackButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            BackButton.ForeColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            BackButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            BackButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            BackButton.HoverText =  null ;
            BackButton.HoverTextColor =  System.Drawing.Color.White ;
            BackButton.IsDerivedStyle =  true ;
            BackButton.Location =  new System.Drawing.Point( 3, 3 ) ;
            BackButton.Name =  "BackButton" ;
            BackButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            BackButton.NormalColor =  System.Drawing.Color.Transparent ;
            BackButton.NormalTextColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            BackButton.Padding =  new Padding( 1 ) ;
            BackButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            BackButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            BackButton.PressTextColor =  System.Drawing.Color.White ;
            BackButton.Size =  new System.Drawing.Size( 75, 25 ) ;
            BackButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            BackButton.StyleManager =  null ;
            BackButton.TabIndex =  4 ;
            BackButton.Text =  "Back" ;
            BackButton.ThemeAuthor =  "Terry D. Eppler" ;
            BackButton.ThemeName =  "Budget Execution" ;
            BackButton.ToolTip =  null ;
            BackButton.UseWaitCursor =  true ;
            // 
            // ListBoxTable
            // 
            ListBoxTable.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ListBoxTable.CaptionStyle =  CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle ;
            ListBoxTable.CaptionText =  "Documentation" ;
            ListBoxTable.ColumnCount =  1 ;
            ListBoxTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            ListBoxTable.Controls.Add( ListBoxPanel, 0, 1 );
            ListBoxTable.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ListBoxTable.ForeColor =  System.Drawing.Color.DarkGray ;
            ListBoxTable.Location =  new System.Drawing.Point( 1042, 36 ) ;
            ListBoxTable.Name =  "ListBoxTable" ;
            ListBoxTable.RowCount =  2 ;
            ListBoxTable.RowStyles.Add( new RowStyle( SizeType.Percent, 1.23647606F ) );
            ListBoxTable.RowStyles.Add( new RowStyle( SizeType.Percent, 98.76353F ) );
            ListBoxTable.Size =  new System.Drawing.Size( 293, 663 ) ;
            ListBoxTable.TabIndex =  9 ;
            ListBoxTable.UseWaitCursor =  true ;
            // 
            // ListBoxPanel
            // 
            ListBoxPanel.BackColor =  System.Drawing.Color.Transparent ;
            ListBoxPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ListBoxPanel.BindingSource =  null ;
            ListBoxPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            ListBoxPanel.BorderThickness =  1 ;
            ListBoxPanel.Children =  null ;
            ListBoxPanel.Controls.Add( FlowPanel );
            ListBoxPanel.DataFilter =  null ;
            ListBoxPanel.Dock =  DockStyle.Fill ;
            ListBoxPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ListBoxPanel.ForeColor =  System.Drawing.Color.Transparent ;
            ListBoxPanel.HoverText =  null ;
            ListBoxPanel.IsDerivedStyle =  true ;
            ListBoxPanel.Location =  new System.Drawing.Point( 3, 27 ) ;
            ListBoxPanel.Name =  "ListBoxPanel" ;
            ListBoxPanel.Padding =  new Padding( 1 ) ;
            ListBoxPanel.Size =  new System.Drawing.Size( 287, 633 ) ;
            ListBoxPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            ListBoxPanel.StyleManager =  null ;
            ListBoxPanel.TabIndex =  3 ;
            ListBoxPanel.ThemeAuthor =  "Terry D. Eppler" ;
            ListBoxPanel.ThemeName =  "Budget Execution" ;
            ListBoxPanel.ToolTip =  null ;
            ListBoxPanel.UseWaitCursor =  true ;
            // 
            // FlowPanel
            // 
            FlowPanel.Dock =  DockStyle.Fill ;
            FlowPanel.FlowDirection =  FlowDirection.TopDown ;
            FlowPanel.Location =  new System.Drawing.Point( 1, 1 ) ;
            FlowPanel.Name =  "FlowPanel" ;
            FlowPanel.Size =  new System.Drawing.Size( 285, 631 ) ;
            FlowPanel.TabIndex =  0 ;
            FlowPanel.WrapContents =  false ;
            // 
            // PdfForm
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   15  ,   15  ,   15   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            BorderThickness =  2 ;
            CaptionAlign =  HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionBarHeight =  5 ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 1338, 739 ) ;
            Controls.Add( PdfTable );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            FormBorderStyle =  FormBorderStyle.FixedSingle ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 1350, 750 ) ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            MinimumSize =  new System.Drawing.Size( 1350, 750 ) ;
            Name =  "PdfForm" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            ShowMouseOver =  true ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "PDF Document" ;
            UseWaitCursor =  true ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            PdfTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            DocumentPanel.ResumeLayout( false );
            CloseButtonTable.ResumeLayout( false );
            ListBoxTable.ResumeLayout( false );
            ListBoxPanel.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public BindingSource BindingSource;
        public SmallTip ToolTip;
        public Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl DocViewer;
        private TableLayoutPanel PdfTable;
        private Layout DocumentPanel;
        public PictureBox PictureBox;
        public TableLayoutPanel ButtonTable;
        public Label HeaderLabel;
        public Button CloseButton;
        private TableLayoutPanel CloseButtonTable;
        public Layout ListBoxPanel;
        public Button MenuButton;
        public Button BackButton;
        public HeaderPanel ListBoxTable;
        private ListView listView1;
        public FlowLayoutPanel FlowPanel;
    }
}
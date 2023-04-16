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
            var messageBoxSettings2 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings( );
            var pdfViewerPrinterSettings2 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( PdfForm ) );
            var textSearchSettings2 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings( );
            ToolTip =  new SmallTip( ) ;
            BindingSource =  new BindingSource( components ) ;
            toolSeparator1 =  new ToolSeparator( ) ;
            ToolSeparator =  new ToolSeparator( ) ;
            toolSeparator3 =  new ToolSeparator( ) ;
            DocViewer =  new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl( ) ;
            PdfTable =  new TableLayoutPanel( ) ;
            ListTable =  new TableLayoutPanel( ) ;
            First =  new HeaderPanel( ) ;
            ListBoxPanel =  new Layout( ) ;
            ListBox =  new ListBox( ) ;
            ComboBox =  new ComboBox( ) ;
            ButtonPanel =  new Layout( ) ;
            CloseButton =  new Button( ) ;
            DocumentPanel =  new Layout( ) ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            PdfTable.SuspendLayout( );
            ListTable.SuspendLayout( );
            First.SuspendLayout( );
            ListBoxPanel.SuspendLayout( );
            ButtonPanel.SuspendLayout( );
            DocumentPanel.SuspendLayout( );
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
            DocViewer.Location =  new System.Drawing.Point( 1, 1 ) ;
            messageBoxSettings2.EnableNotification =  true ;
            DocViewer.MessageBoxSettings =  messageBoxSettings2 ;
            DocViewer.MinimumZoomPercentage =  50 ;
            DocViewer.Name =  "DocViewer" ;
            DocViewer.PageBorderThickness =  1 ;
            pdfViewerPrinterSettings2.Copies =  1 ;
            pdfViewerPrinterSettings2.PageOrientation =  Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto ;
            pdfViewerPrinterSettings2.PageSize =  Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize ;
            pdfViewerPrinterSettings2.PrintLocation =  (System.Drawing.PointF) resources.GetObject( "pdfViewerPrinterSettings2.PrintLocation" )  ;
            pdfViewerPrinterSettings2.ShowPrintStatusDialog =  true ;
            DocViewer.PrinterSettings =  pdfViewerPrinterSettings2 ;
            DocViewer.ReferencePath =  null ;
            DocViewer.ScrollDisplacementValue =  0 ;
            DocViewer.ShowHorizontalScrollBar =  true ;
            DocViewer.ShowToolBar =  true ;
            DocViewer.ShowVerticalScrollBar =  true ;
            DocViewer.Size =  new System.Drawing.Size( 1010, 731 ) ;
            DocViewer.SpaceBetweenPages =  8 ;
            DocViewer.TabIndex =  2 ;
            DocViewer.Text =  "pdfViewerControl1" ;
            textSearchSettings2.CurrentInstanceColor =  System.Drawing.Color.FromArgb(   127  ,   255  ,   171  ,   64   ) ;
            textSearchSettings2.HighlightAllInstance =  true ;
            textSearchSettings2.OtherInstanceColor =  System.Drawing.Color.FromArgb(   127  ,   254  ,   255  ,   0   ) ;
            DocViewer.TextSearchSettings =  textSearchSettings2 ;
            DocViewer.ThemeName =  "Office2016Black" ;
            DocViewer.UseWaitCursor =  true ;
            DocViewer.VerticalScrollOffset =  0 ;
            DocViewer.VisualStyle =  Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Black ;
            DocViewer.ZoomMode =  Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitWidth ;
            // 
            // PdfTable
            // 
            PdfTable.ColumnCount =  3 ;
            PdfTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 3.19248819F ) );
            PdfTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 96.80751F ) );
            PdfTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 286F ) );
            PdfTable.Controls.Add( ListTable, 2, 0 );
            PdfTable.Controls.Add( DocumentPanel, 1, 0 );
            PdfTable.Dock =  DockStyle.Fill ;
            PdfTable.Location =  new System.Drawing.Point( 0, 0 ) ;
            PdfTable.Name =  "PdfTable" ;
            PdfTable.RowCount =  1 ;
            PdfTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            PdfTable.Size =  new System.Drawing.Size( 1338, 739 ) ;
            PdfTable.TabIndex =  3 ;
            PdfTable.UseWaitCursor =  true ;
            // 
            // ListTable
            // 
            ListTable.ColumnCount =  3 ;
            ListTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            ListTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 251F ) );
            ListTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 8F ) );
            ListTable.Controls.Add( First, 1, 0 );
            ListTable.Controls.Add( ButtonPanel, 1, 1 );
            ListTable.Dock =  DockStyle.Fill ;
            ListTable.Location =  new System.Drawing.Point( 1054, 3 ) ;
            ListTable.Name =  "ListTable" ;
            ListTable.RowCount =  2 ;
            ListTable.RowStyles.Add( new RowStyle( SizeType.Percent, 100F ) );
            ListTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            ListTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            ListTable.Size =  new System.Drawing.Size( 281, 733 ) ;
            ListTable.TabIndex =  3 ;
            ListTable.UseWaitCursor =  true ;
            // 
            // First
            // 
            First.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            First.CaptionStyle =  CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle ;
            First.CaptionText =  "Documents" ;
            First.ColumnCount =  1 ;
            First.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            First.Controls.Add( ListBoxPanel, 0, 1 );
            First.Controls.Add( ComboBox, 0, 0 );
            First.Dock =  DockStyle.Fill ;
            First.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            First.ForeColor =  System.Drawing.Color.DarkGray ;
            First.Location =  new System.Drawing.Point( 25, 3 ) ;
            First.Name =  "First" ;
            First.RowCount =  2 ;
            First.RowStyles.Add( new RowStyle( SizeType.Percent, 5.748865F ) );
            First.RowStyles.Add( new RowStyle( SizeType.Percent, 94.25114F ) );
            First.Size =  new System.Drawing.Size( 245, 677 ) ;
            First.TabIndex =  0 ;
            First.UseWaitCursor =  true ;
            // 
            // ListBoxPanel
            // 
            ListBoxPanel.BackColor =  System.Drawing.Color.Transparent ;
            ListBoxPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ListBoxPanel.BindingSource =  null ;
            ListBoxPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            ListBoxPanel.BorderThickness =  1 ;
            ListBoxPanel.Children =  null ;
            ListBoxPanel.Controls.Add( ListBox );
            ListBoxPanel.DataFilter =  null ;
            ListBoxPanel.Dock =  DockStyle.Fill ;
            ListBoxPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ListBoxPanel.ForeColor =  System.Drawing.Color.Transparent ;
            ListBoxPanel.HoverText =  null ;
            ListBoxPanel.IsDerivedStyle =  true ;
            ListBoxPanel.Location =  new System.Drawing.Point( 3, 56 ) ;
            ListBoxPanel.Name =  "ListBoxPanel" ;
            ListBoxPanel.Padding =  new Padding( 1 ) ;
            ListBoxPanel.Size =  new System.Drawing.Size( 239, 618 ) ;
            ListBoxPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            ListBoxPanel.StyleManager =  null ;
            ListBoxPanel.TabIndex =  0 ;
            ListBoxPanel.ThemeAuthor =  "Terry D. Eppler" ;
            ListBoxPanel.ThemeName =  "Budget Execution" ;
            ListBoxPanel.ToolTip =  null ;
            ListBoxPanel.UseWaitCursor =  true ;
            // 
            // ListBox
            // 
            ListBox.BackColor =  System.Drawing.Color.FromArgb(   40  ,   40  ,   40   ) ;
            ListBox.BindingSource =  null ;
            ListBox.BorderColor =  System.Drawing.Color.FromArgb(   55  ,   55  ,   55   ) ;
            ListBox.DataFilter =  null ;
            ListBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ListBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ListBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ListBox.HoveredItemBackColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            ListBox.HoveredItemColor =  System.Drawing.Color.White ;
            ListBox.HoverText =  null ;
            ListBox.IsDerivedStyle =  true ;
            ListBox.ItemHeight =  28 ;
            ListBox.Location =  new System.Drawing.Point( 22, 18 ) ;
            ListBox.Margin =  new Padding( 1 ) ;
            ListBox.MultiSelect =  true ;
            ListBox.Name =  "ListBox" ;
            ListBox.Padding =  new Padding( 1 ) ;
            ListBox.SelectedIndex =  -1 ;
            ListBox.SelectedItem =  null ;
            ListBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ListBox.SelectedItemColor =  System.Drawing.Color.White ;
            ListBox.SelectedText =  null ;
            ListBox.SelectedValue =  null ;
            ListBox.ShowBorder =  false ;
            ListBox.ShowScrollBar =  false ;
            ListBox.Size =  new System.Drawing.Size( 196, 582 ) ;
            ListBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            ListBox.StyleManager =  null ;
            ListBox.TabIndex =  0 ;
            ListBox.ThemeAuthor =  "Terry D. Eppler" ;
            ListBox.ThemeName =  "Budget Execution" ;
            ListBox.ToolTip =  null ;
            ListBox.UseWaitCursor =  true ;
            // 
            // ComboBox
            // 
            ComboBox.AllowDrop =  true ;
            ComboBox.ArrowColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ComboBox.BackColor =  System.Drawing.Color.Transparent ;
            ComboBox.BackgroundColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
            ComboBox.BindingSource =  null ;
            ComboBox.BorderColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
            ComboBox.CausesValidation =  false ;
            ComboBox.DataFilter =  null ;
            ComboBox.DisabledBackColor =  System.Drawing.Color.Transparent ;
            ComboBox.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            ComboBox.DisabledForeColor =  System.Drawing.Color.Transparent ;
            ComboBox.Dock =  DockStyle.Fill ;
            ComboBox.DrawMode =  DrawMode.OwnerDrawFixed ;
            ComboBox.DropDownStyle =  ComboBoxStyle.DropDownList ;
            ComboBox.FlatStyle =  FlatStyle.Flat ;
            ComboBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ComboBox.FormattingEnabled =  true ;
            ComboBox.HoverText =  null ;
            ComboBox.IsDerivedStyle =  true ;
            ComboBox.ItemHeight =  24 ;
            ComboBox.Location =  new System.Drawing.Point( 3, 19 ) ;
            ComboBox.Name =  "ComboBox" ;
            ComboBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ComboBox.SelectedItemForeColor =  System.Drawing.Color.White ;
            ComboBox.Size =  new System.Drawing.Size( 239, 30 ) ;
            ComboBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            ComboBox.StyleManager =  null ;
            ComboBox.TabIndex =  1 ;
            ComboBox.ThemeAuthor =  "Terry D. Eppler" ;
            ComboBox.ThemeName =  "Budget Execution" ;
            ComboBox.ToolTip =  null ;
            ComboBox.UseWaitCursor =  true ;
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor =  System.Drawing.Color.Transparent ;
            ButtonPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ButtonPanel.BindingSource =  null ;
            ButtonPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            ButtonPanel.BorderThickness =  1 ;
            ButtonPanel.Children =  null ;
            ButtonPanel.Controls.Add( CloseButton );
            ButtonPanel.DataFilter =  null ;
            ButtonPanel.Dock =  DockStyle.Fill ;
            ButtonPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ButtonPanel.ForeColor =  System.Drawing.Color.Transparent ;
            ButtonPanel.HoverText =  null ;
            ButtonPanel.IsDerivedStyle =  true ;
            ButtonPanel.Location =  new System.Drawing.Point( 25, 686 ) ;
            ButtonPanel.Name =  "ButtonPanel" ;
            ButtonPanel.Padding =  new Padding( 1 ) ;
            ButtonPanel.Size =  new System.Drawing.Size( 245, 44 ) ;
            ButtonPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            ButtonPanel.StyleManager =  null ;
            ButtonPanel.TabIndex =  2 ;
            ButtonPanel.ThemeAuthor =  "Terry D. Eppler" ;
            ButtonPanel.ThemeName =  "Budget Execution" ;
            ButtonPanel.ToolTip =  null ;
            ButtonPanel.UseWaitCursor =  true ;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource =  BindingSource ;
            CloseButton.DataFilter =  null ;
            CloseButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            CloseButton.Dock =  DockStyle.Fill ;
            CloseButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CloseButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            CloseButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            CloseButton.HoverText =  null ;
            CloseButton.HoverTextColor =  System.Drawing.Color.White ;
            CloseButton.IsDerivedStyle =  true ;
            CloseButton.Location =  new System.Drawing.Point( 1, 1 ) ;
            CloseButton.Name =  "CloseButton" ;
            CloseButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.Padding =  new Padding( 1 ) ;
            CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressTextColor =  System.Drawing.Color.White ;
            CloseButton.Size =  new System.Drawing.Size( 243, 42 ) ;
            CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            CloseButton.StyleManager =  null ;
            CloseButton.TabIndex =  0 ;
            CloseButton.Text =  "Close" ;
            CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
            CloseButton.ThemeName =  "Budget Execution" ;
            CloseButton.ToolTip =  null ;
            CloseButton.UseWaitCursor =  true ;
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
            DocumentPanel.Location =  new System.Drawing.Point( 36, 3 ) ;
            DocumentPanel.Name =  "DocumentPanel" ;
            DocumentPanel.Padding =  new Padding( 1 ) ;
            DocumentPanel.Size =  new System.Drawing.Size( 1012, 733 ) ;
            DocumentPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            DocumentPanel.StyleManager =  null ;
            DocumentPanel.TabIndex =  4 ;
            DocumentPanel.ThemeAuthor =  "Terry D. Eppler" ;
            DocumentPanel.ThemeName =  "Budget Execution" ;
            DocumentPanel.ToolTip =  null ;
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
            ListTable.ResumeLayout( false );
            First.ResumeLayout( false );
            ListBoxPanel.ResumeLayout( false );
            ButtonPanel.ResumeLayout( false );
            DocumentPanel.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public ToolSeparator ToolSeparator;
        public ToolSeparator toolSeparator3;
        public BindingSource BindingSource;
        public SmallTip ToolTip;
        public Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl DocViewer;
        private ToolSeparator toolSeparator1;
        private TableLayoutPanel PdfTable;
        private TableLayoutPanel ListTable;
        private HeaderPanel First;
        private Layout ListBoxPanel;
        public ListBox ListBox;
        public ComboBox ComboBox;
        public Button CloseButton;
        private Layout DocumentPanel;
        public Layout ButtonPanel;
    }
}
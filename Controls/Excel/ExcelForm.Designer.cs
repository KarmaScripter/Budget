namespace BudgetExecution
{


    partial class ExcelForm
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
            var spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste( );
            var formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( ExcelForm ) );
            Ribbon =  new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon( ) ;
            Spreadsheet =  new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet( ) ;
            BindingSource =  new System.Windows.Forms.BindingSource( components ) ;
            ToolStrip =  new ToolStrip( ) ;
            HomeButton =  new ToolStripButton( ) ;
            ToolTip =  new SmallTip( ) ;
            Separator1 =  new ToolSeparator( ) ;
            ToolStripTextBox =  new ToolStripTextBox( ) ;
            UploadButton =  new ToolStripButton( ) ;
            Separator8 =  new ToolSeparator( ) ;
            Separator9 =  new ToolSeparator( ) ;
            Separator10 =  new ToolSeparator( ) ;
            ChartButton =  new ToolStripButton( ) ;
            BackButton =  new ToolStripButton( ) ;
            toolSeparator2 =  new ToolSeparator( ) ;
            toolSeparator19 =  new ToolSeparator( ) ;
            ToolStripSpacer1 =  new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( ) ;
            ToolStripSpacer2 =  new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( ) ;
            Separator11 =  new ToolSeparator( ) ;
            ToolStripSpacer3 =  new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( ) ;
            ToolStripSpacer4 =  new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( ) ;
            ToolStripSpacer5 =  new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( ) ;
            ContextMenu =  new ContextMenu( ) ;
            ( (System.ComponentModel.ISupportInitialize) Ribbon  ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            ToolStrip.SuspendLayout( );
            SuspendLayout( );
            // 
            // Ribbon
            // 
            Ribbon.CaptionFont =  new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Ribbon.Dock =  Syncfusion.Windows.Forms.Tools.DockStyleEx.Top ;
            Ribbon.Font =  new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Ribbon.HideMenuButtonToolTip =  true ;
            Ribbon.LauncherStyle =  Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro ;
            Ribbon.Location =  new System.Drawing.Point( 0, 0 ) ;
            Ribbon.MenuButtonFont =  new System.Drawing.Font( "Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Ribbon.MenuButtonText =  "FILE" ;
            Ribbon.MenuButtonWidth =  56 ;
            Ribbon.MenuColor =  System.Drawing.Color.FromArgb(   54  ,   54  ,   54   ) ;
            Ribbon.Name =  "Ribbon" ;
            Ribbon.Office2013ColorScheme =  Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray ;
            Ribbon.Office2016ColorScheme =  Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black ;
            Ribbon.OfficeColorScheme =  Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black ;
            // 
            // 
            // 
            Ribbon.OfficeMenu.Name =  "OfficeMenu" ;
            Ribbon.OfficeMenu.ShowItemToolTips =  true ;
            Ribbon.OfficeMenu.Size =  new System.Drawing.Size( 12, 65 ) ;
            Ribbon.QuickPanelImageLayout =  System.Windows.Forms.PictureBoxSizeMode.StretchImage ;
            Ribbon.RibbonHeaderImage =  Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None ;
            Ribbon.RibbonStyle =  Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2010 ;
            Ribbon.ShowQuickItemsDropDownButton =  false ;
            Ribbon.ShowRibbonDisplayOptionButton =  false ;
            Ribbon.Size =  new System.Drawing.Size( 1338, 155 ) ;
            Ribbon.Spreadsheet =  Spreadsheet ;
            Ribbon.SystemText.QuickAccessDialogDropDownName =  "Start menu" ;
            Ribbon.SystemText.RenameDisplayLabelText =  "&Display Name:" ;
            Ribbon.TabIndex =  0 ;
            Ribbon.Text =  "spreadsheetRibbon1" ;
            Ribbon.ThemeName =  "Default" ;
            Ribbon.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor =  System.Drawing.Color.FromArgb(   171  ,   171  ,   171   ) ;
            Ribbon.TitleColor =  System.Drawing.Color.White ;
            Ribbon.TitleFont =  new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            // 
            // Spreadsheet
            // 
            Spreadsheet.AllowCellContextMenu =  true ;
            Spreadsheet.AllowExtendRowColumnCount =  true ;
            Spreadsheet.AllowFiltering =  false ;
            Spreadsheet.AllowFormulaRangeSelection =  true ;
            Spreadsheet.AllowTabItemContextMenu =  true ;
            Spreadsheet.AllowZooming =  true ;
            Spreadsheet.BaseThemeName =  "" ;
            spreadsheetCopyPaste1.AllowPasteOptionPopup =  true ;
            spreadsheetCopyPaste1.DefaultPasteOption =  Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste ;
            Spreadsheet.CopyPaste =  spreadsheetCopyPaste1 ;
            Spreadsheet.DefaultColumnCount =  101 ;
            Spreadsheet.DefaultRowCount =  101 ;
            Spreadsheet.DisplayAlerts =  true ;
            Spreadsheet.Dock =  System.Windows.Forms.DockStyle.Fill ;
            Spreadsheet.FileName =  "Book1" ;
            Spreadsheet.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Spreadsheet.ForeColor =  System.Drawing.Color.Black ;
            Spreadsheet.FormulaBarVisibility =  true ;
            formulaRangeSelectionController1.AllowMouseSelection =  true ;
            formulaRangeSelectionController1.AllowSelectionOnEditing =  true ;
            Spreadsheet.FormulaRangeSelectionController =  formulaRangeSelectionController1 ;
            Spreadsheet.IsCustomTabItemContextMenuEnabled =  false ;
            Spreadsheet.Location =  new System.Drawing.Point( 0, 155 ) ;
            Spreadsheet.Name =  "Spreadsheet" ;
            Spreadsheet.SelectedTabIndex =  0 ;
            Spreadsheet.SelectedTabItem =  null ;
            Spreadsheet.ShowBusyIndicator =  true ;
            Spreadsheet.Size =  new System.Drawing.Size( 1338, 512 ) ;
            Spreadsheet.TabIndex =  1 ;
            Spreadsheet.TabItemContextMenu =  null ;
            Spreadsheet.Text =  "Spreadsheet" ;
            Spreadsheet.ThemeName =  "Default" ;
            // 
            // ToolStrip
            // 
            ToolStrip.AddButton =  null ;
            ToolStrip.AddColumnButton =  null ;
            ToolStrip.AddTableButton =  null ;
            ToolStrip.BackColor =  System.Drawing.Color.Transparent ;
            ToolStrip.BindingSource =  BindingSource ;
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
            ToolStrip.Dock =  System.Windows.Forms.DockStyle.Bottom ;
            ToolStrip.DropDown =  null ;
            ToolStrip.EditButton =  null ;
            ToolStrip.EditColumnButton =  null ;
            ToolStrip.EditRecordButton =  null ;
            ToolStrip.EditSqlButton =  null ;
            ToolStrip.ExcelButton =  null ;
            ToolStrip.FilterDataButton =  null ;
            ToolStrip.FirstButton =  null ;
            ToolStrip.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ToolStrip.ForeColor =  System.Drawing.Color.MidnightBlue ;
            ToolStrip.GripStyle =  System.Windows.Forms.ToolStripGripStyle.Hidden ;
            ToolStrip.HomeButton =  HomeButton ;
            ToolStrip.Image =  null ;
            ToolStrip.ImageDirectory =  null ;
            ToolStrip.ImageSize =  new System.Drawing.Size( 16, 16 ) ;
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { ToolStripSpacer1, Separator1, ToolStripTextBox, this.Separator2, ToolStripSpacer2, Separator11, this.LookupButton, Separator3, UploadButton, this.Separator5, ChartButton, this.Separator4, ToolStripSpacer3, ToolStripSpacer4, ToolStripSpacer5, Separator8, BackButton, Separator9, HomeButton, Separator10 } );
            ToolStrip.LastButton =  null ;
            ToolStrip.LauncherStyle =  Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12 ;
            ToolStrip.Location =  new System.Drawing.Point( 0, 667 ) ;
            ToolStrip.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            ToolStrip.Name =  "ToolStrip" ;
            ToolStrip.NextButton =  null ;
            ToolStrip.Office12Mode =  false ;
            ToolStrip.OfficeColorScheme =  Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue ;
            ToolStrip.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ToolStrip.PreviousButton =  null ;
            ToolStrip.ProgressBar =  null ;
            ToolStrip.RefreshButton =  null ;
            ToolStrip.SaveButton =  null ;
            ToolStrip.SearchCriteriaLabel =  null ;
            ToolStrip.SearchEngineLabel =  null ;
            ToolStrip.Separators =  null ;
            ToolStrip.ShowCaption =  true ;
            ToolStrip.ShowLauncher =  true ;
            ToolStrip.Size =  new System.Drawing.Size( 1338, 46 ) ;
            ToolStrip.TabIndex =  2 ;
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
            ToolStrip.VisualStyle =  Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray ;
            // 
            // HomeButton
            // 
            HomeButton.AutoToolTip =  false ;
            HomeButton.BackColor =  System.Drawing.Color.Transparent ;
            HomeButton.BindingSource =  BindingSource ;
            HomeButton.DataFilter =  null ;
            HomeButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            HomeButton.Field =  Field.AccountCode ;
            HomeButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            HomeButton.ForeColor =  System.Drawing.Color.LightGray ;
            HomeButton.HoverText =  "Main Menu" ;
            HomeButton.Image =  Properties.Resources.HomeButton ;
            HomeButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            HomeButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            HomeButton.Name =  "HomeButton" ;
            HomeButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            HomeButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            HomeButton.Text =  "toolStripButton10" ;
            HomeButton.ToolTip =  ToolTip ;
            HomeButton.ToolType =  ToolType.HomeButton ;
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
            ToolTip.TipIcon =  System.Windows.Forms.ToolTipIcon.Info ;
            ToolTip.TipText =  null ;
            ToolTip.TipTitle =  null ;
            // 
            // Separator1
            // 
            Separator1.ForeColor =  System.Drawing.Color.Black ;
            Separator1.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator1.Name =  "Separator1" ;
            Separator1.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator1.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // ToolStripTextBox
            // 
            ToolStripTextBox.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ToolStripTextBox.BindingSource =  null ;
            ToolStripTextBox.Field =  Field.AccountCode ;
            ToolStripTextBox.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ToolStripTextBox.ForeColor =  System.Drawing.SystemColors.WindowText ;
            ToolStripTextBox.HoverText =  "" ;
            ToolStripTextBox.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            ToolStripTextBox.Name =  "ToolStripTextBox" ;
            ToolStripTextBox.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ToolStripTextBox.Size =  new System.Drawing.Size( 234, 28 ) ;
            ToolStripTextBox.Tag =  "" ;
            ToolStripTextBox.ToolTip =  null ;
            // 
            // Separator2
            // 
            this.Separator2.ForeColor =  System.Drawing.Color.Black ;
            this.Separator2.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            this.Separator2.Name =  "Separator2" ;
            this.Separator2.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            this.Separator2.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // Separator3
            // 
            Separator3.ForeColor =  System.Drawing.Color.Black ;
            Separator3.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator3.Name =  "Separator3" ;
            Separator3.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator3.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // LookupButton
            // 
            this.LookupButton.AutoToolTip =  false ;
            this.LookupButton.BackColor =  System.Drawing.Color.Transparent ;
            this.LookupButton.BindingSource =  BindingSource ;
            this.LookupButton.DataFilter =  null ;
            this.LookupButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            this.LookupButton.Field =  Field.AccountCode ;
            this.LookupButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            this.LookupButton.ForeColor =  System.Drawing.Color.LightGray ;
            this.LookupButton.HoverText =  "Open Query Dialog" ;
            this.LookupButton.Image =  Properties.Resources.DataSearchButton ;
            this.LookupButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            this.LookupButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            this.LookupButton.Name =  "LookupButton" ;
            this.LookupButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            this.LookupButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            this.LookupButton.Text =  "toolStripButton1" ;
            this.LookupButton.ToolTip =  ToolTip ;
            this.LookupButton.ToolType =  ToolType.LookupButton ;
            // 
            // Separator4
            // 
            this.Separator4.ForeColor =  System.Drawing.Color.Black ;
            this.Separator4.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            this.Separator4.Name =  "Separator4" ;
            this.Separator4.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            this.Separator4.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // Separator5
            // 
            this.Separator5.ForeColor =  System.Drawing.Color.Black ;
            this.Separator5.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            this.Separator5.Name =  "Separator5" ;
            this.Separator5.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            this.Separator5.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // UploadButton
            // 
            UploadButton.AutoToolTip =  false ;
            UploadButton.BackColor =  System.Drawing.Color.Transparent ;
            UploadButton.BindingSource =  BindingSource ;
            UploadButton.DataFilter =  null ;
            UploadButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            UploadButton.Field =  Field.AccountCode ;
            UploadButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            UploadButton.ForeColor =  System.Drawing.Color.LightGray ;
            UploadButton.HoverText =  "Excel Upload" ;
            UploadButton.Image =  Properties.Resources.UploadButton ;
            UploadButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            UploadButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            UploadButton.Name =  "UploadButton" ;
            UploadButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            UploadButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            UploadButton.Text =  "toolStripButton2" ;
            UploadButton.ToolTip =  ToolTip ;
            UploadButton.ToolType =  ToolType.UploadButton ;
            // 
            // Separator8
            // 
            Separator8.ForeColor =  System.Drawing.Color.Black ;
            Separator8.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator8.Name =  "Separator8" ;
            Separator8.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator8.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // Separator9
            // 
            Separator9.ForeColor =  System.Drawing.Color.Black ;
            Separator9.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator9.Name =  "Separator9" ;
            Separator9.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator9.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // Separator10
            // 
            Separator10.ForeColor =  System.Drawing.Color.Black ;
            Separator10.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator10.Name =  "Separator10" ;
            Separator10.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator10.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // ChartButton
            // 
            ChartButton.AutoToolTip =  false ;
            ChartButton.BackColor =  System.Drawing.Color.Transparent ;
            ChartButton.BindingSource =  BindingSource ;
            ChartButton.DataFilter =  null ;
            ChartButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            ChartButton.Field =  Field.AccountCode ;
            ChartButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ChartButton.ForeColor =  System.Drawing.Color.LightGray ;
            ChartButton.HoverText =  "Visualizations" ;
            ChartButton.Image =  Properties.Resources.ChartButton ;
            ChartButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            ChartButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            ChartButton.Name =  "ChartButton" ;
            ChartButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ChartButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            ChartButton.Text =  "toolStripButton7" ;
            ChartButton.ToolTip =  ToolTip ;
            ChartButton.ToolType =  ToolType.ChartButton ;
            // 
            // BackButton
            // 
            BackButton.AutoToolTip =  false ;
            BackButton.BackColor =  System.Drawing.Color.Transparent ;
            BackButton.BindingSource =  BindingSource ;
            BackButton.DataFilter =  null ;
            BackButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            BackButton.Field =  Field.AccountCode ;
            BackButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            BackButton.ForeColor =  System.Drawing.Color.LightGray ;
            BackButton.HoverText =  "Go Back" ;
            BackButton.Image =  Properties.Resources.BackButton ;
            BackButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            BackButton.Margin =  new System.Windows.Forms.Padding( 3 ) ;
            BackButton.Name =  "BackButton" ;
            BackButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            BackButton.Size =  new System.Drawing.Size( 23, 24 ) ;
            BackButton.Text =  "toolStripButton1" ;
            BackButton.ToolTip =  null ;
            BackButton.ToolType =  ToolType.BackButton ;
            // 
            // toolSeparator2
            // 
            toolSeparator2.ForeColor =  System.Drawing.Color.Black ;
            toolSeparator2.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            toolSeparator2.Name =  "toolSeparator2" ;
            toolSeparator2.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            toolSeparator2.Size =  new System.Drawing.Size( 6, 32 ) ;
            // 
            // toolSeparator19
            // 
            toolSeparator19.ForeColor =  System.Drawing.Color.Black ;
            toolSeparator19.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            toolSeparator19.Name =  "toolSeparator19" ;
            toolSeparator19.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            toolSeparator19.Size =  new System.Drawing.Size( 6, 30 ) ;
            // 
            // ToolStripSpacer1
            // 
            ToolStripSpacer1.BackColor =  System.Drawing.Color.Transparent ;
            ToolStripSpacer1.ForeColor =  System.Drawing.Color.Transparent ;
            ToolStripSpacer1.Name =  "ToolStripSpacer1" ;
            ToolStripSpacer1.Size =  new System.Drawing.Size( 106, 27 ) ;
            ToolStripSpacer1.Text =  "toolStripLabelExt1" ;
            // 
            // ToolStripSpacer2
            // 
            ToolStripSpacer2.BackColor =  System.Drawing.Color.Transparent ;
            ToolStripSpacer2.ForeColor =  System.Drawing.Color.Transparent ;
            ToolStripSpacer2.Name =  "ToolStripSpacer2" ;
            ToolStripSpacer2.Size =  new System.Drawing.Size( 88, 27 ) ;
            ToolStripSpacer2.Text =  "this is a spacer" ;
            // 
            // Separator11
            // 
            Separator11.ForeColor =  System.Drawing.Color.Black ;
            Separator11.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator11.Name =  "Separator11" ;
            Separator11.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator11.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // ToolStripSpacer3
            // 
            ToolStripSpacer3.BackColor =  System.Drawing.Color.Transparent ;
            ToolStripSpacer3.ForeColor =  System.Drawing.Color.Transparent ;
            ToolStripSpacer3.Name =  "ToolStripSpacer3" ;
            ToolStripSpacer3.Size =  new System.Drawing.Size( 91, 27 ) ;
            ToolStripSpacer3.Text =  "this is  a spacer" ;
            // 
            // ToolStripSpacer4
            // 
            ToolStripSpacer4.BackColor =  System.Drawing.Color.Transparent ;
            ToolStripSpacer4.ForeColor =  System.Drawing.Color.Transparent ;
            ToolStripSpacer4.Name =  "ToolStripSpacer4" ;
            ToolStripSpacer4.Size =  new System.Drawing.Size( 88, 27 ) ;
            ToolStripSpacer4.Text =  "this is a spacer" ;
            // 
            // ToolStripSpacer5
            // 
            ToolStripSpacer5.BackColor =  System.Drawing.Color.Transparent ;
            ToolStripSpacer5.ForeColor =  System.Drawing.Color.Transparent ;
            ToolStripSpacer5.Name =  "ToolStripSpacer5" ;
            ToolStripSpacer5.Size =  new System.Drawing.Size( 88, 27 ) ;
            ToolStripSpacer5.Text =  "this is a spacer" ;
            // 
            // ContextMenu
            // 
            ContextMenu.AutoSize =  false ;
            ContextMenu.BackColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
            ContextMenu.ForeColor =  System.Drawing.Color.White ;
            ContextMenu.IsDerivedStyle =  false ;
            ContextMenu.Name =  "ContextMenu" ;
            ContextMenu.RenderMode =  System.Windows.Forms.ToolStripRenderMode.System ;
            ContextMenu.Size =  new System.Drawing.Size( 156, 264 ) ;
            ContextMenu.Style =  MetroSet_UI.Enums.Style.Custom ;
            ContextMenu.StyleManager =  null ;
            ContextMenu.ThemeAuthor =  "Terry D. Eppler" ;
            ContextMenu.ThemeName =  "Budget Execution" ;
            // 
            // ExcelForm
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionAlign =  System.Windows.Forms.HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 1338, 713 ) ;
            Controls.Add( Spreadsheet );
            Controls.Add( ToolStrip );
            Controls.Add( Ribbon );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            Name =  "ExcelForm" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            ShowMouseOver =  true ;
            StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen ;
            Text =  "Excel Document" ;
            ( (System.ComponentModel.ISupportInitialize) Ribbon  ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        public Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon Ribbon;
        public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet Spreadsheet;
        public System.Windows.Forms.BindingSource BindingSource;
        public ToolStripTextBox ToolStripTextBox;
        public ToolStripLabel Label;
        public ToolStripDropDown DropDown;
        public ToolSeparator Separator12;
        public ToolSeparator Separator13;
        public ToolSeparator Separator14;
        public ToolSeparator Separator15;
        public ToolStripButton FirstButton;
        public ToolStripButton LastButton;
        public ToolStripButton AddButton;
        public ToolStripButton DeleteButton;
        public ToolStripButton EditButton;
        public ToolStripButton RefreshButton;
        public ToolStripButton SaveButton;
        public ToolStripButton ExcelButton;
        public ToolStripButton ChartButton;
        public ToolStripButton HomeButton;
        public ToolSeparator Separator16;
        public ToolStripButton PreviousButton;
        public ToolStripButton NextButton;
        public ToolSeparator Separator17;
        public ToolSeparator Separator18;
        private ToolStrip ToolStrip;
        private SmallTip ToolTip;

        private ToolSeparator toolSeparator1;
        private ToolSeparator toolSeparator2;
        private ToolSeparator toolSeparator3;
        public ToolStripButton RefreshDataButton;
        public ToolSeparator Separator8;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt ToolStripSpacer1;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt ToolStripSpacer2;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt ToolStripSpacer3;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt ToolStripSpacer4;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt ToolStripSpacer5;
        private ToolSeparator Separator11;
        public ContextMenu ContextMenu;
        public ToolStripButton UploadButton;
        private ToolSeparator toolSeparator6;
        public ToolStripButton DeleteDatabaseButton;
        private ToolSeparator toolSeparator7;
        private ToolSeparator toolSeparator8;
        private ToolSeparator toolSeparator9;
        private ToolSeparator toolSeparator10;
        private ToolSeparator Separator2;
        private ToolSeparator toolSeparator12;
        private ToolSeparator toolSeparator14;
        private ToolSeparator toolSeparator15;
        private ToolSeparator toolSeparator16;
        private ToolSeparator toolSeparator17;
        public ToolStripButton BackButton;
        private ToolSeparator toolSeparator19;
        public ToolSeparator Separator3;
        public ToolSeparator Separator1;
        public ToolSeparator Separator4;
    }
}
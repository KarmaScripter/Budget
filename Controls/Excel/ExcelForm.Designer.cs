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
            Label2 =  new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( ) ;
            Separator2 =  new ToolSeparator( ) ;
            ToolStripTextBox =  new ToolStripTextBox( ) ;
            Separator3 =  new ToolSeparator( ) ;
            Label3 =  new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( ) ;
            Separator4 =  new ToolSeparator( ) ;
            UploadButton =  new ToolStripButton( ) ;
            Separator5 =  new ToolSeparator( ) ;
            ChartButton =  new ToolStripButton( ) ;
            Separator6 =  new ToolSeparator( ) ;
            LookupButton =  new ToolStripButton( ) ;
            Separator7 =  new ToolSeparator( ) ;
            Label4 =  new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( ) ;
            Label5 =  new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( ) ;
            Label6 =  new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( ) ;
            Separator8 =  new ToolSeparator( ) ;
            BackButton =  new ToolStripButton( ) ;
            Separator9 =  new ToolSeparator( ) ;
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
            Spreadsheet.FileName =  "Book3" ;
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
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Separator1, Label2, Separator2, ToolStripTextBox, Separator3, Label3, Separator4, UploadButton, Separator5, ChartButton, Separator6, LookupButton, Separator7, Label4, Label5, Label6, Separator8, BackButton, Separator9, HomeButton } );
            ToolStrip.Label =  null ;
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
            // Label2
            // 
            Label2.BackColor =  System.Drawing.Color.Transparent ;
            Label2.ForeColor =  System.Drawing.Color.Transparent ;
            Label2.Name =  "Label2" ;
            Label2.Size =  new System.Drawing.Size( 106, 27 ) ;
            Label2.Text =  "toolStripLabelExt1" ;
            // 
            // Separator2
            // 
            Separator2.ForeColor =  System.Drawing.Color.Black ;
            Separator2.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator2.Name =  "Separator2" ;
            Separator2.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator2.Size =  new System.Drawing.Size( 6, 28 ) ;
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
            ToolStripTextBox.Size =  new System.Drawing.Size( 260, 28 ) ;
            ToolStripTextBox.Tag =  "" ;
            ToolStripTextBox.ToolTip =  null ;
            // 
            // Separator3
            // 
            Separator3.ForeColor =  System.Drawing.Color.Black ;
            Separator3.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator3.Name =  "Separator3" ;
            Separator3.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator3.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // Label3
            // 
            Label3.BackColor =  System.Drawing.Color.Transparent ;
            Label3.ForeColor =  System.Drawing.Color.Transparent ;
            Label3.Name =  "Label3" ;
            Label3.Size =  new System.Drawing.Size( 131, 27 ) ;
            Label3.Text =  "this is to provide space" ;
            // 
            // Separator4
            // 
            Separator4.ForeColor =  System.Drawing.Color.Black ;
            Separator4.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator4.Name =  "Separator4" ;
            Separator4.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator4.Size =  new System.Drawing.Size( 6, 28 ) ;
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
            // Separator5
            // 
            Separator5.ForeColor =  System.Drawing.Color.Black ;
            Separator5.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator5.Name =  "Separator5" ;
            Separator5.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator5.Size =  new System.Drawing.Size( 6, 28 ) ;
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
            // Separator6
            // 
            Separator6.ForeColor =  System.Drawing.Color.Black ;
            Separator6.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator6.Name =  "Separator6" ;
            Separator6.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator6.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // LookupButton
            // 
            LookupButton.AutoToolTip =  false ;
            LookupButton.BackColor =  System.Drawing.Color.Transparent ;
            LookupButton.BindingSource =  BindingSource ;
            LookupButton.DataFilter =  null ;
            LookupButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            LookupButton.Field =  Field.AccountCode ;
            LookupButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            LookupButton.ForeColor =  System.Drawing.Color.LightGray ;
            LookupButton.HoverText =  "Data Query" ;
            LookupButton.Image =  Properties.Resources.LookupButton ;
            LookupButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            LookupButton.Margin =  new System.Windows.Forms.Padding( 3 ) ;
            LookupButton.Name =  "LookupButton" ;
            LookupButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            LookupButton.Size =  new System.Drawing.Size( 23, 24 ) ;
            LookupButton.Text =  "toolStripButton1" ;
            LookupButton.ToolTip =  ToolTip ;
            LookupButton.ToolType =  ToolType.NS ;
            // 
            // Separator7
            // 
            Separator7.ForeColor =  System.Drawing.Color.Black ;
            Separator7.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator7.Name =  "Separator7" ;
            Separator7.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator7.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // Label4
            // 
            Label4.BackColor =  System.Drawing.Color.Transparent ;
            Label4.ForeColor =  System.Drawing.Color.Transparent ;
            Label4.Name =  "Label4" ;
            Label4.Size =  new System.Drawing.Size( 170, 27 ) ;
            Label4.Text =  "this is a label to provide space" ;
            // 
            // Label5
            // 
            Label5.BackColor =  System.Drawing.Color.Transparent ;
            Label5.ForeColor =  System.Drawing.Color.Transparent ;
            Label5.Name =  "Label5" ;
            Label5.Size =  new System.Drawing.Size( 170, 27 ) ;
            Label5.Text =  "this is a label to provide space" ;
            // 
            // Label6
            // 
            Label6.BackColor =  System.Drawing.Color.Transparent ;
            Label6.ForeColor =  System.Drawing.Color.Transparent ;
            Label6.Name =  "Label6" ;
            Label6.Size =  new System.Drawing.Size( 88, 27 ) ;
            Label6.Text =  "this is a spacer" ;
            // 
            // Separator8
            // 
            Separator8.ForeColor =  System.Drawing.Color.Black ;
            Separator8.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator8.Name =  "Separator8" ;
            Separator8.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator8.Size =  new System.Drawing.Size( 6, 28 ) ;
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
            // Separator9
            // 
            Separator9.ForeColor =  System.Drawing.Color.Black ;
            Separator9.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Separator9.Name =  "Separator9" ;
            Separator9.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Separator9.Size =  new System.Drawing.Size( 6, 28 ) ;
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
        public ToolStripDropDown DropDown;
        public ToolStripButton AddButton;
        public ToolStripButton DeleteButton;
        public ToolStripButton EditButton;
        public ToolStripButton RefreshButton;
        public ToolStripButton ChartButton;
        public ToolStripButton HomeButton;
        private ToolStrip ToolStrip;
        private SmallTip ToolTip;
        public ToolStripButton RefreshDataButton;
        public ToolSeparator Separator5;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt Label2;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt Label3;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt Label4;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt Label5;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt Label6;
        public ContextMenu ContextMenu;
        public ToolStripButton UploadButton;
        public ToolStripButton DeleteDatabaseButton;
        private ToolSeparator Separator2;
        public ToolStripButton BackButton;
        public ToolSeparator Separator3;
        public ToolSeparator Separator1;
        public ToolSeparator Separator4;
        public ToolSeparator Separator6;
        public ToolStripButton LookupButton;
        public ToolSeparator Separator7;
        public ToolSeparator Separator8;
        public ToolSeparator Separator9;
    }
}
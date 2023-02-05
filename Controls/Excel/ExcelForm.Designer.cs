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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            this.Ribbon = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.Spreadsheet = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolStrip = new BudgetExecution.ToolStrip();
            this.HomeButton = new BudgetExecution.ToolStripButton();
            this.ToolTip = new BudgetExecution.SmallTip();
            this.Label = new BudgetExecution.ToolStripLabel();
            this.toolSeparator1 = new BudgetExecution.ToolSeparator();
            this.TextBox = new BudgetExecution.ToolStripTextBox();
            this.toolSeparator2 = new BudgetExecution.ToolSeparator();
            this.toolSeparator11 = new BudgetExecution.ToolSeparator();
            this.FirstButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator14 = new BudgetExecution.ToolSeparator();
            this.PreviousButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator15 = new BudgetExecution.ToolSeparator();
            this.NextButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator16 = new BudgetExecution.ToolSeparator();
            this.LastButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator17 = new BudgetExecution.ToolSeparator();
            this.DropDown = new BudgetExecution.ToolStripDropDown();
            this.toolSeparator3 = new BudgetExecution.ToolSeparator();
            this.RefreshDataButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator4 = new BudgetExecution.ToolSeparator();
            this.TableButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator5 = new BudgetExecution.ToolSeparator();
            this.UploadButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator6 = new BudgetExecution.ToolSeparator();
            this.DeleteDatabaseButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator7 = new BudgetExecution.ToolSeparator();
            this.SaveButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator8 = new BudgetExecution.ToolSeparator();
            this.CalendarButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator9 = new BudgetExecution.ToolSeparator();
            this.CalculatorButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator10 = new BudgetExecution.ToolSeparator();
            this.ChartButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator12 = new BudgetExecution.ToolSeparator();
            this.BackButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator13 = new BudgetExecution.ToolSeparator();
            this.toolSeparator19 = new BudgetExecution.ToolSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ribbon
            // 
            this.Ribbon.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ribbon.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.Ribbon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ribbon.HideMenuButtonToolTip = true;
            this.Ribbon.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.Ribbon.Location = new System.Drawing.Point(0, 0);
            this.Ribbon.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ribbon.MenuButtonText = "FILE";
            this.Ribbon.MenuButtonWidth = 56;
            this.Ribbon.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Ribbon.Name = "Ribbon";
            this.Ribbon.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
            this.Ribbon.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black;
            this.Ribbon.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            // 
            // 
            // 
            this.Ribbon.OfficeMenu.Name = "OfficeMenu";
            this.Ribbon.OfficeMenu.ShowItemToolTips = true;
            this.Ribbon.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.Ribbon.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ribbon.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.Ribbon.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2010;
            this.Ribbon.ShowQuickItemsDropDownButton = false;
            this.Ribbon.ShowRibbonDisplayOptionButton = false;
            this.Ribbon.Size = new System.Drawing.Size(1388, 155);
            this.Ribbon.Spreadsheet = this.Spreadsheet;
            this.Ribbon.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.Ribbon.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.Ribbon.TabIndex = 0;
            this.Ribbon.Text = "spreadsheetRibbon1";
            this.Ribbon.ThemeName = "Default";
            this.Ribbon.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.Ribbon.TitleColor = System.Drawing.Color.White;
            this.Ribbon.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // Spreadsheet
            // 
            this.Spreadsheet.AllowCellContextMenu = true;
            this.Spreadsheet.AllowExtendRowColumnCount = true;
            this.Spreadsheet.AllowFiltering = false;
            this.Spreadsheet.AllowFormulaRangeSelection = true;
            this.Spreadsheet.AllowTabItemContextMenu = true;
            this.Spreadsheet.AllowZooming = true;
            this.Spreadsheet.BaseThemeName = "";
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.Spreadsheet.CopyPaste = spreadsheetCopyPaste1;
            this.Spreadsheet.DefaultColumnCount = 101;
            this.Spreadsheet.DefaultRowCount = 101;
            this.Spreadsheet.DisplayAlerts = true;
            this.Spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spreadsheet.FileName = "Book1";
            this.Spreadsheet.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Spreadsheet.ForeColor = System.Drawing.Color.Black;
            this.Spreadsheet.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.Spreadsheet.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.Spreadsheet.IsCustomTabItemContextMenuEnabled = false;
            this.Spreadsheet.Location = new System.Drawing.Point(0, 155);
            this.Spreadsheet.Name = "Spreadsheet";
            this.Spreadsheet.SelectedTabIndex = 0;
            this.Spreadsheet.SelectedTabItem = null;
            this.Spreadsheet.ShowBusyIndicator = true;
            this.Spreadsheet.Size = new System.Drawing.Size(1388, 508);
            this.Spreadsheet.TabIndex = 1;
            this.Spreadsheet.TabItemContextMenu = null;
            this.Spreadsheet.Text = "Spreadsheet";
            this.Spreadsheet.ThemeName = "Default";
            // 
            // ToolStrip
            // 
            this.ToolStrip.AddButton = null;
            this.ToolStrip.AddColumnButton = null;
            this.ToolStrip.AddTableButton = null;
            this.ToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.BindingSource = this.BindingSource;
            this.ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolStrip.CalculatorButton = null;
            this.ToolStrip.CanOverrideStyle = true;
            this.ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            this.ToolStrip.CaptionFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            this.ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.ToolStrip.ChartButton = null;
            this.ToolStrip.DataFilter = null;
            this.ToolStrip.DeleteButton = null;
            this.ToolStrip.DeleteColumnButton = null;
            this.ToolStrip.DeleteRecordButton = null;
            this.ToolStrip.DeleteTableButton = null;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.DropDown = null;
            this.ToolStrip.EditButton = null;
            this.ToolStrip.EditColumnButton = null;
            this.ToolStrip.EditRecordButton = null;
            this.ToolStrip.EditSqlButton = null;
            this.ToolStrip.ExcelButton = null;
            this.ToolStrip.FilterDataButton = null;
            this.ToolStrip.FirstButton = null;
            this.ToolStrip.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.HomeButton = this.HomeButton;
            this.ToolStrip.Image = null;
            this.ToolStrip.ImageDirectory = null;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.ImageSize = new System.Drawing.Size(0, 0);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label,
            this.toolSeparator1,
            this.TextBox,
            this.toolSeparator11,
            this.FirstButton,
            this.toolSeparator14,
            this.PreviousButton,
            this.toolSeparator15,
            this.NextButton,
            this.toolSeparator16,
            this.LastButton,
            this.toolSeparator17,
            this.DropDown,
            this.toolSeparator3,
            this.RefreshDataButton,
            this.toolSeparator4,
            this.TableButton,
            this.toolSeparator5,
            this.UploadButton,
            this.toolSeparator6,
            this.DeleteDatabaseButton,
            this.toolSeparator7,
            this.SaveButton,
            this.toolSeparator8,
            this.CalendarButton,
            this.toolSeparator9,
            this.CalculatorButton,
            this.toolSeparator10,
            this.ChartButton,
            this.toolSeparator12,
            this.BackButton,
            this.toolSeparator13,
            this.HomeButton});
            this.ToolStrip.Label = this.Label;
            this.ToolStrip.LastButton = null;
            this.ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.ToolStrip.Location = new System.Drawing.Point(0, 663);
            this.ToolStrip.Margin = new System.Windows.Forms.Padding(1);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.NextButton = null;
            this.ToolStrip.Office12Mode = false;
            this.ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(1);
            this.ToolStrip.PreviousButton = null;
            this.ToolStrip.ProgressBar = null;
            this.ToolStrip.RefreshButton = null;
            this.ToolStrip.SaveButton = null;
            this.ToolStrip.SearchCriteriaLabel = null;
            this.ToolStrip.SearchEngineLabel = null;
            this.ToolStrip.Separators = null;
            this.ToolStrip.ShowCaption = true;
            this.ToolStrip.ShowLauncher = true;
            this.ToolStrip.Size = new System.Drawing.Size(1388, 50);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.TextBox = null;
            this.ToolStrip.ThemeName = "Office2016DarkGray";
            this.ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            this.ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            this.ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // HomeButton
            // 
            this.HomeButton.AutoToolTip = false;
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BindingSource = this.BindingSource;
            this.HomeButton.DataFilter = null;
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Field = BudgetExecution.Field.AccountCode;
            this.HomeButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.LightGray;
            this.HomeButton.HoverText = "Main Menu";
            this.HomeButton.Image = global::BudgetExecution.Properties.Resources.HomeButton;
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Margin = new System.Windows.Forms.Padding(1);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(1);
            this.HomeButton.Size = new System.Drawing.Size(26, 32);
            this.HomeButton.Text = "toolStripButton10";
            this.HomeButton.ToolTip = this.ToolTip;
            this.HomeButton.ToolType = BudgetExecution.ToolType.HomeButton;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.IsDerivedStyle = true;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.Style = MetroSet_UI.Enums.Style.Custom;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipText = null;
            this.ToolTip.TipTitle = null;
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Label.BindingSource = this.BindingSource;
            this.Label.DataFilter = null;
            this.Label.Field = BudgetExecution.Field.AccountCode;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.ForeColor = System.Drawing.Color.White;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(1);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(1);
            this.Label.Size = new System.Drawing.Size(91, 32);
            this.Label.Tag = "";
            this.Label.Text = "toolStripLabel1";
            this.Label.ToolTip = this.ToolTip;
            // 
            // toolSeparator1
            // 
            this.toolSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator1.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator1.Name = "toolSeparator1";
            this.toolSeparator1.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TextBox.BindingSource = null;
            this.TextBox.Field = BudgetExecution.Field.AccountCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox.HoverText = "";
            this.TextBox.Margin = new System.Windows.Forms.Padding(1);
            this.TextBox.Name = "TextBox";
            this.TextBox.Padding = new System.Windows.Forms.Padding(1);
            this.TextBox.Size = new System.Drawing.Size(246, 32);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = null;
            // 
            // toolSeparator2
            // 
            this.toolSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator2.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator2.Name = "toolSeparator2";
            this.toolSeparator2.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // toolSeparator11
            // 
            this.toolSeparator11.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator11.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator11.Name = "toolSeparator11";
            this.toolSeparator11.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator11.Size = new System.Drawing.Size(6, 32);
            // 
            // FirstButton
            // 
            this.FirstButton.AutoToolTip = false;
            this.FirstButton.BackColor = System.Drawing.Color.Transparent;
            this.FirstButton.BindingSource = this.BindingSource;
            this.FirstButton.DataFilter = null;
            this.FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstButton.Field = BudgetExecution.Field.AccountCode;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstButton.ForeColor = System.Drawing.Color.LightGray;
            this.FirstButton.HoverText = "First Row";
            this.FirstButton.Image = global::BudgetExecution.Properties.Resources.FirstButton;
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(3);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Padding = new System.Windows.Forms.Padding(1);
            this.FirstButton.Size = new System.Drawing.Size(26, 28);
            this.FirstButton.Text = "toolStripButton1";
            this.FirstButton.ToolTip = this.ToolTip;
            this.FirstButton.ToolType = BudgetExecution.ToolType.FirstButton;
            // 
            // toolSeparator14
            // 
            this.toolSeparator14.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator14.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator14.Name = "toolSeparator14";
            this.toolSeparator14.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator14.Size = new System.Drawing.Size(6, 32);
            // 
            // PreviousButton
            // 
            this.PreviousButton.AutoToolTip = false;
            this.PreviousButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviousButton.BindingSource = this.BindingSource;
            this.PreviousButton.DataFilter = null;
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Field = BudgetExecution.Field.AccountCode;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            this.PreviousButton.HoverText = "Previous Row";
            this.PreviousButton.Image = global::BudgetExecution.Properties.Resources.PreviousButton;
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(3);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Padding = new System.Windows.Forms.Padding(1);
            this.PreviousButton.Size = new System.Drawing.Size(26, 28);
            this.PreviousButton.Text = "toolStripButton2";
            this.PreviousButton.ToolTip = this.ToolTip;
            this.PreviousButton.ToolType = BudgetExecution.ToolType.PreviousButton;
            // 
            // toolSeparator15
            // 
            this.toolSeparator15.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator15.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator15.Name = "toolSeparator15";
            this.toolSeparator15.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator15.Size = new System.Drawing.Size(6, 32);
            // 
            // NextButton
            // 
            this.NextButton.AutoToolTip = false;
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.BindingSource = this.BindingSource;
            this.NextButton.DataFilter = null;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.AccountCode;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextButton.ForeColor = System.Drawing.Color.LightGray;
            this.NextButton.HoverText = "Next Row";
            this.NextButton.Image = global::BudgetExecution.Properties.Resources.NextButton;
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(3);
            this.NextButton.Name = "NextButton";
            this.NextButton.Padding = new System.Windows.Forms.Padding(1);
            this.NextButton.Size = new System.Drawing.Size(26, 28);
            this.NextButton.Text = "toolStripButton3";
            this.NextButton.ToolTip = this.ToolTip;
            this.NextButton.ToolType = BudgetExecution.ToolType.NextButton;
            // 
            // toolSeparator16
            // 
            this.toolSeparator16.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator16.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator16.Name = "toolSeparator16";
            this.toolSeparator16.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator16.Size = new System.Drawing.Size(6, 32);
            // 
            // LastButton
            // 
            this.LastButton.AutoToolTip = false;
            this.LastButton.BackColor = System.Drawing.Color.Transparent;
            this.LastButton.BindingSource = this.BindingSource;
            this.LastButton.DataFilter = null;
            this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastButton.Field = BudgetExecution.Field.AccountCode;
            this.LastButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastButton.ForeColor = System.Drawing.Color.LightGray;
            this.LastButton.HoverText = "Last Row";
            this.LastButton.Image = global::BudgetExecution.Properties.Resources.LastButton;
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(3);
            this.LastButton.Name = "LastButton";
            this.LastButton.Padding = new System.Windows.Forms.Padding(1);
            this.LastButton.Size = new System.Drawing.Size(26, 28);
            this.LastButton.Text = "toolStripButton4";
            this.LastButton.ToolTip = this.ToolTip;
            this.LastButton.ToolType = BudgetExecution.ToolType.LastButton;
            // 
            // toolSeparator17
            // 
            this.toolSeparator17.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator17.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator17.Name = "toolSeparator17";
            this.toolSeparator17.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator17.Size = new System.Drawing.Size(6, 32);
            // 
            // DropDown
            // 
            this.DropDown.AllowDrop = true;
            this.DropDown.BindingSource = null;
            this.DropDown.DataFilter = null;
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.Field = BudgetExecution.Field.AccountCode;
            this.DropDown.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.DropDown.HoverText = "Make Selection";
            this.DropDown.Margin = new System.Windows.Forms.Padding(1);
            this.DropDown.MaxDropDownItems = 100;
            this.DropDown.MaxLength = 32767;
            this.DropDown.Name = "DropDown";
            this.DropDown.Numeric = BudgetExecution.Numeric.Accepted;
            this.DropDown.Padding = new System.Windows.Forms.Padding(1);
            this.DropDown.Size = new System.Drawing.Size(252, 32);
            this.DropDown.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            this.DropDown.Tag = "Make Selection";
            this.DropDown.ToolTip = this.ToolTip;
            this.DropDown.ToolTipText = "Make Selection";
            // 
            // toolSeparator3
            // 
            this.toolSeparator3.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator3.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator3.Name = "toolSeparator3";
            this.toolSeparator3.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // RefreshDataButton
            // 
            this.RefreshDataButton.AutoToolTip = false;
            this.RefreshDataButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshDataButton.BindingSource = this.BindingSource;
            this.RefreshDataButton.DataFilter = null;
            this.RefreshDataButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshDataButton.Field = BudgetExecution.Field.AccountCode;
            this.RefreshDataButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshDataButton.ForeColor = System.Drawing.Color.LightGray;
            this.RefreshDataButton.HoverText = "Refresh Data";
            this.RefreshDataButton.Image = global::BudgetExecution.Properties.Resources.RefreshDataButton;
            this.RefreshDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshDataButton.Margin = new System.Windows.Forms.Padding(1);
            this.RefreshDataButton.Name = "RefreshDataButton";
            this.RefreshDataButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshDataButton.Size = new System.Drawing.Size(26, 32);
            this.RefreshDataButton.Text = "toolStripButton1";
            this.RefreshDataButton.ToolTip = this.ToolTip;
            this.RefreshDataButton.ToolType = BudgetExecution.ToolType.RefreshDataButton;
            // 
            // toolSeparator4
            // 
            this.toolSeparator4.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator4.Name = "toolSeparator4";
            this.toolSeparator4.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // TableButton
            // 
            this.TableButton.AutoToolTip = false;
            this.TableButton.BackColor = System.Drawing.Color.Transparent;
            this.TableButton.BindingSource = this.BindingSource;
            this.TableButton.DataFilter = null;
            this.TableButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TableButton.Field = BudgetExecution.Field.AccountCode;
            this.TableButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableButton.ForeColor = System.Drawing.Color.LightGray;
            this.TableButton.HoverText = "Data Editor";
            this.TableButton.Image = global::BudgetExecution.Properties.Resources.TableButton;
            this.TableButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TableButton.Margin = new System.Windows.Forms.Padding(1);
            this.TableButton.Name = "TableButton";
            this.TableButton.Padding = new System.Windows.Forms.Padding(1);
            this.TableButton.Size = new System.Drawing.Size(26, 32);
            this.TableButton.Text = "toolStripButton11";
            this.TableButton.ToolTip = this.ToolTip;
            this.TableButton.ToolType = BudgetExecution.ToolType.TableButton;
            // 
            // toolSeparator5
            // 
            this.toolSeparator5.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator5.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator5.Name = "toolSeparator5";
            this.toolSeparator5.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // UploadButton
            // 
            this.UploadButton.AutoToolTip = false;
            this.UploadButton.BackColor = System.Drawing.Color.Transparent;
            this.UploadButton.BindingSource = this.BindingSource;
            this.UploadButton.DataFilter = null;
            this.UploadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UploadButton.Field = BudgetExecution.Field.AccountCode;
            this.UploadButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UploadButton.ForeColor = System.Drawing.Color.LightGray;
            this.UploadButton.HoverText = "Excel Upload";
            this.UploadButton.Image = global::BudgetExecution.Properties.Resources.UploadButton;
            this.UploadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UploadButton.Margin = new System.Windows.Forms.Padding(1);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Padding = new System.Windows.Forms.Padding(1);
            this.UploadButton.Size = new System.Drawing.Size(26, 32);
            this.UploadButton.Text = "toolStripButton2";
            this.UploadButton.ToolTip = this.ToolTip;
            this.UploadButton.ToolType = BudgetExecution.ToolType.UploadButton;
            // 
            // toolSeparator6
            // 
            this.toolSeparator6.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator6.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator6.Name = "toolSeparator6";
            this.toolSeparator6.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator6.Size = new System.Drawing.Size(6, 32);
            // 
            // DeleteDatabaseButton
            // 
            this.DeleteDatabaseButton.AutoToolTip = false;
            this.DeleteDatabaseButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteDatabaseButton.BindingSource = this.BindingSource;
            this.DeleteDatabaseButton.DataFilter = null;
            this.DeleteDatabaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteDatabaseButton.Field = BudgetExecution.Field.AccountCode;
            this.DeleteDatabaseButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteDatabaseButton.ForeColor = System.Drawing.Color.LightGray;
            this.DeleteDatabaseButton.HoverText = "Delete Data";
            this.DeleteDatabaseButton.Image = global::BudgetExecution.Properties.Resources.DeleteDatabaseButton;
            this.DeleteDatabaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteDatabaseButton.Margin = new System.Windows.Forms.Padding(1);
            this.DeleteDatabaseButton.Name = "DeleteDatabaseButton";
            this.DeleteDatabaseButton.Padding = new System.Windows.Forms.Padding(1);
            this.DeleteDatabaseButton.Size = new System.Drawing.Size(26, 32);
            this.DeleteDatabaseButton.Text = "toolStripButton3";
            this.DeleteDatabaseButton.ToolTip = this.ToolTip;
            this.DeleteDatabaseButton.ToolType = BudgetExecution.ToolType.DeleteDatabaseButton;
            // 
            // toolSeparator7
            // 
            this.toolSeparator7.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator7.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator7.Name = "toolSeparator7";
            this.toolSeparator7.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator7.Size = new System.Drawing.Size(6, 32);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoToolTip = false;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BindingSource = this.BindingSource;
            this.SaveButton.DataFilter = null;
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Field = BudgetExecution.Field.AccountCode;
            this.SaveButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.LightGray;
            this.SaveButton.HoverText = "Save Changes";
            this.SaveButton.Image = global::BudgetExecution.Properties.Resources.SaveButton;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(1);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(1);
            this.SaveButton.Size = new System.Drawing.Size(26, 32);
            this.SaveButton.Text = "toolStripButton4";
            this.SaveButton.ToolTip = this.ToolTip;
            this.SaveButton.ToolType = BudgetExecution.ToolType.SaveButton;
            // 
            // toolSeparator8
            // 
            this.toolSeparator8.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator8.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator8.Name = "toolSeparator8";
            this.toolSeparator8.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator8.Size = new System.Drawing.Size(6, 32);
            // 
            // CalendarButton
            // 
            this.CalendarButton.AutoToolTip = false;
            this.CalendarButton.BackColor = System.Drawing.Color.Transparent;
            this.CalendarButton.BindingSource = this.BindingSource;
            this.CalendarButton.DataFilter = null;
            this.CalendarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalendarButton.Field = BudgetExecution.Field.AccountCode;
            this.CalendarButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarButton.ForeColor = System.Drawing.Color.LightGray;
            this.CalendarButton.HoverText = "Budget Calendar";
            this.CalendarButton.Image = global::BudgetExecution.Properties.Resources.CalendarButton;
            this.CalendarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalendarButton.Margin = new System.Windows.Forms.Padding(1);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Padding = new System.Windows.Forms.Padding(1);
            this.CalendarButton.Size = new System.Drawing.Size(26, 32);
            this.CalendarButton.Text = "toolStripButton5";
            this.CalendarButton.ToolTip = this.ToolTip;
            this.CalendarButton.ToolType = BudgetExecution.ToolType.CalendarButton;
            // 
            // toolSeparator9
            // 
            this.toolSeparator9.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator9.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator9.Name = "toolSeparator9";
            this.toolSeparator9.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator9.Size = new System.Drawing.Size(6, 32);
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.AutoToolTip = false;
            this.CalculatorButton.BackColor = System.Drawing.Color.Transparent;
            this.CalculatorButton.BindingSource = this.BindingSource;
            this.CalculatorButton.DataFilter = null;
            this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatorButton.Field = BudgetExecution.Field.AccountCode;
            this.CalculatorButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightGray;
            this.CalculatorButton.HoverText = "Budget Calculator";
            this.CalculatorButton.Image = global::BudgetExecution.Properties.Resources.CalculatorButton;
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(1);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Padding = new System.Windows.Forms.Padding(1);
            this.CalculatorButton.Size = new System.Drawing.Size(26, 32);
            this.CalculatorButton.Text = "toolStripButton6";
            this.CalculatorButton.ToolTip = this.ToolTip;
            this.CalculatorButton.ToolType = BudgetExecution.ToolType.CalculatorButton;
            // 
            // toolSeparator10
            // 
            this.toolSeparator10.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator10.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator10.Name = "toolSeparator10";
            this.toolSeparator10.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator10.Size = new System.Drawing.Size(6, 32);
            // 
            // ChartButton
            // 
            this.ChartButton.AutoToolTip = false;
            this.ChartButton.BackColor = System.Drawing.Color.Transparent;
            this.ChartButton.BindingSource = this.BindingSource;
            this.ChartButton.DataFilter = null;
            this.ChartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChartButton.Field = BudgetExecution.Field.AccountCode;
            this.ChartButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChartButton.ForeColor = System.Drawing.Color.LightGray;
            this.ChartButton.HoverText = "Visualizations";
            this.ChartButton.Image = global::BudgetExecution.Properties.Resources.ChartButton;
            this.ChartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChartButton.Margin = new System.Windows.Forms.Padding(1);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Padding = new System.Windows.Forms.Padding(1);
            this.ChartButton.Size = new System.Drawing.Size(26, 32);
            this.ChartButton.Text = "toolStripButton7";
            this.ChartButton.ToolTip = this.ToolTip;
            this.ChartButton.ToolType = BudgetExecution.ToolType.ChartButton;
            // 
            // toolSeparator12
            // 
            this.toolSeparator12.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator12.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator12.Name = "toolSeparator12";
            this.toolSeparator12.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator12.Size = new System.Drawing.Size(6, 32);
            // 
            // BackButton
            // 
            this.BackButton.AutoToolTip = false;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BindingSource = this.BindingSource;
            this.BackButton.DataFilter = null;
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Field = BudgetExecution.Field.AccountCode;
            this.BackButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.LightGray;
            this.BackButton.HoverText = "Go Back";
            this.BackButton.Image = global::BudgetExecution.Properties.Resources.BackButton;
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Margin = new System.Windows.Forms.Padding(3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Padding = new System.Windows.Forms.Padding(1);
            this.BackButton.Size = new System.Drawing.Size(26, 28);
            this.BackButton.Text = "toolStripButton1";
            this.BackButton.ToolTip = null;
            this.BackButton.ToolType = BudgetExecution.ToolType.BackButton;
            // 
            // toolSeparator13
            // 
            this.toolSeparator13.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator13.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator13.Name = "toolSeparator13";
            this.toolSeparator13.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator13.Size = new System.Drawing.Size(6, 32);
            // 
            // toolSeparator19
            // 
            this.toolSeparator19.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator19.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator19.Name = "toolSeparator19";
            this.toolSeparator19.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator19.Size = new System.Drawing.Size(6, 30);
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1388, 713);
            this.Controls.Add(this.Spreadsheet);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.Ribbon);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeBox = false;
            this.Name = "ExcelForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Document";
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon Ribbon;
        public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet Spreadsheet;
        public System.Windows.Forms.BindingSource BindingSource;
        public ToolSeparator Separator1;
        public ToolStripTextBox TextBox;
        public ToolSeparator Separator2;
        public ToolStripLabel Label;
        public ToolSeparator Separator3;
        public ToolStripDropDown DropDown;
        public ToolSeparator Separator4;
        public ToolSeparator Separator5;
        public ToolSeparator Separator6;
        public ToolSeparator Separator7;
        public ToolSeparator Separator8;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolSeparator Separator11;
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
        public ToolStripButton CalculatorButton;
        public ToolStripButton ChartButton;
        public ToolStripButton HomeButton;
        public ToolSeparator Separator16;
        public ToolStripButton PreviousButton;
        public ToolStripButton NextButton;
        public ToolSeparator Separator17;
        public ToolStripButton TableButton;
        public ToolSeparator Separator18;
        private ToolStrip ToolStrip;
        private SmallTip ToolTip;

        private ToolSeparator toolSeparator1;
        private ToolSeparator toolSeparator2;
        private ToolSeparator toolSeparator3;
        public ToolStripButton RefreshDataButton;
        private ToolSeparator toolSeparator4;
        private ToolSeparator toolSeparator5;
        public ToolStripButton UploadButton;
        private ToolSeparator toolSeparator6;
        public ToolStripButton DeleteDatabaseButton;
        private ToolSeparator toolSeparator7;
        private ToolSeparator toolSeparator8;
        public ToolStripButton CalendarButton;
        private ToolSeparator toolSeparator9;
        private ToolSeparator toolSeparator10;
        private ToolSeparator toolSeparator11;
        private ToolSeparator toolSeparator12;
        private ToolSeparator toolSeparator13;
        private ToolSeparator toolSeparator14;
        private ToolSeparator toolSeparator15;
        private ToolSeparator toolSeparator16;
        private ToolSeparator toolSeparator17;
        public ToolStripButton BackButton;
        private ToolSeparator toolSeparator19;
    }
}
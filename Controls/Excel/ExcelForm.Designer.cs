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
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            this.Ribbon = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.Spreadsheet = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Ribbon
            // 
            this.Ribbon.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ribbon.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.None;
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
            this.Ribbon.Spreadsheet = null;
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
            this.Spreadsheet.FileName = "Book2";
            this.Spreadsheet.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.Spreadsheet.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.Spreadsheet.IsCustomTabItemContextMenuEnabled = false;
            this.Spreadsheet.Location = new System.Drawing.Point(0, 0);
            this.Spreadsheet.Name = "Spreadsheet";
            this.Spreadsheet.SelectedTabIndex = 0;
            this.Spreadsheet.SelectedTabItem = null;
            this.Spreadsheet.ShowBusyIndicator = true;
            this.Spreadsheet.Size = new System.Drawing.Size(1388, 713);
            this.Spreadsheet.TabIndex = 1;
            this.Spreadsheet.TabItemContextMenu = null;
            this.Spreadsheet.Text = "Spreadsheet";
            this.Spreadsheet.ThemeName = "Default";
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
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            captionImage1.BackColor = System.Drawing.Color.Transparent;
            captionImage1.Location = new System.Drawing.Point(4, 4);
            captionImage1.Name = "CaptionImage";
            captionImage1.Size = new System.Drawing.Size(22, 22);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1388, 713);
            this.Controls.Add(this.Spreadsheet);
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
            this.Text = "     Excel Data";
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon Ribbon;
        public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet Spreadsheet;
        public SmallTip ToolTip;
        public ToolStrip ToolStrip;
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
        public ToolStripButton DatabaseButton;
        public ToolSeparator Separator18;
    }
}
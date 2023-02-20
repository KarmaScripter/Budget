namespace BudgetExecution
{
    using System.Windows.Forms;
    
    using Syncfusion.Windows.Forms.Tools;

    partial class PivotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PivotForm));
            this.ListPanel = new BudgetExecution.Layout();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.PivotPanel = new BudgetExecution.Layout();
            this.ToolStrip = new BudgetExecution.ToolStrip();
            this.AddButton = new BudgetExecution.ToolStripButton();
            this.BrowseButton = new BudgetExecution.ToolStripButton();
            this.CalculatorButton = new BudgetExecution.ToolStripButton();
            this.DeleteButton = new BudgetExecution.ToolStripButton();
            this.DropDown = new BudgetExecution.ToolStripDropDown();
            this.ExcelButton = new BudgetExecution.ToolStripButton();
            this.FirstButton = new BudgetExecution.ToolStripButton();
            this.TextBox = new BudgetExecution.ToolStripTextBox();
            this.Separator1 = new BudgetExecution.ToolSeparator();
            this.Label = new BudgetExecution.ToolStripLabel();
            this.Separator2 = new BudgetExecution.ToolSeparator();
            this.Separator3 = new BudgetExecution.ToolSeparator();
            this.Separator4 = new BudgetExecution.ToolSeparator();
            this.PreviousButton = new BudgetExecution.ToolStripButton();
            this.Separator5 = new BudgetExecution.ToolSeparator();
            this.NextButton = new BudgetExecution.ToolStripButton();
            this.Separator6 = new BudgetExecution.ToolSeparator();
            this.LastButton = new BudgetExecution.ToolStripButton();
            this.Separator7 = new BudgetExecution.ToolSeparator();
            this.Separator8 = new BudgetExecution.ToolSeparator();
            this.Separator9 = new BudgetExecution.ToolSeparator();
            this.RefreshButton = new BudgetExecution.ToolStripButton();
            this.Separator10 = new BudgetExecution.ToolSeparator();
            this.SaveButton = new BudgetExecution.ToolStripButton();
            this.Separator11 = new BudgetExecution.ToolSeparator();
            this.Separator12 = new BudgetExecution.ToolSeparator();
            this.Separator13 = new BudgetExecution.ToolSeparator();
            this.ChartButton = new BudgetExecution.ToolStripButton();
            this.Separator14 = new BudgetExecution.ToolSeparator();
            this.Separator15 = new BudgetExecution.ToolSeparator();
            this.HomeButton = new BudgetExecution.ToolStripButton();
            this.Separator16 = new BudgetExecution.ToolSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ListPanel.BindingSource = null;
            this.ListPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ListPanel.BorderThickness = 1;
            this.ListPanel.Children = null;
            this.ListPanel.DataFilter = null;
            this.ListPanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ListPanel.HoverText = null;
            this.ListPanel.IsDerivedStyle = true;
            this.ListPanel.Location = new System.Drawing.Point(869, 112);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ListPanel.Size = new System.Drawing.Size(264, 476);
            this.ListPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ListPanel.StyleManager = null;
            this.ListPanel.TabIndex = 10;
            this.ListPanel.Text = "layout1";
            this.ListPanel.ThemeAuthor = "Terry D. Eppler";
            this.ListPanel.ThemeName = "Budget Execution";
            this.ListPanel.ToolTip = null;
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
            // PivotPanel
            // 
            this.PivotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PivotPanel.BackColor = System.Drawing.Color.Transparent;
            this.PivotPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PivotPanel.BindingSource = this.BindingSource;
            this.PivotPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.PivotPanel.BorderThickness = 1;
            this.PivotPanel.Children = null;
            this.PivotPanel.DataFilter = null;
            this.PivotPanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PivotPanel.ForeColor = System.Drawing.Color.Transparent;
            this.PivotPanel.HoverText = null;
            this.PivotPanel.IsDerivedStyle = true;
            this.PivotPanel.Location = new System.Drawing.Point(55, 112);
            this.PivotPanel.Name = "PivotPanel";
            this.PivotPanel.Padding = new System.Windows.Forms.Padding(1);
            this.PivotPanel.Size = new System.Drawing.Size(757, 476);
            this.PivotPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.PivotPanel.StyleManager = null;
            this.PivotPanel.TabIndex = 8;
            this.PivotPanel.Text = "layout1";
            this.PivotPanel.ThemeAuthor = "Terry D. Eppler";
            this.PivotPanel.ThemeName = "Budget Execution";
            this.PivotPanel.ToolTip = this.ToolTip;
            // 
            // ToolStrip
            // 
            this.ToolStrip.AddButton = null;
            this.ToolStrip.AddColumnButton = null;
            this.ToolStrip.AddTableButton = null;
            this.ToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.BindingSource = null;
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
            this.ToolStrip.ForeColor = System.Drawing.Color.Black;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.HomeButton = null;
            this.ToolStrip.Image = null;
            this.ToolStrip.ImageDirectory = null;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.ToolStrip.ImageSize = new System.Drawing.Size(0, 0);
            this.ToolStrip.Label = null;
            this.ToolStrip.LastButton = null;
            this.ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.ToolStrip.Location = new System.Drawing.Point(0, 669);
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
            this.ToolStrip.Size = new System.Drawing.Size(1184, 41);
            this.ToolStrip.TabIndex = 11;
            this.ToolStrip.TextBox = null;
            this.ToolStrip.ThemeName = "Office2016DarkGray";
            this.ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            this.ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            this.ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // AddButton
            // 
            this.AddButton.AutoToolTip = false;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BindingSource = null;
            this.AddButton.DataFilter = null;
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Field = BudgetExecution.Field.AccountCode;
            this.AddButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.Color.LightGray;
            this.AddButton.HoverText = null;
            this.AddButton.Margin = new System.Windows.Forms.Padding(3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(1);
            this.AddButton.Size = new System.Drawing.Size(24, 20);
            this.AddButton.ToolTip = null;
            this.AddButton.ToolType = BudgetExecution.ToolType.NS;
            // 
            // BrowseButton
            // 
            this.BrowseButton.AutoToolTip = false;
            this.BrowseButton.BackColor = System.Drawing.Color.Transparent;
            this.BrowseButton.BindingSource = null;
            this.BrowseButton.DataFilter = null;
            this.BrowseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BrowseButton.Field = BudgetExecution.Field.AccountCode;
            this.BrowseButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrowseButton.ForeColor = System.Drawing.Color.LightGray;
            this.BrowseButton.HoverText = null;
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Padding = new System.Windows.Forms.Padding(1);
            this.BrowseButton.Size = new System.Drawing.Size(24, 20);
            this.BrowseButton.ToolTip = null;
            this.BrowseButton.ToolType = BudgetExecution.ToolType.NS;
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.AutoToolTip = false;
            this.CalculatorButton.BackColor = System.Drawing.Color.Transparent;
            this.CalculatorButton.BindingSource = null;
            this.CalculatorButton.DataFilter = null;
            this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatorButton.Field = BudgetExecution.Field.AccountCode;
            this.CalculatorButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightGray;
            this.CalculatorButton.HoverText = null;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(3);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Padding = new System.Windows.Forms.Padding(1);
            this.CalculatorButton.Size = new System.Drawing.Size(24, 20);
            this.CalculatorButton.ToolTip = null;
            this.CalculatorButton.ToolType = BudgetExecution.ToolType.NS;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoToolTip = false;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BindingSource = null;
            this.DeleteButton.DataFilter = null;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Field = BudgetExecution.Field.AccountCode;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.LightGray;
            this.DeleteButton.HoverText = null;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(1);
            this.DeleteButton.Size = new System.Drawing.Size(24, 20);
            this.DeleteButton.ToolTip = null;
            this.DeleteButton.ToolType = BudgetExecution.ToolType.NS;
            // 
            // DropDown
            // 
            this.DropDown.AllowDrop = true;
            this.DropDown.BindingSource = this.BindingSource;
            this.DropDown.DataFilter = null;
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.Field = BudgetExecution.Field.RpioActivityCode;
            this.DropDown.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.DropDown.HoverText = "Make Selection";
            this.DropDown.Margin = new System.Windows.Forms.Padding(5);
            this.DropDown.MaxDropDownItems = 100;
            this.DropDown.MaxLength = 32767;
            this.DropDown.Name = "DropDown";
            this.DropDown.Numeric = BudgetExecution.Numeric.Accepted;
            this.DropDown.Padding = new System.Windows.Forms.Padding(1);
            this.DropDown.Size = new System.Drawing.Size(172, 24);
            this.DropDown.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            this.DropDown.Tag = "Make Selection";
            this.DropDown.ToolTip = this.ToolTip;
            this.DropDown.ToolTipText = "Make Selection";
            // 
            // ExcelButton
            // 
            this.ExcelButton.AutoToolTip = false;
            this.ExcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ExcelButton.BindingSource = this.BindingSource;
            this.ExcelButton.DataFilter = null;
            this.ExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcelButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.ExcelButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcelButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ExcelButton.HoverText = null;
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Padding = new System.Windows.Forms.Padding(1);
            this.ExcelButton.Size = new System.Drawing.Size(24, 24);
            this.ExcelButton.Text = "toolStripButton10";
            this.ExcelButton.ToolTip = this.ToolTip;
            this.ExcelButton.ToolType = BudgetExecution.ToolType.ExcelButton;
            // 
            // FirstButton
            // 
            this.FirstButton.AutoToolTip = false;
            this.FirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.FirstButton.BindingSource = this.BindingSource;
            this.FirstButton.DataFilter = null;
            this.FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FirstButton.HoverText = null;
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(5);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Padding = new System.Windows.Forms.Padding(1);
            this.FirstButton.Size = new System.Drawing.Size(24, 24);
            this.FirstButton.Text = "toolStripButton1";
            this.FirstButton.ToolTip = this.ToolTip;
            this.FirstButton.ToolType = BudgetExecution.ToolType.FirstButton;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBox.BindingSource = null;
            this.TextBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.TextBox.HoverText = "";
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Padding = new System.Windows.Forms.Padding(1);
            this.TextBox.Size = new System.Drawing.Size(132, 24);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = null;
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator1.Name = "Separator1";
            this.Separator1.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator1.Size = new System.Drawing.Size(6, 34);
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Label.BindingSource = this.BindingSource;
            this.Label.DataFilter = null;
            this.Label.Field = BudgetExecution.Field.RpioActivityCode;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(5);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(1);
            this.Label.Size = new System.Drawing.Size(111, 24);
            this.Label.Tag = "";
            this.Label.Text = "Record Information";
            this.Label.ToolTip = this.ToolTip;
            // 
            // Separator2
            // 
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator2.Name = "Separator2";
            this.Separator2.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator2.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator3
            // 
            this.Separator3.ForeColor = System.Drawing.Color.Black;
            this.Separator3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator3.Name = "Separator3";
            this.Separator3.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator3.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator4
            // 
            this.Separator4.ForeColor = System.Drawing.Color.Black;
            this.Separator4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator4.Name = "Separator4";
            this.Separator4.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator4.Size = new System.Drawing.Size(6, 34);
            // 
            // PreviousButton
            // 
            this.PreviousButton.AutoToolTip = false;
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PreviousButton.BindingSource = this.BindingSource;
            this.PreviousButton.DataFilter = null;
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreviousButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.PreviousButton.HoverText = null;
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Padding = new System.Windows.Forms.Padding(1);
            this.PreviousButton.Size = new System.Drawing.Size(24, 24);
            this.PreviousButton.Text = "toolStripButton2";
            this.PreviousButton.ToolTip = this.ToolTip;
            this.PreviousButton.ToolType = BudgetExecution.ToolType.PreviousButton;
            // 
            // Separator5
            // 
            this.Separator5.ForeColor = System.Drawing.Color.Black;
            this.Separator5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator5.Name = "Separator5";
            this.Separator5.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator5.Size = new System.Drawing.Size(6, 34);
            // 
            // NextButton
            // 
            this.NextButton.AutoToolTip = false;
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.NextButton.BindingSource = this.BindingSource;
            this.NextButton.DataFilter = null;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.NextButton.HoverText = null;
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Padding = new System.Windows.Forms.Padding(1);
            this.NextButton.Size = new System.Drawing.Size(24, 24);
            this.NextButton.Text = "toolStripButton3";
            this.NextButton.ToolTip = this.ToolTip;
            this.NextButton.ToolType = BudgetExecution.ToolType.NextButton;
            // 
            // Separator6
            // 
            this.Separator6.ForeColor = System.Drawing.Color.Black;
            this.Separator6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator6.Name = "Separator6";
            this.Separator6.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator6.Size = new System.Drawing.Size(6, 34);
            // 
            // LastButton
            // 
            this.LastButton.AutoToolTip = false;
            this.LastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LastButton.BindingSource = this.BindingSource;
            this.LastButton.DataFilter = null;
            this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.LastButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.LastButton.HoverText = null;
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Padding = new System.Windows.Forms.Padding(1);
            this.LastButton.Size = new System.Drawing.Size(24, 24);
            this.LastButton.Text = "toolStripButton4";
            this.LastButton.ToolTip = this.ToolTip;
            this.LastButton.ToolType = BudgetExecution.ToolType.LastButton;
            // 
            // Separator7
            // 
            this.Separator7.ForeColor = System.Drawing.Color.Black;
            this.Separator7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator7.Name = "Separator7";
            this.Separator7.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator7.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator8
            // 
            this.Separator8.ForeColor = System.Drawing.Color.Black;
            this.Separator8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator8.Name = "Separator8";
            this.Separator8.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator8.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator9
            // 
            this.Separator9.ForeColor = System.Drawing.Color.Black;
            this.Separator9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator9.Name = "Separator9";
            this.Separator9.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator9.Size = new System.Drawing.Size(6, 34);
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoToolTip = false;
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RefreshButton.BindingSource = this.BindingSource;
            this.RefreshButton.DataFilter = null;
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshButton.HoverText = null;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshButton.Size = new System.Drawing.Size(24, 24);
            this.RefreshButton.Text = "toolStripButton7";
            this.RefreshButton.ToolTip = this.ToolTip;
            this.RefreshButton.ToolType = BudgetExecution.ToolType.RefreshButton;
            // 
            // Separator10
            // 
            this.Separator10.ForeColor = System.Drawing.Color.Black;
            this.Separator10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator10.Name = "Separator10";
            this.Separator10.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator10.Size = new System.Drawing.Size(6, 34);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoToolTip = false;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.SaveButton.BindingSource = this.BindingSource;
            this.SaveButton.DataFilter = null;
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.SaveButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.SaveButton.HoverText = null;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(1);
            this.SaveButton.Size = new System.Drawing.Size(24, 24);
            this.SaveButton.Text = "toolStripButton8";
            this.SaveButton.ToolTip = this.ToolTip;
            this.SaveButton.ToolType = BudgetExecution.ToolType.SaveButton;
            // 
            // Separator11
            // 
            this.Separator11.ForeColor = System.Drawing.Color.Black;
            this.Separator11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator11.Name = "Separator11";
            this.Separator11.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator11.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator12
            // 
            this.Separator12.ForeColor = System.Drawing.Color.Black;
            this.Separator12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator12.Name = "Separator12";
            this.Separator12.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator12.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator13
            // 
            this.Separator13.ForeColor = System.Drawing.Color.Black;
            this.Separator13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator13.Name = "Separator13";
            this.Separator13.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator13.Size = new System.Drawing.Size(6, 34);
            // 
            // ChartButton
            // 
            this.ChartButton.AutoToolTip = false;
            this.ChartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ChartButton.BindingSource = this.BindingSource;
            this.ChartButton.DataFilter = null;
            this.ChartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChartButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.ChartButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChartButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ChartButton.HoverText = null;
            this.ChartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChartButton.Margin = new System.Windows.Forms.Padding(5);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Padding = new System.Windows.Forms.Padding(1);
            this.ChartButton.Size = new System.Drawing.Size(24, 24);
            this.ChartButton.Text = "toolStripButton11";
            this.ChartButton.ToolTip = this.ToolTip;
            this.ChartButton.ToolType = BudgetExecution.ToolType.ChartButton;
            // 
            // Separator14
            // 
            this.Separator14.ForeColor = System.Drawing.Color.Black;
            this.Separator14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator14.Name = "Separator14";
            this.Separator14.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator14.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator15
            // 
            this.Separator15.ForeColor = System.Drawing.Color.Black;
            this.Separator15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator15.Name = "Separator15";
            this.Separator15.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator15.Size = new System.Drawing.Size(6, 34);
            // 
            // HomeButton
            // 
            this.HomeButton.AutoToolTip = false;
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.HomeButton.BindingSource = this.BindingSource;
            this.HomeButton.DataFilter = null;
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.HomeButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.HomeButton.HoverText = null;
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Margin = new System.Windows.Forms.Padding(5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(1);
            this.HomeButton.Size = new System.Drawing.Size(24, 24);
            this.HomeButton.Text = "toolStripButton12";
            this.HomeButton.ToolTip = this.ToolTip;
            this.HomeButton.ToolType = BudgetExecution.ToolType.HomeButton;
            // 
            // Separator16
            // 
            this.Separator16.ForeColor = System.Drawing.Color.Black;
            this.Separator16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator16.Name = "Separator16";
            this.Separator16.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator16.Size = new System.Drawing.Size(6, 34);
            // 
            // PivotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Maroon;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1184, 710);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.PivotPanel);
            this.Controls.Add(this.ToolStrip);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PivotForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ToolStrip ToolStrip;
        public ToolStripButton AddButton;
        public ToolStripButton BrowseButton;
        public ToolStripButton CalculatorButton;
        public ToolStripButton DeleteButton;
        public ToolStripDropDown DropDown;
        public ToolStripButton ExcelButton;
        public ToolStripButton FirstButton;
        public ToolStripTextBox TextBox;
        public ToolSeparator Separator1;
        public ToolStripLabel Label;
        public ToolSeparator Separator2;
        public ToolSeparator Separator3;
        public ToolSeparator Separator4;
        public ToolStripButton PreviousButton;
        public ToolSeparator Separator5;
        public ToolStripButton NextButton;
        public ToolSeparator Separator6;
        public ToolStripButton LastButton;
        public ToolSeparator Separator7;
        public ToolSeparator Separator8;
        public ToolSeparator Separator9;
        public ToolStripButton RefreshButton;
        public ToolSeparator Separator10;
        public ToolStripButton SaveButton;
        public ToolSeparator Separator11;
        public ToolSeparator Separator12;
        public ToolSeparator Separator13;
        public ToolStripButton ChartButton;
        public ToolSeparator Separator14;
        public ToolSeparator Separator15;
        public ToolStripButton HomeButton;
        public ToolSeparator Separator16;
        public Layout PivotPanel;
        public BindingSource BindingSource;
        public SmallTip ToolTip;
        public Layout ListPanel;
    }
}
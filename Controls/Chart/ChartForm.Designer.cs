namespace BudgetExecution
{
    

    partial class ChartForm
    {

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.ToolStrip = new BudgetExecution.ToolStrip();
            this.toolSeparator2 = new BudgetExecution.ToolSeparator();
            this.Label = new BudgetExecution.ToolStripLabel();
            this.toolSeparator1 = new BudgetExecution.ToolSeparator();
            this.LookupButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator3 = new BudgetExecution.ToolSeparator();
            this.TextBox = new BudgetExecution.ToolStripTextBox();
            this.toolSeparator4 = new BudgetExecution.ToolSeparator();
            this.FirstButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator5 = new BudgetExecution.ToolSeparator();
            this.PreviousButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator6 = new BudgetExecution.ToolSeparator();
            this.NextButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator8 = new BudgetExecution.ToolSeparator();
            this.LastButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator7 = new BudgetExecution.ToolSeparator();
            this.DropDown = new BudgetExecution.ToolStripDropDown();
            this.toolSeparator9 = new BudgetExecution.ToolSeparator();
            this.RefreshDataButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator10 = new BudgetExecution.ToolSeparator();
            this.TableButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator14 = new BudgetExecution.ToolSeparator();
            this.ExcelButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator11 = new BudgetExecution.ToolSeparator();
            this.CalendarButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator12 = new BudgetExecution.ToolSeparator();
            this.CalculatorButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator13 = new BudgetExecution.ToolSeparator();
            this.BackButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator16 = new BudgetExecution.ToolSeparator();
            this.HomeButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator17 = new BudgetExecution.ToolSeparator();
            this.toolSeparator15 = new BudgetExecution.ToolSeparator();
            this.Chart = new BudgetExecution.Chart();
            this.FilterTable = new System.Windows.Forms.TableLayoutPanel();
            this.FirstFilterLabel = new BudgetExecution.Label();
            this.SecondFilterLabel = new BudgetExecution.Label();
            this.ThirdFilterLabel = new BudgetExecution.Label();
            this.FirstFilterPanel = new BudgetExecution.Layout();
            this.FirstFilterListBox = new BudgetExecution.ListBox();
            this.SecondFilterPanel = new BudgetExecution.Layout();
            this.SecondFilterListBox = new BudgetExecution.ListBox();
            this.ThirdFilterPanel = new BudgetExecution.Layout();
            this.ThirdFilterListBox = new BudgetExecution.ListBox();
            this.ChartPanel = new BudgetExecution.Layout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.FilterTable.SuspendLayout();
            this.FirstFilterPanel.SuspendLayout();
            this.SecondFilterPanel.SuspendLayout();
            this.ThirdFilterPanel.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.ToolStrip.Field = BudgetExecution.Field.AccountCode;
            this.ToolStrip.FilterDataButton = null;
            this.ToolStrip.FirstButton = null;
            this.ToolStrip.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.HomeButton = null;
            this.ToolStrip.Image = null;
            this.ToolStrip.ImageDirectory = null;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.ImageSize = new System.Drawing.Size(0, 0);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSeparator2,
            this.Label,
            this.toolSeparator1,
            this.LookupButton,
            this.toolSeparator3,
            this.TextBox,
            this.toolSeparator4,
            this.FirstButton,
            this.toolSeparator5,
            this.PreviousButton,
            this.toolSeparator6,
            this.NextButton,
            this.toolSeparator8,
            this.LastButton,
            this.toolSeparator7,
            this.DropDown,
            this.toolSeparator9,
            this.RefreshDataButton,
            this.toolSeparator10,
            this.TableButton,
            this.toolSeparator14,
            this.ExcelButton,
            this.toolSeparator11,
            this.CalendarButton,
            this.toolSeparator12,
            this.CalculatorButton,
            this.toolSeparator13,
            this.BackButton,
            this.toolSeparator16,
            this.HomeButton,
            this.toolSeparator17});
            this.ToolStrip.Label = null;
            this.ToolStrip.LastButton = null;
            this.ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.ToolStrip.Location = new System.Drawing.Point(0, 660);
            this.ToolStrip.Margin = new System.Windows.Forms.Padding(1);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.NextButton = null;
            this.ToolStrip.Numeric = BudgetExecution.Numeric.Accepted;
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
            this.ToolStrip.Size = new System.Drawing.Size(1388, 52);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            this.ToolStrip.TextBox = null;
            this.ToolStrip.ThemeName = "Office2016DarkGray";
            this.ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            this.ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            this.ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // toolSeparator2
            // 
            this.toolSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator2.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator2.Name = "toolSeparator2";
            this.toolSeparator2.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Label.BindingSource = null;
            this.Label.DataFilter = null;
            this.Label.Field = BudgetExecution.Field.AccountCode;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(1);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(1);
            this.Label.Size = new System.Drawing.Size(75, 34);
            this.Label.Tag = "";
            this.Label.Text = "Data Search";
            this.Label.ToolTip = this.ToolTip;
            // 
            // toolSeparator1
            // 
            this.toolSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator1.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator1.Name = "toolSeparator1";
            this.toolSeparator1.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // LookupButton
            // 
            this.LookupButton.AutoToolTip = false;
            this.LookupButton.BackColor = System.Drawing.Color.Transparent;
            this.LookupButton.BindingSource = null;
            this.LookupButton.DataFilter = null;
            this.LookupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LookupButton.Field = BudgetExecution.Field.AccountCode;
            this.LookupButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LookupButton.ForeColor = System.Drawing.Color.LightGray;
            this.LookupButton.HoverText = null;
            this.LookupButton.Image = global::BudgetExecution.Properties.Resources.LookupButton;
            this.LookupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LookupButton.Margin = new System.Windows.Forms.Padding(3);
            this.LookupButton.Name = "LookupButton";
            this.LookupButton.Padding = new System.Windows.Forms.Padding(1);
            this.LookupButton.Size = new System.Drawing.Size(26, 30);
            this.LookupButton.Text = "toolStripButton1";
            this.LookupButton.ToolTip = null;
            this.LookupButton.ToolType = BudgetExecution.ToolType.NS;
            // 
            // toolSeparator3
            // 
            this.toolSeparator3.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator3.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator3.Name = "toolSeparator3";
            this.toolSeparator3.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TextBox.BindingSource = this.BindingSource;
            this.TextBox.Field = BudgetExecution.Field.AccountCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox.HoverText = "Enter Keywords";
            this.TextBox.Margin = new System.Windows.Forms.Padding(1);
            this.TextBox.Name = "TextBox";
            this.TextBox.Padding = new System.Windows.Forms.Padding(1);
            this.TextBox.Size = new System.Drawing.Size(224, 34);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = this.ToolTip;
            // 
            // toolSeparator4
            // 
            this.toolSeparator4.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator4.Name = "toolSeparator4";
            this.toolSeparator4.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator4.Size = new System.Drawing.Size(6, 34);
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
            this.FirstButton.HoverText = "First Record";
            this.FirstButton.Image = global::BudgetExecution.Properties.Resources.FirstButton;
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(3);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Padding = new System.Windows.Forms.Padding(1);
            this.FirstButton.Size = new System.Drawing.Size(26, 30);
            this.FirstButton.Text = "toolStripButton1";
            this.FirstButton.ToolTip = this.ToolTip;
            this.FirstButton.ToolType = BudgetExecution.ToolType.FirstButton;
            // 
            // toolSeparator5
            // 
            this.toolSeparator5.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator5.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator5.Name = "toolSeparator5";
            this.toolSeparator5.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator5.Size = new System.Drawing.Size(6, 34);
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
            this.PreviousButton.HoverText = "Previous Record";
            this.PreviousButton.Image = global::BudgetExecution.Properties.Resources.PreviousButton;
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(3);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Padding = new System.Windows.Forms.Padding(1);
            this.PreviousButton.Size = new System.Drawing.Size(26, 30);
            this.PreviousButton.Text = "toolStripButton2";
            this.PreviousButton.ToolTip = this.ToolTip;
            this.PreviousButton.ToolType = BudgetExecution.ToolType.PreviousButton;
            // 
            // toolSeparator6
            // 
            this.toolSeparator6.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator6.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator6.Name = "toolSeparator6";
            this.toolSeparator6.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator6.Size = new System.Drawing.Size(6, 34);
            // 
            // NextButton
            // 
            this.NextButton.AutoToolTip = false;
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.BindingSource = null;
            this.NextButton.DataFilter = null;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.AccountCode;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextButton.ForeColor = System.Drawing.Color.LightGray;
            this.NextButton.HoverText = null;
            this.NextButton.Image = global::BudgetExecution.Properties.Resources.NextButton;
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(3);
            this.NextButton.Name = "NextButton";
            this.NextButton.Padding = new System.Windows.Forms.Padding(1);
            this.NextButton.Size = new System.Drawing.Size(26, 30);
            this.NextButton.Text = "toolStripButton3";
            this.NextButton.ToolTip = null;
            this.NextButton.ToolType = BudgetExecution.ToolType.NS;
            // 
            // toolSeparator8
            // 
            this.toolSeparator8.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator8.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator8.Name = "toolSeparator8";
            this.toolSeparator8.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator8.Size = new System.Drawing.Size(6, 34);
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
            this.LastButton.HoverText = "Last Record";
            this.LastButton.Image = global::BudgetExecution.Properties.Resources.LastButton;
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(3);
            this.LastButton.Name = "LastButton";
            this.LastButton.Padding = new System.Windows.Forms.Padding(1);
            this.LastButton.Size = new System.Drawing.Size(26, 30);
            this.LastButton.Text = "toolStripButton4";
            this.LastButton.ToolTip = this.ToolTip;
            this.LastButton.ToolType = BudgetExecution.ToolType.LastButton;
            // 
            // toolSeparator7
            // 
            this.toolSeparator7.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator7.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator7.Name = "toolSeparator7";
            this.toolSeparator7.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator7.Size = new System.Drawing.Size(6, 34);
            // 
            // DropDown
            // 
            this.DropDown.AllowDrop = true;
            this.DropDown.BindingSource = this.BindingSource;
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
            this.DropDown.Size = new System.Drawing.Size(252, 34);
            this.DropDown.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            this.DropDown.Tag = "Make Selection";
            this.DropDown.ToolTip = this.ToolTip;
            this.DropDown.ToolTipText = "Make Selection";
            // 
            // toolSeparator9
            // 
            this.toolSeparator9.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator9.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator9.Name = "toolSeparator9";
            this.toolSeparator9.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator9.Size = new System.Drawing.Size(6, 34);
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
            this.RefreshDataButton.Margin = new System.Windows.Forms.Padding(3);
            this.RefreshDataButton.Name = "RefreshDataButton";
            this.RefreshDataButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshDataButton.Size = new System.Drawing.Size(26, 30);
            this.RefreshDataButton.Text = "toolStripButton1";
            this.RefreshDataButton.ToolTip = this.ToolTip;
            this.RefreshDataButton.ToolType = BudgetExecution.ToolType.RefreshDataButton;
            // 
            // toolSeparator10
            // 
            this.toolSeparator10.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator10.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator10.Name = "toolSeparator10";
            this.toolSeparator10.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator10.Size = new System.Drawing.Size(6, 34);
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
            this.TableButton.HoverText = "View Datatable";
            this.TableButton.Image = global::BudgetExecution.Properties.Resources.TableButton;
            this.TableButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TableButton.Margin = new System.Windows.Forms.Padding(3);
            this.TableButton.Name = "TableButton";
            this.TableButton.Padding = new System.Windows.Forms.Padding(1);
            this.TableButton.Size = new System.Drawing.Size(26, 30);
            this.TableButton.Text = "toolStripButton5";
            this.TableButton.ToolTip = this.ToolTip;
            this.TableButton.ToolType = BudgetExecution.ToolType.TableButton;
            // 
            // toolSeparator14
            // 
            this.toolSeparator14.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator14.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator14.Name = "toolSeparator14";
            this.toolSeparator14.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator14.Size = new System.Drawing.Size(6, 34);
            // 
            // ExcelButton
            // 
            this.ExcelButton.AutoToolTip = false;
            this.ExcelButton.BackColor = System.Drawing.Color.Transparent;
            this.ExcelButton.BindingSource = this.BindingSource;
            this.ExcelButton.DataFilter = null;
            this.ExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcelButton.Field = BudgetExecution.Field.AccountCode;
            this.ExcelButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcelButton.ForeColor = System.Drawing.Color.LightGray;
            this.ExcelButton.HoverText = "View Excel Data";
            this.ExcelButton.Image = global::BudgetExecution.Properties.Resources.ExcelButton;
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Margin = new System.Windows.Forms.Padding(3);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Padding = new System.Windows.Forms.Padding(1);
            this.ExcelButton.Size = new System.Drawing.Size(26, 30);
            this.ExcelButton.Text = "toolStripButton2";
            this.ExcelButton.ToolTip = this.ToolTip;
            this.ExcelButton.ToolType = BudgetExecution.ToolType.ExcelButton;
            // 
            // toolSeparator11
            // 
            this.toolSeparator11.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator11.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator11.Name = "toolSeparator11";
            this.toolSeparator11.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator11.Size = new System.Drawing.Size(6, 34);
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
            this.CalendarButton.HoverText = "Select Date";
            this.CalendarButton.Image = global::BudgetExecution.Properties.Resources.CalendarButton;
            this.CalendarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalendarButton.Margin = new System.Windows.Forms.Padding(3);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Padding = new System.Windows.Forms.Padding(1);
            this.CalendarButton.Size = new System.Drawing.Size(26, 30);
            this.CalendarButton.Text = "toolStripButton3";
            this.CalendarButton.ToolTip = this.ToolTip;
            this.CalendarButton.ToolType = BudgetExecution.ToolType.CalendarButton;
            // 
            // toolSeparator12
            // 
            this.toolSeparator12.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator12.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator12.Name = "toolSeparator12";
            this.toolSeparator12.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator12.Size = new System.Drawing.Size(6, 34);
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
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(3);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Padding = new System.Windows.Forms.Padding(1);
            this.CalculatorButton.Size = new System.Drawing.Size(26, 30);
            this.CalculatorButton.Text = "toolStripButton4";
            this.CalculatorButton.ToolTip = this.ToolTip;
            this.CalculatorButton.ToolType = BudgetExecution.ToolType.CalculatorButton;
            // 
            // toolSeparator13
            // 
            this.toolSeparator13.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator13.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator13.Name = "toolSeparator13";
            this.toolSeparator13.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator13.Size = new System.Drawing.Size(6, 34);
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
            this.BackButton.Size = new System.Drawing.Size(26, 30);
            this.BackButton.Text = "toolStripButton1";
            this.BackButton.ToolTip = this.ToolTip;
            this.BackButton.ToolType = BudgetExecution.ToolType.BackButton;
            // 
            // toolSeparator16
            // 
            this.toolSeparator16.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator16.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator16.Name = "toolSeparator16";
            this.toolSeparator16.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator16.Size = new System.Drawing.Size(6, 34);
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
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(1);
            this.HomeButton.Size = new System.Drawing.Size(26, 30);
            this.HomeButton.Text = "toolStripButton1";
            this.HomeButton.ToolTip = this.ToolTip;
            this.HomeButton.ToolType = BudgetExecution.ToolType.HomeButton;
            // 
            // toolSeparator17
            // 
            this.toolSeparator17.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator17.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator17.Name = "toolSeparator17";
            this.toolSeparator17.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator17.Size = new System.Drawing.Size(6, 34);
            // 
            // toolSeparator15
            // 
            this.toolSeparator15.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator15.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator15.Name = "toolSeparator15";
            this.toolSeparator15.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator15.Size = new System.Drawing.Size(6, 30);
            // 
            // Chart
            // 
            this.Chart.AllowGradientPalette = true;
            this.Chart.AllowUserEditStyles = true;
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart.AutoHighlight = true;
            this.Chart.AxisModel = null;
            this.Chart.BindingModel = null;
            this.Chart.BindingSource = this.BindingSource;
            this.Chart.ChartArea.AutoScale = true;
            this.Chart.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.Chart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart.ChartArea.CursorReDraw = false;
            this.Chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(3, 3, 3, 3);
            this.Chart.ChartSeries = null;
            this.Chart.ChartType = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Line;
            this.Chart.Data = null;
            this.Chart.DataFilter = null;
            this.Chart.DataTable = null;
            this.Chart.Depth = 250F;
            this.Chart.DisplayChartContextMenu = false;
            this.Chart.DisplaySeriesContextMenu = false;
            this.Chart.EnableMouseRotation = true;
            this.Chart.Field = BudgetExecution.Field.AccountCode;
            this.Chart.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart.Legend.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chart.Legend.ItemsAlignment = System.Drawing.StringAlignment.Center;
            this.Chart.Legend.ItemsSize = new System.Drawing.Size(10, 10);
            this.Chart.Legend.Location = new System.Drawing.Point(875, 88);
            this.Chart.Legend.ShowItemsShadow = true;
            this.Chart.Legend.ShowSymbol = true;
            this.Chart.Legend.VisibleCheckBox = true;
            this.Chart.Localize = null;
            this.Chart.Location = new System.Drawing.Point(18, 19);
            this.Chart.Name = "Chart";
            this.Chart.Numeric = BudgetExecution.Numeric.Accepted;
            this.Chart.Padding = new System.Windows.Forms.Padding(1);
            this.Chart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.Chart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart.PrimaryXAxis.Margin = true;
            this.Chart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart.PrimaryYAxis.Margin = true;
            this.Chart.RealMode3D = true;
            this.Chart.Rotation = 0.1F;
            this.Chart.Series3D = true;
            this.Chart.SeriesHighlight = true;
            this.Chart.ShowScrollBars = false;
            this.Chart.ShowToolbar = true;
            this.Chart.ShowToolTips = true;
            this.Chart.Size = new System.Drawing.Size(978, 577);
            this.Chart.Source = BudgetExecution.Source.External;
            this.Chart.Spacing = 5F;
            this.Chart.SpacingBetweenPoints = 5F;
            this.Chart.Stat = BudgetExecution.STAT.NS;
            this.Chart.STAT = BudgetExecution.STAT.NS;
            this.Chart.Style3D = true;
            this.Chart.TabIndex = 1;
            this.Chart.Text = "chart1";
            this.Chart.Tilt = 5F;
            // 
            // 
            // 
            this.Chart.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Chart.Title.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chart.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Chart.Title.Name = "Default";
            this.Chart.Titles.Add(this.Chart.Title);
            this.Chart.ToolBar.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Chart.ToolBar.ShowBorder = false;
            this.Chart.ToolBar.ShowGrip = false;
            this.Chart.ToolBar.Visible = true;
            this.Chart.VisualTheme = "";
            this.Chart.xAxis = null;
            this.Chart.yValue = null;
            // 
            // FilterTable
            // 
            this.FilterTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTable.ColumnCount = 1;
            this.FilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FilterTable.Controls.Add(this.FirstFilterLabel, 0, 0);
            this.FilterTable.Controls.Add(this.SecondFilterLabel, 0, 2);
            this.FilterTable.Controls.Add(this.ThirdFilterLabel, 0, 4);
            this.FilterTable.Controls.Add(this.FirstFilterPanel, 0, 1);
            this.FilterTable.Controls.Add(this.SecondFilterPanel, 0, 3);
            this.FilterTable.Controls.Add(this.ThirdFilterPanel, 0, 5);
            this.FilterTable.Location = new System.Drawing.Point(1065, 1);
            this.FilterTable.Name = "FilterTable";
            this.FilterTable.RowCount = 6;
            this.FilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.FilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.FilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.FilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.FilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.FilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.FilterTable.Size = new System.Drawing.Size(311, 659);
            this.FilterTable.TabIndex = 3;
            // 
            // FirstFilterLabel
            // 
            this.FirstFilterLabel.BindingSource = null;
            this.FirstFilterLabel.DataFilter = null;
            this.FirstFilterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstFilterLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstFilterLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstFilterLabel.HoverText = null;
            this.FirstFilterLabel.IsDerivedStyle = true;
            this.FirstFilterLabel.Location = new System.Drawing.Point(3, 3);
            this.FirstFilterLabel.Margin = new System.Windows.Forms.Padding(3);
            this.FirstFilterLabel.Name = "FirstFilterLabel";
            this.FirstFilterLabel.Padding = new System.Windows.Forms.Padding(1);
            this.FirstFilterLabel.Size = new System.Drawing.Size(305, 20);
            this.FirstFilterLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstFilterLabel.StyleManager = null;
            this.FirstFilterLabel.TabIndex = 0;
            this.FirstFilterLabel.Text = "Top";
            this.FirstFilterLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FirstFilterLabel.ThemeAuthor = "Terry D. Eppler";
            this.FirstFilterLabel.ThemeName = "BudgetExecution";
            this.FirstFilterLabel.ToolTip = null;
            // 
            // SecondFilterLabel
            // 
            this.SecondFilterLabel.BindingSource = null;
            this.SecondFilterLabel.DataFilter = null;
            this.SecondFilterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondFilterLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondFilterLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondFilterLabel.HoverText = null;
            this.SecondFilterLabel.IsDerivedStyle = true;
            this.SecondFilterLabel.Location = new System.Drawing.Point(3, 219);
            this.SecondFilterLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SecondFilterLabel.Name = "SecondFilterLabel";
            this.SecondFilterLabel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondFilterLabel.Size = new System.Drawing.Size(305, 20);
            this.SecondFilterLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondFilterLabel.StyleManager = null;
            this.SecondFilterLabel.TabIndex = 1;
            this.SecondFilterLabel.Text = "Middle";
            this.SecondFilterLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SecondFilterLabel.ThemeAuthor = "Terry D. Eppler";
            this.SecondFilterLabel.ThemeName = "BudgetExecution";
            this.SecondFilterLabel.ToolTip = null;
            // 
            // ThirdFilterLabel
            // 
            this.ThirdFilterLabel.BindingSource = null;
            this.ThirdFilterLabel.DataFilter = null;
            this.ThirdFilterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThirdFilterLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThirdFilterLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdFilterLabel.HoverText = null;
            this.ThirdFilterLabel.IsDerivedStyle = true;
            this.ThirdFilterLabel.Location = new System.Drawing.Point(3, 435);
            this.ThirdFilterLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ThirdFilterLabel.Name = "ThirdFilterLabel";
            this.ThirdFilterLabel.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdFilterLabel.Size = new System.Drawing.Size(305, 20);
            this.ThirdFilterLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdFilterLabel.StyleManager = null;
            this.ThirdFilterLabel.TabIndex = 2;
            this.ThirdFilterLabel.Text = "Bottom";
            this.ThirdFilterLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ThirdFilterLabel.ThemeAuthor = "Terry D. Eppler";
            this.ThirdFilterLabel.ThemeName = "BudgetExecution";
            this.ThirdFilterLabel.ToolTip = null;
            // 
            // FirstFilterPanel
            // 
            this.FirstFilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.FirstFilterPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstFilterPanel.BindingSource = null;
            this.FirstFilterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.FirstFilterPanel.BorderThickness = 1;
            this.FirstFilterPanel.Children = null;
            this.FirstFilterPanel.Controls.Add(this.FirstFilterListBox);
            this.FirstFilterPanel.DataFilter = null;
            this.FirstFilterPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstFilterPanel.ForeColor = System.Drawing.Color.Transparent;
            this.FirstFilterPanel.HoverText = null;
            this.FirstFilterPanel.IsDerivedStyle = true;
            this.FirstFilterPanel.Location = new System.Drawing.Point(3, 29);
            this.FirstFilterPanel.Name = "FirstFilterPanel";
            this.FirstFilterPanel.Padding = new System.Windows.Forms.Padding(1);
            this.FirstFilterPanel.Size = new System.Drawing.Size(305, 184);
            this.FirstFilterPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstFilterPanel.StyleManager = null;
            this.FirstFilterPanel.TabIndex = 3;
            this.FirstFilterPanel.ThemeAuthor = "Terry D. Eppler";
            this.FirstFilterPanel.ThemeName = "BudgetExecution";
            this.FirstFilterPanel.ToolTip = null;
            // 
            // FirstFilterListBox
            // 
            this.FirstFilterListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstFilterListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FirstFilterListBox.BindingSource = null;
            this.FirstFilterListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FirstFilterListBox.DataFilter = null;
            this.FirstFilterListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstFilterListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstFilterListBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstFilterListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.FirstFilterListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.FirstFilterListBox.HoverText = null;
            this.FirstFilterListBox.IsDerivedStyle = true;
            this.FirstFilterListBox.ItemHeight = 20;
            this.FirstFilterListBox.Location = new System.Drawing.Point(22, 19);
            this.FirstFilterListBox.MultiSelect = false;
            this.FirstFilterListBox.Name = "FirstFilterListBox";
            this.FirstFilterListBox.Padding = new System.Windows.Forms.Padding(1);
            this.FirstFilterListBox.SelectedIndex = -1;
            this.FirstFilterListBox.SelectedItem = null;
            this.FirstFilterListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstFilterListBox.SelectedItemColor = System.Drawing.Color.White;
            this.FirstFilterListBox.SelectedText = null;
            this.FirstFilterListBox.SelectedValue = null;
            this.FirstFilterListBox.ShowBorder = false;
            this.FirstFilterListBox.ShowScrollBar = false;
            this.FirstFilterListBox.Size = new System.Drawing.Size(266, 148);
            this.FirstFilterListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstFilterListBox.StyleManager = null;
            this.FirstFilterListBox.TabIndex = 0;
            this.FirstFilterListBox.ThemeAuthor = "Terry D. Eppler";
            this.FirstFilterListBox.ThemeName = "BudgetExecution";
            this.FirstFilterListBox.ToolTip = null;
            // 
            // SecondFilterPanel
            // 
            this.SecondFilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.SecondFilterPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondFilterPanel.BindingSource = null;
            this.SecondFilterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SecondFilterPanel.BorderThickness = 1;
            this.SecondFilterPanel.Children = null;
            this.SecondFilterPanel.Controls.Add(this.SecondFilterListBox);
            this.SecondFilterPanel.DataFilter = null;
            this.SecondFilterPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondFilterPanel.ForeColor = System.Drawing.Color.Transparent;
            this.SecondFilterPanel.HoverText = null;
            this.SecondFilterPanel.IsDerivedStyle = true;
            this.SecondFilterPanel.Location = new System.Drawing.Point(3, 245);
            this.SecondFilterPanel.Name = "SecondFilterPanel";
            this.SecondFilterPanel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondFilterPanel.Size = new System.Drawing.Size(305, 181);
            this.SecondFilterPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondFilterPanel.StyleManager = null;
            this.SecondFilterPanel.TabIndex = 4;
            this.SecondFilterPanel.ThemeAuthor = "Terry D. Eppler";
            this.SecondFilterPanel.ThemeName = "BudgetExecution";
            this.SecondFilterPanel.ToolTip = null;
            // 
            // SecondFilterListBox
            // 
            this.SecondFilterListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondFilterListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SecondFilterListBox.BindingSource = null;
            this.SecondFilterListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SecondFilterListBox.DataFilter = null;
            this.SecondFilterListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondFilterListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondFilterListBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondFilterListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SecondFilterListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.SecondFilterListBox.HoverText = null;
            this.SecondFilterListBox.IsDerivedStyle = true;
            this.SecondFilterListBox.ItemHeight = 20;
            this.SecondFilterListBox.Location = new System.Drawing.Point(22, 17);
            this.SecondFilterListBox.MultiSelect = false;
            this.SecondFilterListBox.Name = "SecondFilterListBox";
            this.SecondFilterListBox.Padding = new System.Windows.Forms.Padding(1);
            this.SecondFilterListBox.SelectedIndex = -1;
            this.SecondFilterListBox.SelectedItem = null;
            this.SecondFilterListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondFilterListBox.SelectedItemColor = System.Drawing.Color.White;
            this.SecondFilterListBox.SelectedText = null;
            this.SecondFilterListBox.SelectedValue = null;
            this.SecondFilterListBox.ShowBorder = false;
            this.SecondFilterListBox.ShowScrollBar = false;
            this.SecondFilterListBox.Size = new System.Drawing.Size(266, 148);
            this.SecondFilterListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondFilterListBox.StyleManager = null;
            this.SecondFilterListBox.TabIndex = 0;
            this.SecondFilterListBox.ThemeAuthor = "Terry D. Eppler";
            this.SecondFilterListBox.ThemeName = "BudgetExecution";
            this.SecondFilterListBox.ToolTip = null;
            // 
            // ThirdFilterPanel
            // 
            this.ThirdFilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.ThirdFilterPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdFilterPanel.BindingSource = null;
            this.ThirdFilterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ThirdFilterPanel.BorderThickness = 1;
            this.ThirdFilterPanel.Children = null;
            this.ThirdFilterPanel.Controls.Add(this.ThirdFilterListBox);
            this.ThirdFilterPanel.DataFilter = null;
            this.ThirdFilterPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdFilterPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ThirdFilterPanel.HoverText = null;
            this.ThirdFilterPanel.IsDerivedStyle = true;
            this.ThirdFilterPanel.Location = new System.Drawing.Point(3, 461);
            this.ThirdFilterPanel.Name = "ThirdFilterPanel";
            this.ThirdFilterPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdFilterPanel.Size = new System.Drawing.Size(305, 185);
            this.ThirdFilterPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdFilterPanel.StyleManager = null;
            this.ThirdFilterPanel.TabIndex = 5;
            this.ThirdFilterPanel.ThemeAuthor = "Terry D. Eppler";
            this.ThirdFilterPanel.ThemeName = "BudgetExecution";
            this.ThirdFilterPanel.ToolTip = null;
            // 
            // ThirdFilterListBox
            // 
            this.ThirdFilterListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThirdFilterListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ThirdFilterListBox.BindingSource = null;
            this.ThirdFilterListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ThirdFilterListBox.DataFilter = null;
            this.ThirdFilterListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdFilterListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdFilterListBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdFilterListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ThirdFilterListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.ThirdFilterListBox.HoverText = null;
            this.ThirdFilterListBox.IsDerivedStyle = true;
            this.ThirdFilterListBox.ItemHeight = 20;
            this.ThirdFilterListBox.Location = new System.Drawing.Point(22, 19);
            this.ThirdFilterListBox.MultiSelect = false;
            this.ThirdFilterListBox.Name = "ThirdFilterListBox";
            this.ThirdFilterListBox.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdFilterListBox.SelectedIndex = -1;
            this.ThirdFilterListBox.SelectedItem = null;
            this.ThirdFilterListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdFilterListBox.SelectedItemColor = System.Drawing.Color.White;
            this.ThirdFilterListBox.SelectedText = null;
            this.ThirdFilterListBox.SelectedValue = null;
            this.ThirdFilterListBox.ShowBorder = false;
            this.ThirdFilterListBox.ShowScrollBar = false;
            this.ThirdFilterListBox.Size = new System.Drawing.Size(266, 148);
            this.ThirdFilterListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdFilterListBox.StyleManager = null;
            this.ThirdFilterListBox.TabIndex = 0;
            this.ThirdFilterListBox.ThemeAuthor = "Terry D. Eppler";
            this.ThirdFilterListBox.ThemeName = "BudgetExecution";
            this.ThirdFilterListBox.ToolTip = null;
            // 
            // ChartPanel
            // 
            this.ChartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartPanel.BackColor = System.Drawing.Color.Transparent;
            this.ChartPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ChartPanel.BindingSource = null;
            this.ChartPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ChartPanel.BorderThickness = 1;
            this.ChartPanel.Children = null;
            this.ChartPanel.Controls.Add(this.Chart);
            this.ChartPanel.DataFilter = null;
            this.ChartPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChartPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ChartPanel.HoverText = null;
            this.ChartPanel.IsDerivedStyle = true;
            this.ChartPanel.Location = new System.Drawing.Point(20, 30);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ChartPanel.Size = new System.Drawing.Size(1017, 617);
            this.ChartPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ChartPanel.StyleManager = null;
            this.ChartPanel.TabIndex = 4;
            this.ChartPanel.ThemeAuthor = "Terry D. Eppler";
            this.ChartPanel.ThemeName = "BudgetExecution";
            this.ChartPanel.ToolTip = null;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1388, 712);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.FilterTable);
            this.Controls.Add(this.ToolStrip);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeBox = false;
            this.Name = "ChartForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Visualization";
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.FilterTable.ResumeLayout(false);
            this.FirstFilterPanel.ResumeLayout(false);
            this.SecondFilterPanel.ResumeLayout(false);
            this.ThirdFilterPanel.ResumeLayout(false);
            this.ChartPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ToolSeparator Separator16;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.BindingSource BindingSource;
        public SmallTip ToolTip;
        public ToolStrip ToolStrip;
        private ToolSeparator toolSeparator2;
        public ToolStripLabel Label;
        private ToolSeparator toolSeparator1;
        public ToolStripButton LookupButton;
        private ToolSeparator toolSeparator3;
        public ToolStripTextBox TextBox;
        private ToolSeparator toolSeparator4;
        public ToolStripButton FirstButton;
        private ToolSeparator toolSeparator5;
        public ToolStripButton PreviousButton;
        private ToolSeparator toolSeparator6;
        public ToolStripButton NextButton;
        private ToolSeparator toolSeparator8;
        public ToolStripButton LastButton;
        private ToolSeparator toolSeparator7;
        public ToolStripDropDown DropDown;
        private ToolSeparator toolSeparator9;
        public Chart Chart;
        public ToolStripButton RefreshDataButton;
        private ToolSeparator toolSeparator10;
        public ToolStripButton TableButton;
        private ToolSeparator toolSeparator14;
        public ToolStripButton ExcelButton;
        private ToolSeparator toolSeparator11;
        public ToolStripButton CalendarButton;
        private ToolSeparator toolSeparator12;
        public ToolStripButton CalculatorButton;
        private ToolSeparator toolSeparator13;
        public ToolStripButton HomeButton;
        private ToolSeparator toolSeparator15;
        private ToolSeparator toolSeparator16;
        public System.Windows.Forms.TableLayoutPanel FilterTable;
        public Label FirstFilterLabel;
        public Label SecondFilterLabel;
        public Label ThirdFilterLabel;
        public Layout FirstFilterPanel;
        public ListBox FirstFilterListBox;
        public Layout SecondFilterPanel;
        public ListBox SecondFilterListBox;
        public Layout ThirdFilterPanel;
        public ListBox ThirdFilterListBox;
        private Layout ChartPanel;
        public ToolStripButton BackButton;
        private ToolSeparator toolSeparator17;
    }
}
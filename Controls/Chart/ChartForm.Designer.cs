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
            this.FirstPanel = new BudgetExecution.Layout();
            this.FirstListBox = new BudgetExecution.ListBox();
            this.SecondPanel = new BudgetExecution.Layout();
            this.SecondListBox = new BudgetExecution.ListBox();
            this.ThirdPanel = new BudgetExecution.Layout();
            this.ThirdListBox = new BudgetExecution.ListBox();
            this.ChartPanel = new BudgetExecution.Layout();
            this.ChartTable = new System.Windows.Forms.TableLayoutPanel();
            this.Header = new BudgetExecution.Label();
            this.FirstFilterTable = new System.Windows.Forms.TableLayoutPanel();
            this.SecondFilterTable = new System.Windows.Forms.TableLayoutPanel();
            this.ThirdFilterTable = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new BudgetExecution.ComboBox();
            this.comboBox2 = new BudgetExecution.ComboBox();
            this.comboBox3 = new BudgetExecution.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.FirstPanel.SuspendLayout();
            this.SecondPanel.SuspendLayout();
            this.ThirdPanel.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            this.ChartTable.SuspendLayout();
            this.FirstFilterTable.SuspendLayout();
            this.SecondFilterTable.SuspendLayout();
            this.ThirdFilterTable.SuspendLayout();
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
            this.ToolStrip.Location = new System.Drawing.Point(0, 714);
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
            this.ToolStrip.Size = new System.Drawing.Size(1388, 50);
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
            this.ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
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
            this.toolSeparator2.Size = new System.Drawing.Size(6, 32);
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
            this.Label.Size = new System.Drawing.Size(75, 32);
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
            this.toolSeparator1.Size = new System.Drawing.Size(6, 32);
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
            this.LookupButton.Image = global::BudgetExecution.Properties.Resources.DataSearchButton;
            this.LookupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LookupButton.Margin = new System.Windows.Forms.Padding(3);
            this.LookupButton.Name = "LookupButton";
            this.LookupButton.Padding = new System.Windows.Forms.Padding(1);
            this.LookupButton.Size = new System.Drawing.Size(26, 28);
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
            this.toolSeparator3.Size = new System.Drawing.Size(6, 32);
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
            this.TextBox.Size = new System.Drawing.Size(198, 32);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = this.ToolTip;
            // 
            // toolSeparator4
            // 
            this.toolSeparator4.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator4.Name = "toolSeparator4";
            this.toolSeparator4.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator4.Size = new System.Drawing.Size(6, 32);
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
            this.FirstButton.Size = new System.Drawing.Size(26, 28);
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
            this.toolSeparator5.Size = new System.Drawing.Size(6, 32);
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
            this.PreviousButton.Size = new System.Drawing.Size(26, 28);
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
            this.toolSeparator6.Size = new System.Drawing.Size(6, 32);
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
            this.NextButton.Size = new System.Drawing.Size(26, 28);
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
            this.toolSeparator8.Size = new System.Drawing.Size(6, 32);
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
            this.LastButton.Size = new System.Drawing.Size(26, 28);
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
            this.toolSeparator7.Size = new System.Drawing.Size(6, 32);
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
            this.DropDown.Size = new System.Drawing.Size(252, 32);
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
            this.toolSeparator9.Size = new System.Drawing.Size(6, 32);
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
            this.RefreshDataButton.HoverText = "Remove Filters";
            this.RefreshDataButton.Image = global::BudgetExecution.Properties.Resources.RemoveFiltersButton;
            this.RefreshDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshDataButton.Margin = new System.Windows.Forms.Padding(3);
            this.RefreshDataButton.Name = "RefreshDataButton";
            this.RefreshDataButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshDataButton.Size = new System.Drawing.Size(26, 28);
            this.RefreshDataButton.Text = "toolStripButton1";
            this.RefreshDataButton.ToolTip = this.ToolTip;
            this.RefreshDataButton.ToolType = BudgetExecution.ToolType.RemoveFiltersButton;
            // 
            // toolSeparator10
            // 
            this.toolSeparator10.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator10.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator10.Name = "toolSeparator10";
            this.toolSeparator10.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator10.Size = new System.Drawing.Size(6, 32);
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
            this.TableButton.Size = new System.Drawing.Size(26, 28);
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
            this.toolSeparator14.Size = new System.Drawing.Size(6, 32);
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
            this.ExcelButton.Size = new System.Drawing.Size(26, 28);
            this.ExcelButton.Text = "toolStripButton2";
            this.ExcelButton.ToolTip = this.ToolTip;
            this.ExcelButton.ToolType = BudgetExecution.ToolType.ExcelExportButton;
            // 
            // toolSeparator11
            // 
            this.toolSeparator11.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator11.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator11.Name = "toolSeparator11";
            this.toolSeparator11.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator11.Size = new System.Drawing.Size(6, 32);
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
            this.CalendarButton.Size = new System.Drawing.Size(26, 28);
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
            this.toolSeparator12.Size = new System.Drawing.Size(6, 32);
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
            this.CalculatorButton.Size = new System.Drawing.Size(26, 28);
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
            this.toolSeparator13.Size = new System.Drawing.Size(6, 32);
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
            this.BackButton.ToolTip = this.ToolTip;
            this.BackButton.ToolType = BudgetExecution.ToolType.BackButton;
            // 
            // toolSeparator16
            // 
            this.toolSeparator16.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator16.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator16.Name = "toolSeparator16";
            this.toolSeparator16.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator16.Size = new System.Drawing.Size(6, 32);
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
            this.HomeButton.Size = new System.Drawing.Size(26, 28);
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
            this.toolSeparator17.Size = new System.Drawing.Size(6, 32);
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
            this.Chart.DataTable = null;
            this.Chart.Depth = 250F;
            this.Chart.DisplayChartContextMenu = false;
            this.Chart.DisplaySeriesContextMenu = false;
            this.Chart.EnableMouseRotation = true;
            this.Chart.Field = BudgetExecution.Field.AccountCode;
            this.Chart.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chart.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart.Legend.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chart.Legend.ItemsAlignment = System.Drawing.StringAlignment.Center;
            this.Chart.Legend.ItemsSize = new System.Drawing.Size(10, 10);
            this.Chart.Legend.Location = new System.Drawing.Point(864, 86);
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
            this.Chart.Size = new System.Drawing.Size(967, 614);
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
            this.Chart.ToolBar.ButtonSize = new System.Drawing.Size(20, 20);
            this.Chart.ToolBar.ShowBorder = false;
            this.Chart.ToolBar.ShowGrip = false;
            this.Chart.ToolBar.Visible = true;
            this.Chart.VisualTheme = "";
            this.Chart.xAxis = null;
            this.Chart.yValue = null;
            // 
            // FirstPanel
            // 
            this.FirstPanel.BackColor = System.Drawing.Color.Transparent;
            this.FirstPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstPanel.BindingSource = null;
            this.FirstPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.FirstPanel.BorderThickness = 1;
            this.FirstPanel.Children = null;
            this.FirstPanel.Controls.Add(this.FirstListBox);
            this.FirstPanel.DataFilter = null;
            this.FirstPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstPanel.ForeColor = System.Drawing.Color.Transparent;
            this.FirstPanel.HoverText = null;
            this.FirstPanel.IsDerivedStyle = true;
            this.FirstPanel.Location = new System.Drawing.Point(3, 37);
            this.FirstPanel.Name = "FirstPanel";
            this.FirstPanel.Padding = new System.Windows.Forms.Padding(1);
            this.FirstPanel.Size = new System.Drawing.Size(285, 176);
            this.FirstPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstPanel.StyleManager = null;
            this.FirstPanel.TabIndex = 3;
            this.FirstPanel.ThemeAuthor = "Terry D. Eppler";
            this.FirstPanel.ThemeName = "BudgetExecution";
            this.FirstPanel.ToolTip = null;
            // 
            // FirstListBox
            // 
            this.FirstListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FirstListBox.BindingSource = null;
            this.FirstListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.FirstListBox.DataFilter = null;
            this.FirstListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.FirstListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.FirstListBox.HoverText = null;
            this.FirstListBox.IsDerivedStyle = true;
            this.FirstListBox.ItemHeight = 28;
            this.FirstListBox.Location = new System.Drawing.Point(19, 19);
            this.FirstListBox.Margin = new System.Windows.Forms.Padding(1);
            this.FirstListBox.MultiSelect = false;
            this.FirstListBox.Name = "FirstListBox";
            this.FirstListBox.Padding = new System.Windows.Forms.Padding(1);
            this.FirstListBox.SelectedIndex = -1;
            this.FirstListBox.SelectedItem = null;
            this.FirstListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstListBox.SelectedItemColor = System.Drawing.Color.White;
            this.FirstListBox.SelectedText = null;
            this.FirstListBox.SelectedValue = null;
            this.FirstListBox.ShowBorder = false;
            this.FirstListBox.ShowScrollBar = false;
            this.FirstListBox.Size = new System.Drawing.Size(249, 140);
            this.FirstListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstListBox.StyleManager = null;
            this.FirstListBox.TabIndex = 0;
            this.FirstListBox.ThemeAuthor = "Terry D. Eppler";
            this.FirstListBox.ThemeName = "BudgetExecution";
            this.FirstListBox.ToolTip = null;
            // 
            // SecondPanel
            // 
            this.SecondPanel.BackColor = System.Drawing.Color.Transparent;
            this.SecondPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondPanel.BindingSource = null;
            this.SecondPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SecondPanel.BorderThickness = 1;
            this.SecondPanel.Children = null;
            this.SecondPanel.Controls.Add(this.SecondListBox);
            this.SecondPanel.DataFilter = null;
            this.SecondPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPanel.ForeColor = System.Drawing.Color.Transparent;
            this.SecondPanel.HoverText = null;
            this.SecondPanel.IsDerivedStyle = true;
            this.SecondPanel.Location = new System.Drawing.Point(3, 40);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondPanel.Size = new System.Drawing.Size(282, 182);
            this.SecondPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondPanel.StyleManager = null;
            this.SecondPanel.TabIndex = 4;
            this.SecondPanel.ThemeAuthor = "Terry D. Eppler";
            this.SecondPanel.ThemeName = "BudgetExecution";
            this.SecondPanel.ToolTip = null;
            // 
            // SecondListBox
            // 
            this.SecondListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SecondListBox.BindingSource = null;
            this.SecondListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SecondListBox.DataFilter = null;
            this.SecondListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SecondListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.SecondListBox.HoverText = null;
            this.SecondListBox.IsDerivedStyle = true;
            this.SecondListBox.ItemHeight = 28;
            this.SecondListBox.Location = new System.Drawing.Point(19, 14);
            this.SecondListBox.Margin = new System.Windows.Forms.Padding(1);
            this.SecondListBox.MultiSelect = false;
            this.SecondListBox.Name = "SecondListBox";
            this.SecondListBox.Padding = new System.Windows.Forms.Padding(1);
            this.SecondListBox.SelectedIndex = -1;
            this.SecondListBox.SelectedItem = null;
            this.SecondListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondListBox.SelectedItemColor = System.Drawing.Color.White;
            this.SecondListBox.SelectedText = null;
            this.SecondListBox.SelectedValue = null;
            this.SecondListBox.ShowBorder = false;
            this.SecondListBox.ShowScrollBar = false;
            this.SecondListBox.Size = new System.Drawing.Size(246, 150);
            this.SecondListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondListBox.StyleManager = null;
            this.SecondListBox.TabIndex = 0;
            this.SecondListBox.ThemeAuthor = "Terry D. Eppler";
            this.SecondListBox.ThemeName = "BudgetExecution";
            this.SecondListBox.ToolTip = null;
            // 
            // ThirdPanel
            // 
            this.ThirdPanel.BackColor = System.Drawing.Color.Transparent;
            this.ThirdPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdPanel.BindingSource = null;
            this.ThirdPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ThirdPanel.BorderThickness = 1;
            this.ThirdPanel.Children = null;
            this.ThirdPanel.Controls.Add(this.ThirdListBox);
            this.ThirdPanel.DataFilter = null;
            this.ThirdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThirdPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ThirdPanel.HoverText = null;
            this.ThirdPanel.IsDerivedStyle = true;
            this.ThirdPanel.Location = new System.Drawing.Point(3, 34);
            this.ThirdPanel.Name = "ThirdPanel";
            this.ThirdPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdPanel.Size = new System.Drawing.Size(279, 205);
            this.ThirdPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdPanel.StyleManager = null;
            this.ThirdPanel.TabIndex = 5;
            this.ThirdPanel.ThemeAuthor = "Terry D. Eppler";
            this.ThirdPanel.ThemeName = "BudgetExecution";
            this.ThirdPanel.ToolTip = null;
            // 
            // ThirdListBox
            // 
            this.ThirdListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThirdListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ThirdListBox.BindingSource = null;
            this.ThirdListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ThirdListBox.DataFilter = null;
            this.ThirdListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ThirdListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.ThirdListBox.HoverText = null;
            this.ThirdListBox.IsDerivedStyle = true;
            this.ThirdListBox.ItemHeight = 28;
            this.ThirdListBox.Location = new System.Drawing.Point(19, 26);
            this.ThirdListBox.Margin = new System.Windows.Forms.Padding(1);
            this.ThirdListBox.MultiSelect = false;
            this.ThirdListBox.Name = "ThirdListBox";
            this.ThirdListBox.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdListBox.SelectedIndex = -1;
            this.ThirdListBox.SelectedItem = null;
            this.ThirdListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdListBox.SelectedItemColor = System.Drawing.Color.White;
            this.ThirdListBox.SelectedText = null;
            this.ThirdListBox.SelectedValue = null;
            this.ThirdListBox.ShowBorder = false;
            this.ThirdListBox.ShowScrollBar = false;
            this.ThirdListBox.Size = new System.Drawing.Size(240, 165);
            this.ThirdListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdListBox.StyleManager = null;
            this.ThirdListBox.TabIndex = 0;
            this.ThirdListBox.ThemeAuthor = "Terry D. Eppler";
            this.ThirdListBox.ThemeName = "BudgetExecution";
            this.ThirdListBox.ToolTip = null;
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
            this.ChartPanel.Location = new System.Drawing.Point(3, 35);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ChartPanel.Size = new System.Drawing.Size(1006, 654);
            this.ChartPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ChartPanel.StyleManager = null;
            this.ChartPanel.TabIndex = 4;
            this.ChartPanel.ThemeAuthor = "Terry D. Eppler";
            this.ChartPanel.ThemeName = "BudgetExecution";
            this.ChartPanel.ToolTip = null;
            this.ChartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartPanel_Paint);
            // 
            // ChartTable
            // 
            this.ChartTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartTable.ColumnCount = 1;
            this.ChartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ChartTable.Controls.Add(this.ChartPanel, 0, 1);
            this.ChartTable.Controls.Add(this.Header, 0, 0);
            this.ChartTable.Location = new System.Drawing.Point(29, 4);
            this.ChartTable.Name = "ChartTable";
            this.ChartTable.RowCount = 2;
            this.ChartTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.644412F));
            this.ChartTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.35559F));
            this.ChartTable.Size = new System.Drawing.Size(1012, 692);
            this.ChartTable.TabIndex = 5;
            // 
            // Header
            // 
            this.Header.BindingSource = null;
            this.Header.DataFilter = null;
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Header.HoverText = null;
            this.Header.IsDerivedStyle = true;
            this.Header.Location = new System.Drawing.Point(3, 3);
            this.Header.Margin = new System.Windows.Forms.Padding(3);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(1);
            this.Header.Size = new System.Drawing.Size(1006, 26);
            this.Header.Style = MetroSet_UI.Enums.Style.Custom;
            this.Header.StyleManager = null;
            this.Header.TabIndex = 5;
            this.Header.Text = "Chart";
            this.Header.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Header.ThemeAuthor = "Terry D. Eppler";
            this.Header.ThemeName = "BudgetExecution";
            this.Header.ToolTip = null;
            // 
            // FirstFilterTable
            // 
            this.FirstFilterTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstFilterTable.ColumnCount = 1;
            this.FirstFilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FirstFilterTable.Controls.Add(this.FirstPanel, 0, 1);
            this.FirstFilterTable.Controls.Add(this.comboBox1, 0, 0);
            this.FirstFilterTable.Location = new System.Drawing.Point(1068, 5);
            this.FirstFilterTable.Name = "FirstFilterTable";
            this.FirstFilterTable.RowCount = 2;
            this.FirstFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.FirstFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.FirstFilterTable.Size = new System.Drawing.Size(291, 215);
            this.FirstFilterTable.TabIndex = 6;
            // 
            // SecondFilterTable
            // 
            this.SecondFilterTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondFilterTable.ColumnCount = 1;
            this.SecondFilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SecondFilterTable.Controls.Add(this.comboBox2, 0, 0);
            this.SecondFilterTable.Controls.Add(this.SecondPanel, 0, 1);
            this.SecondFilterTable.Location = new System.Drawing.Point(1071, 223);
            this.SecondFilterTable.Name = "SecondFilterTable";
            this.SecondFilterTable.RowCount = 2;
            this.SecondFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.SecondFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.SecondFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SecondFilterTable.Size = new System.Drawing.Size(288, 225);
            this.SecondFilterTable.TabIndex = 7;
            // 
            // ThirdFilterTable
            // 
            this.ThirdFilterTable.ColumnCount = 1;
            this.ThirdFilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ThirdFilterTable.Controls.Add(this.comboBox3, 0, 0);
            this.ThirdFilterTable.Controls.Add(this.ThirdPanel, 0, 1);
            this.ThirdFilterTable.Location = new System.Drawing.Point(1071, 454);
            this.ThirdFilterTable.Name = "ThirdFilterTable";
            this.ThirdFilterTable.RowCount = 2;
            this.ThirdFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.ThirdFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.ThirdFilterTable.Size = new System.Drawing.Size(285, 242);
            this.ThirdFilterTable.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.comboBox1.BackColor = System.Drawing.Color.Transparent;
            this.comboBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox1.BindingSource = null;
            this.comboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DataFilter = null;
            this.comboBox1.DisabledBackColor = System.Drawing.Color.Transparent;
            this.comboBox1.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.comboBox1.DisabledForeColor = System.Drawing.Color.Transparent;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.HoverText = null;
            this.comboBox1.IsDerivedStyle = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.comboBox1.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboBox1.Size = new System.Drawing.Size(285, 30);
            this.comboBox1.Style = MetroSet_UI.Enums.Style.Custom;
            this.comboBox1.StyleManager = null;
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ThemeAuthor = "Terry D. Eppler";
            this.comboBox1.ThemeName = "Budget Execution";
            this.comboBox1.ToolTip = null;
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.comboBox2.BackColor = System.Drawing.Color.Transparent;
            this.comboBox2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox2.BindingSource = null;
            this.comboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.comboBox2.CausesValidation = false;
            this.comboBox2.DataFilter = null;
            this.comboBox2.DisabledBackColor = System.Drawing.Color.Transparent;
            this.comboBox2.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.comboBox2.DisabledForeColor = System.Drawing.Color.Transparent;
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.HoverText = null;
            this.comboBox2.IsDerivedStyle = true;
            this.comboBox2.ItemHeight = 24;
            this.comboBox2.Location = new System.Drawing.Point(3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.comboBox2.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboBox2.Size = new System.Drawing.Size(282, 30);
            this.comboBox2.Style = MetroSet_UI.Enums.Style.Custom;
            this.comboBox2.StyleManager = null;
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ThemeAuthor = "Terry D. Eppler";
            this.comboBox2.ThemeName = "Budget Execution";
            this.comboBox2.ToolTip = null;
            // 
            // comboBox3
            // 
            this.comboBox3.AllowDrop = true;
            this.comboBox3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.comboBox3.BackColor = System.Drawing.Color.Transparent;
            this.comboBox3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox3.BindingSource = null;
            this.comboBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.comboBox3.CausesValidation = false;
            this.comboBox3.DataFilter = null;
            this.comboBox3.DisabledBackColor = System.Drawing.Color.Transparent;
            this.comboBox3.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.comboBox3.DisabledForeColor = System.Drawing.Color.Transparent;
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.HoverText = null;
            this.comboBox3.IsDerivedStyle = true;
            this.comboBox3.ItemHeight = 24;
            this.comboBox3.Location = new System.Drawing.Point(3, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.comboBox3.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboBox3.Size = new System.Drawing.Size(279, 30);
            this.comboBox3.Style = MetroSet_UI.Enums.Style.Custom;
            this.comboBox3.StyleManager = null;
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ThemeAuthor = "Terry D. Eppler";
            this.comboBox3.ThemeName = "Budget Execution";
            this.comboBox3.ToolTip = null;
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
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1388, 764);
            this.Controls.Add(this.ThirdFilterTable);
            this.Controls.Add(this.SecondFilterTable);
            this.Controls.Add(this.FirstFilterTable);
            this.Controls.Add(this.ChartTable);
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
            this.FirstPanel.ResumeLayout(false);
            this.SecondPanel.ResumeLayout(false);
            this.ThirdPanel.ResumeLayout(false);
            this.ChartPanel.ResumeLayout(false);
            this.ChartTable.ResumeLayout(false);
            this.FirstFilterTable.ResumeLayout(false);
            this.SecondFilterTable.ResumeLayout(false);
            this.ThirdFilterTable.ResumeLayout(false);
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
        public Layout FirstPanel;
        public ListBox FirstListBox;
        public Layout SecondPanel;
        public ListBox SecondListBox;
        public Layout ThirdPanel;
        public ListBox ThirdListBox;
        private Layout ChartPanel;
        public ToolStripButton BackButton;
        private ToolSeparator toolSeparator17;
        private System.Windows.Forms.TableLayoutPanel ChartTable;
        private Label Header;
        private System.Windows.Forms.TableLayoutPanel FirstFilterTable;
        private System.Windows.Forms.TableLayoutPanel SecondFilterTable;
        private System.Windows.Forms.TableLayoutPanel ThirdFilterTable;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}
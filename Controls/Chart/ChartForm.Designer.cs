﻿namespace BudgetExecution
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
            this.HomeButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator15 = new BudgetExecution.ToolSeparator();
            this.LogoutButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator16 = new BudgetExecution.ToolSeparator();
            this.Chart = new BudgetExecution.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.ToolStrip.SuspendLayout();
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
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 18);
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
            this.HomeButton,
            this.toolSeparator15,
            this.LogoutButton,
            this.toolSeparator16});
            this.ToolStrip.Label = null;
            this.ToolStrip.LastButton = null;
            this.ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.ToolStrip.Location = new System.Drawing.Point(0, 715);
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
            this.ToolStrip.Size = new System.Drawing.Size(1388, 48);
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
            this.toolSeparator2.Size = new System.Drawing.Size(6, 30);
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
            this.Label.Size = new System.Drawing.Size(75, 30);
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
            this.toolSeparator1.Size = new System.Drawing.Size(6, 30);
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
            this.LookupButton.Size = new System.Drawing.Size(26, 26);
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
            this.toolSeparator3.Size = new System.Drawing.Size(6, 30);
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
            this.TextBox.Size = new System.Drawing.Size(169, 30);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = this.ToolTip;
            // 
            // toolSeparator4
            // 
            this.toolSeparator4.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator4.Name = "toolSeparator4";
            this.toolSeparator4.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator4.Size = new System.Drawing.Size(6, 30);
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
            this.FirstButton.Size = new System.Drawing.Size(26, 26);
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
            this.toolSeparator5.Size = new System.Drawing.Size(6, 30);
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
            this.PreviousButton.Size = new System.Drawing.Size(26, 26);
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
            this.toolSeparator6.Size = new System.Drawing.Size(6, 30);
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
            this.NextButton.Size = new System.Drawing.Size(26, 26);
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
            this.toolSeparator8.Size = new System.Drawing.Size(6, 30);
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
            this.LastButton.Size = new System.Drawing.Size(26, 26);
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
            this.toolSeparator7.Size = new System.Drawing.Size(6, 30);
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
            this.DropDown.Size = new System.Drawing.Size(198, 30);
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
            this.toolSeparator9.Size = new System.Drawing.Size(6, 30);
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
            this.RefreshDataButton.Size = new System.Drawing.Size(26, 26);
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
            this.toolSeparator10.Size = new System.Drawing.Size(6, 30);
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
            this.TableButton.Size = new System.Drawing.Size(26, 26);
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
            this.toolSeparator14.Size = new System.Drawing.Size(6, 30);
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
            this.ExcelButton.Size = new System.Drawing.Size(26, 26);
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
            this.toolSeparator11.Size = new System.Drawing.Size(6, 30);
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
            this.CalendarButton.Size = new System.Drawing.Size(26, 26);
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
            this.toolSeparator12.Size = new System.Drawing.Size(6, 30);
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
            this.CalculatorButton.Size = new System.Drawing.Size(26, 26);
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
            this.toolSeparator13.Size = new System.Drawing.Size(6, 30);
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
            this.HomeButton.Size = new System.Drawing.Size(26, 26);
            this.HomeButton.Text = "toolStripButton1";
            this.HomeButton.ToolTip = this.ToolTip;
            this.HomeButton.ToolType = BudgetExecution.ToolType.HomeButton;
            // 
            // toolSeparator15
            // 
            this.toolSeparator15.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator15.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator15.Name = "toolSeparator15";
            this.toolSeparator15.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator15.Size = new System.Drawing.Size(6, 30);
            // 
            // LogoutButton
            // 
            this.LogoutButton.AutoToolTip = false;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BindingSource = this.BindingSource;
            this.LogoutButton.DataFilter = null;
            this.LogoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogoutButton.Field = BudgetExecution.Field.AccountCode;
            this.LogoutButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.ForeColor = System.Drawing.Color.LightGray;
            this.LogoutButton.HoverText = "Exit Application";
            this.LogoutButton.Image = global::BudgetExecution.Properties.Resources.LogoutButton;
            this.LogoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(1);
            this.LogoutButton.Size = new System.Drawing.Size(26, 26);
            this.LogoutButton.Text = "toolStripButton2";
            this.LogoutButton.ToolTip = this.ToolTip;
            this.LogoutButton.ToolType = BudgetExecution.ToolType.LogoutButton;
            // 
            // toolSeparator16
            // 
            this.toolSeparator16.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator16.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator16.Name = "toolSeparator16";
            this.toolSeparator16.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator16.Size = new System.Drawing.Size(6, 30);
            // 
            // Chart
            // 
            this.Chart.AllowGradientPalette = true;
            this.Chart.AllowUserEditStyles = true;
            this.Chart.AutoHighlight = true;
            this.Chart.BindingModel = null;
            this.Chart.BindingSource = this.BindingSource;
            this.Chart.ChartArea.AutoScale = true;
            this.Chart.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.Chart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart.ChartArea.CursorReDraw = false;
            this.Chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(3, 3, 3, 3);
            this.Chart.DataFilter = null;
            this.Chart.DataMetric = null;
            this.Chart.DataSeries = null;
            this.Chart.DataSource = null;
            this.Chart.DataValues = null;
            this.Chart.Depth = 250F;
            this.Chart.DisplayChartContextMenu = false;
            this.Chart.DisplaySeriesContextMenu = false;
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart.EnableMouseRotation = true;
            this.Chart.Field = BudgetExecution.Field.AccountCode;
            this.Chart.HoverText = null;
            this.Chart.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart.Legend.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chart.Legend.ItemsAlignment = System.Drawing.StringAlignment.Center;
            this.Chart.Legend.ItemsSize = new System.Drawing.Size(10, 10);
            this.Chart.Legend.Location = new System.Drawing.Point(1285, 94);
            this.Chart.Legend.ShowItemsShadow = true;
            this.Chart.Legend.ShowSymbol = true;
            this.Chart.Legend.VisibleCheckBox = true;
            this.Chart.Localize = null;
            this.Chart.Location = new System.Drawing.Point(0, 0);
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
            this.Chart.Size = new System.Drawing.Size(1388, 715);
            this.Chart.Source = BudgetExecution.Source.External;
            this.Chart.Spacing = 5F;
            this.Chart.SpacingBetweenPoints = 5F;
            this.Chart.Stat = BudgetExecution.STAT.NS;
            this.Chart.Style3D = true;
            this.Chart.TabIndex = 1;
            this.Chart.TableName = null;
            this.Chart.Text = "chart1";
            this.Chart.Tilt = 5F;
            // 
            // 
            // 
            this.Chart.Title.Name = "Default";
            this.Chart.Titles.Add(this.Chart.Title);
            this.Chart.ToolBar.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Chart.ToolBar.ShowBorder = false;
            this.Chart.ToolBar.ShowGrip = false;
            this.Chart.ToolBar.Visible = true;
            this.Chart.ToolTip = null;
            this.Chart.VisualTheme = "";
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
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1388, 763);
            this.Controls.Add(this.Chart);
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
        public ToolStripButton LogoutButton;
        private ToolSeparator toolSeparator16;
    }
}
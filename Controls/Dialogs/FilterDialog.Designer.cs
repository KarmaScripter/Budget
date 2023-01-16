// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class FilterDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterDialog));
            this.FirstTable = new System.Windows.Forms.TableLayoutPanel();
            this.FirstPanel = new BudgetExecution.Layout();
            this.FirstListBox = new BudgetExecution.ListBox();
            this.FirstLabel = new BudgetExecution.Label();
            this.FirstComboBox = new BudgetExecution.ComboBox();
            this.ThirdTable = new System.Windows.Forms.TableLayoutPanel();
            this.ThirdLabel = new BudgetExecution.Label();
            this.ThirdComboBox = new BudgetExecution.ComboBox();
            this.ThirdPanel = new BudgetExecution.Layout();
            this.ThirdListBox = new BudgetExecution.ListBox();
            this.FirstButton = new BudgetExecution.Button();
            this.SecondButton = new BudgetExecution.Button();
            this.ThirdButton = new BudgetExecution.Button();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.TabControl = new BudgetExecution.TabControl();
            this.TableTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new BudgetExecution.Label();
            this.ProviderTable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new BudgetExecution.Label();
            this.ProviderPanel = new BudgetExecution.Layout();
            this.SqlCeRadioButton = new BudgetExecution.RadioButton();
            this.AccessRadioButton = new BudgetExecution.RadioButton();
            this.SqlServerRadioButton = new BudgetExecution.RadioButton();
            this.SQLiteRadioButton = new BudgetExecution.RadioButton();
            this.SourceTable = new System.Windows.Forms.TableLayoutPanel();
            this.TableLabel = new BudgetExecution.Label();
            this.TablePanel = new BudgetExecution.Layout();
            this.TableListBox = new BudgetExecution.ListBox();
            this.CalendarTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.CalendarDataPanel = new BudgetExecution.Layout();
            this.TimeLabelTable = new System.Windows.Forms.TableLayoutPanel();
            this.TimeLabel1 = new BudgetExecution.Label();
            this.TimeLabel2 = new BudgetExecution.Label();
            this.TimeLabel3 = new BudgetExecution.Label();
            this.TimeLabel4 = new BudgetExecution.Label();
            this.TimeLabel5 = new BudgetExecution.Label();
            this.TimeLabel6 = new BudgetExecution.Label();
            this.TimeLabel7 = new BudgetExecution.Label();
            this.SecondCalendarPanel = new BudgetExecution.Layout();
            this.SecondCalendarTable = new System.Windows.Forms.TableLayoutPanel();
            this.SecondCalendarLabel = new BudgetExecution.Label();
            this.SeondCalendar = new Syncfusion.WinForms.Input.SfCalendar();
            this.DateSelectionPanel = new BudgetExecution.Layout();
            this.FirstCalendarTable = new System.Windows.Forms.TableLayoutPanel();
            this.FirstCalendar = new Syncfusion.WinForms.Input.SfCalendar();
            this.FirstCalendarLabel = new BudgetExecution.Label();
            this.FilterTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new BudgetExecution.Label();
            this.comboBox1 = new BudgetExecution.ComboBox();
            this.SecondTable = new System.Windows.Forms.TableLayoutPanel();
            this.SecondLabel = new BudgetExecution.Label();
            this.SecondComboBox = new BudgetExecution.ComboBox();
            this.SecondPanel = new BudgetExecution.Layout();
            this.SecondListBox = new BudgetExecution.ListBox();
            this.ReferencePanel = new BudgetExecution.Layout();
            this.ReferenceListBox = new BudgetExecution.ListBox();
            this.FirstTable.SuspendLayout();
            this.FirstPanel.SuspendLayout();
            this.ThirdTable.SuspendLayout();
            this.ThirdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TableTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ProviderTable.SuspendLayout();
            this.ProviderPanel.SuspendLayout();
            this.SourceTable.SuspendLayout();
            this.TablePanel.SuspendLayout();
            this.CalendarTabPage.SuspendLayout();
            this.CalendarDataPanel.SuspendLayout();
            this.TimeLabelTable.SuspendLayout();
            this.SecondCalendarPanel.SuspendLayout();
            this.SecondCalendarTable.SuspendLayout();
            this.DateSelectionPanel.SuspendLayout();
            this.FirstCalendarTable.SuspendLayout();
            this.FilterTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SecondTable.SuspendLayout();
            this.SecondPanel.SuspendLayout();
            this.ReferencePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstTable
            // 
            this.FirstTable.ColumnCount = 1;
            this.FirstTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FirstTable.Controls.Add(this.FirstPanel, 0, 2);
            this.FirstTable.Controls.Add(this.FirstLabel, 0, 0);
            this.FirstTable.Controls.Add(this.FirstComboBox, 0, 1);
            this.FirstTable.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.FirstTable.Location = new System.Drawing.Point(12, 5);
            this.FirstTable.Name = "FirstTable";
            this.FirstTable.RowCount = 3;
            this.FirstTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.FirstTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.FirstTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.FirstTable.Size = new System.Drawing.Size(245, 366);
            this.FirstTable.TabIndex = 5;
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
            this.FirstPanel.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstPanel.ForeColor = System.Drawing.Color.Transparent;
            this.FirstPanel.HoverText = null;
            this.FirstPanel.IsDerivedStyle = true;
            this.FirstPanel.Location = new System.Drawing.Point(3, 61);
            this.FirstPanel.Name = "FirstPanel";
            this.FirstPanel.Padding = new System.Windows.Forms.Padding(1);
            this.FirstPanel.Size = new System.Drawing.Size(239, 302);
            this.FirstPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstPanel.StyleManager = null;
            this.FirstPanel.TabIndex = 2;
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
            this.FirstListBox.Location = new System.Drawing.Point(18, 19);
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
            this.FirstListBox.Size = new System.Drawing.Size(201, 261);
            this.FirstListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstListBox.StyleManager = null;
            this.FirstListBox.TabIndex = 0;
            this.FirstListBox.ThemeAuthor = "Terry D. Eppler";
            this.FirstListBox.ThemeName = "BudgetExecution";
            this.FirstListBox.ToolTip = null;
            // 
            // FirstLabel
            // 
            this.FirstLabel.BindingSource = null;
            this.FirstLabel.DataFilter = null;
            this.FirstLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstLabel.HoverText = null;
            this.FirstLabel.IsDerivedStyle = true;
            this.FirstLabel.Location = new System.Drawing.Point(3, 3);
            this.FirstLabel.Margin = new System.Windows.Forms.Padding(3);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Padding = new System.Windows.Forms.Padding(1);
            this.FirstLabel.Size = new System.Drawing.Size(239, 18);
            this.FirstLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstLabel.StyleManager = null;
            this.FirstLabel.TabIndex = 0;
            this.FirstLabel.Text = "First Category";
            this.FirstLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.FirstLabel.ThemeAuthor = "Terry D. Eppler";
            this.FirstLabel.ThemeName = "BudgetExecution";
            this.FirstLabel.ToolTip = null;
            // 
            // FirstComboBox
            // 
            this.FirstComboBox.AllowDrop = true;
            this.FirstComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FirstComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstComboBox.BindingSource = null;
            this.FirstComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.FirstComboBox.CausesValidation = false;
            this.FirstComboBox.DataFilter = null;
            this.FirstComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            this.FirstComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.FirstComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            this.FirstComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FirstComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstComboBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstComboBox.FormattingEnabled = true;
            this.FirstComboBox.HoverText = "Select First Category";
            this.FirstComboBox.IsDerivedStyle = true;
            this.FirstComboBox.ItemHeight = 24;
            this.FirstComboBox.Location = new System.Drawing.Point(3, 27);
            this.FirstComboBox.MaxDropDownItems = 60;
            this.FirstComboBox.Name = "FirstComboBox";
            this.FirstComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.FirstComboBox.Size = new System.Drawing.Size(239, 30);
            this.FirstComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstComboBox.StyleManager = null;
            this.FirstComboBox.TabIndex = 1;
            this.FirstComboBox.ThemeAuthor = "Terry D. Eppler";
            this.FirstComboBox.ThemeName = "BudgetExecution";
            this.FirstComboBox.ToolTip = null;
            // 
            // ThirdTable
            // 
            this.ThirdTable.ColumnCount = 1;
            this.ThirdTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ThirdTable.Controls.Add(this.ThirdLabel, 0, 0);
            this.ThirdTable.Controls.Add(this.ThirdComboBox, 0, 1);
            this.ThirdTable.Controls.Add(this.ThirdPanel, 0, 2);
            this.ThirdTable.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ThirdTable.Location = new System.Drawing.Point(541, 5);
            this.ThirdTable.Name = "ThirdTable";
            this.ThirdTable.RowCount = 3;
            this.ThirdTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.ThirdTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.ThirdTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.ThirdTable.Size = new System.Drawing.Size(245, 366);
            this.ThirdTable.TabIndex = 7;
            // 
            // ThirdLabel
            // 
            this.ThirdLabel.BindingSource = null;
            this.ThirdLabel.DataFilter = null;
            this.ThirdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThirdLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThirdLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdLabel.HoverText = null;
            this.ThirdLabel.IsDerivedStyle = true;
            this.ThirdLabel.Location = new System.Drawing.Point(3, 3);
            this.ThirdLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ThirdLabel.Name = "ThirdLabel";
            this.ThirdLabel.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdLabel.Size = new System.Drawing.Size(239, 18);
            this.ThirdLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdLabel.StyleManager = null;
            this.ThirdLabel.TabIndex = 0;
            this.ThirdLabel.Text = "Third Category";
            this.ThirdLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ThirdLabel.ThemeAuthor = "Terry D. Eppler";
            this.ThirdLabel.ThemeName = "BudgetExecution";
            this.ThirdLabel.ToolTip = null;
            // 
            // ThirdComboBox
            // 
            this.ThirdComboBox.AllowDrop = true;
            this.ThirdComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ThirdComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdComboBox.BindingSource = null;
            this.ThirdComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ThirdComboBox.CausesValidation = false;
            this.ThirdComboBox.DataFilter = null;
            this.ThirdComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            this.ThirdComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.ThirdComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            this.ThirdComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThirdComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ThirdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThirdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThirdComboBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdComboBox.FormattingEnabled = true;
            this.ThirdComboBox.HoverText = "Select Third Category";
            this.ThirdComboBox.IsDerivedStyle = true;
            this.ThirdComboBox.ItemHeight = 24;
            this.ThirdComboBox.Location = new System.Drawing.Point(3, 27);
            this.ThirdComboBox.MaxDropDownItems = 60;
            this.ThirdComboBox.Name = "ThirdComboBox";
            this.ThirdComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.ThirdComboBox.Size = new System.Drawing.Size(239, 30);
            this.ThirdComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdComboBox.StyleManager = null;
            this.ThirdComboBox.TabIndex = 1;
            this.ThirdComboBox.ThemeAuthor = "Terry D. Eppler";
            this.ThirdComboBox.ThemeName = "BudgetExecution";
            this.ThirdComboBox.ToolTip = null;
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
            this.ThirdPanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ThirdPanel.HoverText = null;
            this.ThirdPanel.IsDerivedStyle = true;
            this.ThirdPanel.Location = new System.Drawing.Point(3, 61);
            this.ThirdPanel.Name = "ThirdPanel";
            this.ThirdPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdPanel.Size = new System.Drawing.Size(239, 302);
            this.ThirdPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdPanel.StyleManager = null;
            this.ThirdPanel.TabIndex = 2;
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
            this.ThirdListBox.Location = new System.Drawing.Point(18, 19);
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
            this.ThirdListBox.Size = new System.Drawing.Size(199, 261);
            this.ThirdListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdListBox.StyleManager = null;
            this.ThirdListBox.TabIndex = 0;
            this.ThirdListBox.ThemeAuthor = "Terry D. Eppler";
            this.ThirdListBox.ThemeName = "BudgetExecution";
            this.ThirdListBox.ToolTip = null;
            // 
            // FirstButton
            // 
            this.FirstButton.BindingSource = null;
            this.FirstButton.DataFilter = null;
            this.FirstButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.FirstButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.FirstButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.FirstButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.FirstButton.HoverText = null;
            this.FirstButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.FirstButton.IsDerivedStyle = true;
            this.FirstButton.Location = new System.Drawing.Point(58, 474);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.FirstButton.NormalColor = System.Drawing.Color.Transparent;
            this.FirstButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.Padding = new System.Windows.Forms.Padding(1);
            this.FirstButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.PressTextColor = System.Drawing.Color.White;
            this.FirstButton.Size = new System.Drawing.Size(235, 53);
            this.FirstButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstButton.StyleManager = null;
            this.FirstButton.TabIndex = 9;
            this.FirstButton.Text = "Clear";
            this.FirstButton.ThemeAuthor = "Terry D. Eppler";
            this.FirstButton.ThemeName = "BudgetExecution";
            this.FirstButton.ToolTip = null;
            // 
            // SecondButton
            // 
            this.SecondButton.BindingSource = null;
            this.SecondButton.DataFilter = null;
            this.SecondButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.SecondButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.SecondButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.SecondButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SecondButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SecondButton.HoverText = null;
            this.SecondButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.SecondButton.IsDerivedStyle = true;
            this.SecondButton.Location = new System.Drawing.Point(408, 474);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.SecondButton.NormalColor = System.Drawing.Color.Transparent;
            this.SecondButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.Padding = new System.Windows.Forms.Padding(1);
            this.SecondButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.PressTextColor = System.Drawing.Color.White;
            this.SecondButton.Size = new System.Drawing.Size(235, 53);
            this.SecondButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondButton.StyleManager = null;
            this.SecondButton.TabIndex = 10;
            this.SecondButton.Text = "Select";
            this.SecondButton.ThemeAuthor = "Terry D. Eppler";
            this.SecondButton.ThemeName = "BudgetExecution";
            this.SecondButton.ToolTip = null;
            // 
            // ThirdButton
            // 
            this.ThirdButton.BindingSource = null;
            this.ThirdButton.DataFilter = null;
            this.ThirdButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.ThirdButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.ThirdButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.ThirdButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ThirdButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ThirdButton.HoverText = null;
            this.ThirdButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.ThirdButton.IsDerivedStyle = true;
            this.ThirdButton.Location = new System.Drawing.Point(774, 474);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.ThirdButton.NormalColor = System.Drawing.Color.Transparent;
            this.ThirdButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.PressTextColor = System.Drawing.Color.White;
            this.ThirdButton.Size = new System.Drawing.Size(252, 53);
            this.ThirdButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdButton.StyleManager = null;
            this.ThirdButton.TabIndex = 11;
            this.ThirdButton.Text = "Close";
            this.ThirdButton.ThemeAuthor = "Terry D. Eppler";
            this.ThirdButton.ThemeName = "BudgetExecution";
            this.ThirdButton.ToolTip = null;
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
            // TabControl
            // 
            this.TabControl.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ActiveTabFont = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.BeforeTouchSize = new System.Drawing.Size(1068, 441);
            this.TabControl.BindingSource = null;
            this.TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabControl.CanOverrideStyle = true;
            this.TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.Controls.Add(this.TableTabPage);
            this.TabControl.Controls.Add(this.CalendarTabPage);
            this.TabControl.Controls.Add(this.FilterTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.FocusOnTabClick = false;
            this.TabControl.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.ForeColor = System.Drawing.Color.LightGray;
            this.TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ItemSize = new System.Drawing.Size(100, 30);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Size = new System.Drawing.Size(1068, 441);
            this.TabControl.TabIndex = 12;
            this.TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.TabControl.ThemeName = "TabRendererMetro";
            this.TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            this.TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TabControl.ThemeStyle.TabStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ToolTip = null;
            // 
            // TableTabPage
            // 
            this.TableTabPage.Controls.Add(this.tableLayoutPanel1);
            this.TableTabPage.Controls.Add(this.ProviderTable);
            this.TableTabPage.Controls.Add(this.SourceTable);
            this.TableTabPage.Image = null;
            this.TableTabPage.ImageSize = new System.Drawing.Size(16, 16);
            this.TableTabPage.Location = new System.Drawing.Point(0, 29);
            this.TableTabPage.Name = "TableTabPage";
            this.TableTabPage.ShowCloseButton = true;
            this.TableTabPage.Size = new System.Drawing.Size(1068, 412);
            this.TableTabPage.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TableTabPage.TabFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableTabPage.TabIndex = 2;
            this.TableTabPage.ThemesEnabled = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ReferencePanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(752, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 357);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BindingSource = null;
            this.label1.DataFilter = null;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.HoverText = null;
            this.label1.IsDerivedStyle = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(272, 18);
            this.label1.Style = MetroSet_UI.Enums.Style.Custom;
            this.label1.StyleManager = null;
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference Tables";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.ThemeAuthor = "Terry D. Eppler";
            this.label1.ThemeName = "BudgetExecution";
            this.label1.ToolTip = null;
            // 
            // ProviderTable
            // 
            this.ProviderTable.ColumnCount = 1;
            this.ProviderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProviderTable.Controls.Add(this.label2, 0, 0);
            this.ProviderTable.Controls.Add(this.ProviderPanel, 0, 1);
            this.ProviderTable.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderTable.ForeColor = System.Drawing.Color.DarkGray;
            this.ProviderTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ProviderTable.Location = new System.Drawing.Point(33, 5);
            this.ProviderTable.Name = "ProviderTable";
            this.ProviderTable.RowCount = 2;
            this.ProviderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.ProviderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.ProviderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ProviderTable.Size = new System.Drawing.Size(278, 357);
            this.ProviderTable.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BindingSource = null;
            this.label2.DataFilter = null;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.HoverText = null;
            this.label2.IsDerivedStyle = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(272, 18);
            this.label2.Style = MetroSet_UI.Enums.Style.Custom;
            this.label2.StyleManager = null;
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Provider";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.ThemeAuthor = "Terry D. Eppler";
            this.label2.ThemeName = "BudgetExecution";
            this.label2.ToolTip = null;
            // 
            // ProviderPanel
            // 
            this.ProviderPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProviderPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ProviderPanel.BindingSource = null;
            this.ProviderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ProviderPanel.BorderThickness = 1;
            this.ProviderPanel.Children = null;
            this.ProviderPanel.Controls.Add(this.SqlCeRadioButton);
            this.ProviderPanel.Controls.Add(this.AccessRadioButton);
            this.ProviderPanel.Controls.Add(this.SqlServerRadioButton);
            this.ProviderPanel.Controls.Add(this.SQLiteRadioButton);
            this.ProviderPanel.DataFilter = null;
            this.ProviderPanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ProviderPanel.HoverText = null;
            this.ProviderPanel.IsDerivedStyle = true;
            this.ProviderPanel.Location = new System.Drawing.Point(3, 27);
            this.ProviderPanel.Name = "ProviderPanel";
            this.ProviderPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ProviderPanel.Size = new System.Drawing.Size(272, 327);
            this.ProviderPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ProviderPanel.StyleManager = null;
            this.ProviderPanel.TabIndex = 2;
            this.ProviderPanel.ThemeAuthor = "Terry D. Eppler";
            this.ProviderPanel.ThemeName = "BudgetExecution";
            this.ProviderPanel.ToolTip = null;
            // 
            // SqlCeRadioButton
            // 
            this.SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqlCeRadioButton.Checked = false;
            this.SqlCeRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            this.SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.SqlCeRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqlCeRadioButton.Group = 0;
            this.SqlCeRadioButton.HoverText = null;
            this.SqlCeRadioButton.IsDerivedStyle = true;
            this.SqlCeRadioButton.Location = new System.Drawing.Point(78, 110);
            this.SqlCeRadioButton.Name = "SqlCeRadioButton";
            this.SqlCeRadioButton.Result = null;
            this.SqlCeRadioButton.Size = new System.Drawing.Size(125, 17);
            this.SqlCeRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SqlCeRadioButton.StyleManager = null;
            this.SqlCeRadioButton.TabIndex = 3;
            this.SqlCeRadioButton.Tag = "SqlCe";
            this.SqlCeRadioButton.Text = "  SQL Compact";
            this.SqlCeRadioButton.ThemeAuthor = "Terry D. Eppler";
            this.SqlCeRadioButton.ThemeName = "Budget Execution";
            this.SqlCeRadioButton.ToolTip = this.ToolTip;
            // 
            // AccessRadioButton
            // 
            this.AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AccessRadioButton.Checked = false;
            this.AccessRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            this.AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.AccessRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccessRadioButton.Group = 0;
            this.AccessRadioButton.HoverText = null;
            this.AccessRadioButton.IsDerivedStyle = true;
            this.AccessRadioButton.Location = new System.Drawing.Point(78, 205);
            this.AccessRadioButton.Name = "AccessRadioButton";
            this.AccessRadioButton.Result = null;
            this.AccessRadioButton.Size = new System.Drawing.Size(125, 17);
            this.AccessRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.AccessRadioButton.StyleManager = null;
            this.AccessRadioButton.TabIndex = 2;
            this.AccessRadioButton.Tag = "Access";
            this.AccessRadioButton.Text = "  MS Access";
            this.AccessRadioButton.ThemeAuthor = "Terry D. Eppler";
            this.AccessRadioButton.ThemeName = "Budget Execution";
            this.AccessRadioButton.ToolTip = this.ToolTip;
            // 
            // SqlServerRadioButton
            // 
            this.SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqlServerRadioButton.Checked = false;
            this.SqlServerRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            this.SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.SqlServerRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqlServerRadioButton.Group = 0;
            this.SqlServerRadioButton.HoverText = null;
            this.SqlServerRadioButton.IsDerivedStyle = true;
            this.SqlServerRadioButton.Location = new System.Drawing.Point(78, 156);
            this.SqlServerRadioButton.Name = "SqlServerRadioButton";
            this.SqlServerRadioButton.Result = null;
            this.SqlServerRadioButton.Size = new System.Drawing.Size(125, 17);
            this.SqlServerRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SqlServerRadioButton.StyleManager = null;
            this.SqlServerRadioButton.TabIndex = 1;
            this.SqlServerRadioButton.Tag = "SqlServer";
            this.SqlServerRadioButton.Text = "  SQL Server";
            this.SqlServerRadioButton.ThemeAuthor = "Terry D. Eppler";
            this.SqlServerRadioButton.ThemeName = "Budget Execution";
            this.SqlServerRadioButton.ToolTip = this.ToolTip;
            // 
            // SQLiteRadioButton
            // 
            this.SQLiteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SQLiteRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SQLiteRadioButton.Checked = false;
            this.SQLiteRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            this.SQLiteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.SQLiteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.SQLiteRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SQLiteRadioButton.Group = 0;
            this.SQLiteRadioButton.HoverText = null;
            this.SQLiteRadioButton.IsDerivedStyle = true;
            this.SQLiteRadioButton.Location = new System.Drawing.Point(78, 64);
            this.SQLiteRadioButton.Name = "SQLiteRadioButton";
            this.SQLiteRadioButton.Result = null;
            this.SQLiteRadioButton.Size = new System.Drawing.Size(125, 17);
            this.SQLiteRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SQLiteRadioButton.StyleManager = null;
            this.SQLiteRadioButton.TabIndex = 0;
            this.SQLiteRadioButton.Tag = "SQLite";
            this.SQLiteRadioButton.Text = "  SQLite";
            this.SQLiteRadioButton.ThemeAuthor = "Terry D. Eppler";
            this.SQLiteRadioButton.ThemeName = "Budget Execution";
            this.SQLiteRadioButton.ToolTip = this.ToolTip;
            // 
            // SourceTable
            // 
            this.SourceTable.ColumnCount = 1;
            this.SourceTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SourceTable.Controls.Add(this.TableLabel, 0, 0);
            this.SourceTable.Controls.Add(this.TablePanel, 0, 1);
            this.SourceTable.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.SourceTable.Location = new System.Drawing.Point(385, 5);
            this.SourceTable.Name = "SourceTable";
            this.SourceTable.RowCount = 2;
            this.SourceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.SourceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.SourceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SourceTable.Size = new System.Drawing.Size(278, 357);
            this.SourceTable.TabIndex = 7;
            // 
            // TableLabel
            // 
            this.TableLabel.BindingSource = null;
            this.TableLabel.DataFilter = null;
            this.TableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableLabel.HoverText = null;
            this.TableLabel.IsDerivedStyle = true;
            this.TableLabel.Location = new System.Drawing.Point(3, 3);
            this.TableLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Padding = new System.Windows.Forms.Padding(1);
            this.TableLabel.Size = new System.Drawing.Size(272, 18);
            this.TableLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.TableLabel.StyleManager = null;
            this.TableLabel.TabIndex = 0;
            this.TableLabel.Text = "Data Tables";
            this.TableLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TableLabel.ThemeAuthor = "Terry D. Eppler";
            this.TableLabel.ThemeName = "BudgetExecution";
            this.TableLabel.ToolTip = null;
            // 
            // TablePanel
            // 
            this.TablePanel.BackColor = System.Drawing.Color.Transparent;
            this.TablePanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TablePanel.BindingSource = null;
            this.TablePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TablePanel.BorderThickness = 1;
            this.TablePanel.Children = null;
            this.TablePanel.Controls.Add(this.TableListBox);
            this.TablePanel.DataFilter = null;
            this.TablePanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TablePanel.ForeColor = System.Drawing.Color.Transparent;
            this.TablePanel.HoverText = null;
            this.TablePanel.IsDerivedStyle = true;
            this.TablePanel.Location = new System.Drawing.Point(3, 27);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Padding = new System.Windows.Forms.Padding(1);
            this.TablePanel.Size = new System.Drawing.Size(272, 327);
            this.TablePanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.TablePanel.StyleManager = null;
            this.TablePanel.TabIndex = 1;
            this.TablePanel.ThemeAuthor = "Terry D. Eppler";
            this.TablePanel.ThemeName = "Budget Execution";
            this.TablePanel.ToolTip = null;
            // 
            // TableListBox
            // 
            this.TableListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TableListBox.BindingSource = null;
            this.TableListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TableListBox.DataFilter = null;
            this.TableListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TableListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TableListBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.TableListBox.HoveredItemColor = System.Drawing.Color.White;
            this.TableListBox.HoverText = null;
            this.TableListBox.IsDerivedStyle = true;
            this.TableListBox.ItemHeight = 28;
            this.TableListBox.Location = new System.Drawing.Point(32, 38);
            this.TableListBox.Margin = new System.Windows.Forms.Padding(1);
            this.TableListBox.MultiSelect = true;
            this.TableListBox.Name = "TableListBox";
            this.TableListBox.Padding = new System.Windows.Forms.Padding(1);
            this.TableListBox.SelectedIndex = -1;
            this.TableListBox.SelectedItem = null;
            this.TableListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TableListBox.SelectedItemColor = System.Drawing.Color.White;
            this.TableListBox.SelectedText = null;
            this.TableListBox.SelectedValue = null;
            this.TableListBox.ShowBorder = false;
            this.TableListBox.ShowScrollBar = false;
            this.TableListBox.Size = new System.Drawing.Size(210, 252);
            this.TableListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.TableListBox.StyleManager = null;
            this.TableListBox.TabIndex = 1;
            this.TableListBox.ThemeAuthor = "Terry D. Eppler";
            this.TableListBox.ThemeName = "Budget Execution";
            this.TableListBox.ToolTip = null;
            // 
            // CalendarTabPage
            // 
            this.CalendarTabPage.Controls.Add(this.CalendarDataPanel);
            this.CalendarTabPage.Controls.Add(this.SecondCalendarPanel);
            this.CalendarTabPage.Controls.Add(this.DateSelectionPanel);
            this.CalendarTabPage.Image = null;
            this.CalendarTabPage.ImageSize = new System.Drawing.Size(16, 16);
            this.CalendarTabPage.Location = new System.Drawing.Point(0, 29);
            this.CalendarTabPage.Name = "CalendarTabPage";
            this.CalendarTabPage.ShowCloseButton = true;
            this.CalendarTabPage.Size = new System.Drawing.Size(1068, 412);
            this.CalendarTabPage.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CalendarTabPage.TabForeColor = System.Drawing.Color.LightGray;
            this.CalendarTabPage.TabIndex = 3;
            this.CalendarTabPage.ThemesEnabled = false;
            // 
            // CalendarDataPanel
            // 
            this.CalendarDataPanel.BackColor = System.Drawing.Color.Transparent;
            this.CalendarDataPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CalendarDataPanel.BindingSource = null;
            this.CalendarDataPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.CalendarDataPanel.BorderThickness = 1;
            this.CalendarDataPanel.Children = null;
            this.CalendarDataPanel.Controls.Add(this.TimeLabelTable);
            this.CalendarDataPanel.DataFilter = null;
            this.CalendarDataPanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarDataPanel.ForeColor = System.Drawing.Color.Transparent;
            this.CalendarDataPanel.HoverText = null;
            this.CalendarDataPanel.IsDerivedStyle = true;
            this.CalendarDataPanel.Location = new System.Drawing.Point(719, 44);
            this.CalendarDataPanel.Name = "CalendarDataPanel";
            this.CalendarDataPanel.Padding = new System.Windows.Forms.Padding(1);
            this.CalendarDataPanel.Size = new System.Drawing.Size(335, 311);
            this.CalendarDataPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.CalendarDataPanel.StyleManager = null;
            this.CalendarDataPanel.TabIndex = 4;
            this.CalendarDataPanel.ThemeAuthor = "Terry D. Eppler";
            this.CalendarDataPanel.ThemeName = "Budget Execution";
            this.CalendarDataPanel.ToolTip = null;
            // 
            // TimeLabelTable
            // 
            this.TimeLabelTable.ColumnCount = 2;
            this.TimeLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TimeLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.TimeLabelTable.Controls.Add(this.TimeLabel1, 1, 1);
            this.TimeLabelTable.Controls.Add(this.TimeLabel2, 1, 2);
            this.TimeLabelTable.Controls.Add(this.TimeLabel3, 1, 3);
            this.TimeLabelTable.Controls.Add(this.TimeLabel4, 1, 4);
            this.TimeLabelTable.Controls.Add(this.TimeLabel5, 1, 5);
            this.TimeLabelTable.Controls.Add(this.TimeLabel6, 1, 6);
            this.TimeLabelTable.Controls.Add(this.TimeLabel7, 1, 7);
            this.TimeLabelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeLabelTable.Location = new System.Drawing.Point(1, 1);
            this.TimeLabelTable.Name = "TimeLabelTable";
            this.TimeLabelTable.RowCount = 9;
            this.TimeLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TimeLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TimeLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TimeLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TimeLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TimeLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TimeLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TimeLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TimeLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TimeLabelTable.Size = new System.Drawing.Size(333, 309);
            this.TimeLabelTable.TabIndex = 5;
            // 
            // TimeLabel1
            // 
            this.TimeLabel1.BindingSource = null;
            this.TimeLabel1.DataFilter = null;
            this.TimeLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel1.HoverText = null;
            this.TimeLabel1.IsDerivedStyle = true;
            this.TimeLabel1.Location = new System.Drawing.Point(15, 47);
            this.TimeLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.TimeLabel1.Name = "TimeLabel1";
            this.TimeLabel1.Padding = new System.Windows.Forms.Padding(1);
            this.TimeLabel1.Size = new System.Drawing.Size(315, 23);
            this.TimeLabel1.Style = MetroSet_UI.Enums.Style.Custom;
            this.TimeLabel1.StyleManager = null;
            this.TimeLabel1.TabIndex = 0;
            this.TimeLabel1.Text = "label4";
            this.TimeLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TimeLabel1.ThemeAuthor = "Terry D. Eppler";
            this.TimeLabel1.ThemeName = "Budget Execution";
            this.TimeLabel1.ToolTip = null;
            // 
            // TimeLabel2
            // 
            this.TimeLabel2.BindingSource = null;
            this.TimeLabel2.DataFilter = null;
            this.TimeLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel2.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel2.HoverText = null;
            this.TimeLabel2.IsDerivedStyle = true;
            this.TimeLabel2.Location = new System.Drawing.Point(15, 82);
            this.TimeLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.TimeLabel2.Name = "TimeLabel2";
            this.TimeLabel2.Padding = new System.Windows.Forms.Padding(1);
            this.TimeLabel2.Size = new System.Drawing.Size(315, 23);
            this.TimeLabel2.Style = MetroSet_UI.Enums.Style.Custom;
            this.TimeLabel2.StyleManager = null;
            this.TimeLabel2.TabIndex = 1;
            this.TimeLabel2.Text = "label5";
            this.TimeLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TimeLabel2.ThemeAuthor = "Terry D. Eppler";
            this.TimeLabel2.ThemeName = "Budget Execution";
            this.TimeLabel2.ToolTip = null;
            // 
            // TimeLabel3
            // 
            this.TimeLabel3.BindingSource = null;
            this.TimeLabel3.DataFilter = null;
            this.TimeLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel3.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel3.HoverText = null;
            this.TimeLabel3.IsDerivedStyle = true;
            this.TimeLabel3.Location = new System.Drawing.Point(15, 117);
            this.TimeLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.TimeLabel3.Name = "TimeLabel3";
            this.TimeLabel3.Padding = new System.Windows.Forms.Padding(1);
            this.TimeLabel3.Size = new System.Drawing.Size(315, 23);
            this.TimeLabel3.Style = MetroSet_UI.Enums.Style.Custom;
            this.TimeLabel3.StyleManager = null;
            this.TimeLabel3.TabIndex = 2;
            this.TimeLabel3.Text = "label6";
            this.TimeLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TimeLabel3.ThemeAuthor = "Terry D. Eppler";
            this.TimeLabel3.ThemeName = "Budget Execution";
            this.TimeLabel3.ToolTip = null;
            // 
            // TimeLabel4
            // 
            this.TimeLabel4.BindingSource = null;
            this.TimeLabel4.DataFilter = null;
            this.TimeLabel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel4.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel4.HoverText = null;
            this.TimeLabel4.IsDerivedStyle = true;
            this.TimeLabel4.Location = new System.Drawing.Point(15, 147);
            this.TimeLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.TimeLabel4.Name = "TimeLabel4";
            this.TimeLabel4.Padding = new System.Windows.Forms.Padding(1);
            this.TimeLabel4.Size = new System.Drawing.Size(315, 23);
            this.TimeLabel4.Style = MetroSet_UI.Enums.Style.Custom;
            this.TimeLabel4.StyleManager = null;
            this.TimeLabel4.TabIndex = 3;
            this.TimeLabel4.Text = "label7";
            this.TimeLabel4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TimeLabel4.ThemeAuthor = "Terry D. Eppler";
            this.TimeLabel4.ThemeName = "Budget Execution";
            this.TimeLabel4.ToolTip = null;
            // 
            // TimeLabel5
            // 
            this.TimeLabel5.BindingSource = null;
            this.TimeLabel5.DataFilter = null;
            this.TimeLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel5.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel5.HoverText = null;
            this.TimeLabel5.IsDerivedStyle = true;
            this.TimeLabel5.Location = new System.Drawing.Point(15, 185);
            this.TimeLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.TimeLabel5.Name = "TimeLabel5";
            this.TimeLabel5.Padding = new System.Windows.Forms.Padding(1);
            this.TimeLabel5.Size = new System.Drawing.Size(315, 23);
            this.TimeLabel5.Style = MetroSet_UI.Enums.Style.Custom;
            this.TimeLabel5.StyleManager = null;
            this.TimeLabel5.TabIndex = 4;
            this.TimeLabel5.Text = "label8";
            this.TimeLabel5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TimeLabel5.ThemeAuthor = "Terry D. Eppler";
            this.TimeLabel5.ThemeName = "Budget Execution";
            this.TimeLabel5.ToolTip = null;
            // 
            // TimeLabel6
            // 
            this.TimeLabel6.BindingSource = null;
            this.TimeLabel6.DataFilter = null;
            this.TimeLabel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel6.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel6.HoverText = null;
            this.TimeLabel6.IsDerivedStyle = true;
            this.TimeLabel6.Location = new System.Drawing.Point(15, 221);
            this.TimeLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.TimeLabel6.Name = "TimeLabel6";
            this.TimeLabel6.Padding = new System.Windows.Forms.Padding(1);
            this.TimeLabel6.Size = new System.Drawing.Size(315, 23);
            this.TimeLabel6.Style = MetroSet_UI.Enums.Style.Custom;
            this.TimeLabel6.StyleManager = null;
            this.TimeLabel6.TabIndex = 5;
            this.TimeLabel6.Text = "label9";
            this.TimeLabel6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TimeLabel6.ThemeAuthor = "Terry D. Eppler";
            this.TimeLabel6.ThemeName = "Budget Execution";
            this.TimeLabel6.ToolTip = null;
            // 
            // TimeLabel7
            // 
            this.TimeLabel7.BindingSource = null;
            this.TimeLabel7.DataFilter = null;
            this.TimeLabel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel7.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel7.HoverText = null;
            this.TimeLabel7.IsDerivedStyle = true;
            this.TimeLabel7.Location = new System.Drawing.Point(15, 255);
            this.TimeLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.TimeLabel7.Name = "TimeLabel7";
            this.TimeLabel7.Padding = new System.Windows.Forms.Padding(1);
            this.TimeLabel7.Size = new System.Drawing.Size(315, 23);
            this.TimeLabel7.Style = MetroSet_UI.Enums.Style.Custom;
            this.TimeLabel7.StyleManager = null;
            this.TimeLabel7.TabIndex = 6;
            this.TimeLabel7.Text = "label10";
            this.TimeLabel7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TimeLabel7.ThemeAuthor = "Terry D. Eppler";
            this.TimeLabel7.ThemeName = "Budget Execution";
            this.TimeLabel7.ToolTip = null;
            // 
            // SecondCalendarPanel
            // 
            this.SecondCalendarPanel.BackColor = System.Drawing.Color.Transparent;
            this.SecondCalendarPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondCalendarPanel.BindingSource = null;
            this.SecondCalendarPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SecondCalendarPanel.BorderThickness = 1;
            this.SecondCalendarPanel.Children = null;
            this.SecondCalendarPanel.Controls.Add(this.SecondCalendarTable);
            this.SecondCalendarPanel.DataFilter = null;
            this.SecondCalendarPanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondCalendarPanel.ForeColor = System.Drawing.Color.Transparent;
            this.SecondCalendarPanel.HoverText = null;
            this.SecondCalendarPanel.IsDerivedStyle = true;
            this.SecondCalendarPanel.Location = new System.Drawing.Point(365, 44);
            this.SecondCalendarPanel.Name = "SecondCalendarPanel";
            this.SecondCalendarPanel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondCalendarPanel.Size = new System.Drawing.Size(335, 311);
            this.SecondCalendarPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondCalendarPanel.StyleManager = null;
            this.SecondCalendarPanel.TabIndex = 3;
            this.SecondCalendarPanel.ThemeAuthor = "Terry D. Eppler";
            this.SecondCalendarPanel.ThemeName = "Budget Execution";
            this.SecondCalendarPanel.ToolTip = null;
            // 
            // SecondCalendarTable
            // 
            this.SecondCalendarTable.ColumnCount = 1;
            this.SecondCalendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SecondCalendarTable.Controls.Add(this.SecondCalendarLabel, 0, 0);
            this.SecondCalendarTable.Controls.Add(this.SeondCalendar, 0, 1);
            this.SecondCalendarTable.Location = new System.Drawing.Point(4, 4);
            this.SecondCalendarTable.Name = "SecondCalendarTable";
            this.SecondCalendarTable.RowCount = 2;
            this.SecondCalendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.333333F));
            this.SecondCalendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.66666F));
            this.SecondCalendarTable.Size = new System.Drawing.Size(324, 296);
            this.SecondCalendarTable.TabIndex = 2;
            // 
            // SecondCalendarLabel
            // 
            this.SecondCalendarLabel.BindingSource = null;
            this.SecondCalendarLabel.DataFilter = null;
            this.SecondCalendarLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondCalendarLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondCalendarLabel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondCalendarLabel.HoverText = null;
            this.SecondCalendarLabel.IsDerivedStyle = true;
            this.SecondCalendarLabel.Location = new System.Drawing.Point(3, 3);
            this.SecondCalendarLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SecondCalendarLabel.Name = "SecondCalendarLabel";
            this.SecondCalendarLabel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondCalendarLabel.Size = new System.Drawing.Size(318, 21);
            this.SecondCalendarLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondCalendarLabel.StyleManager = null;
            this.SecondCalendarLabel.TabIndex = 2;
            this.SecondCalendarLabel.Text = "Label";
            this.SecondCalendarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SecondCalendarLabel.ThemeAuthor = "Terry D. Eppler";
            this.SecondCalendarLabel.ThemeName = "Budget Execution";
            this.SecondCalendarLabel.ToolTip = null;
            // 
            // SeondCalendar
            // 
            this.SeondCalendar.CanOverrideStyle = true;
            this.SeondCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeondCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.SeondCalendar.Location = new System.Drawing.Point(3, 30);
            this.SeondCalendar.MinimumSize = new System.Drawing.Size(196, 196);
            this.SeondCalendar.Name = "SeondCalendar";
            this.SeondCalendar.ShowToolTip = true;
            this.SeondCalendar.Size = new System.Drawing.Size(315, 263);
            this.SeondCalendar.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeondCalendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeondCalendar.Style.Cell.BlackoutDatesFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeondCalendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeondCalendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeondCalendar.Style.Cell.CellFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeondCalendar.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SeondCalendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SeondCalendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
            this.SeondCalendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
            this.SeondCalendar.Style.Cell.SelectedCellFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SeondCalendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            this.SeondCalendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
            this.SeondCalendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeondCalendar.Style.Cell.TodayFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SeondCalendar.Style.Cell.TodayForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SeondCalendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SeondCalendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeondCalendar.Style.Cell.TrailingCellFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeondCalendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
            this.SeondCalendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeondCalendar.Style.Cell.WeekNumberFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeondCalendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SeondCalendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeondCalendar.Style.Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SeondCalendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
            this.SeondCalendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
            this.SeondCalendar.Style.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeondCalendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeondCalendar.Style.Header.DayNamesFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeondCalendar.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SeondCalendar.Style.Header.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SeondCalendar.Style.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SeondCalendar.Style.Header.HoverForeColor = System.Drawing.Color.White;
            this.SeondCalendar.Style.Header.NavigationButtonDisabledForeColor = System.Drawing.Color.DimGray;
            this.SeondCalendar.Style.Header.NavigationButtonForeColor = System.Drawing.Color.SteelBlue;
            this.SeondCalendar.Style.Header.NavigationButtonHoverForeColor = System.Drawing.Color.White;
            this.SeondCalendar.Style.HorizontalSplitterColor = System.Drawing.Color.DimGray;
            this.SeondCalendar.Style.VerticalSplitterColor = System.Drawing.Color.DimGray;
            this.SeondCalendar.TabIndex = 3;
            // 
            // DateSelectionPanel
            // 
            this.DateSelectionPanel.BackColor = System.Drawing.Color.Transparent;
            this.DateSelectionPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DateSelectionPanel.BindingSource = null;
            this.DateSelectionPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DateSelectionPanel.BorderThickness = 1;
            this.DateSelectionPanel.Children = null;
            this.DateSelectionPanel.Controls.Add(this.FirstCalendarTable);
            this.DateSelectionPanel.DataFilter = null;
            this.DateSelectionPanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateSelectionPanel.ForeColor = System.Drawing.Color.Transparent;
            this.DateSelectionPanel.HoverText = null;
            this.DateSelectionPanel.IsDerivedStyle = true;
            this.DateSelectionPanel.Location = new System.Drawing.Point(12, 44);
            this.DateSelectionPanel.Name = "DateSelectionPanel";
            this.DateSelectionPanel.Padding = new System.Windows.Forms.Padding(1);
            this.DateSelectionPanel.Size = new System.Drawing.Size(335, 311);
            this.DateSelectionPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.DateSelectionPanel.StyleManager = null;
            this.DateSelectionPanel.TabIndex = 1;
            this.DateSelectionPanel.ThemeAuthor = "Terry D. Eppler";
            this.DateSelectionPanel.ThemeName = "Budget Execution";
            this.DateSelectionPanel.ToolTip = null;
            // 
            // FirstCalendarTable
            // 
            this.FirstCalendarTable.ColumnCount = 1;
            this.FirstCalendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.70636F));
            this.FirstCalendarTable.Controls.Add(this.FirstCalendar, 0, 1);
            this.FirstCalendarTable.Controls.Add(this.FirstCalendarLabel, 0, 0);
            this.FirstCalendarTable.Location = new System.Drawing.Point(4, 4);
            this.FirstCalendarTable.Name = "FirstCalendarTable";
            this.FirstCalendarTable.RowCount = 2;
            this.FirstCalendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FirstCalendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.FirstCalendarTable.Size = new System.Drawing.Size(323, 296);
            this.FirstCalendarTable.TabIndex = 0;
            // 
            // FirstCalendar
            // 
            this.FirstCalendar.CanOverrideStyle = true;
            this.FirstCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.FirstCalendar.Location = new System.Drawing.Point(3, 31);
            this.FirstCalendar.MinimumSize = new System.Drawing.Size(196, 196);
            this.FirstCalendar.Name = "FirstCalendar";
            this.FirstCalendar.ShowToolTip = true;
            this.FirstCalendar.Size = new System.Drawing.Size(315, 262);
            this.FirstCalendar.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstCalendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstCalendar.Style.Cell.BlackoutDatesFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstCalendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstCalendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstCalendar.Style.Cell.CellFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstCalendar.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstCalendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstCalendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
            this.FirstCalendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
            this.FirstCalendar.Style.Cell.SelectedCellFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstCalendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            this.FirstCalendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
            this.FirstCalendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstCalendar.Style.Cell.TodayFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstCalendar.Style.Cell.TodayForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstCalendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstCalendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstCalendar.Style.Cell.TrailingCellFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstCalendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
            this.FirstCalendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstCalendar.Style.Cell.WeekNumberFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstCalendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstCalendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstCalendar.Style.Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstCalendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
            this.FirstCalendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
            this.FirstCalendar.Style.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstCalendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstCalendar.Style.Header.DayNamesFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstCalendar.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstCalendar.Style.Header.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstCalendar.Style.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstCalendar.Style.Header.HoverForeColor = System.Drawing.Color.White;
            this.FirstCalendar.Style.Header.NavigationButtonDisabledForeColor = System.Drawing.Color.DimGray;
            this.FirstCalendar.Style.Header.NavigationButtonForeColor = System.Drawing.Color.SteelBlue;
            this.FirstCalendar.Style.Header.NavigationButtonHoverForeColor = System.Drawing.Color.White;
            this.FirstCalendar.Style.HorizontalSplitterColor = System.Drawing.Color.DimGray;
            this.FirstCalendar.Style.VerticalSplitterColor = System.Drawing.Color.DimGray;
            this.FirstCalendar.TabIndex = 1;
            // 
            // FirstCalendarLabel
            // 
            this.FirstCalendarLabel.BindingSource = null;
            this.FirstCalendarLabel.DataFilter = null;
            this.FirstCalendarLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstCalendarLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstCalendarLabel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstCalendarLabel.HoverText = null;
            this.FirstCalendarLabel.IsDerivedStyle = true;
            this.FirstCalendarLabel.Location = new System.Drawing.Point(3, 3);
            this.FirstCalendarLabel.Margin = new System.Windows.Forms.Padding(3);
            this.FirstCalendarLabel.Name = "FirstCalendarLabel";
            this.FirstCalendarLabel.Padding = new System.Windows.Forms.Padding(1);
            this.FirstCalendarLabel.Size = new System.Drawing.Size(317, 22);
            this.FirstCalendarLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstCalendarLabel.StyleManager = null;
            this.FirstCalendarLabel.TabIndex = 1;
            this.FirstCalendarLabel.Text = "Label";
            this.FirstCalendarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstCalendarLabel.ThemeAuthor = "Terry D. Eppler";
            this.FirstCalendarLabel.ThemeName = "Budget Execution";
            this.FirstCalendarLabel.ToolTip = null;
            // 
            // FilterTabPage
            // 
            this.FilterTabPage.Controls.Add(this.tableLayoutPanel2);
            this.FilterTabPage.Controls.Add(this.SecondTable);
            this.FilterTabPage.Controls.Add(this.ThirdTable);
            this.FilterTabPage.Controls.Add(this.FirstTable);
            this.FilterTabPage.Image = null;
            this.FilterTabPage.ImageSize = new System.Drawing.Size(16, 16);
            this.FilterTabPage.Location = new System.Drawing.Point(0, 29);
            this.FilterTabPage.Name = "FilterTabPage";
            this.FilterTabPage.ShowCloseButton = true;
            this.FilterTabPage.Size = new System.Drawing.Size(1068, 412);
            this.FilterTabPage.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FilterTabPage.TabIndex = 1;
            this.FilterTabPage.ThemesEnabled = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 1);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(806, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(245, 366);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BindingSource = null;
            this.label3.DataFilter = null;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.HoverText = null;
            this.label3.IsDerivedStyle = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(239, 18);
            this.label3.Style = MetroSet_UI.Enums.Style.Custom;
            this.label3.StyleManager = null;
            this.label3.TabIndex = 0;
            this.label3.Text = "Third Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.ThemeAuthor = "Terry D. Eppler";
            this.label3.ThemeName = "BudgetExecution";
            this.label3.ToolTip = null;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.comboBox1.BackColor = System.Drawing.Color.Transparent;
            this.comboBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
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
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.HoverText = "Select Third Category";
            this.comboBox1.IsDerivedStyle = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Location = new System.Drawing.Point(3, 27);
            this.comboBox1.MaxDropDownItems = 60;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.comboBox1.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboBox1.Size = new System.Drawing.Size(239, 30);
            this.comboBox1.Style = MetroSet_UI.Enums.Style.Custom;
            this.comboBox1.StyleManager = null;
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ThemeAuthor = "Terry D. Eppler";
            this.comboBox1.ThemeName = "BudgetExecution";
            this.comboBox1.ToolTip = null;
            // 
            // SecondTable
            // 
            this.SecondTable.ColumnCount = 1;
            this.SecondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SecondTable.Controls.Add(this.SecondLabel, 0, 0);
            this.SecondTable.Controls.Add(this.SecondComboBox, 0, 1);
            this.SecondTable.Controls.Add(this.SecondPanel, 0, 2);
            this.SecondTable.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.SecondTable.Location = new System.Drawing.Point(276, 5);
            this.SecondTable.Name = "SecondTable";
            this.SecondTable.RowCount = 3;
            this.SecondTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.SecondTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.SecondTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.SecondTable.Size = new System.Drawing.Size(245, 366);
            this.SecondTable.TabIndex = 6;
            // 
            // SecondLabel
            // 
            this.SecondLabel.BindingSource = null;
            this.SecondLabel.DataFilter = null;
            this.SecondLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondLabel.HoverText = null;
            this.SecondLabel.IsDerivedStyle = true;
            this.SecondLabel.Location = new System.Drawing.Point(3, 3);
            this.SecondLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondLabel.Size = new System.Drawing.Size(239, 18);
            this.SecondLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondLabel.StyleManager = null;
            this.SecondLabel.TabIndex = 0;
            this.SecondLabel.Text = "Second Category";
            this.SecondLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SecondLabel.ThemeAuthor = "Terry D. Eppler";
            this.SecondLabel.ThemeName = "BudgetExecution";
            this.SecondLabel.ToolTip = null;
            // 
            // SecondComboBox
            // 
            this.SecondComboBox.AllowDrop = true;
            this.SecondComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SecondComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondComboBox.BindingSource = null;
            this.SecondComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SecondComboBox.CausesValidation = false;
            this.SecondComboBox.DataFilter = null;
            this.SecondComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            this.SecondComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.SecondComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            this.SecondComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SecondComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondComboBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondComboBox.FormattingEnabled = true;
            this.SecondComboBox.HoverText = "Select Second Category";
            this.SecondComboBox.IsDerivedStyle = true;
            this.SecondComboBox.ItemHeight = 24;
            this.SecondComboBox.Location = new System.Drawing.Point(3, 27);
            this.SecondComboBox.MaxDropDownItems = 60;
            this.SecondComboBox.Name = "SecondComboBox";
            this.SecondComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.SecondComboBox.Size = new System.Drawing.Size(239, 30);
            this.SecondComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondComboBox.StyleManager = null;
            this.SecondComboBox.TabIndex = 1;
            this.SecondComboBox.ThemeAuthor = "Terry D. Eppler";
            this.SecondComboBox.ThemeName = "BudgetExecution";
            this.SecondComboBox.ToolTip = null;
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
            this.SecondPanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPanel.ForeColor = System.Drawing.Color.Transparent;
            this.SecondPanel.HoverText = null;
            this.SecondPanel.IsDerivedStyle = true;
            this.SecondPanel.Location = new System.Drawing.Point(3, 61);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondPanel.Size = new System.Drawing.Size(239, 302);
            this.SecondPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondPanel.StyleManager = null;
            this.SecondPanel.TabIndex = 2;
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
            this.SecondListBox.Location = new System.Drawing.Point(17, 19);
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
            this.SecondListBox.Size = new System.Drawing.Size(202, 261);
            this.SecondListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondListBox.StyleManager = null;
            this.SecondListBox.TabIndex = 0;
            this.SecondListBox.ThemeAuthor = "Terry D. Eppler";
            this.SecondListBox.ThemeName = "BudgetExecution";
            this.SecondListBox.ToolTip = null;
            // 
            // ReferencePanel
            // 
            this.ReferencePanel.BackColor = System.Drawing.Color.Transparent;
            this.ReferencePanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ReferencePanel.BindingSource = null;
            this.ReferencePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ReferencePanel.BorderThickness = 1;
            this.ReferencePanel.Children = null;
            this.ReferencePanel.Controls.Add(this.ReferenceListBox);
            this.ReferencePanel.DataFilter = null;
            this.ReferencePanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReferencePanel.ForeColor = System.Drawing.Color.Transparent;
            this.ReferencePanel.HoverText = null;
            this.ReferencePanel.IsDerivedStyle = true;
            this.ReferencePanel.Location = new System.Drawing.Point(3, 27);
            this.ReferencePanel.Name = "ReferencePanel";
            this.ReferencePanel.Padding = new System.Windows.Forms.Padding(1);
            this.ReferencePanel.Size = new System.Drawing.Size(272, 327);
            this.ReferencePanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ReferencePanel.StyleManager = null;
            this.ReferencePanel.TabIndex = 2;
            this.ReferencePanel.ThemeAuthor = "Terry D. Eppler";
            this.ReferencePanel.ThemeName = "Budget Execution";
            this.ReferencePanel.ToolTip = null;
            // 
            // ReferenceListBox
            // 
            this.ReferenceListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ReferenceListBox.BindingSource = null;
            this.ReferenceListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ReferenceListBox.DataFilter = null;
            this.ReferenceListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ReferenceListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ReferenceListBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReferenceListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ReferenceListBox.HoveredItemColor = System.Drawing.Color.White;
            this.ReferenceListBox.HoverText = null;
            this.ReferenceListBox.IsDerivedStyle = true;
            this.ReferenceListBox.ItemHeight = 28;
            this.ReferenceListBox.Location = new System.Drawing.Point(32, 38);
            this.ReferenceListBox.Margin = new System.Windows.Forms.Padding(1);
            this.ReferenceListBox.MultiSelect = true;
            this.ReferenceListBox.Name = "ReferenceListBox";
            this.ReferenceListBox.Padding = new System.Windows.Forms.Padding(1);
            this.ReferenceListBox.SelectedIndex = -1;
            this.ReferenceListBox.SelectedItem = null;
            this.ReferenceListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ReferenceListBox.SelectedItemColor = System.Drawing.Color.White;
            this.ReferenceListBox.SelectedText = null;
            this.ReferenceListBox.SelectedValue = null;
            this.ReferenceListBox.ShowBorder = false;
            this.ReferenceListBox.ShowScrollBar = false;
            this.ReferenceListBox.Size = new System.Drawing.Size(210, 252);
            this.ReferenceListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ReferenceListBox.StyleManager = null;
            this.ReferenceListBox.TabIndex = 1;
            this.ReferenceListBox.ThemeAuthor = "Terry D. Eppler";
            this.ReferenceListBox.ThemeName = "Budget Execution";
            this.ReferenceListBox.ToolTip = null;
            // 
            // FilterDialog
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
            this.ClientSize = new System.Drawing.Size(1068, 539);
            this.Controls.Add(this.ThirdButton);
            this.Controls.Add(this.SecondButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeBox = false;
            this.Name = "FilterDialog";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DataSource Name";
            this.FirstTable.ResumeLayout(false);
            this.FirstPanel.ResumeLayout(false);
            this.ThirdTable.ResumeLayout(false);
            this.ThirdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TableTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ProviderTable.ResumeLayout(false);
            this.ProviderPanel.ResumeLayout(false);
            this.SourceTable.ResumeLayout(false);
            this.TablePanel.ResumeLayout(false);
            this.CalendarTabPage.ResumeLayout(false);
            this.CalendarDataPanel.ResumeLayout(false);
            this.TimeLabelTable.ResumeLayout(false);
            this.SecondCalendarPanel.ResumeLayout(false);
            this.SecondCalendarTable.ResumeLayout(false);
            this.DateSelectionPanel.ResumeLayout(false);
            this.FirstCalendarTable.ResumeLayout(false);
            this.FilterTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.SecondTable.ResumeLayout(false);
            this.SecondPanel.ResumeLayout(false);
            this.ReferencePanel.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.TableLayoutPanel FirstTable;
    public Label FirstLabel;
    public ComboBox FirstComboBox;
    public Layout FirstPanel;
    public ListBox FirstListBox;
    public System.Windows.Forms.TableLayoutPanel ThirdTable;
    public Label ThirdLabel;
    public ComboBox ThirdComboBox;
    public Layout ThirdPanel;
    public ListBox ThirdListBox;
    public Button FirstButton;
    public Button SecondButton;
    public Button ThirdButton;
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
    public TabControl TabControl;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv TableTabPage;
    public System.Windows.Forms.TableLayoutPanel ProviderTable;
    public Label label2;
    public Layout ProviderPanel;
    public System.Windows.Forms.TableLayoutPanel SourceTable;
    public Label TableLabel;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv FilterTabPage;
    public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    public Label label1;
    public RadioButton AccessRadioButton;
    public RadioButton SqlServerRadioButton;
    public RadioButton SQLiteRadioButton;
    public RadioButton SqlCeRadioButton;
    private Syncfusion.Windows.Forms.Tools.TabPageAdv CalendarTabPage;
    private System.Windows.Forms.TableLayoutPanel FirstCalendarTable;
    private Label FirstCalendarLabel;
    private Label SecondCalendarLabel;
    private Layout DateSelectionPanel;
    public Syncfusion.WinForms.Input.SfCalendar FirstCalendar;
    public Syncfusion.WinForms.Input.SfCalendar SeondCalendar;
    private System.Windows.Forms.TableLayoutPanel SecondCalendarTable;
    private Layout TablePanel;
    private Layout CalendarDataPanel;
    private System.Windows.Forms.TableLayoutPanel TimeLabelTable;
    public Label TimeLabel1;
    public Label TimeLabel2;
    public Label TimeLabel3;
    public Label TimeLabel4;
    public Label TimeLabel5;
    public Label TimeLabel6;
    public Label TimeLabel7;
    private Layout SecondCalendarPanel;
    public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    public Label label3;
    public ComboBox comboBox1;
    public System.Windows.Forms.TableLayoutPanel SecondTable;
    public Label SecondLabel;
    public ComboBox SecondComboBox;
    public Layout SecondPanel;
    public ListBox SecondListBox;
    public ListBox TableListBox;
    private Layout ReferencePanel;
    public ListBox ReferenceListBox;
}
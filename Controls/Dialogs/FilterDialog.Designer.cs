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
            this.SecondPanel = new BudgetExecution.Layout();
            this.SecondListBox = new BudgetExecution.ListBox();
            this.SecondComboBox = new BudgetExecution.ComboBox();
            this.SecondLabel = new BudgetExecution.Label();
            this.SecondTable = new System.Windows.Forms.TableLayoutPanel();
            this.FirstButton = new BudgetExecution.Button();
            this.SecondButton = new BudgetExecution.Button();
            this.ThirdButton = new BudgetExecution.Button();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.TabControl = new BudgetExecution.TabControl();
            this.FilterTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TableTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ProviderTable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new BudgetExecution.Label();
            this.ProviderPanel = new BudgetExecution.Layout();
            this.AccessRadioButton = new BudgetExecution.RadioButton();
            this.SqlServerRadioButton = new BudgetExecution.RadioButton();
            this.SQLiteRadioButton = new BudgetExecution.RadioButton();
            this.SourceTable = new System.Windows.Forms.TableLayoutPanel();
            this.TableLabel = new BudgetExecution.Label();
            this.layout1 = new BudgetExecution.Layout();
            this.TableListBox = new BudgetExecution.ListBox();
            this.FirstTable.SuspendLayout();
            this.FirstPanel.SuspendLayout();
            this.ThirdTable.SuspendLayout();
            this.ThirdPanel.SuspendLayout();
            this.SecondPanel.SuspendLayout();
            this.SecondTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.FilterTab.SuspendLayout();
            this.TableTab.SuspendLayout();
            this.ProviderTable.SuspendLayout();
            this.ProviderPanel.SuspendLayout();
            this.SourceTable.SuspendLayout();
            this.layout1.SuspendLayout();
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
            this.FirstTable.Location = new System.Drawing.Point(12, 3);
            this.FirstTable.Name = "FirstTable";
            this.FirstTable.RowCount = 3;
            this.FirstTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.FirstTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.FirstTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.FirstTable.Size = new System.Drawing.Size(270, 330);
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
            this.FirstPanel.Size = new System.Drawing.Size(262, 265);
            this.FirstPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstPanel.StyleManager = null;
            this.FirstPanel.TabIndex = 2;
            this.FirstPanel.ThemeAuthor = "Terry D. Eppler";
            this.FirstPanel.ThemeName = "BudgetExecution";
            this.FirstPanel.ToolTip = null;
            // 
            // FirstListBox
            // 
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
            this.FirstListBox.Size = new System.Drawing.Size(222, 232);
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
            this.FirstLabel.Size = new System.Drawing.Size(264, 18);
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
            this.FirstComboBox.Size = new System.Drawing.Size(264, 30);
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
            this.ThirdTable.Location = new System.Drawing.Point(588, 3);
            this.ThirdTable.Name = "ThirdTable";
            this.ThirdTable.RowCount = 3;
            this.ThirdTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.ThirdTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.ThirdTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.ThirdTable.Size = new System.Drawing.Size(262, 330);
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
            this.ThirdLabel.Size = new System.Drawing.Size(256, 18);
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
            this.ThirdComboBox.Size = new System.Drawing.Size(256, 30);
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
            this.ThirdPanel.Size = new System.Drawing.Size(256, 265);
            this.ThirdPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdPanel.StyleManager = null;
            this.ThirdPanel.TabIndex = 2;
            this.ThirdPanel.ThemeAuthor = "Terry D. Eppler";
            this.ThirdPanel.ThemeName = "BudgetExecution";
            this.ThirdPanel.ToolTip = null;
            // 
            // ThirdListBox
            // 
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
            this.ThirdListBox.Size = new System.Drawing.Size(216, 232);
            this.ThirdListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdListBox.StyleManager = null;
            this.ThirdListBox.TabIndex = 0;
            this.ThirdListBox.ThemeAuthor = "Terry D. Eppler";
            this.ThirdListBox.ThemeName = "BudgetExecution";
            this.ThirdListBox.ToolTip = null;
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
            this.SecondPanel.Size = new System.Drawing.Size(256, 265);
            this.SecondPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondPanel.StyleManager = null;
            this.SecondPanel.TabIndex = 2;
            this.SecondPanel.ThemeAuthor = "Terry D. Eppler";
            this.SecondPanel.ThemeName = "BudgetExecution";
            this.SecondPanel.ToolTip = null;
            // 
            // SecondListBox
            // 
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
            this.SecondListBox.Size = new System.Drawing.Size(224, 232);
            this.SecondListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondListBox.StyleManager = null;
            this.SecondListBox.TabIndex = 0;
            this.SecondListBox.ThemeAuthor = "Terry D. Eppler";
            this.SecondListBox.ThemeName = "BudgetExecution";
            this.SecondListBox.ToolTip = null;
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
            this.SecondComboBox.Size = new System.Drawing.Size(256, 30);
            this.SecondComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondComboBox.StyleManager = null;
            this.SecondComboBox.TabIndex = 1;
            this.SecondComboBox.ThemeAuthor = "Terry D. Eppler";
            this.SecondComboBox.ThemeName = "BudgetExecution";
            this.SecondComboBox.ToolTip = null;
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
            this.SecondLabel.Size = new System.Drawing.Size(256, 18);
            this.SecondLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondLabel.StyleManager = null;
            this.SecondLabel.TabIndex = 0;
            this.SecondLabel.Text = "Second Category";
            this.SecondLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SecondLabel.ThemeAuthor = "Terry D. Eppler";
            this.SecondLabel.ThemeName = "BudgetExecution";
            this.SecondLabel.ToolTip = null;
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
            this.SecondTable.Location = new System.Drawing.Point(303, 3);
            this.SecondTable.Name = "SecondTable";
            this.SecondTable.RowCount = 3;
            this.SecondTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.SecondTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.SecondTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.SecondTable.Size = new System.Drawing.Size(262, 330);
            this.SecondTable.TabIndex = 6;
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
            this.FirstButton.Location = new System.Drawing.Point(46, 371);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.FirstButton.NormalColor = System.Drawing.Color.Transparent;
            this.FirstButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.Padding = new System.Windows.Forms.Padding(1);
            this.FirstButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.PressTextColor = System.Drawing.Color.White;
            this.FirstButton.Size = new System.Drawing.Size(224, 53);
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
            this.SecondButton.Location = new System.Drawing.Point(324, 371);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.SecondButton.NormalColor = System.Drawing.Color.Transparent;
            this.SecondButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.Padding = new System.Windows.Forms.Padding(1);
            this.SecondButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.PressTextColor = System.Drawing.Color.White;
            this.SecondButton.Size = new System.Drawing.Size(224, 53);
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
            this.ThirdButton.Location = new System.Drawing.Point(610, 371);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.ThirdButton.NormalColor = System.Drawing.Color.Transparent;
            this.ThirdButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.PressTextColor = System.Drawing.Color.White;
            this.ThirdButton.Size = new System.Drawing.Size(224, 53);
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
            this.TabControl.BeforeTouchSize = new System.Drawing.Size(862, 365);
            this.TabControl.BindingSource = null;
            this.TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabControl.CanOverrideStyle = true;
            this.TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.Controls.Add(this.FilterTab);
            this.TabControl.Controls.Add(this.TableTab);
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
            this.TabControl.Size = new System.Drawing.Size(862, 365);
            this.TabControl.TabIndex = 12;
            this.TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.TabControl.ThemeName = "TabRendererMetro";
            this.TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TabControl.ThemeStyle.TabStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ToolTip = null;
            // 
            // FilterTab
            // 
            this.FilterTab.Controls.Add(this.FirstTable);
            this.FilterTab.Controls.Add(this.SecondTable);
            this.FilterTab.Controls.Add(this.ThirdTable);
            this.FilterTab.Image = null;
            this.FilterTab.ImageSize = new System.Drawing.Size(16, 16);
            this.FilterTab.Location = new System.Drawing.Point(0, 29);
            this.FilterTab.Name = "FilterTab";
            this.FilterTab.ShowCloseButton = true;
            this.FilterTab.Size = new System.Drawing.Size(862, 336);
            this.FilterTab.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FilterTab.TabIndex = 1;
            this.FilterTab.ThemesEnabled = false;
            // 
            // TableTab
            // 
            this.TableTab.Controls.Add(this.ProviderTable);
            this.TableTab.Controls.Add(this.SourceTable);
            this.TableTab.Image = null;
            this.TableTab.ImageSize = new System.Drawing.Size(16, 16);
            this.TableTab.Location = new System.Drawing.Point(0, 29);
            this.TableTab.Name = "TableTab";
            this.TableTab.ShowCloseButton = true;
            this.TableTab.Size = new System.Drawing.Size(862, 336);
            this.TableTab.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TableTab.TabFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableTab.TabIndex = 2;
            this.TableTab.ThemesEnabled = false;
            // 
            // ProviderTable
            // 
            this.ProviderTable.ColumnCount = 1;
            this.ProviderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProviderTable.Controls.Add(this.label2, 0, 0);
            this.ProviderTable.Controls.Add(this.ProviderPanel, 0, 1);
            this.ProviderTable.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ProviderTable.Location = new System.Drawing.Point(139, 6);
            this.ProviderTable.Name = "ProviderTable";
            this.ProviderTable.RowCount = 2;
            this.ProviderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.ProviderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.ProviderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ProviderTable.Size = new System.Drawing.Size(237, 312);
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
            this.label2.Size = new System.Drawing.Size(231, 18);
            this.label2.Style = MetroSet_UI.Enums.Style.Custom;
            this.label2.StyleManager = null;
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Provider";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ProviderPanel.Size = new System.Drawing.Size(231, 279);
            this.ProviderPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ProviderPanel.StyleManager = null;
            this.ProviderPanel.TabIndex = 2;
            this.ProviderPanel.ThemeAuthor = "Terry D. Eppler";
            this.ProviderPanel.ThemeName = "BudgetExecution";
            this.ProviderPanel.ToolTip = null;
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
            this.AccessRadioButton.Location = new System.Drawing.Point(54, 188);
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
            this.AccessRadioButton.ToolTip = null;
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
            this.SqlServerRadioButton.Location = new System.Drawing.Point(54, 121);
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
            this.SqlServerRadioButton.ToolTip = null;
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
            this.SQLiteRadioButton.Location = new System.Drawing.Point(54, 64);
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
            this.SQLiteRadioButton.ToolTip = null;
            // 
            // SourceTable
            // 
            this.SourceTable.ColumnCount = 1;
            this.SourceTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SourceTable.Controls.Add(this.TableLabel, 0, 0);
            this.SourceTable.Controls.Add(this.layout1, 0, 1);
            this.SourceTable.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.SourceTable.Location = new System.Drawing.Point(478, 6);
            this.SourceTable.Name = "SourceTable";
            this.SourceTable.RowCount = 2;
            this.SourceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.SourceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.SourceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SourceTable.Size = new System.Drawing.Size(262, 312);
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
            this.TableLabel.Size = new System.Drawing.Size(256, 18);
            this.TableLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.TableLabel.StyleManager = null;
            this.TableLabel.TabIndex = 0;
            this.TableLabel.Text = "Data Table";
            this.TableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TableLabel.ThemeAuthor = "Terry D. Eppler";
            this.TableLabel.ThemeName = "BudgetExecution";
            this.TableLabel.ToolTip = null;
            // 
            // layout1
            // 
            this.layout1.BackColor = System.Drawing.Color.Transparent;
            this.layout1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.layout1.BindingSource = null;
            this.layout1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.layout1.BorderThickness = 1;
            this.layout1.Children = null;
            this.layout1.Controls.Add(this.TableListBox);
            this.layout1.DataFilter = null;
            this.layout1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.layout1.ForeColor = System.Drawing.Color.Transparent;
            this.layout1.HoverText = null;
            this.layout1.IsDerivedStyle = true;
            this.layout1.Location = new System.Drawing.Point(3, 27);
            this.layout1.Name = "layout1";
            this.layout1.Padding = new System.Windows.Forms.Padding(1);
            this.layout1.Size = new System.Drawing.Size(256, 279);
            this.layout1.Style = MetroSet_UI.Enums.Style.Custom;
            this.layout1.StyleManager = null;
            this.layout1.TabIndex = 2;
            this.layout1.ThemeAuthor = "Terry D. Eppler";
            this.layout1.ThemeName = "BudgetExecution";
            this.layout1.ToolTip = null;
            // 
            // TableListBox
            // 
            this.TableListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TableListBox.BindingSource = null;
            this.TableListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TableListBox.DataFilter = null;
            this.TableListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TableListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TableListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.TableListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.TableListBox.HoverText = null;
            this.TableListBox.IsDerivedStyle = true;
            this.TableListBox.ItemHeight = 28;
            this.TableListBox.Location = new System.Drawing.Point(20, 15);
            this.TableListBox.Margin = new System.Windows.Forms.Padding(1);
            this.TableListBox.MultiSelect = false;
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
            this.TableListBox.Size = new System.Drawing.Size(219, 247);
            this.TableListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.TableListBox.StyleManager = null;
            this.TableListBox.TabIndex = 0;
            this.TableListBox.ThemeAuthor = "Terry D. Eppler";
            this.TableListBox.ThemeName = "BudgetExecution";
            this.TableListBox.ToolTip = null;
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
            this.ClientSize = new System.Drawing.Size(862, 436);
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
            this.SecondPanel.ResumeLayout(false);
            this.SecondTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.FilterTab.ResumeLayout(false);
            this.TableTab.ResumeLayout(false);
            this.ProviderTable.ResumeLayout(false);
            this.ProviderPanel.ResumeLayout(false);
            this.SourceTable.ResumeLayout(false);
            this.layout1.ResumeLayout(false);
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
    public Layout SecondPanel;
    public ListBox SecondListBox;
    public ComboBox SecondComboBox;
    public Label SecondLabel;
    public System.Windows.Forms.TableLayoutPanel SecondTable;
    public Button FirstButton;
    public Button SecondButton;
    public Button ThirdButton;
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
    public TabControl TabControl;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv TableTab;
    public System.Windows.Forms.TableLayoutPanel ProviderTable;
    public Label label2;
    public Layout ProviderPanel;
    private RadioButton AccessRadioButton;
    private RadioButton SqlServerRadioButton;
    private RadioButton SQLiteRadioButton;
    public System.Windows.Forms.TableLayoutPanel SourceTable;
    public Label TableLabel;
    public Layout layout1;
    public ListBox TableListBox;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv FilterTab;
}
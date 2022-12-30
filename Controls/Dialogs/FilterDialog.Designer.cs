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
            this.FirstFilterTable = new System.Windows.Forms.TableLayoutPanel();
            this.FirstFilterPanel = new BudgetExecution.Layout();
            this.FirstListBox = new BudgetExecution.ListBox();
            this.FirstLabel = new BudgetExecution.Label();
            this.FirstComboBox = new BudgetExecution.ComboBox();
            this.ThirdFilterTable = new System.Windows.Forms.TableLayoutPanel();
            this.ThirdLabel = new BudgetExecution.Label();
            this.ThirdComboBox = new BudgetExecution.ComboBox();
            this.ThirdFilterPanel = new BudgetExecution.Layout();
            this.ThirdListBox = new BudgetExecution.ListBox();
            this.SecondFilterPanel = new BudgetExecution.Layout();
            this.SecondListBox = new BudgetExecution.ListBox();
            this.SecondComboBox = new BudgetExecution.ComboBox();
            this.SecondLabel = new BudgetExecution.Label();
            this.SecondFilterTable = new System.Windows.Forms.TableLayoutPanel();
            this.FirstButton = new BudgetExecution.Button();
            this.SecondButton = new BudgetExecution.Button();
            this.ThirdButton = new BudgetExecution.Button();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.FirstFilterTable.SuspendLayout();
            this.FirstFilterPanel.SuspendLayout();
            this.ThirdFilterTable.SuspendLayout();
            this.ThirdFilterPanel.SuspendLayout();
            this.SecondFilterPanel.SuspendLayout();
            this.SecondFilterTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstFilterTable
            // 
            this.FirstFilterTable.ColumnCount = 1;
            this.FirstFilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FirstFilterTable.Controls.Add(this.FirstFilterPanel, 0, 2);
            this.FirstFilterTable.Controls.Add(this.FirstLabel, 0, 0);
            this.FirstFilterTable.Controls.Add(this.FirstComboBox, 0, 1);
            this.FirstFilterTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.FirstFilterTable.Location = new System.Drawing.Point(12, 18);
            this.FirstFilterTable.Name = "FirstFilterTable";
            this.FirstFilterTable.RowCount = 3;
            this.FirstFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FirstFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.FirstFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.FirstFilterTable.Size = new System.Drawing.Size(268, 330);
            this.FirstFilterTable.TabIndex = 5;
            // 
            // FirstFilterPanel
            // 
            this.FirstFilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.FirstFilterPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstFilterPanel.BindingSource = null;
            this.FirstFilterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.FirstFilterPanel.BorderThickness = 1;
            this.FirstFilterPanel.Children = null;
            this.FirstFilterPanel.Controls.Add(this.FirstListBox);
            this.FirstFilterPanel.DataFilter = null;
            this.FirstFilterPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstFilterPanel.ForeColor = System.Drawing.Color.Transparent;
            this.FirstFilterPanel.HoverText = null;
            this.FirstFilterPanel.IsDerivedStyle = true;
            this.FirstFilterPanel.Location = new System.Drawing.Point(3, 57);
            this.FirstFilterPanel.Name = "FirstFilterPanel";
            this.FirstFilterPanel.Padding = new System.Windows.Forms.Padding(1);
            this.FirstFilterPanel.Size = new System.Drawing.Size(262, 265);
            this.FirstFilterPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstFilterPanel.StyleManager = null;
            this.FirstFilterPanel.TabIndex = 2;
            this.FirstFilterPanel.ThemeAuthor = "Terry D. Eppler";
            this.FirstFilterPanel.ThemeName = "BudgetExecution";
            this.FirstFilterPanel.ToolTip = null;
            // 
            // FirstListBox
            // 
            this.FirstListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FirstListBox.BindingSource = null;
            this.FirstListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FirstListBox.DataFilter = null;
            this.FirstListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.FirstListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.FirstListBox.HoverText = null;
            this.FirstListBox.IsDerivedStyle = true;
            this.FirstListBox.ItemHeight = 20;
            this.FirstListBox.Location = new System.Drawing.Point(17, 19);
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
            this.FirstListBox.Size = new System.Drawing.Size(228, 232);
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
            this.FirstLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstLabel.HoverText = null;
            this.FirstLabel.IsDerivedStyle = true;
            this.FirstLabel.Location = new System.Drawing.Point(3, 3);
            this.FirstLabel.Margin = new System.Windows.Forms.Padding(3);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Padding = new System.Windows.Forms.Padding(1);
            this.FirstLabel.Size = new System.Drawing.Size(262, 14);
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
            this.FirstComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
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
            this.FirstComboBox.Location = new System.Drawing.Point(3, 23);
            this.FirstComboBox.MaxDropDownItems = 60;
            this.FirstComboBox.Name = "FirstComboBox";
            this.FirstComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.FirstComboBox.Size = new System.Drawing.Size(262, 30);
            this.FirstComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstComboBox.StyleManager = null;
            this.FirstComboBox.TabIndex = 1;
            this.FirstComboBox.ThemeAuthor = "Terry D. Eppler";
            this.FirstComboBox.ThemeName = "BudgetExecution";
            this.FirstComboBox.ToolTip = null;
            // 
            // ThirdFilterTable
            // 
            this.ThirdFilterTable.ColumnCount = 1;
            this.ThirdFilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ThirdFilterTable.Controls.Add(this.ThirdLabel, 0, 0);
            this.ThirdFilterTable.Controls.Add(this.ThirdComboBox, 0, 1);
            this.ThirdFilterTable.Controls.Add(this.ThirdFilterPanel, 0, 2);
            this.ThirdFilterTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ThirdFilterTable.Location = new System.Drawing.Point(595, 18);
            this.ThirdFilterTable.Name = "ThirdFilterTable";
            this.ThirdFilterTable.RowCount = 3;
            this.ThirdFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ThirdFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.ThirdFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.ThirdFilterTable.Size = new System.Drawing.Size(266, 330);
            this.ThirdFilterTable.TabIndex = 7;
            // 
            // ThirdLabel
            // 
            this.ThirdLabel.BindingSource = null;
            this.ThirdLabel.DataFilter = null;
            this.ThirdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThirdLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThirdLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdLabel.HoverText = null;
            this.ThirdLabel.IsDerivedStyle = true;
            this.ThirdLabel.Location = new System.Drawing.Point(3, 3);
            this.ThirdLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ThirdLabel.Name = "ThirdLabel";
            this.ThirdLabel.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdLabel.Size = new System.Drawing.Size(260, 14);
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
            this.ThirdComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
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
            this.ThirdComboBox.Location = new System.Drawing.Point(3, 23);
            this.ThirdComboBox.MaxDropDownItems = 60;
            this.ThirdComboBox.Name = "ThirdComboBox";
            this.ThirdComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.ThirdComboBox.Size = new System.Drawing.Size(260, 30);
            this.ThirdComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdComboBox.StyleManager = null;
            this.ThirdComboBox.TabIndex = 1;
            this.ThirdComboBox.ThemeAuthor = "Terry D. Eppler";
            this.ThirdComboBox.ThemeName = "BudgetExecution";
            this.ThirdComboBox.ToolTip = null;
            // 
            // ThirdFilterPanel
            // 
            this.ThirdFilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.ThirdFilterPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdFilterPanel.BindingSource = null;
            this.ThirdFilterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ThirdFilterPanel.BorderThickness = 1;
            this.ThirdFilterPanel.Children = null;
            this.ThirdFilterPanel.Controls.Add(this.ThirdListBox);
            this.ThirdFilterPanel.DataFilter = null;
            this.ThirdFilterPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdFilterPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ThirdFilterPanel.HoverText = null;
            this.ThirdFilterPanel.IsDerivedStyle = true;
            this.ThirdFilterPanel.Location = new System.Drawing.Point(3, 57);
            this.ThirdFilterPanel.Name = "ThirdFilterPanel";
            this.ThirdFilterPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdFilterPanel.Size = new System.Drawing.Size(260, 265);
            this.ThirdFilterPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdFilterPanel.StyleManager = null;
            this.ThirdFilterPanel.TabIndex = 2;
            this.ThirdFilterPanel.ThemeAuthor = "Terry D. Eppler";
            this.ThirdFilterPanel.ThemeName = "BudgetExecution";
            this.ThirdFilterPanel.ToolTip = null;
            // 
            // ThirdListBox
            // 
            this.ThirdListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ThirdListBox.BindingSource = null;
            this.ThirdListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ThirdListBox.DataFilter = null;
            this.ThirdListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ThirdListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.ThirdListBox.HoverText = null;
            this.ThirdListBox.IsDerivedStyle = true;
            this.ThirdListBox.ItemHeight = 20;
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
            this.ThirdListBox.Size = new System.Drawing.Size(228, 232);
            this.ThirdListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdListBox.StyleManager = null;
            this.ThirdListBox.TabIndex = 0;
            this.ThirdListBox.ThemeAuthor = "Terry D. Eppler";
            this.ThirdListBox.ThemeName = "BudgetExecution";
            this.ThirdListBox.ToolTip = null;
            // 
            // SecondFilterPanel
            // 
            this.SecondFilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.SecondFilterPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondFilterPanel.BindingSource = null;
            this.SecondFilterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SecondFilterPanel.BorderThickness = 1;
            this.SecondFilterPanel.Children = null;
            this.SecondFilterPanel.Controls.Add(this.SecondListBox);
            this.SecondFilterPanel.DataFilter = null;
            this.SecondFilterPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondFilterPanel.ForeColor = System.Drawing.Color.Transparent;
            this.SecondFilterPanel.HoverText = null;
            this.SecondFilterPanel.IsDerivedStyle = true;
            this.SecondFilterPanel.Location = new System.Drawing.Point(3, 57);
            this.SecondFilterPanel.Name = "SecondFilterPanel";
            this.SecondFilterPanel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondFilterPanel.Size = new System.Drawing.Size(260, 265);
            this.SecondFilterPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondFilterPanel.StyleManager = null;
            this.SecondFilterPanel.TabIndex = 2;
            this.SecondFilterPanel.ThemeAuthor = "Terry D. Eppler";
            this.SecondFilterPanel.ThemeName = "BudgetExecution";
            this.SecondFilterPanel.ToolTip = null;
            // 
            // SecondListBox
            // 
            this.SecondListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SecondListBox.BindingSource = null;
            this.SecondListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SecondListBox.DataFilter = null;
            this.SecondListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SecondListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.SecondListBox.HoverText = null;
            this.SecondListBox.IsDerivedStyle = true;
            this.SecondListBox.ItemHeight = 20;
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
            this.SecondListBox.Size = new System.Drawing.Size(228, 232);
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
            this.SecondComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
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
            this.SecondComboBox.Location = new System.Drawing.Point(3, 23);
            this.SecondComboBox.MaxDropDownItems = 60;
            this.SecondComboBox.Name = "SecondComboBox";
            this.SecondComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.SecondComboBox.Size = new System.Drawing.Size(260, 30);
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
            this.SecondLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondLabel.HoverText = null;
            this.SecondLabel.IsDerivedStyle = true;
            this.SecondLabel.Location = new System.Drawing.Point(3, 3);
            this.SecondLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondLabel.Size = new System.Drawing.Size(260, 14);
            this.SecondLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondLabel.StyleManager = null;
            this.SecondLabel.TabIndex = 0;
            this.SecondLabel.Text = "Second Category";
            this.SecondLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SecondLabel.ThemeAuthor = "Terry D. Eppler";
            this.SecondLabel.ThemeName = "BudgetExecution";
            this.SecondLabel.ToolTip = null;
            // 
            // SecondFilterTable
            // 
            this.SecondFilterTable.ColumnCount = 1;
            this.SecondFilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SecondFilterTable.Controls.Add(this.SecondLabel, 0, 0);
            this.SecondFilterTable.Controls.Add(this.SecondComboBox, 0, 1);
            this.SecondFilterTable.Controls.Add(this.SecondFilterPanel, 0, 2);
            this.SecondFilterTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.SecondFilterTable.Location = new System.Drawing.Point(304, 18);
            this.SecondFilterTable.Name = "SecondFilterTable";
            this.SecondFilterTable.RowCount = 3;
            this.SecondFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SecondFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.SecondFilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.SecondFilterTable.Size = new System.Drawing.Size(266, 330);
            this.SecondFilterTable.TabIndex = 6;
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
            this.FirstButton.Location = new System.Drawing.Point(33, 354);
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
            this.SecondButton.Location = new System.Drawing.Point(324, 354);
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
            this.ThirdButton.Location = new System.Drawing.Point(617, 354);
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
            this.CaptionFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(878, 417);
            this.Controls.Add(this.FirstFilterTable);
            this.Controls.Add(this.ThirdButton);
            this.Controls.Add(this.SecondButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.ThirdFilterTable);
            this.Controls.Add(this.SecondFilterTable);
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
            this.FirstFilterTable.ResumeLayout(false);
            this.FirstFilterPanel.ResumeLayout(false);
            this.ThirdFilterTable.ResumeLayout(false);
            this.ThirdFilterPanel.ResumeLayout(false);
            this.SecondFilterPanel.ResumeLayout(false);
            this.SecondFilterTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.TableLayoutPanel FirstFilterTable;
    public Label FirstLabel;
    public ComboBox FirstComboBox;
    public Layout FirstFilterPanel;
    public ListBox FirstListBox;
    public System.Windows.Forms.TableLayoutPanel ThirdFilterTable;
    public Label ThirdLabel;
    public ComboBox ThirdComboBox;
    public Layout ThirdFilterPanel;
    public ListBox ThirdListBox;
    public Layout SecondFilterPanel;
    public ListBox SecondListBox;
    public ComboBox SecondComboBox;
    public Label SecondLabel;
    public System.Windows.Forms.TableLayoutPanel SecondFilterTable;
    public Button FirstButton;
    public Button SecondButton;
    public Button ThirdButton;
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
}
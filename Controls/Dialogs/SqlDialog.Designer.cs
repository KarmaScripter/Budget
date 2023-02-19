// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class SqlDialog
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
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlDialog));
            this.TabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.SqlCommandTable = new System.Windows.Forms.TableLayoutPanel();
            this.SecondPanel = new BudgetExecution.Layout();
            this.FirstLabel = new BudgetExecution.Label();
            this.SqlServerRadioButton = new BudgetExecution.RadioButton();
            this.AccessRadioButton = new BudgetExecution.RadioButton();
            this.ToollTip = new BudgetExecution.SmallTip();
            this.SQLiteRadioButton = new BudgetExecution.RadioButton();
            this.SqlCeRadioButton = new BudgetExecution.RadioButton();
            this.ThirdPanel = new BudgetExecution.Layout();
            this.SqlComboBox = new BudgetExecution.ComboBox();
            this.SecondLabel = new BudgetExecution.Label();
            this.FifithPanel = new BudgetExecution.Layout();
            this.ThirdLabel = new BudgetExecution.Label();
            this.SqlListBox = new BudgetExecution.ListBox();
            this.EditorPanel = new BudgetExecution.Layout();
            this.Editor = new BudgetExecution.Editor();
            this.FirstButton = new BudgetExecution.Button();
            this.SecondButton = new BudgetExecution.Button();
            this.ThirdButton = new BudgetExecution.Button();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.SqlCommandTable.SuspendLayout();
            this.SecondPanel.SuspendLayout();
            this.ThirdPanel.SuspendLayout();
            this.FifithPanel.SuspendLayout();
            this.EditorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ActiveTabFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.BeforeTouchSize = new System.Drawing.Size(1380, 556);
            this.TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabControl.BorderWidth = 1;
            this.TabControl.CanOverrideStyle = true;
            this.TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.Controls.Add(this.TabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.FocusOnTabClick = false;
            this.TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ItemSize = new System.Drawing.Size(158, 23);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(1);
            this.TabControl.Name = "TabControl";
            this.TabControl.Size = new System.Drawing.Size(1380, 556);
            this.TabControl.TabIndex = 9;
            this.TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.TabControl.ThemeName = "TabRendererMetro";
            this.TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.DisabledTabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.EditableTabStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.EditableTabStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            this.TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveCloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.White;
            this.TabControl.ThemeStyle.TabStyle.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            // 
            // TabPage
            // 
            this.TabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabPage.Controls.Add(this.SqlCommandTable);
            this.TabPage.Controls.Add(this.EditorPanel);
            this.TabPage.Image = null;
            this.TabPage.ImageSize = new System.Drawing.Size(14, 14);
            this.TabPage.Location = new System.Drawing.Point(0, 22);
            this.TabPage.Margin = new System.Windows.Forms.Padding(1);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage.ShowCloseButton = true;
            this.TabPage.Size = new System.Drawing.Size(1380, 534);
            this.TabPage.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabPage.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TabPage.TabIndex = 8;
            this.TabPage.ThemesEnabled = false;
            // 
            // SqlCommandTable
            // 
            this.SqlCommandTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SqlCommandTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SqlCommandTable.ColumnCount = 1;
            this.SqlCommandTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SqlCommandTable.Controls.Add(this.SecondPanel, 0, 0);
            this.SqlCommandTable.Controls.Add(this.ThirdPanel, 0, 1);
            this.SqlCommandTable.Controls.Add(this.FifithPanel, 0, 2);
            this.SqlCommandTable.Location = new System.Drawing.Point(1007, 21);
            this.SqlCommandTable.Name = "SqlCommandTable";
            this.SqlCommandTable.RowCount = 3;
            this.SqlCommandTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SqlCommandTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.SqlCommandTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.SqlCommandTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SqlCommandTable.Size = new System.Drawing.Size(352, 508);
            this.SqlCommandTable.TabIndex = 4;
            // 
            // SecondPanel
            // 
            this.SecondPanel.BackColor = System.Drawing.Color.Transparent;
            this.SecondPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondPanel.BindingSource = null;
            this.SecondPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SecondPanel.BorderThickness = 1;
            this.SecondPanel.Children = null;
            this.SecondPanel.Controls.Add(this.FirstLabel);
            this.SecondPanel.Controls.Add(this.SqlServerRadioButton);
            this.SecondPanel.Controls.Add(this.AccessRadioButton);
            this.SecondPanel.Controls.Add(this.SQLiteRadioButton);
            this.SecondPanel.Controls.Add(this.SqlCeRadioButton);
            this.SecondPanel.DataFilter = null;
            this.SecondPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondPanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPanel.ForeColor = System.Drawing.Color.Transparent;
            this.SecondPanel.HoverText = null;
            this.SecondPanel.IsDerivedStyle = true;
            this.SecondPanel.Location = new System.Drawing.Point(3, 3);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondPanel.Size = new System.Drawing.Size(346, 99);
            this.SecondPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondPanel.StyleManager = null;
            this.SecondPanel.TabIndex = 3;
            this.SecondPanel.ThemeAuthor = "Terry D. Eppler";
            this.SecondPanel.ThemeName = "Budget Execution";
            this.SecondPanel.ToolTip = null;
            // 
            // FirstLabel
            // 
            this.FirstLabel.BindingSource = null;
            this.FirstLabel.DataFilter = null;
            this.FirstLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstLabel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstLabel.HoverText = null;
            this.FirstLabel.IsDerivedStyle = true;
            this.FirstLabel.Location = new System.Drawing.Point(1, 1);
            this.FirstLabel.Margin = new System.Windows.Forms.Padding(3);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Padding = new System.Windows.Forms.Padding(1);
            this.FirstLabel.Size = new System.Drawing.Size(344, 25);
            this.FirstLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstLabel.StyleManager = null;
            this.FirstLabel.TabIndex = 3;
            this.FirstLabel.Text = "Providers";
            this.FirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstLabel.ThemeAuthor = "Terry D. Eppler";
            this.FirstLabel.ThemeName = "Budget Execution";
            this.FirstLabel.ToolTip = null;
            // 
            // SqlServerRadioButton
            // 
            this.SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqlServerRadioButton.Checked = false;
            this.SqlServerRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            this.SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SqlServerRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqlServerRadioButton.Group = 0;
            this.SqlServerRadioButton.HoverText = null;
            this.SqlServerRadioButton.IsDerivedStyle = true;
            this.SqlServerRadioButton.Location = new System.Drawing.Point(256, 48);
            this.SqlServerRadioButton.Name = "SqlServerRadioButton";
            this.SqlServerRadioButton.Padding = new System.Windows.Forms.Padding(3);
            this.SqlServerRadioButton.Result = null;
            this.SqlServerRadioButton.Size = new System.Drawing.Size(86, 17);
            this.SqlServerRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SqlServerRadioButton.StyleManager = null;
            this.SqlServerRadioButton.TabIndex = 2;
            this.SqlServerRadioButton.Tag = "SqlServer";
            this.SqlServerRadioButton.Text = "SQL Server";
            this.SqlServerRadioButton.ThemeAuthor = "Terry D. Eppler";
            this.SqlServerRadioButton.ThemeName = "Budget Execution";
            this.SqlServerRadioButton.ToolTip = null;
            // 
            // AccessRadioButton
            // 
            this.AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AccessRadioButton.Checked = false;
            this.AccessRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            this.AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AccessRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccessRadioButton.Group = 0;
            this.AccessRadioButton.HoverText = null;
            this.AccessRadioButton.IsDerivedStyle = true;
            this.AccessRadioButton.Location = new System.Drawing.Point(15, 48);
            this.AccessRadioButton.Name = "AccessRadioButton";
            this.AccessRadioButton.Padding = new System.Windows.Forms.Padding(3);
            this.AccessRadioButton.Result = null;
            this.AccessRadioButton.Size = new System.Drawing.Size(64, 17);
            this.AccessRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.AccessRadioButton.StyleManager = null;
            this.AccessRadioButton.TabIndex = 0;
            this.AccessRadioButton.Tag = "Access";
            this.AccessRadioButton.Text = "Access";
            this.AccessRadioButton.ThemeAuthor = "Terry D. Eppler";
            this.AccessRadioButton.ThemeName = "Budget Execution";
            this.AccessRadioButton.ToolTip = this.ToollTip;
            // 
            // ToollTip
            // 
            this.ToollTip.AutoPopDelay = 5000;
            this.ToollTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToollTip.BindingSource = null;
            this.ToollTip.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ToollTip.ForeColor = System.Drawing.Color.White;
            this.ToollTip.InitialDelay = 500;
            this.ToollTip.IsDerivedStyle = true;
            this.ToollTip.Name = null;
            this.ToollTip.OwnerDraw = true;
            this.ToollTip.ReshowDelay = 100;
            this.ToollTip.Style = MetroSet_UI.Enums.Style.Custom;
            this.ToollTip.StyleManager = null;
            this.ToollTip.ThemeAuthor = "Terry D. Eppler";
            this.ToollTip.ThemeName = "Budget Execution";
            this.ToollTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToollTip.TipText = null;
            this.ToollTip.TipTitle = null;
            // 
            // SQLiteRadioButton
            // 
            this.SQLiteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SQLiteRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SQLiteRadioButton.Checked = false;
            this.SQLiteRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            this.SQLiteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.SQLiteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SQLiteRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SQLiteRadioButton.Group = 0;
            this.SQLiteRadioButton.HoverText = null;
            this.SQLiteRadioButton.IsDerivedStyle = true;
            this.SQLiteRadioButton.Location = new System.Drawing.Point(85, 48);
            this.SQLiteRadioButton.Name = "SQLiteRadioButton";
            this.SQLiteRadioButton.Padding = new System.Windows.Forms.Padding(3);
            this.SQLiteRadioButton.Result = null;
            this.SQLiteRadioButton.Size = new System.Drawing.Size(64, 17);
            this.SQLiteRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SQLiteRadioButton.StyleManager = null;
            this.SQLiteRadioButton.TabIndex = 1;
            this.SQLiteRadioButton.Tag = "SQLite";
            this.SQLiteRadioButton.Text = "SQLite";
            this.SQLiteRadioButton.ThemeAuthor = "Terry D. Eppler";
            this.SQLiteRadioButton.ThemeName = "Budget Execution";
            this.SQLiteRadioButton.ToolTip = null;
            // 
            // SqlCeRadioButton
            // 
            this.SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqlCeRadioButton.Checked = false;
            this.SqlCeRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            this.SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SqlCeRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqlCeRadioButton.Group = 0;
            this.SqlCeRadioButton.HoverText = null;
            this.SqlCeRadioButton.IsDerivedStyle = true;
            this.SqlCeRadioButton.Location = new System.Drawing.Point(155, 48);
            this.SqlCeRadioButton.Name = "SqlCeRadioButton";
            this.SqlCeRadioButton.Padding = new System.Windows.Forms.Padding(3);
            this.SqlCeRadioButton.Result = null;
            this.SqlCeRadioButton.Size = new System.Drawing.Size(95, 17);
            this.SqlCeRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SqlCeRadioButton.StyleManager = null;
            this.SqlCeRadioButton.TabIndex = 1;
            this.SqlCeRadioButton.Tag = "SqlCe";
            this.SqlCeRadioButton.Text = "SQL Compact";
            this.SqlCeRadioButton.ThemeAuthor = "Terry D. Eppler";
            this.SqlCeRadioButton.ThemeName = "Budget Execution";
            this.SqlCeRadioButton.ToolTip = null;
            // 
            // ThirdPanel
            // 
            this.ThirdPanel.BackColor = System.Drawing.Color.Transparent;
            this.ThirdPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ThirdPanel.BindingSource = null;
            this.ThirdPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ThirdPanel.BorderThickness = 1;
            this.ThirdPanel.Children = null;
            this.ThirdPanel.Controls.Add(this.SqlComboBox);
            this.ThirdPanel.Controls.Add(this.SecondLabel);
            this.ThirdPanel.DataFilter = null;
            this.ThirdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThirdPanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ThirdPanel.HoverText = null;
            this.ThirdPanel.IsDerivedStyle = true;
            this.ThirdPanel.Location = new System.Drawing.Point(3, 108);
            this.ThirdPanel.Name = "ThirdPanel";
            this.ThirdPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdPanel.Size = new System.Drawing.Size(346, 96);
            this.ThirdPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdPanel.StyleManager = null;
            this.ThirdPanel.TabIndex = 2;
            this.ThirdPanel.ThemeAuthor = "Terry D. Eppler";
            this.ThirdPanel.ThemeName = "Budget Execution";
            this.ThirdPanel.ToolTip = null;
            // 
            // SqlComboBox
            // 
            this.SqlComboBox.AllowDrop = true;
            this.SqlComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SqlComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqlComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SqlComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqlComboBox.BindingSource = null;
            this.SqlComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SqlComboBox.CausesValidation = false;
            this.SqlComboBox.DataFilter = null;
            this.SqlComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            this.SqlComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.SqlComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            this.SqlComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SqlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SqlComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SqlComboBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqlComboBox.FormattingEnabled = true;
            this.SqlComboBox.HoverText = null;
            this.SqlComboBox.IsDerivedStyle = true;
            this.SqlComboBox.ItemHeight = 24;
            this.SqlComboBox.Location = new System.Drawing.Point(45, 42);
            this.SqlComboBox.Name = "SqlComboBox";
            this.SqlComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqlComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.SqlComboBox.Size = new System.Drawing.Size(258, 30);
            this.SqlComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.SqlComboBox.StyleManager = null;
            this.SqlComboBox.TabIndex = 0;
            this.SqlComboBox.ThemeAuthor = "Terry D. Eppler";
            this.SqlComboBox.ThemeName = "Budget Execution";
            this.SqlComboBox.ToolTip = null;
            // 
            // SecondLabel
            // 
            this.SecondLabel.BindingSource = null;
            this.SecondLabel.DataFilter = null;
            this.SecondLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondLabel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondLabel.HoverText = null;
            this.SecondLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SecondLabel.IsDerivedStyle = true;
            this.SecondLabel.Location = new System.Drawing.Point(1, 1);
            this.SecondLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondLabel.Size = new System.Drawing.Size(344, 26);
            this.SecondLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondLabel.StyleManager = null;
            this.SecondLabel.TabIndex = 4;
            this.SecondLabel.Text = "Commands";
            this.SecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SecondLabel.ThemeAuthor = "Terry D. Eppler";
            this.SecondLabel.ThemeName = "Budget Execution";
            this.SecondLabel.ToolTip = null;
            // 
            // FifithPanel
            // 
            this.FifithPanel.BackColor = System.Drawing.Color.Transparent;
            this.FifithPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FifithPanel.BindingSource = null;
            this.FifithPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.FifithPanel.BorderThickness = 1;
            this.FifithPanel.Children = null;
            this.FifithPanel.Controls.Add(this.ThirdLabel);
            this.FifithPanel.Controls.Add(this.SqlListBox);
            this.FifithPanel.DataFilter = null;
            this.FifithPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FifithPanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FifithPanel.ForeColor = System.Drawing.Color.Transparent;
            this.FifithPanel.HoverText = null;
            this.FifithPanel.IsDerivedStyle = true;
            this.FifithPanel.Location = new System.Drawing.Point(3, 210);
            this.FifithPanel.Name = "FifithPanel";
            this.FifithPanel.Padding = new System.Windows.Forms.Padding(1);
            this.FifithPanel.Size = new System.Drawing.Size(346, 295);
            this.FifithPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FifithPanel.StyleManager = null;
            this.FifithPanel.TabIndex = 1;
            this.FifithPanel.ThemeAuthor = "Terry D. Eppler";
            this.FifithPanel.ThemeName = "Budget Execution";
            this.FifithPanel.ToolTip = null;
            // 
            // ThirdLabel
            // 
            this.ThirdLabel.BindingSource = null;
            this.ThirdLabel.DataFilter = null;
            this.ThirdLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThirdLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThirdLabel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdLabel.HoverText = null;
            this.ThirdLabel.IsDerivedStyle = true;
            this.ThirdLabel.Location = new System.Drawing.Point(1, 1);
            this.ThirdLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ThirdLabel.Name = "ThirdLabel";
            this.ThirdLabel.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdLabel.Size = new System.Drawing.Size(344, 26);
            this.ThirdLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdLabel.StyleManager = null;
            this.ThirdLabel.TabIndex = 4;
            this.ThirdLabel.Text = "Statements";
            this.ThirdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThirdLabel.ThemeAuthor = "Terry D. Eppler";
            this.ThirdLabel.ThemeName = "Budget Execution";
            this.ThirdLabel.ToolTip = null;
            // 
            // SqlListBox
            // 
            this.SqlListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SqlListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SqlListBox.BindingSource = null;
            this.SqlListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SqlListBox.DataFilter = null;
            this.SqlListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SqlListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SqlListBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqlListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SqlListBox.HoveredItemColor = System.Drawing.Color.White;
            this.SqlListBox.HoverText = null;
            this.SqlListBox.IsDerivedStyle = true;
            this.SqlListBox.ItemHeight = 28;
            this.SqlListBox.Location = new System.Drawing.Point(15, 42);
            this.SqlListBox.Margin = new System.Windows.Forms.Padding(1);
            this.SqlListBox.MultiSelect = true;
            this.SqlListBox.Name = "SqlListBox";
            this.SqlListBox.Padding = new System.Windows.Forms.Padding(1);
            this.SqlListBox.SelectedIndex = -1;
            this.SqlListBox.SelectedItem = null;
            this.SqlListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqlListBox.SelectedItemColor = System.Drawing.Color.White;
            this.SqlListBox.SelectedText = null;
            this.SqlListBox.SelectedValue = null;
            this.SqlListBox.ShowBorder = false;
            this.SqlListBox.ShowScrollBar = false;
            this.SqlListBox.Size = new System.Drawing.Size(317, 235);
            this.SqlListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.SqlListBox.StyleManager = null;
            this.SqlListBox.TabIndex = 0;
            this.SqlListBox.ThemeAuthor = "Terry D. Eppler";
            this.SqlListBox.ThemeName = "Budget Execution";
            this.SqlListBox.ToolTip = null;
            // 
            // EditorPanel
            // 
            this.EditorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorPanel.BackColor = System.Drawing.Color.Transparent;
            this.EditorPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.EditorPanel.BindingSource = null;
            this.EditorPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.EditorPanel.BorderThickness = 1;
            this.EditorPanel.Children = null;
            this.EditorPanel.Controls.Add(this.Editor);
            this.EditorPanel.DataFilter = null;
            this.EditorPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditorPanel.ForeColor = System.Drawing.Color.Transparent;
            this.EditorPanel.HoverText = null;
            this.EditorPanel.IsDerivedStyle = true;
            this.EditorPanel.Location = new System.Drawing.Point(30, 21);
            this.EditorPanel.Name = "EditorPanel";
            this.EditorPanel.Padding = new System.Windows.Forms.Padding(1);
            this.EditorPanel.Size = new System.Drawing.Size(971, 509);
            this.EditorPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.EditorPanel.StyleManager = null;
            this.EditorPanel.TabIndex = 0;
            this.EditorPanel.ThemeAuthor = "Terry D. Eppler";
            this.EditorPanel.ThemeName = "BudgetExecution";
            this.EditorPanel.ToolTip = null;
            // 
            // Editor
            // 
            this.Editor.AllowZoom = false;
            this.Editor.AlwaysShowScrollers = true;
            this.Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Editor.CanOverrideStyle = true;
            this.Editor.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.Editor.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.Editor.ColumnGuidesMeasuringFont = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Editor.Configurator = config1;
            this.Editor.ContextChoiceBackColor = System.Drawing.Color.LightGray;
            this.Editor.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.Editor.ContextPromptBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Editor.ContextTooltipBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Editor.CurrentLineHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.Editor.DefaultNewLineStyle = Syncfusion.IO.NewLineStyle.Windows;
            this.Editor.EndOfLineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Editor.EndOfLineForeColor = System.Drawing.Color.DimGray;
            this.Editor.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Editor.ForeColor = System.Drawing.Color.LightGray;
            this.Editor.HighlightCurrentLine = true;
            this.Editor.IndentationBlockBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Editor.IndentLineColor = System.Drawing.Color.LightGray;
            this.Editor.IndicatorMarginBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Editor.LineNumbersColor = System.Drawing.Color.DarkGray;
            this.Editor.LineNumbersFont = new System.Drawing.Font("Hack", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Editor.Location = new System.Drawing.Point(18, 18);
            this.Editor.Name = "Editor";
            this.Editor.RenderRightToLeft = false;
            this.Editor.ScrollColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Black;
            this.Editor.ScrollPosition = new System.Drawing.Point(0, 0);
            this.Editor.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            this.Editor.SelectionTextColor = System.Drawing.Color.White;
            this.Editor.ShowEndOfLine = true;
            this.Editor.Size = new System.Drawing.Size(931, 469);
            this.Editor.StatusBarSettings.CoordsPanel.Width = 150;
            this.Editor.StatusBarSettings.EncodingPanel.Width = 100;
            this.Editor.StatusBarSettings.FileNamePanel.Width = 100;
            this.Editor.StatusBarSettings.InsertPanel.Width = 33;
            this.Editor.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.Editor.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.Editor.StatusBarSettings.StatusPanel.Width = 70;
            this.Editor.StatusBarSettings.TextPanel.Width = 214;
            this.Editor.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Office2016Black;
            this.Editor.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Black;
            this.Editor.TabIndex = 0;
            this.Editor.TabSize = 4;
            this.Editor.Text = "";
            this.Editor.TextAreaWidth = 400;
            this.Editor.ThemeName = "Office2016Black";
            this.Editor.UseXPStyle = false;
            this.Editor.UseXPStyleBorder = true;
            this.Editor.VisualColumn = 1;
            this.Editor.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.Editor.WordWrap = true;
            this.Editor.WordWrapColumn = 80;
            this.Editor.ZoomFactor = 1F;
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstButton.BackColor = System.Drawing.Color.Transparent;
            this.FirstButton.BindingSource = null;
            this.FirstButton.DataFilter = null;
            this.FirstButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.FirstButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.FirstButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.FirstButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.FirstButton.HoverText = "Not Yet Implemented!";
            this.FirstButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.FirstButton.IsDerivedStyle = true;
            this.FirstButton.Location = new System.Drawing.Point(30, 598);
            this.FirstButton.Margin = new System.Windows.Forms.Padding(0);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.FirstButton.NormalColor = System.Drawing.Color.Transparent;
            this.FirstButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.Padding = new System.Windows.Forms.Padding(1);
            this.FirstButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.PressTextColor = System.Drawing.Color.White;
            this.FirstButton.Size = new System.Drawing.Size(140, 40);
            this.FirstButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstButton.StyleManager = null;
            this.FirstButton.TabIndex = 12;
            this.FirstButton.Text = "Select";
            this.FirstButton.ThemeAuthor = "Terry D. Eppler";
            this.FirstButton.ThemeName = "BudgetExecution";
            this.FirstButton.ToolTip = null;
            // 
            // SecondButton
            // 
            this.SecondButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondButton.BackColor = System.Drawing.Color.Transparent;
            this.SecondButton.BindingSource = null;
            this.SecondButton.DataFilter = null;
            this.SecondButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.SecondButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.SecondButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.SecondButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SecondButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SecondButton.HoverText = "Not Yet Implemented!";
            this.SecondButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.SecondButton.IsDerivedStyle = true;
            this.SecondButton.Location = new System.Drawing.Point(623, 598);
            this.SecondButton.Margin = new System.Windows.Forms.Padding(0);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.SecondButton.NormalColor = System.Drawing.Color.Transparent;
            this.SecondButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.Padding = new System.Windows.Forms.Padding(1);
            this.SecondButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.PressTextColor = System.Drawing.Color.White;
            this.SecondButton.Size = new System.Drawing.Size(140, 40);
            this.SecondButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondButton.StyleManager = null;
            this.SecondButton.TabIndex = 10;
            this.SecondButton.Text = "Clear";
            this.SecondButton.ThemeAuthor = "Terry D. Eppler";
            this.SecondButton.ThemeName = "BudgetExecution";
            this.SecondButton.ToolTip = null;
            // 
            // ThirdButton
            // 
            this.ThirdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThirdButton.BackColor = System.Drawing.Color.Transparent;
            this.ThirdButton.BindingSource = null;
            this.ThirdButton.DataFilter = null;
            this.ThirdButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.ThirdButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.ThirdButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.ThirdButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ThirdButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ThirdButton.HoverText = "Close Window";
            this.ThirdButton.HoverTextColor = System.Drawing.Color.White;
            this.ThirdButton.IsDerivedStyle = true;
            this.ThirdButton.Location = new System.Drawing.Point(1200, 598);
            this.ThirdButton.Margin = new System.Windows.Forms.Padding(0);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.ThirdButton.NormalColor = System.Drawing.Color.Transparent;
            this.ThirdButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.PressTextColor = System.Drawing.Color.White;
            this.ThirdButton.Size = new System.Drawing.Size(140, 40);
            this.ThirdButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdButton.StyleManager = null;
            this.ThirdButton.TabIndex = 11;
            this.ThirdButton.Text = "Close";
            this.ThirdButton.ThemeAuthor = "Terry D. Eppler";
            this.ThirdButton.ThemeName = "BudgetExecution";
            this.ThirdButton.ToolTip = null;
            // 
            // SqlDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientSize = new System.Drawing.Size(1380, 675);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.SecondButton);
            this.Controls.Add(this.ThirdButton);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SqlDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPage.ResumeLayout(false);
            this.SqlCommandTable.ResumeLayout(false);
            this.SecondPanel.ResumeLayout(false);
            this.ThirdPanel.ResumeLayout(false);
            this.FifithPanel.ResumeLayout(false);
            this.EditorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv TabPage;
    public Button FirstButton;
    public Button SecondButton;
    public Button ThirdButton;
    public Layout EditorPanel;
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToollTip;
    private System.Windows.Forms.TableLayoutPanel SqlCommandTable;
    private Layout SecondPanel;
    public RadioButton SqlServerRadioButton;
    public RadioButton SqlCeRadioButton;
    public RadioButton SQLiteRadioButton;
    private Layout ThirdPanel;
    private ComboBox SqlComboBox;
    private Label SecondLabel;
    private Layout FifithPanel;
    private ListBox SqlListBox;
    private Label ThirdLabel;
    public RadioButton AccessRadioButton;
    public Label FirstLabel;
    public Editor Editor;
}
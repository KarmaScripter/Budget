// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class SchemaDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchemaDialog));
            this.SecondButton = new BudgetExecution.Button();
            this.ThirdButton = new BudgetExecution.Button();
            this.FirstPanel = new BudgetExecution.Layout();
            this.FieldsListBox = new BudgetExecution.ListBox();
            this.FirstButton = new BudgetExecution.Button();
            this.SecondPanel = new BudgetExecution.Layout();
            this.NumericsListBox = new BudgetExecution.ListBox();
            this.FirstLabel = new BudgetExecution.Label();
            this.SecondLabel = new BudgetExecution.Label();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.FirstTable = new System.Windows.Forms.TableLayoutPanel();
            this.SecondTable = new System.Windows.Forms.TableLayoutPanel();
            this.SelectionsTextBox = new BudgetExecution.TextBox();
            this.label1 = new BudgetExecution.Label();
            this.FirstPanel.SuspendLayout();
            this.SecondPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.FirstTable.SuspendLayout();
            this.SecondTable.SuspendLayout();
            this.SuspendLayout();
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
            this.SecondButton.Location = new System.Drawing.Point(277, 437);
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
            this.SecondButton.TabIndex = 0;
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
            this.ThirdButton.Location = new System.Drawing.Point(484, 437);
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
            this.ThirdButton.TabIndex = 1;
            this.ThirdButton.Text = "Close";
            this.ThirdButton.ThemeAuthor = "Terry D. Eppler";
            this.ThirdButton.ThemeName = "BudgetExecution";
            this.ThirdButton.ToolTip = null;
            // 
            // FirstPanel
            // 
            this.FirstPanel.BackColor = System.Drawing.Color.Transparent;
            this.FirstPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FirstPanel.BindingSource = null;
            this.FirstPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.FirstPanel.BorderThickness = 1;
            this.FirstPanel.Children = null;
            this.FirstPanel.Controls.Add(this.FieldsListBox);
            this.FirstPanel.DataFilter = null;
            this.FirstPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstPanel.ForeColor = System.Drawing.Color.Transparent;
            this.FirstPanel.HoverText = null;
            this.FirstPanel.IsDerivedStyle = true;
            this.FirstPanel.Location = new System.Drawing.Point(3, 35);
            this.FirstPanel.Name = "FirstPanel";
            this.FirstPanel.Padding = new System.Windows.Forms.Padding(1);
            this.FirstPanel.Size = new System.Drawing.Size(239, 264);
            this.FirstPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstPanel.StyleManager = null;
            this.FirstPanel.TabIndex = 3;
            this.FirstPanel.ThemeAuthor = "Terry D. Eppler";
            this.FirstPanel.ThemeName = "BudgetExecution";
            this.FirstPanel.ToolTip = null;
            // 
            // FieldsListBox
            // 
            this.FieldsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FieldsListBox.BindingSource = null;
            this.FieldsListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.FieldsListBox.DataFilter = null;
            this.FieldsListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FieldsListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FieldsListBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FieldsListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.FieldsListBox.HoveredItemColor = System.Drawing.Color.White;
            this.FieldsListBox.HoverText = null;
            this.FieldsListBox.IsDerivedStyle = true;
            this.FieldsListBox.ItemHeight = 28;
            this.FieldsListBox.Location = new System.Drawing.Point(11, 14);
            this.FieldsListBox.Margin = new System.Windows.Forms.Padding(1);
            this.FieldsListBox.MultiSelect = true;
            this.FieldsListBox.Name = "FieldsListBox";
            this.FieldsListBox.Padding = new System.Windows.Forms.Padding(1);
            this.FieldsListBox.SelectedIndex = -1;
            this.FieldsListBox.SelectedItem = null;
            this.FieldsListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FieldsListBox.SelectedItemColor = System.Drawing.Color.White;
            this.FieldsListBox.SelectedText = null;
            this.FieldsListBox.SelectedValue = null;
            this.FieldsListBox.ShowBorder = false;
            this.FieldsListBox.ShowScrollBar = false;
            this.FieldsListBox.Size = new System.Drawing.Size(214, 234);
            this.FieldsListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.FieldsListBox.StyleManager = null;
            this.FieldsListBox.TabIndex = 0;
            this.FieldsListBox.ThemeAuthor = "Terry D. Eppler";
            this.FieldsListBox.ThemeName = "Budget Execution";
            this.FieldsListBox.ToolTip = null;
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
            this.FirstButton.Location = new System.Drawing.Point(65, 437);
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
            this.FirstButton.TabIndex = 4;
            this.FirstButton.Text = "Clear";
            this.FirstButton.ThemeAuthor = "Terry D. Eppler";
            this.FirstButton.ThemeName = "Budget Execution";
            this.FirstButton.ToolTip = null;
            // 
            // SecondPanel
            // 
            this.SecondPanel.BackColor = System.Drawing.Color.Transparent;
            this.SecondPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SecondPanel.BindingSource = null;
            this.SecondPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SecondPanel.BorderThickness = 1;
            this.SecondPanel.Children = null;
            this.SecondPanel.Controls.Add(this.NumericsListBox);
            this.SecondPanel.DataFilter = null;
            this.SecondPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPanel.ForeColor = System.Drawing.Color.Transparent;
            this.SecondPanel.HoverText = null;
            this.SecondPanel.IsDerivedStyle = true;
            this.SecondPanel.Location = new System.Drawing.Point(3, 33);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.Padding = new System.Windows.Forms.Padding(1);
            this.SecondPanel.Size = new System.Drawing.Size(239, 266);
            this.SecondPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondPanel.StyleManager = null;
            this.SecondPanel.TabIndex = 5;
            this.SecondPanel.ThemeAuthor = "Terry D. Eppler";
            this.SecondPanel.ThemeName = "BudgetExecution";
            this.SecondPanel.ToolTip = null;
            // 
            // NumericsListBox
            // 
            this.NumericsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.NumericsListBox.BindingSource = null;
            this.NumericsListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NumericsListBox.DataFilter = null;
            this.NumericsListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.NumericsListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.NumericsListBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumericsListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.NumericsListBox.HoveredItemColor = System.Drawing.Color.White;
            this.NumericsListBox.HoverText = null;
            this.NumericsListBox.IsDerivedStyle = true;
            this.NumericsListBox.ItemHeight = 28;
            this.NumericsListBox.Location = new System.Drawing.Point(13, 16);
            this.NumericsListBox.Margin = new System.Windows.Forms.Padding(1);
            this.NumericsListBox.MultiSelect = true;
            this.NumericsListBox.Name = "NumericsListBox";
            this.NumericsListBox.Padding = new System.Windows.Forms.Padding(1);
            this.NumericsListBox.SelectedIndex = -1;
            this.NumericsListBox.SelectedItem = null;
            this.NumericsListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.NumericsListBox.SelectedItemColor = System.Drawing.Color.White;
            this.NumericsListBox.SelectedText = null;
            this.NumericsListBox.SelectedValue = null;
            this.NumericsListBox.ShowBorder = false;
            this.NumericsListBox.ShowScrollBar = false;
            this.NumericsListBox.Size = new System.Drawing.Size(214, 234);
            this.NumericsListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.NumericsListBox.StyleManager = null;
            this.NumericsListBox.TabIndex = 0;
            this.NumericsListBox.ThemeAuthor = "Terry D. Eppler";
            this.NumericsListBox.ThemeName = "Budget Execution";
            this.NumericsListBox.ToolTip = null;
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
            this.FirstLabel.Size = new System.Drawing.Size(239, 26);
            this.FirstLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstLabel.StyleManager = null;
            this.FirstLabel.TabIndex = 3;
            this.FirstLabel.Text = "Fields :";
            this.FirstLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.FirstLabel.ThemeAuthor = "Terry D. Eppler";
            this.FirstLabel.ThemeName = "BudgetExecution";
            this.FirstLabel.ToolTip = null;
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
            this.SecondLabel.Size = new System.Drawing.Size(239, 24);
            this.SecondLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SecondLabel.StyleManager = null;
            this.SecondLabel.TabIndex = 3;
            this.SecondLabel.Text = "Numerics:";
            this.SecondLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SecondLabel.ThemeAuthor = "Terry D. Eppler";
            this.SecondLabel.ThemeName = "BudgetExecution";
            this.SecondLabel.ToolTip = null;
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
            // FirstTable
            // 
            this.FirstTable.ColumnCount = 1;
            this.FirstTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FirstTable.Controls.Add(this.FirstLabel, 0, 0);
            this.FirstTable.Controls.Add(this.FirstPanel, 0, 1);
            this.FirstTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.FirstTable.Location = new System.Drawing.Point(65, 36);
            this.FirstTable.Name = "FirstTable";
            this.FirstTable.RowCount = 2;
            this.FirstTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.59603F));
            this.FirstTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.40398F));
            this.FirstTable.Size = new System.Drawing.Size(245, 302);
            this.FirstTable.TabIndex = 8;
            // 
            // SecondTable
            // 
            this.SecondTable.ColumnCount = 1;
            this.SecondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SecondTable.Controls.Add(this.SecondLabel, 0, 0);
            this.SecondTable.Controls.Add(this.SecondPanel, 0, 1);
            this.SecondTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.SecondTable.Location = new System.Drawing.Point(379, 36);
            this.SecondTable.Name = "SecondTable";
            this.SecondTable.RowCount = 2;
            this.SecondTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.03344F));
            this.SecondTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.96655F));
            this.SecondTable.Size = new System.Drawing.Size(245, 302);
            this.SecondTable.TabIndex = 9;
            // 
            // SelectionsTextBox
            // 
            this.SelectionsTextBox.AutoCompleteCustomSource = null;
            this.SelectionsTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SelectionsTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SelectionsTextBox.BindingSource = null;
            this.SelectionsTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SelectionsTextBox.DataFilter = null;
            this.SelectionsTextBox.DisabledBackColor = System.Drawing.Color.Transparent;
            this.SelectionsTextBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.SelectionsTextBox.DisabledForeColor = System.Drawing.Color.Transparent;
            this.SelectionsTextBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectionsTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SelectionsTextBox.HoverText = null;
            this.SelectionsTextBox.Image = null;
            this.SelectionsTextBox.IsDerivedStyle = true;
            this.SelectionsTextBox.Lines = null;
            this.SelectionsTextBox.Location = new System.Drawing.Point(138, 354);
            this.SelectionsTextBox.MaxLength = 32767;
            this.SelectionsTextBox.Multiline = true;
            this.SelectionsTextBox.Name = "SelectionsTextBox";
            this.SelectionsTextBox.ReadOnly = false;
            this.SelectionsTextBox.Size = new System.Drawing.Size(483, 47);
            this.SelectionsTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.SelectionsTextBox.StyleManager = null;
            this.SelectionsTextBox.TabIndex = 10;
            this.SelectionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SelectionsTextBox.ThemeAuthor = "Terry D. Eppler";
            this.SelectionsTextBox.ThemeName = "Budget Execution";
            this.SelectionsTextBox.ToolTip = null;
            this.SelectionsTextBox.UseSystemPasswordChar = false;
            this.SelectionsTextBox.WatermarkText = "";
            // 
            // label1
            // 
            this.label1.BindingSource = null;
            this.label1.DataFilter = null;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.HoverText = null;
            this.label1.IsDerivedStyle = true;
            this.label1.Location = new System.Drawing.Point(65, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.Style = MetroSet_UI.Enums.Style.Custom;
            this.label1.StyleManager = null;
            this.label1.TabIndex = 11;
            this.label1.Text = "Selected :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.ThemeAuthor = "Terry D. Eppler";
            this.label1.ThemeName = "Budget Execution";
            this.label1.ToolTip = null;
            // 
            // SchemaDialog
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
            this.ClientSize = new System.Drawing.Size(692, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectionsTextBox);
            this.Controls.Add(this.SecondTable);
            this.Controls.Add(this.FirstTable);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.ThirdButton);
            this.Controls.Add(this.SecondButton);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "SchemaDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Data Columns";
            this.FirstPanel.ResumeLayout(false);
            this.SecondPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.FirstTable.ResumeLayout(false);
            this.SecondTable.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Button SecondButton;
    public Button ThirdButton;
    private Layout FirstPanel;
    public Button FirstButton;
    private Layout SecondPanel;
    private Label FirstLabel;
    private Label SecondLabel;
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
    private System.Windows.Forms.TableLayoutPanel FirstTable;
    private System.Windows.Forms.TableLayoutPanel SecondTable;
    public ListBox FieldsListBox;
    private ListBox NumericsListBox;
    public TextBox SelectionsTextBox;
    private Label label1;
}
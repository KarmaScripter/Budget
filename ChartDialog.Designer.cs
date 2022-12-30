// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class ChartDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartDialog));
            this.SecondButton = new BudgetExecution.Button();
            this.ThirdButton = new BudgetExecution.Button();
            this.TableListBox = new BudgetExecution.ListBox();
            this.TablesPanel = new BudgetExecution.Layout();
            this.FirstButton = new BudgetExecution.Button();
            this.ColumnsPanel = new BudgetExecution.Layout();
            this.FieldListBox = new BudgetExecution.ListBox();
            this.TablesLabel = new BudgetExecution.Label();
            this.ColumnLabel = new BudgetExecution.Label();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.layout1 = new BudgetExecution.Layout();
            this.NumericListBox = new BudgetExecution.ListBox();
            this.NumericLabel = new BudgetExecution.Label();
            this.TablesPanel.SuspendLayout();
            this.ColumnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.layout1.SuspendLayout();
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
            this.SecondButton.Location = new System.Drawing.Point(362, 411);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.SecondButton.NormalColor = System.Drawing.Color.Transparent;
            this.SecondButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.Padding = new System.Windows.Forms.Padding(1);
            this.SecondButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SecondButton.PressTextColor = System.Drawing.Color.White;
            this.SecondButton.Size = new System.Drawing.Size(160, 40);
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
            this.ThirdButton.Location = new System.Drawing.Point(656, 411);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.ThirdButton.NormalColor = System.Drawing.Color.Transparent;
            this.ThirdButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.Padding = new System.Windows.Forms.Padding(1);
            this.ThirdButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ThirdButton.PressTextColor = System.Drawing.Color.White;
            this.ThirdButton.Size = new System.Drawing.Size(160, 40);
            this.ThirdButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.ThirdButton.StyleManager = null;
            this.ThirdButton.TabIndex = 1;
            this.ThirdButton.Text = "Close";
            this.ThirdButton.ThemeAuthor = "Terry D. Eppler";
            this.ThirdButton.ThemeName = "BudgetExecution";
            this.ThirdButton.ToolTip = null;
            // 
            // TableListBox
            // 
            this.TableListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TableListBox.BindingSource = null;
            this.TableListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TableListBox.DataFilter = null;
            this.TableListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TableListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TableListBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.TableListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.TableListBox.HoverText = null;
            this.TableListBox.IsDerivedStyle = true;
            this.TableListBox.ItemHeight = 20;
            this.TableListBox.Location = new System.Drawing.Point(15, 13);
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
            this.TableListBox.Size = new System.Drawing.Size(232, 310);
            this.TableListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.TableListBox.StyleManager = null;
            this.TableListBox.TabIndex = 2;
            this.TableListBox.ThemeAuthor = "Terry D. Eppler";
            this.TableListBox.ThemeName = "BudgetExecution";
            this.TableListBox.ToolTip = null;
            // 
            // TablesPanel
            // 
            this.TablesPanel.BackColor = System.Drawing.Color.Transparent;
            this.TablesPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TablesPanel.BindingSource = null;
            this.TablesPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TablesPanel.BorderThickness = 1;
            this.TablesPanel.Children = null;
            this.TablesPanel.Controls.Add(this.TableListBox);
            this.TablesPanel.DataFilter = null;
            this.TablesPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TablesPanel.ForeColor = System.Drawing.Color.Transparent;
            this.TablesPanel.HoverText = null;
            this.TablesPanel.IsDerivedStyle = true;
            this.TablesPanel.Location = new System.Drawing.Point(12, 52);
            this.TablesPanel.Name = "TablesPanel";
            this.TablesPanel.Padding = new System.Windows.Forms.Padding(1);
            this.TablesPanel.Size = new System.Drawing.Size(265, 336);
            this.TablesPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.TablesPanel.StyleManager = null;
            this.TablesPanel.TabIndex = 3;
            this.TablesPanel.ThemeAuthor = "Terry D. Eppler";
            this.TablesPanel.ThemeName = "BudgetExecution";
            this.TablesPanel.ToolTip = null;
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
            this.FirstButton.Location = new System.Drawing.Point(46, 411);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.FirstButton.NormalColor = System.Drawing.Color.Transparent;
            this.FirstButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.Padding = new System.Windows.Forms.Padding(1);
            this.FirstButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FirstButton.PressTextColor = System.Drawing.Color.White;
            this.FirstButton.Size = new System.Drawing.Size(160, 40);
            this.FirstButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.FirstButton.StyleManager = null;
            this.FirstButton.TabIndex = 4;
            this.FirstButton.Text = "Undo / Clear";
            this.FirstButton.ThemeAuthor = "Terry D. Eppler";
            this.FirstButton.ThemeName = "Budget Execution";
            this.FirstButton.ToolTip = null;
            // 
            // ColumnsPanel
            // 
            this.ColumnsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ColumnsPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ColumnsPanel.BindingSource = null;
            this.ColumnsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ColumnsPanel.BorderThickness = 1;
            this.ColumnsPanel.Children = null;
            this.ColumnsPanel.Controls.Add(this.FieldListBox);
            this.ColumnsPanel.DataFilter = null;
            this.ColumnsPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColumnsPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ColumnsPanel.HoverText = null;
            this.ColumnsPanel.IsDerivedStyle = true;
            this.ColumnsPanel.Location = new System.Drawing.Point(300, 52);
            this.ColumnsPanel.Name = "ColumnsPanel";
            this.ColumnsPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ColumnsPanel.Size = new System.Drawing.Size(272, 336);
            this.ColumnsPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ColumnsPanel.StyleManager = null;
            this.ColumnsPanel.TabIndex = 5;
            this.ColumnsPanel.ThemeAuthor = "Terry D. Eppler";
            this.ColumnsPanel.ThemeName = "BudgetExecution";
            this.ColumnsPanel.ToolTip = null;
            // 
            // FieldListBox
            // 
            this.FieldListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FieldListBox.BindingSource = null;
            this.FieldListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FieldListBox.DataFilter = null;
            this.FieldListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FieldListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FieldListBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FieldListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.FieldListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.FieldListBox.HoverText = null;
            this.FieldListBox.IsDerivedStyle = true;
            this.FieldListBox.ItemHeight = 20;
            this.FieldListBox.Location = new System.Drawing.Point(18, 13);
            this.FieldListBox.Margin = new System.Windows.Forms.Padding(1);
            this.FieldListBox.MultiSelect = true;
            this.FieldListBox.Name = "FieldListBox";
            this.FieldListBox.Padding = new System.Windows.Forms.Padding(1);
            this.FieldListBox.SelectedIndex = -1;
            this.FieldListBox.SelectedItem = null;
            this.FieldListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.FieldListBox.SelectedItemColor = System.Drawing.Color.White;
            this.FieldListBox.SelectedText = null;
            this.FieldListBox.SelectedValue = null;
            this.FieldListBox.ShowBorder = false;
            this.FieldListBox.ShowScrollBar = false;
            this.FieldListBox.Size = new System.Drawing.Size(237, 310);
            this.FieldListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.FieldListBox.StyleManager = null;
            this.FieldListBox.TabIndex = 2;
            this.FieldListBox.ThemeAuthor = "Terry D. Eppler";
            this.FieldListBox.ThemeName = "BudgetExecution";
            this.FieldListBox.ToolTip = null;
            // 
            // TablesLabel
            // 
            this.TablesLabel.BindingSource = null;
            this.TablesLabel.DataFilter = null;
            this.TablesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TablesLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TablesLabel.HoverText = null;
            this.TablesLabel.IsDerivedStyle = true;
            this.TablesLabel.Location = new System.Drawing.Point(12, 23);
            this.TablesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TablesLabel.Name = "TablesLabel";
            this.TablesLabel.Padding = new System.Windows.Forms.Padding(1);
            this.TablesLabel.Size = new System.Drawing.Size(265, 23);
            this.TablesLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.TablesLabel.StyleManager = null;
            this.TablesLabel.TabIndex = 3;
            this.TablesLabel.Text = "Tables :";
            this.TablesLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TablesLabel.ThemeAuthor = "Terry D. Eppler";
            this.TablesLabel.ThemeName = "BudgetExecution";
            this.TablesLabel.ToolTip = null;
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.BindingSource = null;
            this.ColumnLabel.DataFilter = null;
            this.ColumnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColumnLabel.HoverText = null;
            this.ColumnLabel.IsDerivedStyle = true;
            this.ColumnLabel.Location = new System.Drawing.Point(300, 23);
            this.ColumnLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Padding = new System.Windows.Forms.Padding(1);
            this.ColumnLabel.Size = new System.Drawing.Size(272, 23);
            this.ColumnLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ColumnLabel.StyleManager = null;
            this.ColumnLabel.TabIndex = 3;
            this.ColumnLabel.Text = "Fields :";
            this.ColumnLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ColumnLabel.ThemeAuthor = "Terry D. Eppler";
            this.ColumnLabel.ThemeName = "BudgetExecution";
            this.ColumnLabel.ToolTip = null;
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
            // layout1
            // 
            this.layout1.BackColor = System.Drawing.Color.Transparent;
            this.layout1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.layout1.BindingSource = null;
            this.layout1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.layout1.BorderThickness = 1;
            this.layout1.Children = null;
            this.layout1.Controls.Add(this.NumericListBox);
            this.layout1.DataFilter = null;
            this.layout1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.layout1.ForeColor = System.Drawing.Color.Transparent;
            this.layout1.HoverText = null;
            this.layout1.IsDerivedStyle = true;
            this.layout1.Location = new System.Drawing.Point(591, 52);
            this.layout1.Name = "layout1";
            this.layout1.Padding = new System.Windows.Forms.Padding(1);
            this.layout1.Size = new System.Drawing.Size(272, 336);
            this.layout1.Style = MetroSet_UI.Enums.Style.Custom;
            this.layout1.StyleManager = null;
            this.layout1.TabIndex = 6;
            this.layout1.ThemeAuthor = "Terry D. Eppler";
            this.layout1.ThemeName = "BudgetExecution";
            this.layout1.ToolTip = null;
            // 
            // NumericListBox
            // 
            this.NumericListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.NumericListBox.BindingSource = null;
            this.NumericListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NumericListBox.DataFilter = null;
            this.NumericListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.NumericListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.NumericListBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumericListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.NumericListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.NumericListBox.HoverText = null;
            this.NumericListBox.IsDerivedStyle = true;
            this.NumericListBox.ItemHeight = 20;
            this.NumericListBox.Location = new System.Drawing.Point(18, 13);
            this.NumericListBox.Margin = new System.Windows.Forms.Padding(1);
            this.NumericListBox.MultiSelect = true;
            this.NumericListBox.Name = "NumericListBox";
            this.NumericListBox.Padding = new System.Windows.Forms.Padding(1);
            this.NumericListBox.SelectedIndex = -1;
            this.NumericListBox.SelectedItem = null;
            this.NumericListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.NumericListBox.SelectedItemColor = System.Drawing.Color.White;
            this.NumericListBox.SelectedText = null;
            this.NumericListBox.SelectedValue = null;
            this.NumericListBox.ShowBorder = false;
            this.NumericListBox.ShowScrollBar = false;
            this.NumericListBox.Size = new System.Drawing.Size(237, 310);
            this.NumericListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.NumericListBox.StyleManager = null;
            this.NumericListBox.TabIndex = 2;
            this.NumericListBox.ThemeAuthor = "Terry D. Eppler";
            this.NumericListBox.ThemeName = "BudgetExecution";
            this.NumericListBox.ToolTip = null;
            // 
            // NumericLabel
            // 
            this.NumericLabel.BindingSource = null;
            this.NumericLabel.DataFilter = null;
            this.NumericLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumericLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumericLabel.HoverText = null;
            this.NumericLabel.IsDerivedStyle = true;
            this.NumericLabel.Location = new System.Drawing.Point(591, 23);
            this.NumericLabel.Margin = new System.Windows.Forms.Padding(3);
            this.NumericLabel.Name = "NumericLabel";
            this.NumericLabel.Padding = new System.Windows.Forms.Padding(1);
            this.NumericLabel.Size = new System.Drawing.Size(272, 23);
            this.NumericLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.NumericLabel.StyleManager = null;
            this.NumericLabel.TabIndex = 7;
            this.NumericLabel.Text = "Numerics :";
            this.NumericLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.NumericLabel.ThemeAuthor = "Terry D. Eppler";
            this.NumericLabel.ThemeName = "BudgetExecution";
            this.NumericLabel.ToolTip = null;
            // 
            // ChartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(875, 463);
            this.Controls.Add(this.NumericLabel);
            this.Controls.Add(this.layout1);
            this.Controls.Add(this.ColumnLabel);
            this.Controls.Add(this.TablesLabel);
            this.Controls.Add(this.ColumnsPanel);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.TablesPanel);
            this.Controls.Add(this.ThirdButton);
            this.Controls.Add(this.SecondButton);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "ChartDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Data Columns";
            this.TablesPanel.ResumeLayout(false);
            this.ColumnsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.layout1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Button SecondButton;
    public Button ThirdButton;
    private ListBox TableListBox;
    private Layout TablesPanel;
    public Button FirstButton;
    private Layout ColumnsPanel;
    private ListBox FieldListBox;
    private Label TablesLabel;
    private Label ColumnLabel;
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
    private Layout layout1;
    private ListBox NumericListBox;
    private Label NumericLabel;
}
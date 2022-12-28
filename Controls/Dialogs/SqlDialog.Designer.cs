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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectButton = new BudgetExecution.Button();
            this.InsertButton = new BudgetExecution.Button();
            this.UpdateButton = new BudgetExecution.Button();
            this.DeleteButton = new BudgetExecution.Button();
            this.EditorPanel = new BudgetExecution.Layout();
            this.Editor = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.AcceptButton = new BudgetExecution.Button();
            this.RefreshButton = new BudgetExecution.Button();
            this.CloseButton = new BudgetExecution.Button();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToollTip = new BudgetExecution.SmallTip();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.TabControl.BeforeTouchSize = new System.Drawing.Size(1368, 459);
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
            this.TabControl.Size = new System.Drawing.Size(1368, 459);
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
            this.TabPage.Controls.Add(this.tableLayoutPanel1);
            this.TabPage.Controls.Add(this.EditorPanel);
            this.TabPage.Image = null;
            this.TabPage.ImageSize = new System.Drawing.Size(14, 14);
            this.TabPage.Location = new System.Drawing.Point(0, 22);
            this.TabPage.Margin = new System.Windows.Forms.Padding(1);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage.ShowCloseButton = true;
            this.TabPage.Size = new System.Drawing.Size(1368, 437);
            this.TabPage.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabPage.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TabPage.TabIndex = 8;
            this.TabPage.ThemesEnabled = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SelectButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InsertButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UpdateButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1148, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(146, 312);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SelectButton
            // 
            this.SelectButton.BindingSource = null;
            this.SelectButton.DataFilter = null;
            this.SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.SelectButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SelectButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SelectButton.HoverText = null;
            this.SelectButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.SelectButton.IsDerivedStyle = true;
            this.SelectButton.Location = new System.Drawing.Point(3, 3);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.SelectButton.NormalColor = System.Drawing.Color.Transparent;
            this.SelectButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.Padding = new System.Windows.Forms.Padding(1);
            this.SelectButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.PressTextColor = System.Drawing.Color.White;
            this.SelectButton.Size = new System.Drawing.Size(140, 40);
            this.SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SelectButton.StyleManager = null;
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "SELECT";
            this.SelectButton.ThemeAuthor = "Terry D. Eppler";
            this.SelectButton.ThemeName = "BudgetExecution";
            this.SelectButton.ToolTip = null;
            // 
            // InsertButton
            // 
            this.InsertButton.BindingSource = null;
            this.InsertButton.DataFilter = null;
            this.InsertButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.InsertButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.InsertButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.InsertButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.InsertButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.InsertButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.InsertButton.HoverText = null;
            this.InsertButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.InsertButton.IsDerivedStyle = true;
            this.InsertButton.Location = new System.Drawing.Point(3, 68);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.InsertButton.NormalColor = System.Drawing.Color.Transparent;
            this.InsertButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.InsertButton.Padding = new System.Windows.Forms.Padding(1);
            this.InsertButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.InsertButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.InsertButton.PressTextColor = System.Drawing.Color.White;
            this.InsertButton.Size = new System.Drawing.Size(140, 40);
            this.InsertButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.InsertButton.StyleManager = null;
            this.InsertButton.TabIndex = 2;
            this.InsertButton.Text = "INSERT";
            this.InsertButton.ThemeAuthor = "Terry D. Eppler";
            this.InsertButton.ThemeName = "BudgetExecution";
            this.InsertButton.ToolTip = null;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BindingSource = null;
            this.UpdateButton.DataFilter = null;
            this.UpdateButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.UpdateButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.UpdateButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.UpdateButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.UpdateButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.UpdateButton.HoverText = null;
            this.UpdateButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.UpdateButton.IsDerivedStyle = true;
            this.UpdateButton.Location = new System.Drawing.Point(3, 146);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.UpdateButton.NormalColor = System.Drawing.Color.Transparent;
            this.UpdateButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.UpdateButton.Padding = new System.Windows.Forms.Padding(1);
            this.UpdateButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.UpdateButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.UpdateButton.PressTextColor = System.Drawing.Color.White;
            this.UpdateButton.Size = new System.Drawing.Size(140, 40);
            this.UpdateButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.UpdateButton.StyleManager = null;
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.ThemeAuthor = "Terry D. Eppler";
            this.UpdateButton.ThemeName = "BudgetExecution";
            this.UpdateButton.ToolTip = null;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BindingSource = null;
            this.DeleteButton.DataFilter = null;
            this.DeleteButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.DeleteButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.DeleteButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.DeleteButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.DeleteButton.HoverText = null;
            this.DeleteButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.DeleteButton.IsDerivedStyle = true;
            this.DeleteButton.Location = new System.Drawing.Point(3, 232);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.DeleteButton.NormalColor = System.Drawing.Color.Transparent;
            this.DeleteButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(1);
            this.DeleteButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.DeleteButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.DeleteButton.PressTextColor = System.Drawing.Color.White;
            this.DeleteButton.Size = new System.Drawing.Size(140, 40);
            this.DeleteButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.DeleteButton.StyleManager = null;
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.ThemeAuthor = "Terry D. Eppler";
            this.DeleteButton.ThemeName = "BudgetExecution";
            this.DeleteButton.ToolTip = null;
            // 
            // EditorPanel
            // 
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
            this.EditorPanel.Location = new System.Drawing.Point(75, 55);
            this.EditorPanel.Name = "EditorPanel";
            this.EditorPanel.Padding = new System.Windows.Forms.Padding(1);
            this.EditorPanel.Size = new System.Drawing.Size(1052, 313);
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
            this.Editor.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.Editor.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.Editor.Configurator = config1;
            this.Editor.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Editor.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.Editor.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editor.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.Editor.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Editor.Location = new System.Drawing.Point(1, 1);
            this.Editor.Name = "Editor";
            this.Editor.RenderRightToLeft = false;
            this.Editor.ScrollPosition = new System.Drawing.Point(0, 0);
            this.Editor.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            this.Editor.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.Editor.ShowEndOfLine = false;
            this.Editor.Size = new System.Drawing.Size(1050, 311);
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
            this.Editor.Text = "editControl1";
            this.Editor.ThemeName = "Office2016Black";
            this.Editor.UseXPStyle = false;
            this.Editor.UseXPStyleBorder = true;
            this.Editor.VisualColumn = 13;
            this.Editor.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.Editor.ZoomFactor = 1F;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AcceptButton.BackColor = System.Drawing.Color.Transparent;
            this.AcceptButton.BindingSource = null;
            this.AcceptButton.DataFilter = null;
            this.AcceptButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.AcceptButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.AcceptButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.AcceptButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AcceptButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.AcceptButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.AcceptButton.HoverText = "Not Yet Implemented!";
            this.AcceptButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.AcceptButton.IsDerivedStyle = true;
            this.AcceptButton.Location = new System.Drawing.Point(38, 508);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.AcceptButton.NormalColor = System.Drawing.Color.Transparent;
            this.AcceptButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AcceptButton.Padding = new System.Windows.Forms.Padding(1);
            this.AcceptButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AcceptButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AcceptButton.PressTextColor = System.Drawing.Color.White;
            this.AcceptButton.Size = new System.Drawing.Size(140, 51);
            this.AcceptButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.AcceptButton.StyleManager = null;
            this.AcceptButton.TabIndex = 12;
            this.AcceptButton.Text = "Select";
            this.AcceptButton.ThemeAuthor = "Terry D. Eppler";
            this.AcceptButton.ThemeName = "BudgetExecution";
            this.AcceptButton.ToolTip = null;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.BindingSource = null;
            this.RefreshButton.DataFilter = null;
            this.RefreshButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.RefreshButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.RefreshButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.RefreshButton.HoverText = "Not Yet Implemented!";
            this.RefreshButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshButton.IsDerivedStyle = true;
            this.RefreshButton.Location = new System.Drawing.Point(573, 508);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.RefreshButton.NormalColor = System.Drawing.Color.Transparent;
            this.RefreshButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.PressTextColor = System.Drawing.Color.White;
            this.RefreshButton.Size = new System.Drawing.Size(140, 51);
            this.RefreshButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.RefreshButton.StyleManager = null;
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.Text = "Clear";
            this.RefreshButton.ThemeAuthor = "Terry D. Eppler";
            this.RefreshButton.ThemeName = "BudgetExecution";
            this.RefreshButton.ToolTip = null;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BindingSource = null;
            this.CloseButton.DataFilter = null;
            this.CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverText = "Close Window";
            this.CloseButton.HoverTextColor = System.Drawing.Color.White;
            this.CloseButton.IsDerivedStyle = true;
            this.CloseButton.Location = new System.Drawing.Point(1148, 508);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressTextColor = System.Drawing.Color.White;
            this.CloseButton.Size = new System.Drawing.Size(140, 51);
            this.CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.CloseButton.StyleManager = null;
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.ThemeAuthor = "Terry D. Eppler";
            this.CloseButton.ThemeName = "BudgetExecution";
            this.CloseButton.ToolTip = null;
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
            // SqlDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1368, 568);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SqlDialog";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.EditorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv TabPage;
    public Button AcceptButton;
    public Button RefreshButton;
    public Button CloseButton;
    public Layout EditorPanel;
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToollTip;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private Button SelectButton;
    public Syncfusion.Windows.Forms.Edit.EditControl Editor;
    private Button InsertButton;
    private Button UpdateButton;
    private Button DeleteButton;
}
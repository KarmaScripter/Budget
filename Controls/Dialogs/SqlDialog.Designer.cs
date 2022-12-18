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
            this.TabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.layout1 = new BudgetExecution.Layout();
            this.Editor = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.SelectButton = new BudgetExecution.Button();
            this.RefreshButton = new BudgetExecution.Button();
            this.CloseButton = new BudgetExecution.Button();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToollTip = new BudgetExecution.SmallTip();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.layout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ActiveTabFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.BeforeTouchSize = new System.Drawing.Size(1368, 452);
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
            this.TabControl.Size = new System.Drawing.Size(1368, 452);
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
            this.TabPage.Controls.Add(this.layout1);
            this.TabPage.Image = null;
            this.TabPage.ImageSize = new System.Drawing.Size(14, 14);
            this.TabPage.Location = new System.Drawing.Point(0, 22);
            this.TabPage.Margin = new System.Windows.Forms.Padding(1);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage.ShowCloseButton = true;
            this.TabPage.Size = new System.Drawing.Size(1368, 430);
            this.TabPage.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabPage.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TabPage.TabIndex = 8;
            this.TabPage.ThemesEnabled = false;
            // 
            // layout1
            // 
            this.layout1.BackColor = System.Drawing.Color.Transparent;
            this.layout1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.layout1.BindingSource = null;
            this.layout1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.layout1.BorderThickness = 1;
            this.layout1.Children = null;
            this.layout1.Controls.Add(this.Editor);
            this.layout1.DataFilter = null;
            this.layout1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.layout1.ForeColor = System.Drawing.Color.Transparent;
            this.layout1.HoverText = null;
            this.layout1.IsDerivedStyle = true;
            this.layout1.Location = new System.Drawing.Point(160, 20);
            this.layout1.Name = "layout1";
            this.layout1.Padding = new System.Windows.Forms.Padding(1);
            this.layout1.Size = new System.Drawing.Size(1052, 335);
            this.layout1.Style = MetroSet_UI.Enums.Style.Custom;
            this.layout1.StyleManager = null;
            this.layout1.TabIndex = 0;
            this.layout1.ThemeAuthor = "Terry D. Eppler";
            this.layout1.ThemeName = "BudgetExecution";
            this.layout1.ToolTip = null;
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
            this.Editor.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.Editor.ShowEndOfLine = false;
            this.Editor.Size = new System.Drawing.Size(1050, 333);
            this.Editor.StatusBarSettings.CoordsPanel.Width = 150;
            this.Editor.StatusBarSettings.EncodingPanel.Width = 100;
            this.Editor.StatusBarSettings.FileNamePanel.Width = 100;
            this.Editor.StatusBarSettings.InsertPanel.Width = 33;
            this.Editor.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.Editor.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.Editor.StatusBarSettings.StatusPanel.Width = 70;
            this.Editor.StatusBarSettings.TextPanel.Width = 214;
            this.Editor.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.Editor.TabIndex = 0;
            this.Editor.Text = "editControl1";
            this.Editor.UseXPStyleBorder = true;
            this.Editor.VisualColumn = 13;
            this.Editor.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.Editor.ZoomFactor = 1F;
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectButton.BindingSource = null;
            this.SelectButton.DataFilter = null;
            this.SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.SelectButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SelectButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SelectButton.HoverText = "Not Yet Implemented!";
            this.SelectButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.SelectButton.IsDerivedStyle = true;
            this.SelectButton.Location = new System.Drawing.Point(37, 486);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(0);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.SelectButton.NormalColor = System.Drawing.Color.Transparent;
            this.SelectButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.Padding = new System.Windows.Forms.Padding(1);
            this.SelectButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.PressTextColor = System.Drawing.Color.White;
            this.SelectButton.Size = new System.Drawing.Size(140, 55);
            this.SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SelectButton.StyleManager = null;
            this.SelectButton.TabIndex = 12;
            this.SelectButton.Text = "Select";
            this.SelectButton.ThemeAuthor = "Terry D. Eppler";
            this.SelectButton.ThemeName = "BudgetExecution";
            this.SelectButton.ToolTip = null;
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
            this.RefreshButton.Location = new System.Drawing.Point(572, 486);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.RefreshButton.NormalColor = System.Drawing.Color.Transparent;
            this.RefreshButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.PressTextColor = System.Drawing.Color.White;
            this.RefreshButton.Size = new System.Drawing.Size(140, 55);
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
            this.CloseButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.CloseButton.IsDerivedStyle = true;
            this.CloseButton.Location = new System.Drawing.Point(1147, 486);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressTextColor = System.Drawing.Color.White;
            this.CloseButton.Size = new System.Drawing.Size(140, 55);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1368, 564);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TabControl);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "SqlDialog";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPage.ResumeLayout(false);
            this.layout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv TabPage;
    public Button SelectButton;
    public Button RefreshButton;
    public Button CloseButton;
    public Layout layout1;
    private Syncfusion.Windows.Forms.Edit.EditControl Editor;
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToollTip;
}
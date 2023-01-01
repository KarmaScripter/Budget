// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class ProgramProjectDialog
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
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramProjectDialog));
            this.CloseButton = new BudgetExecution.Button();
            this.StatutoryAuthorityTextBox = new BudgetExecution.RichTextBox();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatutoryAuthorityLabel = new BudgetExecution.Label();
            this.StatutoryAuthorityTable = new System.Windows.Forms.TableLayoutPanel();
            this.ProgramDescriptionTextBox = new BudgetExecution.RichTextBox();
            this.ProgramAreaNameTable = new System.Windows.Forms.TableLayoutPanel();
            this.ProgramAreaLabel = new BudgetExecution.Label();
            this.ProgramAreaNameTextBox = new BudgetExecution.RichTextBox();
            this.ProgramListBox = new BudgetExecution.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ProgramProjectLabel = new BudgetExecution.Label();
            this.ProgramProjectNameTextBox = new BudgetExecution.RichTextBox();
            this.PreviousButton = new BudgetExecution.Button();
            this.NextButton = new BudgetExecution.Button();
            this.label1 = new BudgetExecution.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.StatutoryAuthorityTable.SuspendLayout();
            this.ProgramAreaNameTable.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BindingSource = null;
            this.CloseButton.DataFilter = null;
            this.CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverText = null;
            this.CloseButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.CloseButton.IsDerivedStyle = true;
            this.CloseButton.Location = new System.Drawing.Point(830, 520);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressTextColor = System.Drawing.Color.White;
            this.CloseButton.Size = new System.Drawing.Size(121, 46);
            this.CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.CloseButton.StyleManager = null;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.ThemeAuthor = "Terry D. Eppler";
            this.CloseButton.ThemeName = "Budget Execution";
            this.CloseButton.ToolTip = null;
            // 
            // StatutoryAuthorityTextBox
            // 
            this.StatutoryAuthorityTextBox.AutoWordSelection = false;
            this.StatutoryAuthorityTextBox.BindingSource = this.BindingSource;
            this.StatutoryAuthorityTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.StatutoryAuthorityTextBox.DataFilter = null;
            this.StatutoryAuthorityTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.StatutoryAuthorityTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.StatutoryAuthorityTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.StatutoryAuthorityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatutoryAuthorityTextBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatutoryAuthorityTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.StatutoryAuthorityTextBox.HoverText = null;
            this.StatutoryAuthorityTextBox.IsDerivedStyle = true;
            this.StatutoryAuthorityTextBox.Lines = null;
            this.StatutoryAuthorityTextBox.Location = new System.Drawing.Point(3, 38);
            this.StatutoryAuthorityTextBox.MaxLength = 32767;
            this.StatutoryAuthorityTextBox.Name = "StatutoryAuthorityTextBox";
            this.StatutoryAuthorityTextBox.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.StatutoryAuthorityTextBox.ReadOnly = false;
            this.StatutoryAuthorityTextBox.Size = new System.Drawing.Size(307, 157);
            this.StatutoryAuthorityTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.StatutoryAuthorityTextBox.StyleManager = null;
            this.StatutoryAuthorityTextBox.TabIndex = 1;
            this.StatutoryAuthorityTextBox.Tag = "Laws";
            this.StatutoryAuthorityTextBox.ThemeAuthor = "Terry D. Eppler";
            this.StatutoryAuthorityTextBox.ThemeName = "Budget Execution";
            this.StatutoryAuthorityTextBox.ToolTip = null;
            this.StatutoryAuthorityTextBox.WordWrap = true;
            // 
            // StatutoryAuthorityLabel
            // 
            this.StatutoryAuthorityLabel.AccessibleName = "";
            this.StatutoryAuthorityLabel.BindingSource = null;
            this.StatutoryAuthorityLabel.DataFilter = null;
            this.StatutoryAuthorityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatutoryAuthorityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatutoryAuthorityLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatutoryAuthorityLabel.HoverText = null;
            this.StatutoryAuthorityLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StatutoryAuthorityLabel.IsDerivedStyle = true;
            this.StatutoryAuthorityLabel.Location = new System.Drawing.Point(3, 3);
            this.StatutoryAuthorityLabel.Margin = new System.Windows.Forms.Padding(3);
            this.StatutoryAuthorityLabel.Name = "StatutoryAuthorityLabel";
            this.StatutoryAuthorityLabel.Padding = new System.Windows.Forms.Padding(1);
            this.StatutoryAuthorityLabel.Size = new System.Drawing.Size(307, 29);
            this.StatutoryAuthorityLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.StatutoryAuthorityLabel.StyleManager = null;
            this.StatutoryAuthorityLabel.TabIndex = 0;
            this.StatutoryAuthorityLabel.Text = "Statutory Authority";
            this.StatutoryAuthorityLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.StatutoryAuthorityLabel.ThemeAuthor = "Terry D. Eppler";
            this.StatutoryAuthorityLabel.ThemeName = "Budget Execution";
            this.StatutoryAuthorityLabel.ToolTip = null;
            // 
            // StatutoryAuthorityTable
            // 
            this.StatutoryAuthorityTable.ColumnCount = 1;
            this.StatutoryAuthorityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.8806F));
            this.StatutoryAuthorityTable.Controls.Add(this.StatutoryAuthorityTextBox, 0, 1);
            this.StatutoryAuthorityTable.Controls.Add(this.StatutoryAuthorityLabel, 0, 0);
            this.StatutoryAuthorityTable.Location = new System.Drawing.Point(25, 41);
            this.StatutoryAuthorityTable.Name = "StatutoryAuthorityTable";
            this.StatutoryAuthorityTable.RowCount = 2;
            this.StatutoryAuthorityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.07229F));
            this.StatutoryAuthorityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.92771F));
            this.StatutoryAuthorityTable.Size = new System.Drawing.Size(313, 198);
            this.StatutoryAuthorityTable.TabIndex = 3;
            // 
            // ProgramDescriptionTextBox
            // 
            this.ProgramDescriptionTextBox.AutoWordSelection = false;
            this.ProgramDescriptionTextBox.BindingSource = this.BindingSource;
            this.ProgramDescriptionTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ProgramDescriptionTextBox.DataFilter = null;
            this.ProgramDescriptionTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ProgramDescriptionTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ProgramDescriptionTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.ProgramDescriptionTextBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramDescriptionTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ProgramDescriptionTextBox.HoverText = null;
            this.ProgramDescriptionTextBox.IsDerivedStyle = true;
            this.ProgramDescriptionTextBox.Lines = null;
            this.ProgramDescriptionTextBox.Location = new System.Drawing.Point(25, 288);
            this.ProgramDescriptionTextBox.MaxLength = 32767;
            this.ProgramDescriptionTextBox.Name = "ProgramDescriptionTextBox";
            this.ProgramDescriptionTextBox.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ProgramDescriptionTextBox.ReadOnly = false;
            this.ProgramDescriptionTextBox.Size = new System.Drawing.Size(926, 180);
            this.ProgramDescriptionTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ProgramDescriptionTextBox.StyleManager = null;
            this.ProgramDescriptionTextBox.TabIndex = 1;
            this.ProgramDescriptionTextBox.Tag = "Description";
            this.ProgramDescriptionTextBox.ThemeAuthor = "Terry D. Eppler";
            this.ProgramDescriptionTextBox.ThemeName = "Budget Execution";
            this.ProgramDescriptionTextBox.ToolTip = null;
            this.ProgramDescriptionTextBox.WordWrap = true;
            // 
            // ProgramAreaNameTable
            // 
            this.ProgramAreaNameTable.ColumnCount = 1;
            this.ProgramAreaNameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.8806F));
            this.ProgramAreaNameTable.Controls.Add(this.ProgramAreaLabel, 0, 0);
            this.ProgramAreaNameTable.Controls.Add(this.ProgramAreaNameTextBox, 0, 1);
            this.ProgramAreaNameTable.Location = new System.Drawing.Point(355, 44);
            this.ProgramAreaNameTable.Name = "ProgramAreaNameTable";
            this.ProgramAreaNameTable.RowCount = 2;
            this.ProgramAreaNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.ProgramAreaNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.ProgramAreaNameTable.Size = new System.Drawing.Size(234, 75);
            this.ProgramAreaNameTable.TabIndex = 7;
            // 
            // ProgramAreaLabel
            // 
            this.ProgramAreaLabel.AccessibleName = "";
            this.ProgramAreaLabel.BindingSource = null;
            this.ProgramAreaLabel.DataFilter = null;
            this.ProgramAreaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgramAreaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgramAreaLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramAreaLabel.HoverText = null;
            this.ProgramAreaLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ProgramAreaLabel.IsDerivedStyle = true;
            this.ProgramAreaLabel.Location = new System.Drawing.Point(3, 3);
            this.ProgramAreaLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ProgramAreaLabel.Name = "ProgramAreaLabel";
            this.ProgramAreaLabel.Padding = new System.Windows.Forms.Padding(1);
            this.ProgramAreaLabel.Size = new System.Drawing.Size(228, 21);
            this.ProgramAreaLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ProgramAreaLabel.StyleManager = null;
            this.ProgramAreaLabel.TabIndex = 0;
            this.ProgramAreaLabel.Text = "Program Area";
            this.ProgramAreaLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ProgramAreaLabel.ThemeAuthor = "Terry D. Eppler";
            this.ProgramAreaLabel.ThemeName = "Budget Execution";
            this.ProgramAreaLabel.ToolTip = null;
            // 
            // ProgramAreaNameTextBox
            // 
            this.ProgramAreaNameTextBox.AutoWordSelection = false;
            this.ProgramAreaNameTextBox.BindingSource = this.BindingSource;
            this.ProgramAreaNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ProgramAreaNameTextBox.DataFilter = null;
            this.ProgramAreaNameTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ProgramAreaNameTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ProgramAreaNameTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.ProgramAreaNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgramAreaNameTextBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramAreaNameTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ProgramAreaNameTextBox.HoverText = null;
            this.ProgramAreaNameTextBox.IsDerivedStyle = true;
            this.ProgramAreaNameTextBox.Lines = null;
            this.ProgramAreaNameTextBox.Location = new System.Drawing.Point(3, 30);
            this.ProgramAreaNameTextBox.MaxLength = 32767;
            this.ProgramAreaNameTextBox.Name = "ProgramAreaNameTextBox";
            this.ProgramAreaNameTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.ProgramAreaNameTextBox.ReadOnly = false;
            this.ProgramAreaNameTextBox.Size = new System.Drawing.Size(228, 42);
            this.ProgramAreaNameTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ProgramAreaNameTextBox.StyleManager = null;
            this.ProgramAreaNameTextBox.TabIndex = 1;
            this.ProgramAreaNameTextBox.Text = "ProgramAreaName";
            this.ProgramAreaNameTextBox.ThemeAuthor = "Terry D. Eppler";
            this.ProgramAreaNameTextBox.ThemeName = "Budget Execution";
            this.ProgramAreaNameTextBox.ToolTip = null;
            this.ProgramAreaNameTextBox.WordWrap = true;
            // 
            // ProgramListBox
            // 
            this.ProgramListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ProgramListBox.BindingSource = null;
            this.ProgramListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ProgramListBox.DataFilter = null;
            this.ProgramListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ProgramListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ProgramListBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ProgramListBox.HoveredItemColor = System.Drawing.Color.White;
            this.ProgramListBox.HoverText = null;
            this.ProgramListBox.IsDerivedStyle = true;
            this.ProgramListBox.ItemHeight = 28;
            this.ProgramListBox.Location = new System.Drawing.Point(613, 41);
            this.ProgramListBox.Margin = new System.Windows.Forms.Padding(1);
            this.ProgramListBox.MultiSelect = true;
            this.ProgramListBox.Name = "ProgramListBox";
            this.ProgramListBox.Padding = new System.Windows.Forms.Padding(1);
            this.ProgramListBox.SelectedIndex = -1;
            this.ProgramListBox.SelectedItem = null;
            this.ProgramListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ProgramListBox.SelectedItemColor = System.Drawing.Color.White;
            this.ProgramListBox.SelectedText = null;
            this.ProgramListBox.SelectedValue = null;
            this.ProgramListBox.ShowBorder = false;
            this.ProgramListBox.ShowScrollBar = false;
            this.ProgramListBox.Size = new System.Drawing.Size(338, 195);
            this.ProgramListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ProgramListBox.StyleManager = null;
            this.ProgramListBox.TabIndex = 8;
            this.ProgramListBox.ThemeAuthor = "Terry D. Eppler";
            this.ProgramListBox.ThemeName = "Budget Execution";
            this.ProgramListBox.ToolTip = null;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.8806F));
            this.tableLayoutPanel2.Controls.Add(this.ProgramProjectLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProgramProjectNameTextBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(358, 157);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.92683F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.07317F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 82);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // ProgramProjectLabel
            // 
            this.ProgramProjectLabel.AccessibleName = "";
            this.ProgramProjectLabel.BindingSource = null;
            this.ProgramProjectLabel.DataFilter = null;
            this.ProgramProjectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgramProjectLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgramProjectLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramProjectLabel.HoverText = null;
            this.ProgramProjectLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ProgramProjectLabel.IsDerivedStyle = true;
            this.ProgramProjectLabel.Location = new System.Drawing.Point(3, 3);
            this.ProgramProjectLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ProgramProjectLabel.Name = "ProgramProjectLabel";
            this.ProgramProjectLabel.Padding = new System.Windows.Forms.Padding(1);
            this.ProgramProjectLabel.Size = new System.Drawing.Size(228, 21);
            this.ProgramProjectLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ProgramProjectLabel.StyleManager = null;
            this.ProgramProjectLabel.TabIndex = 0;
            this.ProgramProjectLabel.Text = "Program Project";
            this.ProgramProjectLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ProgramProjectLabel.ThemeAuthor = "Terry D. Eppler";
            this.ProgramProjectLabel.ThemeName = "Budget Execution";
            this.ProgramProjectLabel.ToolTip = null;
            // 
            // ProgramProjectNameTextBox
            // 
            this.ProgramProjectNameTextBox.AutoWordSelection = false;
            this.ProgramProjectNameTextBox.BindingSource = this.BindingSource;
            this.ProgramProjectNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ProgramProjectNameTextBox.DataFilter = null;
            this.ProgramProjectNameTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ProgramProjectNameTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ProgramProjectNameTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.ProgramProjectNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgramProjectNameTextBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramProjectNameTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ProgramProjectNameTextBox.HoverText = null;
            this.ProgramProjectNameTextBox.IsDerivedStyle = true;
            this.ProgramProjectNameTextBox.Lines = null;
            this.ProgramProjectNameTextBox.Location = new System.Drawing.Point(3, 30);
            this.ProgramProjectNameTextBox.MaxLength = 32767;
            this.ProgramProjectNameTextBox.Name = "ProgramProjectNameTextBox";
            this.ProgramProjectNameTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.ProgramProjectNameTextBox.ReadOnly = false;
            this.ProgramProjectNameTextBox.Size = new System.Drawing.Size(228, 49);
            this.ProgramProjectNameTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ProgramProjectNameTextBox.StyleManager = null;
            this.ProgramProjectNameTextBox.TabIndex = 1;
            this.ProgramProjectNameTextBox.Tag = "Code";
            this.ProgramProjectNameTextBox.ThemeAuthor = "Terry D. Eppler";
            this.ProgramProjectNameTextBox.ThemeName = "Budget Execution";
            this.ProgramProjectNameTextBox.ToolTip = null;
            this.ProgramProjectNameTextBox.WordWrap = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.BindingSource = null;
            this.PreviousButton.DataFilter = null;
            this.PreviousButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.PreviousButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.PreviousButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreviousButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.PreviousButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.PreviousButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.PreviousButton.HoverText = null;
            this.PreviousButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.PreviousButton.IsDerivedStyle = true;
            this.PreviousButton.Location = new System.Drawing.Point(25, 520);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.PreviousButton.NormalColor = System.Drawing.Color.Transparent;
            this.PreviousButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.PreviousButton.Padding = new System.Windows.Forms.Padding(1);
            this.PreviousButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.PreviousButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.PreviousButton.PressTextColor = System.Drawing.Color.White;
            this.PreviousButton.Size = new System.Drawing.Size(121, 46);
            this.PreviousButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.PreviousButton.StyleManager = null;
            this.PreviousButton.TabIndex = 9;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.ThemeAuthor = "Terry D. Eppler";
            this.PreviousButton.ThemeName = "Budget Execution";
            this.PreviousButton.ToolTip = null;
            // 
            // NextButton
            // 
            this.NextButton.BindingSource = null;
            this.NextButton.DataFilter = null;
            this.NextButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.NextButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.NextButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.NextButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.NextButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.NextButton.HoverText = null;
            this.NextButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.NextButton.IsDerivedStyle = true;
            this.NextButton.Location = new System.Drawing.Point(422, 520);
            this.NextButton.Name = "NextButton";
            this.NextButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.NextButton.NormalColor = System.Drawing.Color.Transparent;
            this.NextButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.NextButton.Padding = new System.Windows.Forms.Padding(1);
            this.NextButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.NextButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.NextButton.PressTextColor = System.Drawing.Color.White;
            this.NextButton.Size = new System.Drawing.Size(121, 46);
            this.NextButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.NextButton.StyleManager = null;
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next";
            this.NextButton.ThemeAuthor = "Terry D. Eppler";
            this.NextButton.ThemeName = "Budget Execution";
            this.NextButton.ToolTip = null;
            // 
            // label1
            // 
            this.label1.BindingSource = null;
            this.label1.DataFilter = null;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.HoverText = null;
            this.label1.IsDerivedStyle = true;
            this.label1.Location = new System.Drawing.Point(28, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.Style = MetroSet_UI.Enums.Style.Custom;
            this.label1.StyleManager = null;
            this.label1.TabIndex = 12;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.ThemeAuthor = "Terry D. Eppler";
            this.label1.ThemeName = "Budget Execution";
            this.label1.ToolTip = null;
            // 
            // ProgramProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionBarHeight = 30;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            captionImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            captionImage1.Image = global::BudgetExecution.Properties.Resources.EPA;
            captionImage1.Location = new System.Drawing.Point(5, 5);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(42, 16);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(970, 578);
            this.Controls.Add(this.ProgramDescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.StatutoryAuthorityTable);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ProgramAreaNameTable);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ProgramListBox);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "ProgramProjectDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.StatutoryAuthorityTable.ResumeLayout(false);
            this.ProgramAreaNameTable.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private RichTextBox StatutoryAuthorityTextBox;
    private Label StatutoryAuthorityLabel;
    private System.Windows.Forms.TableLayoutPanel StatutoryAuthorityTable;
    private RichTextBox ProgramDescriptionTextBox;
    public System.Windows.Forms.BindingSource BindingSource;
    private System.Windows.Forms.TableLayoutPanel ProgramAreaNameTable;
    private Label ProgramAreaLabel;
    private RichTextBox ProgramAreaNameTextBox;
    public Button PreviousButton;
    public Button NextButton;
    private Button CloseButton;
    private ListBox ProgramListBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private Label ProgramProjectLabel;
    private RichTextBox ProgramProjectNameTextBox;
    private Label label1;
}
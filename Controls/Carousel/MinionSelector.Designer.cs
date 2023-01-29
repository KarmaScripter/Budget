// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class MinionSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinionSelector));
            this.Header = new BudgetExecution.Label();
            this.CloseButton = new BudgetExecution.Button();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.ImageList = new BudgetExecution.ImageList();
            this.Selector = new BudgetExecution.Selector();
            this.SelectorTable = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SelectorTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BindingSource = null;
            this.Header.DataFilter = null;
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Header.HoverText = null;
            this.Header.IsDerivedStyle = true;
            this.Header.Location = new System.Drawing.Point(3, 3);
            this.Header.Margin = new System.Windows.Forms.Padding(3);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(1);
            this.Header.Size = new System.Drawing.Size(1042, 32);
            this.Header.Style = MetroSet_UI.Enums.Style.Custom;
            this.Header.StyleManager = null;
            this.Header.TabIndex = 3;
            this.Header.Text = "Header";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Header.ThemeAuthor = "Terry D. Eppler";
            this.Header.ThemeName = "BudgetExecution";
            this.Header.ToolTip = null;
            // 
            // CloseButton
            // 
            this.CloseButton.BindingSource = this.BindingSource;
            this.CloseButton.DataFilter = null;
            this.CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverText = "Return to Main Menu";
            this.CloseButton.HoverTextColor = System.Drawing.Color.White;
            this.CloseButton.IsDerivedStyle = true;
            this.CloseButton.Location = new System.Drawing.Point(994, 476);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressTextColor = System.Drawing.Color.White;
            this.CloseButton.Size = new System.Drawing.Size(140, 40);
            this.CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.CloseButton.StyleManager = null;
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.ThemeAuthor = "Terry D. Eppler";
            this.CloseButton.ThemeName = "BudgetExecution";
            this.CloseButton.ToolTip = this.ToolTip;
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
            // ImageList
            // 
            this.ImageList.BindingSource = null;
            this.ImageList.DataFilter = null;
            this.ImageList.FileNames = null;
            this.ImageList.FilePaths = null;
            this.ImageList.HoverText = null;
            this.ImageList.Image = null;
            this.ImageList.ImageSource = BudgetExecution.ImageDirectory.NS;
            this.ImageList.ToolTip = null;
            // 
            // Selector
            // 
            this.Selector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Selector.BindingSource = this.BindingSource;
            this.Selector.CanOverrideStyle = true;
            this.Selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Selector.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Selector.ForeColor = System.Drawing.Color.White;
            this.Selector.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Selector.Images = null;
            this.Selector.ImageshadeColor = System.Drawing.Color.Black;
            this.Selector.ImageSize = new System.Drawing.Size(250, 250);
            this.Selector.ImageSlides = true;
            this.Selector.Location = new System.Drawing.Point(3, 41);
            this.Selector.Name = "Selector";
            this.Selector.PadX = 0;
            this.Selector.PadY = 0;
            this.Selector.Perspective = 4F;
            this.Selector.RotateAlways = false;
            this.Selector.ShowImagePreview = true;
            this.Selector.ShowImageShadow = true;
            this.Selector.Size = new System.Drawing.Size(1042, 328);
            this.Selector.TabIndex = 8;
            this.Selector.ThemeName = "Metro";
            this.Selector.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.Selector.ThemeStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Selector.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Selector.ThemeStyle.HoverImageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Selector.ThemeStyle.HoverImageBorderThickness = 3;
            this.Selector.ThemeStyle.ImageShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Selector.TouchTransitionSpeed = 1F;
            this.Selector.UseOriginalImageinPreview = true;
            this.Selector.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Metro;
            // 
            // SelectorTable
            // 
            this.SelectorTable.ColumnCount = 1;
            this.SelectorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SelectorTable.Controls.Add(this.Selector, 0, 1);
            this.SelectorTable.Controls.Add(this.Header, 0, 0);
            this.SelectorTable.Location = new System.Drawing.Point(86, 43);
            this.SelectorTable.Name = "SelectorTable";
            this.SelectorTable.RowCount = 2;
            this.SelectorTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.24931F));
            this.SelectorTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.75069F));
            this.SelectorTable.Size = new System.Drawing.Size(1048, 372);
            this.SelectorTable.TabIndex = 9;
            // 
            // MinionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1188, 562);
            this.Controls.Add(this.SelectorTable);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MinionSelector";
            this.ShowIcon = false;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.SelectorTable.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    public Label Header;
    public Button CloseButton;
    public SmallTip ToolTip;
    public ImageList ImageList;
    public System.Windows.Forms.BindingSource BindingSource;
    private Selector Selector;
    private System.Windows.Forms.TableLayoutPanel SelectorTable;
}
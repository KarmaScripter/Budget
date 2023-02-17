// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    public partial class GuidanceDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuidanceDialog));
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListBox = new BudgetExecution.ListBox();
            this.ClearButton = new BudgetExecution.Button();
            this.SelectButton = new BudgetExecution.Button();
            this.CloseButto = new BudgetExecution.Button();
            this.Picture = new BudgetExecution.Picture();
            this.HeaderLabel = new BudgetExecution.Label();
            this.BrowseButton = new BudgetExecution.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip = new BudgetExecution.SmallTip();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ListBox.BindingSource = this.BindingSource;
            this.ListBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ListBox.DataFilter = null;
            this.ListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ListBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ListBox.HoveredItemColor = System.Drawing.Color.White;
            this.ListBox.HoverText = null;
            this.ListBox.IsDerivedStyle = true;
            this.ListBox.ItemHeight = 28;
            this.ListBox.Location = new System.Drawing.Point(26, 61);
            this.ListBox.Margin = new System.Windows.Forms.Padding(1);
            this.ListBox.MultiSelect = true;
            this.ListBox.Name = "ListBox";
            this.ListBox.Padding = new System.Windows.Forms.Padding(1);
            this.ListBox.SelectedIndex = -1;
            this.ListBox.SelectedItem = null;
            this.ListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ListBox.SelectedItemColor = System.Drawing.Color.White;
            this.ListBox.SelectedText = null;
            this.ListBox.SelectedValue = null;
            this.ListBox.ShowBorder = false;
            this.ListBox.ShowScrollBar = false;
            this.ListBox.Size = new System.Drawing.Size(473, 300);
            this.ListBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.ListBox.StyleManager = null;
            this.ListBox.TabIndex = 0;
            this.ListBox.ThemeAuthor = "Terry D. Eppler";
            this.ListBox.ThemeName = "Budget Execution";
            this.ListBox.ToolTip = null;
            // 
            // ClearButton
            // 
            this.ClearButton.BindingSource = null;
            this.ClearButton.DataFilter = null;
            this.ClearButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.ClearButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.ClearButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.ClearButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClearButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ClearButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ClearButton.HoverText = null;
            this.ClearButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.ClearButton.IsDerivedStyle = true;
            this.ClearButton.Location = new System.Drawing.Point(158, 438);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.ClearButton.NormalColor = System.Drawing.Color.Transparent;
            this.ClearButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClearButton.Padding = new System.Windows.Forms.Padding(1);
            this.ClearButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClearButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClearButton.PressTextColor = System.Drawing.Color.White;
            this.ClearButton.Size = new System.Drawing.Size(97, 31);
            this.ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.ClearButton.StyleManager = null;
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.ThemeAuthor = "Terry D. Eppler";
            this.ClearButton.ThemeName = "Budget Execution";
            this.ClearButton.ToolTip = null;
            // 
            // SelectButton
            // 
            this.SelectButton.BindingSource = null;
            this.SelectButton.DataFilter = null;
            this.SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.SelectButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SelectButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SelectButton.HoverText = null;
            this.SelectButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.SelectButton.IsDerivedStyle = true;
            this.SelectButton.Location = new System.Drawing.Point(285, 438);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.SelectButton.NormalColor = System.Drawing.Color.Transparent;
            this.SelectButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.Padding = new System.Windows.Forms.Padding(1);
            this.SelectButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.PressTextColor = System.Drawing.Color.White;
            this.SelectButton.Size = new System.Drawing.Size(97, 31);
            this.SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SelectButton.StyleManager = null;
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select";
            this.SelectButton.ThemeAuthor = "Terry D. Eppler";
            this.SelectButton.ThemeName = "Budget Execution";
            this.SelectButton.ToolTip = null;
            // 
            // CloseButto
            // 
            this.CloseButto.BindingSource = null;
            this.CloseButto.DataFilter = null;
            this.CloseButto.DisabledBackColor = System.Drawing.Color.Transparent;
            this.CloseButto.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CloseButto.DisabledForeColor = System.Drawing.Color.Transparent;
            this.CloseButto.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButto.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButto.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButto.HoverText = null;
            this.CloseButto.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.CloseButto.IsDerivedStyle = true;
            this.CloseButto.Location = new System.Drawing.Point(424, 438);
            this.CloseButto.Name = "CloseButto";
            this.CloseButto.NormalBorderColor = System.Drawing.Color.Transparent;
            this.CloseButto.NormalColor = System.Drawing.Color.Transparent;
            this.CloseButto.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButto.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButto.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButto.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButto.PressTextColor = System.Drawing.Color.White;
            this.CloseButto.Size = new System.Drawing.Size(97, 31);
            this.CloseButto.Style = MetroSet_UI.Enums.Style.Custom;
            this.CloseButto.StyleManager = null;
            this.CloseButto.TabIndex = 3;
            this.CloseButto.Text = "Close";
            this.CloseButto.ThemeAuthor = "Terry D. Eppler";
            this.CloseButto.ThemeName = "Budget Execution";
            this.CloseButto.ToolTip = null;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.BindingSource = null;
            this.Picture.DataFilter = null;
            this.Picture.Field = BudgetExecution.Field.AccountCode;
            this.Picture.HoverText = null;
            this.Picture.Image = global::BudgetExecution.Properties.Resources.SignpostTile;
            this.Picture.ImageList = null;
            this.Picture.Location = new System.Drawing.Point(1, 3);
            this.Picture.Name = "Picture";
            this.Picture.Padding = new System.Windows.Forms.Padding(1);
            this.Picture.Size = new System.Drawing.Size(22, 22);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 4;
            this.Picture.TabStop = false;
            this.Picture.ToolTip = null;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BindingSource = null;
            this.HeaderLabel.DataFilter = null;
            this.HeaderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.HoverText = null;
            this.HeaderLabel.IsDerivedStyle = true;
            this.HeaderLabel.Location = new System.Drawing.Point(40, 4);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(3);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Padding = new System.Windows.Forms.Padding(1);
            this.HeaderLabel.Size = new System.Drawing.Size(459, 23);
            this.HeaderLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.HeaderLabel.StyleManager = null;
            this.HeaderLabel.TabIndex = 5;
            this.HeaderLabel.Text = "Guidance";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeaderLabel.ThemeAuthor = "Terry D. Eppler";
            this.HeaderLabel.ThemeName = "Budget Execution";
            this.HeaderLabel.ToolTip = null;
            // 
            // BrowseButton
            // 
            this.BrowseButton.BindingSource = null;
            this.BrowseButton.DataFilter = null;
            this.BrowseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.BrowseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.BrowseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.BrowseButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrowseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.BrowseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.BrowseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.BrowseButton.HoverText = null;
            this.BrowseButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.BrowseButton.IsDerivedStyle = true;
            this.BrowseButton.Location = new System.Drawing.Point(12, 438);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.BrowseButton.NormalColor = System.Drawing.Color.Transparent;
            this.BrowseButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.BrowseButton.Padding = new System.Windows.Forms.Padding(1);
            this.BrowseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.BrowseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.BrowseButton.PressTextColor = System.Drawing.Color.White;
            this.BrowseButton.Size = new System.Drawing.Size(97, 31);
            this.BrowseButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.BrowseButton.StyleManager = null;
            this.BrowseButton.TabIndex = 6;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.ThemeAuthor = "Terry D. Eppler";
            this.BrowseButton.ThemeName = "Budget Execution";
            this.BrowseButton.ToolTip = null;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Title = "Search for Document";
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
            // GuidanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionBarHeight = 1;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(523, 471);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.CloseButto);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ListBox);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "GuidanceDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource BindingSource;

        public SmallTip ToolTip;

        private Label HeaderLabel;
        private ListBox ListBox;
        private Button ClearButton;
        public Button SelectButton;
        private Button CloseButto;
        private Button BrowseButton;
        public System.Windows.Forms.OpenFileDialog OpenFileDialog;
        public Picture Picture;
    }
}

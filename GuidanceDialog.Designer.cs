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
            this.listBox1 = new BudgetExecution.ListBox();
            this.ClearButton = new BudgetExecution.Button();
            this.SelectButton = new BudgetExecution.Button();
            this.CloseButto = new BudgetExecution.Button();
            this.Picture = new BudgetExecution.Picture();
            this.HeaderLabel = new BudgetExecution.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBox1.BindingSource = null;
            this.listBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.listBox1.DataFilter = null;
            this.listBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.listBox1.HoveredItemColor = System.Drawing.Color.White;
            this.listBox1.HoverText = null;
            this.listBox1.IsDerivedStyle = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(26, 61);
            this.listBox1.Margin = new System.Windows.Forms.Padding(1);
            this.listBox1.MultiSelect = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Padding = new System.Windows.Forms.Padding(1);
            this.listBox1.SelectedIndex = -1;
            this.listBox1.SelectedItem = null;
            this.listBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.listBox1.SelectedItemColor = System.Drawing.Color.White;
            this.listBox1.SelectedText = null;
            this.listBox1.SelectedValue = null;
            this.listBox1.ShowBorder = false;
            this.listBox1.ShowScrollBar = false;
            this.listBox1.Size = new System.Drawing.Size(473, 300);
            this.listBox1.Style = MetroSet_UI.Enums.Style.Custom;
            this.listBox1.StyleManager = null;
            this.listBox1.TabIndex = 0;
            this.listBox1.ThemeAuthor = "Terry D. Eppler";
            this.listBox1.ThemeName = "Budget Execution";
            this.listBox1.ToolTip = null;
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
            this.ClearButton.Location = new System.Drawing.Point(1, 438);
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
            this.SelectButton.Location = new System.Drawing.Point(212, 438);
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
            this.Picture.Size = new System.Drawing.Size(24, 22);
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
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.CloseButto);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.listBox1);
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
        private ListBox listBox1;
        private Button ClearButton;
        public Button SelectButton;
        private Button CloseButto;
        private Picture Picture;
    }
}

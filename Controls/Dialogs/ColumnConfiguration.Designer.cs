#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace BudgetExecution
{
    
    
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;

        public partial class ColumnConfiguration
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <dict name="disposing">true if managed resources should be disposed; otherwise, false.</dict>
            protected override void Dispose( bool disposing )
            {
                if( disposing && ( components != null ) )
                {
                    components.Dispose();
                }

                base.Dispose( disposing );
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnConfiguration));
            this.ColumnListBox = new System.Windows.Forms.CheckedListBox();
            this.ColumnConfigPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new BudgetExecution.Button();
            this.ColumnConfigurationImage = new BudgetExecution.Picture();
            this.HeaderLabel = new BudgetExecution.Label();
            this.ColumnConfigPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnConfigurationImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnListBox
            // 
            this.ColumnListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ColumnListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColumnListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnListBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColumnListBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ColumnListBox.FormattingEnabled = true;
            this.ColumnListBox.Location = new System.Drawing.Point(1, 1);
            this.ColumnListBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Size = new System.Drawing.Size(212, 246);
            this.ColumnListBox.TabIndex = 3;
            // 
            // ColumnConfigPanel
            // 
            this.ColumnConfigPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ColumnConfigPanel.Controls.Add(this.ColumnListBox);
            this.ColumnConfigPanel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ColumnConfigPanel.Location = new System.Drawing.Point(12, 42);
            this.ColumnConfigPanel.Name = "ColumnConfigPanel";
            this.ColumnConfigPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ColumnConfigPanel.Size = new System.Drawing.Size(214, 248);
            this.ColumnConfigPanel.TabIndex = 5;
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
            this.CloseButton.Location = new System.Drawing.Point(124, 305);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressTextColor = System.Drawing.Color.White;
            this.CloseButton.Size = new System.Drawing.Size(102, 35);
            this.CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.CloseButton.StyleManager = null;
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.ThemeAuthor = "Terry D. Eppler";
            this.CloseButton.ThemeName = "Budget Execution";
            this.CloseButton.ToolTip = null;
            // 
            // ColumnConfigurationImage
            // 
            this.ColumnConfigurationImage.BackColor = System.Drawing.Color.Transparent;
            this.ColumnConfigurationImage.BindingSource = null;
            this.ColumnConfigurationImage.DataFilter = null;
            this.ColumnConfigurationImage.Field = BudgetExecution.Field.AccountCode;
            this.ColumnConfigurationImage.HoverText = null;
            this.ColumnConfigurationImage.Image = global::BudgetExecution.Properties.Resources.SettingsTile;
            this.ColumnConfigurationImage.ImageList = null;
            this.ColumnConfigurationImage.Location = new System.Drawing.Point(0, 5);
            this.ColumnConfigurationImage.Name = "ColumnConfigurationImage";
            this.ColumnConfigurationImage.Padding = new System.Windows.Forms.Padding(1);
            this.ColumnConfigurationImage.Size = new System.Drawing.Size(22, 24);
            this.ColumnConfigurationImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ColumnConfigurationImage.TabIndex = 7;
            this.ColumnConfigurationImage.TabStop = false;
            this.ColumnConfigurationImage.ToolTip = null;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BindingSource = null;
            this.HeaderLabel.DataFilter = null;
            this.HeaderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.HoverText = null;
            this.HeaderLabel.IsDerivedStyle = true;
            this.HeaderLabel.Location = new System.Drawing.Point(28, 5);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(3);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Padding = new System.Windows.Forms.Padding(1);
            this.HeaderLabel.Size = new System.Drawing.Size(184, 23);
            this.HeaderLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.HeaderLabel.StyleManager = null;
            this.HeaderLabel.TabIndex = 8;
            this.HeaderLabel.Text = "Data Column Configuration";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeaderLabel.ThemeAuthor = "Terry D. Eppler";
            this.HeaderLabel.ThemeName = "Budget Execution";
            this.HeaderLabel.ToolTip = null;
            // 
            // ColumnConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionBarHeight = 1;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            captionImage1.BackColor = System.Drawing.Color.Transparent;
            captionImage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            captionImage1.Location = new System.Drawing.Point(10, 5);
            captionImage1.Name = "Image";
            captionImage1.Size = new System.Drawing.Size(16, 16);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(238, 343);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.ColumnConfigurationImage);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ColumnConfigPanel);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(250, 350);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "ColumnConfiguration";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "       SELECT COLUMNS";
            this.ColumnConfigPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnConfigurationImage)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            public CheckedListBox ColumnListBox;

            public Panel ColumnConfigPanel;
        public Button CloseButton;
        public Picture ColumnConfigurationImage;
        private Label HeaderLabel;
    }
    
}
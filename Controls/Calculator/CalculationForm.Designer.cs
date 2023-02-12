// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//
namespace BudgetExecution
{
    partial class CalculationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationForm));
            this.TopPanel = new BudgetExecution.Layout();
            this.Image = new BudgetExecution.Picture();
            this.ValueLabel = new BudgetExecution.Label();
            this.CalculatorPanel = new BudgetExecution.Layout();
            this.Calculator = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.ButtonPanel = new BudgetExecution.Layout();
            this.CloseButton = new BudgetExecution.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.CalculatorPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TopPanel.BindingSource = null;
            this.TopPanel.BorderColor = System.Drawing.Color.Transparent;
            this.TopPanel.BorderThickness = 1;
            this.TopPanel.Children = null;
            this.TopPanel.Controls.Add(this.Image);
            this.TopPanel.Controls.Add(this.ValueLabel);
            this.TopPanel.DataFilter = null;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopPanel.ForeColor = System.Drawing.Color.Transparent;
            this.TopPanel.HoverText = null;
            this.TopPanel.IsDerivedStyle = true;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(1);
            this.TopPanel.Size = new System.Drawing.Size(361, 36);
            this.TopPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.TopPanel.StyleManager = null;
            this.TopPanel.TabIndex = 0;
            this.TopPanel.ThemeAuthor = "Terry D. Eppler";
            this.TopPanel.ThemeName = "Budget Execution";
            this.TopPanel.ToolTip = null;
            // 
            // Image
            // 
            this.Image.BackColor = System.Drawing.Color.Transparent;
            this.Image.BindingSource = null;
            this.Image.DataFilter = null;
            this.Image.Field = BudgetExecution.Field.AccountCode;
            this.Image.HoverText = null;
            this.Image.Image = global::BudgetExecution.Properties.Resources.UtilityTile;
            this.Image.ImageList = null;
            this.Image.Location = new System.Drawing.Point(4, 4);
            this.Image.Name = "Image";
            this.Image.Padding = new System.Windows.Forms.Padding(1);
            this.Image.Size = new System.Drawing.Size(24, 26);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            this.Image.ToolTip = null;
            // 
            // ValueLabel
            // 
            this.ValueLabel.BindingSource = null;
            this.ValueLabel.DataFilter = null;
            this.ValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValueLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueLabel.HoverText = null;
            this.ValueLabel.IsDerivedStyle = true;
            this.ValueLabel.Location = new System.Drawing.Point(34, 4);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Padding = new System.Windows.Forms.Padding(1);
            this.ValueLabel.Size = new System.Drawing.Size(315, 28);
            this.ValueLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ValueLabel.StyleManager = null;
            this.ValueLabel.TabIndex = 0;
            this.ValueLabel.Text = "0.0";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ValueLabel.ThemeAuthor = "Terry D. Eppler";
            this.ValueLabel.ThemeName = "Budget Execution";
            this.ValueLabel.ToolTip = null;
            // 
            // CalculatorPanel
            // 
            this.CalculatorPanel.BackColor = System.Drawing.Color.Transparent;
            this.CalculatorPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CalculatorPanel.BindingSource = null;
            this.CalculatorPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.CalculatorPanel.BorderThickness = 1;
            this.CalculatorPanel.Children = null;
            this.CalculatorPanel.Controls.Add(this.Calculator);
            this.CalculatorPanel.DataFilter = null;
            this.CalculatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculatorPanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculatorPanel.ForeColor = System.Drawing.Color.Transparent;
            this.CalculatorPanel.HoverText = null;
            this.CalculatorPanel.IsDerivedStyle = true;
            this.CalculatorPanel.Location = new System.Drawing.Point(0, 36);
            this.CalculatorPanel.Name = "CalculatorPanel";
            this.CalculatorPanel.Padding = new System.Windows.Forms.Padding(1);
            this.CalculatorPanel.Size = new System.Drawing.Size(361, 362);
            this.CalculatorPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.CalculatorPanel.StyleManager = null;
            this.CalculatorPanel.TabIndex = 1;
            this.CalculatorPanel.ThemeAuthor = "Terry D. Eppler";
            this.CalculatorPanel.ThemeName = "Budget Execution";
            this.CalculatorPanel.ToolTip = null;
            // 
            // Calculator
            // 
            this.Calculator.AccessibleDescription = "Calculator control";
            this.Calculator.AccessibleName = "Calculator Control";
            this.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Calculator.BeforeTouchSize = new System.Drawing.Size(359, 360);
            this.Calculator.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.Calculator.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Calculator.Culture = new System.Globalization.CultureInfo("en-US");
            this.Calculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calculator.DoubleValue = 0D;
            this.Calculator.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.ForeColor = System.Drawing.Color.White;
            this.Calculator.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.Financial;
            this.Calculator.Location = new System.Drawing.Point(1, 1);
            this.Calculator.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Calculator.Name = "Calculator";
            this.Calculator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calculator.ShowDisplayArea = false;
            this.Calculator.Size = new System.Drawing.Size(359, 360);
            this.Calculator.TabIndex = 0;
            this.Calculator.ThemeName = "Metro";
            this.Calculator.UseVerticalAndHorizontalSpacing = true;
            this.Calculator.UseVisualStyle = true;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonPanel.BindingSource = null;
            this.ButtonPanel.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonPanel.BorderThickness = 1;
            this.ButtonPanel.Children = null;
            this.ButtonPanel.Controls.Add(this.CloseButton);
            this.ButtonPanel.DataFilter = null;
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonPanel.HoverText = null;
            this.ButtonPanel.IsDerivedStyle = true;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 398);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ButtonPanel.Size = new System.Drawing.Size(361, 44);
            this.ButtonPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ButtonPanel.StyleManager = null;
            this.ButtonPanel.TabIndex = 2;
            this.ButtonPanel.ThemeAuthor = "Terry D. Eppler";
            this.ButtonPanel.ThemeName = "Budget Execution";
            this.ButtonPanel.ToolTip = null;
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
            this.CloseButton.Location = new System.Drawing.Point(231, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressTextColor = System.Drawing.Color.White;
            this.CloseButton.Size = new System.Drawing.Size(126, 34);
            this.CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.CloseButton.StyleManager = null;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.ThemeAuthor = "Terry D. Eppler";
            this.CloseButton.ThemeName = "Budget Execution";
            this.CloseButton.ToolTip = null;
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionBarHeight = 3;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(361, 442);
            this.Controls.Add(this.CalculatorPanel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "CalculationForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.CalculatorPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Layout TopPanel;
        private Picture Image;
        private Label ValueLabel;
        private Layout CalculatorPanel;
        public Syncfusion.Windows.Forms.Tools.CalculatorControl Calculator;
        private Layout ButtonPanel;
        public Button CloseButton;
    }
}


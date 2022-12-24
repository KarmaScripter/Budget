
namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;

    partial class Message
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.TextBox = new BudgetExecution.TextBox();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OpenButton = new BudgetExecution.Button();
            this.ToolTip = new BudgetExecution.SmallTip();
            this.CloseButton = new BudgetExecution.Button();
            this.Label = new BudgetExecution.Label();
            this.Picture = new BudgetExecution.Picture();
            this.Header = new BudgetExecution.Label();
            this.BackPanel = new BudgetExecution.Layout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.AutoCompleteCustomSource = null;
            this.TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBox.BindingSource = this.BindingSource;
            this.TextBox.BorderColor = System.Drawing.Color.Transparent;
            this.TextBox.DataFilter = null;
            this.TextBox.DisabledBackColor = System.Drawing.Color.Transparent;
            this.TextBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.TextBox.DisabledForeColor = System.Drawing.Color.Transparent;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.TextBox.HoverText = null;
            this.TextBox.Image = null;
            this.TextBox.IsDerivedStyle = true;
            this.TextBox.Lines = null;
            this.TextBox.Location = new System.Drawing.Point(27, 19);
            this.TextBox.MaxLength = 2147483647;
            this.TextBox.Multiline = false;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(490, 186);
            this.TextBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.TextBox.StyleManager = null;
            this.TextBox.TabIndex = 8;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox.ThemeAuthor = "Terry D. Eppler";
            this.TextBox.ThemeName = "BudgetExecution";
            this.TextBox.ToolTip = null;
            this.TextBox.UseSystemPasswordChar = false;
            this.TextBox.WatermarkText = "";
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenButton.BindingSource = null;
            this.OpenButton.DataFilter = null;
            this.OpenButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.OpenButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.OpenButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.OpenButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.OpenButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.OpenButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.OpenButton.HoverText = null;
            this.OpenButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.OpenButton.IsDerivedStyle = true;
            this.OpenButton.Location = new System.Drawing.Point(70, 327);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.OpenButton.NormalColor = System.Drawing.Color.Transparent;
            this.OpenButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.OpenButton.Padding = new System.Windows.Forms.Padding(1);
            this.OpenButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.OpenButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.OpenButton.PressTextColor = System.Drawing.Color.White;
            this.OpenButton.Size = new System.Drawing.Size(124, 57);
            this.OpenButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.OpenButton.StyleManager = null;
            this.OpenButton.TabIndex = 9;
            this.OpenButton.Text = "Open";
            this.OpenButton.ThemeAuthor = "Terry D. Eppler";
            this.OpenButton.ThemeName = "BudgetExecution";
            this.OpenButton.ToolTip = this.ToolTip;
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
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BindingSource = null;
            this.CloseButton.DataFilter = null;
            this.CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverText = null;
            this.CloseButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.CloseButton.IsDerivedStyle = true;
            this.CloseButton.Location = new System.Drawing.Point(485, 327);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressTextColor = System.Drawing.Color.White;
            this.CloseButton.Size = new System.Drawing.Size(127, 57);
            this.CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.CloseButton.StyleManager = null;
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.ThemeAuthor = "Terry D. Eppler";
            this.CloseButton.ThemeName = "BudgetExecution";
            this.CloseButton.ToolTip = this.ToolTip;
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.BindingSource = null;
            this.Label.DataFilter = null;
            this.Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.HoverText = null;
            this.Label.IsDerivedStyle = true;
            this.Label.Location = new System.Drawing.Point(86, 67);
            this.Label.Margin = new System.Windows.Forms.Padding(3);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(1);
            this.Label.Size = new System.Drawing.Size(526, 23);
            this.Label.Style = MetroSet_UI.Enums.Style.Custom;
            this.Label.StyleManager = null;
            this.Label.TabIndex = 12;
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label.ThemeAuthor = "Terry D. Eppler";
            this.Label.ThemeName = "BudgetExecution";
            this.Label.ToolTip = null;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.BindingSource = null;
            this.Picture.DataFilter = null;
            this.Picture.Field = BudgetExecution.Field.RpioActivityCode;
            this.Picture.HoverText = null;
            this.Picture.Image = global::BudgetExecution.Properties.Resources.Message;
            this.Picture.ImageList = null;
            this.Picture.Location = new System.Drawing.Point(0, 3);
            this.Picture.Name = "Picture";
            this.Picture.Padding = new System.Windows.Forms.Padding(1);
            this.Picture.Size = new System.Drawing.Size(16, 18);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 13;
            this.Picture.TabStop = false;
            this.Picture.ToolTip = null;
            // 
            // Header
            // 
            this.Header.BindingSource = null;
            this.Header.DataFilter = null;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Header.HoverText = null;
            this.Header.IsDerivedStyle = true;
            this.Header.Location = new System.Drawing.Point(86, 11);
            this.Header.Margin = new System.Windows.Forms.Padding(3);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(1);
            this.Header.Size = new System.Drawing.Size(526, 23);
            this.Header.Style = MetroSet_UI.Enums.Style.Custom;
            this.Header.StyleManager = null;
            this.Header.TabIndex = 14;
            this.Header.Text = "Budget Execution Message";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Header.ThemeAuthor = "Terry D. Eppler";
            this.Header.ThemeName = "BudgetExecution";
            this.Header.ToolTip = null;
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackPanel.BindingSource = null;
            this.BackPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BackPanel.BorderThickness = 1;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.TextBox);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackPanel.ForeColor = System.Drawing.Color.Transparent;
            this.BackPanel.HoverText = null;
            this.BackPanel.IsDerivedStyle = true;
            this.BackPanel.Location = new System.Drawing.Point(70, 77);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(542, 229);
            this.BackPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.BackPanel.StyleManager = null;
            this.BackPanel.TabIndex = 15;
            this.BackPanel.ThemeAuthor = "Terry D. Eppler";
            this.BackPanel.ThemeName = "BudgetExecution";
            this.BackPanel.ToolTip = null;
            // 
            // Message
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionBarHeight = 1;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(688, 393);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OpenButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeBox = false;
            this.Name = "Message";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion
        public TextBox TextBox;
        public Button OpenButton;
        public SmallTip ToolTip;
        public Button CloseButton;
        public Label Label;
        public Picture Picture;
        private Label Header;
        public BindingSource BindingSource;
        private Layout BackPanel;
    }
    
}

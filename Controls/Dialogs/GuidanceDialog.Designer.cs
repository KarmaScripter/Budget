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
            if(disposing && (components != null))
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
            components = new System.ComponentModel.Container( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( GuidanceDialog ) );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ListBox = new ListBox( );
            ClearButton = new Button( );
            SelectButton = new Button( );
            CloseButto = new Button( );
            Picture = new Picture( );
            HeaderLabel = new Label( );
            BrowseButton = new Button( );
            OpenFileDialog = new System.Windows.Forms.OpenFileDialog( );
            ToolTip = new SmallTip( );
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel( );
            ((System.ComponentModel.ISupportInitialize)BindingSource).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit( );
            flowLayoutPanel1.SuspendLayout( );
            SuspendLayout( );
            // 
            // ListBox
            // 
            ListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ListBox.BindingSource = BindingSource;
            ListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            ListBox.DataFilter = null;
            ListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ListBox.HoveredItemColor = System.Drawing.Color.White;
            ListBox.HoverText = null;
            ListBox.IsDerivedStyle = true;
            ListBox.ItemHeight = 28;
            ListBox.Location = new System.Drawing.Point( 40, 76 );
            ListBox.Margin = new System.Windows.Forms.Padding( 1 );
            ListBox.MultiSelect = true;
            ListBox.Name = "ListBox";
            ListBox.Padding = new System.Windows.Forms.Padding( 1 );
            ListBox.SelectedIndex = -1;
            ListBox.SelectedItem = null;
            ListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ListBox.SelectedItemColor = System.Drawing.Color.White;
            ListBox.SelectedText = null;
            ListBox.SelectedValue = null;
            ListBox.ShowBorder = false;
            ListBox.ShowScrollBar = false;
            ListBox.Size = new System.Drawing.Size( 441, 285 );
            ListBox.Style = MetroSet_UI.Enums.Style.Custom;
            ListBox.StyleManager = null;
            ListBox.TabIndex = 0;
            ListBox.ThemeAuthor = "Terry D. Eppler";
            ListBox.ThemeName = "Budget Execution";
            ListBox.ToolTip = null;
            // 
            // ClearButton
            // 
            ClearButton.BindingSource = null;
            ClearButton.DataFilter = null;
            ClearButton.DisabledBackColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledForeColor = System.Drawing.Color.Transparent;
            ClearButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ClearButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ClearButton.HoverColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ClearButton.HoverText = null;
            ClearButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            ClearButton.IsDerivedStyle = true;
            ClearButton.Location = new System.Drawing.Point( 123, 3 );
            ClearButton.Name = "ClearButton";
            ClearButton.NormalBorderColor = System.Drawing.Color.Transparent;
            ClearButton.NormalColor = System.Drawing.Color.Transparent;
            ClearButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.Padding = new System.Windows.Forms.Padding( 1 );
            ClearButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressTextColor = System.Drawing.Color.White;
            ClearButton.Size = new System.Drawing.Size( 114, 31 );
            ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
            ClearButton.StyleManager = null;
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.ThemeAuthor = "Terry D. Eppler";
            ClearButton.ThemeName = "Budget Execution";
            ClearButton.ToolTip = null;
            // 
            // SelectButton
            // 
            SelectButton.BindingSource = null;
            SelectButton.DataFilter = null;
            SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SelectButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SelectButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            SelectButton.HoverColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            SelectButton.HoverText = null;
            SelectButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            SelectButton.IsDerivedStyle = true;
            SelectButton.Location = new System.Drawing.Point( 243, 3 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.Transparent;
            SelectButton.NormalColor = System.Drawing.Color.Transparent;
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.Padding = new System.Windows.Forms.Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 114, 31 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 2;
            SelectButton.Text = "Select";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "Budget Execution";
            SelectButton.ToolTip = null;
            // 
            // CloseButto
            // 
            CloseButto.BindingSource = null;
            CloseButto.DataFilter = null;
            CloseButto.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButto.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButto.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButto.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButto.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButto.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButto.HoverColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButto.HoverText = null;
            CloseButto.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            CloseButto.IsDerivedStyle = true;
            CloseButto.Location = new System.Drawing.Point( 363, 3 );
            CloseButto.Name = "CloseButto";
            CloseButto.NormalBorderColor = System.Drawing.Color.Transparent;
            CloseButto.NormalColor = System.Drawing.Color.Transparent;
            CloseButto.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButto.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButto.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButto.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButto.PressTextColor = System.Drawing.Color.White;
            CloseButto.Size = new System.Drawing.Size( 114, 31 );
            CloseButto.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButto.StyleManager = null;
            CloseButto.TabIndex = 3;
            CloseButto.Text = "Close";
            CloseButto.ThemeAuthor = "Terry D. Eppler";
            CloseButto.ThemeName = "Budget Execution";
            CloseButto.ToolTip = null;
            // 
            // Picture
            // 
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.BindingSource = null;
            Picture.DataFilter = null;
            Picture.Field = Field.AccountCode;
            Picture.HoverText = null;
            Picture.Image = Properties.Resources.SignpostTile;
            Picture.ImageList = null;
            Picture.Location = new System.Drawing.Point( 1, 3 );
            Picture.Name = "Picture";
            Picture.Padding = new System.Windows.Forms.Padding( 1 );
            Picture.Size = new System.Drawing.Size( 22, 22 );
            Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 4;
            Picture.TabStop = false;
            Picture.ToolTip = null;
            // 
            // HeaderLabel
            // 
            HeaderLabel.BindingSource = null;
            HeaderLabel.DataFilter = null;
            HeaderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            HeaderLabel.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            HeaderLabel.HoverText = null;
            HeaderLabel.IsDerivedStyle = true;
            HeaderLabel.Location = new System.Drawing.Point( 40, 4 );
            HeaderLabel.Margin = new System.Windows.Forms.Padding( 3 );
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Padding = new System.Windows.Forms.Padding( 1 );
            HeaderLabel.Size = new System.Drawing.Size( 459, 23 );
            HeaderLabel.Style = MetroSet_UI.Enums.Style.Custom;
            HeaderLabel.StyleManager = null;
            HeaderLabel.TabIndex = 5;
            HeaderLabel.Text = "Guidance";
            HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            HeaderLabel.ThemeAuthor = "Terry D. Eppler";
            HeaderLabel.ThemeName = "Budget Execution";
            HeaderLabel.ToolTip = null;
            // 
            // BrowseButton
            // 
            BrowseButton.BindingSource = null;
            BrowseButton.DataFilter = null;
            BrowseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BrowseButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            BrowseButton.HoverColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            BrowseButton.HoverText = null;
            BrowseButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            BrowseButton.IsDerivedStyle = true;
            BrowseButton.Location = new System.Drawing.Point( 3, 3 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            BrowseButton.NormalColor = System.Drawing.Color.Transparent;
            BrowseButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.Padding = new System.Windows.Forms.Padding( 1 );
            BrowseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.PressTextColor = System.Drawing.Color.White;
            BrowseButton.Size = new System.Drawing.Size( 114, 31 );
            BrowseButton.Style = MetroSet_UI.Enums.Style.Custom;
            BrowseButton.StyleManager = null;
            BrowseButton.TabIndex = 6;
            BrowseButton.Text = "Browse";
            BrowseButton.ThemeAuthor = "Terry D. Eppler";
            BrowseButton.ThemeName = "Budget Execution";
            BrowseButton.ToolTip = null;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.Title = "Search for Document";
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb( 5, 5, 5 );
            ToolTip.BindingSource = null;
            ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            ToolTip.ForeColor = System.Drawing.Color.White;
            ToolTip.InitialDelay = 500;
            ToolTip.IsDerivedStyle = true;
            ToolTip.Name = null;
            ToolTip.OwnerDraw = true;
            ToolTip.ReshowDelay = 100;
            ToolTip.Style = MetroSet_UI.Enums.Style.Custom;
            ToolTip.StyleManager = null;
            ToolTip.ThemeAuthor = "Terry D. Eppler";
            ToolTip.ThemeName = "Budget Execution";
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add( BrowseButton );
            flowLayoutPanel1.Controls.Add( ClearButton );
            flowLayoutPanel1.Controls.Add( SelectButton );
            flowLayoutPanel1.Controls.Add( CloseButto );
            flowLayoutPanel1.Location = new System.Drawing.Point( 24, 433 );
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size( 487, 36 );
            flowLayoutPanel1.TabIndex = 7;
            // 
            // GuidanceDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 1;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClientSize = new System.Drawing.Size( 523, 471 );
            Controls.Add( flowLayoutPanel1 );
            Controls.Add( HeaderLabel );
            Controls.Add( Picture );
            Controls.Add( ListBox );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            Name = "GuidanceDialog";
            ShowIcon = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)BindingSource).EndInit( );
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit( );
            flowLayoutPanel1.ResumeLayout( false );
            ResumeLayout( false );
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

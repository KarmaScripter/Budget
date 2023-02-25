namespace BudgetExecution
{
    partial class LoadingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources
        /// should be disposed; otherwise, false.</param>
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( LoadingForm ) );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Worker = new System.ComponentModel.BackgroundWorker( );
            Timer = new System.Windows.Forms.Timer( components );
            CloaseButton = new Button( );
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit( );
            SuspendLayout( );
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.Location = new System.Drawing.Point( 260, 82 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 800, 600 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Worker
            // 
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 5000;
            // 
            // CloaseButton
            // 
            CloaseButton.BindingSource = null;
            CloaseButton.DataFilter = null;
            CloaseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloaseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloaseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloaseButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloaseButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloaseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloaseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloaseButton.HoverText = null;
            CloaseButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            CloaseButton.IsDerivedStyle = true;
            CloaseButton.Location = new System.Drawing.Point( 1186, 691 );
            CloaseButton.Name = "CloaseButton";
            CloaseButton.NormalBorderColor = System.Drawing.Color.Black;
            CloaseButton.NormalColor = System.Drawing.Color.Black;
            CloaseButton.NormalTextColor = System.Drawing.Color.Black;
            CloaseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloaseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloaseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloaseButton.PressTextColor = System.Drawing.Color.White;
            CloaseButton.Size = new System.Drawing.Size( 140, 40 );
            CloaseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloaseButton.StyleManager = null;
            CloaseButton.TabIndex = 1;
            CloaseButton.Text = "button1";
            CloaseButton.ThemeAuthor = "Terry D. Eppler";
            CloaseButton.ThemeName = "Budget Execution";
            CloaseButton.ToolTip = null;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 6F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.Black;
            CaptionBarHeight = 1;
            CaptionButtonColor = System.Drawing.Color.Black;
            CaptionButtonHoverColor = System.Drawing.Color.Black;
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size( 1345, 745 );
            Controls.Add( CloaseButton );
            Controls.Add( PictureBox );
            Font = new System.Drawing.Font( "Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.Black;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MetroColor = System.Drawing.Color.Black;
            Name = "LoadingForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit( );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        public System.Windows.Forms.PictureBox PictureBox;
        public System.ComponentModel.BackgroundWorker Worker;
        public System.Windows.Forms.Timer Timer;
        private Button CloaseButton;
    }
}
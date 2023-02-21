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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.CloaseButton = new BudgetExecution.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.Image = global::BudgetExecution.Properties.Resources.Loading;
            this.PictureBox.Location = new System.Drawing.Point(260, 82);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(800, 600);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // Worker
            // 
            this.Worker.WorkerReportsProgress = true;
            this.Worker.WorkerSupportsCancellation = true;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 5000;
            // 
            // CloaseButton
            // 
            this.CloaseButton.BindingSource = null;
            this.CloaseButton.DataFilter = null;
            this.CloaseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.CloaseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CloaseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.CloaseButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloaseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloaseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.CloaseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.CloaseButton.HoverText = null;
            this.CloaseButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.CloaseButton.IsDerivedStyle = true;
            this.CloaseButton.Location = new System.Drawing.Point(1186, 691);
            this.CloaseButton.Name = "CloaseButton";
            this.CloaseButton.NormalBorderColor = System.Drawing.Color.Black;
            this.CloaseButton.NormalColor = System.Drawing.Color.Black;
            this.CloaseButton.NormalTextColor = System.Drawing.Color.Black;
            this.CloaseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloaseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloaseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloaseButton.PressTextColor = System.Drawing.Color.White;
            this.CloaseButton.Size = new System.Drawing.Size(140, 40);
            this.CloaseButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.CloaseButton.StyleManager = null;
            this.CloaseButton.TabIndex = 1;
            this.CloaseButton.Text = "button1";
            this.CloaseButton.ThemeAuthor = "Terry D. Eppler";
            this.CloaseButton.ThemeName = "Budget Execution";
            this.CloaseButton.ToolTip = null;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionBarHeight = 1;
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1338, 743);
            this.Controls.Add(this.CloaseButton);
            this.Controls.Add(this.PictureBox);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "LoadingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox PictureBox;
        public System.ComponentModel.BackgroundWorker Worker;
        public System.Windows.Forms.Timer Timer;
        private Button CloaseButton;
    }
}
namespace BudgetExecution
{
    partial class FormBase
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( FormBase ) );
            SuspendLayout( );
            // 
            // FormBase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 1350, 750 );
            ControlBox = false;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            HeaderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            HeaderHeight = 5;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "FormBase";
            ShowBorder = true;
            ShowIcon = false;
            ShowLeftRect = false;
            ShowTitle = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            SmallLineColor1 = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SmallLineColor2 = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SmallRectThickness = 0;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Style = MetroSet_UI.Enums.Style.Custom;
            TextColor = System.Drawing.Color.DarkGray;
            ThemeName = "MetroDark";
            UseSlideAnimation = true;
            ResumeLayout( false );
        }

        #endregion
    }
}
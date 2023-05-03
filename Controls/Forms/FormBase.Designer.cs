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
            splashMessage1 =  new SplashMessage( ) ;
            SuspendLayout( );
            // 
            // splashMessage1
            // 
            splashMessage1.AnimationSpeed =  20 ;
            splashMessage1.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            splashMessage1.BeforeTouchSize =  new System.Drawing.Size( 329, 172 ) ;
            splashMessage1.BindingSource =  null ;
            splashMessage1.BorderStyle =  System.Windows.Forms.Border3DStyle.Flat ;
            splashMessage1.CloseOnClick =  true ;
            splashMessage1.DataFilter =  null ;
            splashMessage1.DiscreetLocation =  new System.Drawing.Point( 0, 0 ) ;
            splashMessage1.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            splashMessage1.ForeColor =  System.Drawing.Color.White ;
            splashMessage1.Images =  null ;
            splashMessage1.Location =  new System.Drawing.Point( 397, 276 ) ;
            splashMessage1.MarqueeDirection =  Syncfusion.Windows.Forms.Tools.SplashPanelMarqueeDirection.RightToLeft ;
            splashMessage1.MarqueePosition =  Syncfusion.Windows.Forms.Tools.MarqueePosition.BottomRight ;
            splashMessage1.Name =  "splashMessage1" ;
            splashMessage1.Size =  new System.Drawing.Size( 329, 172 ) ;
            splashMessage1.SlideStyle =  Syncfusion.Windows.Forms.Tools.SlideStyle.FadeIn ;
            splashMessage1.TabIndex =  0 ;
            splashMessage1.Text =  "splashMessage1" ;
            splashMessage1.ToolTip =  null ;
            // 
            // FormBase
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   15  ,   15  ,   15   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionAlign =  System.Windows.Forms.HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   15  ,   15  ,   15   ) ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.DarkRed ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 1338, 713 ) ;
            Controls.Add( splashMessage1 );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.DarkGray ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximumSize =  new System.Drawing.Size( 1350, 750 ) ;
            MetroColor =  System.Drawing.Color.FromArgb(   15  ,   15  ,   15   ) ;
            MinimumSize =  new System.Drawing.Size( 1350, 750 ) ;
            Name =  "FormBase" ;
            ShowIcon =  false ;
            StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen ;
            ResumeLayout( false );
        }

        #endregion

        private SplashMessage splashMessage1;
    }
}
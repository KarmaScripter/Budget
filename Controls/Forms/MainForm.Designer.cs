namespace BudgetExecution
{


    partial class MainForm
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
            components =  new System.ComponentModel.Container( ) ;
            var captionImage1 = new Syncfusion.Windows.Forms.CaptionImage( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            BindingSource =  new System.Windows.Forms.BindingSource( components ) ;
            Darkmode =  new MetroSet_UI.Components.StyleManager( ) ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            SuspendLayout( );
            // 
            // Darkmode
            // 
            Darkmode.CustomTheme =  "C:\\Users\\terry\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml" ;
            Darkmode.MetroForm =  this ;
            Darkmode.Style =  MetroSet_UI.Enums.Style.Custom ;
            Darkmode.ThemeAuthor =  "Terry D. Eppler" ;
            Darkmode.ThemeName =  "BudgetExecution" ;
            // 
            // MainForm
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionAlign =  System.Windows.Forms.HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.Red ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            captionImage1.BackColor =  System.Drawing.Color.Transparent ;
            captionImage1.Location =  new System.Drawing.Point( 4, 4 ) ;
            captionImage1.Name =  "CaptionImage" ;
            captionImage1.Size =  new System.Drawing.Size( 22, 22 ) ;
            CaptionImages.Add( captionImage1 );
            ClientSize =  new System.Drawing.Size( 1338, 713 ) ;
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.DarkGray ;
            FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedSingle ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 1350, 750 ) ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            MinimumSize =  new System.Drawing.Size( 1350, 750 ) ;
            Name =  "MainForm" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        public MetroSet_UI.Components.StyleManager Darkmode;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        private Tile GuidanceTile;
        private Tile ReportingTile;
        private Tile UtilityTile;
        private Tile ClientTile;
        private Tile WebTile;
        public Button ExitButton;
        public Tile DatabaseTile;
        public Button TestButton;
    }
}
namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    partial class CalendarDialog
    {
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            components =  new Container( ) ;
            var resources = new ComponentResourceManager( typeof( CalendarDialog ) );
            ToolTip =  new SmallTip( ) ;
            BindingSource =  new BindingSource( components ) ;
            CloseButton =  new Button( ) ;
            Header =  new TableLayoutPanel( ) ;
            PictureBox =  new PictureBox( ) ;
            HeaderLabel =  new Label( ) ;
            Calendar =  new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv( ) ;
            ( (ISupportInitialize) BindingSource  ).BeginInit( );
            Header.SuspendLayout( );
            ( (ISupportInitialize) PictureBox  ).BeginInit( );
            ( (ISupportInitialize) Calendar  ).BeginInit( );
            SuspendLayout( );
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay =  5000 ;
            ToolTip.BackColor =  System.Drawing.Color.FromArgb(   5  ,   5  ,   5   ) ;
            ToolTip.BindingSource =  null ;
            ToolTip.BorderColor =  System.Drawing.SystemColors.Highlight ;
            ToolTip.ForeColor =  System.Drawing.Color.White ;
            ToolTip.InitialDelay =  500 ;
            ToolTip.IsDerivedStyle =  true ;
            ToolTip.Name =  null ;
            ToolTip.OwnerDraw =  true ;
            ToolTip.ReshowDelay =  100 ;
            ToolTip.Style =  MetroSet_UI.Enums.Style.Custom ;
            ToolTip.StyleManager =  null ;
            ToolTip.ThemeAuthor =  "Terry D. Eppler" ;
            ToolTip.ThemeName =  "Budget Execution" ;
            ToolTip.TipIcon =  ToolTipIcon.Info ;
            ToolTip.TipText =  null ;
            ToolTip.TipTitle =  null ;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource =  null ;
            CloseButton.DataFilter =  null ;
            CloseButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            CloseButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CloseButton.ForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            CloseButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            CloseButton.HoverText =  null ;
            CloseButton.HoverTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.IsDerivedStyle =  true ;
            CloseButton.Location =  new System.Drawing.Point( 441, 358 ) ;
            CloseButton.Name =  "CloseButton" ;
            CloseButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalTextColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CloseButton.Padding =  new Padding( 1 ) ;
            CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressTextColor =  System.Drawing.Color.White ;
            CloseButton.Size =  new System.Drawing.Size( 90, 25 ) ;
            CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            CloseButton.StyleManager =  null ;
            CloseButton.TabIndex =  1 ;
            CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
            CloseButton.ThemeName =  "Budget Execution" ;
            CloseButton.ToolTip =  null ;
            // 
            // Header
            // 
            Header.ColumnCount =  2 ;
            Header.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 5.59085131F ) );
            Header.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 94.40915F ) );
            Header.Controls.Add( PictureBox, 0, 0 );
            Header.Controls.Add( HeaderLabel, 1, 0 );
            Header.Dock =  DockStyle.Top ;
            Header.Location =  new System.Drawing.Point( 0, 0 ) ;
            Header.Name =  "Header" ;
            Header.RowCount =  1 ;
            Header.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            Header.Size =  new System.Drawing.Size( 572, 34 ) ;
            Header.TabIndex =  2 ;
            // 
            // PictureBox
            // 
            PictureBox.Image =  Properties.Resources.Calendar ;
            PictureBox.Location =  new System.Drawing.Point( 3, 3 ) ;
            PictureBox.Name =  "PictureBox" ;
            PictureBox.Size =  new System.Drawing.Size( 25, 23 ) ;
            PictureBox.SizeMode =  PictureBoxSizeMode.Zoom ;
            PictureBox.TabIndex =  0 ;
            PictureBox.TabStop =  false ;
            // 
            // HeaderLabel
            // 
            HeaderLabel.BindingSource =  null ;
            HeaderLabel.DataFilter =  null ;
            HeaderLabel.Dock =  DockStyle.Fill ;
            HeaderLabel.FlatStyle =  FlatStyle.Flat ;
            HeaderLabel.Font =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            HeaderLabel.HoverText =  null ;
            HeaderLabel.IsDerivedStyle =  true ;
            HeaderLabel.Location =  new System.Drawing.Point( 34, 3 ) ;
            HeaderLabel.Margin =  new Padding( 3 ) ;
            HeaderLabel.Name =  "HeaderLabel" ;
            HeaderLabel.Padding =  new Padding( 1 ) ;
            HeaderLabel.Size =  new System.Drawing.Size( 535, 28 ) ;
            HeaderLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
            HeaderLabel.StyleManager =  null ;
            HeaderLabel.TabIndex =  1 ;
            HeaderLabel.Text =  "Budget Calendar" ;
            HeaderLabel.TextAlign =  System.Drawing.ContentAlignment.MiddleCenter ;
            HeaderLabel.ThemeAuthor =  "Terry D. Eppler" ;
            HeaderLabel.ThemeName =  "Budget Execution" ;
            HeaderLabel.ToolTip =  null ;
            // 
            // Calendar
            // 
            Calendar.BorderColor =  System.Drawing.Color.FromArgb(   209  ,   211  ,   212   ) ;
            Calendar.BottomHeight =  24 ;
            Calendar.Culture =  new System.Globalization.CultureInfo( "" ) ;
            Calendar.DayNamesFont =  new System.Drawing.Font( "Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.DaysFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.HeaderFont =  new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.HighlightColor =  System.Drawing.Color.Black ;
            Calendar.Iso8601CalenderFormat =  false ;
            Calendar.Location =  new System.Drawing.Point( 48, 53 ) ;
            Calendar.MetroColor =  System.Drawing.Color.FromArgb(   22  ,   165  ,   220   ) ;
            Calendar.Name =  "Calendar" ;
            // 
            // 
            // 
            Calendar.NoneButton.AutoSize =  true ;
            Calendar.NoneButton.Location =  new System.Drawing.Point( 425, 0 ) ;
            Calendar.NoneButton.Size =  new System.Drawing.Size( 72, 24 ) ;
            Calendar.NoneButton.Text =  "None" ;
            Calendar.Size =  new System.Drawing.Size( 497, 299 ) ;
            Calendar.TabIndex =  3 ;
            // 
            // 
            // 
            Calendar.TodayButton.AutoSize =  true ;
            Calendar.TodayButton.Location =  new System.Drawing.Point( 0, 0 ) ;
            Calendar.TodayButton.Size =  new System.Drawing.Size( 425, 24 ) ;
            Calendar.TodayButton.Text =  "Today" ;
            Calendar.WeekFont =  new System.Drawing.Font( "Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            // 
            // CalendarDialog
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionAlign =  HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionBarHeight =  5 ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.Red ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 572, 395 ) ;
            Controls.Add( Calendar );
            Controls.Add( Header );
            Controls.Add( CloseButton );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            FormBorderStyle =  FormBorderStyle.FixedSingle ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 614, 450 ) ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            Name =  "CalendarDialog" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            ShowMouseOver =  true ;
            SizeGripStyle =  SizeGripStyle.Hide ;
            StartPosition =  FormStartPosition.CenterScreen ;
            ( (ISupportInitialize) BindingSource  ).EndInit( );
            Header.ResumeLayout( false );
            ( (ISupportInitialize) PictureBox  ).EndInit( );
            ( (ISupportInitialize) Calendar  ).EndInit( );
            ResumeLayout( false );
        }

        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public Button CloseButton;
        public PictureBox PictureBox;
        public TableLayoutPanel Header;
        public Label HeaderLabel;
        public Syncfusion.Windows.Forms.Tools.MonthCalendarAdv Calendar;
    }
}
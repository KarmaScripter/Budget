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
            BindingSource =  new BindingSource( components ) ;
            Header =  new TableLayoutPanel( ) ;
            PictureBox =  new PictureBox( ) ;
            Calendar =  new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv( ) ;
            ToolTip =  new SmallTip( ) ;
            ( (ISupportInitialize) BindingSource  ).BeginInit( );
            Header.SuspendLayout( );
            ( (ISupportInitialize) PictureBox  ).BeginInit( );
            ( (ISupportInitialize) Calendar  ).BeginInit( );
            SuspendLayout( );
            // 
            // Header
            // 
            Header.ColumnCount =  2 ;
            Header.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 5.59085131F ) );
            Header.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 94.40915F ) );
            Header.Controls.Add( PictureBox, 0, 0 );
            Header.Dock =  DockStyle.Top ;
            Header.ForeColor =  System.Drawing.Color.FromArgb( 0, 120, 212 ) ;
            Header.Location =  new System.Drawing.Point( 0, 0 ) ;
            Header.Name =  "Header" ;
            Header.RowCount =  1 ;
            Header.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            Header.Size =  new System.Drawing.Size( 427, 34 ) ;
            Header.TabIndex =  2 ;
            // 
            // PictureBox
            // 
            PictureBox.Image =  Properties.Resources.Calendar ;
            PictureBox.Location =  new System.Drawing.Point( 3, 3 ) ;
            PictureBox.Name =  "PictureBox" ;
            PictureBox.Size =  new System.Drawing.Size( 17, 23 ) ;
            PictureBox.SizeMode =  PictureBoxSizeMode.Zoom ;
            PictureBox.TabIndex =  0 ;
            PictureBox.TabStop =  false ;
            // 
            // Calendar
            // 
            Calendar.Border3DStyle =  Border3DStyle.Flat ;
            Calendar.BorderColor =  System.Drawing.Color.FromArgb( 209, 211, 212 ) ;
            Calendar.BottomHeight =  30 ;
            Calendar.Culture =  new System.Globalization.CultureInfo( "" ) ;
            Calendar.DayNamesColor =  System.Drawing.Color.Black ;
            Calendar.DayNamesFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.DayNamesHeight =  22 ;
            Calendar.DaysColor =  System.Drawing.Color.Black ;
            Calendar.DaysFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Dock =  DockStyle.Fill ;
            Calendar.FirstDayOfWeek =  Day.Monday ;
            Calendar.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.GridBackColor =  System.Drawing.SystemColors.GradientActiveCaption ;
            Calendar.GridLines =  Syncfusion.Windows.Forms.Grid.GridBorderStyle.Dashed ;
            Calendar.HeaderEndColor =  System.Drawing.Color.FromArgb( 50, 93, 129 ) ;
            Calendar.HeaderFont =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.HeaderHeight =  34 ;
            Calendar.HeaderStartColor =  System.Drawing.Color.FromArgb( 50, 93, 129 ) ;
            Calendar.HeadForeColor =  System.Drawing.Color.White ;
            Calendar.HighlightColor =  System.Drawing.Color.Black ;
            Calendar.Iso8601CalenderFormat =  false ;
            Calendar.Location =  new System.Drawing.Point( 0, 34 ) ;
            Calendar.Margin =  new Padding( 4, 3, 4, 3 ) ;
            Calendar.MetroColor =  System.Drawing.Color.FromArgb( 22, 165, 220 ) ;
            Calendar.Name =  "Calendar" ;
            // 
            // 
            // 
            Calendar.NoneButton.AutoSize =  true ;
            Calendar.NoneButton.BackColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
            Calendar.NoneButton.Location =  new System.Drawing.Point( 140, 0 ) ;
            Calendar.NoneButton.Margin =  new Padding( 4, 3, 4, 3 ) ;
            Calendar.NoneButton.Office2007ColorScheme =  Office2007Theme.Black ;
            Calendar.NoneButton.Office2010ColorScheme =  Office2010Theme.Black ;
            Calendar.NoneButton.Size =  new System.Drawing.Size( 287, 30 ) ;
            Calendar.NoneButton.Text =  "None" ;
            Calendar.NoneButton.ThemeName =  "None" ;
            Calendar.NoneButton.UseVisualStyle =  false ;
            Calendar.Office2007Theme =  Office2007Theme.Black ;
            Calendar.Office2010Theme =  Office2010Theme.Black ;
            Calendar.ScrollButtonSize =  new System.Drawing.Size( 20, 20 ) ;
            Calendar.Size =  new System.Drawing.Size( 427, 327 ) ;
            Calendar.TabIndex =  3 ;
            // 
            // 
            // 
            Calendar.TodayButton.AutoSize =  true ;
            Calendar.TodayButton.BackColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
            Calendar.TodayButton.Location =  new System.Drawing.Point( 0, 0 ) ;
            Calendar.TodayButton.Margin =  new Padding( 4, 3, 4, 3 ) ;
            Calendar.TodayButton.Office2007ColorScheme =  Office2007Theme.Black ;
            Calendar.TodayButton.Office2010ColorScheme =  Office2010Theme.Black ;
            Calendar.TodayButton.Size =  new System.Drawing.Size( 140, 30 ) ;
            Calendar.TodayButton.Text =  "Today" ;
            Calendar.TodayButton.ThemeName =  "None" ;
            Calendar.TodayButton.UseVisualStyle =  false ;
            Calendar.WeekFont =  new System.Drawing.Font( "Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay =  5000 ;
            ToolTip.BackColor =  System.Drawing.Color.FromArgb( 5, 5, 5 ) ;
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
            // CalendarDialog
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
            BorderColor =  System.Drawing.Color.FromArgb( 0, 120, 212 ) ;
            CaptionAlign =  HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
            CaptionBarHeight =  5 ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.Red ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb( 0, 120, 212 ) ;
            ClientSize =  new System.Drawing.Size( 427, 361 ) ;
            Controls.Add( Calendar );
            Controls.Add( Header );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            FormBorderStyle =  FormBorderStyle.FixedSingle ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 504, 391 ) ;
            MetroColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
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

        public System.Windows.Forms.BindingSource BindingSource;
        public PictureBox PictureBox;
        public TableLayoutPanel Header;
        public Label HeaderLabel;
        public Syncfusion.Windows.Forms.Tools.MonthCalendarAdv Calendar;
        private SmallTip ToolTip;
    }
}
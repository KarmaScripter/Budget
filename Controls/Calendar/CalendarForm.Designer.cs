namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    partial class CalendarForm
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
            var resources = new ComponentResourceManager( typeof( CalendarForm ) );
            Calendar =  new Syncfusion.WinForms.Input.SfCalendar( ) ;
            ToolTip =  new SmallTip( ) ;
            BindingSource =  new BindingSource( components ) ;
            CloseButton =  new Button( ) ;
            ( (ISupportInitialize) BindingSource  ).BeginInit( );
            SuspendLayout( );
            // 
            // Calendar
            // 
            Calendar.CanOverrideStyle =  true ;
            Calendar.FirstDayOfWeek =  System.DayOfWeek.Monday ;
            Calendar.Location =  new System.Drawing.Point( 32, 51 ) ;
            Calendar.MinimumSize =  new System.Drawing.Size( 196, 196 ) ;
            Calendar.Name =  "Calendar" ;
            Calendar.ShowToolTip =  true ;
            Calendar.Size =  new System.Drawing.Size( 728, 345 ) ;
            Calendar.Style.BorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.BlackoutDatesBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.BlackoutDatesFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.BlackoutDatesForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.CellBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.CellFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.CellForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Cell.CellHoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Cell.SelectedCellBackColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Cell.SelectedCellBorderColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Cell.SelectedCellFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.SelectedCellForeColor =  System.Drawing.Color.White ;
            Calendar.Style.Cell.SelectedCellHoverBorderColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Cell.TodayBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.TodayFont =  new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.TodayForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Cell.TodayHoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Cell.TrailingCellBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.TrailingCellFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.TrailingCellForeColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Cell.WeekNumberBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Cell.WeekNumberFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Cell.WeekNumberForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Footer.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Footer.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Footer.HoverBackColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Footer.HoverForeColor =  System.Drawing.Color.White ;
            Calendar.Style.Header.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Header.DayNamesBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Calendar.Style.Header.DayNamesFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Header.DayNamesForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Header.Font =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            Calendar.Style.Header.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Calendar.Style.Header.HoverForeColor =  System.Drawing.Color.White ;
            Calendar.Style.Header.NavigationButtonDisabledForeColor =  System.Drawing.Color.DimGray ;
            Calendar.Style.Header.NavigationButtonForeColor =  System.Drawing.Color.SteelBlue ;
            Calendar.Style.Header.NavigationButtonHoverForeColor =  System.Drawing.Color.White ;
            Calendar.Style.HorizontalSplitterColor =  System.Drawing.Color.DimGray ;
            Calendar.Style.VerticalSplitterColor =  System.Drawing.Color.DimGray ;
            Calendar.TabIndex =  0 ;
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
            CloseButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            CloseButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            CloseButton.HoverText =  null ;
            CloseButton.HoverTextColor =  System.Drawing.Color.LightSteelBlue ;
            CloseButton.IsDerivedStyle =  true ;
            CloseButton.Location =  new System.Drawing.Point( 670, 433 ) ;
            CloseButton.Name =  "CloseButton" ;
            CloseButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.Padding =  new Padding( 1 ) ;
            CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressTextColor =  System.Drawing.Color.White ;
            CloseButton.Size =  new System.Drawing.Size( 105, 33 ) ;
            CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            CloseButton.StyleManager =  null ;
            CloseButton.TabIndex =  1 ;
            CloseButton.Text =  "Close" ;
            CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
            CloseButton.ThemeName =  "Budget Execution" ;
            CloseButton.ToolTip =  null ;
            // 
            // CalendarForm
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionAlign =  HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.Red ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 787, 469 ) ;
            Controls.Add( CloseButton );
            Controls.Add( Calendar );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightSteelBlue ;
            FormBorderStyle =  FormBorderStyle.FixedSingle ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            Name =  "CalendarForm" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            ShowMouseOver =  true ;
            StartPosition =  FormStartPosition.CenterScreen ;
            ( (ISupportInitialize) BindingSource  ).EndInit( );
            ResumeLayout( false );
        }

        public Syncfusion.WinForms.Input.SfCalendar Calendar;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public Button CloseButton;
    }
}
namespace BudgetExecution
{


    partial class ChartForm
    {

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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( ChartForm ) );
            BindingSource =  new System.Windows.Forms.BindingSource( components ) ;
            ChartTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            LabelTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            TableTabPage =  new Syncfusion.Windows.Forms.Tools.TabPageAdv( ) ;
            FilterTabPage =  new Syncfusion.Windows.Forms.Tools.TabPageAdv( ) ;
            FilterTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            GroupTabPage =  new Syncfusion.Windows.Forms.Tools.TabPageAdv( ) ;
            NumericTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            FieldTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            CalendarTabPage =  new Syncfusion.Windows.Forms.Tools.TabPageAdv( ) ;
            CalendarTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            SecondCalendar =  new Syncfusion.WinForms.Input.SfCalendar( ) ;
            FirstCalendar =  new Syncfusion.WinForms.Input.SfCalendar( ) ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            ChartTable.SuspendLayout( );
            FilterTabPage.SuspendLayout( );
            GroupTabPage.SuspendLayout( );
            CalendarTabPage.SuspendLayout( );
            SuspendLayout( );
            // 
            // ChartTable
            // 
            ChartTable.ColumnCount =  1 ;
            ChartTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartTable.Controls.Add( LabelTable, 0, 0 );
            ChartTable.Location =  new System.Drawing.Point( 32, 31 ) ;
            ChartTable.Name =  "ChartTable" ;
            ChartTable.RowCount =  2 ;
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 5.748865F ) );
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 94.25114F ) );
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            ChartTable.Size =  new System.Drawing.Size( 970, 586 ) ;
            ChartTable.TabIndex =  5 ;
            // 
            // LabelTable
            // 
            LabelTable.ColumnCount =  4 ;
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 58.25771F ) );
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 41.74229F ) );
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 209F ) );
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 196F ) );
            LabelTable.Dock =  System.Windows.Forms.DockStyle.Fill ;
            LabelTable.Location =  new System.Drawing.Point( 3, 3 ) ;
            LabelTable.Name =  "LabelTable" ;
            LabelTable.RowCount =  1 ;
            LabelTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            LabelTable.Size =  new System.Drawing.Size( 964, 27 ) ;
            LabelTable.TabIndex =  5 ;
            // 
            // TableTabPage
            // 
            TableTabPage.Image =  null ;
            TableTabPage.ImageSize =  new System.Drawing.Size( 16, 16 ) ;
            TableTabPage.Location =  new System.Drawing.Point( 0, 9 ) ;
            TableTabPage.Name =  "TableTabPage" ;
            TableTabPage.ShowCloseButton =  true ;
            TableTabPage.Size =  new System.Drawing.Size( 303, 568 ) ;
            TableTabPage.TabBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TableTabPage.TabFont =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            TableTabPage.TabForeColor =  System.Drawing.Color.DarkGray ;
            TableTabPage.TabIndex =  3 ;
            TableTabPage.ThemesEnabled =  false ;
            // 
            // FilterTabPage
            // 
            FilterTabPage.Controls.Add( FilterTable );
            FilterTabPage.Image =  null ;
            FilterTabPage.ImageSize =  new System.Drawing.Size( 16, 16 ) ;
            FilterTabPage.Location =  new System.Drawing.Point( 0, 9 ) ;
            FilterTabPage.Name =  "FilterTabPage" ;
            FilterTabPage.ShowCloseButton =  true ;
            FilterTabPage.Size =  new System.Drawing.Size( 303, 568 ) ;
            FilterTabPage.TabBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FilterTabPage.TabFont =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FilterTabPage.TabForeColor =  System.Drawing.Color.DarkGray ;
            FilterTabPage.TabIndex =  1 ;
            FilterTabPage.ThemesEnabled =  false ;
            // 
            // FilterTable
            // 
            FilterTable.ColumnCount =  1 ;
            FilterTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            FilterTable.Location =  new System.Drawing.Point( 3, 3 ) ;
            FilterTable.Name =  "FilterTable" ;
            FilterTable.RowCount =  6 ;
            FilterTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 22.78481F ) );
            FilterTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 77.21519F ) );
            FilterTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 34F ) );
            FilterTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 162F ) );
            FilterTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 36F ) );
            FilterTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 165F ) );
            FilterTable.Size =  new System.Drawing.Size( 296, 557 ) ;
            FilterTable.TabIndex =  46 ;
            // 
            // GroupTabPage
            // 
            GroupTabPage.Controls.Add( NumericTable );
            GroupTabPage.Controls.Add( FieldTable );
            GroupTabPage.Image =  null ;
            GroupTabPage.ImageSize =  new System.Drawing.Size( 16, 16 ) ;
            GroupTabPage.Location =  new System.Drawing.Point( 0, 9 ) ;
            GroupTabPage.Name =  "GroupTabPage" ;
            GroupTabPage.ShowCloseButton =  true ;
            GroupTabPage.Size =  new System.Drawing.Size( 303, 568 ) ;
            GroupTabPage.TabBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            GroupTabPage.TabFont =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            GroupTabPage.TabForeColor =  System.Drawing.Color.DarkGray ;
            GroupTabPage.TabIndex =  2 ;
            GroupTabPage.ThemesEnabled =  false ;
            // 
            // NumericTable
            // 
            NumericTable.ColumnCount =  1 ;
            NumericTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            NumericTable.Location =  new System.Drawing.Point( 5, 299 ) ;
            NumericTable.Name =  "NumericTable" ;
            NumericTable.RowCount =  2 ;
            NumericTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 25F ) );
            NumericTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 191F ) );
            NumericTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            NumericTable.Size =  new System.Drawing.Size( 295, 261 ) ;
            NumericTable.TabIndex =  9 ;
            // 
            // FieldTable
            // 
            FieldTable.ColumnCount =  1 ;
            FieldTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            FieldTable.Location =  new System.Drawing.Point( 5, 0 ) ;
            FieldTable.Name =  "FieldTable" ;
            FieldTable.RowCount =  2 ;
            FieldTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 27F ) );
            FieldTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 189F ) );
            FieldTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            FieldTable.Size =  new System.Drawing.Size( 295, 280 ) ;
            FieldTable.TabIndex =  8 ;
            // 
            // CalendarTabPage
            // 
            CalendarTabPage.Controls.Add( CalendarTable );
            CalendarTabPage.Image =  null ;
            CalendarTabPage.ImageSize =  new System.Drawing.Size( 16, 16 ) ;
            CalendarTabPage.Location =  new System.Drawing.Point( 0, 9 ) ;
            CalendarTabPage.Name =  "CalendarTabPage" ;
            CalendarTabPage.ShowCloseButton =  true ;
            CalendarTabPage.Size =  new System.Drawing.Size( 303, 568 ) ;
            CalendarTabPage.TabFont =  null ;
            CalendarTabPage.TabIndex =  4 ;
            CalendarTabPage.Text =  "tabPageAdv3" ;
            CalendarTabPage.ThemesEnabled =  false ;
            // 
            // CalendarTable
            // 
            CalendarTable.ColumnCount =  1 ;
            CalendarTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            CalendarTable.GrowStyle =  System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize ;
            CalendarTable.Location =  new System.Drawing.Point( 3, 3 ) ;
            CalendarTable.Name =  "CalendarTable" ;
            CalendarTable.RowCount =  4 ;
            CalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 11.55235F ) );
            CalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 88.44765F ) );
            CalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 33F ) );
            CalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 266F ) );
            CalendarTable.Size =  new System.Drawing.Size( 300, 557 ) ;
            CalendarTable.TabIndex =  1 ;
            // 
            // SecondCalendar
            // 
            SecondCalendar.CanOverrideStyle =  true ;
            SecondCalendar.Dock =  System.Windows.Forms.DockStyle.Fill ;
            SecondCalendar.FirstDayOfWeek =  System.DayOfWeek.Monday ;
            SecondCalendar.Location =  new System.Drawing.Point( 1, 1 ) ;
            SecondCalendar.MinimumSize =  new System.Drawing.Size( 196, 196 ) ;
            SecondCalendar.Name =  "SecondCalendar" ;
            SecondCalendar.ShowToolTip =  true ;
            SecondCalendar.Size =  new System.Drawing.Size( 287, 259 ) ;
            SecondCalendar.Style.BorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondCalendar.Style.Cell.BlackoutDatesBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondCalendar.Style.Cell.BlackoutDatesFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SecondCalendar.Style.Cell.BlackoutDatesForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondCalendar.Style.Cell.CellBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondCalendar.Style.Cell.CellFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SecondCalendar.Style.Cell.CellForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondCalendar.Style.Cell.CellHoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondCalendar.Style.Cell.SelectedCellBackColor =  System.Drawing.Color.SteelBlue ;
            SecondCalendar.Style.Cell.SelectedCellBorderColor =  System.Drawing.Color.SteelBlue ;
            SecondCalendar.Style.Cell.SelectedCellFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            SecondCalendar.Style.Cell.SelectedCellForeColor =  System.Drawing.Color.White ;
            SecondCalendar.Style.Cell.SelectedCellHoverBorderColor =  System.Drawing.Color.SteelBlue ;
            SecondCalendar.Style.Cell.TodayBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondCalendar.Style.Cell.TodayFont =  new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            SecondCalendar.Style.Cell.TodayForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondCalendar.Style.Cell.TodayHoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondCalendar.Style.Cell.TrailingCellBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondCalendar.Style.Cell.TrailingCellFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SecondCalendar.Style.Cell.TrailingCellForeColor =  System.Drawing.Color.SteelBlue ;
            SecondCalendar.Style.Cell.WeekNumberBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondCalendar.Style.Cell.WeekNumberFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SecondCalendar.Style.Cell.WeekNumberForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondCalendar.Style.Footer.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondCalendar.Style.Footer.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondCalendar.Style.Footer.HoverBackColor =  System.Drawing.Color.SteelBlue ;
            SecondCalendar.Style.Footer.HoverForeColor =  System.Drawing.Color.White ;
            SecondCalendar.Style.Header.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondCalendar.Style.Header.DayNamesBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondCalendar.Style.Header.DayNamesFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SecondCalendar.Style.Header.DayNamesForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondCalendar.Style.Header.Font =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            SecondCalendar.Style.Header.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondCalendar.Style.Header.HoverForeColor =  System.Drawing.Color.White ;
            SecondCalendar.Style.Header.NavigationButtonDisabledForeColor =  System.Drawing.Color.DimGray ;
            SecondCalendar.Style.Header.NavigationButtonForeColor =  System.Drawing.Color.SteelBlue ;
            SecondCalendar.Style.Header.NavigationButtonHoverForeColor =  System.Drawing.Color.White ;
            SecondCalendar.Style.HorizontalSplitterColor =  System.Drawing.Color.DimGray ;
            SecondCalendar.Style.VerticalSplitterColor =  System.Drawing.Color.DimGray ;
            SecondCalendar.TabIndex =  3 ;
            // 
            // FirstCalendar
            // 
            FirstCalendar.CanOverrideStyle =  true ;
            FirstCalendar.Dock =  System.Windows.Forms.DockStyle.Fill ;
            FirstCalendar.FirstDayOfWeek =  System.DayOfWeek.Monday ;
            FirstCalendar.Location =  new System.Drawing.Point( 1, 1 ) ;
            FirstCalendar.MinimumSize =  new System.Drawing.Size( 196, 196 ) ;
            FirstCalendar.Name =  "FirstCalendar" ;
            FirstCalendar.ShowToolTip =  true ;
            FirstCalendar.Size =  new System.Drawing.Size( 287, 220 ) ;
            FirstCalendar.Style.BorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstCalendar.Style.Cell.BlackoutDatesBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstCalendar.Style.Cell.BlackoutDatesFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstCalendar.Style.Cell.BlackoutDatesForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstCalendar.Style.Cell.CellBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstCalendar.Style.Cell.CellFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstCalendar.Style.Cell.CellForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstCalendar.Style.Cell.CellHoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstCalendar.Style.Cell.SelectedCellBackColor =  System.Drawing.Color.SteelBlue ;
            FirstCalendar.Style.Cell.SelectedCellBorderColor =  System.Drawing.Color.SteelBlue ;
            FirstCalendar.Style.Cell.SelectedCellFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            FirstCalendar.Style.Cell.SelectedCellForeColor =  System.Drawing.Color.White ;
            FirstCalendar.Style.Cell.SelectedCellHoverBorderColor =  System.Drawing.Color.SteelBlue ;
            FirstCalendar.Style.Cell.TodayBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstCalendar.Style.Cell.TodayFont =  new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            FirstCalendar.Style.Cell.TodayForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstCalendar.Style.Cell.TodayHoverBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstCalendar.Style.Cell.TrailingCellBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstCalendar.Style.Cell.TrailingCellFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstCalendar.Style.Cell.TrailingCellForeColor =  System.Drawing.Color.SteelBlue ;
            FirstCalendar.Style.Cell.WeekNumberBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstCalendar.Style.Cell.WeekNumberFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstCalendar.Style.Cell.WeekNumberForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstCalendar.Style.Footer.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstCalendar.Style.Footer.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstCalendar.Style.Footer.HoverBackColor =  System.Drawing.Color.SteelBlue ;
            FirstCalendar.Style.Footer.HoverForeColor =  System.Drawing.Color.White ;
            FirstCalendar.Style.Header.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstCalendar.Style.Header.DayNamesBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstCalendar.Style.Header.DayNamesFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstCalendar.Style.Header.DayNamesForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstCalendar.Style.Header.Font =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            FirstCalendar.Style.Header.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstCalendar.Style.Header.HoverForeColor =  System.Drawing.Color.White ;
            FirstCalendar.Style.Header.NavigationButtonDisabledForeColor =  System.Drawing.Color.DimGray ;
            FirstCalendar.Style.Header.NavigationButtonForeColor =  System.Drawing.Color.SteelBlue ;
            FirstCalendar.Style.Header.NavigationButtonHoverForeColor =  System.Drawing.Color.White ;
            FirstCalendar.Style.HorizontalSplitterColor =  System.Drawing.Color.DimGray ;
            FirstCalendar.Style.VerticalSplitterColor =  System.Drawing.Color.DimGray ;
            FirstCalendar.TabIndex =  2 ;
            // 
            // ChartForm
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionAlign =  System.Windows.Forms.HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 1338, 714 ) ;
            Controls.Add( ChartTable );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedSingle ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 1400, 800 ) ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            MinimumSize =  new System.Drawing.Size( 1300, 700 ) ;
            Name =  "ChartForm" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            ShowMouseOver =  true ;
            StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen ;
            Text =  " Visualization" ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ChartTable.ResumeLayout( false );
            FilterTabPage.ResumeLayout( false );
            GroupTabPage.ResumeLayout( false );
            CalendarTabPage.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.BindingSource BindingSource;
        public SmallTip ToolTip;
        public ToolStrip ToolStrip;
        private ToolSeparator Separator2;
        public ToolStripLabel Label;
        private ToolSeparator Separator1;
        public ToolStripButton LookupButton;
        private ToolSeparator Separator3;
        public ToolStripTextBox ToolStripTextBox;
        private ToolSeparator TextBoxSeparator;
        public ToolStripButton FirstButton;
        public ToolStripButton PreviousButton;
        private ToolSeparator PreviousButtonSeparator;
        public ToolStripButton NextButton;
        private ToolSeparator Separator8;
        public ToolStripButton LastButton;
        private ToolSeparator Separator7;
        public ToolStripDropDown DropDown;
        private ToolSeparator Separator9;
        public Chart Chart;
        public ToolStripButton RemoveFiltersButton;
        private ToolSeparator Separator10;
        public ToolStripButton TableButton;
        private ToolSeparator Separator14;
        public ToolStripButton ExcelButton;
        private ToolSeparator Separator11;
        public ToolStripButton CalendarButton;
        private ToolSeparator Separator12;
        public ToolStripButton CalculatorButton;
        private ToolSeparator Separator13;
        public ToolStripButton MenuButton;
        private ToolSeparator toolSeparator15;
        private Layout ChartPanel;
        public ToolStripButton BackButton;
        private ToolSeparator Separator17;
        private System.Windows.Forms.TableLayoutPanel ChartTable;

        private System.Windows.Forms.TableLayoutPanel LabelTable;
        private Label SecondHeaderLabel;
        private Label FourthHeaderLabel;
        private Label FirstHeaderLabel;
        private Label ThirdHeaderLabel;
        public TabControl TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv TableTabPage;
        public Layout TablePanel;
        public ListBox TableListBox;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv FilterTabPage;
        private System.Windows.Forms.TableLayoutPanel FilterTable;
        private ComboBox ThirdComboBox;
        public Layout ThirdListBoxPanel;
        public ListBox ThirdListBox;
        public Layout FirstListBoxPanel;
        public ListBox FirstListBox;
        private ComboBox FirstComboBox;
        private ComboBox SecondComboBox;
        public Layout SecondListBoxPanel;
        public ListBox SecondListBox;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv GroupTabPage;
        private System.Windows.Forms.TableLayoutPanel NumericTable;
        public Layout NumericsPanel;
        public ListBox NumericListBox;
        private Label NumericsLabel;
        private System.Windows.Forms.TableLayoutPanel FieldTable;
        public Layout FieldPanel;
        public ListBox FieldListBox;
        private Label FieldsLabel;
        public ToolStripButton RefreshDataButton;
        private ToolSeparator Separator18;
        public ToolStripButton GroupButton;
        private ToolSeparator GroupButtonSeparator;
        private ToolSeparator ExitSeparator;
        public ToolStripButton ExitButton;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv CalendarTabPage;
        private System.Windows.Forms.TableLayoutPanel CalendarTable;
        public Layout SecondCalendarPanel;
        public Syncfusion.WinForms.Input.SfCalendar SecondCalendar;
        public Layout FirstCalendarPanel;
        public Syncfusion.WinForms.Input.SfCalendar FirstCalendar;
        public Label FirstCalendarLabel;
        public Label SecondCalendarLabel;
        public ToolSeparator FirstButtonSeparator;
    }
}
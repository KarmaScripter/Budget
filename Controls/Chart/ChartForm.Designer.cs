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
            var dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle( );
            GridTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            LabelTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            ChartTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            ChartPanel =  new Layout( ) ;
            Chart =  new Chart( ) ;
            ChartLabelTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            SecondHeaderLabel =  new Label( ) ;
            FourthHeaderLabel =  new Label( ) ;
            FirstHeaderLabel =  new Label( ) ;
            ThirdHeaderLabel =  new Label( ) ;
            ToolStrip =  new ToolStrip( ) ;
            BindingSource =  new System.Windows.Forms.BindingSource( components ) ;
            TableButton =  new ToolStripButton( ) ;
            ToolTip =  new SmallTip( ) ;
            ExcelButton =  new ToolStripButton( ) ;
            FirstButton =  new ToolStripButton( ) ;
            Label1 =  new ToolStripLabel( ) ;
            ToolStripSeparator =  new ToolSeparator( ) ;
            ToolStripTextBox =  new ToolStripTextBox( ) ;
            TextBoxSeparator =  new ToolSeparator( ) ;
            FirstSeparator =  new ToolSeparator( ) ;
            PreviousButton =  new ToolStripButton( ) ;
            PreviousSeparator =  new ToolSeparator( ) ;
            NextButton =  new ToolStripButton( ) ;
            NextSeparator =  new ToolSeparator( ) ;
            LastButton =  new ToolStripButton( ) ;
            LastSeparator =  new ToolSeparator( ) ;
            FilterButton =  new ToolStripButton( ) ;
            RemoveFiltersSeparator =  new ToolSeparator( ) ;
            EditSqlSeparator =  new ToolSeparator( ) ;
            TableSeparator =  new ToolSeparator( ) ;
            DropDown =  new ToolStripDropDown( ) ;
            DropDownSeparator =  new ToolSeparator( ) ;
            Label2 =  new ToolStripLabel( ) ;
            LabelSeparator =  new ToolSeparator( ) ;
            BackButton =  new ToolStripButton( ) ;
            BackSeparator =  new ToolSeparator( ) ;
            MenuButton =  new ToolStripButton( ) ;
            MenuSeparator =  new ToolSeparator( ) ;
            ExitButton =  new ToolStripButton( ) ;
            ExcelSeparator =  new ToolSeparator( ) ;
            RefreshDataSeparator =  new ToolSeparator( ) ;
            GroupSeparator =  new ToolSeparator( ) ;
            ContextMenu =  new ContextMenu( ) ;
            FirstTable =  new HeaderPanel( ) ;
            FirstComboBox =  new ComboBox( ) ;
            FirstListBoxPanel =  new Layout( ) ;
            FirstListBox =  new ListBox( ) ;
            SecondTable =  new HeaderPanel( ) ;
            SecondListBoxPanel =  new Layout( ) ;
            SecondListBox =  new ListBox( ) ;
            SecondComboBox =  new ComboBox( ) ;
            ChartTable.SuspendLayout( );
            ChartPanel.SuspendLayout( );
            ChartLabelTable.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            FirstTable.SuspendLayout( );
            FirstListBoxPanel.SuspendLayout( );
            SecondTable.SuspendLayout( );
            SecondListBoxPanel.SuspendLayout( );
            SuspendLayout( );
            // 
            // GridTable
            // 
            GridTable.Location =  new System.Drawing.Point( 0, 0 ) ;
            GridTable.Name =  "GridTable" ;
            GridTable.Size =  new System.Drawing.Size( 200, 100 ) ;
            GridTable.TabIndex =  0 ;
            // 
            // LabelTable
            // 
            LabelTable.ColumnCount =  4 ;
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 71.65533F ) );
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 28.34467F ) );
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 120F ) );
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 411F ) );
            LabelTable.Dock =  System.Windows.Forms.DockStyle.Fill ;
            LabelTable.Location =  new System.Drawing.Point( 3, 3 ) ;
            LabelTable.Name =  "LabelTable" ;
            LabelTable.RowCount =  1 ;
            LabelTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            LabelTable.Size =  new System.Drawing.Size( 194, 26 ) ;
            LabelTable.TabIndex =  1 ;
            // 
            // ChartTable
            // 
            ChartTable.AutoSizeMode =  System.Windows.Forms.AutoSizeMode.GrowAndShrink ;
            ChartTable.BackColor =  System.Drawing.Color.Transparent ;
            ChartTable.ColumnCount =  1 ;
            ChartTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            ChartTable.Controls.Add( ChartPanel, 0, 1 );
            ChartTable.Controls.Add( ChartLabelTable, 0, 0 );
            ChartTable.Location =  new System.Drawing.Point( 49, 76 ) ;
            ChartTable.Name =  "ChartTable" ;
            ChartTable.RowCount =  2 ;
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            ChartTable.Size =  new System.Drawing.Size( 970, 590 ) ;
            ChartTable.TabIndex =  38 ;
            // 
            // ChartPanel
            // 
            ChartPanel.BackColor =  System.Drawing.Color.Transparent ;
            ChartPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ChartPanel.BindingSource =  null ;
            ChartPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            ChartPanel.BorderThickness =  1 ;
            ChartPanel.Children =  null ;
            ChartPanel.Controls.Add( Chart );
            ChartPanel.DataFilter =  null ;
            ChartPanel.Dock =  System.Windows.Forms.DockStyle.Fill ;
            ChartPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ChartPanel.ForeColor =  System.Drawing.Color.Transparent ;
            ChartPanel.HoverText =  null ;
            ChartPanel.IsDerivedStyle =  true ;
            ChartPanel.Location =  new System.Drawing.Point( 3, 35 ) ;
            ChartPanel.Name =  "ChartPanel" ;
            ChartPanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ChartPanel.Size =  new System.Drawing.Size( 964, 552 ) ;
            ChartPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            ChartPanel.StyleManager =  null ;
            ChartPanel.TabIndex =  47 ;
            ChartPanel.ThemeAuthor =  "Terry D. Eppler" ;
            ChartPanel.ThemeName =  "Budget Execution" ;
            ChartPanel.ToolTip =  null ;
            // 
            // Chart
            // 
            Chart.AllowGapForEmptyPoints =  false ;
            Chart.AllowGradientPalette =  true ;
            Chart.AllowUserEditStyles =  true ;
            Chart.Anchor =  System.Windows.Forms.AnchorStyles.None ;
            Chart.AutoHighlight =  true ;
            Chart.AxisModel =  null ;
            Chart.BindingModel =  null ;
            Chart.BindingSource =  null ;
            Chart.ChartArea.AutoScale =  true ;
            Chart.ChartArea.BorderColor =  System.Drawing.Color.Transparent ;
            Chart.ChartArea.CursorLocation =  new System.Drawing.Point( 0, 0 ) ;
            Chart.ChartArea.CursorReDraw =  false ;
            Chart.ChartAreaMargins =  new Syncfusion.Windows.Forms.Chart.ChartMargins( 3, 3, 3, 3 ) ;
            Chart.ChartSeries =  null ;
            Chart.Data =  null ;
            Chart.DataTable =  null ;
            Chart.Depth =  250F ;
            Chart.DisplayChartContextMenu =  false ;
            Chart.DisplaySeriesContextMenu =  false ;
            Chart.EnableMouseRotation =  true ;
            Chart.Field =  Field.AccountCode ;
            Chart.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Chart.IsWindowLess =  false ;
            // 
            // 
            // 
            Chart.Legend.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Chart.Legend.ItemsAlignment =  System.Drawing.StringAlignment.Center ;
            Chart.Legend.ItemsSize =  new System.Drawing.Size( 10, 10 ) ;
            Chart.Legend.Location =  new System.Drawing.Point( 825, 64 ) ;
            Chart.Legend.ShowItemsShadow =  true ;
            Chart.Legend.ShowSymbol =  true ;
            Chart.Legend.VisibleCheckBox =  true ;
            Chart.Localize =  null ;
            Chart.Location =  new System.Drawing.Point( 18, 38 ) ;
            Chart.Name =  "Chart" ;
            Chart.Numeric =  Numeric.Accepted ;
            Chart.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Chart.Palette =  Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro ;
            Chart.PrimaryXAxis.LogLabelsDisplayMode =  Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default ;
            Chart.PrimaryXAxis.Margin =  true ;
            Chart.PrimaryYAxis.LogLabelsDisplayMode =  Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default ;
            Chart.PrimaryYAxis.Margin =  true ;
            Chart.RealMode3D =  true ;
            Chart.Rotation =  0.1F ;
            Chart.Series3D =  true ;
            Chart.SeriesHighlight =  true ;
            Chart.SeriesType =  Syncfusion.Windows.Forms.Chart.ChartSeriesType.Line ;
            Chart.ShowScrollBars =  false ;
            Chart.ShowToolbar =  true ;
            Chart.ShowToolTips =  true ;
            Chart.Size =  new System.Drawing.Size( 928, 486 ) ;
            Chart.Source =  Source.External ;
            Chart.Spacing =  5F ;
            Chart.SpacingBetweenPoints =  5F ;
            Chart.SpacingBetweenSeries =  5F ;
            Chart.Stat =  STAT.NS ;
            Chart.STAT =  STAT.NS ;
            Chart.Style3D =  true ;
            Chart.TabIndex =  1 ;
            Chart.Text =  "chart1" ;
            Chart.Tilt =  5F ;
            // 
            // 
            // 
            Chart.Title.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Chart.Title.Font =  new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Chart.Title.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            Chart.Title.Name =  "Default" ;
            Chart.Titles.Add( Chart.Title );
            Chart.ToolBar.ButtonBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            Chart.ToolBar.Location =  new System.Drawing.Point( 0, 0 ) ;
            Chart.ToolBar.Position =  Syncfusion.Windows.Forms.Chart.ChartDock.Floating ;
            Chart.ToolBar.ShowBorder =  false ;
            Chart.ToolBar.ShowGrip =  false ;
            Chart.ToolBar.Visible =  true ;
            Chart.VisualTheme =  "" ;
            Chart.xAxis =  null ;
            Chart.yValues =  null ;
            // 
            // ChartLabelTable
            // 
            ChartLabelTable.ColumnCount =  4 ;
            ChartLabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 71.65533F ) );
            ChartLabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 28.34467F ) );
            ChartLabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 120F ) );
            ChartLabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 411F ) );
            ChartLabelTable.Controls.Add( SecondHeaderLabel, 1, 0 );
            ChartLabelTable.Controls.Add( FourthHeaderLabel, 3, 0 );
            ChartLabelTable.Controls.Add( FirstHeaderLabel, 0, 0 );
            ChartLabelTable.Controls.Add( ThirdHeaderLabel, 2, 0 );
            ChartLabelTable.Dock =  System.Windows.Forms.DockStyle.Fill ;
            ChartLabelTable.Location =  new System.Drawing.Point( 3, 3 ) ;
            ChartLabelTable.Name =  "ChartLabelTable" ;
            ChartLabelTable.RowCount =  1 ;
            ChartLabelTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartLabelTable.Size =  new System.Drawing.Size( 964, 26 ) ;
            ChartLabelTable.TabIndex =  1 ;
            // 
            // SecondHeaderLabel
            // 
            SecondHeaderLabel.BindingSource =  null ;
            SecondHeaderLabel.DataFilter =  null ;
            SecondHeaderLabel.Dock =  System.Windows.Forms.DockStyle.Fill ;
            SecondHeaderLabel.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
            SecondHeaderLabel.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SecondHeaderLabel.HoverText =  null ;
            SecondHeaderLabel.IsDerivedStyle =  true ;
            SecondHeaderLabel.Location =  new System.Drawing.Point( 313, 3 ) ;
            SecondHeaderLabel.Margin =  new System.Windows.Forms.Padding( 3 ) ;
            SecondHeaderLabel.Name =  "SecondHeaderLabel" ;
            SecondHeaderLabel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            SecondHeaderLabel.Size =  new System.Drawing.Size( 116, 20 ) ;
            SecondHeaderLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
            SecondHeaderLabel.StyleManager =  null ;
            SecondHeaderLabel.TabIndex =  44 ;
            SecondHeaderLabel.Text =  "Source" ;
            SecondHeaderLabel.TextAlign =  System.Drawing.ContentAlignment.BottomLeft ;
            SecondHeaderLabel.ThemeAuthor =  "Terry D. Eppler" ;
            SecondHeaderLabel.ThemeName =  "BudgetExecution" ;
            SecondHeaderLabel.ToolTip =  null ;
            // 
            // FourthHeaderLabel
            // 
            FourthHeaderLabel.BindingSource =  null ;
            FourthHeaderLabel.DataFilter =  null ;
            FourthHeaderLabel.Dock =  System.Windows.Forms.DockStyle.Fill ;
            FourthHeaderLabel.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
            FourthHeaderLabel.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FourthHeaderLabel.HoverText =  null ;
            FourthHeaderLabel.IsDerivedStyle =  true ;
            FourthHeaderLabel.Location =  new System.Drawing.Point( 555, 3 ) ;
            FourthHeaderLabel.Margin =  new System.Windows.Forms.Padding( 3 ) ;
            FourthHeaderLabel.Name =  "FourthHeaderLabel" ;
            FourthHeaderLabel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            FourthHeaderLabel.Size =  new System.Drawing.Size( 406, 20 ) ;
            FourthHeaderLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
            FourthHeaderLabel.StyleManager =  null ;
            FourthHeaderLabel.TabIndex =  44 ;
            FourthHeaderLabel.Text =  "Source" ;
            FourthHeaderLabel.TextAlign =  System.Drawing.ContentAlignment.BottomLeft ;
            FourthHeaderLabel.ThemeAuthor =  "Terry D. Eppler" ;
            FourthHeaderLabel.ThemeName =  "BudgetExecution" ;
            FourthHeaderLabel.ToolTip =  null ;
            // 
            // FirstHeaderLabel
            // 
            FirstHeaderLabel.BindingSource =  null ;
            FirstHeaderLabel.DataFilter =  null ;
            FirstHeaderLabel.Dock =  System.Windows.Forms.DockStyle.Fill ;
            FirstHeaderLabel.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
            FirstHeaderLabel.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstHeaderLabel.HoverText =  null ;
            FirstHeaderLabel.IsDerivedStyle =  true ;
            FirstHeaderLabel.Location =  new System.Drawing.Point( 3, 3 ) ;
            FirstHeaderLabel.Margin =  new System.Windows.Forms.Padding( 3 ) ;
            FirstHeaderLabel.Name =  "FirstHeaderLabel" ;
            FirstHeaderLabel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            FirstHeaderLabel.Size =  new System.Drawing.Size( 304, 20 ) ;
            FirstHeaderLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
            FirstHeaderLabel.StyleManager =  null ;
            FirstHeaderLabel.TabIndex =  33 ;
            FirstHeaderLabel.Text =  "Source" ;
            FirstHeaderLabel.TextAlign =  System.Drawing.ContentAlignment.BottomLeft ;
            FirstHeaderLabel.ThemeAuthor =  "Terry D. Eppler" ;
            FirstHeaderLabel.ThemeName =  "BudgetExecution" ;
            FirstHeaderLabel.ToolTip =  null ;
            // 
            // ThirdHeaderLabel
            // 
            ThirdHeaderLabel.BindingSource =  null ;
            ThirdHeaderLabel.DataFilter =  null ;
            ThirdHeaderLabel.Dock =  System.Windows.Forms.DockStyle.Fill ;
            ThirdHeaderLabel.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
            ThirdHeaderLabel.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ThirdHeaderLabel.HoverText =  null ;
            ThirdHeaderLabel.IsDerivedStyle =  true ;
            ThirdHeaderLabel.Location =  new System.Drawing.Point( 435, 3 ) ;
            ThirdHeaderLabel.Margin =  new System.Windows.Forms.Padding( 3 ) ;
            ThirdHeaderLabel.Name =  "ThirdHeaderLabel" ;
            ThirdHeaderLabel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ThirdHeaderLabel.Size =  new System.Drawing.Size( 114, 20 ) ;
            ThirdHeaderLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
            ThirdHeaderLabel.StyleManager =  null ;
            ThirdHeaderLabel.TabIndex =  43 ;
            ThirdHeaderLabel.Text =  "Source" ;
            ThirdHeaderLabel.TextAlign =  System.Drawing.ContentAlignment.BottomLeft ;
            ThirdHeaderLabel.ThemeAuthor =  "Terry D. Eppler" ;
            ThirdHeaderLabel.ThemeName =  "BudgetExecution" ;
            ThirdHeaderLabel.ToolTip =  null ;
            // 
            // ToolStrip
            // 
            ToolStrip.AddButton =  null ;
            ToolStrip.AddColumnButton =  null ;
            ToolStrip.AddTableButton =  null ;
            ToolStrip.BackColor =  System.Drawing.Color.Transparent ;
            ToolStrip.BindingSource =  BindingSource ;
            ToolStrip.BorderStyle =  Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge ;
            ToolStrip.CalculatorButton =  null ;
            ToolStrip.CanOverrideStyle =  true ;
            ToolStrip.CaptionAlignment =  Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near ;
            ToolStrip.CaptionFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ToolStrip.CaptionStyle =  Syncfusion.Windows.Forms.Tools.CaptionStyle.Top ;
            ToolStrip.CaptionTextStyle =  Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain ;
            ToolStrip.ChartButton =  TableButton ;
            ToolStrip.DataFilter =  null ;
            ToolStrip.DeleteButton =  null ;
            ToolStrip.DeleteColumnButton =  null ;
            ToolStrip.DeleteRecordButton =  null ;
            ToolStrip.DeleteTableButton =  null ;
            ToolStrip.Dock =  System.Windows.Forms.DockStyle.Bottom ;
            ToolStrip.DropDown =  null ;
            ToolStrip.EditButton =  null ;
            ToolStrip.EditColumnButton =  null ;
            ToolStrip.EditRecordButton =  null ;
            ToolStrip.EditSqlButton =  null ;
            ToolStrip.ExcelButton =  ExcelButton ;
            ToolStrip.FilterDataButton =  null ;
            ToolStrip.FirstButton =  FirstButton ;
            ToolStrip.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ToolStrip.ForeColor =  System.Drawing.Color.MidnightBlue ;
            ToolStrip.GripStyle =  System.Windows.Forms.ToolStripGripStyle.Hidden ;
            ToolStrip.HomeButton =  null ;
            ToolStrip.Image =  null ;
            ToolStrip.ImageDirectory =  null ;
            ToolStrip.ImageSize =  new System.Drawing.Size( 16, 16 ) ;
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Label1, ToolStripSeparator, ToolStripTextBox, TextBoxSeparator, FirstButton, FirstSeparator, PreviousButton, PreviousSeparator, NextButton, NextSeparator, LastButton, LastSeparator, FilterButton, RemoveFiltersSeparator, ExcelButton, EditSqlSeparator, TableButton, TableSeparator, DropDown, DropDownSeparator, Label2, LabelSeparator, BackButton, BackSeparator, MenuButton, MenuSeparator, ExitButton } );
            ToolStrip.Label =  null ;
            ToolStrip.LastButton =  LastButton ;
            ToolStrip.LauncherStyle =  Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12 ;
            ToolStrip.Location =  new System.Drawing.Point( 0, 693 ) ;
            ToolStrip.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            ToolStrip.Name =  "ToolStrip" ;
            ToolStrip.NextButton =  NextButton ;
            ToolStrip.Office12Mode =  false ;
            ToolStrip.OfficeColorScheme =  Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue ;
            ToolStrip.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ToolStrip.PreviousButton =  PreviousButton ;
            ToolStrip.ProgressBar =  null ;
            ToolStrip.RefreshButton =  null ;
            ToolStrip.SaveButton =  null ;
            ToolStrip.SearchCriteriaLabel =  null ;
            ToolStrip.SearchEngineLabel =  null ;
            ToolStrip.Separators =  null ;
            ToolStrip.ShowCaption =  true ;
            ToolStrip.ShowLauncher =  true ;
            ToolStrip.Size =  new System.Drawing.Size( 1338, 46 ) ;
            ToolStrip.TabIndex =  42 ;
            ToolStrip.Text =  "Visualizations" ;
            ToolStrip.TextBox =  ToolStripTextBox ;
            ToolStrip.ThemeName =  "Office2016DarkGray" ;
            ToolStrip.ThemeStyle.ArrowColor =  System.Drawing.Color.SteelBlue ;
            ToolStrip.ThemeStyle.BackColor =  System.Drawing.Color.Transparent ;
            ToolStrip.ThemeStyle.BottomToolStripBackColor =  System.Drawing.Color.Transparent ;
            ToolStrip.ThemeStyle.CaptionBackColor =  System.Drawing.Color.FromArgb(   28  ,   28  ,   28   ) ;
            ToolStrip.ThemeStyle.CaptionForeColor =  System.Drawing.Color.Black ;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor =  System.Drawing.Color.SteelBlue ;
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor =  System.Drawing.Color.FromArgb(   40  ,   40  ,   40   ) ;
            ToolStrip.ThemeStyle.HoverItemBackColor =  System.Drawing.Color.SteelBlue ;
            ToolStrip.ThemeStyle.HoverItemForeColor =  System.Drawing.Color.White ;
            ToolStrip.VisualStyle =  Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray ;
            // 
            // TableButton
            // 
            TableButton.AutoToolTip =  false ;
            TableButton.BackColor =  System.Drawing.Color.Transparent ;
            TableButton.BindingSource =  BindingSource ;
            TableButton.DataFilter =  null ;
            TableButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            TableButton.Field =  Field.AccountCode ;
            TableButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            TableButton.ForeColor =  System.Drawing.Color.LightGray ;
            TableButton.HoverText =  "Data Table" ;
            TableButton.Image =  Properties.Resources.TableButton ;
            TableButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            TableButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            TableButton.Name =  "TableButton" ;
            TableButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            TableButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            TableButton.Text =  "toolStripButton2" ;
            TableButton.ToolTip =  ToolTip ;
            TableButton.ToolType =  ToolType.TableButton ;
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
            ToolTip.TipIcon =  System.Windows.Forms.ToolTipIcon.Info ;
            ToolTip.TipText =  null ;
            ToolTip.TipTitle =  null ;
            // 
            // ExcelButton
            // 
            ExcelButton.AutoToolTip =  false ;
            ExcelButton.BackColor =  System.Drawing.Color.Transparent ;
            ExcelButton.BindingSource =  BindingSource ;
            ExcelButton.DataFilter =  null ;
            ExcelButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            ExcelButton.Field =  Field.AccountCode ;
            ExcelButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ExcelButton.ForeColor =  System.Drawing.Color.LightGray ;
            ExcelButton.HoverText =  "Excel Export" ;
            ExcelButton.Image =  Properties.Resources.ExcelButton ;
            ExcelButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            ExcelButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            ExcelButton.Name =  "ExcelButton" ;
            ExcelButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ExcelButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            ExcelButton.Text =  "toolStripButton2" ;
            ExcelButton.ToolTip =  null ;
            ExcelButton.ToolType =  ToolType.ExcelExportButton ;
            // 
            // FirstButton
            // 
            FirstButton.AutoToolTip =  false ;
            FirstButton.BackColor =  System.Drawing.Color.Transparent ;
            FirstButton.BindingSource =  null ;
            FirstButton.DataFilter =  null ;
            FirstButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            FirstButton.Field =  Field.AccountCode ;
            FirstButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstButton.ForeColor =  System.Drawing.Color.LightGray ;
            FirstButton.HoverText =  "First Record" ;
            FirstButton.Image =  Properties.Resources.FirstButton ;
            FirstButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            FirstButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            FirstButton.Name =  "FirstButton" ;
            FirstButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            FirstButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            FirstButton.ToolTip =  null ;
            FirstButton.ToolType =  ToolType.FirstButton ;
            // 
            // Label1
            // 
            Label1.BackColor =  System.Drawing.Color.FromArgb(   45  ,   45  ,   45   ) ;
            Label1.BindingSource =  null ;
            Label1.DataFilter =  null ;
            Label1.Field =  Field.AccountCode ;
            Label1.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Label1.ForeColor =  System.Drawing.Color.Transparent ;
            Label1.HoverText =  null ;
            Label1.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Label1.Name =  "Label1" ;
            Label1.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Label1.Size =  new System.Drawing.Size( 135, 28 ) ;
            Label1.Tag =  "" ;
            Label1.Text =  "this is a label for spacing" ;
            Label1.ToolTip =  null ;
            // 
            // ToolStripSeparator
            // 
            ToolStripSeparator.ForeColor =  System.Drawing.Color.Black ;
            ToolStripSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            ToolStripSeparator.Name =  "ToolStripSeparator" ;
            ToolStripSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ToolStripSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // ToolStripTextBox
            // 
            ToolStripTextBox.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            ToolStripTextBox.BindingSource =  null ;
            ToolStripTextBox.Field =  Field.AccountCode ;
            ToolStripTextBox.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ToolStripTextBox.ForeColor =  System.Drawing.SystemColors.WindowText ;
            ToolStripTextBox.HoverText =  "" ;
            ToolStripTextBox.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            ToolStripTextBox.Name =  "ToolStripTextBox" ;
            ToolStripTextBox.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ToolStripTextBox.Size =  new System.Drawing.Size( 154, 28 ) ;
            ToolStripTextBox.Tag =  "" ;
            ToolStripTextBox.ToolTip =  null ;
            // 
            // TextBoxSeparator
            // 
            TextBoxSeparator.ForeColor =  System.Drawing.Color.Black ;
            TextBoxSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            TextBoxSeparator.Name =  "TextBoxSeparator" ;
            TextBoxSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            TextBoxSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // FirstSeparator
            // 
            FirstSeparator.ForeColor =  System.Drawing.Color.Black ;
            FirstSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            FirstSeparator.Name =  "FirstSeparator" ;
            FirstSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            FirstSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // PreviousButton
            // 
            PreviousButton.AutoToolTip =  false ;
            PreviousButton.BackColor =  System.Drawing.Color.Transparent ;
            PreviousButton.BindingSource =  null ;
            PreviousButton.DataFilter =  null ;
            PreviousButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            PreviousButton.Field =  Field.AccountCode ;
            PreviousButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            PreviousButton.ForeColor =  System.Drawing.Color.LightGray ;
            PreviousButton.HoverText =  "Previous Button" ;
            PreviousButton.Image =  Properties.Resources.PreviousButton ;
            PreviousButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            PreviousButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            PreviousButton.Name =  "PreviousButton" ;
            PreviousButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            PreviousButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            PreviousButton.Text =  "toolStripButton2" ;
            PreviousButton.ToolTip =  null ;
            PreviousButton.ToolType =  ToolType.NS ;
            // 
            // PreviousSeparator
            // 
            PreviousSeparator.ForeColor =  System.Drawing.Color.Black ;
            PreviousSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            PreviousSeparator.Name =  "PreviousSeparator" ;
            PreviousSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            PreviousSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // NextButton
            // 
            NextButton.AutoToolTip =  false ;
            NextButton.BackColor =  System.Drawing.Color.Transparent ;
            NextButton.BindingSource =  null ;
            NextButton.DataFilter =  null ;
            NextButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            NextButton.Field =  Field.AccountCode ;
            NextButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            NextButton.ForeColor =  System.Drawing.Color.LightGray ;
            NextButton.HoverText =  "Next Record" ;
            NextButton.Image =  Properties.Resources.NextButton ;
            NextButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            NextButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            NextButton.Name =  "NextButton" ;
            NextButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            NextButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            NextButton.Text =  "toolStripButton3" ;
            NextButton.ToolTip =  null ;
            NextButton.ToolType =  ToolType.NextButton ;
            // 
            // NextSeparator
            // 
            NextSeparator.ForeColor =  System.Drawing.Color.Black ;
            NextSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            NextSeparator.Name =  "NextSeparator" ;
            NextSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            NextSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // LastButton
            // 
            LastButton.AutoToolTip =  false ;
            LastButton.BackColor =  System.Drawing.Color.Transparent ;
            LastButton.BindingSource =  null ;
            LastButton.DataFilter =  null ;
            LastButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            LastButton.Field =  Field.AccountCode ;
            LastButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            LastButton.ForeColor =  System.Drawing.Color.LightGray ;
            LastButton.HoverText =  "Last Record" ;
            LastButton.Image =  Properties.Resources.LastButton ;
            LastButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            LastButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            LastButton.Name =  "LastButton" ;
            LastButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            LastButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            LastButton.Text =  "toolStripButton4" ;
            LastButton.ToolTip =  null ;
            LastButton.ToolType =  ToolType.LastButton ;
            // 
            // LastSeparator
            // 
            LastSeparator.ForeColor =  System.Drawing.Color.Black ;
            LastSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            LastSeparator.Name =  "LastSeparator" ;
            LastSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            LastSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // FilterButton
            // 
            FilterButton.AutoToolTip =  false ;
            FilterButton.BackColor =  System.Drawing.Color.Transparent ;
            FilterButton.BindingSource =  BindingSource ;
            FilterButton.DataFilter =  null ;
            FilterButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            FilterButton.Field =  Field.AccountCode ;
            FilterButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FilterButton.ForeColor =  System.Drawing.Color.LightGray ;
            FilterButton.HoverText =  "Table Filters" ;
            FilterButton.Image =  Properties.Resources.FilterButton ;
            FilterButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            FilterButton.Margin =  new System.Windows.Forms.Padding( 3 ) ;
            FilterButton.Name =  "FilterButton" ;
            FilterButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            FilterButton.Size =  new System.Drawing.Size( 23, 24 ) ;
            FilterButton.Text =  "toolStripButton1" ;
            FilterButton.ToolTip =  null ;
            FilterButton.ToolType =  ToolType.FilterButton ;
            // 
            // RemoveFiltersSeparator
            // 
            RemoveFiltersSeparator.ForeColor =  System.Drawing.Color.Black ;
            RemoveFiltersSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            RemoveFiltersSeparator.Name =  "RemoveFiltersSeparator" ;
            RemoveFiltersSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            RemoveFiltersSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // EditSqlSeparator
            // 
            EditSqlSeparator.ForeColor =  System.Drawing.Color.Black ;
            EditSqlSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            EditSqlSeparator.Name =  "EditSqlSeparator" ;
            EditSqlSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            EditSqlSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // TableSeparator
            // 
            TableSeparator.ForeColor =  System.Drawing.Color.Black ;
            TableSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            TableSeparator.Name =  "TableSeparator" ;
            TableSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            TableSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // DropDown
            // 
            DropDown.AllowDrop =  true ;
            DropDown.BindingSource =  null ;
            DropDown.DataFilter =  null ;
            DropDown.DropDownStyle =  System.Windows.Forms.ComboBoxStyle.DropDownList ;
            DropDown.Field =  Field.AccountCode ;
            DropDown.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            DropDown.ForeColor =  System.Drawing.Color.FromArgb(   218  ,   218  ,   218   ) ;
            DropDown.HoverText =  "Make Selection" ;
            DropDown.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            DropDown.MaxDropDownItems =  100 ;
            DropDown.MaxLength =  32767 ;
            DropDown.Name =  "DropDown" ;
            DropDown.Numeric =  Numeric.Accepted ;
            DropDown.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            DropDown.Size =  new System.Drawing.Size( 200, 28 ) ;
            DropDown.Style =  Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black ;
            DropDown.Tag =  "Make Selection" ;
            DropDown.ToolTipText =  "Make Selection" ;
            // 
            // DropDownSeparator
            // 
            DropDownSeparator.ForeColor =  System.Drawing.Color.Black ;
            DropDownSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            DropDownSeparator.Name =  "DropDownSeparator" ;
            DropDownSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            DropDownSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // Label2
            // 
            Label2.BackColor =  System.Drawing.Color.FromArgb(   45  ,   45  ,   45   ) ;
            Label2.BindingSource =  null ;
            Label2.DataFilter =  null ;
            Label2.Field =  Field.AccountCode ;
            Label2.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            Label2.ForeColor =  System.Drawing.Color.Transparent ;
            Label2.HoverText =  null ;
            Label2.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            Label2.Name =  "Label2" ;
            Label2.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Label2.Size =  new System.Drawing.Size( 240, 28 ) ;
            Label2.Tag =  "" ;
            Label2.Text =  "this a lable for spacing this a lable for spacing" ;
            Label2.ToolTip =  null ;
            // 
            // LabelSeparator
            // 
            LabelSeparator.ForeColor =  System.Drawing.Color.Black ;
            LabelSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            LabelSeparator.Name =  "LabelSeparator" ;
            LabelSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            LabelSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // BackButton
            // 
            BackButton.AutoToolTip =  false ;
            BackButton.BackColor =  System.Drawing.Color.Transparent ;
            BackButton.BindingSource =  null ;
            BackButton.DataFilter =  null ;
            BackButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            BackButton.Field =  Field.AccountCode ;
            BackButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            BackButton.ForeColor =  System.Drawing.Color.LightGray ;
            BackButton.HoverText =  "Go Back" ;
            BackButton.Image =  Properties.Resources.BackButton ;
            BackButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            BackButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            BackButton.Name =  "BackButton" ;
            BackButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            BackButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            BackButton.Text =  "toolStripButton2" ;
            BackButton.ToolTip =  null ;
            BackButton.ToolType =  ToolType.BackButton ;
            // 
            // BackSeparator
            // 
            BackSeparator.ForeColor =  System.Drawing.Color.Black ;
            BackSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            BackSeparator.Name =  "BackSeparator" ;
            BackSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            BackSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // MenuButton
            // 
            MenuButton.AutoToolTip =  false ;
            MenuButton.BackColor =  System.Drawing.Color.Transparent ;
            MenuButton.BindingSource =  null ;
            MenuButton.DataFilter =  null ;
            MenuButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            MenuButton.Field =  Field.AccountCode ;
            MenuButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            MenuButton.ForeColor =  System.Drawing.Color.LightGray ;
            MenuButton.HoverText =  "Main Menu" ;
            MenuButton.Image =  Properties.Resources.HomeButton ;
            MenuButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            MenuButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            MenuButton.Name =  "MenuButton" ;
            MenuButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            MenuButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            MenuButton.Text =  "toolStripButton2" ;
            MenuButton.ToolTip =  null ;
            MenuButton.ToolType =  ToolType.MenuButton ;
            // 
            // MenuSeparator
            // 
            MenuSeparator.ForeColor =  System.Drawing.Color.Black ;
            MenuSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            MenuSeparator.Name =  "MenuSeparator" ;
            MenuSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            MenuSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // ExitButton
            // 
            ExitButton.AutoToolTip =  false ;
            ExitButton.BackColor =  System.Drawing.Color.Transparent ;
            ExitButton.BindingSource =  null ;
            ExitButton.DataFilter =  null ;
            ExitButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            ExitButton.Field =  Field.AccountCode ;
            ExitButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ExitButton.ForeColor =  System.Drawing.Color.LightGray ;
            ExitButton.HoverText =  "Exit Application" ;
            ExitButton.Image =  Properties.Resources.ShutdownButton ;
            ExitButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            ExitButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            ExitButton.Name =  "ExitButton" ;
            ExitButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ExitButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            ExitButton.Text =  "toolStripButton1" ;
            ExitButton.ToolTip =  null ;
            ExitButton.ToolType =  ToolType.ExitButton ;
            // 
            // ExcelSeparator
            // 
            ExcelSeparator.ForeColor =  System.Drawing.Color.Black ;
            ExcelSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            ExcelSeparator.Name =  "ExcelSeparator" ;
            ExcelSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ExcelSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // RefreshDataSeparator
            // 
            RefreshDataSeparator.ForeColor =  System.Drawing.Color.Black ;
            RefreshDataSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            RefreshDataSeparator.Name =  "RefreshDataSeparator" ;
            RefreshDataSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            RefreshDataSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // GroupSeparator
            // 
            GroupSeparator.ForeColor =  System.Drawing.Color.Black ;
            GroupSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            GroupSeparator.Name =  "GroupSeparator" ;
            GroupSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            GroupSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // ContextMenu
            // 
            ContextMenu.AutoSize =  false ;
            ContextMenu.BackColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
            ContextMenu.ForeColor =  System.Drawing.Color.White ;
            ContextMenu.IsDerivedStyle =  false ;
            ContextMenu.Name =  "ContextMenu" ;
            ContextMenu.RenderMode =  System.Windows.Forms.ToolStripRenderMode.System ;
            ContextMenu.Size =  new System.Drawing.Size( 156, 264 ) ;
            ContextMenu.Style =  MetroSet_UI.Enums.Style.Custom ;
            ContextMenu.StyleManager =  null ;
            ContextMenu.ThemeAuthor =  "Terry D. Eppler" ;
            ContextMenu.ThemeName =  "Budget Execution" ;
            // 
            // FirstTable
            // 
            FirstTable.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstTable.CaptionStyle =  CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle ;
            FirstTable.ColumnCount =  1 ;
            FirstTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            FirstTable.Controls.Add( FirstComboBox, 0, 0 );
            FirstTable.Controls.Add( FirstListBoxPanel, 0, 1 );
            FirstTable.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstTable.ForeColor =  System.Drawing.Color.DarkGray ;
            FirstTable.Location =  new System.Drawing.Point( 1043, 111 ) ;
            FirstTable.Name =  "FirstTable" ;
            FirstTable.RowCount =  2 ;
            FirstTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 13.818182F ) );
            FirstTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 86.1818161F ) );
            FirstTable.Size =  new System.Drawing.Size( 258, 275 ) ;
            FirstTable.TabIndex =  46 ;
            // 
            // FirstComboBox
            // 
            FirstComboBox.AllowDrop =  true ;
            FirstComboBox.ArrowColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstComboBox.BackColor =  System.Drawing.Color.Transparent ;
            FirstComboBox.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstComboBox.BindingSource =  null ;
            FirstComboBox.BorderColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
            FirstComboBox.CausesValidation =  false ;
            FirstComboBox.DataFilter =  null ;
            FirstComboBox.DisabledBackColor =  System.Drawing.Color.Transparent ;
            FirstComboBox.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            FirstComboBox.DisabledForeColor =  System.Drawing.Color.Transparent ;
            FirstComboBox.DrawMode =  System.Windows.Forms.DrawMode.OwnerDrawFixed ;
            FirstComboBox.DropDownStyle =  System.Windows.Forms.ComboBoxStyle.DropDownList ;
            FirstComboBox.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
            FirstComboBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstComboBox.FormattingEnabled =  true ;
            FirstComboBox.HoverText =  null ;
            FirstComboBox.IsDerivedStyle =  true ;
            FirstComboBox.ItemHeight =  24 ;
            FirstComboBox.Location =  new System.Drawing.Point( 3, 3 ) ;
            FirstComboBox.Name =  "FirstComboBox" ;
            FirstComboBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstComboBox.SelectedItemForeColor =  System.Drawing.Color.White ;
            FirstComboBox.Size =  new System.Drawing.Size( 252, 30 ) ;
            FirstComboBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            FirstComboBox.StyleManager =  null ;
            FirstComboBox.TabIndex =  0 ;
            FirstComboBox.ThemeAuthor =  "Terry D. Eppler" ;
            FirstComboBox.ThemeName =  "Budget Execution" ;
            FirstComboBox.ToolTip =  null ;
            // 
            // FirstListBoxPanel
            // 
            FirstListBoxPanel.BackColor =  System.Drawing.Color.Transparent ;
            FirstListBoxPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstListBoxPanel.BindingSource =  null ;
            FirstListBoxPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            FirstListBoxPanel.BorderThickness =  1 ;
            FirstListBoxPanel.Children =  null ;
            FirstListBoxPanel.Controls.Add( FirstListBox );
            FirstListBoxPanel.DataFilter =  null ;
            FirstListBoxPanel.Dock =  System.Windows.Forms.DockStyle.Fill ;
            FirstListBoxPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstListBoxPanel.ForeColor =  System.Drawing.Color.Transparent ;
            FirstListBoxPanel.HoverText =  null ;
            FirstListBoxPanel.IsDerivedStyle =  true ;
            FirstListBoxPanel.Location =  new System.Drawing.Point( 3, 41 ) ;
            FirstListBoxPanel.Name =  "FirstListBoxPanel" ;
            FirstListBoxPanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            FirstListBoxPanel.Size =  new System.Drawing.Size( 252, 231 ) ;
            FirstListBoxPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            FirstListBoxPanel.StyleManager =  null ;
            FirstListBoxPanel.TabIndex =  1 ;
            FirstListBoxPanel.ThemeAuthor =  "Terry D. Eppler" ;
            FirstListBoxPanel.ThemeName =  "Budget Execution" ;
            FirstListBoxPanel.ToolTip =  null ;
            // 
            // FirstListBox
            // 
            FirstListBox.BackColor =  System.Drawing.Color.FromArgb(   40  ,   40  ,   40   ) ;
            FirstListBox.BindingSource =  null ;
            FirstListBox.BorderColor =  System.Drawing.Color.FromArgb(   55  ,   55  ,   55   ) ;
            FirstListBox.DataFilter =  null ;
            FirstListBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstListBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstListBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstListBox.HoveredItemBackColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            FirstListBox.HoveredItemColor =  System.Drawing.Color.White ;
            FirstListBox.HoverText =  null ;
            FirstListBox.IsDerivedStyle =  true ;
            FirstListBox.ItemHeight =  28 ;
            FirstListBox.Location =  new System.Drawing.Point( 30, 22 ) ;
            FirstListBox.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            FirstListBox.MultiSelect =  true ;
            FirstListBox.Name =  "FirstListBox" ;
            FirstListBox.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            FirstListBox.SelectedIndex =  -1 ;
            FirstListBox.SelectedItem =  null ;
            FirstListBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            FirstListBox.SelectedItemColor =  System.Drawing.Color.White ;
            FirstListBox.SelectedText =  null ;
            FirstListBox.SelectedValue =  null ;
            FirstListBox.ShowBorder =  false ;
            FirstListBox.ShowScrollBar =  false ;
            FirstListBox.Size =  new System.Drawing.Size( 200, 187 ) ;
            FirstListBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            FirstListBox.StyleManager =  null ;
            FirstListBox.TabIndex =  0 ;
            FirstListBox.ThemeAuthor =  "Terry D. Eppler" ;
            FirstListBox.ThemeName =  "Budget Execution" ;
            FirstListBox.ToolTip =  null ;
            // 
            // SecondTable
            // 
            SecondTable.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondTable.CaptionStyle =  CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle ;
            SecondTable.ColumnCount =  1 ;
            SecondTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            SecondTable.Controls.Add( SecondListBoxPanel, 0, 1 );
            SecondTable.Controls.Add( SecondComboBox, 0, 0 );
            SecondTable.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SecondTable.ForeColor =  System.Drawing.Color.DarkGray ;
            SecondTable.Location =  new System.Drawing.Point( 1043, 407 ) ;
            SecondTable.Name =  "SecondTable" ;
            SecondTable.RowCount =  2 ;
            SecondTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 36F ) );
            SecondTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 11F ) );
            SecondTable.Size =  new System.Drawing.Size( 258, 259 ) ;
            SecondTable.TabIndex =  47 ;
            // 
            // SecondListBoxPanel
            // 
            SecondListBoxPanel.BackColor =  System.Drawing.Color.Transparent ;
            SecondListBoxPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondListBoxPanel.BindingSource =  null ;
            SecondListBoxPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            SecondListBoxPanel.BorderThickness =  1 ;
            SecondListBoxPanel.Children =  null ;
            SecondListBoxPanel.Controls.Add( SecondListBox );
            SecondListBoxPanel.DataFilter =  null ;
            SecondListBoxPanel.Dock =  System.Windows.Forms.DockStyle.Fill ;
            SecondListBoxPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SecondListBoxPanel.ForeColor =  System.Drawing.Color.Transparent ;
            SecondListBoxPanel.HoverText =  null ;
            SecondListBoxPanel.IsDerivedStyle =  true ;
            SecondListBoxPanel.Location =  new System.Drawing.Point( 3, 39 ) ;
            SecondListBoxPanel.Name =  "SecondListBoxPanel" ;
            SecondListBoxPanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            SecondListBoxPanel.Size =  new System.Drawing.Size( 252, 217 ) ;
            SecondListBoxPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            SecondListBoxPanel.StyleManager =  null ;
            SecondListBoxPanel.TabIndex =  47 ;
            SecondListBoxPanel.ThemeAuthor =  "Terry D. Eppler" ;
            SecondListBoxPanel.ThemeName =  "Budget Execution" ;
            SecondListBoxPanel.ToolTip =  null ;
            // 
            // SecondListBox
            // 
            SecondListBox.BackColor =  System.Drawing.Color.FromArgb(   40  ,   40  ,   40   ) ;
            SecondListBox.BindingSource =  null ;
            SecondListBox.BorderColor =  System.Drawing.Color.FromArgb(   55  ,   55  ,   55   ) ;
            SecondListBox.DataFilter =  null ;
            SecondListBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondListBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondListBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SecondListBox.HoveredItemBackColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            SecondListBox.HoveredItemColor =  System.Drawing.Color.White ;
            SecondListBox.HoverText =  null ;
            SecondListBox.IsDerivedStyle =  true ;
            SecondListBox.ItemHeight =  28 ;
            SecondListBox.Location =  new System.Drawing.Point( 31, 21 ) ;
            SecondListBox.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            SecondListBox.MultiSelect =  true ;
            SecondListBox.Name =  "SecondListBox" ;
            SecondListBox.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            SecondListBox.SelectedIndex =  -1 ;
            SecondListBox.SelectedItem =  null ;
            SecondListBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondListBox.SelectedItemColor =  System.Drawing.Color.White ;
            SecondListBox.SelectedText =  null ;
            SecondListBox.SelectedValue =  null ;
            SecondListBox.ShowBorder =  false ;
            SecondListBox.ShowScrollBar =  false ;
            SecondListBox.Size =  new System.Drawing.Size( 200, 166 ) ;
            SecondListBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            SecondListBox.StyleManager =  null ;
            SecondListBox.TabIndex =  0 ;
            SecondListBox.ThemeAuthor =  "Terry D. Eppler" ;
            SecondListBox.ThemeName =  "Budget Execution" ;
            SecondListBox.ToolTip =  null ;
            // 
            // SecondComboBox
            // 
            SecondComboBox.AllowDrop =  true ;
            SecondComboBox.ArrowColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondComboBox.BackColor =  System.Drawing.Color.Transparent ;
            SecondComboBox.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            SecondComboBox.BindingSource =  null ;
            SecondComboBox.BorderColor =  System.Drawing.Color.FromArgb(   64  ,   64  ,   64   ) ;
            SecondComboBox.CausesValidation =  false ;
            SecondComboBox.DataFilter =  null ;
            SecondComboBox.DisabledBackColor =  System.Drawing.Color.Transparent ;
            SecondComboBox.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            SecondComboBox.DisabledForeColor =  System.Drawing.Color.Transparent ;
            SecondComboBox.DrawMode =  System.Windows.Forms.DrawMode.OwnerDrawFixed ;
            SecondComboBox.DropDownStyle =  System.Windows.Forms.ComboBoxStyle.DropDownList ;
            SecondComboBox.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
            SecondComboBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            SecondComboBox.FormattingEnabled =  true ;
            SecondComboBox.HoverText =  null ;
            SecondComboBox.IsDerivedStyle =  true ;
            SecondComboBox.ItemHeight =  24 ;
            SecondComboBox.Location =  new System.Drawing.Point( 3, 3 ) ;
            SecondComboBox.Name =  "SecondComboBox" ;
            SecondComboBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            SecondComboBox.SelectedItemForeColor =  System.Drawing.Color.White ;
            SecondComboBox.Size =  new System.Drawing.Size( 252, 30 ) ;
            SecondComboBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            SecondComboBox.StyleManager =  null ;
            SecondComboBox.TabIndex =  46 ;
            SecondComboBox.ThemeAuthor =  "Terry D. Eppler" ;
            SecondComboBox.ThemeName =  "Budget Execution" ;
            SecondComboBox.ToolTip =  null ;
            // 
            // ChartForm
            // 
            BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionBarHeight =  5 ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionFont =  new System.Drawing.Font( "Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 1338, 739 ) ;
            Controls.Add( SecondTable );
            Controls.Add( FirstTable );
            Controls.Add( ToolStrip );
            Controls.Add( ChartTable );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedSingle ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 1350, 750 ) ;
            MinimizeBox =  false ;
            MinimumSize =  new System.Drawing.Size( 1350, 750 ) ;
            Name =  "ChartForm" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen ;
            ChartTable.ResumeLayout( false );
            ChartPanel.ResumeLayout( false );
            ChartLabelTable.ResumeLayout( false );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            FirstTable.ResumeLayout( false );
            FirstListBoxPanel.ResumeLayout( false );
            SecondTable.ResumeLayout( false );
            SecondListBoxPanel.ResumeLayout( false );
            ResumeLayout( false );
            PerformLayout( );
        }

        public System.Windows.Forms.TableLayoutPanel GridTable;
        public System.Windows.Forms.TableLayoutPanel LabelTable;
        public Label SecondHeaderLabel;
        public Label FourthHeaderLabel;
        public Label FirstHeaderLabel;
        public Label ThirdHeaderLabel;
        public System.Windows.Forms.TableLayoutPanel ChartTable;
        public Layout ChartPanel;
        public System.Windows.Forms.TableLayoutPanel ChartLabelTable;
        public ToolStrip ToolStrip;
        public ToolStripButton TableButton;
        public ToolStripButton ExcelButton;
        public ToolStripButton FirstButton;
        public ToolSeparator ToolStripSeparator;
        public ToolStripTextBox ToolStripTextBox;
        public ToolSeparator TextBoxSeparator;
        public ToolSeparator FirstSeparator;
        public ToolStripButton PreviousButton;
        public ToolSeparator PreviousSeparator;
        public ToolStripButton NextButton;
        public ToolSeparator NextSeparator;
        public ToolStripButton LastButton;
        public ToolSeparator LastSeparator;
        public ToolStripButton FilterButton;
        public ToolSeparator RemoveFiltersSeparator;
        public ToolSeparator RefreshDataSeparator;
        public ToolSeparator GroupSeparator;
        public ToolSeparator ExcelSeparator;
        public ToolSeparator EditSqlSeparator;
        public ToolSeparator TableSeparator;
        public ToolStripDropDown DropDown;
        public ToolSeparator DropDownSeparator;
        public ToolStripButton BackButton;
        public ToolSeparator BackSeparator;
        public ToolStripButton MenuButton;
        public ToolSeparator MenuSeparator;
        public ToolStripButton ExitButton;
        public System.Windows.Forms.BindingSource BindingSource;
        private System.ComponentModel.IContainer components;
        public SmallTip ToolTip;
        public System.Windows.Forms.TableLayoutPanel NumericTable;
        public Layout NumericPanel;
        public Label NumericsLabel;
        public ContextMenu ContextMenu;
        public Chart Chart;

        #endregion Windows Form Designer generated code
        public ToolStripLabel Label1;
        public ToolStripLabel Label2;
        public ToolSeparator LabelSeparator;
        public HeaderPanel FirstTable;
        public ComboBox FirstComboBox;
        public Layout FirstListBoxPanel;
        public ListBox FirstListBox;
        public HeaderPanel SecondTable;
        public Layout SecondListBoxPanel;
        public ListBox SecondListBox;
        public ComboBox SecondComboBox;
    }
}
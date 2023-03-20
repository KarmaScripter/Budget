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
            var dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( ChartForm ) );
            GridTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            DataGridPanel =  new Layout( ) ;
            DataGrid =  new DataGrid( ) ;
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
            LookupButton =  new ToolStripButton( ) ;
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
            ExcelSeparator =  new ToolSeparator( ) ;
            RefreshDataButton =  new ToolStripButton( ) ;
            LastSeparator =  new ToolSeparator( ) ;
            FilterButton =  new ToolStripButton( ) ;
            RefreshDataSeparator =  new ToolSeparator( ) ;
            GroupButton =  new ToolStripButton( ) ;
            RemoveFiltersSeparator =  new ToolSeparator( ) ;
            GroupSeparator =  new ToolSeparator( ) ;
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
            TabControl =  new TabControl( ) ;
            GroupTabPage =  new Syncfusion.Windows.Forms.Tools.TabPageAdv( ) ;
            this.SecondPanel =  new Layout( ) ;
            SecondListBox =  new ListBox( ) ;
            TableTabPage =  new Syncfusion.Windows.Forms.Tools.TabPageAdv( ) ;
            TablePanel =  new Layout( ) ;
            TableListBox =  new ListBox( ) ;
            ContextMenu =  new ContextMenu( ) ;
            FirstTable =  new HeaderPanel( ) ;
            FirstComboBox =  new ComboBox( ) ;
            FirstTablePanel =  new Layout( ) ;
            headerPanel1 =  new HeaderPanel( ) ;
            SecondComboBox =  new ComboBox( ) ;
            listBox1 =  new ListBox( ) ;
            GridTable.SuspendLayout( );
            DataGridPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) DataGrid  ).BeginInit( );
            ChartTable.SuspendLayout( );
            ChartPanel.SuspendLayout( );
            ChartLabelTable.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize) TabControl  ).BeginInit( );
            TabControl.SuspendLayout( );
            GroupTabPage.SuspendLayout( );
            this.SecondPanel.SuspendLayout( );
            TableTabPage.SuspendLayout( );
            TablePanel.SuspendLayout( );
            FirstTable.SuspendLayout( );
            FirstTablePanel.SuspendLayout( );
            headerPanel1.SuspendLayout( );
            SuspendLayout( );
            // 
            // GridTable
            // 
            GridTable.AutoSizeMode =  System.Windows.Forms.AutoSizeMode.GrowAndShrink ;
            GridTable.BackColor =  System.Drawing.Color.Transparent ;
            GridTable.ColumnCount =  1 ;
            GridTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            GridTable.Controls.Add( DataGridPanel, 0, 1 );
            GridTable.Location =  new System.Drawing.Point( 0, 0 ) ;
            GridTable.Name =  "GridTable" ;
            GridTable.RowCount =  2 ;
            GridTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            GridTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            GridTable.Size =  new System.Drawing.Size( 200, 100 ) ;
            GridTable.TabIndex =  0 ;
            // 
            // DataGridPanel
            // 
            DataGridPanel.BackColor =  System.Drawing.Color.Transparent ;
            DataGridPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            DataGridPanel.BindingSource =  null ;
            DataGridPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            DataGridPanel.BorderThickness =  1 ;
            DataGridPanel.Children =  null ;
            DataGridPanel.Controls.Add( DataGrid );
            DataGridPanel.DataFilter =  null ;
            DataGridPanel.Dock =  System.Windows.Forms.DockStyle.Fill ;
            DataGridPanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            DataGridPanel.ForeColor =  System.Drawing.Color.Transparent ;
            DataGridPanel.HoverText =  null ;
            DataGridPanel.IsDerivedStyle =  true ;
            DataGridPanel.Location =  new System.Drawing.Point( 3, 23 ) ;
            DataGridPanel.Name =  "DataGridPanel" ;
            DataGridPanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            DataGridPanel.Size =  new System.Drawing.Size( 194, 74 ) ;
            DataGridPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            DataGridPanel.StyleManager =  null ;
            DataGridPanel.TabIndex =  47 ;
            DataGridPanel.ThemeAuthor =  "Terry D. Eppler" ;
            DataGridPanel.ThemeName =  "Budget Execution" ;
            DataGridPanel.ToolTip =  null ;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToOrderColumns =  true ;
            dataGridViewCellStyle6.BackColor =  System.Drawing.Color.FromArgb(   55  ,   55  ,   55   ) ;
            dataGridViewCellStyle6.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            dataGridViewCellStyle6.ForeColor =  System.Drawing.Color.LightSteelBlue ;
            dataGridViewCellStyle6.SelectionBackColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            dataGridViewCellStyle6.SelectionForeColor =  System.Drawing.Color.White ;
            DataGrid.AlternatingRowsDefaultCellStyle =  dataGridViewCellStyle6 ;
            DataGrid.BackgroundColor =  System.Drawing.Color.FromArgb(   45  ,   45  ,   45   ) ;
            DataGrid.BindingSource =  null ;
            DataGrid.BorderStyle =  System.Windows.Forms.BorderStyle.None ;
            DataGrid.CellBorderStyle =  System.Windows.Forms.DataGridViewCellBorderStyle.None ;
            DataGrid.ColumnHeadersBorderStyle =  System.Windows.Forms.DataGridViewHeaderBorderStyle.Single ;
            dataGridViewCellStyle7.Alignment =  System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter ;
            dataGridViewCellStyle7.BackColor =  System.Drawing.Color.SteelBlue ;
            dataGridViewCellStyle7.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            dataGridViewCellStyle7.ForeColor =  System.Drawing.Color.White ;
            dataGridViewCellStyle7.SelectionBackColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            dataGridViewCellStyle7.SelectionForeColor =  System.Drawing.Color.White ;
            dataGridViewCellStyle7.WrapMode =  System.Windows.Forms.DataGridViewTriState.True ;
            DataGrid.ColumnHeadersDefaultCellStyle =  dataGridViewCellStyle7 ;
            DataGrid.ColumnHeadersHeight =  30 ;
            DataGrid.DataFilter =  null ;
            dataGridViewCellStyle8.Alignment =  System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft ;
            dataGridViewCellStyle8.BackColor =  System.Drawing.Color.FromArgb(   45  ,   45  ,   45   ) ;
            dataGridViewCellStyle8.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            dataGridViewCellStyle8.ForeColor =  System.Drawing.Color.LightSteelBlue ;
            dataGridViewCellStyle8.SelectionBackColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            dataGridViewCellStyle8.SelectionForeColor =  System.Drawing.Color.White ;
            dataGridViewCellStyle8.WrapMode =  System.Windows.Forms.DataGridViewTriState.False ;
            DataGrid.DefaultCellStyle =  dataGridViewCellStyle8 ;
            DataGrid.EnableHeadersVisualStyles =  false ;
            DataGrid.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            DataGrid.GridColor =  System.Drawing.Color.FromArgb(   141  ,   139  ,   138   ) ;
            DataGrid.HoverText =  null ;
            DataGrid.Location =  new System.Drawing.Point( 38, 39 ) ;
            DataGrid.MultiSelect =  false ;
            DataGrid.Name =  "DataGrid" ;
            DataGrid.RowHeadersBorderStyle =  System.Windows.Forms.DataGridViewHeaderBorderStyle.Single ;
            dataGridViewCellStyle9.Alignment =  System.Windows.Forms.DataGridViewContentAlignment.BottomCenter ;
            dataGridViewCellStyle9.BackColor =  System.Drawing.Color.FromArgb(   55  ,   55  ,   55   ) ;
            dataGridViewCellStyle9.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            dataGridViewCellStyle9.ForeColor =  System.Drawing.Color.Black ;
            dataGridViewCellStyle9.SelectionBackColor =  System.Drawing.Color.SteelBlue ;
            dataGridViewCellStyle9.SelectionForeColor =  System.Drawing.SystemColors.HighlightText ;
            dataGridViewCellStyle9.WrapMode =  System.Windows.Forms.DataGridViewTriState.True ;
            DataGrid.RowHeadersDefaultCellStyle =  dataGridViewCellStyle9 ;
            DataGrid.RowHeadersWidth =  20 ;
            dataGridViewCellStyle10.Alignment =  System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter ;
            dataGridViewCellStyle10.BackColor =  System.Drawing.Color.FromArgb(   45  ,   45  ,   45   ) ;
            dataGridViewCellStyle10.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            dataGridViewCellStyle10.ForeColor =  System.Drawing.Color.LightSteelBlue ;
            dataGridViewCellStyle10.SelectionBackColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            dataGridViewCellStyle10.SelectionForeColor =  System.Drawing.Color.White ;
            DataGrid.RowsDefaultCellStyle =  dataGridViewCellStyle10 ;
            DataGrid.RowTemplate.Height =  28 ;
            DataGrid.SelectionMode =  System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect ;
            DataGrid.Size =  new System.Drawing.Size( 895, 482 ) ;
            DataGrid.TabIndex =  0 ;
            DataGrid.ToolTip =  null ;
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
            ToolStrip.EditButton =  LookupButton ;
            ToolStrip.EditColumnButton =  null ;
            ToolStrip.EditRecordButton =  null ;
            ToolStrip.EditSqlButton =  LookupButton ;
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
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Label1, ToolStripSeparator, ToolStripTextBox, TextBoxSeparator, FirstButton, FirstSeparator, PreviousButton, PreviousSeparator, NextButton, NextSeparator, LastButton, ExcelSeparator, RefreshDataButton, LastSeparator, FilterButton, RefreshDataSeparator, GroupButton, RemoveFiltersSeparator, ExcelButton, GroupSeparator, LookupButton, EditSqlSeparator, TableButton, TableSeparator, DropDown, DropDownSeparator, Label2, LabelSeparator, BackButton, BackSeparator, MenuButton, MenuSeparator, ExitButton } );
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
            ToolStrip.RefreshButton =  RefreshDataButton ;
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
            // LookupButton
            // 
            LookupButton.AutoToolTip =  false ;
            LookupButton.BackColor =  System.Drawing.Color.Transparent ;
            LookupButton.BindingSource =  BindingSource ;
            LookupButton.DataFilter =  null ;
            LookupButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            LookupButton.Field =  Field.AccountCode ;
            LookupButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            LookupButton.ForeColor =  System.Drawing.Color.LightGray ;
            LookupButton.HoverText =  "Lookup Query" ;
            LookupButton.Image =  Properties.Resources.LookupButton ;
            LookupButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            LookupButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            LookupButton.Name =  "LookupButton" ;
            LookupButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            LookupButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            LookupButton.Text =  "toolStripButton2" ;
            LookupButton.ToolTip =  null ;
            LookupButton.ToolType =  ToolType.LookupButton ;
            // 
            // ExcelButton
            // 
            ExcelButton.AutoToolTip =  false ;
            ExcelButton.BackColor =  System.Drawing.Color.Transparent ;
            ExcelButton.BindingSource =  null ;
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
            ToolStripTextBox.Size =  new System.Drawing.Size( 172, 28 ) ;
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
            // ExcelSeparator
            // 
            ExcelSeparator.ForeColor =  System.Drawing.Color.Black ;
            ExcelSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            ExcelSeparator.Name =  "ExcelSeparator" ;
            ExcelSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            ExcelSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // RefreshDataButton
            // 
            RefreshDataButton.AutoToolTip =  false ;
            RefreshDataButton.BackColor =  System.Drawing.Color.Transparent ;
            RefreshDataButton.BindingSource =  null ;
            RefreshDataButton.DataFilter =  null ;
            RefreshDataButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            RefreshDataButton.Field =  Field.AccountCode ;
            RefreshDataButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            RefreshDataButton.ForeColor =  System.Drawing.Color.LightGray ;
            RefreshDataButton.HoverText =  "Reset Data Source" ;
            RefreshDataButton.Image =  Properties.Resources.RefreshDataButton ;
            RefreshDataButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            RefreshDataButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            RefreshDataButton.Name =  "RefreshDataButton" ;
            RefreshDataButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            RefreshDataButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            RefreshDataButton.Text =  "toolStripButton2" ;
            RefreshDataButton.ToolTip =  null ;
            RefreshDataButton.ToolType =  ToolType.RefreshDataButton ;
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
            // RefreshDataSeparator
            // 
            RefreshDataSeparator.ForeColor =  System.Drawing.Color.Black ;
            RefreshDataSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            RefreshDataSeparator.Name =  "RefreshDataSeparator" ;
            RefreshDataSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            RefreshDataSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // GroupButton
            // 
            GroupButton.AutoToolTip =  false ;
            GroupButton.BackColor =  System.Drawing.Color.Transparent ;
            GroupButton.BindingSource =  null ;
            GroupButton.DataFilter =  null ;
            GroupButton.DisplayStyle =  System.Windows.Forms.ToolStripItemDisplayStyle.Image ;
            GroupButton.Field =  Field.AccountCode ;
            GroupButton.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            GroupButton.ForeColor =  System.Drawing.Color.LightGray ;
            GroupButton.HoverText =  "Aggregate Columns" ;
            GroupButton.Image =  Properties.Resources.GroupButton ;
            GroupButton.ImageTransparentColor =  System.Drawing.Color.Magenta ;
            GroupButton.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            GroupButton.Name =  "GroupButton" ;
            GroupButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            GroupButton.Size =  new System.Drawing.Size( 23, 28 ) ;
            GroupButton.Text =  "toolStripButton2" ;
            GroupButton.ToolTip =  null ;
            GroupButton.ToolType =  ToolType.GroupButton ;
            // 
            // RemoveFiltersSeparator
            // 
            RemoveFiltersSeparator.ForeColor =  System.Drawing.Color.Black ;
            RemoveFiltersSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            RemoveFiltersSeparator.Name =  "RemoveFiltersSeparator" ;
            RemoveFiltersSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            RemoveFiltersSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
            // 
            // GroupSeparator
            // 
            GroupSeparator.ForeColor =  System.Drawing.Color.Black ;
            GroupSeparator.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            GroupSeparator.Name =  "GroupSeparator" ;
            GroupSeparator.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            GroupSeparator.Size =  new System.Drawing.Size( 6, 28 ) ;
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
            // TabControl
            // 
            TabControl.ActiveTabColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.ActiveTabFont =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            TabControl.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.BeforeTouchSize =  new System.Drawing.Size( 316, 598 ) ;
            TabControl.BindingSource =  null ;
            TabControl.BorderStyle =  System.Windows.Forms.BorderStyle.None ;
            TabControl.BorderWidth =  1 ;
            TabControl.CanOverrideStyle =  true ;
            TabControl.CloseButtonBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.Controls.Add( GroupTabPage );
            TabControl.Controls.Add( TableTabPage );
            TabControl.FixedSingleBorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.FocusOnTabClick =  false ;
            TabControl.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            TabControl.ForeColor =  System.Drawing.Color.LightGray ;
            TabControl.InactiveCloseButtonForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.InactiveTabColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.ItemSize =  new System.Drawing.Size( 100, 10 ) ;
            TabControl.Location =  new System.Drawing.Point( 1022, 76 ) ;
            TabControl.Name =  "TabControl" ;
            TabControl.Size =  new System.Drawing.Size( 316, 598 ) ;
            TabControl.TabIndex =  45 ;
            TabControl.TabPanelBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.TabStyle =  typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro ) ;
            TabControl.ThemeName =  "TabRendererMetro" ;
            TabControl.ThemeStyle.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.ThemeStyle.BorderColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.ThemeStyle.BorderFillColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage =  null ;
            TabControl.ThemeStyle.TabPanelBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.ThemeStyle.TabStyle.ActiveBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.ThemeStyle.TabStyle.ActiveFont =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            TabControl.ThemeStyle.TabStyle.ActiveForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            TabControl.ThemeStyle.TabStyle.SeparatorColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TabControl.ToolTip =  ToolTip ;
            // 
            // GroupTabPage
            // 
            GroupTabPage.Controls.Add( headerPanel1 );
            GroupTabPage.Controls.Add( FirstTable );
            GroupTabPage.Image =  null ;
            GroupTabPage.ImageSize =  new System.Drawing.Size( 16, 16 ) ;
            GroupTabPage.Location =  new System.Drawing.Point( 0, 9 ) ;
            GroupTabPage.Name =  "GroupTabPage" ;
            GroupTabPage.ShowCloseButton =  true ;
            GroupTabPage.Size =  new System.Drawing.Size( 316, 589 ) ;
            GroupTabPage.TabBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            GroupTabPage.TabFont =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            GroupTabPage.TabForeColor =  System.Drawing.Color.DarkGray ;
            GroupTabPage.TabIndex =  2 ;
            GroupTabPage.ThemesEnabled =  false ;
            // 
            // SecondPanel
            // 
            this.SecondPanel.BackColor =  System.Drawing.Color.Transparent ;
            this.SecondPanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            this.SecondPanel.BindingSource =  null ;
            this.SecondPanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            this.SecondPanel.BorderThickness =  1 ;
            this.SecondPanel.Children =  null ;
            this.SecondPanel.Controls.Add( SecondListBox );
            this.SecondPanel.DataFilter =  null ;
            this.SecondPanel.Dock =  System.Windows.Forms.DockStyle.Fill ;
            this.SecondPanel.Font =  new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            this.SecondPanel.ForeColor =  System.Drawing.Color.Transparent ;
            this.SecondPanel.HoverText =  null ;
            this.SecondPanel.IsDerivedStyle =  true ;
            this.SecondPanel.Location =  new System.Drawing.Point( 3, 40 ) ;
            this.SecondPanel.Name =  "SecondPanel" ;
            this.SecondPanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            this.SecondPanel.Size =  new System.Drawing.Size( 252, 233 ) ;
            this.SecondPanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            this.SecondPanel.StyleManager =  null ;
            this.SecondPanel.TabIndex =  6 ;
            this.SecondPanel.ThemeAuthor =  "Terry D. Eppler" ;
            this.SecondPanel.ThemeName =  "BudgetExecution" ;
            this.SecondPanel.ToolTip =  null ;
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
            SecondListBox.HoveredItemBackColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            SecondListBox.HoveredItemColor =  System.Drawing.Color.White ;
            SecondListBox.HoverText =  null ;
            SecondListBox.IsDerivedStyle =  true ;
            SecondListBox.ItemHeight =  28 ;
            SecondListBox.Location =  new System.Drawing.Point( 27, 35 ) ;
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
            SecondListBox.Size =  new System.Drawing.Size( 201, 176 ) ;
            SecondListBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            SecondListBox.StyleManager =  null ;
            SecondListBox.TabIndex =  1 ;
            SecondListBox.ThemeAuthor =  "Terry D. Eppler" ;
            SecondListBox.ThemeName =  "Budget Execution" ;
            SecondListBox.ToolTip =  null ;
            // 
            // TableTabPage
            // 
            TableTabPage.Controls.Add( TablePanel );
            TableTabPage.Image =  null ;
            TableTabPage.ImageSize =  new System.Drawing.Size( 16, 16 ) ;
            TableTabPage.Location =  new System.Drawing.Point( 0, 9 ) ;
            TableTabPage.Name =  "TableTabPage" ;
            TableTabPage.ShowCloseButton =  true ;
            TableTabPage.Size =  new System.Drawing.Size( 316, 589 ) ;
            TableTabPage.TabIndex =  5 ;
            TableTabPage.ThemesEnabled =  false ;
            // 
            // TablePanel
            // 
            TablePanel.BackColor =  System.Drawing.Color.Transparent ;
            TablePanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TablePanel.BindingSource =  null ;
            TablePanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            TablePanel.BorderThickness =  1 ;
            TablePanel.Children =  null ;
            TablePanel.Controls.Add( TableListBox );
            TablePanel.DataFilter =  null ;
            TablePanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            TablePanel.ForeColor =  System.Drawing.Color.Transparent ;
            TablePanel.HoverText =  null ;
            TablePanel.IsDerivedStyle =  true ;
            TablePanel.Location =  new System.Drawing.Point( 12, 26 ) ;
            TablePanel.Name =  "TablePanel" ;
            TablePanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            TablePanel.Size =  new System.Drawing.Size( 278, 555 ) ;
            TablePanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            TablePanel.StyleManager =  null ;
            TablePanel.TabIndex =  0 ;
            TablePanel.ThemeAuthor =  "Terry D. Eppler" ;
            TablePanel.ThemeName =  "Budget Execution" ;
            TablePanel.ToolTip =  null ;
            // 
            // TableListBox
            // 
            TableListBox.BackColor =  System.Drawing.Color.FromArgb(   40  ,   40  ,   40   ) ;
            TableListBox.BindingSource =  null ;
            TableListBox.BorderColor =  System.Drawing.Color.FromArgb(   55  ,   55  ,   55   ) ;
            TableListBox.DataFilter =  null ;
            TableListBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TableListBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            TableListBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            TableListBox.HoveredItemBackColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            TableListBox.HoveredItemColor =  System.Drawing.Color.White ;
            TableListBox.HoverText =  null ;
            TableListBox.IsDerivedStyle =  true ;
            TableListBox.ItemHeight =  28 ;
            TableListBox.Location =  new System.Drawing.Point( 37, 38 ) ;
            TableListBox.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            TableListBox.MultiSelect =  false ;
            TableListBox.Name =  "TableListBox" ;
            TableListBox.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            TableListBox.SelectedIndex =  -1 ;
            TableListBox.SelectedItem =  null ;
            TableListBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            TableListBox.SelectedItemColor =  System.Drawing.Color.White ;
            TableListBox.SelectedText =  null ;
            TableListBox.SelectedValue =  null ;
            TableListBox.ShowBorder =  false ;
            TableListBox.ShowScrollBar =  false ;
            TableListBox.Size =  new System.Drawing.Size( 203, 487 ) ;
            TableListBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            TableListBox.StyleManager =  null ;
            TableListBox.TabIndex =  0 ;
            TableListBox.ThemeAuthor =  "Terry D. Eppler" ;
            TableListBox.ThemeName =  "Budget Execution" ;
            TableListBox.ToolTip =  null ;
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
            FirstTable.Controls.Add( FirstTablePanel, 0, 1 );
            FirstTable.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstTable.ForeColor =  System.Drawing.Color.DarkGray ;
            FirstTable.Location =  new System.Drawing.Point( 24, 26 ) ;
            FirstTable.Name =  "FirstTable" ;
            FirstTable.RowCount =  2 ;
            FirstTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 16.216217F ) );
            FirstTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 83.78378F ) );
            FirstTable.Size =  new System.Drawing.Size( 264, 249 ) ;
            FirstTable.TabIndex =  10 ;
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
            FirstComboBox.Dock =  System.Windows.Forms.DockStyle.Fill ;
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
            FirstComboBox.Size =  new System.Drawing.Size( 258, 30 ) ;
            FirstComboBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            FirstComboBox.StyleManager =  null ;
            FirstComboBox.TabIndex =  0 ;
            FirstComboBox.ThemeAuthor =  "Terry D. Eppler" ;
            FirstComboBox.ThemeName =  "Budget Execution" ;
            FirstComboBox.ToolTip =  null ;
            // 
            // FirstTablePanel
            // 
            FirstTablePanel.BackColor =  System.Drawing.Color.Transparent ;
            FirstTablePanel.BackgroundColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            FirstTablePanel.BindingSource =  null ;
            FirstTablePanel.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            FirstTablePanel.BorderThickness =  1 ;
            FirstTablePanel.Children =  null ;
            FirstTablePanel.Controls.Add( listBox1 );
            FirstTablePanel.DataFilter =  null ;
            FirstTablePanel.Dock =  System.Windows.Forms.DockStyle.Fill ;
            FirstTablePanel.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            FirstTablePanel.ForeColor =  System.Drawing.Color.Transparent ;
            FirstTablePanel.HoverText =  null ;
            FirstTablePanel.IsDerivedStyle =  true ;
            FirstTablePanel.Location =  new System.Drawing.Point( 3, 43 ) ;
            FirstTablePanel.Name =  "FirstTablePanel" ;
            FirstTablePanel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            FirstTablePanel.Size =  new System.Drawing.Size( 258, 203 ) ;
            FirstTablePanel.Style =  MetroSet_UI.Enums.Style.Custom ;
            FirstTablePanel.StyleManager =  null ;
            FirstTablePanel.TabIndex =  1 ;
            FirstTablePanel.ThemeAuthor =  "Terry D. Eppler" ;
            FirstTablePanel.ThemeName =  "Budget Execution" ;
            FirstTablePanel.ToolTip =  null ;
            // 
            // headerPanel1
            // 
            headerPanel1.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            headerPanel1.CaptionStyle =  CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle ;
            headerPanel1.ColumnCount =  1 ;
            headerPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            headerPanel1.Controls.Add( this.SecondPanel, 0, 1 );
            headerPanel1.Controls.Add( SecondComboBox, 0, 0 );
            headerPanel1.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            headerPanel1.ForeColor =  System.Drawing.Color.DarkGray ;
            headerPanel1.Location =  new System.Drawing.Point( 27, 310 ) ;
            headerPanel1.Name =  "headerPanel1" ;
            headerPanel1.RowCount =  2 ;
            headerPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 13.405797F ) );
            headerPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 86.5942F ) );
            headerPanel1.Size =  new System.Drawing.Size( 258, 276 ) ;
            headerPanel1.TabIndex =  11 ;
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
            SecondComboBox.Dock =  System.Windows.Forms.DockStyle.Fill ;
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
            SecondComboBox.TabIndex =  7 ;
            SecondComboBox.ThemeAuthor =  "Terry D. Eppler" ;
            SecondComboBox.ThemeName =  "Budget Execution" ;
            SecondComboBox.ToolTip =  null ;
            // 
            // listBox1
            // 
            listBox1.BackColor =  System.Drawing.Color.FromArgb(   40  ,   40  ,   40   ) ;
            listBox1.BindingSource =  null ;
            listBox1.BorderColor =  System.Drawing.Color.FromArgb(   55  ,   55  ,   55   ) ;
            listBox1.DataFilter =  null ;
            listBox1.DisabledBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            listBox1.DisabledForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            listBox1.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            listBox1.HoveredItemBackColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            listBox1.HoveredItemColor =  System.Drawing.Color.White ;
            listBox1.HoverText =  null ;
            listBox1.IsDerivedStyle =  true ;
            listBox1.ItemHeight =  28 ;
            listBox1.Location =  new System.Drawing.Point( 30, 22 ) ;
            listBox1.Margin =  new System.Windows.Forms.Padding( 1 ) ;
            listBox1.MultiSelect =  true ;
            listBox1.Name =  "listBox1" ;
            listBox1.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            listBox1.SelectedIndex =  -1 ;
            listBox1.SelectedItem =  null ;
            listBox1.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            listBox1.SelectedItemColor =  System.Drawing.Color.White ;
            listBox1.SelectedText =  null ;
            listBox1.SelectedValue =  null ;
            listBox1.ShowBorder =  false ;
            listBox1.ShowScrollBar =  false ;
            listBox1.Size =  new System.Drawing.Size( 201, 156 ) ;
            listBox1.Style =  MetroSet_UI.Enums.Style.Custom ;
            listBox1.StyleManager =  null ;
            listBox1.TabIndex =  0 ;
            listBox1.ThemeAuthor =  "Terry D. Eppler" ;
            listBox1.ThemeName =  "Budget Execution" ;
            listBox1.ToolTip =  null ;
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
            Controls.Add( TabControl );
            Controls.Add( ToolStrip );
            Controls.Add( ChartTable );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedSingle ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 1350, 750 ) ;
            MinimizeBox =  false ;
            MinimumSize =  new System.Drawing.Size( 1350, 750 ) ;
            Name =  "ChartForm" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen ;
            GridTable.ResumeLayout( false );
            DataGridPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) DataGrid  ).EndInit( );
            ChartTable.ResumeLayout( false );
            ChartPanel.ResumeLayout( false );
            ChartLabelTable.ResumeLayout( false );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize) TabControl  ).EndInit( );
            TabControl.ResumeLayout( false );
            GroupTabPage.ResumeLayout( false );
            this.SecondPanel.ResumeLayout( false );
            TableTabPage.ResumeLayout( false );
            TablePanel.ResumeLayout( false );
            FirstTable.ResumeLayout( false );
            FirstTablePanel.ResumeLayout( false );
            headerPanel1.ResumeLayout( false );
            ResumeLayout( false );
            PerformLayout( );
        }

        public System.Windows.Forms.TableLayoutPanel GridTable;
        public Layout DataGridPanel;
        public DataGrid DataGrid;
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
        public ToolStripButton LookupButton;
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
        public ToolStripButton RefreshDataButton;
        public ToolSeparator RefreshDataSeparator;
        public ToolStripButton GroupButton;
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
        public TabControl TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv TableTabPage;
        public Layout TablePanel;
        public ListBox TableListBox;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv GroupTabPage;
        public System.Windows.Forms.TableLayoutPanel NumericTable;
        public Layout NumericPanel;
        public ListBox SecondListBox;
        public Label NumericsLabel;
        public ContextMenu ContextMenu;
        public Chart Chart;

        #endregion Windows Form Designer generated code
        public ToolStripLabel Label1;
        public ToolStripLabel Label2;
        public ToolSeparator LabelSeparator;
        private HeaderPanel headerPanel1;
        private ComboBox SecondComboBox;
        public HeaderPanel FirstTable;
        private ComboBox FirstComboBox;
        private Layout FirstTablePanel;
        public ListBox listBox1;
    }
}
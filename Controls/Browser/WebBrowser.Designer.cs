﻿
namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Data;
    using System.Data.Common;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public partial class WebBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent( )
        {
            components = new System.ComponentModel.Container( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( WebBrowser ) );
            MenuStripTab = new ContextMenuStrip( components );
            MenuCloseTab = new ToolStripMenuItem( );
            MenuCloseOtherTabs = new ToolStripMenuItem( );
            RefreshButton = new Button( );
            StopButton = new Button( );
            NextButton = new Button( );
            PreviousButton = new Button( );
            Timer = new System.Windows.Forms.Timer( components );
            DownloadButton = new Button( );
            TabPages = new BrowserTabStrip( );
            TabItem = new BrowserTabStripItem( );
            AddItem = new BrowserTabStripItem( );
            ToolTip = new SmallTip( );
            MainTextBoxPanel = new Panel( );
            AddressTextBox = new TextBox( );
            HomeButton = new Button( );
            QuickSearchPanel = new Panel( );
            QuickSearchTextBox = new TextBox( );
            SearchNextButton = new Button( );
            SearchPreviousButton = new Button( );
            StopSearchButton = new Button( );
            ToolBarTable = new TableLayoutPanel( );
            ToolStrip = new ToolStrip( );
            Separator1 = new ToolSeparator( );
            WebsiteLabel = new ToolStripLabel( );
            WebsiteComboBox = new ToolStripComboBox( );
            Separator3 = new ToolSeparator( );
            EngineLabel = new ToolStripLabel( );
            Separator4 = new ToolSeparator( );
            SearchEngineComboBox = new ToolStripComboBox( );
            Separator5 = new ToolSeparator( );
            NavigationLabel = new ToolStripLabel( );
            Separator6 = new ToolSeparator( );
            WebPreviousButton = new ToolStripButton( );
            Separator7 = new ToolSeparator( );
            WebNextButton = new ToolStripButton( );
            Separator8 = new ToolSeparator( );
            KeyWordTextBox = new ToolStripTextBox( );
            Separator9 = new ToolSeparator( );
            SearchLabel = new ToolStripLabel( );
            Separator10 = new ToolSeparator( );
            WebRefreshButton = new ToolStripButton( );
            Separator11 = new ToolSeparator( );
            WebCancelButton = new ToolStripButton( );
            Separator12 = new ToolSeparator( );
            WebDownloadButton = new ToolStripButton( );
            Separator13 = new ToolSeparator( );
            WebHomeButton = new ToolStripButton( );
            Separator14 = new ToolSeparator( );
            WebMenuButton = new ToolStripButton( );
            Separator15 = new ToolSeparator( );
            WebCloseButton = new ToolStripButton( );
            Separator16 = new ToolSeparator( );
            HeaderTable = new TableLayoutPanel( );
            Picture = new Picture( );
            Title = new Label( );
            BrowserTable = new TableLayoutPanel( );
            MenuStripTab.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) TabPages  ).BeginInit( );
            TabPages.SuspendLayout( );
            MainTextBoxPanel.SuspendLayout( );
            QuickSearchPanel.SuspendLayout( );
            ToolBarTable.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) Picture  ).BeginInit( );
            BrowserTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // MenuStripTab
            // 
            MenuStripTab.BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            MenuStripTab.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            MenuStripTab.ImageScalingSize = new Size( 20, 20 );
            MenuStripTab.Items.AddRange( new ToolStripItem[ ] { MenuCloseTab, MenuCloseOtherTabs } );
            MenuStripTab.Name = "menuStripTab";
            MenuStripTab.ShowImageMargin = false;
            MenuStripTab.Size = new Size( 150, 48 );
            // 
            // MenuCloseTab
            // 
            MenuCloseTab.BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            MenuCloseTab.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            MenuCloseTab.ForeColor = Color.LightGray;
            MenuCloseTab.Name = "MenuCloseTab";
            MenuCloseTab.ShortcutKeys =   Keys.Control  |  Keys.F4  ;
            MenuCloseTab.Size = new Size( 149, 22 );
            MenuCloseTab.Text = "Close Tab";
            MenuCloseTab.Click += OnCloseMenuClicked;
            // 
            // MenuCloseOtherTabs
            // 
            MenuCloseOtherTabs.BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            MenuCloseOtherTabs.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            MenuCloseOtherTabs.ForeColor = Color.LightGray;
            MenuCloseOtherTabs.Name = "MenuCloseOtherTabs";
            MenuCloseOtherTabs.Size = new Size( 149, 22 );
            MenuCloseOtherTabs.Text = "Close other tabs";
            MenuCloseOtherTabs.Click += OnCloseOtherTabsButtonClicked;
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor =   AnchorStyles.Top  |  AnchorStyles.Right  ;
            RefreshButton.BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.ForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            RefreshButton.Image = (Image) resources.GetObject( "RefreshButton.Image" ) ;
            RefreshButton.Location = new Point( 1232, 3 );
            RefreshButton.Margin = new Padding( 3, 4, 3, 4 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size( 25, 25 );
            RefreshButton.TabIndex = 3;
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += OnRefreshButtonClicked;
            // 
            // StopButton
            // 
            StopButton.Anchor =   AnchorStyles.Top  |  AnchorStyles.Right  ;
            StopButton.FlatStyle = FlatStyle.Flat;
            StopButton.ForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            StopButton.Image = (Image) resources.GetObject( "StopButton.Image" ) ;
            StopButton.Location = new Point( 1263, 4 );
            StopButton.Margin = new Padding( 3, 4, 3, 4 );
            StopButton.Name = "StopButton";
            StopButton.Size = new Size( 25, 25 );
            StopButton.TabIndex = 2;
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += OnStopButtonClicked;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.ForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            NextButton.Image = (Image) resources.GetObject( "NextButton.Image" ) ;
            NextButton.Location = new Point( 29, 1 );
            NextButton.Margin = new Padding( 3, 4, 3, 4 );
            NextButton.Name = "NextButton";
            NextButton.Size = new Size( 21, 25 );
            NextButton.TabIndex = 1;
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += OnNextButtonClicked;
            // 
            // PreviousButton
            // 
            PreviousButton.BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            PreviousButton.FlatStyle = FlatStyle.Flat;
            PreviousButton.ForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            PreviousButton.Image = (Image) resources.GetObject( "PreviousButton.Image" ) ;
            PreviousButton.Location = new Point( 2, 1 );
            PreviousButton.Margin = new Padding( 3, 4, 3, 4 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size( 21, 25 );
            PreviousButton.TabIndex = 0;
            PreviousButton.UseVisualStyleBackColor = false;
            PreviousButton.Click += OnPreviousButtonClicked;
            // 
            // Timer
            // 
            Timer.Interval = 50;
            Timer.Tick += OnTimerTick;
            // 
            // DownloadButton
            // 
            DownloadButton.Anchor =   AnchorStyles.Top  |  AnchorStyles.Right  ;
            DownloadButton.BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            DownloadButton.FlatStyle = FlatStyle.Flat;
            DownloadButton.ForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            DownloadButton.Image = (Image) resources.GetObject( "DownloadButton.Image" ) ;
            DownloadButton.Location = new Point( 1294, 4 );
            DownloadButton.Margin = new Padding( 3, 4, 3, 4 );
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size( 25, 25 );
            DownloadButton.TabIndex = 4;
            DownloadButton.Tag = "Downloads";
            DownloadButton.UseVisualStyleBackColor = false;
            DownloadButton.Click += OnDownloadButtonClicked;
            // 
            // TabPages
            // 
            TabPages.BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            TabPages.ContextMenuStrip = MenuStripTab;
            TabPages.Dock = DockStyle.Fill;
            TabPages.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            TabPages.ForeColor = Color.LightSteelBlue;
            TabPages.Items.AddRange( new BrowserTabStripItem[ ] { TabItem, AddItem } );
            TabPages.Location = new Point( 3, 81 );
            TabPages.Name = "TabPages";
            TabPages.Padding = new Padding( 1, 29, 1, 1 );
            TabPages.SelectedItem = TabItem;
            TabPages.Size = new Size( 1332, 613 );
            TabPages.TabIndex = 12;
            TabPages.Text = "browserTabStrip1";
            TabPages.TabStripItemSelectionChanged += OnTabItemChanged;
            TabPages.TabStripItemClosed += OnTabClosed;
            TabPages.MouseClick += OnTabPagesMouseClicked;
            // 
            // TabItem
            // 
            TabItem.Dock = DockStyle.Fill;
            TabItem.IsDrawn = true;
            TabItem.IsSelected = true;
            TabItem.Location = new Point( 1, 29 );
            TabItem.Name = "TabItem";
            TabItem.Size = new Size( 1330, 583 );
            TabItem.TabIndex = 0;
            TabItem.Title = "Loading...";
            // 
            // AddItem
            // 
            AddItem.CanClose = false;
            AddItem.Dock = DockStyle.Fill;
            AddItem.IsDrawn = true;
            AddItem.Location = new Point( 0, 0 );
            AddItem.Name = "AddItem";
            AddItem.Size = new Size( 200, 100 );
            AddItem.TabIndex = 1;
            AddItem.Title = "+";
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = Color.FromArgb(   5  ,   5  ,   5   );
            ToolTip.BorderColor = SystemColors.Highlight;
            ToolTip.ForeColor = Color.White;
            ToolTip.InitialDelay = 500;
            ToolTip.IsDerivedStyle = true;
            ToolTip.Name = null;
            ToolTip.OwnerDraw = true;
            ToolTip.ReshowDelay = 100;
            ToolTip.Style = MetroSet_UI.Enums.Style.Custom;
            ToolTip.StyleManager = null;
            ToolTip.ThemeAuthor = "Terry D. Eppler";
            ToolTip.ThemeName = "Budget Execution";
            ToolTip.TipIcon = ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // MainTextBoxPanel
            // 
            MainTextBoxPanel.BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            MainTextBoxPanel.Controls.Add( AddressTextBox );
            MainTextBoxPanel.Controls.Add( HomeButton );
            MainTextBoxPanel.Controls.Add( DownloadButton );
            MainTextBoxPanel.Controls.Add( NextButton );
            MainTextBoxPanel.Controls.Add( PreviousButton );
            MainTextBoxPanel.Controls.Add( RefreshButton );
            MainTextBoxPanel.Controls.Add( StopButton );
            MainTextBoxPanel.Dock = DockStyle.Fill;
            MainTextBoxPanel.Location = new Point( 3, 39 );
            MainTextBoxPanel.Margin = new Padding( 3, 4, 3, 4 );
            MainTextBoxPanel.Name = "MainTextBoxPanel";
            MainTextBoxPanel.Size = new Size( 1332, 35 );
            MainTextBoxPanel.TabIndex = 6;
            // 
            // AddressTextBox
            // 
            AddressTextBox.AutoCompleteCustomSource = null;
            AddressTextBox.AutoCompleteMode = AutoCompleteMode.None;
            AddressTextBox.AutoCompleteSource = AutoCompleteSource.None;
            AddressTextBox.BorderColor = Color.FromArgb(   0  ,   120  ,   212   );
            AddressTextBox.DisabledBackColor = Color.FromArgb(   20  ,   20  ,   20   );
            AddressTextBox.DisabledBorderColor = Color.FromArgb(   20  ,   20  ,   20   );
            AddressTextBox.DisabledForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            AddressTextBox.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            AddressTextBox.HoverColor = Color.FromArgb(   0  ,   120  ,   212   );
            AddressTextBox.HoverText = "Current URL";
            AddressTextBox.Image = null;
            AddressTextBox.IsDerivedStyle = true;
            AddressTextBox.Lines = null;
            AddressTextBox.Location = new Point( 52, 3 );
            AddressTextBox.Margin = new Padding( 10, 3, 3, 3 );
            AddressTextBox.MaxLength = 32767;
            AddressTextBox.Multiline = false;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Padding = new Padding( 10, 0, 0, 0 );
            AddressTextBox.ReadOnly = false;
            AddressTextBox.SelectionLength = 0;
            AddressTextBox.Size = new Size( 1145, 26 );
            AddressTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            AddressTextBox.StyleManager = null;
            AddressTextBox.TabIndex = 7;
            AddressTextBox.Text = "webTextBox1";
            AddressTextBox.TextAlign = HorizontalAlignment.Left;
            AddressTextBox.ThemeAuthor = "Terry D. Eppler";
            AddressTextBox.ThemeName = "Budget Execution";
            AddressTextBox.ToolTip = ToolTip;
            AddressTextBox.UseSystemPasswordChar = false;
            AddressTextBox.WatermarkText = "";
            AddressTextBox.TextChanged += OnUrlChanged;
            AddressTextBox.Click += OnUrlTextBoxClicked;
            AddressTextBox.KeyDown += OnKeyDown;
            // 
            // HomeButton
            // 
            HomeButton.Anchor =   AnchorStyles.Top  |  AnchorStyles.Right  ;
            HomeButton.BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.ForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            HomeButton.Image = (Image) resources.GetObject( "HomeButton.Image" ) ;
            HomeButton.Location = new Point( 1201, 3 );
            HomeButton.Margin = new Padding( 3, 4, 3, 4 );
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size( 25, 25 );
            HomeButton.TabIndex = 6;
            HomeButton.Tag = "Home";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += OnHomeButtonClicked;
            // 
            // QuickSearchPanel
            // 
            QuickSearchPanel.Anchor =   AnchorStyles.Top  |  AnchorStyles.Right  ;
            QuickSearchPanel.BackColor = Color.FromArgb(   40  ,   40  ,   40   );
            QuickSearchPanel.BorderStyle = BorderStyle.FixedSingle;
            QuickSearchPanel.Controls.Add( QuickSearchTextBox );
            QuickSearchPanel.Controls.Add( SearchNextButton );
            QuickSearchPanel.Controls.Add( SearchPreviousButton );
            QuickSearchPanel.Controls.Add( StopSearchButton );
            QuickSearchPanel.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            QuickSearchPanel.ForeColor = Color.LightGray;
            QuickSearchPanel.Location = new Point( 857, 130 );
            QuickSearchPanel.Name = "QuickSearchPanel";
            QuickSearchPanel.Size = new Size( 466, 46 );
            QuickSearchPanel.TabIndex = 9;
            // 
            // QuickSearchTextBox
            // 
            QuickSearchTextBox.AutoCompleteCustomSource = null;
            QuickSearchTextBox.AutoCompleteMode = AutoCompleteMode.None;
            QuickSearchTextBox.AutoCompleteSource = AutoCompleteSource.None;
            QuickSearchTextBox.BorderColor = Color.FromArgb(   0  ,   120  ,   212   );
            QuickSearchTextBox.DisabledBackColor = Color.FromArgb(   20  ,   20  ,   20   );
            QuickSearchTextBox.DisabledBorderColor = Color.FromArgb(   20  ,   20  ,   20   );
            QuickSearchTextBox.DisabledForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            QuickSearchTextBox.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            QuickSearchTextBox.HoverColor = Color.FromArgb(   0  ,   120  ,   212   );
            QuickSearchTextBox.HoverText = "Search Text";
            QuickSearchTextBox.Image = null;
            QuickSearchTextBox.IsDerivedStyle = false;
            QuickSearchTextBox.Lines = null;
            QuickSearchTextBox.Location = new Point( 857, 130 );
            QuickSearchTextBox.MaxLength = 32767;
            QuickSearchTextBox.Multiline = false;
            QuickSearchTextBox.Name = "QuickSearchTextBox";
            QuickSearchTextBox.ReadOnly = false;
            QuickSearchTextBox.SelectionLength = 0;
            QuickSearchTextBox.Size = new Size( 318, 26 );
            QuickSearchTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            QuickSearchTextBox.StyleManager = null;
            QuickSearchTextBox.TabIndex = 10;
            QuickSearchTextBox.Text = "webTextBox1";
            QuickSearchTextBox.TextAlign = HorizontalAlignment.Left;
            QuickSearchTextBox.ThemeAuthor = "Terry D. Eppler";
            QuickSearchTextBox.ThemeName = "Budget Execution";
            QuickSearchTextBox.ToolTip = ToolTip;
            QuickSearchTextBox.UseSystemPasswordChar = false;
            QuickSearchTextBox.WatermarkText = "";
            QuickSearchTextBox.TextChanged += OnSearchTextChanged;
            // 
            // SearchNextButton
            // 
            SearchNextButton.Anchor =   AnchorStyles.Top  |  AnchorStyles.Right  ;
            SearchNextButton.FlatStyle = FlatStyle.Flat;
            SearchNextButton.ForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            SearchNextButton.Image = (Image) resources.GetObject( "SearchNextButton.Image" ) ;
            SearchNextButton.Location = new Point( 398, 4 );
            SearchNextButton.Margin = new Padding( 3, 4, 3, 4 );
            SearchNextButton.Name = "SearchNextButton";
            SearchNextButton.Size = new Size( 25, 28 );
            SearchNextButton.TabIndex = 9;
            SearchNextButton.Tag = "Find next (Enter)";
            SearchNextButton.UseVisualStyleBackColor = true;
            SearchNextButton.Click += OnSearchNextButtonClicked;
            // 
            // SearchPreviousButton
            // 
            SearchPreviousButton.Anchor =   AnchorStyles.Top  |  AnchorStyles.Right  ;
            SearchPreviousButton.FlatStyle = FlatStyle.Flat;
            SearchPreviousButton.ForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            SearchPreviousButton.Image = (Image) resources.GetObject( "SearchPreviousButton.Image" ) ;
            SearchPreviousButton.Location = new Point( 365, 4 );
            SearchPreviousButton.Margin = new Padding( 3, 4, 3, 4 );
            SearchPreviousButton.Name = "SearchPreviousButton";
            SearchPreviousButton.Size = new Size( 25, 28 );
            SearchPreviousButton.TabIndex = 8;
            SearchPreviousButton.Tag = "Find previous (Shift+Enter)";
            SearchPreviousButton.UseVisualStyleBackColor = true;
            SearchPreviousButton.Click += OnSearchPreviousButtonClicked;
            // 
            // StopSearchButton
            // 
            StopSearchButton.Anchor =   AnchorStyles.Top  |  AnchorStyles.Right  ;
            StopSearchButton.FlatStyle = FlatStyle.Flat;
            StopSearchButton.ForeColor = Color.FromArgb(   20  ,   20  ,   20   );
            StopSearchButton.Image = (Image) resources.GetObject( "StopSearchButton.Image" ) ;
            StopSearchButton.Location = new Point( 431, 4 );
            StopSearchButton.Margin = new Padding( 3, 4, 3, 4 );
            StopSearchButton.Name = "StopSearchButton";
            StopSearchButton.Size = new Size( 25, 25 );
            StopSearchButton.TabIndex = 7;
            StopSearchButton.Tag = "Close (Esc)";
            StopSearchButton.UseVisualStyleBackColor = true;
            StopSearchButton.Click += OnSearchStopButtonClicked;
            // 
            // ToolBarTable
            // 
            ToolBarTable.ColumnCount = 2;
            ToolBarTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 11.261261F ) );
            ToolBarTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 88.73874F ) );
            ToolBarTable.Controls.Add( ToolStrip, 1, 0 );
            ToolBarTable.Location = new Point( 3, 700 );
            ToolBarTable.Name = "ToolBarTable";
            ToolBarTable.RowCount = 1;
            ToolBarTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            ToolBarTable.Size = new Size( 1332, 36 );
            ToolBarTable.TabIndex = 10;
            // 
            // ToolStrip
            // 
            ToolStrip.BackColor = Color.Transparent;
            ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            ToolStrip.CanOverrideStyle = true;
            ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            ToolStrip.CaptionFont = new Font( "Roboto", 8F, FontStyle.Regular, GraphicsUnit.Point );
            ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            ToolStrip.Dock = DockStyle.Fill;
            ToolStrip.SearchEngineComboBox = null;
            ToolStrip.FirstButton = null;
            ToolStrip.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            ToolStrip.ForeColor = Color.MidnightBlue;
            ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.Items.AddRange( new ToolStripItem[ ] { Separator1, WebsiteLabel, WebsiteComboBox, Separator3, EngineLabel, Separator4, SearchEngineComboBox, Separator5, NavigationLabel, Separator6, WebPreviousButton, Separator7, WebNextButton, Separator8, KeyWordTextBox, Separator9, SearchLabel, Separator10, WebRefreshButton, Separator11, WebCancelButton, Separator12, WebDownloadButton, Separator13, WebHomeButton, Separator14, WebMenuButton, Separator15, WebCloseButton, Separator16 } );
            ToolStrip.NavigationLabel = null;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new Point( 151, 1 );
            ToolStrip.Margin = new Padding( 1 );
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NextButton = null;
            ToolStrip.Office12Mode = false;
            ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            ToolStrip.Padding = new Padding( 1 );
            ToolStrip.PreviousButton = null;
            ToolStrip.RefreshButton = null;
            ToolStrip.WebsiteLabel = null;
            ToolStrip.SearchEngineLabel = null;
            ToolStrip.Separators = null;
            ToolStrip.ShowCaption = false;
            ToolStrip.ShowLauncher = true;
            ToolStrip.Size = new Size( 1180, 34 );
            ToolStrip.TabIndex = 9;
            ToolStrip.Text = "webToolStrip1";
            ToolStrip.ToolBarTextBox = null;
            ToolStrip.ThemeName = "Office2016DarkGray";
            ToolStrip.ThemeStyle.ArrowColor = Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.BackColor = Color.Transparent;
            ToolStrip.ThemeStyle.BottomToolStripBackColor = Color.Transparent;
            ToolStrip.ThemeStyle.CaptionBackColor = Color.FromArgb(   28  ,   28  ,   28   );
            ToolStrip.ThemeStyle.CaptionForeColor = Color.Black;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = Color.FromArgb(   65  ,   65  ,   65   );
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor = Color.FromArgb(   40  ,   40  ,   40   );
            ToolStrip.ThemeStyle.HoverItemBackColor = Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.HoverItemForeColor = Color.White;
            ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // Separator1
            // 
            Separator1.ForeColor = Color.Black;
            Separator1.Margin = new Padding( 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new Padding( 1 );
            Separator1.Size = new Size( 6, 30 );
            // 
            // WebsiteLabel
            // 
            WebsiteLabel.BackColor = Color.FromArgb(   45  ,   45  ,   45   );
            WebsiteLabel.Font = new Font( "Roboto", 6.75F, FontStyle.Regular, GraphicsUnit.Point );
            WebsiteLabel.ForeColor = Color.Black;
            WebsiteLabel.HoverText = null;
            WebsiteLabel.Margin = new Padding( 1 );
            WebsiteLabel.Name = "WebsiteLabel";
            WebsiteLabel.Padding = new Padding( 1 );
            WebsiteLabel.RightToLeftAutoMirrorImage = true;
            WebsiteLabel.Size = new Size( 45, 30 );
            WebsiteLabel.Tag = "";
            WebsiteLabel.Text = "Websites";
            WebsiteLabel.ToolTip = null;
            // 
            // WebsiteComboBox
            // 
            WebsiteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WebsiteComboBox.Font = new Font( "Roboto", 8.25F, FontStyle.Regular, GraphicsUnit.Point );
            WebsiteComboBox.ForeColor = Color.FromArgb(   218  ,   218  ,   218   );
            WebsiteComboBox.HoverText = null;
            WebsiteComboBox.MaxLength = 32767;
            WebsiteComboBox.Name = "WebsiteComboBox";
            WebsiteComboBox.Size = new Size( 175, 32 );
            WebsiteComboBox.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            WebsiteComboBox.ToolTip = ToolTip;
            // 
            // Separator3
            // 
            Separator3.ForeColor = Color.Black;
            Separator3.Margin = new Padding( 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new Padding( 1 );
            Separator3.Size = new Size( 6, 30 );
            // 
            // EngineLabel
            // 
            EngineLabel.BackColor = Color.FromArgb(   45  ,   45  ,   45   );
            EngineLabel.Font = new Font( "Roboto", 6.75F, FontStyle.Regular, GraphicsUnit.Point );
            EngineLabel.ForeColor = Color.Black;
            EngineLabel.HoverText = null;
            EngineLabel.Margin = new Padding( 1 );
            EngineLabel.Name = "EngineLabel";
            EngineLabel.Padding = new Padding( 1 );
            EngineLabel.Size = new Size( 47, 30 );
            EngineLabel.Tag = "";
            EngineLabel.Text = "    Engines";
            EngineLabel.ToolTip = null;
            // 
            // Separator4
            // 
            Separator4.ForeColor = Color.Black;
            Separator4.Margin = new Padding( 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new Padding( 1 );
            Separator4.Size = new Size( 6, 30 );
            // 
            // SearchEngineComboBox
            // 
            SearchEngineComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchEngineComboBox.Font = new Font( "Roboto", 8.25F, FontStyle.Regular, GraphicsUnit.Point );
            SearchEngineComboBox.ForeColor = Color.FromArgb(   218  ,   218  ,   218   );
            SearchEngineComboBox.HoverText = null;
            SearchEngineComboBox.Items.AddRange( new object[ ] { "Google", "Bing", "Duck " } );
            SearchEngineComboBox.MaxLength = 32767;
            SearchEngineComboBox.Name = "SearchEngineComboBox";
            SearchEngineComboBox.Size = new Size( 175, 32 );
            SearchEngineComboBox.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            SearchEngineComboBox.ToolTip = ToolTip;
            // 
            // Separator5
            // 
            Separator5.ForeColor = Color.Black;
            Separator5.Margin = new Padding( 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new Padding( 1 );
            Separator5.Size = new Size( 6, 30 );
            // 
            // NavigationLabel
            // 
            NavigationLabel.BackColor = Color.FromArgb(   45  ,   45  ,   45   );
            NavigationLabel.Font = new Font( "Roboto", 6.75F, FontStyle.Regular, GraphicsUnit.Point );
            NavigationLabel.ForeColor = Color.Black;
            NavigationLabel.HoverText = null;
            NavigationLabel.Margin = new Padding( 1 );
            NavigationLabel.Name = "NavigationLabel";
            NavigationLabel.Padding = new Padding( 1 );
            NavigationLabel.Size = new Size( 61, 30 );
            NavigationLabel.Tag = "";
            NavigationLabel.Text = "      Navigation";
            NavigationLabel.ToolTip = null;
            // 
            // Separator6
            // 
            Separator6.ForeColor = Color.Black;
            Separator6.Margin = new Padding( 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new Padding( 1 );
            Separator6.Size = new Size( 6, 30 );
            // 
            // WebPreviousButton
            // 
            WebPreviousButton.AutoToolTip = false;
            WebPreviousButton.BackColor = Color.Transparent;
            WebPreviousButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            WebPreviousButton.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            WebPreviousButton.ForeColor = Color.LightGray;
            WebPreviousButton.HoverText = "Previous Result";
            WebPreviousButton.Image = Resources.Resources.WebPreviousButton;
            WebPreviousButton.ImageTransparentColor = Color.Magenta;
            WebPreviousButton.Margin = new Padding( 3 );
            WebPreviousButton.Name = "WebPreviousButton";
            WebPreviousButton.Padding = new Padding( 1 );
            WebPreviousButton.Size = new Size( 23, 26 );
            WebPreviousButton.Text = "webToolStripButton1";
            WebPreviousButton.ToolTip = ToolTip;
            WebPreviousButton.ToolType = ToolType.WebPreviousButton;
            // 
            // Separator7
            // 
            Separator7.ForeColor = Color.Black;
            Separator7.Margin = new Padding( 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new Padding( 1 );
            Separator7.Size = new Size( 6, 30 );
            // 
            // WebNextButton
            // 
            WebNextButton.AutoToolTip = false;
            WebNextButton.BackColor = Color.Transparent;
            WebNextButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            WebNextButton.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            WebNextButton.ForeColor = Color.LightGray;
            WebNextButton.HoverText = "Next Result";
            WebNextButton.Image = Resources.Resources.WebNextButton;
            WebNextButton.ImageTransparentColor = Color.Magenta;
            WebNextButton.Margin = new Padding( 3 );
            WebNextButton.Name = "WebNextButton";
            WebNextButton.Padding = new Padding( 1 );
            WebNextButton.Size = new Size( 23, 26 );
            WebNextButton.Text = "webToolStripButton2";
            WebNextButton.ToolTip = ToolTip;
            WebNextButton.ToolType = ToolType.WebNextButton;
            // 
            // Separator8
            // 
            Separator8.ForeColor = Color.Black;
            Separator8.Margin = new Padding( 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new Padding( 1 );
            Separator8.Size = new Size( 6, 30 );
            // 
            // KeyWordTextBox
            // 
            KeyWordTextBox.BackColor = Color.FromArgb(   30  ,   30  ,   30   );
            KeyWordTextBox.BorderStyle = BorderStyle.FixedSingle;
            KeyWordTextBox.Font = new Font( "Roboto", 8.25F, FontStyle.Regular, GraphicsUnit.Point );
            KeyWordTextBox.ForeColor = SystemColors.WindowText;
            KeyWordTextBox.HoverText = "Search Text";
            KeyWordTextBox.Margin = new Padding( 1 );
            KeyWordTextBox.Name = "KeyWordTextBox";
            KeyWordTextBox.Padding = new Padding( 1 );
            KeyWordTextBox.Size = new Size( 228, 30 );
            KeyWordTextBox.Tag = "";
            KeyWordTextBox.Text = "Enter Text";
            KeyWordTextBox.TextBoxTextAlign = HorizontalAlignment.Center;
            KeyWordTextBox.ToolTip = ToolTip;
            // 
            // Separator9
            // 
            Separator9.ForeColor = Color.Black;
            Separator9.Margin = new Padding( 1 );
            Separator9.Name = "Separator9";
            Separator9.Padding = new Padding( 1 );
            Separator9.Size = new Size( 6, 30 );
            // 
            // SearchLabel
            // 
            SearchLabel.BackColor = Color.FromArgb(   45  ,   45  ,   45   );
            SearchLabel.Font = new Font( "Roboto", 6.75F, FontStyle.Regular, GraphicsUnit.Point );
            SearchLabel.ForeColor = Color.Black;
            SearchLabel.HoverText = null;
            SearchLabel.Margin = new Padding( 1 );
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Padding = new Padding( 1 );
            SearchLabel.Size = new Size( 70, 30 );
            SearchLabel.Tag = "";
            SearchLabel.Text = "Key Words          ";
            SearchLabel.ToolTip = null;
            // 
            // Separator10
            // 
            Separator10.ForeColor = Color.Black;
            Separator10.Margin = new Padding( 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new Padding( 1 );
            Separator10.Size = new Size( 6, 30 );
            // 
            // WebRefreshButton
            // 
            WebRefreshButton.AutoToolTip = false;
            WebRefreshButton.BackColor = Color.Transparent;
            WebRefreshButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            WebRefreshButton.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            WebRefreshButton.ForeColor = Color.LightGray;
            WebRefreshButton.HoverText = "Refresh Web Page";
            WebRefreshButton.Image = Resources.Resources.WebRefreshButton;
            WebRefreshButton.ImageTransparentColor = Color.Magenta;
            WebRefreshButton.Margin = new Padding( 3 );
            WebRefreshButton.Name = "WebRefreshButton";
            WebRefreshButton.Padding = new Padding( 1 );
            WebRefreshButton.Size = new Size( 23, 26 );
            WebRefreshButton.Text = "webToolStripButton3";
            WebRefreshButton.ToolTip = ToolTip;
            WebRefreshButton.ToolType = ToolType.WebRefreshButton;
            // 
            // Separator11
            // 
            Separator11.ForeColor = Color.Black;
            Separator11.Margin = new Padding( 1 );
            Separator11.Name = "Separator11";
            Separator11.Padding = new Padding( 1 );
            Separator11.Size = new Size( 6, 30 );
            // 
            // WebCancelButton
            // 
            WebCancelButton.AutoToolTip = false;
            WebCancelButton.BackColor = Color.Transparent;
            WebCancelButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            WebCancelButton.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            WebCancelButton.ForeColor = Color.LightGray;
            WebCancelButton.HoverText = "Cancel Search";
            WebCancelButton.Image = Resources.Resources.WebCancelButton;
            WebCancelButton.ImageTransparentColor = Color.Magenta;
            WebCancelButton.Margin = new Padding( 3 );
            WebCancelButton.Name = "WebCancelButton";
            WebCancelButton.Padding = new Padding( 1 );
            WebCancelButton.Size = new Size( 23, 26 );
            WebCancelButton.Text = "webToolStripButton4";
            WebCancelButton.ToolTip = ToolTip;
            WebCancelButton.ToolType = ToolType.WebCancelButton;
            // 
            // Separator12
            // 
            Separator12.ForeColor = Color.Black;
            Separator12.Margin = new Padding( 1 );
            Separator12.Name = "Separator12";
            Separator12.Padding = new Padding( 1 );
            Separator12.Size = new Size( 6, 30 );
            // 
            // WebDownloadButton
            // 
            WebDownloadButton.AutoToolTip = false;
            WebDownloadButton.BackColor = Color.Transparent;
            WebDownloadButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            WebDownloadButton.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            WebDownloadButton.ForeColor = Color.LightGray;
            WebDownloadButton.HoverText = "View Downloads";
            WebDownloadButton.Image = Resources.Resources.WebDownload;
            WebDownloadButton.ImageTransparentColor = Color.Magenta;
            WebDownloadButton.Margin = new Padding( 3 );
            WebDownloadButton.Name = "WebDownloadButton";
            WebDownloadButton.Padding = new Padding( 1 );
            WebDownloadButton.Size = new Size( 23, 26 );
            WebDownloadButton.Text = "webToolStripButton1";
            WebDownloadButton.ToolTip = ToolTip;
            WebDownloadButton.ToolType = ToolType.WebDownloadButton;
            // 
            // Separator13
            // 
            Separator13.ForeColor = Color.Black;
            Separator13.Margin = new Padding( 1 );
            Separator13.Name = "Separator13";
            Separator13.Padding = new Padding( 1 );
            Separator13.Size = new Size( 6, 30 );
            // 
            // WebHomeButton
            // 
            WebHomeButton.AutoToolTip = false;
            WebHomeButton.BackColor = Color.Transparent;
            WebHomeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            WebHomeButton.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            WebHomeButton.ForeColor = Color.LightGray;
            WebHomeButton.HoverText = "Google ";
            WebHomeButton.Image = Resources.Resources.WebGoogleButton;
            WebHomeButton.ImageTransparentColor = Color.Magenta;
            WebHomeButton.Margin = new Padding( 3 );
            WebHomeButton.Name = "WebHomeButton";
            WebHomeButton.Padding = new Padding( 1 );
            WebHomeButton.Size = new Size( 23, 26 );
            WebHomeButton.Text = "webToolStripButton5";
            WebHomeButton.ToolTip = ToolTip;
            WebHomeButton.ToolType = ToolType.WebHomeButton;
            // 
            // Separator14
            // 
            Separator14.ForeColor = Color.Black;
            Separator14.Margin = new Padding( 1 );
            Separator14.Name = "Separator14";
            Separator14.Padding = new Padding( 1 );
            Separator14.Size = new Size( 6, 30 );
            // 
            // WebMenuButton
            // 
            WebMenuButton.AutoToolTip = false;
            WebMenuButton.BackColor = Color.Transparent;
            WebMenuButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            WebMenuButton.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            WebMenuButton.ForeColor = Color.LightGray;
            WebMenuButton.HoverText = "Main Menu";
            WebMenuButton.Image = Resources.Resources.WebMenuButton;
            WebMenuButton.ImageTransparentColor = Color.Magenta;
            WebMenuButton.Margin = new Padding( 3 );
            WebMenuButton.Name = "WebMenuButton";
            WebMenuButton.Padding = new Padding( 1 );
            WebMenuButton.Size = new Size( 23, 26 );
            WebMenuButton.Text = "webToolStripButton1";
            WebMenuButton.ToolTip = ToolTip;
            WebMenuButton.ToolType = ToolType.WebMenuButton;
            // 
            // Separator15
            // 
            Separator15.ForeColor = Color.Black;
            Separator15.Margin = new Padding( 1 );
            Separator15.Name = "Separator15";
            Separator15.Padding = new Padding( 1 );
            Separator15.Size = new Size( 6, 30 );
            // 
            // WebCloseButton
            // 
            WebCloseButton.AutoToolTip = false;
            WebCloseButton.BackColor = Color.Transparent;
            WebCloseButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            WebCloseButton.Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            WebCloseButton.ForeColor = Color.LightGray;
            WebCloseButton.HoverText = "Shut Down";
            WebCloseButton.Image = Resources.Resources.WebCloseButton;
            WebCloseButton.ImageTransparentColor = Color.Magenta;
            WebCloseButton.Margin = new Padding( 3 );
            WebCloseButton.Name = "WebCloseButton";
            WebCloseButton.Padding = new Padding( 1 );
            WebCloseButton.Size = new Size( 23, 26 );
            WebCloseButton.Text = "webToolStripButton2";
            WebCloseButton.ToolTip = ToolTip;
            WebCloseButton.ToolType = ToolType.WebCloseButton;
            // 
            // Separator16
            // 
            Separator16.ForeColor = Color.Black;
            Separator16.Margin = new Padding( 1 );
            Separator16.Name = "Separator16";
            Separator16.Padding = new Padding( 1 );
            Separator16.Size = new Size( 6, 30 );
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 5;
            HeaderTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 30.74074F ) );
            HeaderTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 69.25926F ) );
            HeaderTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 928F ) );
            HeaderTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 9F ) );
            HeaderTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 211F ) );
            HeaderTable.Controls.Add( Picture, 0, 0 );
            HeaderTable.Controls.Add( Title, 2, 0 );
            HeaderTable.Dock = DockStyle.Fill;
            HeaderTable.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            HeaderTable.Location = new Point( 3, 3 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            HeaderTable.Size = new Size( 1332, 29 );
            HeaderTable.TabIndex = 13;
            // 
            // Picture
            // 
            Picture.BackColor = Color.Transparent;
            Picture.Image = Resources.Resources.EPA;
            Picture.Location = new Point( 3, 3 );
            Picture.Name = "Picture";
            Picture.Padding = new Padding( 1 );
            Picture.Size = new Size( 44, 18 );
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 0;
            Picture.TabStop = false;
            Picture.ToolTip = null;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Fill;
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new Font( "Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new Point( 186, 3 );
            Title.Margin = new Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new Padding( 1 );
            Title.Size = new Size( 922, 23 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // BrowserTable
            // 
            BrowserTable.ColumnCount = 1;
            BrowserTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            BrowserTable.Controls.Add( TabPages, 0, 2 );
            BrowserTable.Controls.Add( ToolBarTable, 0, 3 );
            BrowserTable.Controls.Add( HeaderTable, 0, 0 );
            BrowserTable.Controls.Add( MainTextBoxPanel, 0, 1 );
            BrowserTable.Dock = DockStyle.Fill;
            BrowserTable.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            BrowserTable.Location = new Point( 0, 0 );
            BrowserTable.Name = "BrowserTable";
            BrowserTable.RowCount = 4;
            BrowserTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 35F ) );
            BrowserTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 43F ) );
            BrowserTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 619F ) );
            BrowserTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 28F ) );
            BrowserTable.Size = new Size( 1338, 739 );
            BrowserTable.TabIndex = 14;
            // 
            // WebBrowser
            // 
            AutoScaleDimensions = new SizeF( 7F, 14F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionFont = new Font( "Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point );
            CaptionForeColor = Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new Size( 1338, 739 );
            ControlBox = false;
            Controls.Add( BrowserTable );
            Font = new Font( "Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point );
            ForeColor = Color.LightGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon) resources.GetObject( "$this.Icon" ) ;
            Margin = new Padding( 4, 5, 4, 5 );
            MaximizeBox = false;
            MaximumSize = new Size( 1350, 750 );
            MetroColor = Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new Size( 1350, 750 );
            Name = "WebBrowser";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Title";
            FormClosing += OnWebBrowserClosing;
            Load += OnLoad;
            MenuStripTab.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) TabPages  ).EndInit( );
            TabPages.ResumeLayout( false );
            MainTextBoxPanel.ResumeLayout( false );
            QuickSearchPanel.ResumeLayout( false );
            ToolBarTable.ResumeLayout( false );
            ToolBarTable.PerformLayout( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) Picture  ).EndInit( );
            BrowserTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public System.Windows.Forms.Timer Timer;
        public Panel BottomPanel;
        public ContextMenuStrip MenuStripTab;
        public ToolStripMenuItem MenuCloseOtherTabs;
        public Button NextButton;
        public Button PreviousButton;
        public Button RefreshButton;
        public Button HomeButton;
        public Button SearchNextButton;
        public Button SearchPreviousButton;
        public TableLayoutPanel tableLayoutPanel1;
        public Panel MainTextBoxPanel;
        public Button StopButton;
        public Button DownloadButton;
        public Button StopSearchButton;
        public ToolStripMenuItem MenuCloseTab;
        public Panel QuickSearchPanel;
        public TableLayoutPanel ToolBarTable;
        public TextBox AddressTextBox;
        public SmallTip ToolTip;
        public TextBox QuickSearchTextBox;
        public ToolSeparator Separator1;
        public ToolStripLabel EngineLabel;
        public ToolSeparator Separator4;
        public ToolStripComboBox SearchEngineComboBox;
        public ToolSeparator Separator5;
        public ToolStripButton WebPreviousButton;
        public ToolSeparator Separator7;
        public ToolStripButton WebNextButton;
        public ToolSeparator Separator8;
        public ToolStripTextBox KeyWordTextBox;
        public ToolSeparator Separator10;
        public ToolStripButton WebRefreshButton;
        public ToolSeparator Separator11;
        public ToolStripButton WebCancelButton;
        public ToolSeparator Separator12;
        public ToolStripButton WebHomeButton;
        public ToolStrip ToolStrip;
        public BrowserTabStripItem AddItem;
        public BrowserTabStripItem TabItem;
        public BrowserTabStrip TabPages;
        public ToolStripLabel StripLabel1;
        public ToolStripButton WebCloseButton;
        public ToolStripButton WebMenuButton;
        public ToolSeparator Separator16;
        public ToolStripButton WebDownloadButton;
        public ToolSeparator Separator13;
        public ToolSeparator Separator14;
        public ToolSeparator Separator15;
        public TableLayoutPanel HeaderTable;
        public Picture Picture;
        public Label Title;
        public TableLayoutPanel BrowserTable;
        public ToolStripLabel NavigationLabel;
        public ToolSeparator Separator6;
        public ToolSeparator Separator9;
        public ToolStripLabel SearchLabel;
        public ToolStripLabel WebsiteLabel;
        public ToolStripComboBox WebsiteComboBox;
        public ToolSeparator Separator3;
    }
}


namespace BudgetExecution
{
    partial class WebBrowser
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
            components = new System.ComponentModel.Container( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( WebBrowser ) );
            MenuStripTab = new System.Windows.Forms.ContextMenuStrip( components );
            MenuCloseTab = new System.Windows.Forms.ToolStripMenuItem( );
            MenuCloseOtherTabs = new System.Windows.Forms.ToolStripMenuItem( );
            RefreshButton = new System.Windows.Forms.Button( );
            StopButton = new System.Windows.Forms.Button( );
            NextButton = new System.Windows.Forms.Button( );
            PreviousButton = new System.Windows.Forms.Button( );
            Timer = new System.Windows.Forms.Timer( components );
            DownloadButton = new System.Windows.Forms.Button( );
            AddressTextBox = new System.Windows.Forms.TextBox( );
            PanelToolbar = new System.Windows.Forms.Panel( );
            HomeButton = new System.Windows.Forms.Button( );
            TabPages = new BrowserTabStrip( );
            TabStripItem = new BrowserTabStripItem( );
            TabStripAdd = new BrowserTabStripItem( );
            BottomPanel = new System.Windows.Forms.Panel( );
            PanelSearch = new System.Windows.Forms.Panel( );
            SearchNextButton = new System.Windows.Forms.Button( );
            SearchPreviousButton = new System.Windows.Forms.Button( );
            StopSearchButton = new System.Windows.Forms.Button( );
            SearchTextBox = new System.Windows.Forms.TextBox( );
            StatusTable = new System.Windows.Forms.TableLayoutPanel( );
            MenuStripTab.SuspendLayout( );
            PanelToolbar.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) TabPages  ).BeginInit( );
            TabPages.SuspendLayout( );
            PanelSearch.SuspendLayout( );
            StatusTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // MenuStripTab
            // 
            MenuStripTab.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MenuStripTab.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            MenuStripTab.ImageScalingSize = new System.Drawing.Size( 20, 20 );
            MenuStripTab.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { MenuCloseTab, MenuCloseOtherTabs } );
            MenuStripTab.Name = "menuStripTab";
            MenuStripTab.Size = new System.Drawing.Size( 173, 48 );
            // 
            // MenuCloseTab
            // 
            MenuCloseTab.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MenuCloseTab.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            MenuCloseTab.ForeColor = System.Drawing.Color.LightGray;
            MenuCloseTab.Name = "MenuCloseTab";
            MenuCloseTab.ShortcutKeys =   System.Windows.Forms.Keys.Control  |  System.Windows.Forms.Keys.F4  ;
            MenuCloseTab.Size = new System.Drawing.Size( 172, 22 );
            MenuCloseTab.Text = "Close tab";
            MenuCloseTab.Click += OnCloseMenuClicked;
            // 
            // MenuCloseOtherTabs
            // 
            MenuCloseOtherTabs.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MenuCloseOtherTabs.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            MenuCloseOtherTabs.ForeColor = System.Drawing.Color.LightGray;
            MenuCloseOtherTabs.Name = "MenuCloseOtherTabs";
            MenuCloseOtherTabs.Size = new System.Drawing.Size( 172, 22 );
            MenuCloseOtherTabs.Text = "Close other tabs";
            MenuCloseOtherTabs.Click += OnCloseOtherTabsButtonClicked;
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            RefreshButton.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RefreshButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            RefreshButton.Image = (System.Drawing.Image) resources.GetObject( "RefreshButton.Image" ) ;
            RefreshButton.Location = new System.Drawing.Point( 1251, 1 );
            RefreshButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new System.Drawing.Size( 25, 25 );
            RefreshButton.TabIndex = 3;
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += OnRefreshButtonClicked;
            // 
            // StopButton
            // 
            StopButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StopButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            StopButton.Image = (System.Drawing.Image) resources.GetObject( "StopButton.Image" ) ;
            StopButton.Location = new System.Drawing.Point( 1282, 1 );
            StopButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            StopButton.Name = "StopButton";
            StopButton.Size = new System.Drawing.Size( 25, 25 );
            StopButton.TabIndex = 2;
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += OnStopButtonClicked;
            // 
            // NextButton
            // 
            NextButton.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NextButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            NextButton.Image = (System.Drawing.Image) resources.GetObject( "NextButton.Image" ) ;
            NextButton.Location = new System.Drawing.Point( 29, 1 );
            NextButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            NextButton.Name = "NextButton";
            NextButton.Size = new System.Drawing.Size( 21, 25 );
            NextButton.TabIndex = 1;
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += OnForwardButtonClicked;
            // 
            // PreviousButton
            // 
            PreviousButton.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PreviousButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            PreviousButton.Image = (System.Drawing.Image) resources.GetObject( "PreviousButton.Image" ) ;
            PreviousButton.Location = new System.Drawing.Point( 2, 1 );
            PreviousButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new System.Drawing.Size( 21, 25 );
            PreviousButton.TabIndex = 0;
            PreviousButton.UseVisualStyleBackColor = false;
            PreviousButton.Click += OnBackButtonClicked;
            // 
            // Timer
            // 
            Timer.Interval = 50;
            Timer.Tick += OnTimerTick;
            // 
            // DownloadButton
            // 
            DownloadButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            DownloadButton.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DownloadButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            DownloadButton.Image = (System.Drawing.Image) resources.GetObject( "DownloadButton.Image" ) ;
            DownloadButton.Location = new System.Drawing.Point( 1310, 1 );
            DownloadButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new System.Drawing.Size( 25, 25 );
            DownloadButton.TabIndex = 4;
            DownloadButton.Tag = "Downloads";
            DownloadButton.UseVisualStyleBackColor = false;
            DownloadButton.Click += OnDownloadButtonClicked;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            AddressTextBox.BackColor = System.Drawing.Color.FromArgb(   80  ,   80  ,   80   );
            AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            AddressTextBox.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            AddressTextBox.ForeColor = System.Drawing.Color.White;
            AddressTextBox.Location = new System.Drawing.Point( 60, 5 );
            AddressTextBox.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new System.Drawing.Size( 1154, 15 );
            AddressTextBox.TabIndex = 5;
            AddressTextBox.Click += OnUrlTextBoxClicked;
            AddressTextBox.TextChanged += OnUrlChanged;
            AddressTextBox.KeyDown += OnUrlDownButtonClicked;
            // 
            // PanelToolbar
            // 
            PanelToolbar.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            PanelToolbar.Controls.Add( HomeButton );
            PanelToolbar.Controls.Add( AddressTextBox );
            PanelToolbar.Controls.Add( DownloadButton );
            PanelToolbar.Controls.Add( NextButton );
            PanelToolbar.Controls.Add( PreviousButton );
            PanelToolbar.Controls.Add( RefreshButton );
            PanelToolbar.Controls.Add( StopButton );
            PanelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            PanelToolbar.Location = new System.Drawing.Point( 0, 0 );
            PanelToolbar.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            PanelToolbar.Name = "PanelToolbar";
            PanelToolbar.Size = new System.Drawing.Size( 1338, 30 );
            PanelToolbar.TabIndex = 6;
            // 
            // HomeButton
            // 
            HomeButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            HomeButton.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            HomeButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            HomeButton.Image = (System.Drawing.Image) resources.GetObject( "HomeButton.Image" ) ;
            HomeButton.Location = new System.Drawing.Point( 1220, 1 );
            HomeButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new System.Drawing.Size( 25, 25 );
            HomeButton.TabIndex = 6;
            HomeButton.Tag = "Home";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += BtnHome_Click;
            // 
            // TabPages
            // 
            TabPages.ContextMenuStrip = MenuStripTab;
            TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            TabPages.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabPages.Items.AddRange( new BrowserTabStripItem[ ] { TabStripItem, TabStripAdd } );
            TabPages.Location = new System.Drawing.Point( 0, 30 );
            TabPages.Name = "TabPages";
            TabPages.Padding = new System.Windows.Forms.Padding( 1, 29, 1, 1 );
            TabPages.SelectedItem = TabStripItem;
            TabPages.Size = new System.Drawing.Size( 1338, 653 );
            TabPages.TabIndex = 4;
            TabPages.Text = "faTabStrip1";
            TabPages.TabStripItemSelectionChanged += OnTabItemChanged;
            TabPages.TabStripItemClosed += OnTabClosed;
            TabPages.MouseClick += OnTabPagesMouseClicked;
            // 
            // TabStripItem
            // 
            TabStripItem.Dock = System.Windows.Forms.DockStyle.Fill;
            TabStripItem.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabStripItem.IsDrawn = true;
            TabStripItem.Location = new System.Drawing.Point( 1, 29 );
            TabStripItem.Name = "TabStripItem";
            TabStripItem.Selected = true;
            TabStripItem.Size = new System.Drawing.Size( 1336, 623 );
            TabStripItem.TabIndex = 0;
            TabStripItem.Title = "Loading...";
            // 
            // TabStripAdd
            // 
            TabStripAdd.CanClose = false;
            TabStripAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            TabStripAdd.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabStripAdd.IsDrawn = true;
            TabStripAdd.Location = new System.Drawing.Point( 0, 0 );
            TabStripAdd.Name = "TabStripAdd";
            TabStripAdd.Size = new System.Drawing.Size( 931, 601 );
            TabStripAdd.TabIndex = 1;
            TabStripAdd.Title = "+";
            // 
            // BottomPanel
            // 
            BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            BottomPanel.Location = new System.Drawing.Point( 3, 3 );
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new System.Drawing.Size( 205, 25 );
            BottomPanel.TabIndex = 8;
            // 
            // PanelSearch
            // 
            PanelSearch.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            PanelSearch.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            PanelSearch.Controls.Add( SearchNextButton );
            PanelSearch.Controls.Add( SearchPreviousButton );
            PanelSearch.Controls.Add( StopSearchButton );
            PanelSearch.Controls.Add( SearchTextBox );
            PanelSearch.Location = new System.Drawing.Point( 1029, 41 );
            PanelSearch.Name = "PanelSearch";
            PanelSearch.Size = new System.Drawing.Size( 307, 38 );
            PanelSearch.TabIndex = 9;
            PanelSearch.Visible = false;
            // 
            // SearchNextButton
            // 
            SearchNextButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            SearchNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchNextButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SearchNextButton.Image = (System.Drawing.Image) resources.GetObject( "SearchNextButton.Image" ) ;
            SearchNextButton.Location = new System.Drawing.Point( 241, 4 );
            SearchNextButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            SearchNextButton.Name = "SearchNextButton";
            SearchNextButton.Size = new System.Drawing.Size( 25, 28 );
            SearchNextButton.TabIndex = 9;
            SearchNextButton.Tag = "Find next (Enter)";
            SearchNextButton.UseVisualStyleBackColor = true;
            SearchNextButton.Click += OnSearchNextButtonClicked;
            // 
            // SearchPreviousButton
            // 
            SearchPreviousButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            SearchPreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchPreviousButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SearchPreviousButton.Image = (System.Drawing.Image) resources.GetObject( "SearchPreviousButton.Image" ) ;
            SearchPreviousButton.Location = new System.Drawing.Point( 208, 4 );
            SearchPreviousButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            SearchPreviousButton.Name = "SearchPreviousButton";
            SearchPreviousButton.Size = new System.Drawing.Size( 25, 28 );
            SearchPreviousButton.TabIndex = 8;
            SearchPreviousButton.Tag = "Find previous (Shift+Enter)";
            SearchPreviousButton.UseVisualStyleBackColor = true;
            SearchPreviousButton.Click += OnSearchPreviousButtonClicked;
            // 
            // StopSearchButton
            // 
            StopSearchButton.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            StopSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StopSearchButton.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            StopSearchButton.Image = (System.Drawing.Image) resources.GetObject( "StopSearchButton.Image" ) ;
            StopSearchButton.Location = new System.Drawing.Point( 274, 4 );
            StopSearchButton.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            StopSearchButton.Name = "StopSearchButton";
            StopSearchButton.Size = new System.Drawing.Size( 25, 25 );
            StopSearchButton.TabIndex = 7;
            StopSearchButton.Tag = "Close (Esc)";
            StopSearchButton.UseVisualStyleBackColor = true;
            StopSearchButton.Click += OnStopSearchButtonClicked;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            SearchTextBox.BackColor = System.Drawing.Color.FromArgb(   70  ,   70  ,   70   );
            SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            SearchTextBox.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SearchTextBox.ForeColor = System.Drawing.Color.LightGray;
            SearchTextBox.Location = new System.Drawing.Point( 10, 6 );
            SearchTextBox.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new System.Drawing.Size( 183, 15 );
            SearchTextBox.TabIndex = 6;
            SearchTextBox.TextChanged += OnSearchTextChanged;
            SearchTextBox.KeyDown += TxtSearch_KeyDown;
            // 
            // StatusTable
            // 
            StatusTable.ColumnCount = 2;
            StatusTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 15.7698059F ) );
            StatusTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 84.2301941F ) );
            StatusTable.Controls.Add( BottomPanel, 0, 0 );
            StatusTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            StatusTable.Location = new System.Drawing.Point( 0, 683 );
            StatusTable.Name = "StatusTable";
            StatusTable.RowCount = 1;
            StatusTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            StatusTable.Size = new System.Drawing.Size( 1338, 31 );
            StatusTable.TabIndex = 10;
            // 
            // WebBrowser
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 1338, 714 );
            Controls.Add( PanelSearch );
            Controls.Add( TabPages );
            Controls.Add( PanelToolbar );
            Controls.Add( StatusTable );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "WebBrowser";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Title";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += OnWebBrowserClosing;
            Load += MainForm_Load;
            MenuStripTab.ResumeLayout( false );
            PanelToolbar.ResumeLayout( false );
            PanelToolbar.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize) TabPages  ).EndInit( );
            TabPages.ResumeLayout( false );
            PanelSearch.ResumeLayout( false );
            PanelSearch.PerformLayout( );
            StatusTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem menuCloseTab;
        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnHome;
        public System.Windows.Forms.ContextMenuStrip MenuStripTab;
        public System.Windows.Forms.ToolStripMenuItem MenuCloseOtherTabs;
        public System.Windows.Forms.TextBox AddressTextBox;
        public BrowserTabStripItem TabStripAdd;
        public BrowserTabStripItem TabStripItem;
        public System.Windows.Forms.Button NextButton;
        public System.Windows.Forms.Button PreviousButton;
        public System.Windows.Forms.Button RefreshButton;
        public System.Windows.Forms.Button HomeButton;
        public System.Windows.Forms.Button SearchNextButton;
        public System.Windows.Forms.Button SearchPreviousButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public BrowserTabStrip TabPages;
        public System.Windows.Forms.Panel PanelToolbar;
        public System.Windows.Forms.Button StopButton;
        public System.Windows.Forms.Button DownloadButton;
        public System.Windows.Forms.Button StopSearchButton;
        public System.Windows.Forms.ToolStripMenuItem MenuCloseTab;
        public System.Windows.Forms.Panel PanelSearch;
        public System.Windows.Forms.TableLayoutPanel StatusTable;
        public System.Windows.Forms.TextBox SearchTextBox;
    }
}


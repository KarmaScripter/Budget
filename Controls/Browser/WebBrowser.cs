// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-02-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-17-2023
// ******************************************************************************************
// <copyright file="WebBrowser.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   WebBrowser.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using CefSharp;
    using CefSharp.WinForms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Reflection;
    using System.Web;
    using System.Windows.Forms;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Threading;
    using Action = System.Action;
    using LoadErrorEventArgs = CefSharp.LoadErrorEventArgs;

    /// <summary>
    /// The main SharpBrowser form, supporting multiple tabs.
    /// We used the x86 version of CefSharp, so the app works on 32-bit and 64-bit machines.
    /// If you would only like to support 64-bit machines, simply change the DLL references.
    /// </summary>
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    [ SuppressMessage( "ReSharper", "EmptyGeneralCatchClause" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "CanSimplifyDictionaryLookupWithTryGetValue" ) ]
    [ SuppressMessage( "ReSharper", "RedundantCast" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentlySynchronizedField" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [ SuppressMessage( "ReSharper", "InlineOutVariableDeclaration" ) ]
    [ SuppressMessage( "ReSharper", "TooWideLocalVariableScope" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public partial class WebBrowser : MetroForm
    {
        /// <summary>
        /// The download names
        /// </summary>
        public Dictionary<int, string> DownloadNames;

        /// <summary>
        /// The host
        /// </summary>
        public HostHandler Host;

        /// <summary>
        /// The application path
        /// </summary>
        private string _appPath = Path.GetDirectoryName( Application.ExecutablePath ) + @"\";

        /// <summary>
        /// The old border style
        /// </summary>
        private FormBorderStyle _borderStyle;

        /// <summary>
        /// The current clean URL
        /// </summary>
        private string _currentCleanUrl;

        /// <summary>
        /// The current full URL
        /// </summary>
        private string _currentFullUrl;

        /// <summary>
        /// The current title
        /// </summary>
        private string _currentTitle;

        /// <summary>
        /// The d handler
        /// </summary>
        private DownloadHandler _downloadHandler;

        /// <summary>
        /// The downloads strip
        /// </summary>
        private BrowserTabStripItem _downloadsStrip;

        /// <summary>
        /// The is full screen
        /// </summary>
        private bool _isFullScreen;

        /// <summary>
        /// The k handler
        /// </summary>
        private KeyboardHandler _keyboardHandler;

        /// <summary>
        /// The last search
        /// </summary>
        private string _lastSearch = "";

        /// <summary>
        /// The l handler
        /// </summary>
        private LifeSpanHandler _lifeHandler;

        /// <summary>
        /// The m handler
        /// </summary>
        private ContextMenuHandler _menuHandler;

        /// <summary>
        /// The new strip
        /// </summary>
        private BrowserTabStripItem _newTabItem;

        /// <summary>
        /// The r handler
        /// </summary>
        private RequestHandler _requestHandler;

        /// <summary>
        /// The search open
        /// </summary>
        private bool _searchOpen;

        /// <summary>
        /// The old window state
        /// </summary>
        private FormWindowState _windowState;

        /// <summary>
        /// The instance
        /// </summary>
        public static WebBrowser Instance;

        /// <summary>
        /// The assembly
        /// </summary>
        public static Assembly Assembly;

        /// <summary>
        /// Gets the current browser.
        /// </summary>
        /// <value>
        /// The current browser.
        /// </value>
        public ChromiumWebBrowser CurrentBrowser
        {
            get { return ( (BrowserTab)TabPages.SelectedItem?.Tag )?.Browser; }
        }

        /// <summary>
        /// Gets the current tab.
        /// </summary>
        /// <value>
        /// The current tab.
        /// </value>
        public BrowserTab CurrentTab
        {
            get { return (BrowserTab)TabPages.SelectedItem?.Tag; }
        }

        /// <summary>
        /// Gets the current tab loading dur.
        /// </summary>
        /// <value>
        /// The current tab loading dur.
        /// </value>
        public int Duration
        {
            get
            {
                if( TabPages.SelectedItem?.Tag != null )
                {
                    var _loadTime =
                        (int)( DateTime.Now - CurrentTab.DateCreated ).TotalMilliseconds;

                    return _loadTime;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Gets the cancel requests.
        /// </summary>
        /// <value>
        /// The cancel requests.
        /// </value>
        public List<int> CancelRequests { get; set; }

        /// <summary>
        /// Gets the downloads.
        /// </summary>
        /// <value>
        /// The downloads.
        /// </value>
        public Dictionary<int, DownloadItem> Downloads { get; set; }

        /// <summary>
        /// Gets or sets the index of the current.
        /// </summary>
        /// <value>
        /// The index of the current.
        /// </value>
        private int CurrentIndex
        {
            get { return TabPages.Items.IndexOf( TabPages.SelectedItem ); }
            set { TabPages.SelectedItem = TabPages.Items[ value ]; }
        }

        /// <summary>
        /// Gets the last index.
        /// </summary>
        /// <value>
        /// The last index.
        /// </value>
        private int LastIndex
        {
            get { return TabPages.Items.Count - 2; }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.WebBrowser" /> class.
        /// </summary>
        public WebBrowser( )
        {
            Instance = this;
            InitializeComponent( );

            // Form Properties
            Name = "WebBrowser";
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 9, FontStyle.Regular );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            SizeGripStyle = SizeGripStyle.Hide;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            InitBrowser( );
            SetFormTitle( null );

            // Title Properties
            Title.Font = new Font( "Roboto", 11 );
            Title.ForeColor = Color.FromArgb( 66, 135, 245 );
            TabPages.ForeColor = Color.LightSteelBlue;

            // Event Wiring
            Load += OnLoad;
            AddItem.Click += OnAddTabButtonClicked;
            WebCloseButton.Click += OnWebCloseButtonClicked;
            PreviousButton.Click += OnPreviousButtonClicked;
            NextButton.Click += OnNextButtonClicked;
            DownloadButton.Click += OnDownloadButtonClicked;
            HomeButton.Click += OnHomeButtonClicked;
        }

        /// <summary>
        /// Gets the resource stream.
        /// </summary>
        /// <param name="fileName">The fileName.</param>
        /// <param name="withNameSpace">if set to <c>true</c> [with namespace].</param>
        /// <returns></returns>
        public Stream GetResourceStream( string fileName, bool withNameSpace = true )
        {
            try
            {
                return Assembly.GetManifestResourceStream( "BudgetBrowser.Resources." + fileName );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return null;
            }
        }

        /// <summary>
        /// we activate all the tooltips stored in the Tag property of the buttons
        /// </summary>
        /// <param name="parent">The parent.</param>
        public void InitTooltips( Control.ControlCollection parent )
        {
            if( ( parent != null )
               && ( parent.Count > 0 ) )
            {
                try
                {
                    foreach( Control _ui in parent )
                    {
                        var _btn = _ui as Button;
                        if( _btn?.Tag != null )
                        {
                            var _tip = new ToolTip( );
                            _tip.ReshowDelay = _tip.InitialDelay = 200;
                            _tip.ShowAlways = true;
                            _tip.SetToolTip( _btn, _btn.Tag.ToString( ) );
                        }

                        if( _ui is Panel _panel )
                        {
                            InitTooltips( _panel.Controls );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Adds the blank window.
        /// </summary>
        public void AddBlankWindow( )
        {
            try
            {
                var _info = new ProcessStartInfo( Application.ExecutablePath, "" );
                _info.LoadUserProfile = true;
                _info.UseShellExecute = false;
                _info.RedirectStandardError = true;
                _info.RedirectStandardOutput = true;
                _info.RedirectStandardInput = true;
                Process.Start( _info );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Adds the blank tab.
        /// </summary>
        public void AddBlankTab( )
        {
            try
            {
                AddNewBrowserTab( "" );
                this.InvokeOnParent( delegate
                {
                    AddressTextBox.Focus( );
                } );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Adds the new browser tab.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="focusNewTab">if set to <c>true</c> [focus new tab].</param>
        /// <param name="referringUrl">The referer URL.</param>
        /// <returns></returns>
        public ChromiumWebBrowser AddNewBrowserTab( string url, bool focusNewTab = true,
            string referringUrl = null )
        {
            if( url == "" )
            {
                url = BrowserConfig.NewTabUrl;
            }

            return (ChromiumWebBrowser)Invoke( (Func<ChromiumWebBrowser>)delegate
            {
                foreach( BrowserTabStripItem _item in TabPages.Items )
                {
                    var _tab2 = (BrowserTab)_item.Tag;
                    if( ( _tab2 != null )
                       && ( _tab2.CurrentUrl == url ) )
                    {
                        TabPages.SelectedItem = _item;
                        return _tab2.Browser;
                    }
                }

                var _tabStrip = new BrowserTabStripItem( );
                _tabStrip.Title = "New Tab";
                TabPages.Items.Insert( TabPages.Items.Count - 1, _tabStrip );
                _newTabItem = _tabStrip;
                var _tab = AddNewBrowser( _newTabItem, url );
                _tab.ReferringUrl = referringUrl;
                if( focusNewTab )
                {
                    Timer.Enabled = true;
                }

                return _tab.Browser;
            } );
        }

        /// <summary>
        /// Gets the tab by browser.
        /// </summary>
        /// <param name="browser">The browser.</param>
        /// <returns></returns>
        public BrowserTab GetTabByBrowser( IWebBrowser browser )
        {
            if( browser != null )
            {
                try
                {
                    foreach( BrowserTabStripItem _tab2 in TabPages.Items )
                    {
                        var _tab = (BrowserTab)_tab2.Tag;
                        if( ( _tab != null )
                           && ( _tab.Browser == browser ) )
                        {
                            return _tab;
                        }
                    }

                    return default( BrowserTab );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( BrowserTab );
                }
            }

            return default( BrowserTab );
        }

        /// <summary>
        /// Refreshes the active tab.
        /// </summary>
        public void RefreshActiveTab( )
        {
            try
            {
                CurrentBrowser.Load( CurrentBrowser.Address );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Closes the active tab.
        /// </summary>
        public void CloseActiveTab( )
        {
            try
            {
                if( CurrentTab != null/* && TabPages.Items.Count > 2*/ )
                {
                    var _index = TabPages.Items.IndexOf( TabPages.SelectedItem );
                    TabPages.RemoveTab( TabPages.SelectedItem );
                    if( TabPages.Items.Count - 1 > _index )
                    {
                        TabPages.SelectedItem = TabPages.Items[ _index ];
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets all tabs.
        /// </summary>
        /// <returns></returns>
        public List<BrowserTab> GetAllTabs( )
        {
            try
            {
                var _tabs = new List<BrowserTab>( );
                foreach( BrowserTabStripItem _tabPage in TabPages.Items )
                {
                    if( _tabPage.Tag != null )
                    {
                        _tabs.Add( (BrowserTab)_tabPage.Tag );
                    }
                }

                return _tabs;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( List<BrowserTab> );
            }
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
        public void InvokeIfNeeded( Action action )
        {
            if( action != null )
            {
                try
                {
                    if( InvokeRequired )
                    {
                        BeginInvoke( action );
                    }
                    else
                    {
                        action.Invoke( );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Waits for browser to initialize.
        /// </summary>
        /// <param name="browser">The browser.</param>
        public void WaitForBrowserToInitialize( ChromiumWebBrowser browser )
        {
            while( !browser.IsBrowserInitialized )
            {
                Thread.Sleep( 100 );
            }
        }

        /// <summary>
        /// Updates the download item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void UpdateDownloadItem( DownloadItem item )
        {
            if( item != null )
            {
                try
                {
                    lock( Downloads )
                    {
                        if( item.SuggestedFileName != "" )
                        {
                            DownloadNames[ item.Id ] = item.SuggestedFileName;
                        }

                        if( ( item.SuggestedFileName == "" )
                           && DownloadNames.ContainsKey( item.Id ) )
                        {
                            item.SuggestedFileName = DownloadNames[ item.Id ];
                        }

                        Downloads[ item.Id ] = item;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Calculates the download path.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public string GetDownloadPath( DownloadItem item )
        {
            return !string.IsNullOrEmpty( item?.SuggestedFileName )
                ? item.SuggestedFileName
                : string.Empty;
        }

        /// <summary>
        /// Downloads the in progress.
        /// </summary>
        /// <returns></returns>
        public bool DownloadsInProgress( )
        {
            try
            {
                foreach( var _item in Downloads.Values )
                {
                    if( _item.IsInProgress )
                    {
                        return true;
                    }
                }

                return false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// Opens the downloads tab.
        /// </summary>
        public void OpenDownloadsTab( )
        {
            try
            {
                if( ( _downloadsStrip != null )
                   && ( ( (ChromiumWebBrowser)_downloadsStrip.Controls[ 0 ] ).Address
                       == BrowserConfig.DownloadsUrl ) )
                {
                    TabPages.SelectedItem = _downloadsStrip;
                }
                else
                {
                    var _brw = AddNewBrowserTab( BrowserConfig.DownloadsUrl );
                    _downloadsStrip = (BrowserTabStripItem)_brw.Parent;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Adds the new browser.
        /// </summary>
        /// <param name="tabItem">The tab strip.</param>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private BrowserTab AddNewBrowser( BrowserTabStripItem tabItem, String url )
        {
            if( url == "" )
            {
                url = BrowserConfig.NewTabUrl;
            }

            var _browser = new ChromiumWebBrowser( url );
            ConfigureBrowser( _browser );
            _browser.Dock = DockStyle.Fill;
            tabItem.Controls.Add( _browser );
            _browser.BringToFront( );
            _browser.StatusMessage += OnBrowserStatusUpdated;
            _browser.LoadingStateChanged += OnBrowserLoadingStateChange;
            _browser.TitleChanged += OnBrowserTitleChange;
            _browser.LoadError += OnBrowserLoadError;
            _browser.AddressChanged += OnBrowserAddressChanged;
            _browser.DownloadHandler = _downloadHandler;
            _browser.MenuHandler = _menuHandler;
            _browser.LifeSpanHandler = _lifeHandler;
            _browser.KeyboardHandler = _keyboardHandler;
            _browser.RequestHandler = _requestHandler;
            var _tab = new BrowserTab
            {
                IsOpen = true,
                Browser = _browser,
                Tab = tabItem,
                OriginalUrl = url,
                CurrentUrl = url,
                Title = "New Tab",
                DateCreated = DateTime.Now
            };

            tabItem.Tag = _tab;
            if( url.StartsWith( BrowserConfig.InternalUrl + ":" ) )
            {
                _browser.JavascriptObjectRepository.Register( "host", Host,
                    BindingOptions.DefaultBinder );
            }

            return _tab;
        }

        /// <summary>
        /// Handles the Load event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitAppIcon( );
                InitTooltips( Controls );
                InitHotkeys( );
                SetToolBarProperties( );
                SetTextBoxProperties( );
                SetComboBoxProperties( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// embedding the resource using the Visual Studio designer results in a blurry icon.
        /// the best way to get a non-blurry icon for Windows 7 apps.
        /// </summary>
        private void InitAppIcon( )
        {
            try
            {
                Assembly = Assembly.GetAssembly( typeof( WebBrowser ) );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// these hotkeys work when the user is focused on the .NET form and its controls,
        /// AND when the user is focused on the browser (CefSharp portion)
        /// </summary>
        private void InitHotkeys( )
        {
            try
            {
                KeyboardHandler.AddHotKey( this, CloseActiveTab, Keys.W, true );
                KeyboardHandler.AddHotKey( this, CloseActiveTab, Keys.Escape, true );
                KeyboardHandler.AddHotKey( this, AddBlankWindow, Keys.N, true );
                KeyboardHandler.AddHotKey( this, AddBlankTab, Keys.T, true );
                KeyboardHandler.AddHotKey( this, RefreshActiveTab, Keys.F5 );
                KeyboardHandler.AddHotKey( this, OpenDeveloperTools, Keys.F12 );
                KeyboardHandler.AddHotKey( this, NextTab, Keys.Tab, true );
                KeyboardHandler.AddHotKey( this, PreviousTab, Keys.Tab, true, true );
                KeyboardHandler.AddHotKey( this, OpenSearch, Keys.F, true );
                KeyboardHandler.AddHotKey( this, CloseSearch, Keys.Escape );
                KeyboardHandler.AddHotKey( this, StopActiveTab, Keys.Escape );
                KeyboardHandler.AddHotKey( this, ToggleFullscreen, Keys.F11 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// this is done just once, to globally initialize CefSharp/CEF
        /// </summary>
        private void InitBrowser( )
        {
            try
            {
                var _settings = new CefSettings( );
                _settings.RegisterScheme( new CefCustomScheme
                {
                    SchemeName = BrowserConfig.InternalUrl,
                    SchemeHandlerFactory = new SchemeHandlerFactory( )
                } );

                _settings.UserAgent = BrowserConfig.UserAgent;
                _settings.AcceptLanguageList = BrowserConfig.AcceptLanguage;
                _settings.IgnoreCertificateErrors = true;
                _settings.CachePath = GetAppDir( "Cache" );
                if( BrowserConfig.Proxy )
                {
                    CefSharpSettings.Proxy = new ProxyOptions( BrowserConfig.ProxyIp,
                        BrowserConfig.ProxyPort.ToString( ), BrowserConfig.ProxyUsername,
                        BrowserConfig.ProxyPassword, BrowserConfig.ProxyBypassList );
                }

                Cef.Initialize( _settings );
                _downloadHandler = new DownloadHandler( this );
                _lifeHandler = new LifeSpanHandler( this );
                _menuHandler = new ContextMenuHandler( this );
                _keyboardHandler = new KeyboardHandler( this );
                _requestHandler = new RequestHandler( this );
                InitDownloads( );
                Host = new HostHandler( this );
                AddNewBrowser( TabItem, BrowserConfig.HomepageUrl );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// this is done every time a new tab is opened
        /// </summary>
        /// <param name="browser">The browser.</param>
        private void ConfigureBrowser( ChromiumWebBrowser browser )
        {
            if( browser != null )
            {
                try
                {
                    var _config = new BrowserSettings( );
                    _config.WebGl = BrowserConfig.WebGl.ToCefState( );
                    browser.BrowserSettings = _config;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Gets the application dir.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        private static string GetAppDir( string name )
        {
            if( !string.IsNullOrEmpty( name ) )
            {
                try
                {
                    var _winXpDir = @"C:\Documents and Settings\All Users\Application Data\";
                    if( Directory.Exists( _winXpDir ) )
                    {
                        return _winXpDir + BrowserConfig.Branding + @"\" + name + @"\";
                    }

                    return @"C:\ProgramData\" + BrowserConfig.Branding + @"\" + name + @"\";
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Loads the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        private void LoadUrl( string url )
        {
            if( !string.IsNullOrEmpty( url ) )
            {
                try
                {
                    Uri _outUrl;
                    var _newUrl = url;
                    var _lower = url.Trim( ).ToLower( );

                    // UI
                    SetTabTitle( CurrentBrowser, "Loading..." );

                    // load page
                    if( _lower == "localhost" )
                    {
                        _newUrl = "http://localhost/";
                    }
                    else if( url.CheckIfFilePath( )
                            || url.CheckIfFilePath2( ) )
                    {
                        _newUrl = url.PathToURL( );
                    }
                    else
                    {
                        Uri.TryCreate( url, UriKind.Absolute, out _outUrl );
                        if( !( _lower.StartsWith( "http" )
                               || _lower.StartsWith( BrowserConfig.InternalUrl ) ) )
                        {
                            if( ( _outUrl == null )
                               || ( _outUrl.Scheme != Uri.UriSchemeFile ) )
                            {
                                _newUrl = "http://" + url;
                            }
                        }

                        if( _lower.StartsWith( BrowserConfig.InternalUrl + ":" )
                           || ( Uri.TryCreate( _newUrl, UriKind.Absolute, out _outUrl )
                               && ( ( ( ( _outUrl.Scheme == Uri.UriSchemeHttp )
                                           || ( _outUrl.Scheme == Uri.UriSchemeHttps ) )
                                       && _newUrl.Contains( "." ) )
                                   || ( _outUrl.Scheme == Uri.UriSchemeFile ) ) ) )
                        {
                        }
                        else
                        {
                            _newUrl = BrowserConfig.SearchUrl + HttpUtility.UrlEncode( url );
                        }
                    }

                    CurrentBrowser.Load( _newUrl );
                    SetFormUrl( _newUrl );
                    EnableBackButton( true );
                    EnableForwardButton( false );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the form title.
        /// </summary>
        /// <param name="tabName">Name of the tab.</param>
        private void SetFormTitle( string tabName )
        {
            if( !string.IsNullOrEmpty( tabName ) )
            {
                try
                {
                    if( tabName.CheckIfValid( ) )
                    {
                        Title.Text = tabName + " - " + BrowserConfig.Branding;
                        _currentTitle = tabName;
                    }
                    else
                    {
                        Title.Text = BrowserConfig.Branding;
                        _currentTitle = "New Tab";
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the form URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        private void SetFormUrl( string url )
        {
            if( !string.IsNullOrEmpty( url ) )
            {
                try
                {
                    _currentFullUrl = url;
                    _currentCleanUrl = CleanUrl( url );
                    AddressTextBox.Text = _currentCleanUrl;
                    CurrentTab.CurrentUrl = _currentFullUrl;
                    CloseSearch( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool strip properties.
        /// </summary>
        private void SetToolBarProperties( )
        {
            try
            {
                ToolStrip.Visible = true;
                ToolStrip.Text = string.Empty;
                ToolStrip.VisualStyle = ToolStripExStyle.Office2016Black;
                ToolStrip.Office12Mode = true;
                ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
                ToolStrip.LauncherStyle = LauncherStyle.Office2007;
                ToolStrip.ImageScalingSize = new Size( 16, 16 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the ComboBox properties.
        /// </summary>
        private void SetComboBoxProperties( )
        {
            try
            {
                // Website ComboBox Properties
                WebsiteComboBox.Font = new Font( "Roboto", 8, FontStyle.Bold );
                WebsiteComboBox.ForeColor = Color.White;
                WebsiteComboBox.Size = new Size( 175, 32 );

                // SearchEngine ComboBox Properties
                SearchEngineComboBox.Font = new Font( "Roboto", 8, FontStyle.Bold );
                SearchEngineComboBox.ForeColor = Color.White;
                SearchEngineComboBox.Size = new Size( 175, 32 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the tool strip properties.
        /// </summary>
        private void SetTextBoxProperties( )
        {
            try
            {
                // Header URL Search
                AddressTextBox.BackColor = Color.FromArgb( 75, 75, 75 );
                AddressTextBox.Font = new Font( "Roboto", 9, FontStyle.Bold );
                AddressTextBox.ForeColor = Color.White;
                AddressTextBox.BorderColor = Color.FromArgb( 0, 120, 212 );
                AddressTextBox.HoverColor = Color.FromArgb( 0, 120, 212 );

                // Key Word Dialog Search
                QuickSearchTextBox.BackColor = Color.FromArgb( 75, 75, 75 );
                AddressTextBox.Font = new Font( "Roboto", 9, FontStyle.Bold );
                AddressTextBox.ForeColor = Color.White;
                QuickSearchTextBox.BorderColor = Color.FromArgb( 0, 120, 212 );
                QuickSearchTextBox.HoverColor = Color.FromArgb( 0, 120, 212 );

                // Toolbar TextBox
                ToolBarTextBox.ForeColor = Color.White;
                ToolBarTextBox.Font = new Font( "Roboto", 9, FontStyle.Bold );
                ToolBarTextBox.TextBoxTextAlign = HorizontalAlignment.Center;
                ToolBarTextBox.BackColor = Color.FromArgb( 75, 75, 75 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the tab title.
        /// </summary>
        /// <param name="browser">The browser.</param>
        /// <param name="text">The text.</param>
        private void SetTabTitle( ChromiumWebBrowser browser, string text )
        {
            text = text.Trim( );
            if( IsBlank( text ) )
            {
                text = "New Tab";
            }

            browser.Tag = text;
            var _tabStrip = (BrowserTabStripItem)browser.Parent;
            _tabStrip.Title = text;
            if( browser == CurrentBrowser )
            {
                SetFormTitle( text );
            }
        }

        /// <summary>
        /// Cleans the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private string CleanUrl( string url )
        {
            try
            {
                if( url.BeginsWith( "about:" ) )
                {
                    return "";
                }

                url = url.RemovePrefix( "http://" );
                url = url.RemovePrefix( "https://" );
                url = url.RemovePrefix( "file://" );
                url = url.RemovePrefix( "/" );
                return url.UrlDecode( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Determines whether the specified URL is blank.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        ///   <c>true</c> if the specified URL is blank; otherwise, <c>false</c>.
        /// </returns>
        private bool IsBlank( string url )
        {
            return ( url == "" ) || ( url == "about:blank" );
        }

        /// <summary>
        /// Determines whether [is blank or system] [the specified URL].
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        ///   <c>true</c> if [is blank or system] [the specified URL]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsBlankOrSystem( string url )
        {
            return ( url == "" )
                || url.BeginsWith( "about:" )
                || url.BeginsWith( "chrome:" )
                || url.BeginsWith( BrowserConfig.InternalUrl + ":" );
        }

        /// <summary>
        /// Toggles the fullscreen.
        /// </summary>
        private void ToggleFullscreen( )
        {
            if( !_isFullScreen )
            {
                _windowState = WindowState;
                _borderStyle = FormBorderStyle;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                _isFullScreen = true;
            }
            else
            {
                FormBorderStyle = _borderStyle;
                WindowState = _windowState;
                _isFullScreen = false;
            }
        }

        /// <summary>
        /// Stops the active tab.
        /// </summary>
        private void StopActiveTab( )
        {
            try
            {
                CurrentBrowser.Stop( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Determines whether [is on first tab].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is on first tab]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsOnFirstTab( )
        {
            return TabPages.SelectedItem == TabPages.Items[ 0 ];
        }

        /// <summary>
        /// Determines whether [is on last tab].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is on last tab]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsOnLastTab( )
        {
            return TabPages.SelectedItem == TabPages.Items[ ^2 ];
        }

        /// <summary>
        /// Next tab.
        /// </summary>
        private void NextTab( )
        {
            if( IsOnLastTab( ) )
            {
                CurrentIndex = 0;
            }
            else
            {
                CurrentIndex++;
            }
        }

        /// <summary>
        /// Previous  the tab.
        /// </summary>
        private void PreviousTab( )
        {
            if( IsOnFirstTab( ) )
            {
                CurrentIndex = LastIndex;
            }
            else
            {
                CurrentIndex--;
            }
        }

        /// <summary>
        /// Enables the back button.
        /// </summary>
        /// <param name="canGoBack">if set to <c>true</c> [can go back].</param>
        private void EnableBackButton( bool canGoBack )
        {
            try
            {
                InvokeIfNeeded( ( ) => PreviousButton.Enabled = canGoBack );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Enables the forward button.
        /// </summary>
        /// <param name="canGoForward">if set to <c>true</c> [can go forward].</param>
        private void EnableForwardButton( bool canGoForward )
        {
            try
            {
                InvokeIfNeeded( ( ) => NextButton.Enabled = canGoForward );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the developer tools.
        /// </summary>
        private void OpenDeveloperTools( )
        {
            try
            {
                CurrentBrowser.ShowDevTools( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// we must store download metadata in a list, since CefSharp does not
        /// </summary>
        private void InitDownloads( )
        {
            try
            {
                Downloads = new Dictionary<int, DownloadItem>( );
                DownloadNames = new Dictionary<int, string>( );
                CancelRequests = new List<int>( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the search.
        /// </summary>
        private void OpenSearch( )
        {
            if( !_searchOpen )
            {
                _searchOpen = true;
                InvokeIfNeeded( delegate
                {
                    QuickSearchPanel.Visible = true;
                    QuickSearchTextBox.Text = _lastSearch;
                    QuickSearchTextBox.Focus( );
                    QuickSearchTextBox.SelectAll( );
                } );
            }
            else
            {
                InvokeIfNeeded( delegate
                {
                    QuickSearchTextBox.Focus( );
                    QuickSearchTextBox.SelectAll( );
                } );
            }
        }

        /// <summary>
        /// Closes the search.
        /// </summary>
        private void CloseSearch( )
        {
            if( _searchOpen )
            {
                _searchOpen = false;
                InvokeIfNeeded( delegate
                {
                    QuickSearchPanel.Visible = false;
                    CurrentBrowser.GetBrowser( )?.StopFinding( true );
                } );
            }
        }

        /// <summary>
        /// Finds the text on page.
        /// </summary>
        /// <param name="next">if set to <c>true</c> [next].</param>
        private void FindTextOnPage( bool next = true )
        {
            var _first = _lastSearch != QuickSearchTextBox.Text;
            _lastSearch = QuickSearchTextBox.Text;
            if( _lastSearch.CheckIfValid( ) )
            {
                CurrentBrowser.GetBrowser( )?.Find( _lastSearch, true, false, !_first );
            }
            else
            {
                CurrentBrowser.GetBrowser( )?.StopFinding( true );
            }

            QuickSearchTextBox.Focus( );
        }

        /// <summary>
        /// Handles the URLChanged event of the Browser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="AddressChangedEventArgs"/> instance containing the event data.</param>
        private void OnBrowserAddressChanged( object sender, AddressChangedEventArgs e )
        {
            InvokeIfNeeded( ( ) =>
            {
                if( sender == CurrentBrowser )
                {
                    if( !WebUtils.IsFocused( AddressTextBox ) )
                    {
                        SetFormUrl( e.Address );
                    }

                    EnableBackButton( CurrentBrowser.CanGoBack );
                    EnableForwardButton( CurrentBrowser.CanGoForward );
                    SetTabTitle( (ChromiumWebBrowser)sender, "Loading..." );
                    RefreshButton.Visible = false;
                    StopButton.Visible = true;
                    CurrentTab.DateCreated = DateTime.Now;
                }
            } );
        }

        /// <summary>
        /// Called when [tab closed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTabClosed( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Raises the <see cref="E:TabClosing" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabStripItemClosingEventArgs"/> instance containing the event data.</param>
        private void OnTabClosing( TabStripItemClosingEventArgs e )
        {
            if( CurrentTab == null )
            {
                e.Cancel = true;
                return;
            }

            if( TabPages.Items.Count <= 2 )
            {
                AddBlankTab( );
            }
        }

        /// <summary>
        /// Handles the LoadError event of the Browser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LoadErrorEventArgs"/> instance containing the event data.</param>
        private void OnBrowserLoadError( object sender, LoadErrorEventArgs e )
        {
            try
            {
                // ("Load Error:" + e.ErrorCode + ";" + e.ErrorText);
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Handles the TitleChanged event of the Browser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TitleChangedEventArgs"/> instance containing the event data.</param>
        private void OnBrowserTitleChange( object sender, TitleChangedEventArgs e )
        {
            InvokeIfNeeded( ( ) =>
            {
                var _browser = (ChromiumWebBrowser)sender;
                SetTabTitle( _browser, e.Title );
            } );
        }

        /// <summary>
        /// Handles the LoadingStateChanged event of the Browser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LoadingStateChangedEventArgs"/> instance containing the event data.</param>
        private void OnBrowserLoadingStateChange( object sender, LoadingStateChangedEventArgs e )
        {
            if( sender == CurrentBrowser )
            {
                EnableBackButton( e.CanGoBack );
                EnableForwardButton( e.CanGoForward );
                if( e.IsLoading )
                {
                    //SetTabTitle( CurrentBrowser, "" );
                }
                else
                {
                    InvokeIfNeeded( ( ) =>
                    {
                        RefreshButton.Visible = true;
                        StopButton.Visible = false;
                    } );
                }
            }
        }

        /// <summary>
        /// Handles the StatusMessage event of the Browser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="StatusMessageEventArgs"/> instance containing the event data.</param>
        private void OnBrowserStatusUpdated( object sender, StatusMessageEventArgs e )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnHome control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnHomeButtonClicked( object sender, EventArgs e )
        {
            try
            {
                CurrentBrowser.Load( BrowserConfig.HomepageUrl );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Raises the <see cref="E:TabItemChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabStripItemChangedEventArgs"/> instance containing the event data.</param>
        private void OnTabItemChanged( TabStripItemChangedEventArgs e )
        {
            ChromiumWebBrowser _browser = null;
            try
            {
                _browser = (ChromiumWebBrowser)e.Item.Controls[ 0 ];
            }
            catch( Exception )
            {
            }

            try
            {
                if( e.ChangeType == BrowserTabStripItemChangeTypes.SelectionChanged )
                {
                    if( TabPages.SelectedItem == AddItem )
                    {
                        AddBlankTab( );
                    }
                    else
                    {
                        _browser = CurrentBrowser;
                        SetFormUrl( _browser.Address );
                        SetFormTitle( _browser.Tag.ConvertToString( ) ?? "New Tab" );
                        EnableBackButton( _browser.CanGoBack );
                        EnableForwardButton( _browser.CanGoForward );
                    }
                }

                if( e.ChangeType == BrowserTabStripItemChangeTypes.Removed )
                {
                    if( e.Item == _downloadsStrip )
                    {
                        _downloadsStrip = null;
                    }

                    _browser?.Dispose( );
                }

                if( e.ChangeType == BrowserTabStripItemChangeTypes.Changed )
                {
                    if( _browser != null )
                    {
                        if( _currentFullUrl != "about:blank" )
                        {
                            _browser.Focus( );
                        }
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [timer tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTimerTick( object sender, EventArgs e )
        {
            try
            {
                TabPages.SelectedItem = TabItem;
                Timer.Enabled = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [close menu clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCloseMenuClicked( object sender, EventArgs e )
        {
            CloseActiveTab( );
        }

        /// <summary>
        /// Called when [web close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnWebCloseButtonClicked( object sender, EventArgs e )
        {
            Close( );
        }

        /// <summary>
        /// Called when [close others clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCloseOtherTabsButtonClicked( object sender, EventArgs e )
        {
            var _list = new List<BrowserTabStripItem>( );
            foreach( BrowserTabStripItem _tab in TabPages.Items )
            {
                if( ( _tab != AddItem )
                   && ( _tab != TabPages.SelectedItem ) )
                {
                    _list.Add( _tab );
                }
            }

            foreach( var _tab in _list )
            {
                TabPages.RemoveTab( _tab );
            }
        }

        /// <summary>
        /// Called when [back button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnPreviousButtonClicked( object sender, EventArgs e )
        {
            try
            {
                CurrentBrowser.Back( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [forward button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnNextButtonClicked( object sender, EventArgs e )
        {
            try
            {
                CurrentBrowser.Forward( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [URL changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnUrlChanged( object sender, EventArgs e )
        {
            LoadUrl( AddressTextBox.Text );
        }

        /// <summary>
        /// Called when [download button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnAddTabButtonClicked( object sender, EventArgs e )
        {
            AddNewBrowserTab( BrowserConfig.HomepageUrl );
        }

        /// <summary>
        /// Called when [refresh button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnRefreshButtonClicked( object sender, EventArgs e )
        {
            RefreshActiveTab( );
        }

        /// <summary>
        /// Called when [stop button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnStopButtonClicked( object sender, EventArgs e )
        {
            StopActiveTab( );
        }

        /// <summary>
        /// Called when [URL down button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void OnUrlDownButtonClicked( object sender, KeyEventArgs e )
        {
            if( e.IsHotKey( Keys.Enter )
               || e.IsHotKey( Keys.Enter, true ) )
            {
                LoadUrl( AddressTextBox.Text );
                e.Handled = true;
                e.SuppressKeyPress = true;
                Focus( );
            }

            if( e.IsHotKey( Keys.C, true )
               && WebUtils.IsFullySelected( AddressTextBox ) )
            {
                Clipboard.SetText( CurrentBrowser.Address, TextDataFormat.UnicodeText );
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// Called when [URL text box clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnUrlTextBoxClicked( object sender, EventArgs e )
        {
            try
            {
                if( !WebUtils.HasSelection( AddressTextBox ) )
                {
                    AddressTextBox.SelectAll( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [tab pages mouse clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void OnTabPagesMouseClicked( object sender, MouseEventArgs e )
        {
            /*if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                tabPages.GetTabItemByPoint(this.mouse
            }*/
        }

        /// <summary>
        /// Called when [WebBrowser closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void OnWebBrowserClosing( object sender, FormClosingEventArgs e )
        {
            if( DownloadsInProgress( ) )
            {
                if( MessageBox.Show( "Downloads are in progress. Cancel those and exit?",
                       "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question )
                   != DialogResult.Yes )
                {
                    e.Cancel = true;
                    return;
                }
            }

            try
            {
                foreach( BrowserTabStripItem _tab in TabPages.Items )
                {
                    var _browser = (ChromiumWebBrowser)_tab.Controls[ 0 ];
                    _browser.Dispose( );
                }
            }
            catch( Exception )
            {
            }
        }

        /// <summary>
        /// open a new tab with the downloads URL
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnDownloadButtonClicked( object sender, EventArgs e )
        {
            OpenDownloadsTab( );
        }

        /// <summary>
        /// Handles the Click event of the BtnClearSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSearchStopButtonClicked( object sender, EventArgs e )
        {
            CloseSearch( );
        }

        /// <summary>
        /// Handles the Click event of the BtnPrevSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSearchPreviousButtonClicked( object sender, EventArgs e )
        {
            FindTextOnPage( false );
        }

        /// <summary>
        /// Handles the Click event of the BtnNextSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSearchNextButtonClicked( object sender, EventArgs e )
        {
            FindTextOnPage( true );
        }

        /// <summary>
        /// Handles the TextChanged event of the SearchTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSearchTextChanged( object sender, EventArgs e )
        {
            FindTextOnPage( true );
        }

        /// <summary>
        /// Handles the KeyDown event of the SearchTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void OnKeyDown( object sender, KeyEventArgs e )
        {
            if( e.IsHotKey( Keys.Enter ) )
            {
                FindTextOnPage( true );
            }

            if( e.IsHotKey( Keys.Enter, true )
               || e.IsHotKey( Keys.Enter, false, true ) )
            {
                FindTextOnPage( false );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
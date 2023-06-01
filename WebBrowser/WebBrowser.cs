// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
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
    using Browser;
    using System;
    using System.Windows.Forms;
    using System.Threading;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.IO;
    using System.Web;
    using CefSharp;
    using CefSharp.WinForms;
    using System.Reflection;
    using Syncfusion.Windows.Forms;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The main SharpBrowser form, supporting multiple tabs.
    /// We used the x86 version of CefSharp, so the app works on 32-bit and 64-bit machines.
    /// If you would only like to support 64-bit machines, simply change the DLL references.
    /// </summary>
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    [ SuppressMessage( "ReSharper", "EmptyGeneralCatchClause" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "CanSimplifyDictionaryLookupWithTryGetValue" ) ]
    internal partial class WebBrowser : MetroForm
    {
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
        private string _currentCleanURL;

        /// <summary>
        /// The current full URL
        /// </summary>
        private string _currentFullURL;

        /// <summary>
        /// The current title
        /// </summary>
        private string _currentTitle;

        /// <summary>
        /// The d handler
        /// </summary>
        private DownloadHandler _dHandler;

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
        private KeyboardHandler _kHandler;

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
        /// The r handler
        /// </summary>
        private RequestHandler _requestHandler;

        /// <summary>
        /// The search open
        /// </summary>
        private bool _searchOpen;

        /// <summary>
        /// The new strip
        /// </summary>
        private BrowserTabStripItem _tabItem;

        /// <summary>
        /// The old window state
        /// </summary>
        private FormWindowState _windowState;

        /// <summary>
        /// The download cancel requests
        /// </summary>
        public List<int> DownloadCancelRequests;

        /// <summary>
        /// The download names
        /// </summary>
        public Dictionary<int, string> DownloadNames;

        /// <summary>
        /// The downloads
        /// </summary>
        public Dictionary<int, DownloadItem> downloads;

        /// <summary>
        /// The host
        /// </summary>
        public HostHandler Host;

        /// <summary>
        /// Gets or sets the index of the current.
        /// </summary>
        /// <value>
        /// The index of the current.
        /// </value>
        private int CurIndex
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

        /// <summary>
        /// Gets the current browser.
        /// </summary>
        /// <value>
        /// The current browser.
        /// </value>
        public ChromiumWebBrowser CurBrowser
        {
            get
            {
                if( ( TabPages.SelectedItem != null )
                   && ( TabPages.SelectedItem.Tag != null ) )
                {
                    return ( (BrowserTab)TabPages.SelectedItem.Tag ).Browser;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets the current tab.
        /// </summary>
        /// <value>
        /// The current tab.
        /// </value>
        public BrowserTab CurTab
        {
            get
            {
                if( ( TabPages.SelectedItem != null )
                   && ( TabPages.SelectedItem.Tag != null ) )
                {
                    return (BrowserTab)TabPages.SelectedItem.Tag;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets the current tab loading dur.
        /// </summary>
        /// <value>
        /// The current tab loading dur.
        /// </value>
        public int CurTabLoadingDur
        {
            get
            {
                if( ( TabPages.SelectedItem != null )
                   && ( TabPages.SelectedItem.Tag != null ) )
                {
                    var loadTime = (int)( DateTime.Now - CurTab.DateCreated ).TotalMilliseconds;
                    return loadTime;
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
        public List<int> CancelRequests
        {
            get { return DownloadCancelRequests; }
        }

        /// <summary>
        /// Gets the downloads.
        /// </summary>
        /// <value>
        /// The downloads.
        /// </value>
        public Dictionary<int, DownloadItem> Downloads
        {
            get { return downloads; }
        }

        /// <summary>
        /// The instance
        /// </summary>
        public static WebBrowser Instance;

        /// <summary>
        /// The assembly
        /// </summary>
        public static Assembly Assembly;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebBrowser"/> class.
        /// </summary>
        public WebBrowser( )
        {
            Instance = this;
            InitializeComponent( );
            InitBrowser( );
            SetFormTitle( null );
        }

        /// <summary>
        /// Gets the resource stream.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="withNamespace">if set to <c>true</c> [with namespace].</param>
        /// <returns></returns>
        public Stream GetResourceStream( string filename, bool withNamespace = true )
        {
            try
            {
                return Assembly.GetManifestResourceStream( "SharpBrowser.Resources." + filename );
            }
            catch( Exception ex ) { }

            return null;
        }

        /// <summary>
        /// we activate all the tooltips stored in the Tag property of the buttons
        /// </summary>
        /// <param name="parent">The parent.</param>
        public void InitTooltips( Control.ControlCollection parent )
        {
            foreach( Control ui in parent )
            {
                var btn = ui as Button;
                if( btn?.Tag != null )
                {
                    var tip = new ToolTip( );
                    tip.ReshowDelay = tip.InitialDelay = 200;
                    tip.ShowAlways = true;
                    tip.SetToolTip( btn, btn.Tag.ToString( ) );
                }

                if( ui is Panel panel )
                {
                    InitTooltips( panel.Controls );
                }
            }
        }

        /// <summary>
        /// Adds the blank window.
        /// </summary>
        public void AddBlankWindow( )
        {
            var info = new ProcessStartInfo( Application.ExecutablePath, "" );
            info.LoadUserProfile = true;
            info.UseShellExecute = false;
            info.RedirectStandardError = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardInput = true;
            Process.Start( info );
        }

        /// <summary>
        /// Adds the blank tab.
        /// </summary>
        public void AddBlankTab( )
        {
            AddNewBrowserTab( "" );
            this.InvokeOnParent( delegate
            {
                AddressTextBox.Focus( );
            } );
        }

        /// <summary>
        /// Adds the new browser tab.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="focusNewTab">if set to <c>true</c> [focus new tab].</param>
        /// <param name="refererUrl">The referer URL.</param>
        /// <returns></returns>
        public ChromiumWebBrowser AddNewBrowserTab(
            string url, bool focusNewTab = true, string refererUrl = null )
        {
            return Invoke( delegate
            {
                foreach( BrowserTabStripItem tab in TabPages.Items )
                {
                    var tab2 = (BrowserTab)tab.Tag;
                    if( ( tab2 != null )
                       && ( tab2.CurURL == url ) )
                    {
                        TabPages.SelectedItem = tab;
                        return tab2.Browser;
                    }
                }

                var tabStrip = new BrowserTabStripItem( );
                tabStrip.Title = "New Tab";
                TabPages.Items.Insert( TabPages.Items.Count - 1, tabStrip );
                _tabItem = tabStrip;
                var newTab = AddNewBrowser( _tabItem, url );
                newTab.RefererURL = refererUrl;
                if( focusNewTab )
                {
                    Timer.Enabled = true;
                }

                return newTab.Browser;
            } );
        }

        /// <summary>
        /// Gets the tab by browser.
        /// </summary>
        /// <param name="browser">The browser.</param>
        /// <returns></returns>
        public BrowserTab GetTabByBrowser( IWebBrowser browser )
        {
            foreach( BrowserTabStripItem tab2 in TabPages.Items )
            {
                var tab = (BrowserTab)tab2.Tag;
                if( ( tab != null )
                   && ( tab.Browser == browser ) )
                {
                    return tab;
                }
            }

            return null;
        }

        /// <summary>
        /// Refreshes the active tab.
        /// </summary>
        public void RefreshActiveTab( )
        {
            CurBrowser.Load( CurBrowser.Address );
        }

        /// <summary>
        /// Closes the active tab.
        /// </summary>
        public void CloseActiveTab( )
        {
            if( CurTab != null/* && TabPages.Items.Count > 2*/ )
            {
                var index = TabPages.Items.IndexOf( TabPages.SelectedItem );
                TabPages.RemoveTab( TabPages.SelectedItem );
                if( TabPages.Items.Count - 1 > index )
                {
                    TabPages.SelectedItem = TabPages.Items[ index ];
                }
            }
        }

        /// <summary>
        /// Gets all tabs.
        /// </summary>
        /// <returns></returns>
        public List<BrowserTab> GetAllTabs( )
        {
            var tabs = new List<BrowserTab>( );
            foreach( BrowserTabStripItem tabPage in TabPages.Items )
            {
                if( tabPage.Tag != null )
                {
                    tabs.Add( (BrowserTab)tabPage.Tag );
                }
            }

            return tabs;
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
        public void InvokeIfNeeded( Action action )
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
            lock( downloads )
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

                downloads[ item.Id ] = item;
            }
        }

        /// <summary>
        /// Calculates the download path.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public string CalcDownloadPath( DownloadItem item )
        {
            return item.SuggestedFileName;
        }

        /// <summary>
        /// Downloadses the in progress.
        /// </summary>
        /// <returns></returns>
        public bool DownloadsInProgress( )
        {
            foreach( var item in downloads.Values )
            {
                if( item.IsInProgress )
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Opens the downloads tab.
        /// </summary>
        public void OpenDownloadsTab( )
        {
            if( ( _downloadsStrip != null )
               && ( ( (ChromiumWebBrowser)_downloadsStrip.Controls[ 0 ] ).Address
                   == BrowserConfig.DownloadsURL ) )
            {
                TabPages.SelectedItem = _downloadsStrip;
            }
            else
            {
                var brw = AddNewBrowserTab( BrowserConfig.DownloadsURL );
                _downloadsStrip = (BrowserTabStripItem)brw.Parent;
            }
        }

        /// <summary>
        /// Handles the Load event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load( object sender, EventArgs e )
        {
            InitAppIcon( );
            InitTooltips( Controls );
            InitHotkeys( );
        }

        /// <summary>
        /// Handles the Click event of the BtnHome control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnHome_Click( object sender, EventArgs e )
        {
            CurBrowser.Load( BrowserConfig.HomepageURL );
        }

        /// <summary>
        /// embedding the resource using the Visual Studio designer results in a blurry icon.
        /// the best way to get a non-blurry icon for Windows 7 apps.
        /// </summary>
        private void InitAppIcon( )
        {
            Assembly = Assembly.GetAssembly( typeof( WebBrowser ) );
        }

        /// <summary>
        /// these hotkeys work when the user is focused on the .NET form and its controls,
        /// AND when the user is focused on the browser (CefSharp portion)
        /// </summary>
        private void InitHotkeys( )
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

        /// <summary>
        /// this is done just once, to globally initialize CefSharp/CEF
        /// </summary>
        private void InitBrowser( )
        {
            var _settings = new CefSettings( );
            _settings.RegisterScheme( new CefCustomScheme
            {
                SchemeName = BrowserConfig.InternalURL,
                SchemeHandlerFactory = new SchemeHandlerFactory( )
            } );

            _settings.UserAgent = BrowserConfig.UserAgent;
            _settings.AcceptLanguageList = BrowserConfig.AcceptLanguage;
            _settings.IgnoreCertificateErrors = true;
            _settings.CachePath = GetAppDir( "Cache" );
            if( BrowserConfig.Proxy )
            {
                CefSharpSettings.Proxy = new ProxyOptions( BrowserConfig.ProxyIP,
                    BrowserConfig.ProxyPort.ToString( ), BrowserConfig.ProxyUsername,
                    BrowserConfig.ProxyPassword, BrowserConfig.ProxyBypassList );
            }

            Cef.Initialize( _settings );
            _dHandler = new DownloadHandler( this );
            _lifeHandler = new LifeSpanHandler( this );
            _menuHandler = new ContextMenuHandler( this );
            _kHandler = new KeyboardHandler( this );
            _requestHandler = new RequestHandler( this );
            InitDownloads( );
            Host = new HostHandler( this );
            AddNewBrowser( TabStripItem, BrowserConfig.HomepageURL );
        }

        /// <summary>
        /// this is done every time a new tab is opened
        /// </summary>
        /// <param name="browser">The browser.</param>
        private void ConfigureBrowser( ChromiumWebBrowser browser )
        {
            var config = new BrowserSettings( );
            config.WebGl = BrowserConfig.WebGL.ToCefState( );
            browser.BrowserSettings = config;
        }

        /// <summary>
        /// Gets the application dir.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        private static string GetAppDir( string name )
        {
            var winXPDir = @"C:\Documents and Settings\All Users\Application Data\";
            if( Directory.Exists( winXPDir ) )
            {
                return winXPDir + BrowserConfig.Branding + @"\" + name + @"\";
            }

            return @"C:\ProgramData\" + BrowserConfig.Branding + @"\" + name + @"\";
        }

        /// <summary>
        /// Loads the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        private void LoadURL( string url )
        {
            var newUrl = url;
            var urlLower = url.Trim( ).ToLower( );

            // UI
            SetTabTitle( CurBrowser, "Loading..." );

            // load page
            if( urlLower == "localhost" )
            {
                newUrl = "http://localhost/";
            }
            else if( url.CheckIfFilePath( )
                    || url.CheckIfFilePath2( ) )
            {
                newUrl = url.PathToURL( );
            }
            else
            {
                Uri.TryCreate( url, UriKind.Absolute, out var outUri );
                if( !( urlLower.StartsWith( "http" )
                       || urlLower.StartsWith( BrowserConfig.InternalURL ) ) )
                {
                    if( ( outUri == null )
                       || ( outUri.Scheme != Uri.UriSchemeFile ) )
                    {
                        newUrl = "http://" + url;
                    }
                }

                if( urlLower.StartsWith( BrowserConfig.InternalURL + ":" )
                   || ( Uri.TryCreate( newUrl, UriKind.Absolute, out outUri )
                       && ( ( ( ( outUri.Scheme == Uri.UriSchemeHttp )
                                   || ( outUri.Scheme == Uri.UriSchemeHttps ) )
                               && newUrl.Contains( "." ) )
                           || ( outUri.Scheme == Uri.UriSchemeFile ) ) ) )
                {
                }
                else
                {
                    newUrl = BrowserConfig.SearchURL + HttpUtility.UrlEncode( url );
                }
            }

            CurBrowser.Load( newUrl );
            SetFormURL( newUrl );
            EnableBackButton( true );
            EnableForwardButton( false );
        }

        /// <summary>
        /// Sets the form title.
        /// </summary>
        /// <param name="tabName">Name of the tab.</param>
        private void SetFormTitle( string tabName )
        {
            if( tabName.CheckIfValid( ) )
            {
                Text = tabName + " - " + BrowserConfig.Branding;
                _currentTitle = tabName;
            }
            else
            {
                Text = BrowserConfig.Branding;
                _currentTitle = "New Tab";
            }
        }

        /// <summary>
        /// Sets the form URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        private void SetFormURL( string url )
        {
            _currentFullURL = url;
            _currentCleanURL = CleanURL( url );
            AddressTextBox.Text = _currentCleanURL;
            CurTab.CurURL = _currentFullURL;
            CloseSearch( );
        }

        /// <summary>
        /// Cleans the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private string CleanURL( string url )
        {
            if( url.BeginsWith( "about:" ) )
            {
                return "";
            }

            url = url.RemovePrefix( "http://" );
            url = url.RemovePrefix( "https://" );
            url = url.RemovePrefix( "file://" );
            url = url.RemovePrefix( "/" );
            return url.DecodeURL( );
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
                || url.BeginsWith( BrowserConfig.InternalURL + ":" );
        }

        /// <summary>
        /// Adds the new browser.
        /// </summary>
        /// <param name="tabStrip">The tab strip.</param>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private BrowserTab AddNewBrowser( BrowserTabStripItem tabStrip, String url )
        {
            if( url == "" )
            {
                url = BrowserConfig.NewTabURL;
            }

            var browser = new ChromiumWebBrowser( url );
            ConfigureBrowser( browser );
            browser.Dock = DockStyle.Fill;
            tabStrip.Controls.Add( browser );
            browser.BringToFront( );
            browser.StatusMessage += OnBrowserStatusUpdated;
            browser.LoadingStateChanged += OnBrowserLoadingStateChanged;
            browser.TitleChanged += OnBrowserTitleChanged;
            browser.LoadError += OnBrowserLoadError;
            browser.AddressChanged += OnBrowserAddressChanged;
            browser.DownloadHandler = _dHandler;
            browser.MenuHandler = _menuHandler;
            browser.LifeSpanHandler = _lifeHandler;
            browser.KeyboardHandler = _kHandler;
            browser.RequestHandler = _requestHandler;
            var tab = new BrowserTab
            {
                IsOpen = true,
                Browser = browser,
                Tab = tabStrip,
                OrigURL = url,
                CurURL = url,
                Title = "New Tab",
                DateCreated = DateTime.Now
            };

            tabStrip.Tag = tab;
            if( url.StartsWith( BrowserConfig.InternalURL + ":" ) )
            {
                browser.JavascriptObjectRepository.Register( "host", Host,
                    BindingOptions.DefaultBinder );
            }

            return tab;
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
        /// Called when [tab closed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTabClosed( object sender, EventArgs e )
        {
        }

        /// <summary>
        /// Raises the <see cref="E:TabClosing" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabStripItemClosingEventArgs"/> instance containing the event data.</param>
        private void OnTabClosing( TabStripItemClosingEventArgs e )
        {
            if( CurTab == null )
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
        /// Stops the active tab.
        /// </summary>
        private void StopActiveTab( )
        {
            CurBrowser.Stop( );
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
        /// Nexts the tab.
        /// </summary>
        private void NextTab( )
        {
            if( IsOnLastTab( ) )
            {
                CurIndex = 0;
            }
            else
            {
                CurIndex++;
            }
        }

        /// <summary>
        /// Previouses the tab.
        /// </summary>
        private void PreviousTab( )
        {
            if( IsOnFirstTab( ) )
            {
                CurIndex = LastIndex;
            }
            else
            {
                CurIndex--;
            }
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
                if( sender == CurBrowser )
                {
                    if( !Utils.IsFocussed( AddressTextBox ) )
                    {
                        SetFormURL( e.Address );
                    }

                    EnableBackButton( CurBrowser.CanGoBack );
                    EnableForwardButton( CurBrowser.CanGoForward );
                    SetTabTitle( (ChromiumWebBrowser)sender, "Loading..." );
                    RefreshButton.Visible = false;
                    StopButton.Visible = true;
                    CurTab.DateCreated = DateTime.Now;
                }
            } );
        }

        /// <summary>
        /// Handles the LoadError event of the Browser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LoadErrorEventArgs"/> instance containing the event data.</param>
        private void OnBrowserLoadError( object sender, LoadErrorEventArgs e )
        {
            // ("Load Error:" + e.ErrorCode + ";" + e.ErrorText);
        }

        /// <summary>
        /// Handles the TitleChanged event of the Browser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TitleChangedEventArgs"/> instance containing the event data.</param>
        private void OnBrowserTitleChanged( object sender, TitleChangedEventArgs e )
        {
            InvokeIfNeeded( ( ) =>
            {
                var browser = (ChromiumWebBrowser)sender;
                SetTabTitle( browser, e.Title );
            } );
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
            var tabStrip = (BrowserTabStripItem)browser.Parent;
            tabStrip.Title = text;
            if( browser == CurBrowser )
            {
                SetFormTitle( text );
            }
        }

        /// <summary>
        /// Handles the LoadingStateChanged event of the Browser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LoadingStateChangedEventArgs"/> instance containing the event data.</param>
        private void OnBrowserLoadingStateChanged( object sender, LoadingStateChangedEventArgs e )
        {
            if( sender == CurBrowser )
            {
                EnableBackButton( e.CanGoBack );
                EnableForwardButton( e.CanGoForward );
                if( e.IsLoading )
                {
                    // set title
                    //SetTabTitle();
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
        }

        /// <summary>
        /// Enables the back button.
        /// </summary>
        /// <param name="canGoBack">if set to <c>true</c> [can go back].</param>
        private void EnableBackButton( bool canGoBack )
        {
            InvokeIfNeeded( ( ) => PreviousButton.Enabled = canGoBack );
        }

        /// <summary>
        /// Enables the forward button.
        /// </summary>
        /// <param name="canGoForward">if set to <c>true</c> [can go forward].</param>
        private void EnableForwardButton( bool canGoForward )
        {
            InvokeIfNeeded( ( ) => NextButton.Enabled = canGoForward );
        }

        /// <summary>
        /// Raises the <see cref="E:TabItemChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="TabStripItemChangedEventArgs"/> instance containing the event data.</param>
        private void OnTabItemChanged( TabStripItemChangedEventArgs e )
        {
            ChromiumWebBrowser browser = null;
            try
            {
                browser = (ChromiumWebBrowser)e.Item.Controls[ 0 ];
            }
            catch( Exception ex )
            {
            }

            if( e.ChangeType == BrowserTabStripItemChangeTypes.SelectionChanged )
            {
                if( TabPages.SelectedItem == TabStripAdd )
                {
                    AddBlankTab( );
                }
                else
                {
                    browser = CurBrowser;
                    SetFormURL( browser.Address );
                    SetFormTitle( browser.Tag.ConvertToString( ) ?? "New Tab" );
                    EnableBackButton( browser.CanGoBack );
                    EnableForwardButton( browser.CanGoForward );
                }
            }

            if( e.ChangeType == BrowserTabStripItemChangeTypes.Removed )
            {
                if( e.Item == _downloadsStrip )
                {
                    _downloadsStrip = null;
                }

                browser?.Dispose( );
            }

            if( e.ChangeType == BrowserTabStripItemChangeTypes.Changed )
            {
                if( browser != null )
                {
                    if( _currentFullURL != "about:blank" )
                    {
                        browser.Focus( );
                    }
                }
            }
        }

        /// <summary>
        /// Called when [timer tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTimerTick( object sender, EventArgs e )
        {
            TabPages.SelectedItem = _tabItem;
            Timer.Enabled = false;
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
        /// Called when [close others clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCloseOtherTabsButtonClicked( object sender, EventArgs e )
        {
            var _list = new List<BrowserTabStripItem>( );
            foreach( BrowserTabStripItem tab in TabPages.Items )
            {
                if( ( tab != TabStripAdd )
                   && ( tab != TabPages.SelectedItem ) )
                {
                    _list.Add( tab );
                }
            }

            foreach( var tab in _list )
            {
                TabPages.RemoveTab( tab );
            }
        }

        /// <summary>
        /// Called when [back button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnBackButtonClicked( object sender, EventArgs e )
        {
            CurBrowser.Back( );
        }

        /// <summary>
        /// Called when [forward button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnForwardButtonClicked( object sender, EventArgs e )
        {
            CurBrowser.Forward( );
        }

        /// <summary>
        /// Called when [URL changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnUrlChanged( object sender, EventArgs e )
        {
        }

        /// <summary>
        /// Called when [download button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnAddTabButtonClicked( object sender, EventArgs e )
        {
            AddNewBrowserTab( BrowserConfig.DownloadsURL );
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
            if( e.IsHotkey( Keys.Enter )
               || e.IsHotkey( Keys.Enter, true ) )
            {
                LoadURL( AddressTextBox.Text );
                e.Handled = true;
                e.SuppressKeyPress = true;
                Focus( );
            }

            if( e.IsHotkey( Keys.C, true )
               && Utils.IsFullySelected( AddressTextBox ) )
            {
                Clipboard.SetText( CurBrowser.Address, TextDataFormat.UnicodeText );
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
            if( !Utils.HasSelection( AddressTextBox ) )
            {
                AddressTextBox.SelectAll( );
            }
        }

        /// <summary>
        /// Opens the developer tools.
        /// </summary>
        private void OpenDeveloperTools( )
        {
            CurBrowser.ShowDevTools( );
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
                foreach( TabPage tab in TabPages.Items )
                {
                    var browser = (ChromiumWebBrowser)tab.Controls[ 0 ];
                    browser.Dispose( );
                }
            }
            catch( Exception ex ) { }
        }

        /// <summary>
        /// we must store download metadata in a list, since CefSharp does not
        /// </summary>
        private void InitDownloads( )
        {
            downloads = new Dictionary<int, DownloadItem>( );
            DownloadNames = new Dictionary<int, string>( );
            DownloadCancelRequests = new List<int>( );
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
        /// Opens the search.
        /// </summary>
        private void OpenSearch( )
        {
            if( !_searchOpen )
            {
                _searchOpen = true;
                InvokeIfNeeded( delegate
                {
                    PanelSearch.Visible = true;
                    SearchTextBox.Text = _lastSearch;
                    SearchTextBox.Focus( );
                    SearchTextBox.SelectAll( );
                } );
            }
            else
            {
                InvokeIfNeeded( delegate
                {
                    SearchTextBox.Focus( );
                    SearchTextBox.SelectAll( );
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
                    PanelSearch.Visible = false;
                    CurBrowser.GetBrowser( ).StopFinding( true );
                } );
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnClearSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnStopSearchButtonClicked( object sender, EventArgs e )
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
        /// Finds the text on page.
        /// </summary>
        /// <param name="next">if set to <c>true</c> [next].</param>
        private void FindTextOnPage( bool next = true )
        {
            var first = _lastSearch != SearchTextBox.Text;
            _lastSearch = SearchTextBox.Text;
            if( _lastSearch.CheckIfValid( ) )
            {
                CurBrowser.GetBrowser( ).Find( _lastSearch, true, false, !first );
            }
            else
            {
                CurBrowser.GetBrowser( ).StopFinding( true );
            }

            SearchTextBox.Focus( );
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
        private void TxtSearch_KeyDown( object sender, KeyEventArgs e )
        {
            if( e.IsHotkey( Keys.Enter ) )
            {
                FindTextOnPage( true );
            }

            if( e.IsHotkey( Keys.Enter, true )
               || e.IsHotkey( Keys.Enter, false, true ) )
            {
                FindTextOnPage( false );
            }
        }
    }
}
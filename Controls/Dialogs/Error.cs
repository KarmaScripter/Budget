namespace BudgetExecution
{
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using Syncfusion.Windows.Forms;
    
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public partial class Error : MetroForm
    {
        /// <summary>
        /// The application setting
        /// </summary>
        public virtual NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public virtual Exception Exception { get; set; }

        /// <summary>
        /// Gets or sets the icon path.
        /// </summary>
        /// <value>
        /// The icon path.
        /// </value>
        public virtual string IconPath { get; set; }

        public Error( )
        {
            InitializeComponent( );
            
            // Form Property Values
            BackColor = Color.FromArgb( 15, 15, 15 );
            BorderThickness = 1;
            BorderColor = Color.FromArgb( 192, 0, 0 );
            Size = new Size( 700, 550 );
            Font = new Font( "Roboto", 9 );
            CaptionBarColor = Color.FromArgb( 15, 15, 15 );
            CaptionBarHeight = 26;
            CaptionButtonColor = Color.FromArgb( 80, 80, 80 );
            CaptionButtonHoverColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 9 );
            MetroColor = Color.FromArgb( 15, 15, 15 );
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = new Icon( IconPath, 33, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = new Padding( 1 );
            Text = string.Empty;
            Size = new Size( 812, 486 );
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="ext">The ext.</param>
        public Error( Exception ext ) 
            : this( )
        {
            InitializeComponent( );
            Exception = ext;
            Text = ext.ToLogString( "" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public Error( string message )
            : this( )
        {
            InitializeComponent( );
            Exception = null;
            Text = message;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public void SetText( )
        {
            try
            {
                //var _logString = Exception?.ToLogString( "" );
                Console.WriteLine(  );
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.StackTrace );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public void SetText( Exception exc )
        {
            try
            {
                var _logString = exc?.ToLogString( "" );
                Console.WriteLine( _logString );
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.StackTrace );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public void SetText( string msg = "" )
        {
            Console.WriteLine( msg );
        }

        public void OnClick( object sender, EventArgs e )
        {
            if( sender is Button )
            {
                Close( );
            }
        }
    }
    
}


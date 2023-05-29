namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public static class Program
    {
        /// <summary>
        /// Gets or sets the windows.
        /// </summary>
        /// <value>
        /// The windows.
        /// </value>
        public static IDictionary<string, Form> Windows { get; set; }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [ STAThread ]
        public static void Main( )
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "MjIyNzQwMEAzMjMxMmUzMTJlMzMzNWJ6Ylo1L05Bcm1yT0wyenJGMWhFM21xdUJlUERvMUdOUmE3MnBJUjJFbzQ9;MjIyNzQwMUAzMjMxMmUzMTJlMzMzNUZUcGV5Y29yQkkvS0lNVWl1RTBSTTArYmFJQ3Z0NHZMK1FYYm0zOFo1OGM9" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Windows = new Dictionary<string, Form>( );
            var _main = new MainForm( );
            Application.Run( _main );
        }
    }
}

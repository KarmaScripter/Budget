namespace BudgetExecution
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [ STAThread ]
        public static void Main( )
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "OTg1MzgxQDMyMzAyZTM0MmUzMFlqMDNnUEV6N0E4bG5rT2NRdnlJMm8yS1JhU1pRTytCdlRzbnNyUm5YWDQ9" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm( ) );
        }
    }
}

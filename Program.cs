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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "ODI1MjUyQDMyMzAyZTMzMmUzMEZnb3VHUWNYY0swN2VuUnZXeXU4WE5rRDRsODIyT2MvdVlRMEk4b2pOdUk9" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new DataGridForm( ) );
        }
    }
}

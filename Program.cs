namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "ArrangeTypeModifiers" ) ]
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [ STAThread ]
        static void Main( )
        {
            Application.Run( new MainForm( ) );
        }
    }
}

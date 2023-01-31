// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public static class Minion
    {
        /// <summary>
        /// Opens the sq lite.
        /// </summary>
        public static void OpenSQLite( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = @"C:\Users\terry\source\repos\Budget\Minions\SQLite\DB Browser for SQLite.exe";
                _startInfo.Arguments = @"C:\Users\terry\source\repos\Budget\Data\Database\SQLite\DataModels\Data.db";
                _startInfo.UseShellExecute = true;
                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Opens the SQL ce.
        /// </summary>
        public static void OpenSqlCe( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = @"C:\Users\terry\source\repos\Budget\Minions\SqlCe\CompactView.exe";
                _startInfo.Arguments = @"C:\Users\terry\source\repos\Budget\Data\Database\SqlCe\DataModels\Data.sdf";
                _startInfo.UseShellExecute = true;
                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Opens the access.
        /// </summary>
        public static void OpenAccess( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = @"C:\Users\terry\source\repos\Budget\Data\Database\Access\DataModels\Data.accdb";
                _startInfo.UseShellExecute = true;
                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Opens the excel.
        /// </summary>
        public static void OpenExcel( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = @"C:\Users\terry\source\repos\Budget\Resource\Reports\Template.xlsx";
                _startInfo.UseShellExecute = true;
                Process.Start( _startInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}

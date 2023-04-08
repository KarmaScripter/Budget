// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UseNullPropagation" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public static class BindingSourceExtensions
    {
        /// <summary>
        /// Gets the rows.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> GetDataRows( this BindingSource bindingSource )
        {
            if( bindingSource.DataSource != null )
            {
                try
                {
                    var _table = (DataTable)bindingSource.DataSource;
                    return _table?.Rows?.Count > 0
                        ? _table.AsEnumerable( )
                        : default( IEnumerable<DataRow> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <returns></returns>
        public static DataTable GetDataTable( this BindingSource bindingSource )
        {
            if( bindingSource.DataSource != null )
            {
                try
                {
                    var _table = (DataTable)bindingSource.DataSource;
                    return _table != null 
                        && _table.Rows.Count > 0
                            ? _table
                            : default( DataTable );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }
        
        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
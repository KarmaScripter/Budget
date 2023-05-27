// <copyright file = "DataMetric.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;
    using LinqStatistics;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    [ SuppressMessage( "ReSharper", "ReturnTypeCanBeEnumerable.Local" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class DataMetric
    {
        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IEnumerable<string> Numerics { get; set; }

        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        /// <value>
        /// The values.
        /// </value>
        public IDictionary<string, double> Values { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMetric"/> class.
        /// </summary>
        public DataMetric( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMetric"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public DataMetric( DataTable dataTable )
        {
            DataTable = dataTable;
            Numerics = GetNumericColumns( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMetric"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public DataMetric( IEnumerable<DataRow> dataRow )
        {
            DataTable = dataRow.CopyToDataTable( );
            Numerics = GetNumericColumns( );
        }

        /// <summary>
        /// Counts the values.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public int CountValues( string numeric )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _select = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) );
                    
                    return _select?.Any( ) == true
                        ? _select.Count( )
                        : -1;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return -1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Counts the values.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public int CountValues( string numeric, IDictionary<string, object> where )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && ( where?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _select = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) );
                    
                    return _select?.Any( ) == true
                        ? _select.Count( )
                        : -1;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return -1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Calculates the total.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateTotal( string numeric )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _select = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Sum( );
                    
                    return _select > 0
                        ? double.Parse( _select?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the total.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public double CalculateTotal( string numeric, IDictionary<string, object> where )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _select = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Sum( );
                    
                    return _select > 0
                        ? double.Parse( _select?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the average.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateAverage( string numeric )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _query = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Average( );
                    
                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return 0.0d;
        }

        /// <summary>
        /// Calculates the average.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public double CalculateAverage( string numeric, IDictionary<string, object> where )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _query = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Average( );
                    
                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return 0.0d;
        }

        /// <summary>
        /// Calculates the percentage.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculatePercentage( string numeric )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _select = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Sum( );
                    
                    return _select > 0
                        ? double.Parse( _select?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the percentage.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public double CalculatePercentage( string numeric, IDictionary<string, object> where )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _select = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Sum( );
                    
                    return _select > 0
                        ? double.Parse( _select?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the deviation.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateDeviation( string numeric )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _query = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.StandardDeviation( );
                    
                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the deviation.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public double CalculateDeviation( string numeric, IDictionary<string, object> where )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _query = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.StandardDeviation( );
                    
                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateVariance( string numeric )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _query = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Variance( );
                    
                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return -1.0d;
        }

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public double CalculateVariance( string numeric, IDictionary<string, object> where )
        {
            if( ( DataTable != null )
               && ( Numerics?.Any( ) == true )
               && !string.IsNullOrEmpty( numeric )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _query = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Variance( );
                    
                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return -1.0d;
        }

        /// <summary>
        /// Gets the numeric columns.
        /// </summary>
        /// <returns></returns>
        private IList<string> GetNumericColumns( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _numerics = new List<string>( );
                    foreach( DataColumn col in DataTable.Columns )
                    {
                        if( !col.ColumnName.EndsWith( "Id" )
                           && ( col.DataType != typeof( int ) )
                           && ( col.DataType != typeof( string ) )
                           && ( col.DataType != typeof( DateTime ) )
                           && ( col.DataType != typeof( DateOnly ) )
                           && ( col.DataType != typeof( DateTimeOffset ) )
                           && ( ( col.DataType == typeof( double ) ) 
                               || ( col.DataType == typeof( decimal ) ) 
                               || ( col.DataType == typeof( float ) ) ) )
                        {
                            _numerics.Add( col.ColumnName );
                        }
                    }

                    return _numerics?.Any( ) == true
                        ? _numerics
                        : default( IList<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IList<string> );
                }
            }

            return default( IList<string> );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
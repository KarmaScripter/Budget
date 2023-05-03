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
    using System.Windows.Forms;
    using LinqStatistics;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    public class Metric
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the data member.
        /// </summary>
        /// <value>
        /// The data member.
        /// </value>
        public string DataMember { get; set; }

        /// <summary>
        /// The dataRow
        /// </summary>
        public IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// The Numerics
        /// </summary>
        public IEnumerable<string> Numerics { get; set; }
        
        /// <summary>
        /// The count
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// The total
        /// </summary>
        public double Total { get; set; }

        /// <summary>
        /// The average
        /// </summary>
        public double Average { get; set; }

        /// <summary>
        /// Gets the variance.
        /// </summary>
        /// <value>
        /// The variance.
        /// </value>
        public double Variance { get; set; }

        /// <summary>
        /// Gets the deviation.
        /// </summary>
        /// <value>
        /// The deviation.
        /// </value>
        public double Deviation { get; set; }
        
        /// <summary>
        /// Gets or sets the amounts.
        /// </summary>
        /// <value>
        /// The amounts.
        /// </value>
        public IDictionary<string, double> Amounts { get; set; }

        /// <summary>
        /// The statistics
        /// </summary>
        public IDictionary<string, double> Statistics { get; set; }

        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        /// <value>
        /// The values.
        /// </value>
        public IDictionary<string, double> Values { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metric"/> class.
        /// </summary>
        public Metric( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metric"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="numeric">The numeric.</param>
        public Metric( BindingSource bindingSource )
        {
            DataTable = (DataTable)bindingSource.DataSource;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metric"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="numeric">The numeric.</param>
        public Metric( DataTable dataTable )
        {
            DataTable = dataTable;
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="where"></param>
        /// <param name="numeric"></param>
        public Metric( IEnumerable<DataRow> dataRow )
        {
            DataTable = dataRow.CopyToDataTable( );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
        }
        
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public int CountValues( string numeric )
        {
            if( DataTable != null 
               && !string.IsNullOrEmpty( numeric ) )
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
        /// Gets the count.
        /// </summary>
        /// <param name="where">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public int CountUniqueValues( string numeric )
        {
            if( DataTable != null 
               && !string.IsNullOrEmpty( numeric ) )
            {
                try
                {
                    var _select = DataTable.AsEnumerable( )
                        ?.Where( p => p.Field<double>( numeric ) != 0 )
                        ?.Select( p => p );

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
        /// Calculates the totals.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateTotal( string numeric )
        {
            if( DataTable != null 
               && !string.IsNullOrEmpty( numeric ) )
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

            return default;
        }

        public double CalculateTotal( string numeric, IDictionary<string, object> where )
        {
            if( DataTable != null 
               && !string.IsNullOrEmpty( numeric ) 
               && where?.Any( ) == true )
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

            return default;
        }
        
        /// <summary>
        /// Calculates the average.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateAverage( string numeric )
        {
            if( DataTable != null 
               && !string.IsNullOrEmpty( numeric ) )
            {
                try
                {
                    var _query = DataTable.AsEnumerable( )
                        ?.Where( p => p.Field<double>( numeric ) != 0 )
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
        
        public double CalculateAverage( string numeric, IDictionary<string, object> where )
        {
            if( DataTable != null 
               && !string.IsNullOrEmpty( numeric ) 
               && where?.Any() == true )
            {
                try
                {
                    var _query = DataTable.Filter( where )
                        ?.Where( p => p.Field<double>( numeric ) != 0 )
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
        /// Calculates the deviation.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public double CalculateDeviation( string numeric )
        {
            if( DataTable != null 
               && !string.IsNullOrEmpty( numeric ) )
            {
                try
                {
                    var _query = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) ) 
                        ?.StandardDeviation(  );

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

            return default;
        }

        public double CalculateDeviation( string numeric, IDictionary<string, object> where )
        {
            if( DataTable != null 
               && !string.IsNullOrEmpty( numeric ) 
               && where?.Any( ) == true )
            {
                try
                {
                    var _query = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) ) 
                        ?.StandardDeviation(  );

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

            return default;
        }

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public double CalculateVariance( string numeric )
        {
            if( DataTable != null 
               && !string.IsNullOrEmpty( numeric ) )
            {
                try
                {
                    var _query = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Variance(  );

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

        public double CalculateVariance( string numeric, IDictionary<string, object> where )
        {
            if( DataTable != null 
               && !string.IsNullOrEmpty( numeric ) 
               && where?.Any( ) == true )
            {
                try
                {
                    var _query = DataTable.Filter( where  )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Variance(  );

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
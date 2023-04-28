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
        public string TableName { get; set; }

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
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        public IEnumerable<string> Categories { get; set; }

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
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="numeric">The numeric.</param>
        public Metric( BindingSource bindingSource, string numeric )
        {
            Data = ( (DataTable)bindingSource.DataSource ).AsEnumerable( );
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), TableName );
            Count = GetCount( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metric"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="numeric">The numeric.</param>
        public Metric( BindingSource bindingSource, IDictionary<string, object> where, 
            string numeric )
        {
            Data = ( (DataTable)bindingSource.DataSource ).Select( where.ToCriteria( ) );
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), TableName );
            Total = CalculateTotal( Data, numeric );
            Count = GetCount( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metric"/> class.
        /// </summary>
        /// <param name="dataTable">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        public Metric( DataTable dataTable, string numeric )
        {
            Data = dataTable.AsEnumerable( );
            TableName = dataTable.TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            Count = Data.Count( );
            Total = CalculateTotal( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metric"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="numeric">The numeric.</param>
        public Metric( DataTable dataTable, IDictionary<string, object> where,
            string numeric )
        {
            Data = dataTable.Select( where.ToCriteria( ) );
            TableName = dataTable.TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            Count = Data.Count( );
            Total = CalculateTotal( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metric"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        public Metric( IEnumerable<DataRow> dataRow, string numeric )
        {
            Data = dataRow;
            TableName = dataRow.CopyToDataTable( ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataRow.CopyToDataTable( ).TableName );
            Count = dataRow.Count( );
            Total = CalculateTotal( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="where"></param>
        /// <param name="numeric"></param>
        public Metric( IEnumerable<DataRow> dataRow, IDictionary<string, object> where,
            string numeric )
        {
            Data = dataRow.Filter( where );
            TableName = dataRow.CopyToDataTable( ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataRow.CopyToDataTable( ).TableName );
            Count = Data.Count( );
            Total = CalculateTotal( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// Gets the codes.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name = "dataMember" > </param>
        /// <returns></returns>
        public static IEnumerable<string> GetUniqueValues( IEnumerable<DataRow> dataRow,
            string dataMember )
        {
            if( dataRow?.Any( ) == true
               && !string.IsNullOrEmpty( dataMember ) )
            {
                try
                {
                    var _columns = dataRow
                        ?.CopyToDataTable( )
                        ?.GetColumnNames( );
                    
                    if( _columns?.Contains( dataMember ) == true )
                    {
                        var _query = dataRow
                            ?.Select( p => p.Field<string>( dataMember ) )
                            ?.Distinct( )
                            ?.ToArray( );

                        return _query?.Any( ) == true
                            ? _query
                            : default( IEnumerable<string> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public int GetCount( IEnumerable<DataRow> dataRow, string numeric )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _select = dataRow
                        ?.Where( p => p.Field<double>( numeric ) != 0 )
                        ?.Select( p => p );

                    return _select?.Any( ) == true
                        ? _select.Count( )
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0;
                }
            }

            return 0;
        }

        /// <summary>
        /// Calculates the totals.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateTotal( IEnumerable<DataRow> dataRow, string numeric )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _select = dataRow
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
        protected double CalculateAverage( IEnumerable<DataRow> dataRow, string numeric )
        {
            if( dataRow?.Any( ) == true
               && !string.IsNullOrEmpty( numeric ) )
            {
                try
                {
                    var _query = dataRow
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
        public double CalculateDeviation( IEnumerable<DataRow> dataRow, string numeric )
        {
            if( dataRow?.Any( ) == true
               && GetCount( dataRow, numeric ) > 30 )
            {
                try
                {
                    var _query = dataRow
                        ?.Where( p => p.Field<double>( numeric ) != 0 )
                        ?.StandardDeviation( p => p.Field<double>( numeric ) );

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
        public double CalculateVariance( IEnumerable<DataRow> dataRow, string numeric )
        {
            if( dataRow?.Any( ) == true
               && GetCount( dataRow, numeric ) > 30 )
            {
                var _table = dataRow.CopyToDataTable( );
                try
                {
                    var _query = _table?.AsEnumerable( )
                        ?.Where( p => p.Field<double>( numeric ) != 0 )
                        ?.Variance( p => p.Field<double>( numeric ) );

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
        /// Calculates the statistics.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, double> CalculateStatistics( )
        {
            try
            {
                var _stats = new Dictionary<string, double>
                {
                    { "TOTAL", Total },
                    { "COUNT", Count },
                    { "AVERAGE", Average }
                };

                return _stats?.Any( ) == true
                    ? _stats
                    : default( IDictionary<string, double> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
        
        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
// <copyright file = "DataAccess.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using BudgetExecution;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DataConfig" />
    /// <seealso cref="ISource" />
    /// <seealso cref="IProvider" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class DataAccess : DataConfig, ISource, IProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccess"/> class.
        /// </summary>
        protected DataAccess( )
        {
        }

        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DataRow> GetData( )
        {
            try
            {
                var _dataTable = GetDataTable( );
                var _data = _dataTable?.AsEnumerable( );
                return _data?.Any( ) == true
                    ? _data
                    : default( IEnumerable<DataRow> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<DataRow> );
            }
        }

        /// <summary>
        /// Gets the Data table.
        /// </summary>
        /// <returns></returns>
        private protected DataTable GetDataTable( )
        {
            if( Query != null )
            {
                try
                {
                    DataSet = new DataSet( $"{ Provider }" );
                    DataTable = new DataTable( $"{ Source }" );
                    DataTable.TableName = Source.ToString( );
                    DataSet.Tables.Add( DataTable );
                    var _adapter = Query.DataAdapter;
                    _adapter.Fill( DataSet, DataTable.TableName );
                    SetColumnCaptions( DataTable );
                    return DataTable?.Rows?.Count > 0
                        ? DataTable
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
        /// Gets the Data set.
        /// </summary>
        /// <returns></returns>
        private protected DataSet GetDataSet( )
        {
            if( Query != null )
            {
                try
                {
                    DataSet = new DataSet( $"{ Provider }" );
                    DataTable = new DataTable( $"{ Source }" );
                    DataSet.Tables.Add( DataTable );
                    var _adapter = Query.DataAdapter;
                    _adapter?.Fill( DataSet, DataTable.TableName );
                    SetColumnCaptions( DataTable );
                    return DataSet?.Tables?.Count > 0
                        ? DataSet
                        : default( DataSet );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataSet );
                }
            }

            return default( DataSet );
        }

        /// <summary>
        /// Sets the column captions.
        /// </summary>
        /// <param name="dataTable">The Data table.</param>
        private protected void SetColumnCaptions( DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    foreach( DataColumn column in dataTable.Columns )
                    {
                        if( column != null )
                        {
                            var _caption = column.ColumnName.SplitPascal( );
                            column.Caption = _caption;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the column schema.
        /// </summary>
        /// <returns></returns>
        public DataColumnCollection GetTableSchema( )
        {
            if( Query != null )
            {
                try
                {
                    DataSet = new DataSet( $"{ Provider }" );
                    DataTable = new DataTable( $"{ Source }" );
                    DataSet.Tables.Add( DataTable );
                    var _adapter = Query?.DataAdapter;
                    _adapter?.Fill( DataSet, DataTable.TableName );
                    SetColumnCaptions( DataTable );
                    return DataTable?.Columns?.Count > 0
                        ? DataTable.Columns
                        : default( DataColumnCollection );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataColumnCollection );
                }
            }

            return default( DataColumnCollection );
        }

        /// <summary>
        /// Gets the primary indexes.
        /// </summary>
        /// <param name="dataRows">The Data rows.</param>
        /// <returns></returns>
        public IEnumerable<int> GetPrimaryIndexes( IEnumerable<DataRow> dataRows )
        {
            if( dataRows?.Any( ) == true
               && dataRows?.HasPrimaryKey( ) == true )
            {
                try
                {
                    var _table = dataRows?.CopyToDataTable( );
                    var _values = _table?.GetPrimaryKeyValues( );
                    return _values?.Any( ) == true
                        ? _values.ToArray( )
                        : default( IEnumerable<int> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<int> );
                }
            }

            return default( IEnumerable<int> );
        }

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetFields( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _fields = new List<string>( );
                    foreach( DataColumn col in DataTable.Columns )
                    {
                        if( col.Ordinal > 0
                           && col.DataType == typeof( string ) )
                        {
                            _fields.Add( col.ColumnName );
                        }
                    }

                    return _fields?.Any( ) == true
                        ? _fields
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
        /// Gets the numerics.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetNumerics( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _numerics = new List<string>( );
                    foreach( DataColumn col in DataTable.Columns )
                    {
                        if( col.Ordinal > 0
                           && ( col.DataType == typeof( double ) 
                               | col.DataType == typeof( decimal ) 
                               | col.DataType == typeof( float ) ) )
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
        /// Gets the dates.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetDates( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _numerics = new List<string>( );
                    foreach( DataColumn col in DataTable.Columns )
                    {
                        if( col.Ordinal > 0
                           && ( col.DataType == typeof( DateTime ) 
                               || col.DataType == typeof( DateOnly ) ) )
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
        /// Compresses the specified column names.
        /// </summary>
        /// <param name="columnNames">The column names.</param>
        /// <param name="having">The where.</param>
        /// <returns></returns>
        public DataTable Compress( IEnumerable<string> columnNames, IDictionary<string, object> having )
        {
            if( columnNames?.Any( ) == true 
               && having?.Any( ) == true
               && DataTable != null )
            {
                try
                {
                    var _fields = new List<string>( );
                    var _numerics = new List<string>( );
                    foreach( DataColumn col in DataTable.Columns )
                    {
                        foreach( var name in columnNames )
                        {
                            if( col.ColumnName == name
                               && col.Ordinal > 0
                               && col.DataType == typeof( string ) )
                            {
                                _fields.Add( col.ColumnName );
                            }
                            else if( col.ColumnName == name 
                                    && col.Ordinal > 0 
                                    && col.DataType != typeof( string ) 
                                    && col.DataType != typeof( DateTime ) )
                            {
                                _numerics.Add( col.ColumnName );
                            }
                        }
                    }
                    
                    var _dataSet = new DataSet( $"UI" );
                    var _dataTable = new DataTable( $"{ Source }" );
                    _dataSet.Tables.Add( _dataTable );
                    var _sqlStatement = new SqlStatement( Source, Provider, _fields,
                        _numerics, having, SQL.SELECT );
                    var _query = new Query( _sqlStatement );
                    var _adapter = _query?.DataAdapter;
                    _adapter?.Fill( _dataSet, _dataTable.TableName );
                    SetColumnCaptions( _dataTable );
                    return _dataTable;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataTable );
                }
            }
            
            return default( DataTable );
        }
    }
}
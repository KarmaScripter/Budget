﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using System.Xml.Linq;
    using OfficeOpenXml;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "ReturnTypeCanBeEnumerable.Global" ) ]
    public static class DataTableExtensions
    {
        /// <summary>
        /// The connection string
        /// </summary>
        public static readonly ConnectionStringSettingsCollection Connection =
            ConfigurationManager.ConnectionStrings;

        /// <summary>
        /// Converts to xml.
        /// </summary>
        /// <param name="dataTable">The dataTable.</param>
        /// <param name="rootName">The rootName.</param>
        /// <returns></returns>
        public static XDocument ToXml( this DataTable dataTable, string rootName )
        {
            try
            {
                var _xml = new XDocument
                {
                    Declaration = new XDeclaration( "1.0", "utf-8", "" )
                };

                _xml.Add( new XElement( rootName ) );
                foreach( DataRow _dataRow in dataTable.Rows )
                {
                    var _element = new XElement( dataTable.TableName );
                    for( var i = 0; i < dataTable.Columns.Count; i++ )
                    {
                        var col = dataTable.Columns[ i ];
                        var _row = _dataRow?[ col ]?.ToString( )?.Trim( ' ' );
                        var _node = new XElement( col.ColumnName, _row );
                        _element.Add( new XElement( _node ) );
                    }

                    _xml.Root?.Add( _element );
                }

                return _xml;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Converts to excel.
        /// </summary>
        /// <param name="dataTable">The dataTable.</param>
        /// <param name="filePath">The filePath.</param>
        /// <exception cref="Exception">
        /// OSExportToExcelFile: Null or empty input datatable!\n
        /// or
        /// OSExportToExcelFile: Excel file could not be saved.\n"
        ///                             + ex.Message
        /// </exception>
        public static void ToExcel( this DataTable dataTable, string filePath = null )
        {
            try
            {
                if( dataTable == null )
                {
                    throw new Exception( "Null or empty input datatable!\n" );
                }

                var _excel = new ExcelPackage( );
                var _worksheet = _excel?.Workbook?.Worksheets[ 0 ];
                for( var i = 0; i < dataTable?.Columns?.Count; i++ )
                {
                    if( _worksheet != null
                       && !string.IsNullOrEmpty( dataTable.Columns[ i ]?.ColumnName ) )
                    {
                        _worksheet.Cells[ 1, i + 1 ].Value = dataTable.Columns[ i ]?.ColumnName;
                    }
                }

                for( var i = 0; i < dataTable.Rows?.Count; i++ )
                {
                    for( var j = 0; j < dataTable.Columns?.Count; j++ )
                    {
                        if( _worksheet != null )
                        {
                            _worksheet.Cells[ i + 2, j + 1 ].Value = dataTable.Rows[ i ][ j ];
                        }
                    }
                }

                if( !string.IsNullOrEmpty( filePath ) )
                {
                    try
                    {
                        _excel.Save( filePath );
                        MessageBox.Show( "Excel file saved!" );
                    }
                    catch( Exception ex )
                    {
                        throw new Exception( "Excel file could not be saved.\n" + ex.Message );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// From excel.
        /// </summary>
        /// <param name="dataTable">The dataTable.</param>
        /// <param name="filePath">The filePath.</param>
        /// <param name="sheetName">The sheetName.</param>
        /// <returns></returns>
        public static DataTable FromExcel( this DataTable dataTable, string filePath,
            string sheetName )
        {
            if( !string.IsNullOrEmpty( filePath )
               && !string.IsNullOrEmpty( sheetName ) )
            {
                try
                {
                    var _connectionString = Connection[ "Excel" ].ConnectionString;
                    var _sql = "SELECT * FROM [" + sheetName + "$]";
                    using var _adapter = new OleDbDataAdapter( _sql, _connectionString );
                    var _table = new DataTable( );
                    _table.TableName = sheetName;
                    _adapter?.FillSchema( _table, System.Data.SchemaType.Source );
                    _adapter.Fill( _table, _table.TableName );
                    return _table;
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
        /// Determines whether [has numeric column].
        /// </summary>
        /// <param name="dataTable">The dataTable.</param>
        /// <returns>
        ///   <c>true</c> if [has numeric column] [the specified dataTable]; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasNumericColumn( this DataTable dataTable )
        {
            try
            {
                if( dataTable?.Rows?.Count > 0 )
                {
                    foreach( DataColumn col in dataTable.Columns )
                    {
                        if( col?.Ordinal > 0
                           && col.DataType == typeof( double ) | col.DataType == typeof( decimal )
                           | col.DataType == typeof( float ) | col.DataType == typeof( int ) )
                        {
                            return true;
                        }
                    }
                    
                    return false;
                }

                return false;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Determines whether [has primary key].
        /// </summary>
        /// <param name="dataTable">The dataTable.</param>
        /// <returns>
        ///   <c>true</c> if [has primary key] [the specified dataTable]; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasPrimaryKey( this DataTable dataTable )
        {
            try
            {
                if( dataTable?.Rows?.Count > 0
                   && dataTable.Columns?.Count > 0 )
                {
                    foreach( DataColumn col in dataTable.Columns )
                    {
                        if( col.Ordinal == 0 
                           && col.DataType == typeof( int ) | col.DataType == typeof( double ) )
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Gets the primary key values.
        /// </summary>
        /// <param name="dataTable">The dataTable.</param>
        /// <returns></returns>
        public static IEnumerable<int> GetPrimaryKeyValues( this DataTable dataTable )
        {
            try
            {
                if( dataTable?.Rows?.Count > 0
                   && dataTable.Columns?.Count > 0 )
                {
                    var _list = new List<int>( );
                    for( var i = 0; i < dataTable.Rows.Count; i++ )
                    {
                        DataRow row = dataTable.Rows[ i ];
                        var _item = row?.ItemArray[ 0 ];
                        var _value = _item?.ToString( );
                        var _index = int.Parse( _value );
                        _list.Add( _index );
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( IEnumerable<int> );
                }

                return default( IEnumerable<int> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<int> );
            }
        }

        /// <summary>
        /// Gets the primary key values.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="where">The dictionary.</param>
        /// <returns></returns>
        public static IEnumerable<int> GetPrimaryKeyValues( this DataTable dataTable,
            IDictionary<string, object> where )
        {
            try
            {
                if( dataTable?.Rows?.Count > 0
                   && where?.Any( ) == true )
                {
                    var _list = new List<int>( );
                    var _criteria = where.ToCriteria( );
                    if( !string.IsNullOrEmpty( _criteria ) )
                    {
                        var _filtered = dataTable.Select( _criteria );
                        if( _filtered?.Any( ) == true )
                        {
                            foreach( var row in _filtered )
                            {
                                var _item = row?.ItemArray[ 0 ];
                                var _value = _item?.ToString( );
                                var _index = int.Parse( _value );
                                _list.Add( _index );
                            }
                        }
                    }

                    return ( _list?.Any( ) == true )
                        ? _list
                        : default( IEnumerable<int> );
                }

                return default( IEnumerable<int> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<int> );
            }
        }

        /// <summary>
        /// Gets the unique values.
        /// </summary>
        /// <param name="dataTable">The dataTable.</param>
        /// <param name="columnName">The column.</param>
        /// <returns></returns>
        public static string[ ] GetUniqueColumnValues( this DataTable dataTable, string columnName )
        {
            if( !string.IsNullOrEmpty( columnName )
               && dataTable?.Columns?.Contains( columnName ) == true )
            {
                try
                {
                    var _enumerable = dataTable
                        ?.AsEnumerable( )
                        ?.Select( p => p.Field<string>( columnName ) )
                        ?.Distinct( );
                    
                    return ( _enumerable?.Any( ) == true )
                        ? _enumerable?.ToArray( )
                        : default( string[ ] );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string[ ] );
                }
            }

            return default( string[ ] );
        }

        /// <summary>
        /// Filters the specified dictionary.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> Filter( this DataTable dataTable,
            IDictionary<string, object> dict )
        {
            if( dataTable?.Columns?.Count > 0
               && dict?.Any( ) == true )
            {
                try
                {
                    var _query = dataTable
                        ?.Select( dict.ToCriteria( ) )
                        ?.ToList( );
                    
                    return ( _query?.Any( ) == true )
                        ? _query
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
        /// Gets the column names.
        /// </summary>
        /// <param name="dataTable">The dataTable.</param>
        /// <returns></returns>
        public static string[ ] GetColumnNames( this DataTable dataTable )
        {
            try
            {
                var _fields = new string[ dataTable.Columns.Count ];
                for( var i = 0; i < dataTable.Columns.Count; i++ )
                {
                    _fields[ i ] = dataTable.Columns[ i ].ColumnName;
                }

                var _names = _fields
                    ?.OrderBy( f => f.IndexOf( f ) )
                    ?.Select( f => f )
                    ?.ToArray( );
                
                return ( _names?.Any( ) == true )
                    ? _names
                    : default( string[ ] );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string[ ] );
            }
        }

        /// <summary>
        /// Gets the chart points.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <returns></returns>
        public static IList<DataPoint> GetChartPoints( this DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    var _points = new List<DataPoint>( );
                    var _numerics = new List<string>( );
                    var _values = new List<double>( );
                    foreach( DataColumn col in dataTable.Columns )
                    {
                        if( col.Ordinal > 1
                           && ( col.DataType == typeof( decimal ) 
                               | col.DataType == typeof( float )
                               | col.DataType == typeof( double ) 
                               | col.DataType == typeof( int ) ) )
                        {
                            _numerics.Add( col.ColumnName );
                        }
                    }

                    for( var index = 0; index < dataTable.Rows.Count; index++ )
                    {
                        var _row = dataTable.Rows[ index ];
                        var _point = new DataPoint( );
                        _point.XValue = index;
                        foreach( var name in _numerics )
                        {
                            var _val = double.Parse( _row[ name ]?.ToString( ) );
                            _values.Add( _val );
                        }

                        var _range = _values.ToArray( );
                        _point.YValues = _range;
                        _points.Add( _point );
                    }

                    return _points?.Any( ) == true
                        ? _points
                        : default( IList<DataPoint> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IList<DataPoint> );
                }
            }
            
            return default( IList<DataPoint> );
        }

        /// <summary>
        /// Removes a DataColumn from the table
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="columnName">The column name.</param>
        public static void RemoveColumn( this DataTable dataTable, string columnName )
        {
            if (dataTable != null 
                && !string.IsNullOrEmpty( columnName ) 
                && dataTable.Columns.Contains( columnName ) )
            {
                try
                {
                    var _index = dataTable.Columns.IndexOf( columnName );
                    dataTable.Columns.RemoveAt( _index );
                    dataTable.AcceptChanges( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Converts to bindinglist.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <returns></returns>
        public static BindingList<DataRow> ToBindingList( this DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    var _bindingList = new BindingList<DataRow>( );
                    foreach( DataRow row in dataTable.Rows )
                    {
                        _bindingList.Add( row );
                    }

                    return ( _bindingList?.Any( ) == true )
                        ? _bindingList
                        : default( BindingList<DataRow> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( BindingList<DataRow> );
                }
            }

            return default( BindingList<DataRow> );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms.DataVisualization.Charting;
    using BudgetExecution;
    using DocumentFormat.OpenXml.Drawing.Diagrams;
    using OfficeOpenXml;
    using TableStyles = OfficeOpenXml.Table.TableStyles;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Determines whether this instance has numeric.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <returns>
        ///   <c>true</c> if the specified dataRow has numeric; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasNumeric( this IEnumerable<DataRow> dataRow )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _table = dataRow?.CopyToDataTable( );
                    var _columns = _table.Columns;
                    foreach( DataColumn col in _columns )
                    {
                        if( col.Ordinal > 0
                           && !col.ColumnName.EndsWith( "Id" )
                           && col.DataType == typeof( double ) | col.DataType == typeof( decimal )
                           | col.DataType == typeof( float ) | col.DataType == typeof( int ) )
                        {
                            return true;
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

            return false;
        }

        /// <summary>
        /// Determines whether [has primary key].
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <returns>
        ///   <c>true</c> if [has primary key] [the specified dataRow]; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasPrimaryKey( this IEnumerable<DataRow> dataRow )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _row = dataRow?.First( );
                    var _dict = _row?.ToDictionary( );
                    var _key = _dict?.Keys.ToArray( );
                    var _names = Enum.GetNames( typeof( PrimaryKey ) );
                    if( _key != null )
                    {
                        foreach( var k in _key )
                        {
                            if( !string.IsNullOrEmpty( k )
                               && _names?.Contains( k ) == true )
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
                    return default;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the primary key values.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <returns></returns>
        public static IEnumerable<int> GetPrimaryKeyValues( this IEnumerable<DataRow> dataRow )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _list = new List<int>( );
                    foreach( var _row in dataRow )
                    {
                        if( _row?.ItemArray[ 0 ] != null )
                        {
                            var _item = _row.ItemArray[ 0 ].ToString( );
                            _list?.Add( int.Parse( _item ) );
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list.ToArray( )
                        : default;
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
        /// Converts IEnumerable to BindingList.
        /// </summary>
        /// <param name="dataRows">The IEnumerable</param>
        /// <returns></returns>
        public static BindingList<DataRow> ToBindingList( this IEnumerable<DataRow> dataRows )
        {
            if( dataRows?.Any( ) == true )
            {
                try
                {
                    var _list = new BindingList<DataRow>( );
                    foreach( var item in dataRows )
                    {
                        _list.Add( item );
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default;
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
        /// Converts to bindinglist.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns></returns>
        public static BindingList<T> ToBindingList<T>( this IEnumerable<T> enumerable )
        {
            if( enumerable?.Any( ) == true )
            {
                try
                {
                    var _list = new BindingList<T>( );
                    foreach( var item in enumerable )
                    {
                        _list.Add( item );
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( BindingList<T> );
                }
            }

            return default( BindingList<T> );
        }
        
        /// <summary>
        /// Filters the specified columnName.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="name">The columnName.</param>
        /// <param name="value">The filter.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> Filter( this IEnumerable<DataRow> dataRow,
            string name, string value )
        {
            if( dataRow?.Any( ) == true
               && !string.IsNullOrEmpty( name )
               && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _row = dataRow?.First( );
                    var _dictionary = _row.ToDictionary( );
                    var _array = _dictionary.Keys.ToArray( );
                    if( _array?.Contains( name ) == true )
                    {
                        var _select = dataRow
                            ?.Where( p => p.Field<string>( name ) == value )
                            ?.Select( p => p );

                        return _select?.Any( ) == true
                            ? _select
                            : default;
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
        /// Filters the specified dictionary.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> Filter( this IEnumerable<DataRow> dataRow,
            IDictionary<string, object> dict )
        {
            if( dataRow?.Any( ) == true
               && dict?.Any( ) == true )
            {
                try
                {
                    var _table = dataRow.CopyToDataTable( );
                    var _rows = _table?.Select( dict.ToCriteria( ) );
                    return _rows?.Any( ) == true
                        ? _rows
                        : default( IEnumerable<DataRow> );
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
        /// Filters the specified column.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="column">The column.</param>
        /// <param name="value">The filter.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> Filter( this IEnumerable<DataRow> dataRow,
            DataColumn column, string value )
        {
            if( dataRow?.Any( ) == true
               && column != null
               && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _row = dataRow?.First( );
                    var _columns = _row?.Table?.Columns;
                    if( !string.IsNullOrEmpty( column.ColumnName )
                       && _columns?.Contains( column.ColumnName ) == true )
                    {
                        var _enumerable = dataRow
                            ?.Where( p => p.Field<string>( column.ColumnName ).Equals( value ) )
                            ?.Select( p => p );

                        return _enumerable?.Any( ) == true
                            ? _enumerable.ToArray( )
                            : default;
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
        /// Converts to excel.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The dataRow.</param>
        /// <param name="path">The path.</param>
        /// <param name = "style" > </param>
        /// <exception cref="Exception">
        /// Invalid file path.
        /// or
        /// Invalid file path.
        /// or
        /// No dataRow to export.
        /// </exception>
        public static ExcelPackage ToExcel<T>( this IEnumerable<T> type, string path,
            TableStyles style = TableStyles.Light1 )
        {
            if( string.IsNullOrEmpty( path )
               && type?.Any( ) == true
               && Enum.IsDefined( typeof( TableStyles ), style ) )
            {
                throw new ArgumentException( "Verify Path" );
            }

            try
            {
                using var _excel = new ExcelPackage( new FileInfo( path ) );
                var _workbook = _excel.Workbook;
                var _worksheet = _workbook.Worksheets[ 0 ];
                var _range = _worksheet.Cells;
                _range?.LoadFromCollection( type, true, style );
                return _excel;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Slices the specified start.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The dataRow.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns></returns>
        public static IEnumerable<T> LazySlice<T>( this IEnumerable<T> type, int start, int end )
        {
            if( type?.Any( ) == true
               && start > 0
               && end > 0 )
            {
                var _index = 0;
                foreach( var item in type )
                {
                    if( _index >= end )
                    {
                        yield break;
                    }

                    if( _index >= start )
                    {
                        yield return item;
                    }

                    ++_index;
                }
            }
        }

        /// <summary>
        /// Gets the chart points.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <returns></returns>
        public static IList<DataPoint> GetChartPoints( this IEnumerable<DataRow> dataRows )
        {
            if( dataRows?.Any( ) == true )
            {
                try
                {
                    var _points = new List<DataPoint>( );
                    var _numerics = new List<string>( );
                    var _values = new List<double>( );
                    var _dataTable = dataRows.CopyToDataTable( );
                    foreach( DataColumn col in _dataTable.Columns )
                    {
                        if( col.DataType == typeof( double )
                           && col.Ordinal > 0 )
                        {
                            _numerics.Add( col.ColumnName );
                        }
                    }

                    for( var index = 0; index < _dataTable.Rows.Count; index++ )
                    {
                        var _row = _dataTable.Rows[ index ];
                        var _point = new DataPoint( );
                        _point.XValue = index;
                        foreach( var name in _numerics )
                        {
                            var _val = double.Parse( _row[ name ]?.ToString( ) );
                            _values.Add( _val );
                        }

                        _point.YValues = _values.ToArray( );
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

        /// <summary>Fails the specified ex.</summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
// <copyright file = "BudgetObjectClass.cs" company = "Terry D.Eppler">
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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DataUnit" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class BudgetObjectClass : DataUnit 
    {
        /// <summary>
        /// The codes
        /// </summary>
        public readonly IEnumerable<string> Codes = new[ ]
        {
            "10",
            "17",
            "21",
            "28",
            "36",
            "37",
            "38",
            "41"
        };

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public BOC Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetObjectClass"/> class.
        /// </summary>
        public BudgetObjectClass( )
        {
            Source = Source.BudgetObjectClasses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetObjectClass"/> class.
        /// </summary>
        /// <param name="boc">The boc.</param>
        public BudgetObjectClass( BOC boc )
            : this( )
        {
            Record = new DataBuilder( Source, SetArgs( boc ) )?.Record;
            ID = int.Parse( Record[ "BudgetObjectClassesId" ].ToString( ) );
            Name = Record[ "BocName" ].ToString( );
            Code = Record[ "BocCode" ].ToString( );
            Category = boc;
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetObjectClass"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        public BudgetObjectClass( string code )
            : this( )
        {
            Record = new DataBuilder( Source, SetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "BudgetObjectClassesId" ].ToString( ) );
            Name = Record[ "BocName" ].ToString( );
            Code = Record[ "BocCode" ].ToString( );
            Data = Record?.ToDictionary( );
            if( Name != null )
            {
                Category = (BOC)Enum.Parse( typeof( BOC ), Name );
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetObjectClass"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetObjectClass( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "BudgetObjectClassesId" ].ToString( ) ?? "0" );
            Name = Record[ "BocName" ].ToString( );
            Code = Record[ "BocCode" ].ToString( );
            Data = Record?.ToDictionary( );
            if( Name != null )
            {
                Category = (BOC)Enum.Parse( typeof( BOC ), Name );
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetObjectClass"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public BudgetObjectClass( IDataModel builder )
            : this( )
        {
            Record = builder?.Record;
            ID = int.Parse( Record?[ "BudgetObjectClassesId" ].ToString( ) ?? "0" );
            Name = Record?[ "BocName" ].ToString( );
            Code = Record?[ "BocCode" ].ToString( );
            Data = Record?.ToDictionary( );
            if( Name != null )
            {
                Category = (BOC)Enum.Parse( typeof( BOC ), Name );
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetObjectClass"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetObjectClass( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( dataRow[ "BudgetObjectClassesId" ].ToString( ) ?? "0" );
            Name = Record[ "BocName" ].ToString( );
            Code = Record[ "BocCode" ].ToString( );
            Data = Record?.ToDictionary( );
            if( Name != null )
            {
                Category = (BOC)Enum.Parse( typeof( BOC ), Name );
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetObjectClass"/> class.
        /// </summary>
        /// <param name="boc">The boc.</param>
        public BudgetObjectClass( BudgetObjectClass boc )
        {
            ID = boc.ID;
            Code = boc.Code;
            Name = boc.Name;
            Category = boc.Category;
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Data?.Any( ) == true
                    ? Data
                    : default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <param name="prc">The PRC.</param>
        /// <returns></returns>
        public double GetAmount( IProgramResultsCode prc )
        {
            try
            {
                var _amount = prc.Amount;
                return _amount > -1
                    ? _amount
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return -1D;
            }
        }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <returns></returns>
        public double GetAmount( )
        {
            try
            {
                return Value != null
                    ? double.Parse( Value?.ToString( ) ?? "0.0" )
                    : 0.0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( double );
            }
        }

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <returns></returns>
        public BOC GetCategory( )
        {
            try
            {
                return !string.IsNullOrEmpty( Name ) && Enum.IsDefined( typeof( BOC ), Name )
                    ? (BOC)Enum.Parse( typeof( BOC ), Name )
                    : default( BOC );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BOC );
            }
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        private IDictionary<string, object> SetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code )
               && ( code.Length == 2 )
               && Codes.Contains( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ "Code" ] = code };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }
            else if( !string.IsNullOrEmpty( code )
                    && ( code.Length > 2 )
                    && Enum.GetNames( typeof( BOC ) ).Contains( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ "Name" ] = code };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name="boc">The boc.</param>
        /// <returns></returns>
        private IDictionary<string, object> SetArgs( BOC boc )
        {
            if( !string.IsNullOrEmpty( boc.ToString( ) )
               && ( boc.ToString( ).Length == 2 )
               && Codes.Contains( boc.ToString( ) ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ "Code" ] = boc.ToString( ) };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }
    }
}
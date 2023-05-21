// <copyright file = "FinanceObjectClass.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DataUnit" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "UnassignedReadonlyField" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class FinanceObjectClass : DataUnit 
    {
        /// <summary>
        /// Gets or sets the boc code.
        /// </summary>
        /// <value>
        /// The boc code.
        /// </value>
        public string BocCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the boc.
        /// </summary>
        /// <value>
        /// The name of the boc.
        /// </value>
        public string BocName { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public BOC Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        public FinanceObjectClass( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public FinanceObjectClass( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "FinanceObjectClassesId" ].ToString( ) );
            Name = Record[ $"{Field.Name}" ].ToString( );
            Code = Record[ $"{Field.Code}" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public FinanceObjectClass( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record[ "FinanceObjectClassesId" ].ToString( ) );
            Name = Record[ $"{Field.Name}" ].ToString( );
            Code = Record[ $"{Field.Code}" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public FinanceObjectClass( DataRow dataRow )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "FinanceObjectClassesId" ].ToString( ) );
            Name = dataRow[ $"{Field.Name}" ].ToString( );
            Code = dataRow[ $"{Field.Code}" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        /// <param name="focCode">The foc code.</param>
        public FinanceObjectClass( string focCode )
        {
            Record = new DataBuilder( Source, GetArgs( focCode ) )?.Record;
            ID = int.Parse( Record[ "FinanceObjectClassesId" ].ToString( ) );
            Name = Record[ $"{Field.Name}" ].ToString( );
            Code = Record[ $"{Field.Code}" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        /// <param name="foc">The foc.</param>
        public FinanceObjectClass( FinanceObjectClass foc )
        {
            ID = foc.ID;
            Code = foc.Code;
            Name = foc.Name;
            Category = foc.Category;
            BocCode = foc.BocCode;
            BocName = foc.BocName;
        }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        private IDictionary<string, object> GetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ $"{Field.Code}" ] = code };
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
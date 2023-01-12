// <copyright file = "Element.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IElement" />
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class DataUnit : UnitBase, IDataUnit, ISource
    {
        /// <summary>
        ///  
        /// </summary>
        public virtual int ID { get; set; }

        /// <summary>
        /// Gets the field.
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Source Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// 
        /// </value>
        public virtual DataRow Record { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataUnit"/> class.
        /// </summary>
        public DataUnit( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataUnit"/> class.
        /// </summary>
        /// <param name="kvp">The KVP.</param>
        public DataUnit( KeyValuePair<string, object> kvp )
        {
            Name = kvp.Key;
            Code = kvp.Value.ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataUnit"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="columnName">The value.</param>
        protected DataUnit( string name, string columnName = "" )
        {
            Name = name;
            Code = columnName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataUnit"/> class.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="columnName">The value.</param>
        protected DataUnit( Field field, string columnName = "" )
        {
            Name = field.ToString( );
            Code = columnName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataUnit"/> class.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="columnName">The value.</param>
        protected DataUnit( DataRow dataRow, string columnName )
        {
            Name = dataRow[ columnName ].ToString( );
            Code = dataRow[ columnName ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataUnit"/> class.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="dataColumn">The Data column.</param>
        protected DataUnit( DataRow dataRow, DataColumn dataColumn )
        {
            Name = dataColumn.ColumnName;
            Code = dataRow[ dataColumn ].ToString( );
        }

        /// <summary>
        /// Determines whether the specified element is match.
        /// </summary>
        /// <param name="dataUnit">The element.</param>
        /// <returns>
        ///   <c>true</c> if the specified element is match; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsMatch( IDataUnit dataUnit )
        {
            if( dataUnit != null )
            {
                try
                {
                    if( dataUnit.Code?.Equals( Code ) == true )
                    {
                        return true;
                    }
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
        /// Determines whether the specified primary is match.
        /// </summary>
        /// <param name="primary">The primary.</param>
        /// <param name="secondary">The secondary.</param>
        /// <returns>
        ///   <c>true</c> if the specified primary is match; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsMatch( IDataUnit primary, IDataUnit secondary )
        {
            try
            {
                if( primary.Code.Equals( secondary.Code )
                   && primary.Name.Equals( secondary.Name ) )
                {
                    return true;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified dictionary is match.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns>
        ///   <c>true</c> if the specified dictionary is match; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsMatch( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _name = dict.Keys.First( );
                    var _value = dict[ _name ];
                    return _value.Equals( Code ) && _name.Equals( Name );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }
    }
}
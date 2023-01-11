// <copyright file = "DataUnit.cs" company = "Terry D. Eppler">
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
    /// <seealso cref="IDataUnit" />
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class DataUnit : UnitBase, IDataUnit
    {
        /// <summary>
        ///  
        /// </summary>
        public virtual int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// 
        /// </value>
        public virtual DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets the field.
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        /// Determines whether the specified dataUnit is match.
        /// </summary>
        /// <param name="dataUnit">The dataUnit.</param>
        /// <returns>
        ///   <c>true</c> if the specified dataUnit is match; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsMatch( IDataUnit dataUnit )
        {
            if( dataUnit != null )
            {
                try
                {
                    var _name = dataUnit.Name;
                    var _code = dataUnit.Code;
                    return _code.Equals( Code ) && _name.Equals( Name );
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

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <returns></returns>
        protected virtual int GetId( DataRow dataRow )
        {
            if( dataRow != null)
            {
                return int.Parse( dataRow[ 0 ].ToString( ) );
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        protected virtual int GetId( DataRow dataRow, PrimaryKey primaryKey )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( PrimaryKey ), primaryKey ) )
            {
                return int.Parse( dataRow[ $"{ primaryKey }" ].ToString( ) );
            }
            else
            {
                return -1;
            }
        }
        
        /// <summary>
        /// Get Error Dialog.
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
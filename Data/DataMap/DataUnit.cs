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
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class DataUnit : IDataUnit, ISource
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
        /// The name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// The value
        /// </summary>
        public virtual object Value { get; set; }

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
        /// 
        /// </summary>
        /// <value>
        /// 
        /// </value>
        public virtual IDictionary<string, object> Data { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DataUnit"/> class.
        /// </summary>
        protected DataUnit( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataUnit"/> class.
        /// </summary>
        /// <param name="kvp">The KVP.</param>
        protected DataUnit( KeyValuePair<string, object> kvp )
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
        /// <param name="unit">The element.</param>
        /// <returns>
        ///   <c>true</c> if the specified element is match; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsMatch( IDataUnit unit )
        {
            if( unit != null )
            {
                try
                {
                    if( unit.Code?.Equals( Code ) == true )
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public virtual int GetId( DataRow dataRow, string primaryKey )
        {
            try
            {
                return !string.IsNullOrEmpty( primaryKey ) && dataRow != null
                    ? int.Parse( dataRow[ $"{ primaryKey }" ].ToString( ) ?? string.Empty )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <returns></returns>
        public virtual int GetId( DataRow dataRow )
        {
            if( dataRow != null )
            {
                return int.Parse( dataRow[ 0 ].ToString( ) ?? string.Empty );
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
        public virtual int GetId( DataRow dataRow, PrimaryKey primaryKey )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( PrimaryKey ), primaryKey ) )
            {
                return int.Parse( dataRow[ $"{ primaryKey }" ].ToString( ) ?? string.Empty );
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
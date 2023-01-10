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
    public class Element : DataUnit, IDataUnit
    {
        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual string Code { get; set; }
        /// <summary>
        /// The default
        /// </summary>
        public static readonly IDataUnit Default = new Element( );

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        public Element( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="kvp">The KVP.</param>
        public Element( KeyValuePair<string, object> kvp )
        {
            Name = kvp.Key;
            Code = kvp.Value.ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="columnName">The value.</param>
        public Element( string name, string columnName = "" )
        {
            Name = name;
            Code = columnName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="columnName">The value.</param>
        public Element( Field field, string columnName = "" )
        {
            Name = field.ToString( );
            Code = columnName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="columnName">The value.</param>
        public Element( DataRow dataRow, string columnName )
        {
            Name = dataRow[ columnName ].ToString( );
            Code = dataRow[ columnName ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="dataColumn">The Data column.</param>
        public Element( DataRow dataRow, DataColumn dataColumn )
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
        public override bool IsMatch( IDataUnit dataUnit )
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
        /// Sets the columnName.
        /// </summary>
        /// <param name = "dataRow" > </param>
        /// <param name = "columnName" > </param>
        protected virtual void SetName( DataRow dataRow, string columnName )
        {
            if( dataRow != null
               && !string.IsNullOrEmpty( columnName )
               && Enum.GetNames( typeof( Field ) )?.Contains( columnName ) == true )
            {
                try
                {
                    var _names = dataRow.Table?.GetColumnNames( );
                    Name = _names?.Contains( columnName ) == true
                        ? columnName
                        : dataRow.Table.TableName;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the columnName.
        /// </summary>
        /// <param name = "field" > </param>
        protected virtual void SetName( Field field )
        {
            if( Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    Name = Enum.IsDefined( typeof( Field ), field )
                        ? field.ToString( )
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name = "value" > </param>
        protected virtual void SetValue( object value )
        {
            try
            {
                if( !string.IsNullOrEmpty( value?.ToString( ) ) )
                {
                    Code = value?.ToString( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
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
    }
}
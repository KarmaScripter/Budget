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
    public class Element : DataUnit, ISource
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual Source Source { get; set; }
        
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
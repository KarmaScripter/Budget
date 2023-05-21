// <copyright file = "Organization.cs" company = "Terry D.Eppler">
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

    /// <summary> </summary>
    /// <seealso cref="DataUnit"/>
    /// <seealso cref="BudgetExecution.ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class Organization : DataUnit 
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Organization"/>
        /// class.
        /// </summary>
        public Organization( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Organization"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Organization( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "OrganizationsId" ].ToString( ) ?? "0" );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Organization"/>
        /// class.
        /// </summary>
        /// <param name="org"> The org. </param>
        public Organization( string org )
        {
            Record = new DataBuilder( Source, GetArgs( org ) )?.Record;
            ID = int.Parse( Record[ "OrganizationsId" ].ToString( ) ?? "0" );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Organization"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public Organization( IDataModel builder )
        {
            Record = builder.Record;
            ID = int.Parse( Record[ "OrganizationsId" ].ToString( ) ?? "0" );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization"/> class.
        /// </summary>
        /// <param name="org">The org.</param>
        public Organization( Organization org )
        {
            ID = org.ID;
            Code = org.Code;
            Name = org.Name;
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Organization"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public Organization( DataRow dataRow )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "OrganizationsId" ].ToString( ) ?? "0" );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary> Converts to dictionary. </summary>
        /// <returns> </returns>
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
        
        /// <summary> Sets the arguments. </summary>
        /// <param name="code"> The code. </param>
        /// <returns> </returns>
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
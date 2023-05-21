// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="IResourcePlanningOffice"/>
    /// <seealso cref="ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class ResourcePlanningOffice : DataUnit, IResourcePlanningOffice
    {
        /// <summary> The source </summary>
        public override Source Source { get; set; } = Source.ResourcePlanningOffices;

        /// <summary> Gets the dataRow. </summary>
        /// <value> The dataRow. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets the code. </summary>
        public override string Code { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        public override string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffice"/>
        /// class.
        /// </summary>
        public ResourcePlanningOffice( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffice"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ResourcePlanningOffice( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffice"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public ResourcePlanningOffice( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record?[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffice"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public ResourcePlanningOffice( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffice"/>
        /// class.
        /// </summary>
        /// <param name="rpioCode"> The rpioCode. </param>
        public ResourcePlanningOffice( string rpioCode )
            : this( )
        {
            Record = new DataBuilder( Source, SetArgs( rpioCode ) )?.Record;
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        public ResourcePlanningOffice( IResourcePlanningOffice rpio )
        {
            ID = rpio.ID;
            Code = rpio.Code;
            Name = rpio.Name;
        }

        /// <summary> Gets the resource planning office. </summary>
        /// <returns> </returns>
        public IResourcePlanningOffice GetResourcePlanningOffice( )
        {
            return MemberwiseClone( ) as ResourcePlanningOffice;
        }

        /// <summary> Gets the identifier. </summary>
        /// <param name="dataRow"> The data row. </param>
        /// <returns> </returns>
        public override int GetId( DataRow dataRow )
        {
            try
            {
                return dataRow != null
                    ? int.Parse( dataRow[ 0 ].ToString( ) ?? string.Empty )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }

        /// <summary> Sets the arguments. </summary>
        /// <param name="code"> The code. </param>
        /// <returns> </returns>
        private IDictionary<string, object> SetArgs( string code )
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
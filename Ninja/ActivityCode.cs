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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class ActivityCode : DataUnit 
    {
        /// <summary> Gets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets the dataRow. </summary>
        /// <value> The dataRow. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets or sets the description. </summary>
        /// <value> The description. </value>
        public string Description { get; set; }

        /// <summary> Gets or sets the description. </summary>
        /// <value> The description. </value>
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
        /// <see cref="ActivityCode"/>
        /// class.
        /// </summary>
        public ActivityCode( )
        {
            Source = Source.ActivityCodes;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ActivityCode"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ActivityCode( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "ActivityCodesId" ].ToString( ) ?? "0" );
            Name = Record[ $"{Field.ActivityName}" ].ToString( );
            Code = Record[ $"{Field.ActivityCode}" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ActivityCode"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public ActivityCode( IDataModel builder )
            : this( )
        {
            Record = builder?.Record;
            ID = int.Parse( Record?[ "ActivityCodesId" ].ToString( ) ?? "0" );
            Name = Record?[ "ActivityName" ].ToString( );
            Code = Record?[ "ActivityCode" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ActivityCode"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public ActivityCode( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "ActivityCodesId" ].ToString( ) ?? "0" );
            Name = dataRow[ "ActivityName" ].ToString( );
            Code = dataRow[ "ActivityCode" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        public ActivityCode( string code )
            : this( )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "ActivityCodesId" ].ToString( ) ?? "0" );
            Name = Record[ "ActivityName" ].ToString( );
            Code = Record[ "ActivityCode" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        public ActivityCode( ActivityCode activityCode )
            : this( )
        {
            ID = activityCode.ID;
            Code = activityCode.Code;
            Name = activityCode.Name;
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
                    return new Dictionary<string, object> { [ "ActivityCode" ] = code };
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
// <copyright file = "Objective.cs" company = "Terry D.Eppler">
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
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class Objective : DataUnit 
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Objective"/>
        /// class.
        /// </summary>
        public Objective( )
        {
            Source = Source.Objectives;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Objective"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Objective( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "ObjectivesId" ].ToString( ) );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Objective"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public Objective( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record[ "ObjectivesId" ].ToString( ) );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Objective"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public Objective( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "ObjectivesId" ].ToString( ) );
            Name = dataRow[ "Name" ].ToString( );
            Code = dataRow[ "Code" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Objective"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public Objective( string code )
        {
            Record = new DataBuilder( Source, SetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "ObjectivesId" ].ToString( ) );
            Name = Record[ "Field.Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Objective"/> class.
        /// </summary>
        /// <param name="objective">The objective.</param>
        public Objective( Objective objective )
        {
            ID = objective.ID;
            Code = objective.Code;
            Name = objective.Name;
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
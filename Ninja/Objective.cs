// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class Objective : DataUnit, IObjective, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public override Source Source { get; set; } = Source.Objectives;

        /// <summary>
        /// Gets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        public override string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Objective"/> class.
        /// </summary>
        public Objective( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Objective"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public Objective( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "ObjectivesId" ].ToString( ) );
            Name = Record[ "Name" ].ToString(  );
            Code = Record[ "Code" ].ToString(  );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Objective"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public Objective( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record[ "ObjectivesId" ].ToString( ) );
            Name = Record[ "Name" ].ToString(  );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Objective"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public Objective( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "ObjectivesId" ].ToString( ) );
            Name = dataRow[ "Name" ].ToString(  );
            Code = dataRow[ "Code" ].ToString(  );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Objective"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public Objective( string code )
        {
            Record = new DataBuilder( Source, SetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "ObjectivesId" ].ToString( ) );
            Name = Record[ "Field.Name" ].ToString(  );
            Code = Record[ "Code" ].ToString(  );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        /// <returns>
        /// </returns>
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

        /// <summary>
        /// Gets the objective.
        /// </summary>
        /// <returns>
        /// </returns>
        public IObjective GetObjective( )
        {
            try
            {
                return MemberwiseClone( ) as Objective;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IObjective );
            }
        }
    }
}
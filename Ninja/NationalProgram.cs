﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
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
    /// <seealso cref="INationalProgram"/>
    /// <seealso cref="ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "Performance", "CA1822:Mark members as static" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class NationalProgram : DataUnit 
    {
        /// <summary> The source </summary>
        public override Source Source { get; set; } = Source.NationalPrograms;

        /// <summary> Gets the record. </summary>
        /// <value> The record. </value>
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

        /// <summary> Gets the title. </summary>
        /// <value> The title. </value>
        public string Title { get; set; }

        /// <summary> Gets the rpio code. </summary>
        /// <value> The rpio code. </value>
        public string RpioCode { get; set; }

        /// <summary> Gets or sets the NPM. </summary>
        /// <value> The NPM. </value>
        public NPM NPM { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="NationalProgram"/>
        /// class.
        /// </summary>
        public NationalProgram( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="NationalProgram"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public NationalProgram( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "NationalProgramsId" ].ToString( ) );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Data = Record?.ToDictionary( );
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="NationalProgram"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public NationalProgram( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record[ "NationalProgramsId" ].ToString( ) );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Data = Record?.ToDictionary( );
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="NationalProgram"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public NationalProgram( DataRow dataRow )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "NationalProgramsId" ].ToString( ) );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Data = Record?.ToDictionary( );
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="NationalProgram"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public NationalProgram( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "NationalProgramsId" ].ToString( ) );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Data = Record?.ToDictionary( );
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code );
        }

        public NationalProgram( NationalProgram npm )
        {
            ID = npm.ID;
            Code = npm.Code;
            Name = npm.Name;
            NPM = npm.NPM;
            Title = npm.Title;
            RpioCode = npm.RpioCode;
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
                    return default;
                }
            }

            return default;
        }
    }
}
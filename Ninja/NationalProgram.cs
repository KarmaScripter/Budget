// <copyright file = "NationalProgram.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "Performance", "CA1822:Mark members as static" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class NationalProgram : DataUnit 
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public string RpioCode { get; set; }

        /// <summary>
        /// Gets or sets the NPM.
        /// </summary>
        /// <value>
        /// The NPM.
        /// </value>
        public NPM NPM { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NationalProgram"/> class.
        /// </summary>
        public NationalProgram( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NationalProgram"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
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
        /// Initializes a new instance of the <see cref="NationalProgram"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
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
        /// Initializes a new instance of the <see cref="NationalProgram"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
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
        /// Initializes a new instance of the <see cref="NationalProgram"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="NationalProgram"/> class.
        /// </summary>
        /// <param name="npm">The NPM.</param>
        public NationalProgram( NationalProgram npm )
        {
            ID = npm.ID;
            Code = npm.Code;
            Name = npm.Name;
            NPM = npm.NPM;
            Title = npm.Title;
            RpioCode = npm.RpioCode;
        }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
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
// <copyright file = "ProgramArea.cs" company = "Terry D.Eppler">
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
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ProgramArea : DataUnit, IProgramArea
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramArea"/>
        /// class.
        /// </summary>
        public ProgramArea( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramArea"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ProgramArea( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "ProgramAreasId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramArea"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public ProgramArea( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record[ "ProgramAreasId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramArea"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public ProgramArea( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "ProgramAreasId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramArea"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public ProgramArea( string code )
        {
            Record = new DataBuilder( Source, SetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "ProgramAreasId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        public ProgramArea( IProgramArea area )
        {
            ID = area.ID;
            Code = area.Code;
            Name = area.Name;
        }

        /// <summary> Gets the program area. </summary>
        /// <returns> </returns>
        public IProgramArea GetProgramArea( )
        {
            try
            {
                return MemberwiseClone( ) as ProgramArea;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ProgramArea );
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
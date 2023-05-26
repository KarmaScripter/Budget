// <copyright file = "Goal.cs" company = "Terry D.Eppler">
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
    /// <seealso cref="ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class Goal : DataUnit 
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Goal"/>
        /// class.
        /// </summary>
        public Goal( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Goal"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Goal( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "GoalsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Goal"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public Goal( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record[ "GoalsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Goal"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public Goal( DataRow dataRow )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "GoalsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Goal"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public Goal( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "GoalsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Goal"/>
        /// class.
        /// </summary>
        /// <param name="goal"> The goal. </param>
        public Goal( Goal goal )
        {
            ID = goal.ID;
            Code = goal.Code;
            Name = goal.Name;
        }

        /// <summary> Sets the arguments. </summary>
        /// <param name="goal"> The goal. </param>
        /// <returns> </returns>
        public IDictionary<string, object> GetArgs( int goal )
        {
            if( ( goal > 0 )
               && ( goal < 5 ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ "Code" ] = goal.ToString( ) };
                }
                catch( SystemException ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }

        /// <summary> Gets the source. </summary>
        /// <returns> </returns>
        public Source GetSource( )
        {
            try
            {
                return Enum.IsDefined( typeof( Source ), Source )
                    ? Source
                    : default( Source );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Source );
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
                    return new Dictionary<string, object> { [ "Code" ] = code };
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
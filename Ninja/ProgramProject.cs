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
    /// <seealso cref="BudgetExecution.DescriptionBase"/>
    /// <seealso cref="BudgetExecution.ISource"/>
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class ProgramProject : DescriptionBase, ISource
    {
        /// <summary> Gets or sets the code. </summary>
        /// <value> The code. </value>
        public override string Code { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        public override string Name { get; set; }

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

        /// <summary> The source </summary>
        public override Source Source { get; set; } = Source.ProgramDescriptions;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProject"/>
        /// class.
        /// </summary>
        public ProgramProject( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProject"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ProgramProject( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "ProgramProjectsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Definition = Record[ "Definition" ].ToString( );
            Laws = Record[ "Laws" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProject"/>
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The dataBuilder. </param>
        public ProgramProject( IDataModel dataBuilder )
        {
            Record = dataBuilder?.Record;
            ID = int.Parse( Record[ "ProgramProjectsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Definition = Record[ "Definition" ].ToString( );
            Laws = Record[ "Laws" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProject"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public ProgramProject( DataRow dataRow )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "ProgramProjectsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Definition = Record[ "Definition" ].ToString( );
            Laws = Record[ "Laws" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProject"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public ProgramProject( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "ProgramProjectsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Definition = Record[ "Definition" ].ToString( );
            Laws = Record[ "Laws" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }
    }
}
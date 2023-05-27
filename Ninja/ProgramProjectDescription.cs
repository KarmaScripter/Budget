// <copyright file = "ProgramProjectDescription.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ProgramProjectDescription : DescriptionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramProjectDescription"/> class.
        /// </summary>
        public ProgramProjectDescription( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramProjectDescription"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public ProgramProjectDescription( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
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
        /// Initializes a new instance of the <see cref="ProgramProjectDescription"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public ProgramProjectDescription( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
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
        /// Initializes a new instance of the <see cref="ProgramProjectDescription"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public ProgramProjectDescription( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "ProgramProjectsId" ].ToString( ) );
            Code = dataRow[ "Code" ].ToString( );
            Name = dataRow[ "Name" ].ToString( );
            Title = dataRow[ "Title" ].ToString( );
            Definition = dataRow[ "Definition" ].ToString( );
            Laws = dataRow[ "Laws" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }
    }
}
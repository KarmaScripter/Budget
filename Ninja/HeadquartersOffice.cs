// <copyright file = "HeadquartersOffice.cs" company = "Terry D.Eppler">
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
    /// <seealso cref="BudgetExecution.IHeadquartersOffice" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class HeadquartersOffice : DataUnit, IHeadquartersOffice
    {
        /// <summary>
        /// Get or sets the RPIO
        /// </summary>
        public string RPIO { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadquartersOffice"/> class.
        /// </summary>
        public HeadquartersOffice( )
        {
            Source = Source.HeadquartersOffices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadquartersOffice"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public HeadquartersOffice( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadquartersOffice"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public HeadquartersOffice( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadquartersOffice"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public HeadquartersOffice( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadquartersOffice"/> class.
        /// </summary>
        /// <param name="npm">The NPM.</param>
        public HeadquartersOffice( IHeadquartersOffice npm )
        {
            ID = npm.ID;
            RPIO = npm.RPIO;
            Code = npm.Code;
            Name = npm.Name;
        }
    }
}
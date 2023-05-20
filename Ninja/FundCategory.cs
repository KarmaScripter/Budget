// <copyright file = "FundCategory .cs" company = "Terry D.Eppler">
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
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class FundCategory : DataUnit 
    {
        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>
        /// The short name.
        /// </value>
        public string ShortName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundCategory"/> class.
        /// </summary>
        public FundCategory( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundCategory"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public FundCategory( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundCategory"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public FundCategory( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundCategory"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public FundCategory( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundCategory"/> class.
        /// </summary>
        /// <param name="fundCategory">The fund category.</param>
        public FundCategory( FundCategory fundCategory )
        {
            ID = fundCategory.ID;
            Code = fundCategory.Code;
            Name = fundCategory.Name;
            ShortName = fundCategory.ShortName;
        }
    }
}
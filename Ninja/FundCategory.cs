﻿// <copyright file = "FundCategory.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class FundCategory : DataUnit, IFundCategory
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// 
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public override string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>
        /// The short name.
        /// </value>
        public string ShortName { get; set; }
        
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

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
        
        public FundCategory( IFundCategory fundCategory )
        {
            ID = fundCategory.ID;
            Code = fundCategory.Code;
            Name = fundCategory.Name;
            ShortName = fundCategory.ShortName;
        }
    }
}

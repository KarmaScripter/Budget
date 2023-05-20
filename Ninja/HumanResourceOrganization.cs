// <copyright file = "HumanResourceOrganization.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class HumanResourceOrganization : DataUnit
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HumanResourceOrganization"/>
        /// class.
        /// </summary>
        public HumanResourceOrganization( )
        {
            Source = Source.HumanResourceOrganizations;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HumanResourceOrganization"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public HumanResourceOrganization( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "HumanResourceOrganizationsId" ].ToString( ) ?? string.Empty );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HumanResourceOrganization"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public HumanResourceOrganization( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "HumanResourceOrganizationsId" ].ToString( ) ?? string.Empty );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HumanResourceOrganization"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public HumanResourceOrganization( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "HumanResourceOrganizationsId" ].ToString( ) ?? string.Empty );
            Code = dataRow[ "Code" ].ToString( );
            Name = dataRow[ "Name" ].ToString( );
        }

        public HumanResourceOrganization( IDataUnit org )
        {
            ID = org.ID;
            Code = org.Code;
            Name = org.Name;
        }
    }
}
﻿// <copyright file = "ActivityCode.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ActivityCode : DataUnit, IActivityCode
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; } = Source.ActivityCodes;

        /// <summary>
        /// Gets the dataRow.
        /// </summary>
        /// <value>
        /// The dataRow.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        public override string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCode"/> class.
        /// </summary>
        public ActivityCode( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCode"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public ActivityCode( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = GetId( Record, PrimaryKey.ActivityCodesId  );
            Name = Record[ $"{ Field.ActivityName }" ].ToString( );
            Code = Record[ $"{ Field.ActivityCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCode"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public ActivityCode( IDataModel builder )
        {
            Record = builder?.Record;
            ID = GetId( Record, PrimaryKey.ActivityCodesId  );
            Name = Record[ $"{ Field.ActivityName }" ].ToString( );
            Code = Record[ $"{ Field.ActivityCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCode"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public ActivityCode( DataRow dataRow )
        {
            Record = dataRow;
            ID = GetId( dataRow, PrimaryKey.ActivityCodesId  );
            Name = dataRow[ $"{ Field.ActivityName }" ].ToString( );
            Code = dataRow[ $"{ Field.ActivityCode }" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        public ActivityCode( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = GetId( Record, PrimaryKey.ActivityCodesId  );
            Name = Record[ $"{ Field.ActivityName }" ].ToString( );
            Code = Record[ $"{ Field.ActivityCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }
        
        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> GetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object>
                    {
                        [ $"{ Field.ActivityCode }" ] = code
                    };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Data?.Any( ) == true
                    ? Data
                    : default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Gets the activity.
        /// </summary>
        /// <returns></returns>
        public ActivityCode GetActivity( )
        {
            return MemberwiseClone(  ) as ActivityCode;
        }
    }
}

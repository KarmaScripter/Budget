// <copyright file = "ObjectClassOutlays.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    public class ObjectClassOutlay
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectClassOutlay"/> class.
        /// </summary>
        public ObjectClassOutlay( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectClassOutlay"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public ObjectClassOutlay( IQuery query )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectClassOutlay"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public ObjectClassOutlay( IDataModel builder )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectClassOutlay"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public ObjectClassOutlay( DataRow dataRow )
        {
        }
    }
}

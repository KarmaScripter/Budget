// <copyright file = "Reprogramming.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    public class Reprogramming
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
        /// Initializes a new instance of the <see cref="Reprogramming" /> class.
        /// </summary>
        public Reprogramming( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reprogramming" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Reprogramming( IQuery query )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reprogramming" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public Reprogramming( IDataModel builder )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reprogramming" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Reprogramming( DataRow dataRow )
        {
        }
    }
}

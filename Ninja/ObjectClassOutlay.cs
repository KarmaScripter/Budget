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
        /// Gets or sets the report year.
        /// </summary>
        /// <value>
        /// The report year.
        /// </value>
        public string ReportYear { get; set; }

        /// <summary>
        /// Gets or sets the omb agency code.
        /// </summary>
        /// <value>
        /// The omb agency code.
        /// </value>
        public string OmbAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the omb agency.
        /// </summary>
        /// <value>
        /// The name of the omb agency.
        /// </value>
        public string OmbAgencyName { get; set; }

        /// <summary>
        /// Gets or sets the omb bureau code.
        /// </summary>
        /// <value>
        /// The omb bureau code.
        /// </value>
        public string OmbBureauCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the omb bureau.
        /// </summary>
        /// <value>
        /// The name of the omb bureau.
        /// </value>
        public string OmbBureauName { get; set; }

        /// <summary>
        /// Gets or sets the omb account code.
        /// </summary>
        /// <value>
        /// The omb account code.
        /// </value>
        public string OmbAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the omb account.
        /// </summary>
        /// <value>
        /// The name of the omb account.
        /// </value>
        public string OmbAccountName { get; set; }

        /// <summary>
        /// Gets or sets the direct reimbursable.
        /// </summary>
        /// <value>
        /// The direct reimbursable.
        /// </value>
        public string DirectReimbursable { get; set; }

        /// <summary>
        /// Gets or sets the direct reimbursable title.
        /// </summary>
        /// <value>
        /// The direct reimbursable title.
        /// </value>
        public string DirectReimbursableTitle { get; set; }

        /// <summary>
        /// Gets or sets the object class group number.
        /// </summary>
        /// <value>
        /// The object class group number.
        /// </value>
        public string ObjectClassGroupNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the object class group.
        /// </summary>
        /// <value>
        /// The name of the object class group.
        /// </value>
        public string ObjectClassGroupName { get; set; }

        /// <summary>
        /// Gets or sets the finance object class.
        /// </summary>
        /// <value>
        /// The finance object class.
        /// </value>
        public string FinanceObjectClass { get; set; }

        /// <summary>
        /// Gets or sets the prior year.
        /// </summary>
        /// <value>
        /// The prior year.
        /// </value>
        public double PriorYear { get; set; }

        /// <summary>
        /// Gets or sets the current year.
        /// </summary>
        /// <value>
        /// The current year.
        /// </value>
        public double CurrentYear { get; set; }

        /// <summary>
        /// Gets or sets the budget year.
        /// </summary>
        /// <value>
        /// The budget year.
        /// </value>
        public double BudgetYear { get; set; }
        
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

// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class AdministrativeRequest
    {
        public int ID { get; set; }
        
        public string Analyst { get; set; }
        
        public string RpioCode { get; set; }
        
        public string DocumentTitle { get; set; }

        public double Amount { get; set; }
        
        public string FundCode { get; set; }
        
        public string BFY { get; set; }
        
        public string Status { get; set; }

        public DateOnly OriginalActionDate { get; set; }
        
        public DateOnly LastActionDate { get; set; }

        public double Duration { get; set; }
        
        public string BudgetFormulationSystem  { get; set; }
        
        public string Comments { get; set; }
        
        public string RequestType { get; set; }
        
        public string TypeCode { get; set; }
        
        public string Decision { get; set; }

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

        public AdministrativeRequest( )
        {
        }

        public AdministrativeRequest( IQuery query )
        {
        }

        public AdministrativeRequest( IDataModel builder )
        {
        }

        public AdministrativeRequest( DataRow dataRow )
        {
            
        }
        
    }
}

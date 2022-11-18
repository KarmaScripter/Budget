// <copyright file = "SiteProjectCode.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class SiteProjectCode
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public SiteProjectCode( )
        {
        }
        
        public SiteProjectCode( IQuery query )
        {
        }

        public SiteProjectCode( IDataModel builder )
        {
        }

        public SiteProjectCode( DataRow dataRow )
        {
        }
    }
}

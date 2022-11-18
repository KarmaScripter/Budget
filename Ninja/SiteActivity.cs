// <copyright file = "StieActivity.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class SiteActivity
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public SiteActivity( )
        {
        }
        
        public SiteActivity( IQuery query )
        {
        }

        public SiteActivity( IDataModel builder )
        {
        }

        public SiteActivity( DataRow dataRow )
        {
        }
    }
}

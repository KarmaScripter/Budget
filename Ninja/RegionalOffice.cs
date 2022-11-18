// <copyright file = "RegionalOffice.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class RegionalOffice : ResourcePlanningOffice
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public RegionalOffice( )
        {
        }
        
        public RegionalOffice( IQuery query )
        {
        }

        public RegionalOffice( IDataModel builder )
        {
        }

        public RegionalOffice( DataRow dataRow )
        {
        }
    }
}

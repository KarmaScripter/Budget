// <copyright file = "HumanResourceOrganization.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class HumanResourceOrganization
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public HumanResourceOrganization( )
        {
        }
        
        public HumanResourceOrganization( IQuery query )
        {
        }

        public HumanResourceOrganization( IDataModel builder )
        {
        }

        public HumanResourceOrganization( DataRow dataRow )
        {
        }
    }
}

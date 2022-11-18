// <copyright file = "ProjectCostCode.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ProjectCostCode
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ProjectCostCode( )
        {
        }
        
        public ProjectCostCode( IQuery query )
        {
        }

        public ProjectCostCode( IDataModel builder )
        {
        }

        public ProjectCostCode( DataRow dataRow )
        {
        }
    }
}

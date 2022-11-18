// <copyright file = "Project.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Project
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Project( )
        {
        }
        
        public Project( IQuery query )
        {
        }

        public Project( IDataModel builder )
        {
        }

        public Project( DataRow dataRow )
        {
        }
    }
}

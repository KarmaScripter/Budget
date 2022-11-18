// <copyright file = "StatusOfBudgetaryResources.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class StatusOfBudgetaryResources
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public StatusOfBudgetaryResources( )
        {
        }
        
        public StatusOfBudgetaryResources( IQuery query )
        {
        }

        public StatusOfBudgetaryResources( IDataModel builder )
        {
        }

        public StatusOfBudgetaryResources( DataRow dataRow )
        {
        }
    }
}

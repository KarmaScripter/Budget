// <copyright file = "RecoveryAct.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class RecoveryAct
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public RecoveryAct( )
        {
        }
        
        public RecoveryAct( IQuery query )
        {
        }

        public RecoveryAct( IDataModel builder )
        {
        }

        public RecoveryAct( DataRow dataRow )
        {
        }
    }
}

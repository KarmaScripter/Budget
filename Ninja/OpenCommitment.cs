// <copyright file = "OpenCommitment.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class OpenCommitment
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public OpenCommitment( )
        {
        }
        
        public OpenCommitment( IQuery query )
        {
        }

        public OpenCommitment( IDataModel builder )
        {
        }

        public OpenCommitment( DataRow dataRow )
        {
        }
    }
}

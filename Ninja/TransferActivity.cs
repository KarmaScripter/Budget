// <copyright file = "TransferActivity.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class TransferActivity
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public TransferActivity( )
        {
        }
        
        public TransferActivity( IQuery query )
        {
        }

        public TransferActivity( IDataModel builder )
        {
        }

        public TransferActivity( DataRow dataRow )
        {
        }
    }
}

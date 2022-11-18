// <copyright file = "MonthlyLedgerAccountBalance.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class MonthlyLedgerAccountBalance
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public MonthlyLedgerAccountBalance( )
        {
        }
        
        public MonthlyLedgerAccountBalance( IQuery query )
        {
        }

        public MonthlyLedgerAccountBalance( IDataModel builder )
        {
        }

        public MonthlyLedgerAccountBalance( DataRow dataRow )
        {
        }
    }
}

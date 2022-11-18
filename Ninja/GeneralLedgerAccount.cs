// <copyright file = "GeneralLedgerAccount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class GeneralLedgerAccount
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public GeneralLedgerAccount( )
        {
        }
        
        public GeneralLedgerAccount( IQuery query )
        {
        }

        public GeneralLedgerAccount( IDataModel builder )
        {
        }

        public GeneralLedgerAccount( DataRow dataRow )
        {
        }
    }
}

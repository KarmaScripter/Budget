// <copyright file = "SpecialAccount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class SpecialAccount
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public SpecialAccount( )
        {
        }
        
        public SpecialAccount( IQuery query )
        {
        }

        public SpecialAccount( IDataModel builder )
        {
        }

        public SpecialAccount( DataRow dataRow )
        {
        }
    }
}

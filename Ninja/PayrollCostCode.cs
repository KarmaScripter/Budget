// <copyright file = "PayrollCostCodes.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class PayrollCostCode
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public PayrollCostCode( )
        {
        }
        
        public PayrollCostCode( IQuery query )
        {
        }

        public PayrollCostCode( IDataModel builder )
        {
        }

        public PayrollCostCode( DataRow dataRow )
        {
        }
    }
}

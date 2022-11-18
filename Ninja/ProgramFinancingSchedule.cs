// <copyright file = "ProgramFinancingSchedule.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ProgramFinancingSchedule
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ProgramFinancingSchedule( )
        {
        }
        
        public ProgramFinancingSchedule( IQuery query )
        {
        }

        public ProgramFinancingSchedule( IDataModel builder )
        {
        }

        public ProgramFinancingSchedule( DataRow dataRow )
        {
        }
    }
}

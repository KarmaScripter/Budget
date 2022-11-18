// <copyright file = "ProgramDescription.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ProgramDescription
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ProgramDescription( )
        {
        }
        
        public ProgramDescription( IQuery query )
        {
        }

        public ProgramDescription( IDataModel builder )
        {
        }

        public ProgramDescription( DataRow dataRow )
        {
        }
    }
}

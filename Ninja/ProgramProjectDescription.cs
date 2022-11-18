// <copyright file = "ProgramProjectDescriptions.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ProgramProjectDescription
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ProgramProjectDescription( )
        {
        }
        
        public ProgramProjectDescription( IQuery query )
        {
        }

        public ProgramProjectDescription( IDataModel builder )
        {
        }

        public ProgramProjectDescription( DataRow dataRow )
        {
        }
    }
}

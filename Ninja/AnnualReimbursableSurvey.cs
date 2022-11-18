// <copyright file = "AnnualReimbursableSurvey.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class AnnualReimbursableSurvey
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public AnnualReimbursableSurvey( )
        {
        }
        
        public AnnualReimbursableSurvey( IQuery query )
        {
        }

        public AnnualReimbursableSurvey( IDataModel builder )
        {
        }

        public AnnualReimbursableSurvey( DataRow dataRow )
        {
        }
    }
}

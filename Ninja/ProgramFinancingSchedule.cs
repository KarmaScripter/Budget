// <copyright file = "ProgramFinancingSchedulecs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ProgramFinancingSchedule
    {
        public int ID { get; set; }

        public string ReportYear { get; set; }

        public string TreasuryAgencyCode { get; set; }

        public string TreasuryAccountCode { get; set; }

        public string LedgerAccountCode { get; set; }

        public string SectionNumber { get; set; }

        public string SectionName { get; set; }

        public string LineNumber { get; set; }

        public string LineDescription { get; set; }

        public string OmbAgencyCode { get; set; }

        public string OmbFundCode { get; set; }

        public string OmbAccountTitle { get; set; }

        public string AgencySequence { get; set; }

        public string AccountSequence { get; set; }

        public string FundName { get; set; }

        public double OriginalAmount { get; set; }

        public double BudgetAmount { get; set; }

        public double AgencyAmount { get; set; }

        public double Amount { get; set; }

        public string AgencyName { get; set; }

        public Source Source { get; set; }

        public DataRow Record { get; set; }

        public IDictionary<string, object> Data { get; set; }

        public ProgramFinancingSchedule( )
        {
        }

        public ProgramFinancingSchedule( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        public ProgramFinancingSchedule( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        public ProgramFinancingSchedule( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
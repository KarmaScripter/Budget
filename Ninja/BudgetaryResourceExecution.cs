﻿// <copyright file = "BudgetaryResourceExecution.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class BudgetaryResourceExecution : DataUnit, IBudgetaryResourceExecution
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the fiscal year.
        /// </summary>
        /// <value>
        /// The fiscal year.
        /// </value>
        public string FiscalYear { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public string EFY { get; set; }

        /// <summary>
        /// Gets or sets the last update.
        /// </summary>
        /// <value>
        /// The last update.
        /// </value>
        public DateOnly LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the treasury symbol.
        /// </summary>
        /// <value>
        /// The treasury symbol.
        /// </value>
        public string BudgetAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the omb account.
        /// </summary>
        /// <value>
        /// The omb account.
        /// </value>
        public string BudgetAccountName { get; set; }

        /// <summary>
        /// Gets or sets the treasury agency code.
        /// </summary>
        /// <value>
        /// The treasury agency code.
        /// </value>
        public string TreasuryAccountName { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the stat.
        /// </summary>
        /// <value>
        /// The stat.
        /// </value>
        public string STAT { get; set; }

        /// <summary>
        /// Gets or sets the credit indicator.
        /// </summary>
        /// <value>
        /// The credit indicator.
        /// </value>
        public string CreditIndicator { get; set; }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        /// <value>
        /// The line number.
        /// </value>
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the line description.
        /// </summary>
        /// <value>
        /// The line description.
        /// </value>
        public string LineDescription { get; set; }

        /// <summary>
        /// Gets or sets the name of the section.
        /// </summary>
        /// <value>
        /// The name of the section.
        /// </value>
        public string SectionName { get; set; }

        /// <summary>
        /// Gets or sets the section number.
        /// </summary>
        /// <value>
        /// The section number.
        /// </value>
        public string SectionNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the line.
        /// </summary>
        /// <value>
        /// The type of the line.
        /// </value>
        public string LineType { get; set; }

        /// <summary>
        /// Gets or sets the financing accounts.
        /// </summary>
        /// <value>
        /// The financing accounts.
        /// </value>
        public string FinancingAccounts { get; set; }

        /// <summary>
        /// Gets or sets the november.
        /// </summary>
        /// <value>
        /// The november.
        /// </value>
        public double November { get; set; }

        /// <summary>
        /// Gets or sets the january.
        /// </summary>
        /// <value>
        /// The january.
        /// </value>
        public double January { get; set; }

        /// <summary>
        /// Gets or sets the feburary.
        /// </summary>
        /// <value>
        /// The feburary.
        /// </value>
        public double February { get; set; }

        /// <summary>
        /// Gets or sets the april.
        /// </summary>
        /// <value>
        /// The april.
        /// </value>
        public double April { get; set; }

        /// <summary>
        /// Gets or sets the may.
        /// </summary>
        /// <value>
        /// The may.
        /// </value>
        public double May { get; set; }

        /// <summary>
        /// Gets or sets the june.
        /// </summary>
        /// <value>
        /// The june.
        /// </value>
        public double June { get; set; }

        /// <summary>
        /// Gets or sets the august.
        /// </summary>
        /// <value>
        /// The august.
        /// </value>
        public double August { get; set; }

        /// <summary>
        /// Gets or sets the october.
        /// </summary>
        /// <value>
        /// The october.
        /// </value>
        public double October { get; set; }

        /// <summary>
        /// Gets or sets the amount1.
        /// </summary>
        /// <value>
        /// The amount1.
        /// </value>
        public double Amount1 { get; set; }

        /// <summary>
        /// Gets or sets the amount2.
        /// </summary>
        /// <value>
        /// The amount2.
        /// </value>
        public double Amount2 { get; set; }

        /// <summary>
        /// Gets or sets the amount3.
        /// </summary>
        /// <value>
        /// The amount3.
        /// </value>
        public double Amount3 { get; set; }

        /// <summary>
        /// Gets or sets the amount4.
        /// </summary>
        /// <value>
        /// The amount4.
        /// </value>
        public double Amount4 { get; set; }
        
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Provider
        /// </summary>
        public override Provider Provider { get; set; }
        
        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetaryResourceExecution"/> class.
        /// </summary>
        public BudgetaryResourceExecution( )
        {
            Source = Source.BudgetaryResourceExecution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetaryResourceExecution"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetaryResourceExecution( IQuery query ) 
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            FiscalYear = Record[ "FiscalYear" ].ToString(  );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            LastUpdate = DateOnly.Parse( Record[ "LastUpdate" ].ToString(  ) ?? "" );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            STAT = Record[ "STAT" ].ToString(  );
            CreditIndicator = Record[ "CreditIndicator" ].ToString(  );
            LineNumber = Record[ "LineNumber" ].ToString(  );
            LineDescription = Record[ "LineDescription" ].ToString(  );
            SectionName = Record[ "SectionName" ].ToString(  );
            SectionNumber = Record[ "SectionNumber" ].ToString(  );
            LineType = Record[ "LineType" ].ToString(  );
            FinancingAccounts = Record[ "FinancingAccounts" ].ToString(  );
            November = double.Parse( Record[ "November" ].ToString( ) ?? "0" );
            January = double.Parse( Record[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( Record[ "February" ].ToString( ) ?? "0" );
            April = double.Parse( Record[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( Record[ " May" ].ToString( ) ?? "0" );
            June = double.Parse( Record[ "June" ].ToString( ) ?? "0" );
            August = double.Parse( Record[ "August" ].ToString( ) ?? "0" );
            October = double.Parse( Record[ "October" ].ToString( ) ?? "0" );
            Amount1 = double.Parse( Record[ "Amount1" ].ToString( ) ?? "0" );
            Amount2 = double.Parse( Record[ "Amount2" ].ToString( ) ?? "0" );
            Amount3 = double.Parse( Record[ "Amount3" ].ToString( ) ?? "0" );
            Amount4 = double.Parse( Record[ "Amount4" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetaryResourceExecution"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public BudgetaryResourceExecution( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            FiscalYear = Record[ "FiscalYear" ].ToString(  );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            LastUpdate = DateOnly.Parse( Record[ "LastUpdate" ].ToString(  ) ?? "" );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            STAT = Record[ "STAT" ].ToString(  );
            CreditIndicator = Record[ "CreditIndicator" ].ToString(  );
            LineNumber = Record[ "LineNumber" ].ToString(  );
            LineDescription = Record[ "LineDescription" ].ToString(  );
            SectionName = Record[ "SectionName" ].ToString(  );
            SectionNumber = Record[ "SectionNumber" ].ToString(  );
            LineType = Record[ "LineType" ].ToString(  );
            FinancingAccounts = Record[ "FinancingAccounts" ].ToString(  );
            November = double.Parse( Record[ "November" ].ToString( ) ?? "0" );
            January = double.Parse( Record[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( Record[ "February" ].ToString( ) ?? "0" );
            April = double.Parse( Record[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( Record[ " May" ].ToString( ) ?? "0" );
            June = double.Parse( Record[ "June" ].ToString( ) ?? "0" );
            August = double.Parse( Record[ "August" ].ToString( ) ?? "0" );
            October = double.Parse( Record[ "October" ].ToString( ) ?? "0" );
            Amount1 = double.Parse( Record[ "Amount1" ].ToString( ) ?? "0" );
            Amount2 = double.Parse( Record[ "Amount2" ].ToString( ) ?? "0" );
            Amount3 = double.Parse( Record[ "Amount3" ].ToString( ) ?? "0" );
            Amount4 = double.Parse( Record[ "Amount4" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetaryResourceExecution"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetaryResourceExecution( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            FiscalYear = dataRow[ "FiscalYear" ].ToString(  );
            BFY =  dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            LastUpdate = DateOnly.Parse( dataRow[ "LastUpdate" ].ToString(  ) ?? "" );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString(  );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString(  );
            STAT = dataRow[ "STAT" ].ToString(  );
            CreditIndicator = dataRow[ "CreditIndicator" ].ToString(  );
            LineNumber = dataRow[ "LineNumber" ].ToString(  );
            LineDescription = dataRow[ "LineDescription" ].ToString(  );
            SectionName = dataRow[ "SectionName" ].ToString(  );
            SectionNumber = dataRow[ "SectionNumber" ].ToString(  );
            LineType = dataRow[ "LineType" ].ToString(  );
            FinancingAccounts = dataRow[ "FinancingAccounts" ].ToString(  );
            November = double.Parse( Record[ "November" ].ToString( ) ?? "0" );
            January = double.Parse( Record[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( Record[ "February" ].ToString( ) ?? "0" );
            April = double.Parse( Record[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( Record[ " May" ].ToString( ) ?? "0" );
            June = double.Parse( Record[ "June" ].ToString( ) ?? "0" );
            August = double.Parse( Record[ "August" ].ToString( ) ?? "0" );
            October = double.Parse( Record[ "October" ].ToString( ) ?? "0" );
            Amount1 = double.Parse( Record[ "Amount1" ].ToString( ) ?? "0" );
            Amount2 = double.Parse( Record[ "Amount2" ].ToString( ) ?? "0" );
            Amount3 = double.Parse( Record[ "Amount3" ].ToString( ) ?? "0" );
            Amount4 = double.Parse( Record[ "Amount4" ].ToString( ) ?? "0" );
        }
        public BudgetaryResourceExecution( IBudgetaryResourceExecution budget )
            : this( )
        {
            ID = budget.ID;
            FiscalYear = budget.FiscalYear;
            BFY = budget.BFY;
            EFY = budget.EFY;
            LastUpdate = budget.LastUpdate;
            BudgetAccountCode = budget.BudgetAccountCode;
            BudgetAccountName = budget.BudgetAccountName;
            TreasuryAccountCode = budget.TreasuryAccountCode;
            TreasuryAccountName = budget.TreasuryAccountName;
            STAT = budget.STAT;
            CreditIndicator = budget.CreditIndicator;
            LineNumber = budget.LineNumber;
            LineDescription = budget.LineDescription;
            SectionName = budget.SectionName;
            SectionNumber = budget.SectionNumber;
            LineType = budget.LineType;
            FinancingAccounts = budget.FinancingAccounts;
            November = budget.November;
            January = budget.January;
            February = budget.February;
            April = budget.April;
            May = budget.May;
            June = budget.June;
            August = budget.August;
            October = budget.October;
            Amount1 = budget.Amount1;
            Amount2 = budget.Amount2;
            Amount3 = budget.Amount3;
            Amount4 = budget.Amount4;
        }
    }
}

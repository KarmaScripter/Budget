// <copyright file = "BudgetDocument.cs" company = "Terry D. Eppler">
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
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class BudgetDocument
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

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
        /// Gets or sets the budget level.
        /// </summary>
        /// <value>
        /// The budget level.
        /// </value>
        public string BudgetLevel { get; set; }
        
        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or sets the document number.
        /// </summary>
        /// <value>
        /// The document number.
        /// </value>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the document date.
        /// </summary>
        /// <value>
        /// The document date.
        /// </value>
        public DateOnly DocumentDate { get; set; }

        /// <summary>
        /// Gets or sets the budgeted.
        /// </summary>
        /// <value>
        /// The budgeted.
        /// </value>
        public double Budgeted { get; set; }

        /// <summary>
        /// Gets or sets the posted.
        /// </summary>
        /// <value>
        /// The posted.
        /// </value>
        public double Posted { get; set; }

        /// <summary>
        /// Gets or sets the carry out.
        /// </summary>
        /// <value>
        /// The carry out.
        /// </value>
        public double CarryoverOut { get; set; }

        /// <summary>
        /// Gets or sets the carry in.
        /// </summary>
        /// <value>
        /// The carry in.
        /// </value>
        public double CarryoverIn { get; set; }

        /// <summary>
        /// Gets or sets the estimated recoveries.
        /// </summary>
        /// <value>
        /// The estimated recoveries.
        /// </value>
        public double Recoveries { get; set; }

        /// <summary>
        /// Gets or sets the estimated reimbursements.
        /// </summary>
        /// <value>
        /// The estimated reimbursements.
        /// </value>
        public double Reimbursements  { get; set; }
        
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDocument" /> class.
        /// </summary>
        public BudgetDocument( )
        {
            Source = Source.BudgetDocuments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDocument" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetDocument( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            DocumentType = Record[ "DocumentType" ].ToString(  );
            DocumentNumber = Record[ "DocumentNumber" ].ToString(  );
            DocumentDate = DateOnly.Parse( Record[ "DocumentDate" ].ToString(  ) ?? "" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString(  ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString(  ) ?? "0" );
            CarryoverOut = double.Parse( Record[ "CarryoverOut" ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( Record[ "CarryoverIn" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "EstimatedRecoveries" ].ToString(  ) ?? "0" );
            Reimbursements = 
                double.Parse( Record[ "EstimatedReimbursements" ].ToString(  ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDocument" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public BudgetDocument( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            DocumentType = Record[ "DocumentType" ].ToString(  );
            DocumentNumber = Record[ "DocumentNumber" ].ToString(  );
            DocumentDate = DateOnly.Parse( Record[ "DocumentDate" ].ToString(  ) ?? "" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString(  ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString(  ) ?? "0" );
            CarryoverOut = double.Parse( Record[ "CarryoverOut" ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( Record[ "CarryoverIn" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "EstimatedRecoveries" ].ToString(  ) ?? "0" );
            Reimbursements = 
                double.Parse( Record[ "EstimatedReimbursements" ].ToString(  ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDocument" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetDocument( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY =  dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            DocumentType = dataRow[ "DocumentType" ].ToString(  );
            DocumentNumber = dataRow[ "DocumentNumber" ].ToString(  );
            DocumentDate = DateOnly.Parse( dataRow[ "DocumentDate" ].ToString(  ) ?? "" );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString(  ) ?? "0" );
            Posted = double.Parse( dataRow[ "Posted" ].ToString(  ) ?? "0" );
            CarryoverOut = double.Parse( dataRow[ "CarryoverOut" ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( dataRow[ "CarryoverIn" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( dataRow[ "EstimatedRecoveries" ].ToString(  ) ?? "0" );
            Reimbursements = 
                double.Parse( dataRow[ "EstimatedReimbursements" ].ToString(  ) ?? "0" );
        }
    }
}

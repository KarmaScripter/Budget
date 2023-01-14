// <copyright file = "AppropriationDocument.cs" company = "Terry D. Eppler">
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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AppropriationDocument
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
        public string  BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public string  EFY { get; set; }

        /// <summary>
        /// Gets or sets the fund.
        /// </summary>
        /// <value>
        /// The fund.
        /// </value>
        public string  Fund { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string  FundCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        public string  DocumentType { get; set; }

        /// <summary>
        /// Gets or sets the document number.
        /// </summary>
        /// <value>
        /// The document number.
        /// </value>
        public string  DocumentNumber { get; set; }

        /// <summary>
        /// Gets or sets the document date.
        /// </summary>
        /// <value>
        /// The document date.
        /// </value>
        public DateOnly DocumentDate { get; set; }

        /// <summary>
        /// Gets or sets the last document date.
        /// </summary>
        /// <value>
        /// The last document date.
        /// </value>
        public DateOnly LastDocumentDate { get; set; }

        /// <summary>
        /// Gets or sets the budget level.
        /// </summary>
        /// <value>
        /// The budget level.
        /// </value>
        public string  BudgetLevel { get; set; }

        /// <summary>
        /// Gets or sets the budgeting controls.
        /// </summary>
        /// <value>
        /// The budgeting controls.
        /// </value>
        public string  BudgetingControls { get; set; }

        /// <summary>
        /// Gets or sets the posting controls.
        /// </summary>
        /// <value>
        /// The posting controls.
        /// </value>
        public string  PostingControls { get; set; }

        /// <summary>
        /// Gets or sets the pre commitment controls.
        /// </summary>
        /// <value>
        /// The pre commitment controls.
        /// </value>
        public string  PreCommitmentControls { get; set; }

        /// <summary>
        /// Gets or sets the commitment controls.
        /// </summary>
        /// <value>
        /// The commitment controls.
        /// </value>
        public string  CommitmentControls { get; set; }

        /// <summary>
        /// Gets or sets the obligation controls.
        /// </summary>
        /// <value>
        /// The obligation controls.
        /// </value>
        public string  ObligationControls { get; set; }

        /// <summary>
        /// Gets or sets the accrual controls.
        /// </summary>
        /// <value>
        /// The accrual controls.
        /// </value>
        public string  AccrualControls { get; set; }

        /// <summary>
        /// Gets or sets the expenditure controls.
        /// </summary>
        /// <value>
        /// The expenditure controls.
        /// </value>
        public string  ExpenditureControls { get; set; }

        /// <summary>
        /// Gets or sets the expense controls.
        /// </summary>
        /// <value>
        /// The expense controls.
        /// </value>
        public string  ExpenseControls { get; set; }

        /// <summary>
        /// Gets or sets the reimbursement controls.
        /// </summary>
        /// <value>
        /// The reimbursement controls.
        /// </value>
        public string  ReimbursementControls { get; set; }

        /// <summary>
        /// Gets or sets the reimbursable agreement controls.
        /// </summary>
        /// <value>
        /// The reimbursable agreement controls.
        /// </value>
        public string  ReimbursableAgreementControls { get; set; }

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
        public double CarryOut { get; set; }

        /// <summary>
        /// Gets or sets the carry in.
        /// </summary>
        /// <value>
        /// The carry in.
        /// </value>
        public double CarryIn { get; set; }

        /// <summary>
        /// Gets or sets the estimated reimbursements.
        /// </summary>
        /// <value>
        /// The estimated reimbursements.
        /// </value>
        public double EstimatedReimbursements { get; set; }

        /// <summary>
        /// Gets or sets the estimated recoveries.
        /// </summary>
        /// <value>
        /// The estimated recoveries.
        /// </value>
        public double EstimatedRecoveries { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the
        /// <see cref="AppropriationDocument"/> class.
        /// </summary>
        public AppropriationDocument( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationDocument"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AppropriationDocument( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationDocument"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public AppropriationDocument( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationDocument"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AppropriationDocument( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

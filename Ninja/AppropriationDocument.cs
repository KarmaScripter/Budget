// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class AppropriationDocument : DataUnit, IAppropriationDocument
    {
        /// <summary> Gets or sets the last document date. </summary>
        /// <value> The last document date. </value>
        public DateOnly LastDocumentDate { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public override Provider Provider { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AppropriationDocument"/>
        /// class.
        /// </summary>
        public AppropriationDocument( )
        {
            Source = Source.AppropriationDocuments;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AppropriationDocument"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public AppropriationDocument( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            ID = int.Parse( Record[ "AppropriationDocumentsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Fund = Record[ "Fund" ].ToString( );
            FundCode = Record[ "FundName" ].ToString( );
            DocumentType = Record[ "DocumentType" ].ToString( );
            DocumentNumber = Record[ "DocumentNumber" ].ToString( );
            DocumentDate = DateOnly.Parse( Record[ "DocumentDate" ].ToString( ) ?? "" );
            LastDocumentDate = DateOnly.Parse( Record[ "LastDocumentDate" ].ToString( ) ?? "" );
            BudgetingControls = Record[ "BudgetingControls" ].ToString( );
            PostingControls = Record[ "PostingControls" ].ToString( );
            PreCommitmentControls = Record[ "PreCommitmentControls" ].ToString( );
            CommitmentControls = Record[ "CommitmentControls" ].ToString( );
            ObligationControls = Record[ "ObligationControls" ].ToString( );
            AccrualControls = Record[ "AccrualControls" ].ToString( );
            ExpenseControls = Record[ "ExpenseControls" ].ToString( );
            ExpenditureControls = Record[ "ExpenditureControls" ].ToString( );
            ReimbursementControls = Record[ "ReimbursementControls" ].ToString( );
            ReimbursableAgreementControls = Record[ "ReimbursementAgreementControls" ].ToString( );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( Record[ "CarryoverOut" ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( Record[ "CarryoverIn" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AppropriationDocument"/>
        /// class.
        /// </summary>
        /// <param name = "builder" > The builder. </param>
        public AppropriationDocument( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "AppropriationDocumentsId" ].ToString( ) ?? "0" );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Fund = Record[ "Fund" ].ToString( );
            FundCode = Record[ "FundName" ].ToString( );
            DocumentType = Record[ "DocumentType" ].ToString( );
            DocumentNumber = Record[ "DocumentNumber" ].ToString( );
            DocumentDate = DateOnly.Parse( Record[ "DocumentDate" ].ToString( ) ?? "" );
            LastDocumentDate = DateOnly.Parse( Record[ "LastDocumentDate" ].ToString( ) ?? "" );
            BudgetingControls = Record[ "BudgetingControls" ].ToString( );
            PostingControls = Record[ "PostingControls" ].ToString( );
            PreCommitmentControls = Record[ "PreCommitmentControls" ].ToString( );
            CommitmentControls = Record[ "CommitmentControls" ].ToString( );
            ObligationControls = Record[ "ObligationControls" ].ToString( );
            AccrualControls = Record[ "AccrualControls" ].ToString( );
            ExpenseControls = Record[ "ExpenseControls" ].ToString( );
            ExpenditureControls = Record[ "ExpenditureControls" ].ToString( );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( Record[ "CarryoverOut" ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( Record[ "CarryoverIn" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AppropriationDocument"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The data row. </param>
        public AppropriationDocument( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "AppropriationDocumentsId" ].ToString( ) ?? "0" );
            BudgetLevel = dataRow[ "BudgetLevel" ].ToString( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            Fund = dataRow[ "Fund" ].ToString( );
            FundCode = dataRow[ "FundName" ].ToString( );
            DocumentType = dataRow[ "DocumentType" ].ToString( );
            DocumentNumber = dataRow[ "DocumentNumber" ].ToString( );
            DocumentDate = DateOnly.Parse( dataRow[ "DocumentDate" ].ToString( ) ?? "" );
            LastDocumentDate = DateOnly.Parse( dataRow[ "LastDocumentDate" ].ToString( ) ?? "" );
            BudgetingControls = dataRow[ "BudgetingControls" ].ToString( );
            PostingControls = dataRow[ "PostingControls" ].ToString( );
            PreCommitmentControls = dataRow[ "PreCommitmentControls" ].ToString( );
            CommitmentControls = dataRow[ "CommitmentControls" ].ToString( );
            ObligationControls = dataRow[ "ObligationControls" ].ToString( );
            AccrualControls = dataRow[ "AccrualControls" ].ToString( );
            ExpenseControls = dataRow[ "ExpenseControls" ].ToString( );
            ExpenditureControls = dataRow[ "ExpenditureControls" ].ToString( );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString( ) );
            Posted = double.Parse( dataRow[ "Posted" ].ToString( ) );
            CarryoverOut = double.Parse( dataRow[ "CarryoverOut" ].ToString( ) );
            CarryoverIn = double.Parse( dataRow[ "CarryoverIn" ].ToString( ) );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }

        public AppropriationDocument( IAppropriationDocument document )
        {
            ID = document.ID;
            BFY = document.BFY;
            EFY = document.EFY;
            Fund = document.Fund;
            FundCode = document.FundCode;
            DocumentType = document.DocumentType;
            DocumentNumber = document.DocumentNumber;
            DocumentDate = document.DocumentDate;
            BudgetingControls = document.BudgetingControls;
            PostingControls = document.PostingControls;
            PreCommitmentControls = document.PreCommitmentControls;
            CommitmentControls = document.CommitmentControls;
            ObligationControls = document.ObligationControls;
            AccrualControls = document.AccrualControls;
            ExpenditureControls = document.ExpenditureControls;
            Budgeted = document.Budgeted;
            Posted = document.Posted;
            CarryoverOut = document.CarryoverOut;
            CarryoverIn = document.CarryoverIn;
            Recoveries = document.Recoveries;
            Reimbursements = document.Reimbursements;
            TreasuryAccountCode = document.TreasuryAccountCode;
            TreasuryAccountName = document.TreasuryAccountName;
            BudgetAccountCode = document.BudgetAccountCode;
            BudgetAccountName = document.BudgetAccountName;
        }

        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        public string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        public string EFY { get; set; }

        /// <summary> Gets or sets the fund. </summary>
        /// <value> The fund. </value>
        public string Fund { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        public string FundCode { get; set; }

        /// <summary> Gets or sets the type of the document. </summary>
        /// <value> The type of the document. </value>
        public string DocumentType { get; set; }

        /// <summary> Gets or sets the document number. </summary>
        /// <value> The document number. </value>
        public string DocumentNumber { get; set; }

        /// <summary> Gets or sets the document date. </summary>
        /// <value> The document date. </value>
        public DateOnly DocumentDate { get; set; }

        /// <summary> Gets or sets the budget level. </summary>
        /// <value> The budget level. </value>
        public string BudgetLevel { get; set; }

        /// <summary> Gets or sets the budgeting controls. </summary>
        /// <value> The budgeting controls. </value>
        public string BudgetingControls { get; set; }

        /// <summary> Gets or sets the posting controls. </summary>
        /// <value> The posting controls. </value>
        public string PostingControls { get; set; }

        /// <summary> Gets or sets the pre commitment controls. </summary>
        /// <value> The pre commitment controls. </value>
        public string PreCommitmentControls { get; set; }

        /// <summary> Gets or sets the commitment controls. </summary>
        /// <value> The commitment controls. </value>
        public string CommitmentControls { get; set; }

        /// <summary> Gets or sets the obligation controls. </summary>
        /// <value> The obligation controls. </value>
        public string ObligationControls { get; set; }

        /// <summary> Gets or sets the accrual controls. </summary>
        /// <value> The accrual controls. </value>
        public string AccrualControls { get; set; }

        /// <summary> Gets or sets the expenditure controls. </summary>
        /// <value> The expenditure controls. </value>
        public string ExpenditureControls { get; set; }

        /// <summary> Gets or sets the expense controls. </summary>
        /// <value> The expense controls. </value>
        public string ExpenseControls { get; set; }

        /// <summary> Gets or sets the reimbursement controls. </summary>
        /// <value> The reimbursement controls. </value>
        public string ReimbursementControls { get; set; }

        /// <summary> Gets or sets the reimbursable agreement controls. </summary>
        /// <value> The reimbursable agreement controls. </value>
        public string ReimbursableAgreementControls { get; set; }

        /// <summary> Gets or sets the budgeted. </summary>
        /// <value> The budgeted. </value>
        public double Budgeted { get; set; }

        /// <summary> Gets or sets the posted. </summary>
        /// <value> The posted. </value>
        public double Posted { get; set; }

        /// <summary> Gets or sets the carry out. </summary>
        /// <value> The carry out. </value>
        public double CarryoverOut { get; set; }

        /// <summary> Gets or sets the carry in. </summary>
        /// <value> The carry in. </value>
        public double CarryoverIn { get; set; }

        /// <summary> Gets or sets the estimated reimbursements. </summary>
        /// <value> The estimated reimbursements. </value>
        public double Reimbursements { get; set; }

        /// <summary> Gets or sets the estimated recoveries. </summary>
        /// <value> The estimated recoveries. </value>
        public double Recoveries { get; set; }

        /// <summary> Gets or sets the treasury agency code. </summary>
        /// <value> The treasury agency code. </value>
        public string TreasuryAccountName { get; set; }

        /// <summary> Gets or sets the treasury account code. </summary>
        /// <value> The treasury account code. </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary> Gets or sets the budget account code. </summary>
        /// <value> The budget account code. </value>
        public string BudgetAccountCode { get; set; }

        /// <summary> Gets or sets the name of the budget account. </summary>
        /// <value> The name of the budget account. </value>
        public string BudgetAccountName { get; set; }
    }
}
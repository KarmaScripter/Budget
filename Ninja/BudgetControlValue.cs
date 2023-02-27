// <copyright file = "BudgetControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BudgetControlValue
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the security org.
        /// </summary>
        /// <value>
        /// The security org.
        /// </value>
        public string SecurityOrg { get; set; }

        /// <summary>
        /// Gets or sets the type of the budgeting trans.
        /// </summary>
        /// <value>
        /// The type of the budgeting trans.
        /// </value>
        public string BudgetingTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the posted trans.
        /// </summary>
        /// <value>
        /// The type of the posted trans.
        /// </value>
        public string PostedTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the estimated reimbursable trans.
        /// </summary>
        /// <value>
        /// The type of the estimated reimbursable trans.
        /// </value>
        public string EstimatedReimbursableTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the spending adjustment trans.
        /// </summary>
        /// <value>
        /// The type of the spending adjustment trans.
        /// </value>
        public string SpendingAdjustmentTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the estimated recoveries trans.
        /// </summary>
        /// <value>
        /// The type of the estimated recoveries trans.
        /// </value>
        public string EstimatedRecoveriesTransType { get; set; }

        /// <summary>
        /// Gets or sets the actual type of the recoveries trans.
        /// </summary>
        /// <value>
        /// The actual type of the recoveries trans.
        /// </value>
        public string ActualRecoveriesTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the stategic reserve trans.
        /// </summary>
        /// <value>
        /// The type of the stategic reserve trans.
        /// </value>
        public string StrategicReserveTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the prof loss trans.
        /// </summary>
        /// <value>
        /// The type of the prof loss trans.
        /// </value>
        public string ProfitLossTransType { get; set; }

        /// <summary>
        /// Gets or sets the estimated reimbursable spending option.
        /// </summary>
        /// <value>
        /// The estimated reimbursable spending option.
        /// </value>
        public string EstimatedReimbursableSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the estimated reimbursable budgeting option.
        /// </summary>
        /// <value>
        /// The estimated reimbursable budgeting option.
        /// </value>
        public string EstimatedReimbursableBudgetingOption { get; set; }

        /// <summary>
        /// Gets or sets the track agreement lower level.
        /// </summary>
        /// <value>
        /// The track agreement lower level.
        /// </value>
        public string TrackAgreementLowerLevel { get; set; }

        /// <summary>
        /// Gets or sets the budget estimate lower level.
        /// </summary>
        /// <value>
        /// The budget estimate lower level.
        /// </value>
        public string BudgetEstimateLowerLevel { get; set; }

        /// <summary>
        /// Gets or sets the estimated recoveries spending option.
        /// </summary>
        /// <value>
        /// The estimated recoveries spending option.
        /// </value>
        public string EstimatedRecoveriesSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the estimated recoveries budgeting option.
        /// </summary>
        /// <value>
        /// The estimated recoveries budgeting option.
        /// </value>
        public string EstimatedRecoveriesBudgetingOption { get; set; }

        /// <summary>
        /// Gets or sets the record next level.
        /// </summary>
        /// <value>
        /// The record next level.
        /// </value>
        public string RecordNextLevel { get; set; }

        /// <summary>
        /// Gets or sets the record budgeting mismatch.
        /// </summary>
        /// <value>
        /// The record budgeting mismatch.
        /// </value>
        public string RecordBudgetingMismatch { get; set; }

        /// <summary>
        /// Gets or sets the profit loss spending option.
        /// </summary>
        /// <value>
        /// The profit loss spending option.
        /// </value>
        public string ProfitLossSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the profit loss budgeting option.
        /// </summary>
        /// <value>
        /// The profit loss budgeting option.
        /// </value>
        public string ProfitLossBudgetingOption { get; set; }

        /// <summary>
        /// Gets or sets the record carry in lower level.
        /// </summary>
        /// <value>
        /// The record carry in lower level.
        /// </value>
        public string RecordCarryInLowerLevel { get; set; }

        /// <summary>
        /// Gets or sets the record carry in lower level control.
        /// </summary>
        /// <value>
        /// The record carry in lower level control.
        /// </value>
        public string RecordCarryInLowerLevelControl { get; set; }

        /// <summary>
        /// Gets or sets the record carry in amount control.
        /// </summary>
        /// <value>
        /// The record carry in amount control.
        /// </value>
        public string RecordCarryInAmountControl { get; set; }

        /// <summary>
        /// Gets or sets the budgeting control.
        /// </summary>
        /// <value>
        /// The budgeting control.
        /// </value>
        public string BudgetingControl { get; set; }

        /// <summary>
        /// Gets or sets the posting control.
        /// </summary>
        /// <value>
        /// The posting control.
        /// </value>
        public string PostingControl { get; set; }

        /// <summary>
        /// Gets or sets the pre commitment spending control.
        /// </summary>
        /// <value>
        /// The pre commitment spending control.
        /// </value>
        public string PreCommitmentSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the commitment spending control.
        /// </summary>
        /// <value>
        /// The commitment spending control.
        /// </value>
        public string CommitmentSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the obligation spending control.
        /// </summary>
        /// <value>
        /// The obligation spending control.
        /// </value>
        public string ObligationSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the accrual spending control.
        /// </summary>
        /// <value>
        /// The accrual spending control.
        /// </value>
        public string AccrualSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the expenditure spending control.
        /// </summary>
        /// <value>
        /// The expenditure spending control.
        /// </value>
        public string ExpenditureSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the expense spending control.
        /// </summary>
        /// <value>
        /// The expense spending control.
        /// </value>
        public string ExpenseSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the reimbursable spending control.
        /// </summary>
        /// <value>
        /// The reimbursable spending control.
        /// </value>
        public string ReimbursableSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the reimbursable agreement spending control.
        /// </summary>
        /// <value>
        /// The reimbursable agreement spending control.
        /// </value>
        public string ReimbursableAgreementSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the fte budgeting control.
        /// </summary>
        /// <value>
        /// The fte budgeting control.
        /// </value>
        public string FteBudgetingControl { get; set; }

        /// <summary>
        /// Gets or sets the fte spending control.
        /// </summary>
        /// <value>
        /// The fte spending control.
        /// </value>
        public string FteSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the transaction type control.
        /// </summary>
        /// <value>
        /// The transaction type control.
        /// </value>
        public string TransactionTypeControl { get; set; }

        /// <summary>
        /// Gets or sets the authority distribution control.
        /// </summary>
        /// <value>
        /// The authority distribution control.
        /// </value>
        public string AuthorityDistributionControl { get; set; }
        
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
        /// Initializes a new instance of the <see cref="BudgetControlValue"/> class.
        /// </summary>
        public BudgetControlValue( )
        {
            Source = Source.BudgetControls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetControlValue"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetControlValue( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "BudgetControlValuesId" ].ToString(  ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            SecurityOrg = Record[ "" ].ToString(  ); 
            BudgetingTransType = Record[ "" ].ToString(  );
            PostedTransType = Record[ "" ].ToString(  );
            EstimatedReimbursableTransType = Record[ "" ].ToString(  );
            SpendingAdjustmentTransType = Record[ "" ].ToString(  );
            EstimatedRecoveriesTransType = Record[ "" ].ToString(  );
            ActualRecoveriesTransType = Record[ "" ].ToString(  );
            StrategicReserveTransType = Record[ "" ].ToString(  );
            SpendingAdjustmentTransType = Record[ "" ].ToString(  );
            ProfitLossTransType = Record[ "" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetControlValue"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public BudgetControlValue( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "BudgetControlValuesId" ].ToString(  ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetControlValue"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetControlValue( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}

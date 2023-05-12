// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IBudgetControl : IDataUnit
    {
        /// <summary>
        /// Gets or sets the security org.
        /// </summary>
        /// <value>
        /// The security org.
        /// </value>
        string SecurityOrg { get; set; }

        /// <summary>
        /// Gets or sets the type of the budgeting trans.
        /// </summary>
        /// <value>
        /// The type of the budgeting trans.
        /// </value>
        string BudgetingTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the posted trans.
        /// </summary>
        /// <value>
        /// The type of the posted trans.
        /// </value>
        string PostedTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the estimated reimbursable trans.
        /// </summary>
        /// <value>
        /// The type of the estimated reimbursable trans.
        /// </value>
        string EstimatedReimbursableTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the spending adjustment trans.
        /// </summary>
        /// <value>
        /// The type of the spending adjustment trans.
        /// </value>
        string SpendingAdjustmentTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the estimated recoveries trans.
        /// </summary>
        /// <value>
        /// The type of the estimated recoveries trans.
        /// </value>
        string EstimatedRecoveriesTransType { get; set; }

        /// <summary>
        /// Gets or sets the actual type of the recoveries trans.
        /// </summary>
        /// <value>
        /// The actual type of the recoveries trans.
        /// </value>
        string ActualRecoveriesTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the stategic reserve trans.
        /// </summary>
        /// <value>
        /// The type of the stategic reserve trans.
        /// </value>
        string StrategicReserveTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the prof loss trans.
        /// </summary>
        /// <value>
        /// The type of the prof loss trans.
        /// </value>
        string ProfitLossTransType { get; set; }

        /// <summary>
        /// Gets or sets the estimated reimbursable spending option.
        /// </summary>
        /// <value>
        /// The estimated reimbursable spending option.
        /// </value>
        string EstimatedReimbursableSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the estimated reimbursable budgeting option.
        /// </summary>
        /// <value>
        /// The estimated reimbursable budgeting option.
        /// </value>
        string EstimatedReimbursableBudgetingOption { get; set; }

        /// <summary>
        /// Gets or sets the track agreement lower level.
        /// </summary>
        /// <value>
        /// The track agreement lower level.
        /// </value>
        string TrackAgreementLowerLevel { get; set; }

        /// <summary>
        /// Gets or sets the budget estimate lower level.
        /// </summary>
        /// <value>
        /// The budget estimate lower level.
        /// </value>
        string BudgetEstimateLowerLevel { get; set; }

        /// <summary>
        /// Gets or sets the estimated recoveries spending option.
        /// </summary>
        /// <value>
        /// The estimated recoveries spending option.
        /// </value>
        string EstimatedRecoveriesSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the estimated recoveries budgeting option.
        /// </summary>
        /// <value>
        /// The estimated recoveries budgeting option.
        /// </value>
        string EstimatedRecoveriesBudgetingOption { get; set; }

        /// <summary>
        /// Gets or sets the record next level.
        /// </summary>
        /// <value>
        /// The record next level.
        /// </value>
        string RecordNextLevel { get; set; }

        /// <summary>
        /// Gets or sets the record budgeting mismatch.
        /// </summary>
        /// <value>
        /// The record budgeting mismatch.
        /// </value>
        string RecordBudgetingMismatch { get; set; }

        /// <summary>
        /// Gets or sets the profit loss spending option.
        /// </summary>
        /// <value>
        /// The profit loss spending option.
        /// </value>
        string ProfitLossSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the profit loss budgeting option.
        /// </summary>
        /// <value>
        /// The profit loss budgeting option.
        /// </value>
        string ProfitLossBudgetingOption { get; set; }

        /// <summary>
        /// Gets or sets the record carry in lower level.
        /// </summary>
        /// <value>
        /// The record carry in lower level.
        /// </value>
        string RecordCarryInLowerLevel { get; set; }

        /// <summary>
        /// Gets or sets the record carry in lower level control.
        /// </summary>
        /// <value>
        /// The record carry in lower level control.
        /// </value>
        string RecordCarryInLowerLevelControl { get; set; }

        /// <summary>
        /// Gets or sets the record carry in amount control.
        /// </summary>
        /// <value>
        /// The record carry in amount control.
        /// </value>
        string RecordCarryInAmountControl { get; set; }

        /// <summary>
        /// Gets or sets the budgeting control.
        /// </summary>
        /// <value>
        /// The budgeting control.
        /// </value>
        string BudgetingControl { get; set; }

        /// <summary>
        /// Gets or sets the posting control.
        /// </summary>
        /// <value>
        /// The posting control.
        /// </value>
        string PostingControl { get; set; }

        /// <summary>
        /// Gets or sets the pre commitment spending control.
        /// </summary>
        /// <value>
        /// The pre commitment spending control.
        /// </value>
        string PreCommitmentSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the commitment spending control.
        /// </summary>
        /// <value>
        /// The commitment spending control.
        /// </value>
        string CommitmentSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the obligation spending control.
        /// </summary>
        /// <value>
        /// The obligation spending control.
        /// </value>
        string ObligationSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the accrual spending control.
        /// </summary>
        /// <value>
        /// The accrual spending control.
        /// </value>
        string AccrualSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the expenditure spending control.
        /// </summary>
        /// <value>
        /// The expenditure spending control.
        /// </value>
        string ExpenditureSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the expense spending control.
        /// </summary>
        /// <value>
        /// The expense spending control.
        /// </value>
        string ExpenseSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the reimbursable spending control.
        /// </summary>
        /// <value>
        /// The reimbursable spending control.
        /// </value>
        string ReimbursableSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the reimbursable agreement spending control.
        /// </summary>
        /// <value>
        /// The reimbursable agreement spending control.
        /// </value>
        string ReimbursableAgreementSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the fte budgeting control.
        /// </summary>
        /// <value>
        /// The fte budgeting control.
        /// </value>
        string FteBudgetingControl { get; set; }

        /// <summary>
        /// Gets or sets the fte spending control.
        /// </summary>
        /// <value>
        /// The fte spending control.
        /// </value>
        string FteSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the transaction type control.
        /// </summary>
        /// <value>
        /// The transaction type control.
        /// </value>
        string TransactionTypeControl { get; set; }

        /// <summary>
        /// Gets or sets the authority distribution control.
        /// </summary>
        /// <value>
        /// The authority distribution control.
        /// </value>
        string AuthorityDistributionControl { get; set; }
    }
}

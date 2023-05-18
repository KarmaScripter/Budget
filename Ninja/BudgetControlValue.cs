// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class BudgetControlValue : BudgetControl, IBudgetControl
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetControlValue"/>
        /// class.
        /// </summary>
        public BudgetControlValue( )
        {
            Source = Source.BudgetControls;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetControlValue"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public BudgetControlValue( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "BudgetControlValuesId" ].ToString( ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            SecurityOrg = Record[ "" ].ToString( );
            BudgetingTransType = Record[ "SecurityOrg" ].ToString( );
            PostedTransType = Record[ "PostedTransType" ].ToString( );
            EstimatedReimbursableTransType = Record[ "EstimatedReimbursableTransType" ].ToString( );
            SpendingAdjustmentTransType = Record[ "SpendingAdjustmentTransType" ].ToString( );
            EstimatedRecoveriesTransType = Record[ "EstimatedRecoveriesTransType" ].ToString( );
            ActualRecoveriesTransType = Record[ "ActualRecoveriesTransType" ].ToString( );
            StrategicReserveTransType = Record[ "StrategicReserveTransType" ].ToString( );
            SpendingAdjustmentTransType = Record[ "SpendingAdjustmentTransType" ].ToString( );
            ProfitLossTransType = Record[ "ProfitLossTransType" ].ToString( );
            EstimatedReimbursableBudgetingOption =
                Record[ "EstimatedReimbursableBudgetingOption" ].ToString( );

            EstimatedRecoveriesSpendingOption =
                Record[ "EstimatedRecoveriesSpendingOption" ].ToString( );

            EstimatedRecoveriesBudgetingOption =
                Record[ "EstimatedRecoveriesBudgetingOption" ].ToString( );

            EstimatedRecoveriesSpendingOption =
                Record[ "EstimatedRecoveriesSpendingOption" ].ToString( );

            RecordNextLevel = Record[ "RecordNextLevel" ].ToString( );
            RecordBudgetingMismatch = Record[ "RecordBudgetingMismatch" ].ToString( );
            ProfitLossBudgetingOption = Record[ "ProfitLossBudgetingOption" ].ToString( );
            ProfitLossSpendingOption = Record[ "ProfitLossSpendingOption" ].ToString( );
            RecordCarryInLowerLevel = Record[ "RecordCarryInLowerLevel" ].ToString( );
            RecordCarryInLowerLevelControl = Record[ "RecordCarryInLowerLevelControl" ].ToString( );
            RecordCarryInAmountControl = Record[ "RecordCarryInAmountControl" ].ToString( );
            BudgetingControl = Record[ "BudgetingControl" ].ToString( );
            PostingControl = Record[ "PostingControl" ].ToString( );
            PreCommitmentSpendingControl = Record[ "PreCommitmentSpendingControl" ].ToString( );
            CommitmentSpendingControl = Record[ "CommitmentSpendingControl" ].ToString( );
            ObligationSpendingControl = Record[ "ObligationSpendingControl" ].ToString( );
            AccrualSpendingControl = Record[ "" ].ToString( );
            ExpenditureSpendingControl = Record[ "ExpenditureSpendingControl" ].ToString( );
            ExpenseSpendingControl = Record[ "ExpenseSpendingControl" ].ToString( );
            ReimbursableSpendingControl = Record[ "ReimbursableSpendingControl" ].ToString( );
            ReimbursableAgreementSpendingControl =
                Record[ "ReimbursableAgreementSpendingControl" ].ToString( );

            FteBudgetingControl = Record[ "FteBudgetingControl" ].ToString( );
            FteSpendingControl = Record[ "FteSpendingControl" ].ToString( );
            TransactionTypeControl = Record[ "TransactionTypeControl" ].ToString( );
            AuthorityDistributionControl = Record[ "AuthorityDistributionControl" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetControlValue"/>
        /// class.
        /// </summary>
        /// <param name = "builder" > The builder. </param>
        public BudgetControlValue( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "BudgetControlValuesId" ].ToString( ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            SecurityOrg = Record[ "" ].ToString( );
            BudgetingTransType = Record[ "SecurityOrg" ].ToString( );
            PostedTransType = Record[ "PostedTransType" ].ToString( );
            EstimatedReimbursableTransType = Record[ "EstimatedReimbursableTransType" ].ToString( );
            SpendingAdjustmentTransType = Record[ "SpendingAdjustmentTransType" ].ToString( );
            EstimatedRecoveriesTransType = Record[ "EstimatedRecoveriesTransType" ].ToString( );
            ActualRecoveriesTransType = Record[ "ActualRecoveriesTransType" ].ToString( );
            StrategicReserveTransType = Record[ "StrategicReserveTransType" ].ToString( );
            SpendingAdjustmentTransType = Record[ "SpendingAdjustmentTransType" ].ToString( );
            ProfitLossTransType = Record[ "ProfitLossTransType" ].ToString( );
            EstimatedReimbursableBudgetingOption =
                Record[ "EstimatedReimbursableBudgetingOption" ].ToString( );

            EstimatedRecoveriesSpendingOption =
                Record[ "EstimatedRecoveriesSpendingOption" ].ToString( );

            EstimatedRecoveriesBudgetingOption =
                Record[ "EstimatedRecoveriesBudgetingOption" ].ToString( );

            EstimatedRecoveriesSpendingOption =
                Record[ "EstimatedRecoveriesSpendingOption" ].ToString( );

            RecordNextLevel = Record[ "RecordNextLevel" ].ToString( );
            RecordBudgetingMismatch = Record[ "RecordBudgetingMismatch" ].ToString( );
            ProfitLossBudgetingOption = Record[ "ProfitLossBudgetingOption" ].ToString( );
            ProfitLossSpendingOption = Record[ "ProfitLossSpendingOption" ].ToString( );
            RecordCarryInLowerLevel = Record[ "RecordCarryInLowerLevel" ].ToString( );
            RecordCarryInLowerLevelControl = Record[ "RecordCarryInLowerLevelControl" ].ToString( );
            RecordCarryInAmountControl = Record[ "RecordCarryInAmountControl" ].ToString( );
            BudgetingControl = Record[ "BudgetingControl" ].ToString( );
            PostingControl = Record[ "PostingControl" ].ToString( );
            PreCommitmentSpendingControl = Record[ "PreCommitmentSpendingControl" ].ToString( );
            CommitmentSpendingControl = Record[ "CommitmentSpendingControl" ].ToString( );
            ObligationSpendingControl = Record[ "ObligationSpendingControl" ].ToString( );
            AccrualSpendingControl = Record[ "" ].ToString( );
            ExpenditureSpendingControl = Record[ "ExpenditureSpendingControl" ].ToString( );
            ExpenseSpendingControl = Record[ "ExpenseSpendingControl" ].ToString( );
            ReimbursableSpendingControl = Record[ "ReimbursableSpendingControl" ].ToString( );
            ReimbursableAgreementSpendingControl =
                Record[ "ReimbursableAgreementSpendingControl" ].ToString( );

            FteBudgetingControl = Record[ "FteBudgetingControl" ].ToString( );
            FteSpendingControl = Record[ "FteSpendingControl" ].ToString( );
            TransactionTypeControl = Record[ "TransactionTypeControl" ].ToString( );
            AuthorityDistributionControl = Record[ "AuthorityDistributionControl" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetControlValue"/>
        /// class.
        /// </summary>
        /// <param name = "row" > The data row. </param>
        public BudgetControlValue( DataRow row )
            : this( )
        {
            Record = row;
            Data = row.ToDictionary( );
            ID = int.Parse( row[ "BudgetControlValuesId" ].ToString( ) ?? "0" );
            Name = row?[ "Name" ].ToString( );
            Code = row?[ "Code" ].ToString( );
            SecurityOrg = row[ "" ].ToString( );
            BudgetingTransType = row[ "SecurityOrg" ].ToString( );
            PostedTransType = row[ "PostedTransType" ].ToString( );
            EstimatedReimbursableTransType = row[ "EstimatedReimbursableTransType" ].ToString( );
            SpendingAdjustmentTransType = row[ "SpendingAdjustmentTransType" ].ToString( );
            EstimatedRecoveriesTransType = row[ "EstimatedRecoveriesTransType" ].ToString( );
            ActualRecoveriesTransType = row[ "ActualRecoveriesTransType" ].ToString( );
            StrategicReserveTransType = row[ "StrategicReserveTransType" ].ToString( );
            SpendingAdjustmentTransType = row[ "SpendingAdjustmentTransType" ].ToString( );
            ProfitLossTransType = row[ "ProfitLossTransType" ].ToString( );
            EstimatedReimbursableBudgetingOption =
                row[ "EstimatedReimbursableBudgetingOption" ].ToString( );

            EstimatedRecoveriesSpendingOption = row[ "EstimatedRecoveriesSpendingOption" ].ToString( );
            EstimatedRecoveriesBudgetingOption =
                row[ "EstimatedRecoveriesBudgetingOption" ].ToString( );

            EstimatedRecoveriesSpendingOption = row[ "EstimatedRecoveriesSpendingOption" ].ToString( );
            RecordNextLevel = row[ "NextLevel" ].ToString( );
            RecordBudgetingMismatch = row[ "BudgetingMismatch" ].ToString( );
            ProfitLossBudgetingOption = row[ "ProfitLossBudgetingOption" ].ToString( );
            ProfitLossSpendingOption = row[ "ProfitLossSpendingOption" ].ToString( );
            RecordCarryInLowerLevel = row[ "CarryInLowerLevel" ].ToString( );
            RecordCarryInLowerLevelControl = row[ "CarryInLowerLevelControl" ].ToString( );
            RecordCarryInAmountControl = row[ "CarryInAmountControl" ].ToString( );
            BudgetingControl = row[ "BudgetingControl" ].ToString( );
            PostingControl = row[ "PostingControl" ].ToString( );
            PreCommitmentSpendingControl = row[ "PreCommitmentSpendingControl" ].ToString( );
            CommitmentSpendingControl = row[ "CommitmentSpendingControl" ].ToString( );
            ObligationSpendingControl = row[ "ObligationSpendingControl" ].ToString( );
            AccrualSpendingControl = row[ "" ].ToString( );
            ExpenditureSpendingControl = row[ "ExpenditureSpendingControl" ].ToString( );
            ExpenseSpendingControl = row[ "ExpenseSpendingControl" ].ToString( );
            ReimbursableSpendingControl = row[ "ReimbursableSpendingControl" ].ToString( );
            ReimbursableAgreementSpendingControl =
                row[ "ReimbursableAgreementSpendingControl" ].ToString( );

            FteBudgetingControl = row[ "FteBudgetingControl" ].ToString( );
            FteSpendingControl = row[ "FteSpendingControl" ].ToString( );
            TransactionTypeControl = row[ "TransactionTypeControl" ].ToString( );
            AuthorityDistributionControl = row[ "AuthorityDistributionControl" ].ToString( );
        }
    }
}
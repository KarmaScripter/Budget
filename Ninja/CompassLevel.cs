// <copyright file = "CompassLevel.cs" company = "Terry D. Eppler">
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
    public class CompassLevel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the budget level.
        /// </summary>
        /// <value>
        /// The budget level.
        /// </value>
        public string BudgetLevel { get; set; }

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
        /// Gets or sets the appropriation code.
        /// </summary>
        /// <value>
        /// The appropriation code.
        /// </value>
        public string AppropriationCode { get; set; }

        /// <summary>
        /// Gets or sets the sub appropriation code.
        /// </summary>
        /// <value>
        /// The sub appropriation code.
        /// </value>
        public string SubAppropriationCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the appropriation.
        /// </summary>
        /// <value>
        /// The name of the appropriation.
        /// </value>
        public string AppropriationName { get; set; }

        /// <summary>
        /// Gets or sets the treasury symbol.
        /// </summary>
        /// <value>
        /// The treasury symbol.
        /// </value>
        public string TreasurySymbol { get; set; }

        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or sets the name of the lower.
        /// </summary>
        /// <value>
        /// The name of the lower.
        /// </value>
        public string LowerName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the posted control flag.
        /// </summary>
        /// <value>
        /// The posted control flag.
        /// </value>
        public string PostedControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the actual type of the recovery trans.
        /// </summary>
        /// <value>
        /// The actual type of the recovery trans.
        /// </value>
        public string ActualRecoveryTransType { get; set; }

        /// <summary>
        /// Gets or sets the commitment spending control flag.
        /// </summary>
        /// <value>
        /// The commitment spending control flag.
        /// </value>
        public string CommitmentSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the budget default.
        /// </summary>
        /// <value>
        /// The budget default.
        /// </value>
        public string BudgetDefault { get; set; }

        /// <summary>
        /// Gets or sets the lower child expenditure spending control flag.
        /// </summary>
        /// <value>
        /// The lower child expenditure spending control flag.
        /// </value>
        public string LowerChildExpenditureSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the lower child expense spending control flag.
        /// </summary>
        /// <value>
        /// The lower child expense spending control flag.
        /// </value>
        public string LowerChildExpenseSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the fte control flag.
        /// </summary>
        /// <value>
        /// The fte control flag.
        /// </value>
        public string FteControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the accrual spending control flag.
        /// </summary>
        /// <value>
        /// The accrual spending control flag.
        /// </value>
        public string AccrualSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the obligation spending control flag.
        /// </summary>
        /// <value>
        /// The obligation spending control flag.
        /// </value>
        public string ObligationSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the pre commitment spending control flag.
        /// </summary>
        /// <value>
        /// The pre commitment spending control flag.
        /// </value>
        public string PreCommitmentSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the lower commitment spending control flag.
        /// </summary>
        /// <value>
        /// The lower commitment spending control flag.
        /// </value>
        public string LowerCommitmentSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the lower obligation spending control flag.
        /// </summary>
        /// <value>
        /// The lower obligation spending control flag.
        /// </value>
        public string LowerObligationSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the lower expenditure spending control flag.
        /// </summary>
        /// <value>
        /// The lower expenditure spending control flag.
        /// </value>
        public string LowerExpenditureSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the lower expense spending control flag.
        /// </summary>
        /// <value>
        /// The lower expense spending control flag.
        /// </value>
        public string LowerExpenseSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the lower posted control flag.
        /// </summary>
        /// <value>
        /// The lower posted control flag.
        /// </value>
        public string LowerPostedControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the type of the lower posted trans.
        /// </summary>
        /// <value>
        /// The type of the lower posted trans.
        /// </value>
        public string LowerPostedTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the lower trans.
        /// </summary>
        /// <value>
        /// The type of the lower trans.
        /// </value>
        public string LowerTransType { get; set; }

        /// <summary>
        /// Gets or sets the lower posted flag.
        /// </summary>
        /// <value>
        /// The lower posted flag.
        /// </value>
        public string LowerPostedFlag { get; set; }

        /// <summary>
        /// Gets or sets the lower pre commitment spending control flag.
        /// </summary>
        /// <value>
        /// The lower pre commitment spending control flag.
        /// </value>
        public string LowerPreCommitmentSpendingControlFlag { get; set; }

        /// <summary>
        /// Gets or sets the lower recoveries spending option.
        /// </summary>
        /// <value>
        /// The lower recoveries spending option.
        /// </value>
        public string LowerRecoveriesSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the lower recoveries option.
        /// </summary>
        /// <value>
        /// The lower recoveries option.
        /// </value>
        public string LowerRecoveriesOption { get; set; }

        /// <summary>
        /// Gets or sets the lower reimbursable spending option.
        /// </summary>
        /// <value>
        /// The lower reimbursable spending option.
        /// </value>
        public string LowerReimbursableSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Gets or sets the total authority.
        /// </summary>
        /// <value>
        /// The total authority.
        /// </value>
        public double TotalAuthority { get; set; }

        /// <summary>
        /// Gets or sets the original amount.
        /// </summary>
        /// <value>
        /// The original amount.
        /// </value>
        public double OriginalAmount { get; set; }

        /// <summary>
        /// Gets or sets the carryover availability percentage.
        /// </summary>
        /// <value>
        /// The carryover availability percentage.
        /// </value>
        public double CarryoverAvailabilityPercentage { get; set; }

        /// <summary>
        /// Gets or sets the carry in.
        /// </summary>
        /// <value>
        /// The carry in.
        /// </value>
        public double CarryIn { get; set; }

        /// <summary>
        /// Gets or sets the carry out.
        /// </summary>
        /// <value>
        /// The carry out.
        /// </value>
        public double CarryOut { get; set; }

        /// <summary>
        /// Gets or sets the funds in.
        /// </summary>
        /// <value>
        /// The funds in.
        /// </value>
        public double FundsIn { get; set; }

        /// <summary>
        /// Gets or sets the fund out.
        /// </summary>
        /// <value>
        /// The fund out.
        /// </value>
        public double FundOut { get; set; }

        /// <summary>
        /// Gets or sets the recoveries withdrawn.
        /// </summary>
        /// <value>
        /// The recoveries withdrawn.
        /// </value>
        public double RecoveriesWithdrawn { get; set; }

        /// <summary>
        /// Gets or sets the actual recoveries.
        /// </summary>
        /// <value>
        /// The actual recoveries.
        /// </value>
        public double ActualRecoveries { get; set; }

        /// <summary>
        /// Gets or sets the actual reimbursements.
        /// </summary>
        /// <value>
        /// The actual reimbursements.
        /// </value>
        public double ActualReimbursements { get; set; }

        /// <summary>
        /// Gets or sets the agreement reimbursables.
        /// </summary>
        /// <value>
        /// The agreement reimbursables.
        /// </value>
        public double AgreementReimbursables { get; set; }

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
        /// Initializes a new instance of the <see cref="CompassLevel"/> class.
        /// </summary>
        public CompassLevel( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassLevel"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CompassLevel( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassLevel"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CompassLevel( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassLevel"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CompassLevel( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
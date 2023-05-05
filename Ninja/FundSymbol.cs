// <copyright file = "FundSymbol.cs" company = "Terry D. Eppler">
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
    public class FundSymbol : Fund
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundSymbol"/> class.
        /// </summary>
        public FundSymbol( )
        {
            Source = Source.FundSymbols;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundSymbol"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public FundSymbol( IQuery query ) 
            : base( query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundSymbolsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) ?? string.Empty );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) ?? string.Empty );
            SubLevelPrefix = Record[ "SubLevelPrefix" ].ToString( );
            AllocationTransferAgency = Record[ "AllocationTransferAgency" ].ToString( );
            AgencyIdentifier = Record[ "AgencyIdentifier" ].ToString( );
            BeginningPeriodOfAvailability = Record[ "BeginningPeriodOfAvailability" ].ToString( );
            EndingPeriodOfAvailability = Record[ "EndingPeriodOfAvailability" ].ToString( );
            MultiYearIndicator = Record[ "MultiYearIndicator" ].ToString( );
            MainAccount = Record[ "MainAccount" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            FundCategory = Record[ "FundCategory" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            FundGroup = Record[ "FundGroup" ].ToString( );
            NoYear = Record[ "NoYear" ].ToString( );
            Carryover = Record[ "Carryover" ].ToString( );
            CancelledYearSpendingAccount = Record[ "CancelledYearSpendingAccount" ].ToString( );
            ApplyAtAllLevels = Record[ "ApplyAtAllLevels" ].ToString( );
            BatsFund = Record[ "BatsFund" ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) ?? string.Empty );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundSymbol"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public FundSymbol( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundSymbolsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) ?? string.Empty );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) ?? string.Empty );
            SubLevelPrefix = Record[ "SubLevelPrefix" ].ToString( );
            AllocationTransferAgency = Record[ "AllocationTransferAgency" ].ToString( );
            AgencyIdentifier = Record[ "AgencyIdentifier" ].ToString( );
            BeginningPeriodOfAvailability = Record[ "BeginningPeriodOfAvailability" ].ToString( );
            EndingPeriodOfAvailability = Record[ "EndingPeriodOfAvailability" ].ToString( );
            MultiYearIndicator = Record[ "MultiYearIndicator" ].ToString( );
            MainAccount = Record[ "MainAccount" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            FundCategory = Record[ "FundCategory" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            FundGroup = Record[ "FundGroup" ].ToString( );
            NoYear = Record[ "NoYear" ].ToString( );
            Carryover = Record[ "Carryover" ].ToString( );
            CancelledYearSpendingAccount = Record[ "CancelledYearSpendingAccount" ].ToString( );
            ApplyAtAllLevels = Record[ "ApplyAtAllLevels" ].ToString( );
            BatsFund = Record[ "BatsFund" ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) ?? string.Empty );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundSymbol" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public FundSymbol( DataRow dataRow )
        {
            Record = dataRow;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundSymbolsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) ?? string.Empty );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) ?? string.Empty );
            SubLevelPrefix = Record[ "SubLevelPrefix" ].ToString( );
            AllocationTransferAgency = Record[ "AllocationTransferAgency" ].ToString( );
            AgencyIdentifier = Record[ "AgencyIdentifier" ].ToString( );
            BeginningPeriodOfAvailability = Record[ "BeginningPeriodOfAvailability" ].ToString( );
            EndingPeriodOfAvailability = Record[ "EndingPeriodOfAvailability" ].ToString( );
            MultiYearIndicator = Record[ "MultiYearIndicator" ].ToString( );
            MainAccount = Record[ "MainAccount" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            FundCategory = Record[ "FundCategory" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            FundGroup = Record[ "FundGroup" ].ToString( );
            NoYear = Record[ "NoYear" ].ToString( );
            Carryover = Record[ "Carryover" ].ToString( );
            CancelledYearSpendingAccount = Record[ "CancelledYearSpendingAccount" ].ToString( );
            ApplyAtAllLevels = Record[ "ApplyAtAllLevels" ].ToString( );
            BatsFund = Record[ "BatsFund" ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) ?? string.Empty );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        public FundSymbol( IFund fund )
        {
            ID = fund.ID;
            BFY = fund.BFY;
            EFY = fund.EFY;
            Code = fund.Code;
            Name = fund.Name;
            ShortName = fund.ShortName;
            Status = fund.Status;
            StartDate = fund.StartDate;
            EndDate = fund.EndDate;
            SubLevelPrefix = fund.SubLevelPrefix;
            AllocationTransferAgency = fund.AllocationTransferAgency;
            AgencyIdentifier = fund.AgencyIdentifier;
            BeginningPeriodOfAvailability = fund.BeginningPeriodOfAvailability;
            EndingPeriodOfAvailability = fund.EndingPeriodOfAvailability;
            MultiYearIndicator = fund.MultiYearIndicator;
            MainAccount = fund.MainAccount;
            SubAccount = fund.SubAccount;
            FundCategory = fund.FundCategory;
            AppropriationCode = fund.AppropriationCode;
            SubAppropriationCode = fund.SubAppropriationCode;
            FundGroup = fund.FundCategory;
            NoYear = fund.NoYear;
            Carryover = fund.Carryover;
            CancelledYearSpendingAccount = fund.CancelledYearSpendingAccount;
            ApplyAtAllLevels = fund.ApplyAtAllLevels;
            BatsFund = fund.BatsFund;
            BatsEndDate = fund.BatsEndDate;
            BatsOptionId = fund.BatsOptionId;
            SecurityOrg = fund.SecurityOrg;
            TreasuryAccountCode = fund.TreasuryAccountCode;
            TreasuryAccountName = fund.TreasuryAccountName;
            BudgetAccountCode = fund.BudgetAccountCode;
            BudgetAccountName = fund.BudgetAccountName;
            ApportionmentAccountCode = fund.ApportionmentAccountCode;
        }
    }
}

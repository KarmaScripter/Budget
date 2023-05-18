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
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class Fund : FundSymbol, IFund
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Fund"/>
        /// class.
        /// </summary>
        public Fund( )
        {
            Source = Source.Funds;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Fund"/>
        /// class.
        /// </summary>
        /// <param name = "fundCode" > The fundCode. </param>
        public Fund( FundCode fundCode )
            : this( )
        {
            Record = new DataBuilder( Source, GetArgs( fundCode ) )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
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
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Fund"/>
        /// class.
        /// </summary>
        /// <param name = "code" > The code. </param>
        public Fund( string code )
            : this( )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
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
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Fund"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public Fund( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
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
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Fund"/>
        /// class.
        /// </summary>
        /// <param name = "builder" > The builder. </param>
        public Fund( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
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
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Fund"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The Data. </param>
        public Fund( DataRow dataRow )
            : this( )
        {
            Source = Source.Funds;
            Record = dataRow;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
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
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        public Fund( IFund fund )
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
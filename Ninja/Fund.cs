// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class Fund : BudgetUnit, IFund
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public override string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public override string EFY { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>
        /// The short name.
        /// </value>
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateOnly StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateOnly EndDate { get; set; }

        /// <summary>
        /// Gets or sets the sub level prefix.
        /// </summary>
        /// <value>
        /// The sub level prefix.
        /// </value>
        public string SubLevelPrefix { get; set; }

        /// <summary>
        /// Gets or sets the ata.
        /// </summary>
        /// <value>
        /// The ata.
        /// </value>
        public string AllocationTransferAgency { get; set; }

        /// <summary>
        /// Gets or sets the aid.
        /// </summary>
        /// <value>
        /// The aid.
        /// </value>
        public string AgencyIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the beginning period of availability.
        /// </summary>
        /// <value>
        /// The beginning period of availability.
        /// </value>
        public string BeginningPeriodOfAvailability { get; set; }

        /// <summary>
        /// Gets or sets the ending period of availability.
        /// </summary>
        /// <value>
        /// The ending period of availability.
        /// </value>
        public string EndingPeriodOfAvailability { get; set; }

        /// <summary>
        /// Gets or sets a.
        /// </summary>
        /// <value>
        /// a.
        /// </value>
        public string MultiYearIndicator { get; set; }

        /// <summary>
        /// Gets or sets the main.
        /// </summary>
        /// <value>
        /// The main.
        /// </value>
        public string MainAccount { get; set; }

        /// <summary>
        /// Gets or sets the sub.
        /// </summary>
        /// <value>
        /// The sub.
        /// </value>
        public string SubAccount { get; set; }

        /// <summary>
        /// Gets or sets the fund category.
        /// </summary>
        /// <value>
        /// The fund category.
        /// </value>
        public string FundCategory { get; set; }

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
        /// Gets or sets the fund group.
        /// </summary>
        /// <value>
        /// The fund group.
        /// </value>
        public string FundGroup { get; set; }

        /// <summary>
        /// Gets or sets the no year.
        /// </summary>
        /// <value>
        /// The no year.
        /// </value>
        public string NoYear { get; set; }

        /// <summary>
        /// Gets or sets the carryover.
        /// </summary>
        /// <value>
        /// The carryover.
        /// </value>
        public string Carryover { get; set; }

        /// <summary>
        /// Gets or sets the canceled year spending account.
        /// </summary>
        /// <value>
        /// The canceled year spending account.
        /// </value>
        public string CancelledYearSpendingAccount { get; set; }

        /// <summary>
        /// Gets or sets the apply at all levels.
        /// </summary>
        /// <value>
        /// The apply at all levels.
        /// </value>
        public string ApplyAtAllLevels { get; set; }

        /// <summary>
        /// Gets or sets the bats fund.
        /// </summary>
        /// <value>
        /// The bats fund.
        /// </value>
        public string BatsFund { get; set; }

        /// <summary>
        /// Gets or sets the bats end date.
        /// </summary>
        /// <value>
        /// The bats end date.
        /// </value>
        public DateOnly BatsEndDate { get; set; }

        /// <summary>
        /// Gets or sets the bats option identifier.
        /// </summary>
        /// <value>
        /// The bats option identifier.
        /// </value>
        public string BatsOptionId { get; set; }

        /// <summary>
        /// Gets or sets the security org.
        /// </summary>
        /// <value>
        /// The security org.
        /// </value>
        public string SecurityOrg { get; set; }

        /// <summary>
        /// Gets or sets the budget account code.
        /// </summary>
        /// <value>
        /// The budget account code.
        /// </value>
        public override string BudgetAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget account.
        /// </summary>
        /// <value>
        /// The name of the budget account.
        /// </value>
        public override string BudgetAccountName { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public override string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the treasury account.
        /// </summary>
        /// <value>
        /// The name of the treasury account.
        /// </value>
        public override string TreasuryAccountName { get; set; }

        /// <summary>
        /// Gets or sets the apportionment account code.
        /// </summary>
        /// <value>
        /// The apportionment account code.
        /// </value>
        public virtual string ApportionmentAccountCode { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public override Source Source { get; set; }

        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        public Fund( )
        {
            Source = Source.Funds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "fundCode" >
        /// The fundCode.
        /// </param>
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
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
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
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
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
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
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
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The Data.
        /// </param>
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

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Data?.Any( ) == true
                    ? Data
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "fundCode" >
        /// The fundCode.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> GetArgs( string fundCode )
        {
            if( !string.IsNullOrEmpty( fundCode )
               && fundCode.Length < 5 )
            {
                try
                {
                    return new Dictionary<string, object> { [ Field.Code.ToString( ) ] = fundCode };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return new Dictionary<string, object> { [ Field.Name.ToString( ) ] = fundCode };
                }
            }

            if( !string.IsNullOrEmpty( fundCode )
               && fundCode.Length > 5 )
            {
                try
                {
                    return new Dictionary<string, object> { [ Field.Name.ToString( ) ] = fundCode };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "fundCode" >
        /// The fundCode.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> GetArgs( FundCode fundCode )
        {
            try
            {
                return Enum.IsDefined( typeof( FundCode ), fundCode )
                    ? new Dictionary<string, object> { [ "FundCode" ] = fundCode.ToString( ) }
                    : default;
            }
            catch( SystemException ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the fund.
        /// </summary>
        /// <returns>
        /// </returns>
        public IFund GetFund( )
        {
            try
            {
                return MemberwiseClone( ) as Fund;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        public override int GetId( DataRow dataRow )
        {
            try
            {
                return dataRow != null
                    ? int.Parse( dataRow[ 0 ].ToString( ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public override int GetId( DataRow dataRow, PrimaryKey primaryKey )
        {
            try
            {
                return Enum.IsDefined( typeof( PrimaryKey ), primaryKey ) && dataRow != null
                    ? int.Parse( dataRow[ $"{primaryKey}" ].ToString( ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}
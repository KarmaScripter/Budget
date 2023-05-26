// <copyright file = "FundSymbol.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.BudgetUnit" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class FundSymbol : BudgetUnit
    {
        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>
        /// The short name.
        /// </value>
        public virtual string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public virtual string Status { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public virtual DateOnly StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public virtual DateOnly EndDate { get; set; }

        /// <summary>
        /// Gets or sets the sub level prefix.
        /// </summary>
        /// <value>
        /// The sub level prefix.
        /// </value>
        public virtual string SubLevelPrefix { get; set; }

        /// <summary>
        /// Gets or sets the allocation transfer agency.
        /// </summary>
        /// <value>
        /// The allocation transfer agency.
        /// </value>
        public virtual string AllocationTransferAgency { get; set; }

        /// <summary>
        /// Gets or sets the agency identifier.
        /// </summary>
        /// <value>
        /// The agency identifier.
        /// </value>
        public virtual string AgencyIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the beginning period of availability.
        /// </summary>
        /// <value>
        /// The beginning period of availability.
        /// </value>
        public virtual string BeginningPeriodOfAvailability { get; set; }

        /// <summary>
        /// Gets or sets the ending period of availability.
        /// </summary>
        /// <value>
        /// The ending period of availability.
        /// </value>
        public virtual string EndingPeriodOfAvailability { get; set; }

        /// <summary>
        /// Gets or sets the multi year indicator.
        /// </summary>
        /// <value>
        /// The multi year indicator.
        /// </value>
        public virtual string MultiYearIndicator { get; set; }

        /// <summary>
        /// Gets or sets the main account.
        /// </summary>
        /// <value>
        /// The main account.
        /// </value>
        public virtual string MainAccount { get; set; }

        /// <summary>
        /// Gets or sets the sub account.
        /// </summary>
        /// <value>
        /// The sub account.
        /// </value>
        public virtual string SubAccount { get; set; }

        /// <summary>
        /// Gets or sets the fund category.
        /// </summary>
        /// <value>
        /// The fund category.
        /// </value>
        public virtual string FundCategory { get; set; }

        /// <summary>
        /// Gets or sets the appropriation code.
        /// </summary>
        /// <value>
        /// The appropriation code.
        /// </value>
        public virtual string AppropriationCode { get; set; }

        /// <summary>
        /// Gets or sets the sub appropriation code.
        /// </summary>
        /// <value>
        /// The sub appropriation code.
        /// </value>
        public virtual string SubAppropriationCode { get; set; }

        /// <summary>
        /// Gets or sets the fund group.
        /// </summary>
        /// <value>
        /// The fund group.
        /// </value>
        public virtual string FundGroup { get; set; }

        /// <summary>
        /// Gets or sets the no year.
        /// </summary>
        /// <value>
        /// The no year.
        /// </value>
        public virtual string NoYear { get; set; }

        /// <summary>
        /// Gets or sets the carryover.
        /// </summary>
        /// <value>
        /// The carryover.
        /// </value>
        public virtual string Carryover { get; set; }

        /// <summary>
        /// Gets or sets the cancelled year spending account.
        /// </summary>
        /// <value>
        /// The cancelled year spending account.
        /// </value>
        public virtual string CancelledYearSpendingAccount { get; set; }

        /// <summary>
        /// Gets or sets the apply at all levels.
        /// </summary>
        /// <value>
        /// The apply at all levels.
        /// </value>
        public virtual string ApplyAtAllLevels { get; set; }

        /// <summary>
        /// Gets or sets the bats fund.
        /// </summary>
        /// <value>
        /// The bats fund.
        /// </value>
        public virtual string BatsFund { get; set; }

        /// <summary>
        /// Gets or sets the bats end date.
        /// </summary>
        /// <value>
        /// The bats end date.
        /// </value>
        public virtual DateOnly BatsEndDate { get; set; }

        /// <summary>
        /// Gets or sets the bats option identifier.
        /// </summary>
        /// <value>
        /// The bats option identifier.
        /// </value>
        public virtual string BatsOptionId { get; set; }

        /// <summary>
        /// Gets or sets the security org.
        /// </summary>
        /// <value>
        /// The security org.
        /// </value>
        public virtual string SecurityOrg { get; set; }

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
        /// <param name="fundCode">The fund code.</param>
        /// <returns></returns>
        protected IDictionary<string, object> GetArgs( string fundCode )
        {
            if( !string.IsNullOrEmpty( fundCode )
               && ( fundCode.Length < 5 ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ "Code" ] = fundCode };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return new Dictionary<string, object> { [ "Name" ] = fundCode };
                }
            }

            if( !string.IsNullOrEmpty( fundCode )
               && ( fundCode.Length > 5 ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ "Name" ] = fundCode };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <param name="fundCode">The fund code.</param>
        /// <returns></returns>
        protected IDictionary<string, object> GetArgs( FundCode fundCode )
        {
            try
            {
                return Enum.IsDefined( typeof( FundCode ), fundCode )
                    ? new Dictionary<string, object> { [ "Code" ] = fundCode.ToString( ) }
                    : default( Dictionary<string, object> );
            }
            catch( SystemException ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }
    }
}
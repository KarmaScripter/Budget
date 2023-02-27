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
    /// <seealso cref="BudgetExecution.CalendarYear" />
    /// <seealso cref="CalendarYear" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ] 
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public abstract class FiscalYear : CalendarYear
    {
        /// <summary>
        /// Gets or sets the fiscal year identifier.
        /// </summary>
        /// <value>
        /// The fiscal year identifier.
        /// </value>
        public virtual int ID { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public  virtual string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public  virtual string EFY { get; set; }

        /// <summary>
        /// Gets or sets the bbfy.
        /// </summary>
        /// <value>
        /// The bbfy.
        /// </value>
        public virtual string FirstYear { get; set; }

        /// <summary>
        /// Gets or sets the ebfy.
        /// </summary>
        /// <value>
        /// The ebfy.
        /// </value>
        public virtual string LastYear { get; set; }

        /// <summary>
        /// Gets or sets the expiring year.
        /// </summary>
        /// <value>
        /// The expiring year.
        /// </value>
        public virtual string ExpiringYear { get; set; }

        /// <summary>
        /// Gets or sets the input year.
        /// </summary>
        /// <value>
        /// The input year.
        /// </value>
        public virtual string InputYear { get; set; }

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
        /// Gets or sets the cancellation date.
        /// </summary>
        /// <value>
        /// The cancellation date.
        /// </value>
        public virtual DateOnly CancellationDate { get; set; }

        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        /// <value>
        /// The expiration date.
        /// </value>
        public virtual DateOnly ExpirationDate { get; set; }

        /// <summary>
        /// Determines whether this instance is current.
        /// </summary>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if this instance is current; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        public virtual bool IsCurrent( )
        {
            try
            {
                return BFY == CurrentYear.ToString( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( bool );
            }
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "bfy" >
        /// The year.
        /// </param>
        /// <returns>
        /// </returns>
        private protected IDictionary<string, object> SetArgs( string bfy )
        {
            if( !string.IsNullOrEmpty( bfy )
               && bfy.Length == 4
               && int.Parse( bfy ) > 2018
               && int.Parse( bfy ) < 2040 )
            {
                try
                {
                    return new Dictionary<string, object> { [ "BFY" ] = bfy };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }
    }
}
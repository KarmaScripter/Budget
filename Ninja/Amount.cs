﻿// <copyright file = "Amount.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.IAmount" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeModifiersOrder" ) ]
    public class Amount 
    {
        /// <summary>
        /// Gets or sets the initial.
        /// </summary>
        /// <value>
        /// The initial.
        /// </value>
        public double Initial { get; set; }

        /// <summary>
        /// Gets or sets the delta.
        /// </summary>
        /// <value>
        /// The delta.
        /// </value>
        public double Delta { get; set; }

        /// <summary>
        /// Gets the funding.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Gets the numeric column.
        /// </summary>
        public string Numeric { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        public Amount( )
        {
            Numeric = "Amount";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public Amount( double value = 0.0 )
            : this( )
        {
            Value = value;
            Delta = Initial - Value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        public Amount( DataRow dataRow, string numeric )
        {
            Numeric = numeric;
            Value = double.Parse( dataRow[ numeric ].ToString( ) ?? string.Empty );
            Delta = Initial - Value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public Amount( Amount amount )
        {
            Numeric = amount.Numeric;
            Value = amount.Value;
            Delta = 0.0;
        }

        /// <summary>
        /// Increases the specified increment.
        /// </summary>
        /// <param name="increment">The increment.</param>
        public void Increase( int increment )
        {
            try
            {
                Delta = increment;
                Value += increment;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Decreases the specified decrement.
        /// </summary>
        /// <param name="decrement">The decrement.</param>
        public void Decrease( int decrement )
        {
            try
            {
                Delta = decrement;
                Value -= decrement;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Determines whether the specified amount is equal.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns>
        ///   <c>true</c> if the specified amount is equal; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEqual( IAmount amount )
        {
            if( amount != null )
            {
                try
                {
                    return ( ( amount?.Value == Value ) 
                        && ( amount?.Numeric?.Equals( Numeric ) == true ) );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified first is equal.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns>
        ///   <c>true</c> if the specified first is equal; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsEqual( IAmount first, IAmount second )
        {
            if( ( first != null )
               && ( second != null ) )
            {
                try
                {
                    return ( ( first?.Numeric == second?.Numeric ) 
                        && ( first.Value == second.Value ) );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Called when [changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnChanged( object sender, EventArgs e )
        {
            try
            {
                using var _message = new Message( "Not Yet Implemented" );
                _message.Show( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
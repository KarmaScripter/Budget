// <copyright file = "Amount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IAmount" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Amount : DataUnit, IAmount
    {
        /// <summary>
        /// The funding
        /// </summary>
        public double Funding { get; set; }

        /// <summary>
        /// The initial
        /// </summary>
        public double Initial { get; set; }

        /// <summary>
        /// The delta
        /// </summary>
        public double Delta { get; set; }

        /// <summary>
        /// The numeric
        /// </summary>
        public string Numeric { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        public Amount( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="value">The value.</param>
        public Amount( string numeric, double value = 0.0 )
        {
            Funding = value;
            Numeric = numeric;
            Initial = Funding;
            Delta = Initial - Funding;
        }

        /// <summary>
        /// Gets the original.
        /// </summary>
        /// <returns></returns>
        public double GetOriginal( )
        {
            try
            {
                return Initial > 0.0
                    ? Initial
                    : 0.0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0.0;
            }
        }

        /// <summary>
        /// Gets the delta.
        /// </summary>
        /// <returns></returns>
        public double GetDelta( )
        {
            try
            {
                return Delta != 0
                    ? Delta
                    : 0.0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0.0;
            }
        }

        /// <summary>
        /// Increases the specified amount.
        /// </summary>
        /// <param name="increment">The amount.</param>
        public void Increase( double increment = 0.0d )
        {
            try
            {
                Delta = increment;
                Funding += Delta;
                if( Initial != Funding )
                {
                    //unfinished
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Decreases the specified amount.
        /// </summary>
        /// <param name="decrement">The amount.</param>
        public void Decrease( double decrement = 0d )
        {
            try
            {
                Delta = decrement;
                if( Funding > decrement )
                {
                    Funding -= decrement;
                }

                if( Initial != Funding )
                {
                    // Unfinished
                }
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
            if( amount?.Funding != 0.0 )
            {
                try
                {
                    if( amount?.Funding == Funding
                       && amount?.Numeric?.Equals( Numeric ) == true )
                    {
                        return true;
                    }
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
        public static bool IsEqual( IAmount first, IAmount second )
        {
            if( first?.Funding == second?.Funding )
            {
                try
                {
                    return first?.Numeric == second?.Numeric;
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event Data.</param>
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
    }
}
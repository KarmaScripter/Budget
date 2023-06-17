// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="CollectionWithEvents.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   CollectionWithEvents.cs
// </summary>
// ******************************************************************************************

using System.Collections;
using System.ComponentModel;

namespace BudgetExecution
{
    public abstract class CollectionWithEvents : CollectionBase
    {
        private int _suspendCount;

        [ Browsable( false ) ]
        public bool IsSuspended
        {
            get
            {
                return _suspendCount > 0;
            }
        }

        public CollectionWithEvents( )
        {
            _suspendCount = 0;
        }

        [ Browsable( false ) ]
        public event CollectionClear Clearing;

        [ Browsable( false ) ]
        public event CollectionClear Cleared;

        [ Browsable( false ) ]
        public event CollectionChange Inserting;

        [ Browsable( false ) ]
        public event CollectionChange Inserted;

        [ Browsable( false ) ]
        public event CollectionChange Removing;

        [ Browsable( false ) ]
        public event CollectionChange Removed;

        public void SuspendEvents( )
        {
            _suspendCount++;
        }

        public void ResumeEvents( )
        {
            _suspendCount--;
        }

        protected override void OnClear( )
        {
            if( !IsSuspended
               && Clearing != null )
            {
                Clearing( );
            }
        }

        protected override void OnClearComplete( )
        {
            if( !IsSuspended
               && Cleared != null )
            {
                Cleared( );
            }
        }

        protected override void OnInsert( int index, object value )
        {
            if( !IsSuspended
               && Inserting != null )
            {
                Inserting( index, value );
            }
        }

        protected override void OnInsertComplete( int index, object value )
        {
            if( !IsSuspended
               && Inserted != null )
            {
                Inserted( index, value );
            }
        }

        protected override void OnRemove( int index, object value )
        {
            if( !IsSuspended
               && Removing != null )
            {
                Removing( index, value );
            }
        }

        protected override void OnRemoveComplete( int index, object value )
        {
            if( !IsSuspended
               && Removed != null )
            {
                Removed( index, value );
            }
        }

        protected int IndexOf( object value )
        {
            return List.IndexOf( value );
        }
    }
}
// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="BrowserTabStripItemCollection.cs" company="Terry D. Eppler">
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
//   BrowserTabStripItemCollection.cs
// </summary>
// ******************************************************************************************

using System;
using System.ComponentModel;

namespace BudgetExecution
{
    public class BrowserTabStripItemCollection : CollectionWithEvents
    {
        private int lockUpdate;

        public BrowserTabStripItem this[ int index ]
        {
            get
            {
                if( index < 0
                   || List.Count - 1 < index )
                {
                    return null;
                }

                return (BrowserTabStripItem)List[ index ];
            }
            set
            {
                List[ index ] = value;
            }
        }

        [ Browsable( false ) ]
        public virtual int DrawnCount
        {
            get
            {
                var count = Count;
                var num = 0;

                if( count == 0 )
                {
                    return 0;
                }

                for( var i = 0; i < count; i++ )
                {
                    if( this[ i ].IsDrawn )
                    {
                        num++;
                    }
                }

                return num;
            }
        }

        public virtual BrowserTabStripItem LastVisible
        {
            get
            {
                for( var num = Count - 1; num > 0; num-- )
                {
                    if( this[ num ].Visible )
                    {
                        return this[ num ];
                    }
                }

                return null;
            }
        }

        public virtual BrowserTabStripItem FirstVisible
        {
            get
            {
                for( var i = 0; i < Count; i++ )
                {
                    if( this[ i ].Visible )
                    {
                        return this[ i ];
                    }
                }

                return null;
            }
        }

        [ Browsable( false ) ]
        public virtual int VisibleCount
        {
            get
            {
                var count = Count;
                var num = 0;

                if( count == 0 )
                {
                    return 0;
                }

                for( var i = 0; i < count; i++ )
                {
                    if( this[ i ].Visible )
                    {
                        num++;
                    }
                }

                return num;
            }
        }

        public BrowserTabStripItemCollection( )
        {
            lockUpdate = 0;
        }

        [ Browsable( false ) ]
        public event CollectionChangeEventHandler CollectionChanged;

        public virtual void AddRange( BrowserTabStripItem[ ] items )
        {
            BeginUpdate( );

            try
            {
                foreach( var value in items )
                {
                    List.Add( value );
                }
            }
            finally
            {
                EndUpdate( );
            }
        }

        public virtual void Assign( BrowserTabStripItemCollection collection )
        {
            BeginUpdate( );

            try
            {
                Clear( );

                for( var i = 0; i < collection.Count; i++ )
                {
                    var item = collection[ i ];
                    var fATabStripItem = new BrowserTabStripItem( );
                    fATabStripItem.Assign( item );
                    Add( fATabStripItem );
                }
            }
            finally
            {
                EndUpdate( );
            }
        }

        public virtual int Add( BrowserTabStripItem item )
        {
            var num = IndexOf( item );

            if( num == -1 )
            {
                num = List.Add( item );
            }

            return num;
        }

        public virtual void Remove( BrowserTabStripItem item )
        {
            if( List.Contains( item ) )
            {
                List.Remove( item );
            }
        }

        public virtual BrowserTabStripItem MoveTo( int newIndex, BrowserTabStripItem item )
        {
            var num = List.IndexOf( item );

            if( num >= 0 )
            {
                RemoveAt( num );
                Insert( 0, item );
                return item;
            }

            return null;
        }

        public virtual int IndexOf( BrowserTabStripItem item )
        {
            return List.IndexOf( item );
        }

        public virtual bool Contains( BrowserTabStripItem item )
        {
            return List.Contains( item );
        }

        public virtual void Insert( int index, BrowserTabStripItem item )
        {
            if( !Contains( item ) )
            {
                List.Insert( index, item );
            }
        }

        protected virtual void OnCollectionChanged( CollectionChangeEventArgs e )
        {
            CollectionChanged?.Invoke( this, e );
        }

        protected virtual void BeginUpdate( )
        {
            lockUpdate++;
        }

        protected virtual void EndUpdate( )
        {
            if( --lockUpdate == 0 )
            {
                OnCollectionChanged(
                    new CollectionChangeEventArgs( CollectionChangeAction.Refresh, null ) );
            }
        }

        protected override void OnInsertComplete( int index, object item )
        {
            var fATabStripItem = item as BrowserTabStripItem;
            fATabStripItem.Changed += OnItem_Changed;

            OnCollectionChanged(
                new CollectionChangeEventArgs( CollectionChangeAction.Add, item ) );
        }

        protected override void OnRemove( int index, object item )
        {
            base.OnRemove( index, item );
            var fATabStripItem = item as BrowserTabStripItem;
            fATabStripItem.Changed -= OnItem_Changed;

            OnCollectionChanged(
                new CollectionChangeEventArgs( CollectionChangeAction.Remove, item ) );
        }

        protected override void OnClear( )
        {
            if( Count == 0 )
            {
                return;
            }

            BeginUpdate( );

            try
            {
                for( var num = Count - 1; num >= 0; num-- )
                {
                    RemoveAt( num );
                }
            }
            finally
            {
                EndUpdate( );
            }
        }

        protected virtual void OnItem_Changed( object sender, EventArgs e )
        {
            OnCollectionChanged(
                new CollectionChangeEventArgs( CollectionChangeAction.Refresh, sender ) );
        }
    }
}
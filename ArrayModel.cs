// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    public class ArrayModel : IChartSeriesModel
    {
        /// <summary>
        /// The data
        /// </summary>
        private double[ ] data;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayModel"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public ArrayModel( double[ ] data )
        {
            this.data = data;
        }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count
        {
            get
            {
                return data.GetLength( 0 );
            }
        }

        /// <summary>
        /// Gets the y.
        /// </summary>
        /// <param name="xIndex">The xIndex.</param>
        /// <returns></returns>
        public double[ ] GetY( int xIndex )
        {
            return new double[ ]
            {
                data[ xIndex ]
            };
        }

        /// <summary>
        /// Gets the x.
        /// </summary>
        /// <param name="xIndex">The xIndex.</param>
        /// <returns></returns>
        public double GetX( int xIndex )
        {
            return xIndex;
        }

        /// <summary>
        /// Gets the empty.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool GetEmpty( int index )
        {
            return false;
        }

        /// <summary>
        /// Occurs when [changed].
        /// </summary>
        public event ListChangedEventHandler Changed;
    }
}

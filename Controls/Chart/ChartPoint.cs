namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms.DataVisualization.Charting;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ChartPoint : DataPoint
    {
        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public double xAxis { get; set; } 

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public double yValue { get; set; }

        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        /// <value>
        /// The values.
        /// </value>
        public IList<double> Values { get; set; } = new List<double>( );

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartPoint"/> class.
        /// </summary>
        public ChartPoint( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartPoint"/> class.
        /// </summary>
        /// <param name="axis">The label.</param>
        /// <param name="value">The value.</param>
        public ChartPoint( double axis, double value ) 
            : base( axis, value )
        {
            xAxis = axis;
            yValue = value;
            Values.Add( value );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartPoint"/> class.
        /// </summary>
        /// <param name = "axis" > </param>
        /// <param name="values">The values.</param>
        public ChartPoint( double axis, double[ ] values ) 
            : base( axis, values )
        {
            xAxis = axis;
            yValue = values[ 0 ];
            Values.AddRange( values );
        }
    }
}
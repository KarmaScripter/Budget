namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ChartPoint
    {
        public double Label { get; set; }
        
        public double Value { get; set; }

        public IList<double> Values { get; set; }
        
        public ChartPoint( )
        {
            Values = new List<double>( );
        }
        
        public ChartPoint( double label, double value ) 
            : this( )
        {
            Label = label;
            Value = value;
            Values.Add( value );
        }
        
        public ChartPoint( double label, double[ ] values ) 
            : this( )
        {
            Label = label;
            Value = values[ 0 ];
            Values.AddRange( values );
        }
    }
}
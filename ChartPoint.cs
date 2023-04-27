namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    public class ChartPoint
    {
        public int Index { get; set; }
        
        public double Axis { get; set; }

        public IList<double> Values { get; set; }
        
        public ChartPoint( )
        {
        }
    }

}
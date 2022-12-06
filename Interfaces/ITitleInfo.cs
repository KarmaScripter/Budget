// // <copyright file = "ITitleInfo.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
    using Syncfusion.Windows.Forms.Chart;

    public interface ITitleInfo
    {
        /// <summary> Sets the main title. </summary>
        /// <returns> </returns>
        string GetMainText( );

        /// <summary> Sets the axis title. </summary>
        /// <returns> </returns>
        string GetAxisText( );
    }
}
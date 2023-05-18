// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary> </summary>
    public interface IBudgetLevel
    {
        /// <summary> Gets the level number. </summary>
        /// <returns> </returns>
        int GetNumber( );

        /// <summary> Gets the name of the level. </summary>
        /// <returns> </returns>
        string GetName( );

        /// <summary> Gets the level. </summary>
        /// <returns> </returns>
        Level GetLevel( );
    }
}
﻿// <copyright file = "IAmount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAmount
    {
        /// <summary>
        /// Gets the funding.
        /// </summary>
        /// <returns></returns>
        double Funding { get; set; }
        
        /// <summary>
        /// Gets the numeric column.
        /// </summary>
        /// <returns></returns>
        string Numeric { get; set; }
    }
}
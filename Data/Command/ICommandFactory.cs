// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution;

using System.Data.Common;

/// <summary>
/// 
/// </summary>
public interface ICommandFactory : ISource, IProvider
{
    /// <summary>
    /// Sets the command.
    /// </summary>
    /// <returns> DbCommand </returns>
    DbCommand GetCommand( );
}
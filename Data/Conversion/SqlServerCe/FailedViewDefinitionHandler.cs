// <copyright file = "FailedViewDefinitionHandler.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution;

using System;
using System.Threading;

/// <summary> </summary>
/// <param name = "viewSchema" > The view schema. </param>
/// <returns> </returns>
public delegate string FailedViewDefinitionHandler( ViewSchema viewSchema );
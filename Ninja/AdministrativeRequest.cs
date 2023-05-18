// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class AdministrativeRequest : DataUnit
    {
        /// <summary> </summary>
        public virtual string Analyst { get; set; }

        /// <summary> </summary>
        public virtual string RpioCode { get; set; }

        /// <summary> </summary>
        public virtual string DocumentTitle { get; set; }

        /// <summary> </summary>
        public virtual double Amount { get; set; }

        /// <summary> </summary>
        public virtual string FundCode { get; set; }

        /// <summary> </summary>
        public virtual string BFY { get; set; }

        /// <summary> </summary>
        public virtual string Status { get; set; }

        /// <summary> </summary>
        public virtual DateOnly OriginalActionDate { get; set; }

        /// <summary> </summary>
        public virtual DateOnly LastActionDate { get; set; }

        /// <summary> </summary>
        public virtual double Duration { get; set; }

        /// <summary> </summary>
        public virtual string BudgetFormulationSystem { get; set; }

        /// <summary> </summary>
        public virtual string Comments { get; set; }

        /// <summary> </summary>
        public virtual string RequestType { get; set; }

        /// <summary> </summary>
        public virtual string TypeCode { get; set; }

        /// <summary> </summary>
        public virtual string Decision { get; set; }
    }
}
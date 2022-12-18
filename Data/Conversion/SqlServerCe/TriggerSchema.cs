// <copyright file = "TriggerSchema.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public enum TriggerEvent
    {
        /// <summary>
        /// The delete
        /// </summary>
        Delete,

        /// <summary>
        /// The update
        /// </summary>
        Update,

        /// <summary>
        /// The insert
        /// </summary>
        Insert
    }

    /// <summary>
    /// 
    /// </summary>
    public enum TriggerType
    {
        /// <summary>
        /// The after
        /// </summary>
        After,

        /// <summary>
        /// The before
        /// </summary>
        Before
    }

    /// <summary>
    /// 
    /// </summary>
    public class TriggerSchema
    {
        /// <summary>
        /// The body
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The event
        /// </summary>
        public TriggerEvent Event { get; set; }

        /// <summary>
        /// The name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The table
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// The type
        /// </summary>
        public TriggerType Type { get; set; }
    }
}
﻿// <copyright file = "ToolButtonBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.ToolStripButton" />
    [Serializable ]
    public class ToolButtonBase : System.Windows.Forms.ToolStripButton
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual MetroTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the bar.
        /// </summary>
        /// <value>
        /// The bar.
        /// </value>
        public ToolType ToolType { get; set; }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void ReTag( object tag )
        {
            try
            {
                Tag = tag != null
                    ? tag
                    : null;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the hover text from the type of button.
        /// </summary>
        public string GetHoverText( ToolType tool )
        {
            if( Enum.IsDefined( typeof( ToolType ), tool ) )
            {
                try
                {
                    return tool switch
                    {
                        ToolType.FirstButton => "First Record",
                        ToolType.PreviousButton => "Previous Record",
                        ToolType.NextButton => "Next Record",
                        ToolType.LastButton => "Last Record",
                        ToolType.EditButton => "Edit Record",
                        ToolType.AddButton => "Add Record",
                        ToolType.DeleteButton => "Delete Record",
                        ToolType.SaveButton => "Save Record",
                        ToolType.RefreshButton => "Reset Filters",
                        ToolType.ExcelButton => "Excel Export",
                        ToolType.CalculatorButton => "Calculator",
                        ToolType.ChartButton => "Visualizations",
                        ToolType.HomeButton => "Main Menu",
                        _ => string.Empty
                    };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        public void SetHoverText( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                var _text = GetHoverText( ToolType );
                if( !string.IsNullOrEmpty( _text ) )
                {
                    try
                    {
                        HoverText = _text;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
        }

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            try
            {
                HoverText = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
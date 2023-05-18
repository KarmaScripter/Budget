// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IDocumentControlNumber
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        int ID { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        string RpioCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        string RpioName { get; set; }

        /// <summary> Gets or sets the type of the document. </summary>
        /// <value> The type of the document. </value>
        string DocumentType { get; set; }

        /// <summary> Gets or sets the document number. </summary>
        /// <value> The document number. </value>
        string DocumentNumber { get; set; }

        /// <summary> Gets or sets the document prefix. </summary>
        /// <value> The document prefix. </value>
        string DocumentPrefix { get; set; }
    }
}
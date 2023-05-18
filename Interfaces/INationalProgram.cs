// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface INationalProgram
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        int ID { get; set; }

        /// <summary> Gets the code. </summary>
        string Code { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        string Name { get; set; }

        /// <summary> Gets the title. </summary>
        /// <value> The title. </value>
        string Title { get; set; }

        /// <summary> Gets the rpio code. </summary>
        /// <value> The rpio code. </value>
        string RpioCode { get; set; }

        /// <summary> Gets or sets the NPM. </summary>
        /// <value> The NPM. </value>
        NPM NPM { get; set; }
    }
}
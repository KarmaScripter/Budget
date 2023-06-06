// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Frame.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   Frame.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary> </summary>
    public partial class Frame : UserControl
    {
        public string HoverText { get; set; }
        
        /// <summary> Gets or sets the index. </summary>
        /// <value> The index. </value>
        public int Index { get; set; }

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Frame"/>
        /// class.
        /// </summary>
        public Frame( )
        {
            InitializeComponent( );

            // Table Properties
            Table.BackColor = Color.Transparent;
            Table.ColumnCount = 1;
            Table.RowCount = 2;
            Table.Font = new Font( "Roboto", 8 );
            Table.ForeColor = Color.LightGray;

            // TextBox Properties
            TextBox.BorderColor = Color.FromArgb( 70, 70, 70 );
            TextBox.HoverColor = Color.FromArgb( 70, 70, 70 );
            TextBox.BackColor = Color.FromArgb( 30, 30, 30 );
            HoverText = TextBox.Text;
            
            // Wire Events
            TextBox.MouseEnter += OnTextBoxMouseEnter;
        }

        public virtual void OnTextBoxMouseEnter( object sender, EventArgs e )
        {
            
            if ( sender is TextBox textBox )
            {
                try
                {
                    double _double;
                    decimal _decimal;
                    float _float;
                    DateOnly _dateOnly;
                    DateTime _dateTime;
                    DateTimeOffset _dateTimeOffset;
                    var _input = textBox.Text;
                    if( !string.IsNullOrEmpty( _input ) )
                    {
                        if( ( _input.Length >= 6 )
                           && ( _input.Length <= 9 ) )
                        {
                            var _code = _input.Substring( 4, 2 );
                            var _dialog = new ProgramProjectDialog( _code );
                            _dialog.ShowDialog( );
                        }
                    }
                    else if( double.TryParse( _input, out _double ) )
                    {
                        var _value = double.Parse( _input );
                        var _form = new CalculationForm( _value );
                        _form.ShowDialog( );
                        textBox.Text = _form.Calculator.Value.ToString(  );
                    }
                    else if( decimal.TryParse( _input, out _decimal ) )
                    {
                        var _decimalValue = double.Parse( _input );
                        var _form = new CalculationForm( _decimalValue );
                        _form.ShowDialog( );
                        textBox.Text = _form.Calculator.Value.ToString( );
                    }
                    else if( DateOnly.TryParse( _input, out _dateOnly ) )
                    {
                        var _dateOnlyValue = DateTime.Parse( _input );
                        var _form = new CalendarDialog( _dateOnlyValue );
                        _form.ShowDialog( );
                        textBox.Text = _form.Calendar.SelectedDate.ToString( );
                    }
                    else if( DateTime.TryParse( _input, out _dateTime ) )
                    {
                        var _dateTimeValue = DateTime.Parse( _input );
                        var _form = new CalendarDialog( _dateTimeValue );
                        _form.ShowDialog( );
                        textBox.Text = _form.Calendar.SelectedDate.ToString( );
                    }
                    else
                    {
                        return;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        private virtual void OnMouseOver( object sender, EventArgs e )
        {
            var _button = sender as Button;
            try
            {
                if( ( _button != null )
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    if( !string.IsNullOrEmpty( HoverText ) )
                    {
                        var _hoverText = _button?.HoverText;
                        var _ = new SmallTip( _button, _hoverText );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                        {
                            var _text = Tag?.ToString( )?.SplitPascal( );
                            var _ = new SmallTip( _button, _text );
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private virtual void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( sender is Button _button
                   && ( _button != null )
                   && ( ToolTip?.Active == true ) )
                {
                    ToolTip.RemoveAll( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
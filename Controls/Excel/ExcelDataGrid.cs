// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ExcelDataGrid : Spreadsheet, ISpreadsheet
    {
        /// <summary>
        /// Gets or sets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        public SpreadsheetGrid Grid { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public SpreadsheetGridModel Model { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelDataGrid"/> class.
        /// </summary>
        public ExcelDataGrid( )
        {
            // Spreadsheet Properties
            CanApplyTheme = true;
            CanOverrideStyle = true;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            DefaultColumnCount = 26;
            DefaultRowCount = 66;
            AllowZooming = true;
            AllowCellContextMenu = true;
            CanApplyTheme = true;
            CanOverrideStyle = true;
            Margin = new Padding( 1 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            ForeColor = Color.Black;
            DefaultColumnCount = 40;
            DefaultRowCount = 60;
            AllowZooming = true;
            AllowFiltering = true;
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="file">The file.</param>
        public virtual void OpenFile( Stream file )
        {
        }

        /// <summary>
        /// Displays the message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="button">The button.</param>
        /// <param name="icon">The icon.</param>
        /// <returns></returns>
        public virtual bool DisplayMessageBox( string text, string caption,
            MessageBoxButtons button, MessageBoxIcon icon )
        {
            return false;
        }

        /// <summary>
        /// Called when [cell enter].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnCellEnter( object sender, EventArgs e )
        {
            try
            {
                var _range = CurrentCellRange;
                if( !string.IsNullOrEmpty( CurrentCellValue ) )
                {
                    if( CurrentCellValue?.Length >= 6
                       && CurrentCellValue.Length <= 9 )
                    {
                        var _code = CurrentCellValue.Substring( 4, 2 );
                        var _dialog = new ProgramProjectDialog( _code );
                        _dialog.ShowDialog( );
                    }
                }
                else if( double.TryParse( CurrentCellValue, out var value ) )
                {
                    var _form = new CalculationForm( value );
                    _form.ShowDialog( );
                    var _value = _form.Calculator.Value.ToDouble( );
                    Grid.SetCellValue( CurrentCellRange, _value.ToString( "N" ) );
                }
                else if( decimal.TryParse( CurrentCellValue, out var current ) )
                {
                    var _current = (double)current;
                    var _form = new CalculationForm( _current );
                    _form.ShowDialog( );
                    var _calculation = _form.Calculator.Value.ToDouble( );
                    var _cellValue = _calculation.ToString( "N" );
                    Grid.SetCellValue( CurrentCellRange, _cellValue );
                }
                else if( DateOnly.TryParse( CurrentCellValue, out var cellDate ) ) 
                {
                    var _cellValue = DateTime.Parse( CurrentCellValue );
                    var _form = new CalendarForm( );
                    _form.Calendar.SelectedDate = _cellValue;
                    _form.ShowDialog( );
                    Grid.SetCellValue( CurrentCellRange, _cellValue.ToString( ) );
                }
                else if( DateTime.TryParse( CurrentCellValue, out var dateTime ) ) 
                {
                    var _form = new CalendarForm( );
                    _form.Calendar.SelectedDate = dateTime;
                    _form.ShowDialog( );
                    Grid.SetCellValue( CurrentCellRange, dateTime.ToString( ) );
                }
                else if( DateTimeOffset.TryParse( CurrentCellValue, out var offSet ) ) 
                {
                    var _form = new CalendarForm( );
                    _form.Calendar.SelectedDate = offSet.DateTime;
                    _form.ShowDialog( );
                    Grid.SetCellValue( CurrentCellRange, offSet.ToString( ) );
                }
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


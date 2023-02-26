// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using MetroSet_UI.Child;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ContextMenu : ContextMenuStripEx
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextMenu"/> class.
        /// </summary>
        public ContextMenu( )
        {
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.DimGray;
            Font = new Font( "Roboto", 9 );
            ShowCheckMargin = true;
            MetroColor = Color.FromArgb( 0, 120, 212 );
            CanApplyTheme = true;
            CanOverrideStyle = true;
            Style = ContextMenuStyle.Office2016Black;
            ThemeStyle.BackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.ForeColor = Color.DimGray;
            ThemeStyle.HoverBackColor = Color.FromArgb( 17, 53, 84 );
            ThemeStyle.HoverForeColor = Color.White;
            ThemeStyle.DisabledForeColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.PressedBackColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.PressedForeColor = Color.White;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnPaint( object sender, EventArgs e )
        {
            try
            {
                CreateMenuItems( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Creates the menu items.
        /// </summary>
        public void CreateMenuItems( )
        {
            try
            {
                var _options = Enum.GetNames( typeof( MenuOption ) );
                for( var _i = 0; _i < _options.Length; _i++ )
                {
                    if( !string.IsNullOrEmpty( _options[ _i ] )
                       && _options[ _i ] != "NS" ) 
                    {
                        var _item = new ToolStripMenuItemExt( );
                        _item.Name = $"{ _options[ _i ] }";
                        _item.BackColor = Color.FromArgb( 20, 20, 20 );
                        _item.ForeColor = Color.DimGray;
                        _item.Text = $"{ _options[ _i ] }";
                        _item.Tag = _options[ _i ];
                        _item.Checked = false;
                        _item.Click += OnItemClicked;
                        Items.Add( _item ); 
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [item clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnItemClicked( object sender, EventArgs e )
        {
            if( sender is MetroSetToolStripMenuItem item )
            {
                try
                {
                    var _owner = item.Owner;
                    var _parent = _owner.Parent;
                    var _name = item.Tag.ToString( );
                    if( !string.IsNullOrEmpty( _name ) )
                    {
                        var _option = Enum.Parse( typeof( MenuOption ), _name );
                        switch( _option )
                        {
                            case MenuOption.File:
                            {
                                var _file = new FileBrowser(  );
                                _file.Parent = _parent;
                                _file.Show(  );
                                break;
                            }
                            case MenuOption.Folder:
                            {
                                var _file = new FileBrowser(  );
                                _file.Parent = _parent;
                                _file.Show(  );
                                break;
                            }
                            case MenuOption.Calculator:
                            {
                                var _calculationForm = new CalculationForm(  );
                                _calculationForm.Parent = _parent;
                                _calculationForm.Show( );
                                break;
                            }
                            case MenuOption.Calendar:
                            {
                                var _calendarForm = new CalendarForm( );
                                _calendarForm.Parent = _parent;
                                _calendarForm.Show( );
                                break;
                            }
                            case MenuOption.Guidance:
                            {
                                var _dialog = new GuidanceDialog( );
                                _dialog.Parent = _parent;
                                _dialog.Show( );
                                break;
                            }
                            case MenuOption.Save:
                            {
                                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            case MenuOption.Close:
                            {
                                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            case MenuOption.Exit:
                            {
                                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            default:
                            {
                                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                        }
                        
                        Close(  );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}


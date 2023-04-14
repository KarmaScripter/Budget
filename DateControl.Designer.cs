// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class DateControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
        if( disposing && ( components != null ) )
        {
            components.Dispose( );
        }
        base.Dispose( disposing );
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
        components =  new System.ComponentModel.Container( ) ;
        Calendar =  new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv( ) ;
        ( (System.ComponentModel.ISupportInitialize) Calendar  ).BeginInit( );
        SuspendLayout( );
        // 
        // Calendar
        // 
        Calendar.Border3DStyle =  System.Windows.Forms.Border3DStyle.Flat ;
        Calendar.BorderColor =  System.Drawing.Color.FromArgb( 209, 211, 212 ) ;
        Calendar.BottomHeight =  30 ;
        Calendar.Culture =  new System.Globalization.CultureInfo( "" ) ;
        Calendar.DayNamesFont =  new System.Drawing.Font( "Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
        Calendar.DaysFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        Calendar.Dock =  System.Windows.Forms.DockStyle.Fill ;
        Calendar.Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        Calendar.HeaderFont =  new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
        Calendar.HeaderHeight =  30 ;
        Calendar.HighlightColor =  System.Drawing.Color.Black ;
        Calendar.Iso8601CalenderFormat =  false ;
        Calendar.Location =  new System.Drawing.Point( 0, 0 ) ;
        Calendar.MetroColor =  System.Drawing.Color.FromArgb( 22, 165, 220 ) ;
        Calendar.Name =  "Calendar" ;
        // 
        // 
        // 
        Calendar.NoneButton.AutoSize =  true ;
        Calendar.NoneButton.Location =  new System.Drawing.Point( 304, 0 ) ;
        Calendar.NoneButton.Size =  new System.Drawing.Size( 72, 30 ) ;
        Calendar.NoneButton.Text =  "None" ;
        Calendar.ScrollButtonSize =  new System.Drawing.Size( 17, 18 ) ;
        Calendar.Size =  new System.Drawing.Size( 376, 325 ) ;
        Calendar.TabIndex =  0 ;
        // 
        // 
        // 
        Calendar.TodayButton.AutoSize =  true ;
        Calendar.TodayButton.Location =  new System.Drawing.Point( 0, 0 ) ;
        Calendar.TodayButton.Size =  new System.Drawing.Size( 304, 30 ) ;
        Calendar.TodayButton.Text =  "Today" ;
        Calendar.WeekFont =  new System.Drawing.Font( "Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        // 
        // DateControl
        // 
        AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
        AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
        BackColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
        Controls.Add( Calendar );
        Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ForeColor =  System.Drawing.Color.LightGray ;
        Name =  "DateControl" ;
        Size =  new System.Drawing.Size( 376, 325 ) ;
        ( (System.ComponentModel.ISupportInitialize) Calendar  ).EndInit( );
        ResumeLayout( false );
    }

    #endregion

    private Syncfusion.Windows.Forms.Tools.MonthCalendarAdv Calendar;
}

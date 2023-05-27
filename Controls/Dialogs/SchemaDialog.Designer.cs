// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class SchemaDialog
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
        components = new System.ComponentModel.Container( );
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( SchemaDialog ) );
        BindingSource = new System.Windows.Forms.BindingSource( components );
        cartesianChart1 = new LiveCharts.WinForms.CartesianChart( );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        SuspendLayout( );
        // 
        // cartesianChart1
        // 
        cartesianChart1.ForeColor = System.Drawing.Color.DarkGray;
        cartesianChart1.Location = new System.Drawing.Point( 317, 144 );
        cartesianChart1.Name = "cartesianChart1";
        cartesianChart1.Size = new System.Drawing.Size( 228, 131 );
        cartesianChart1.TabIndex = 0;
        cartesianChart1.Text = "cartesianChart1";
        // 
        // SchemaDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
        CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionBarHeight = 1;
        CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ClientSize = new System.Drawing.Size( 1328, 669 );
        Controls.Add( cartesianChart1 );
        Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ForeColor = System.Drawing.Color.Gray;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
        Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        MaximumSize = new System.Drawing.Size( 1340, 676 );
        MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        MinimumSize = new System.Drawing.Size( 1340, 676 );
        Name = "SchemaDialog";
        ShowIcon = false;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        Text = "Data Columns";
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        ResumeLayout( false );
    }

    #endregion
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
    private DataGrid DataGrid;
    private LiveCharts.WinForms.CartesianChart cartesianChart1;
}
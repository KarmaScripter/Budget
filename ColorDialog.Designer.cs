// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class ColorDialog
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorDialog));
            this.ColorPicker = new Syncfusion.Windows.Forms.ColorUIControl();
            this.layout1 = new BudgetExecution.Layout();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layout1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorPicker
            // 
            this.ColorPicker.BeforeTouchSize = new System.Drawing.Size(189, 154);
            this.ColorPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColorPicker.ForeColor = System.Drawing.Color.LightGray;
            this.ColorPicker.Location = new System.Drawing.Point(16, 13);
            this.ColorPicker.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ColorPicker.MetroForeColor = System.Drawing.Color.LightGray;
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.ScrollMetroColorTable = metroColorTable1;
            this.ColorPicker.Size = new System.Drawing.Size(189, 154);
            this.ColorPicker.TabIndex = 0;
            this.ColorPicker.Text = "coloruiControl1";
            this.ColorPicker.ThemeName = "Office2016Black";
            this.ColorPicker.ThemeStyle.ColorListStyle.PaletteBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ColorPicker.ThemeStyle.ColorListStyle.SelectedItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ColorPicker.VisualStyle = Syncfusion.Windows.Forms.ColorUIStyle.Office2016Black;
            // 
            // layout1
            // 
            this.layout1.BackColor = System.Drawing.Color.Transparent;
            this.layout1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.layout1.BindingSource = null;
            this.layout1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.layout1.BorderThickness = 1;
            this.layout1.Children = null;
            this.layout1.Controls.Add(this.ColorPicker);
            this.layout1.DataFilter = null;
            this.layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.layout1.ForeColor = System.Drawing.Color.Transparent;
            this.layout1.HoverText = null;
            this.layout1.IsDerivedStyle = true;
            this.layout1.Location = new System.Drawing.Point(3, 59);
            this.layout1.Name = "layout1";
            this.layout1.Padding = new System.Windows.Forms.Padding(1);
            this.layout1.Size = new System.Drawing.Size(340, 221);
            this.layout1.Style = MetroSet_UI.Enums.Style.Custom;
            this.layout1.StyleManager = null;
            this.layout1.TabIndex = 1;
            this.layout1.ThemeAuthor = "Terry D. Eppler";
            this.layout1.ThemeName = "Budget Execution";
            this.layout1.ToolTip = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.layout1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.83806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.16194F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 356);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(440, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "ColorDialog";
            this.ShowIcon = false;
            this.Text = "ColorDialog";
            this.layout1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    public Syncfusion.Windows.Forms.ColorUIControl ColorPicker;
    private Layout layout1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
}
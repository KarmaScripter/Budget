namespace BudgetExecution
{
    partial class FormBase
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
            var bootstrap1 = new Zeroit.Framework.BasicCharts.Bootstrap( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( FormBase ) );
            var material1 = new Zeroit.Framework.BasicCharts.Material( );
            ContextMenu = new ContextMenu( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ToolTip = new SmallTip( );
            zeroitBarChart1 = new Zeroit.Framework.BasicCharts.ZeroitBarChart( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            SuspendLayout( );
            // 
            // ContextMenu
            // 
            ContextMenu.AutoSize = false;
            ContextMenu.BackColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            ContextMenu.ForeColor = System.Drawing.Color.White;
            ContextMenu.IsDerivedStyle = false;
            ContextMenu.Name = "ContextMenu";
            ContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            ContextMenu.Size = new System.Drawing.Size( 156, 264 );
            ContextMenu.Style = MetroSet_UI.Enums.Style.Custom;
            ContextMenu.StyleManager = null;
            ContextMenu.ThemeAuthor = "Terry Eppler";
            ContextMenu.ThemeName = "Budget Execution";
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb(   5  ,   5  ,   5   );
            ToolTip.BindingSource = null;
            ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            ToolTip.ForeColor = System.Drawing.Color.White;
            ToolTip.InitialDelay = 500;
            ToolTip.IsDerivedStyle = true;
            ToolTip.Name = null;
            ToolTip.OwnerDraw = true;
            ToolTip.ReshowDelay = 100;
            ToolTip.Style = MetroSet_UI.Enums.Style.Custom;
            ToolTip.StyleManager = null;
            ToolTip.ThemeAuthor = "Terry D. Eppler";
            ToolTip.ThemeName = "Budget Execution";
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // zeroitBarChart1
            // 
            zeroitBarChart1.AllowTransparency = true;
            bootstrap1.Background = System.Drawing.Color.FromArgb(   35  ,   40  ,   50   );
            bootstrap1.BorderWidth = 1F;
            bootstrap1.GridColors = System.Drawing.Color.FromArgb(   60  ,   65  ,   70   );
            bootstrap1.OrientBackground = System.Drawing.Color.FromArgb(   30  ,   35  ,   40   );
            bootstrap1.TextColor = System.Drawing.Color.FromArgb(   115  ,   120  ,   125   );
            zeroitBarChart1.BootstrapColors = bootstrap1;
            zeroitBarChart1.DrawMode = Zeroit.Framework.BasicCharts.ZeroitBarChart.DrawType.Solid;
            zeroitBarChart1.FilledColor = System.Drawing.Color.FromArgb(   30  ,   33  ,   38   );
            zeroitBarChart1.FilledGradient = new System.Drawing.Color[ ] { System.Drawing.Color.Beige, System.Drawing.Color.Crimson };
            zeroitBarChart1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            zeroitBarChart1.GraphOrientation = Zeroit.Framework.BasicCharts.ZeroitBarChart.Orientation.Vertical;
            zeroitBarChart1.GraphStyle = Zeroit.Framework.BasicCharts.ZeroitBarChart.Style.Flat;
            zeroitBarChart1.GridSize = 1F;
            zeroitBarChart1.HatchBrush = new System.Drawing.Color[ ] { System.Drawing.Color.Black, System.Drawing.Color.Transparent };
            zeroitBarChart1.HatchStyle = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
            zeroitBarChart1.Items = (System.Collections.Generic.List<int>) resources.GetObject( "zeroitBarChart1.Items" ) ;
            zeroitBarChart1.Location = new System.Drawing.Point( 144, 222 );
            material1.Background = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            material1.Colors = (System.Collections.Generic.List<System.Drawing.Color>) resources.GetObject( "material1.Colors" ) ;
            zeroitBarChart1.MaterialColors = material1;
            zeroitBarChart1.Name = "zeroitBarChart1";
            zeroitBarChart1.ShowGrid = false;
            zeroitBarChart1.Size = new System.Drawing.Size( 615, 302 );
            zeroitBarChart1.Sorting = Zeroit.Framework.BasicCharts.ZeroitBarChart.SortStyle.Normal;
            zeroitBarChart1.SplitterColor = System.Drawing.Color.FromArgb(   59  ,   62  ,   71   );
            zeroitBarChart1.TabIndex = 1;
            zeroitBarChart1.Text = "zeroitBarChart1";
            zeroitBarChart1.TextAlignment = Zeroit.Framework.BasicCharts.ZeroitBarChart.Aligning.Far;
            zeroitBarChart1.TextColor = System.Drawing.Color.FromArgb(   120  ,   120  ,   120   );
            zeroitBarChart1.UnfilledColor = System.Drawing.Color.FromArgb(   37  ,   40  ,   49   );
            // 
            // FormBase
            // 
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ClientSize = new System.Drawing.Size( 1338, 738 );
            ControlBox = false;
            Controls.Add( zeroitBarChart1 );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "FormBase";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public ContextMenu ContextMenu;
        private Zeroit.Framework.BasicCharts.ZeroitBarChart zeroitBarChart1;
    }
}
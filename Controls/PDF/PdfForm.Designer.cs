namespace BudgetExecution
{
    using System.Windows.Forms;
    

    partial class PdfForm
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings2 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings2 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfForm));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings2 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            Syncfusion.Windows.Forms.CaptionImage captionImage2 = new Syncfusion.Windows.Forms.CaptionImage();
            this.DocumentViewer = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            this.ToolStrip = new BudgetExecution.ToolStrip();
            this.Separator1 = new BudgetExecution.ToolSeparator();
            this.Label = new BudgetExecution.ToolStripLabel();
            this.ToolSeparator = new BudgetExecution.ToolSeparator();
            this.TextBox = new BudgetExecution.ToolStripTextBox();
            this.Separator2 = new BudgetExecution.ToolSeparator();
            this.DropDown = new BudgetExecution.ToolStripDropDown();
            this.Separator3 = new BudgetExecution.ToolSeparator();
            this.LookupButton = new BudgetExecution.ToolStripButton();
            this.Separator6 = new BudgetExecution.ToolSeparator();
            this.DatabaseButton = new BudgetExecution.ToolStripButton();
            this.Separator4 = new BudgetExecution.ToolSeparator();
            this.HomeButton = new BudgetExecution.ToolStripButton();
            this.Separator5 = new BudgetExecution.ToolSeparator();
            this.LogoutButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator7 = new BudgetExecution.ToolSeparator();
            this.toolSeparator3 = new BudgetExecution.ToolSeparator();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentViewer
            // 
            this.DocumentViewer.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.DocumentViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentViewer.EnableContextMenu = true;
            this.DocumentViewer.EnableNotificationBar = true;
            this.DocumentViewer.HorizontalScrollOffset = 0;
            this.DocumentViewer.IsBookmarkEnabled = true;
            this.DocumentViewer.IsTextSearchEnabled = true;
            this.DocumentViewer.IsTextSelectionEnabled = true;
            this.DocumentViewer.Location = new System.Drawing.Point(0, 0);
            messageBoxSettings2.EnableNotification = true;
            this.DocumentViewer.MessageBoxSettings = messageBoxSettings2;
            this.DocumentViewer.MinimumZoomPercentage = 50;
            this.DocumentViewer.Name = "DocumentViewer";
            this.DocumentViewer.PageBorderThickness = 1;
            pdfViewerPrinterSettings2.Copies = 1;
            pdfViewerPrinterSettings2.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings2.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings2.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings2.PrintLocation")));
            pdfViewerPrinterSettings2.ShowPrintStatusDialog = true;
            this.DocumentViewer.PrinterSettings = pdfViewerPrinterSettings2;
            this.DocumentViewer.ReferencePath = null;
            this.DocumentViewer.ScrollDisplacementValue = 0;
            this.DocumentViewer.ShowHorizontalScrollBar = true;
            this.DocumentViewer.ShowToolBar = true;
            this.DocumentViewer.ShowVerticalScrollBar = true;
            this.DocumentViewer.Size = new System.Drawing.Size(1388, 669);
            this.DocumentViewer.SpaceBetweenPages = 8;
            this.DocumentViewer.TabIndex = 0;
            this.DocumentViewer.Text = "DocumentViewer";
            textSearchSettings2.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings2.HighlightAllInstance = true;
            textSearchSettings2.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.DocumentViewer.TextSearchSettings = textSearchSettings2;
            this.DocumentViewer.ThemeName = "Default";
            this.DocumentViewer.UseWaitCursor = true;
            this.DocumentViewer.VerticalScrollOffset = 0;
            this.DocumentViewer.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.DocumentViewer.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // ToolStrip
            // 
            this.ToolStrip.AddButton = null;
            this.ToolStrip.AddColumnButton = null;
            this.ToolStrip.AddTableButton = null;
            this.ToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.BindingSource = null;
            this.ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolStrip.CalculatorButton = null;
            this.ToolStrip.CanOverrideStyle = true;
            this.ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            this.ToolStrip.CaptionFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            this.ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.ToolStrip.ChartButton = null;
            this.ToolStrip.DataFilter = null;
            this.ToolStrip.DeleteButton = null;
            this.ToolStrip.DeleteColumnButton = null;
            this.ToolStrip.DeleteRecordButton = null;
            this.ToolStrip.DeleteTableButton = null;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.DropDown = null;
            this.ToolStrip.EditButton = null;
            this.ToolStrip.EditColumnButton = null;
            this.ToolStrip.EditRecordButton = null;
            this.ToolStrip.EditSqlButton = null;
            this.ToolStrip.ExcelButton = null;
            this.ToolStrip.Field = BudgetExecution.Field.AccountCode;
            this.ToolStrip.FilterDataButton = null;
            this.ToolStrip.FirstButton = null;
            this.ToolStrip.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.HomeButton = null;
            this.ToolStrip.Image = null;
            this.ToolStrip.ImageDirectory = null;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 18);
            this.ToolStrip.ImageSize = new System.Drawing.Size(0, 0);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator1,
            this.Label,
            this.ToolSeparator,
            this.TextBox,
            this.Separator2,
            this.DropDown,
            this.Separator3,
            this.LookupButton,
            this.Separator6,
            this.DatabaseButton,
            this.Separator4,
            this.HomeButton,
            this.Separator5,
            this.LogoutButton,
            this.toolSeparator7});
            this.ToolStrip.Label = null;
            this.ToolStrip.LastButton = null;
            this.ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.ToolStrip.Location = new System.Drawing.Point(0, 669);
            this.ToolStrip.Margin = new System.Windows.Forms.Padding(1);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.NextButton = null;
            this.ToolStrip.Numeric = BudgetExecution.Numeric.Accepted;
            this.ToolStrip.Office12Mode = false;
            this.ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(1);
            this.ToolStrip.PreviousButton = null;
            this.ToolStrip.ProgressBar = null;
            this.ToolStrip.RefreshButton = null;
            this.ToolStrip.SaveButton = null;
            this.ToolStrip.Separators = null;
            this.ToolStrip.ShowCaption = true;
            this.ToolStrip.ShowLauncher = true;
            this.ToolStrip.Size = new System.Drawing.Size(1388, 44);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            this.ToolStrip.TextBox = null;
            this.ToolStrip.ThemeName = "Office2016DarkGray";
            this.ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            this.ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            this.ToolStrip.UseWaitCursor = true;
            this.ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Margin = new System.Windows.Forms.Padding(1);
            this.Separator1.Name = "Separator1";
            this.Separator1.Padding = new System.Windows.Forms.Padding(1);
            this.Separator1.Size = new System.Drawing.Size(6, 26);
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Label.BindingSource = null;
            this.Label.DataFilter = null;
            this.Label.Field = BudgetExecution.Field.AccountCode;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.ForeColor = System.Drawing.Color.White;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(1);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(1);
            this.Label.Size = new System.Drawing.Size(91, 26);
            this.Label.Tag = "";
            this.Label.Text = "toolStripLabel1";
            this.Label.ToolTip = null;
            // 
            // ToolSeparator
            // 
            this.ToolSeparator.ForeColor = System.Drawing.Color.Black;
            this.ToolSeparator.Margin = new System.Windows.Forms.Padding(1);
            this.ToolSeparator.Name = "ToolSeparator";
            this.ToolSeparator.Padding = new System.Windows.Forms.Padding(1);
            this.ToolSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TextBox.BindingSource = null;
            this.TextBox.Field = BudgetExecution.Field.AccountCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox.HoverText = "";
            this.TextBox.Margin = new System.Windows.Forms.Padding(1);
            this.TextBox.Name = "TextBox";
            this.TextBox.Padding = new System.Windows.Forms.Padding(1);
            this.TextBox.Size = new System.Drawing.Size(140, 26);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = null;
            // 
            // Separator2
            // 
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Margin = new System.Windows.Forms.Padding(1);
            this.Separator2.Name = "Separator2";
            this.Separator2.Padding = new System.Windows.Forms.Padding(1);
            this.Separator2.Size = new System.Drawing.Size(6, 26);
            // 
            // DropDown
            // 
            this.DropDown.AllowDrop = true;
            this.DropDown.BindingSource = null;
            this.DropDown.DataFilter = null;
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.Field = BudgetExecution.Field.AccountCode;
            this.DropDown.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.DropDown.HoverText = "Make Selection";
            this.DropDown.Margin = new System.Windows.Forms.Padding(1);
            this.DropDown.MaxDropDownItems = 100;
            this.DropDown.MaxLength = 32767;
            this.DropDown.Name = "DropDown";
            this.DropDown.Numeric = BudgetExecution.Numeric.Accepted;
            this.DropDown.Padding = new System.Windows.Forms.Padding(1);
            this.DropDown.Size = new System.Drawing.Size(198, 26);
            this.DropDown.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            this.DropDown.Tag = "Make Selection";
            this.DropDown.ToolTipText = "Make Selection";
            // 
            // Separator3
            // 
            this.Separator3.ForeColor = System.Drawing.Color.Black;
            this.Separator3.Margin = new System.Windows.Forms.Padding(1);
            this.Separator3.Name = "Separator3";
            this.Separator3.Padding = new System.Windows.Forms.Padding(1);
            this.Separator3.Size = new System.Drawing.Size(6, 26);
            // 
            // LookupButton
            // 
            this.LookupButton.AutoToolTip = false;
            this.LookupButton.BackColor = System.Drawing.Color.Transparent;
            this.LookupButton.BindingSource = null;
            this.LookupButton.DataFilter = null;
            this.LookupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LookupButton.Field = BudgetExecution.Field.AccountCode;
            this.LookupButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LookupButton.ForeColor = System.Drawing.Color.LightGray;
            this.LookupButton.HoverText = "Browse Documents";
            this.LookupButton.Image = global::BudgetExecution.Properties.Resources.LookupButton;
            this.LookupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LookupButton.Margin = new System.Windows.Forms.Padding(1);
            this.LookupButton.Name = "LookupButton";
            this.LookupButton.Padding = new System.Windows.Forms.Padding(1);
            this.LookupButton.Size = new System.Drawing.Size(26, 26);
            this.LookupButton.Text = "toolStripButton1";
            this.LookupButton.ToolTip = null;
            this.LookupButton.ToolType = BudgetExecution.ToolType.LookupButton;
            // 
            // Separator6
            // 
            this.Separator6.ForeColor = System.Drawing.Color.Black;
            this.Separator6.Margin = new System.Windows.Forms.Padding(1);
            this.Separator6.Name = "Separator6";
            this.Separator6.Padding = new System.Windows.Forms.Padding(1);
            this.Separator6.Size = new System.Drawing.Size(6, 26);
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.AutoToolTip = false;
            this.DatabaseButton.BackColor = System.Drawing.Color.Transparent;
            this.DatabaseButton.BindingSource = null;
            this.DatabaseButton.DataFilter = null;
            this.DatabaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DatabaseButton.Field = BudgetExecution.Field.AccountCode;
            this.DatabaseButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatabaseButton.ForeColor = System.Drawing.Color.LightGray;
            this.DatabaseButton.HoverText = "View Databases";
            this.DatabaseButton.Image = global::BudgetExecution.Properties.Resources.DatabaseButton;
            this.DatabaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DatabaseButton.Margin = new System.Windows.Forms.Padding(1);
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Padding = new System.Windows.Forms.Padding(1);
            this.DatabaseButton.Size = new System.Drawing.Size(26, 26);
            this.DatabaseButton.Text = "toolStripButton1";
            this.DatabaseButton.ToolTip = null;
            this.DatabaseButton.ToolType = BudgetExecution.ToolType.DatabaseButton;
            // 
            // Separator4
            // 
            this.Separator4.ForeColor = System.Drawing.Color.Black;
            this.Separator4.Margin = new System.Windows.Forms.Padding(1);
            this.Separator4.Name = "Separator4";
            this.Separator4.Padding = new System.Windows.Forms.Padding(1);
            this.Separator4.Size = new System.Drawing.Size(6, 26);
            // 
            // HomeButton
            // 
            this.HomeButton.AutoToolTip = false;
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BindingSource = null;
            this.HomeButton.DataFilter = null;
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Field = BudgetExecution.Field.AccountCode;
            this.HomeButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.LightGray;
            this.HomeButton.HoverText = "Main Menu";
            this.HomeButton.Image = global::BudgetExecution.Properties.Resources.HomeButton;
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Margin = new System.Windows.Forms.Padding(1);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(1);
            this.HomeButton.Size = new System.Drawing.Size(26, 26);
            this.HomeButton.Text = "toolStripButton1";
            this.HomeButton.ToolTip = null;
            this.HomeButton.ToolType = BudgetExecution.ToolType.HomeButton;
            // 
            // Separator5
            // 
            this.Separator5.ForeColor = System.Drawing.Color.Black;
            this.Separator5.Margin = new System.Windows.Forms.Padding(1);
            this.Separator5.Name = "Separator5";
            this.Separator5.Padding = new System.Windows.Forms.Padding(1);
            this.Separator5.Size = new System.Drawing.Size(6, 26);
            // 
            // LogoutButton
            // 
            this.LogoutButton.AutoToolTip = false;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BindingSource = null;
            this.LogoutButton.DataFilter = null;
            this.LogoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogoutButton.Field = BudgetExecution.Field.AccountCode;
            this.LogoutButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.ForeColor = System.Drawing.Color.LightGray;
            this.LogoutButton.HoverText = "Exit Application";
            this.LogoutButton.Image = global::BudgetExecution.Properties.Resources.LogoutButton;
            this.LogoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(1);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(1);
            this.LogoutButton.Size = new System.Drawing.Size(26, 26);
            this.LogoutButton.Text = "toolStripButton2";
            this.LogoutButton.ToolTip = null;
            this.LogoutButton.ToolType = BudgetExecution.ToolType.LogoutButton;
            // 
            // toolSeparator7
            // 
            this.toolSeparator7.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator7.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator7.Name = "toolSeparator7";
            this.toolSeparator7.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator7.Size = new System.Drawing.Size(6, 26);
            // 
            // toolSeparator3
            // 
            this.toolSeparator3.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator3.Margin = new System.Windows.Forms.Padding(1);
            this.toolSeparator3.Name = "toolSeparator3";
            this.toolSeparator3.Padding = new System.Windows.Forms.Padding(1);
            this.toolSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.IsDerivedStyle = true;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.Style = MetroSet_UI.Enums.Style.Custom;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipText = null;
            this.ToolTip.TipTitle = null;
            // 
            // PdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            captionImage2.BackColor = System.Drawing.Color.Transparent;
            captionImage2.Image = global::BudgetExecution.Properties.Resources.PDF;
            captionImage2.Location = new System.Drawing.Point(6, 4);
            captionImage2.Name = "CaptionImage";
            captionImage2.Size = new System.Drawing.Size(22, 22);
            this.CaptionImages.Add(captionImage2);
            this.ClientSize = new System.Drawing.Size(1388, 713);
            this.Controls.Add(this.DocumentViewer);
            this.Controls.Add(this.ToolStrip);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MinimizeBox = false;
            this.Name = "PdfForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "    PDF ";
            this.UseWaitCursor = true;
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl DocumentViewer;
        public ToolSeparator Separator1;
        public ToolStrip ToolStrip;
        public  ToolSeparator ToolSeparator;
        public ToolStripTextBox TextBox;
        public  ToolSeparator Separator2;
        public  ToolStripDropDown DropDown;
        public ToolSeparator Separator3;
        public ToolStripLabel Label;
        public ToolStripButton LookupButton;
        public  ToolSeparator toolSeparator3;
        public  ToolSeparator Separator4;

        public ToolStripButton DatabaseButton;
        private ToolSeparator toolSeparator7;
        public ToolSeparator Separator6;
        public ToolSeparator Separator5;
        public ToolStripButton HomeButton;
        public ToolStripButton LogoutButton;
        public BindingSource BindingSource;
        public SmallTip ToolTip;
    }
}
namespace BudgetExecution
{
    

    partial class DefinitionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinitionDialog));
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.SchemaPanelLabel = new BudgetExecution.Label();
            this.SchemaPanel = new BudgetExecution.Layout();
            this.SchemaPanelTextBox = new BudgetExecution.TextBox();
            this.ToolTip = new BudgetExecution.SmallTip();
            this.AddColumnButton = new BudgetExecution.Button();
            this.DataTypeComboBox = new BudgetExecution.ComboBox();
            this.TablePanel = new BudgetExecution.Layout();
            this.TableNameComboBox = new BudgetExecution.ComboBox();
            this.TablePanelTextBox = new BudgetExecution.TextBox();
            this.TablePanelLabel = new BudgetExecution.Label();
            this.ProviderPanel = new BudgetExecution.Layout();
            this.SqliteRadioButton = new BudgetExecution.RadioButton();
            this.AccessRadioButton = new BudgetExecution.RadioButton();
            this.SqlServerRadioButton = new BudgetExecution.RadioButton();
            this.ProviderPanelLabel = new BudgetExecution.Label();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox7 = new BudgetExecution.Layout();
            this.listBox5 = new BudgetExecution.ListBox();
            this.listBox6 = new BudgetExecution.ListBox();
            this.groupBox8 = new BudgetExecution.Layout();
            this.visualLabel3 = new BudgetExecution.Label();
            this.visualLabel5 = new BudgetExecution.Label();
            this.visualTextBox3 = new BudgetExecution.TextBox();
            this.visualComboBox3 = new BudgetExecution.ComboBox();
            this.SelectButton = new BudgetExecution.Button();
            this.RefreshButton = new BudgetExecution.Button();
            this.CloseButton = new BudgetExecution.Button();
            this.groupBox2 = new BudgetExecution.Layout();
            this.groupBox3 = new BudgetExecution.Layout();
            this.groupBox4 = new BudgetExecution.Layout();
            this.groupBox9 = new BudgetExecution.Layout();
            this.label1 = new BudgetExecution.Label();
            this.label2 = new BudgetExecution.Label();
            this.label3 = new BudgetExecution.Label();
            this.button1 = new BudgetExecution.Button();
            this.button3 = new BudgetExecution.Button();
            this.label4 = new BudgetExecution.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.SchemaPanel.SuspendLayout();
            this.TablePanel.SuspendLayout();
            this.ProviderPanel.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ActiveTabFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.BeforeTouchSize = new System.Drawing.Size(1368, 503);
            this.TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabControl.CanOverrideStyle = true;
            this.TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.Controls.Add(this.TabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.FocusOnTabClick = false;
            this.TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ItemSize = new System.Drawing.Size(158, 23);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Size = new System.Drawing.Size(1368, 503);
            this.TabControl.TabIndex = 8;
            this.TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.TabControl.ThemeName = "TabRendererMetro";
            this.TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControl.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.DisabledTabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.EditableTabStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TabControl.ThemeStyle.EditableTabStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            this.TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveCloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TabControl.ThemeStyle.TabStyle.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            // 
            // TabPage
            // 
            this.TabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabPage.Controls.Add(this.SchemaPanelLabel);
            this.TabPage.Controls.Add(this.SchemaPanel);
            this.TabPage.Controls.Add(this.TablePanel);
            this.TabPage.Controls.Add(this.TablePanelLabel);
            this.TabPage.Controls.Add(this.ProviderPanel);
            this.TabPage.Controls.Add(this.ProviderPanelLabel);
            this.TabPage.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TabPage.Image = null;
            this.TabPage.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage.Location = new System.Drawing.Point(0, 22);
            this.TabPage.Name = "TabPage";
            this.TabPage.ShowCloseButton = true;
            this.TabPage.Size = new System.Drawing.Size(1368, 481);
            this.TabPage.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabPage.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage.TabIndex = 3;
            this.TabPage.ThemesEnabled = false;
            // 
            // SchemaPanelLabel
            // 
            this.SchemaPanelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchemaPanelLabel.BindingSource = null;
            this.SchemaPanelLabel.DataFilter = null;
            this.SchemaPanelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SchemaPanelLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SchemaPanelLabel.HoverText = null;
            this.SchemaPanelLabel.IsDerivedStyle = true;
            this.SchemaPanelLabel.Location = new System.Drawing.Point(958, 130);
            this.SchemaPanelLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SchemaPanelLabel.Name = "SchemaPanelLabel";
            this.SchemaPanelLabel.Padding = new System.Windows.Forms.Padding(1);
            this.SchemaPanelLabel.Size = new System.Drawing.Size(377, 23);
            this.SchemaPanelLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SchemaPanelLabel.StyleManager = null;
            this.SchemaPanelLabel.TabIndex = 12;
            this.SchemaPanelLabel.Text = "Schema";
            this.SchemaPanelLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SchemaPanelLabel.ThemeAuthor = "Terry D. Eppler";
            this.SchemaPanelLabel.ThemeName = "BudgetExecution";
            this.SchemaPanelLabel.ToolTip = null;
            // 
            // SchemaPanel
            // 
            this.SchemaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchemaPanel.BackColor = System.Drawing.Color.Transparent;
            this.SchemaPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SchemaPanel.BindingSource = null;
            this.SchemaPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SchemaPanel.BorderThickness = 1;
            this.SchemaPanel.Children = null;
            this.SchemaPanel.Controls.Add(this.label2);
            this.SchemaPanel.Controls.Add(this.label1);
            this.SchemaPanel.Controls.Add(this.SchemaPanelTextBox);
            this.SchemaPanel.Controls.Add(this.AddColumnButton);
            this.SchemaPanel.Controls.Add(this.DataTypeComboBox);
            this.SchemaPanel.DataFilter = null;
            this.SchemaPanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SchemaPanel.ForeColor = System.Drawing.Color.Transparent;
            this.SchemaPanel.HoverText = null;
            this.SchemaPanel.IsDerivedStyle = true;
            this.SchemaPanel.Location = new System.Drawing.Point(958, 159);
            this.SchemaPanel.Name = "SchemaPanel";
            this.SchemaPanel.Padding = new System.Windows.Forms.Padding(1);
            this.SchemaPanel.Size = new System.Drawing.Size(387, 164);
            this.SchemaPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.SchemaPanel.StyleManager = null;
            this.SchemaPanel.TabIndex = 11;
            this.SchemaPanel.ThemeAuthor = "Terry D. Eppler";
            this.SchemaPanel.ThemeName = "BudgetExecution";
            this.SchemaPanel.ToolTip = null;
            // 
            // SchemaPanelTextBox
            // 
            this.SchemaPanelTextBox.AutoCompleteCustomSource = null;
            this.SchemaPanelTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SchemaPanelTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SchemaPanelTextBox.BindingSource = null;
            this.SchemaPanelTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SchemaPanelTextBox.DataFilter = null;
            this.SchemaPanelTextBox.DisabledBackColor = System.Drawing.Color.Transparent;
            this.SchemaPanelTextBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.SchemaPanelTextBox.DisabledForeColor = System.Drawing.Color.Transparent;
            this.SchemaPanelTextBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SchemaPanelTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SchemaPanelTextBox.HoverText = "Enter Column Name";
            this.SchemaPanelTextBox.Image = null;
            this.SchemaPanelTextBox.IsDerivedStyle = true;
            this.SchemaPanelTextBox.Lines = null;
            this.SchemaPanelTextBox.Location = new System.Drawing.Point(26, 112);
            this.SchemaPanelTextBox.MaxLength = 32767;
            this.SchemaPanelTextBox.Multiline = false;
            this.SchemaPanelTextBox.Name = "SchemaPanelTextBox";
            this.SchemaPanelTextBox.ReadOnly = false;
            this.SchemaPanelTextBox.Size = new System.Drawing.Size(245, 30);
            this.SchemaPanelTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.SchemaPanelTextBox.StyleManager = null;
            this.SchemaPanelTextBox.TabIndex = 6;
            this.SchemaPanelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SchemaPanelTextBox.ThemeAuthor = "Terry D. Eppler";
            this.SchemaPanelTextBox.ThemeName = "BudgetExecution";
            this.SchemaPanelTextBox.ToolTip = this.ToolTip;
            this.SchemaPanelTextBox.UseSystemPasswordChar = false;
            this.SchemaPanelTextBox.WatermarkText = "";
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
            // AddColumnButton
            // 
            this.AddColumnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddColumnButton.BackColor = System.Drawing.Color.Transparent;
            this.AddColumnButton.BindingSource = null;
            this.AddColumnButton.DataFilter = null;
            this.AddColumnButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.AddColumnButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.AddColumnButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.AddColumnButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddColumnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AddColumnButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.AddColumnButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.AddColumnButton.HoverText = null;
            this.AddColumnButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.AddColumnButton.IsDerivedStyle = true;
            this.AddColumnButton.Location = new System.Drawing.Point(317, 39);
            this.AddColumnButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.AddColumnButton.NormalColor = System.Drawing.Color.Transparent;
            this.AddColumnButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AddColumnButton.Padding = new System.Windows.Forms.Padding(1);
            this.AddColumnButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AddColumnButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AddColumnButton.PressTextColor = System.Drawing.Color.White;
            this.AddColumnButton.Size = new System.Drawing.Size(49, 28);
            this.AddColumnButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.AddColumnButton.StyleManager = null;
            this.AddColumnButton.TabIndex = 10;
            this.AddColumnButton.Text = "+";
            this.AddColumnButton.ThemeAuthor = "Terry D. Eppler";
            this.AddColumnButton.ThemeName = "BudgetExecution";
            this.AddColumnButton.ToolTip = null;
            // 
            // DataTypeComboBox
            // 
            this.DataTypeComboBox.AllowDrop = true;
            this.DataTypeComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.DataTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.DataTypeComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DataTypeComboBox.BindingSource = null;
            this.DataTypeComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DataTypeComboBox.CausesValidation = false;
            this.DataTypeComboBox.DataFilter = null;
            this.DataTypeComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            this.DataTypeComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.DataTypeComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            this.DataTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DataTypeComboBox.DropDownHeight = 100;
            this.DataTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataTypeComboBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataTypeComboBox.FormattingEnabled = true;
            this.DataTypeComboBox.HoverText = null;
            this.DataTypeComboBox.IntegralHeight = false;
            this.DataTypeComboBox.IsDerivedStyle = true;
            this.DataTypeComboBox.ItemHeight = 24;
            this.DataTypeComboBox.Location = new System.Drawing.Point(26, 37);
            this.DataTypeComboBox.Name = "DataTypeComboBox";
            this.DataTypeComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.DataTypeComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.DataTypeComboBox.Size = new System.Drawing.Size(245, 30);
            this.DataTypeComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.DataTypeComboBox.StyleManager = null;
            this.DataTypeComboBox.TabIndex = 11;
            this.DataTypeComboBox.ThemeAuthor = "Terry D. Eppler";
            this.DataTypeComboBox.ThemeName = "BudgetExecution";
            this.DataTypeComboBox.ToolTip = this.ToolTip;
            // 
            // TablePanel
            // 
            this.TablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanel.BackColor = System.Drawing.Color.Transparent;
            this.TablePanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TablePanel.BindingSource = null;
            this.TablePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TablePanel.BorderThickness = 1;
            this.TablePanel.Children = null;
            this.TablePanel.Controls.Add(this.label4);
            this.TablePanel.Controls.Add(this.button3);
            this.TablePanel.Controls.Add(this.button1);
            this.TablePanel.Controls.Add(this.label3);
            this.TablePanel.Controls.Add(this.TableNameComboBox);
            this.TablePanel.Controls.Add(this.TablePanelTextBox);
            this.TablePanel.DataFilter = null;
            this.TablePanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TablePanel.ForeColor = System.Drawing.Color.Transparent;
            this.TablePanel.HoverText = null;
            this.TablePanel.IsDerivedStyle = true;
            this.TablePanel.Location = new System.Drawing.Point(502, 159);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Padding = new System.Windows.Forms.Padding(1);
            this.TablePanel.Size = new System.Drawing.Size(395, 164);
            this.TablePanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.TablePanel.StyleManager = null;
            this.TablePanel.TabIndex = 10;
            this.TablePanel.ThemeAuthor = "Terry D. Eppler";
            this.TablePanel.ThemeName = "BudgetExecution";
            this.TablePanel.ToolTip = null;
            // 
            // TableNameComboBox
            // 
            this.TableNameComboBox.AllowDrop = true;
            this.TableNameComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TableNameComboBox.BackColor = System.Drawing.Color.Transparent;
            this.TableNameComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TableNameComboBox.BindingSource = null;
            this.TableNameComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TableNameComboBox.CausesValidation = false;
            this.TableNameComboBox.DataFilter = null;
            this.TableNameComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            this.TableNameComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.TableNameComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            this.TableNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TableNameComboBox.DropDownHeight = 100;
            this.TableNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableNameComboBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableNameComboBox.FormattingEnabled = true;
            this.TableNameComboBox.HoverText = null;
            this.TableNameComboBox.IntegralHeight = false;
            this.TableNameComboBox.IsDerivedStyle = true;
            this.TableNameComboBox.ItemHeight = 24;
            this.TableNameComboBox.Location = new System.Drawing.Point(26, 37);
            this.TableNameComboBox.Name = "TableNameComboBox";
            this.TableNameComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TableNameComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.TableNameComboBox.Size = new System.Drawing.Size(232, 30);
            this.TableNameComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.TableNameComboBox.StyleManager = null;
            this.TableNameComboBox.TabIndex = 12;
            this.TableNameComboBox.ThemeAuthor = "Terry D. Eppler";
            this.TableNameComboBox.ThemeName = "BudgetExecution";
            this.TableNameComboBox.ToolTip = this.ToolTip;
            // 
            // TablePanelTextBox
            // 
            this.TablePanelTextBox.AutoCompleteCustomSource = null;
            this.TablePanelTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TablePanelTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TablePanelTextBox.BindingSource = null;
            this.TablePanelTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TablePanelTextBox.DataFilter = null;
            this.TablePanelTextBox.DisabledBackColor = System.Drawing.Color.Transparent;
            this.TablePanelTextBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.TablePanelTextBox.DisabledForeColor = System.Drawing.Color.Transparent;
            this.TablePanelTextBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TablePanelTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.TablePanelTextBox.HoverText = "New Column Name";
            this.TablePanelTextBox.Image = null;
            this.TablePanelTextBox.IsDerivedStyle = true;
            this.TablePanelTextBox.Lines = null;
            this.TablePanelTextBox.Location = new System.Drawing.Point(26, 112);
            this.TablePanelTextBox.MaxLength = 32767;
            this.TablePanelTextBox.Multiline = false;
            this.TablePanelTextBox.Name = "TablePanelTextBox";
            this.TablePanelTextBox.ReadOnly = false;
            this.TablePanelTextBox.Size = new System.Drawing.Size(232, 30);
            this.TablePanelTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.TablePanelTextBox.StyleManager = null;
            this.TablePanelTextBox.TabIndex = 7;
            this.TablePanelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TablePanelTextBox.ThemeAuthor = "Terry D. Eppler";
            this.TablePanelTextBox.ThemeName = "Budget Execution";
            this.TablePanelTextBox.ToolTip = this.ToolTip;
            this.TablePanelTextBox.UseSystemPasswordChar = false;
            this.TablePanelTextBox.WatermarkText = "";
            // 
            // TablePanelLabel
            // 
            this.TablePanelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanelLabel.BindingSource = null;
            this.TablePanelLabel.DataFilter = null;
            this.TablePanelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TablePanelLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TablePanelLabel.HoverText = null;
            this.TablePanelLabel.IsDerivedStyle = true;
            this.TablePanelLabel.Location = new System.Drawing.Point(502, 130);
            this.TablePanelLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TablePanelLabel.Name = "TablePanelLabel";
            this.TablePanelLabel.Padding = new System.Windows.Forms.Padding(1);
            this.TablePanelLabel.Size = new System.Drawing.Size(377, 23);
            this.TablePanelLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.TablePanelLabel.StyleManager = null;
            this.TablePanelLabel.TabIndex = 9;
            this.TablePanelLabel.Text = "Tables";
            this.TablePanelLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TablePanelLabel.ThemeAuthor = "Terry D. Eppler";
            this.TablePanelLabel.ThemeName = "BudgetExecution";
            this.TablePanelLabel.ToolTip = null;
            // 
            // ProviderPanel
            // 
            this.ProviderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProviderPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ProviderPanel.BindingSource = null;
            this.ProviderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProviderPanel.BorderThickness = 1;
            this.ProviderPanel.Children = null;
            this.ProviderPanel.Controls.Add(this.SqliteRadioButton);
            this.ProviderPanel.Controls.Add(this.AccessRadioButton);
            this.ProviderPanel.Controls.Add(this.SqlServerRadioButton);
            this.ProviderPanel.DataFilter = null;
            this.ProviderPanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ProviderPanel.HoverText = null;
            this.ProviderPanel.IsDerivedStyle = true;
            this.ProviderPanel.Location = new System.Drawing.Point(30, 159);
            this.ProviderPanel.Name = "ProviderPanel";
            this.ProviderPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ProviderPanel.Size = new System.Drawing.Size(395, 164);
            this.ProviderPanel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ProviderPanel.StyleManager = null;
            this.ProviderPanel.TabIndex = 7;
            this.ProviderPanel.ThemeAuthor = "Terry D. Eppler";
            this.ProviderPanel.ThemeName = "BudgetExecution";
            this.ProviderPanel.ToolTip = null;
            // 
            // SqliteRadioButton
            // 
            this.SqliteRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SqliteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqliteRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SqliteRadioButton.Checked = false;
            this.SqliteRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqliteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.SqliteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.SqliteRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqliteRadioButton.Group = 0;
            this.SqliteRadioButton.HoverText = null;
            this.SqliteRadioButton.IsDerivedStyle = true;
            this.SqliteRadioButton.Location = new System.Drawing.Point(112, 34);
            this.SqliteRadioButton.Name = "SqliteRadioButton";
            this.SqliteRadioButton.Result = null;
            this.SqliteRadioButton.Size = new System.Drawing.Size(95, 17);
            this.SqliteRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SqliteRadioButton.StyleManager = null;
            this.SqliteRadioButton.TabIndex = 1;
            this.SqliteRadioButton.Tag = "";
            this.SqliteRadioButton.Text = "    SQLite";
            this.SqliteRadioButton.ThemeAuthor = "Narwin";
            this.SqliteRadioButton.ThemeName = "MetroDark";
            this.SqliteRadioButton.ToolTip = this.ToolTip;
            // 
            // AccessRadioButton
            // 
            this.AccessRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.AccessRadioButton.Checked = false;
            this.AccessRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.AccessRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccessRadioButton.Group = 0;
            this.AccessRadioButton.HoverText = null;
            this.AccessRadioButton.IsDerivedStyle = true;
            this.AccessRadioButton.Location = new System.Drawing.Point(112, 122);
            this.AccessRadioButton.Name = "AccessRadioButton";
            this.AccessRadioButton.Result = null;
            this.AccessRadioButton.Size = new System.Drawing.Size(95, 17);
            this.AccessRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.AccessRadioButton.StyleManager = null;
            this.AccessRadioButton.TabIndex = 3;
            this.AccessRadioButton.Tag = "";
            this.AccessRadioButton.Text = "    MS Access";
            this.AccessRadioButton.ThemeAuthor = "Narwin";
            this.AccessRadioButton.ThemeName = "MetroDark";
            this.AccessRadioButton.ToolTip = this.ToolTip;
            // 
            // SqlServerRadioButton
            // 
            this.SqlServerRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SqlServerRadioButton.Checked = false;
            this.SqlServerRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.SqlServerRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqlServerRadioButton.Group = 0;
            this.SqlServerRadioButton.HoverText = null;
            this.SqlServerRadioButton.IsDerivedStyle = true;
            this.SqlServerRadioButton.Location = new System.Drawing.Point(112, 74);
            this.SqlServerRadioButton.Name = "SqlServerRadioButton";
            this.SqlServerRadioButton.Result = null;
            this.SqlServerRadioButton.Size = new System.Drawing.Size(95, 17);
            this.SqlServerRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SqlServerRadioButton.StyleManager = null;
            this.SqlServerRadioButton.TabIndex = 2;
            this.SqlServerRadioButton.Tag = "";
            this.SqlServerRadioButton.Text = "    SQL Server";
            this.SqlServerRadioButton.ThemeAuthor = "Narwin";
            this.SqlServerRadioButton.ThemeName = "MetroDark";
            this.SqlServerRadioButton.ToolTip = this.ToolTip;
            // 
            // ProviderPanelLabel
            // 
            this.ProviderPanelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderPanelLabel.BindingSource = null;
            this.ProviderPanelLabel.DataFilter = null;
            this.ProviderPanelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProviderPanelLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderPanelLabel.HoverText = null;
            this.ProviderPanelLabel.IsDerivedStyle = true;
            this.ProviderPanelLabel.Location = new System.Drawing.Point(30, 130);
            this.ProviderPanelLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ProviderPanelLabel.Name = "ProviderPanelLabel";
            this.ProviderPanelLabel.Padding = new System.Windows.Forms.Padding(1);
            this.ProviderPanelLabel.Size = new System.Drawing.Size(259, 23);
            this.ProviderPanelLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ProviderPanelLabel.StyleManager = null;
            this.ProviderPanelLabel.TabIndex = 8;
            this.ProviderPanelLabel.Text = "Database  ";
            this.ProviderPanelLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ProviderPanelLabel.ThemeAuthor = "Terry D. Eppler";
            this.ProviderPanelLabel.ThemeName = "BudgetExecution";
            this.ProviderPanelLabel.ToolTip = null;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.groupBox7);
            this.tabPageAdv1.Controls.Add(this.groupBox8);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(200, 100);
            this.tabPageAdv1.TabFont = null;
            this.tabPageAdv1.TabIndex = 0;
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox7.BindingSource = null;
            this.groupBox7.BorderColor = System.Drawing.Color.Transparent;
            this.groupBox7.BorderThickness = 1;
            this.groupBox7.Children = null;
            this.groupBox7.Controls.Add(this.listBox5);
            this.groupBox7.Controls.Add(this.listBox6);
            this.groupBox7.DataFilter = null;
            this.groupBox7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox7.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox7.HoverText = null;
            this.groupBox7.IsDerivedStyle = true;
            this.groupBox7.Location = new System.Drawing.Point(438, 58);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox7.Size = new System.Drawing.Size(377, 191);
            this.groupBox7.Style = MetroSet_UI.Enums.Style.Custom;
            this.groupBox7.StyleManager = null;
            this.groupBox7.TabIndex = 6;
            this.groupBox7.ThemeAuthor = "Terry D. Eppler";
            this.groupBox7.ThemeName = "BudgetExecution";
            this.groupBox7.ToolTip = null;
            // 
            // listBox5
            // 
            this.listBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listBox5.BindingSource = null;
            this.listBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBox5.DataFilter = null;
            this.listBox5.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox5.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox5.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.listBox5.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.listBox5.HoverText = null;
            this.listBox5.IsDerivedStyle = true;
            this.listBox5.ItemHeight = 30;
            this.listBox5.Location = new System.Drawing.Point(15, 37);
            this.listBox5.Margin = new System.Windows.Forms.Padding(1);
            this.listBox5.MultiSelect = false;
            this.listBox5.Name = "listBox5";
            this.listBox5.Padding = new System.Windows.Forms.Padding(1);
            this.listBox5.SelectedIndex = -1;
            this.listBox5.SelectedItem = null;
            this.listBox5.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.listBox5.SelectedItemColor = System.Drawing.Color.White;
            this.listBox5.SelectedText = null;
            this.listBox5.SelectedValue = null;
            this.listBox5.ShowBorder = false;
            this.listBox5.ShowScrollBar = false;
            this.listBox5.Size = new System.Drawing.Size(348, 131);
            this.listBox5.Style = MetroSet_UI.Enums.Style.Custom;
            this.listBox5.StyleManager = null;
            this.listBox5.TabIndex = 2;
            this.listBox5.Text = "listBox3";
            this.listBox5.ThemeAuthor = "Terry D. Eppler";
            this.listBox5.ThemeName = "BudgetExecution";
            this.listBox5.ToolTip = this.ToolTip;
            // 
            // listBox6
            // 
            this.listBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listBox6.BindingSource = null;
            this.listBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBox6.DataFilter = null;
            this.listBox6.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox6.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox6.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.listBox6.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            this.listBox6.HoverText = null;
            this.listBox6.IsDerivedStyle = true;
            this.listBox6.ItemHeight = 30;
            this.listBox6.Location = new System.Drawing.Point(15, 37);
            this.listBox6.Margin = new System.Windows.Forms.Padding(1);
            this.listBox6.MultiSelect = false;
            this.listBox6.Name = "listBox6";
            this.listBox6.Padding = new System.Windows.Forms.Padding(1);
            this.listBox6.SelectedIndex = -1;
            this.listBox6.SelectedItem = null;
            this.listBox6.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.listBox6.SelectedItemColor = System.Drawing.Color.White;
            this.listBox6.SelectedText = null;
            this.listBox6.SelectedValue = null;
            this.listBox6.ShowBorder = false;
            this.listBox6.ShowScrollBar = false;
            this.listBox6.Size = new System.Drawing.Size(348, 131);
            this.listBox6.Style = MetroSet_UI.Enums.Style.Custom;
            this.listBox6.StyleManager = null;
            this.listBox6.TabIndex = 1;
            this.listBox6.Text = "listBox4";
            this.listBox6.ThemeAuthor = "Terry D. Eppler";
            this.listBox6.ThemeName = "BudgetExecution";
            this.listBox6.ToolTip = this.ToolTip;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox8.BindingSource = null;
            this.groupBox8.BorderColor = System.Drawing.Color.Transparent;
            this.groupBox8.BorderThickness = 1;
            this.groupBox8.Children = null;
            this.groupBox8.Controls.Add(this.visualLabel3);
            this.groupBox8.Controls.Add(this.visualLabel5);
            this.groupBox8.Controls.Add(this.visualTextBox3);
            this.groupBox8.DataFilter = null;
            this.groupBox8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox8.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox8.HoverText = null;
            this.groupBox8.IsDerivedStyle = true;
            this.groupBox8.Location = new System.Drawing.Point(25, 293);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox8.Size = new System.Drawing.Size(790, 186);
            this.groupBox8.Style = MetroSet_UI.Enums.Style.Custom;
            this.groupBox8.StyleManager = null;
            this.groupBox8.TabIndex = 5;
            this.groupBox8.ThemeAuthor = "Terry D. Eppler";
            this.groupBox8.ThemeName = "BudgetExecution";
            this.groupBox8.ToolTip = null;
            // 
            // visualLabel3
            // 
            this.visualLabel3.BindingSource = null;
            this.visualLabel3.DataFilter = null;
            this.visualLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualLabel3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visualLabel3.HoverText = null;
            this.visualLabel3.IsDerivedStyle = true;
            this.visualLabel3.Location = new System.Drawing.Point(92, 53);
            this.visualLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.visualLabel3.Name = "visualLabel3";
            this.visualLabel3.Padding = new System.Windows.Forms.Padding(1);
            this.visualLabel3.Size = new System.Drawing.Size(177, 21);
            this.visualLabel3.Style = MetroSet_UI.Enums.Style.Custom;
            this.visualLabel3.StyleManager = null;
            this.visualLabel3.TabIndex = 3;
            this.visualLabel3.Text = "Select  Existing Column";
            this.visualLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visualLabel3.ThemeAuthor = "Terry D. Eppler";
            this.visualLabel3.ThemeName = "BudgetExecution";
            this.visualLabel3.ToolTip = null;
            // 
            // visualLabel5
            // 
            this.visualLabel5.BindingSource = null;
            this.visualLabel5.DataFilter = null;
            this.visualLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualLabel5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visualLabel5.HoverText = null;
            this.visualLabel5.IsDerivedStyle = true;
            this.visualLabel5.Location = new System.Drawing.Point(419, 53);
            this.visualLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.visualLabel5.Name = "visualLabel5";
            this.visualLabel5.Padding = new System.Windows.Forms.Padding(1);
            this.visualLabel5.Size = new System.Drawing.Size(120, 21);
            this.visualLabel5.Style = MetroSet_UI.Enums.Style.Custom;
            this.visualLabel5.StyleManager = null;
            this.visualLabel5.TabIndex = 2;
            this.visualLabel5.Text = "Enter New Name";
            this.visualLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visualLabel5.ThemeAuthor = "Terry D. Eppler";
            this.visualLabel5.ThemeName = "BudgetExecution";
            this.visualLabel5.ToolTip = null;
            // 
            // visualTextBox3
            // 
            this.visualTextBox3.AutoCompleteCustomSource = null;
            this.visualTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.visualTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.visualTextBox3.BindingSource = null;
            this.visualTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.visualTextBox3.DataFilter = null;
            this.visualTextBox3.DisabledBackColor = System.Drawing.Color.Transparent;
            this.visualTextBox3.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.visualTextBox3.DisabledForeColor = System.Drawing.Color.Transparent;
            this.visualTextBox3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visualTextBox3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.visualTextBox3.HoverText = null;
            this.visualTextBox3.Image = null;
            this.visualTextBox3.IsDerivedStyle = true;
            this.visualTextBox3.Lines = null;
            this.visualTextBox3.Location = new System.Drawing.Point(419, 85);
            this.visualTextBox3.MaxLength = 32767;
            this.visualTextBox3.Multiline = false;
            this.visualTextBox3.Name = "visualTextBox3";
            this.visualTextBox3.ReadOnly = false;
            this.visualTextBox3.Size = new System.Drawing.Size(278, 23);
            this.visualTextBox3.Style = MetroSet_UI.Enums.Style.Custom;
            this.visualTextBox3.StyleManager = null;
            this.visualTextBox3.TabIndex = 1;
            this.visualTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.visualTextBox3.ThemeAuthor = "Terry D. Eppler";
            this.visualTextBox3.ThemeName = "BudgetExecution";
            this.visualTextBox3.ToolTip = null;
            this.visualTextBox3.UseSystemPasswordChar = false;
            this.visualTextBox3.WatermarkText = "";
            // 
            // visualComboBox3
            // 
            this.visualComboBox3.AllowDrop = true;
            this.visualComboBox3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.visualComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.visualComboBox3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.visualComboBox3.BindingSource = null;
            this.visualComboBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.visualComboBox3.CausesValidation = false;
            this.visualComboBox3.DataFilter = null;
            this.visualComboBox3.DisabledBackColor = System.Drawing.Color.Transparent;
            this.visualComboBox3.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.visualComboBox3.DisabledForeColor = System.Drawing.Color.Transparent;
            this.visualComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.visualComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visualComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualComboBox3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visualComboBox3.HoverText = null;
            this.visualComboBox3.IsDerivedStyle = true;
            this.visualComboBox3.ItemHeight = 24;
            this.visualComboBox3.Location = new System.Drawing.Point(0, 0);
            this.visualComboBox3.Name = "visualComboBox3";
            this.visualComboBox3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.visualComboBox3.SelectedItemForeColor = System.Drawing.Color.White;
            this.visualComboBox3.Size = new System.Drawing.Size(121, 30);
            this.visualComboBox3.Style = MetroSet_UI.Enums.Style.Custom;
            this.visualComboBox3.StyleManager = null;
            this.visualComboBox3.TabIndex = 0;
            this.visualComboBox3.ThemeAuthor = "Terry D. Eppler";
            this.visualComboBox3.ThemeName = "BudgetExecution";
            this.visualComboBox3.ToolTip = null;
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectButton.BindingSource = null;
            this.SelectButton.DataFilter = null;
            this.SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.SelectButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SelectButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SelectButton.HoverText = "Not Yet Implemented!";
            this.SelectButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.SelectButton.IsDerivedStyle = true;
            this.SelectButton.Location = new System.Drawing.Point(188, 523);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(0);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.SelectButton.NormalColor = System.Drawing.Color.Transparent;
            this.SelectButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.Padding = new System.Windows.Forms.Padding(1);
            this.SelectButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.PressTextColor = System.Drawing.Color.White;
            this.SelectButton.Size = new System.Drawing.Size(140, 80);
            this.SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.SelectButton.StyleManager = null;
            this.SelectButton.TabIndex = 7;
            this.SelectButton.Text = "Select";
            this.SelectButton.ThemeAuthor = "Terry D. Eppler";
            this.SelectButton.ThemeName = "BudgetExecution";
            this.SelectButton.ToolTip = this.ToolTip;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.BindingSource = null;
            this.RefreshButton.DataFilter = null;
            this.RefreshButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.RefreshButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.RefreshButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.RefreshButton.HoverText = "Not Yet Implemented!";
            this.RefreshButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshButton.IsDerivedStyle = true;
            this.RefreshButton.Location = new System.Drawing.Point(616, 523);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.RefreshButton.NormalColor = System.Drawing.Color.Transparent;
            this.RefreshButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.PressTextColor = System.Drawing.Color.White;
            this.RefreshButton.Size = new System.Drawing.Size(140, 80);
            this.RefreshButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.RefreshButton.StyleManager = null;
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Clear";
            this.RefreshButton.ThemeAuthor = "Terry D. Eppler";
            this.RefreshButton.ThemeName = "BudgetExecution";
            this.RefreshButton.ToolTip = this.ToolTip;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BindingSource = null;
            this.CloseButton.DataFilter = null;
            this.CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverText = "Close Window";
            this.CloseButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.CloseButton.IsDerivedStyle = true;
            this.CloseButton.Location = new System.Drawing.Point(1066, 523);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressTextColor = System.Drawing.Color.White;
            this.CloseButton.Size = new System.Drawing.Size(140, 80);
            this.CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.CloseButton.StyleManager = null;
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.ThemeAuthor = "Terry D. Eppler";
            this.CloseButton.ThemeName = "BudgetExecution";
            this.CloseButton.ToolTip = this.ToolTip;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox2.BindingSource = null;
            this.groupBox2.BorderColor = System.Drawing.Color.Transparent;
            this.groupBox2.BorderThickness = 1;
            this.groupBox2.Children = null;
            this.groupBox2.DataFilter = null;
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox2.HoverText = null;
            this.groupBox2.IsDerivedStyle = true;
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(250, 150);
            this.groupBox2.Style = MetroSet_UI.Enums.Style.Custom;
            this.groupBox2.StyleManager = null;
            this.groupBox2.TabIndex = 0;
            this.groupBox2.ThemeAuthor = "Terry D. Eppler";
            this.groupBox2.ThemeName = "BudgetExecution";
            this.groupBox2.ToolTip = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox3.BindingSource = null;
            this.groupBox3.BorderColor = System.Drawing.Color.Transparent;
            this.groupBox3.BorderThickness = 1;
            this.groupBox3.Children = null;
            this.groupBox3.DataFilter = null;
            this.groupBox3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox3.HoverText = null;
            this.groupBox3.IsDerivedStyle = true;
            this.groupBox3.Location = new System.Drawing.Point(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(250, 150);
            this.groupBox3.Style = MetroSet_UI.Enums.Style.Custom;
            this.groupBox3.StyleManager = null;
            this.groupBox3.TabIndex = 0;
            this.groupBox3.ThemeAuthor = "Terry D. Eppler";
            this.groupBox3.ThemeName = "BudgetExecution";
            this.groupBox3.ToolTip = null;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox4.BindingSource = null;
            this.groupBox4.BorderColor = System.Drawing.Color.Transparent;
            this.groupBox4.BorderThickness = 1;
            this.groupBox4.Children = null;
            this.groupBox4.DataFilter = null;
            this.groupBox4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox4.HoverText = null;
            this.groupBox4.IsDerivedStyle = true;
            this.groupBox4.Location = new System.Drawing.Point(1, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox4.Size = new System.Drawing.Size(250, 150);
            this.groupBox4.Style = MetroSet_UI.Enums.Style.Custom;
            this.groupBox4.StyleManager = null;
            this.groupBox4.TabIndex = 0;
            this.groupBox4.ThemeAuthor = "Terry D. Eppler";
            this.groupBox4.ThemeName = "BudgetExecution";
            this.groupBox4.ToolTip = null;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox9.BindingSource = null;
            this.groupBox9.BorderColor = System.Drawing.Color.Transparent;
            this.groupBox9.BorderThickness = 1;
            this.groupBox9.Children = null;
            this.groupBox9.DataFilter = null;
            this.groupBox9.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox9.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox9.HoverText = null;
            this.groupBox9.IsDerivedStyle = true;
            this.groupBox9.Location = new System.Drawing.Point(1, 1);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox9.Size = new System.Drawing.Size(250, 150);
            this.groupBox9.Style = MetroSet_UI.Enums.Style.Custom;
            this.groupBox9.StyleManager = null;
            this.groupBox9.TabIndex = 0;
            this.groupBox9.ThemeAuthor = "Terry D. Eppler";
            this.groupBox9.ThemeName = "BudgetExecution";
            this.groupBox9.ToolTip = null;
            // 
            // label1
            // 
            this.label1.BindingSource = null;
            this.label1.DataFilter = null;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.HoverText = null;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.IsDerivedStyle = true;
            this.label1.Location = new System.Drawing.Point(26, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.Style = MetroSet_UI.Enums.Style.Custom;
            this.label1.StyleManager = null;
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Column Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.ThemeAuthor = "Terry D. Eppler";
            this.label1.ThemeName = "Budget Execution";
            this.label1.ToolTip = null;
            // 
            // label2
            // 
            this.label2.BindingSource = null;
            this.label2.DataFilter = null;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.HoverText = null;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.IsDerivedStyle = true;
            this.label2.Location = new System.Drawing.Point(26, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(233, 24);
            this.label2.Style = MetroSet_UI.Enums.Style.Custom;
            this.label2.StyleManager = null;
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Data Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.ThemeAuthor = "Terry D. Eppler";
            this.label2.ThemeName = "Budget Execution";
            this.label2.ToolTip = null;
            // 
            // label3
            // 
            this.label3.BindingSource = null;
            this.label3.DataFilter = null;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.HoverText = null;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.IsDerivedStyle = true;
            this.label3.Location = new System.Drawing.Point(25, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(233, 24);
            this.label3.Style = MetroSet_UI.Enums.Style.Custom;
            this.label3.StyleManager = null;
            this.label3.TabIndex = 14;
            this.label3.Text = "Select Data Table";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.ThemeAuthor = "Terry D. Eppler";
            this.label3.ThemeName = "Budget Execution";
            this.label3.ToolTip = null;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BindingSource = null;
            this.button1.DataFilter = null;
            this.button1.DisabledBackColor = System.Drawing.Color.Transparent;
            this.button1.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.button1.DisabledForeColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.button1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.button1.HoverText = null;
            this.button1.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.button1.IsDerivedStyle = true;
            this.button1.Location = new System.Drawing.Point(287, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.NormalBorderColor = System.Drawing.Color.Transparent;
            this.button1.NormalColor = System.Drawing.Color.Transparent;
            this.button1.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button1.Padding = new System.Windows.Forms.Padding(1);
            this.button1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button1.PressTextColor = System.Drawing.Color.White;
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.Style = MetroSet_UI.Enums.Style.Custom;
            this.button1.StyleManager = null;
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.ThemeAuthor = "Terry D. Eppler";
            this.button1.ThemeName = "BudgetExecution";
            this.button1.ToolTip = null;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BindingSource = null;
            this.button3.DataFilter = null;
            this.button3.DisabledBackColor = System.Drawing.Color.Transparent;
            this.button3.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.button3.DisabledForeColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.button3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.button3.HoverText = null;
            this.button3.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.button3.IsDerivedStyle = true;
            this.button3.Location = new System.Drawing.Point(287, 103);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.NormalBorderColor = System.Drawing.Color.Transparent;
            this.button3.NormalColor = System.Drawing.Color.Transparent;
            this.button3.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button3.Padding = new System.Windows.Forms.Padding(1);
            this.button3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button3.PressTextColor = System.Drawing.Color.White;
            this.button3.Size = new System.Drawing.Size(74, 28);
            this.button3.Style = MetroSet_UI.Enums.Style.Custom;
            this.button3.StyleManager = null;
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.ThemeAuthor = "Terry D. Eppler";
            this.button3.ThemeName = "BudgetExecution";
            this.button3.ToolTip = null;
            // 
            // label4
            // 
            this.label4.BindingSource = null;
            this.label4.DataFilter = null;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.HoverText = null;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.IsDerivedStyle = true;
            this.label4.Location = new System.Drawing.Point(26, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.Style = MetroSet_UI.Enums.Style.Custom;
            this.label4.StyleManager = null;
            this.label4.TabIndex = 18;
            this.label4.Text = "Enter Table Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.ThemeAuthor = "Terry D. Eppler";
            this.label4.ThemeName = "Budget Execution";
            this.label4.ToolTip = null;
            // 
            // DefinitionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1368, 663);
            this.ControlBox = false;
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CloseButton);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefinitionDialog";
            this.Provider = BudgetExecution.Provider.NS;
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPage.ResumeLayout(false);
            this.SchemaPanel.ResumeLayout(false);
            this.TablePanel.ResumeLayout(false);
            this.ProviderPanel.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public Button RefreshButton;
        public Button CloseButton;
        public Button SelectButton;
        public Layout groupBox2;
        public Layout groupBox3;
        public Layout groupBox4;
        public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv TabPage;
        public Layout groupBox7;
        public ListBox listBox5;
        public ListBox listBox6;
        public Layout groupBox8;
        public BudgetExecution.ComboBox visualComboBox3;
        public BudgetExecution.Label visualLabel3;
        public BudgetExecution.Label visualLabel5;
        public BudgetExecution.TextBox visualTextBox3;
        public Layout groupBox9;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        public Button AddColumnButton;
        public TextBox SchemaPanelTextBox;
        public TextBox TablePanelTextBox;
        public ComboBox DataTypeComboBox;
        private Layout ProviderPanel;
        public RadioButton SqliteRadioButton;
        public RadioButton AccessRadioButton;
        public RadioButton SqlServerRadioButton;
        private Label ProviderPanelLabel;
        private Layout SchemaPanel;
        private Layout TablePanel;
        private Label TablePanelLabel;
        private Label SchemaPanelLabel;
        public ComboBox TableNameComboBox;
        private Label label2;
        private Label label1;
        public Button button3;
        public Button button1;
        private Label label3;
        private Label label4;
    }
}
namespace POSeidon
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.Button addProductButton;
            System.Windows.Forms.Button addCustomerButton;
            System.Windows.Forms.Button addSupplierButton;
            System.Windows.Forms.Button addUserButton;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftsideMainPanel = new System.Windows.Forms.Panel();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.usernameTextLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.homePageMainPanel = new System.Windows.Forms.Panel();
            this.homePageDataGridView = new System.Windows.Forms.DataGridView();
            this.homePageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.statisticsPagePanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.customersPageMainPanel = new System.Windows.Forms.Panel();
            this.customersTabDataGridView = new System.Windows.Forms.DataGridView();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersPageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.customerSearchTextBox = new System.Windows.Forms.TextBox();
            this.suppliersTab = new System.Windows.Forms.TabPage();
            this.suppliersPageMainPanel = new System.Windows.Forms.Panel();
            this.suppliersTabDataGridView = new System.Windows.Forms.DataGridView();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersPageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.supplierSearchTextBox = new System.Windows.Forms.TextBox();
            this.salesAndPurchasingTab = new System.Windows.Forms.TabPage();
            this.salesAndPurchasingPanel = new System.Windows.Forms.Panel();
            this.salesAndPurchasingNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.salesNavigatorPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.salesHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasingNavigatorPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.purchasingDataGridView = new System.Windows.Forms.DataGridView();
            this.productPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonePurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.languageSettingsLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.languageSettingsComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.weightUnitSettingsLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.weightUnitComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.currencySettingsGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.currencySettingsGroupSeparatorComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.currencySettingsDecimalSeparatorComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.currencySettingsGroupSeparatorLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currencySettingsDecimalSeparatorLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currencySettingsPutSpaceCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.currencySettingsSymbolPlacementRightRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.currencySettingsSymbolPlacementLeftRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.currencySettingsLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currencySettingsSymbolPlacementLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currencySettingsComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.supplierStatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customerStatisticsPanel = new System.Windows.Forms.Panel();
            this.customerStatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customerStatisticsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.usersPageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.usersSearchTextBox = new System.Windows.Forms.TextBox();
            this.usersPageMainPanel = new System.Windows.Forms.Panel();
            this.usersPageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteCustomerDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.deleteSupplierDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.shoppingCartLeftSidePanelButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.usernameUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminUsersDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productNameHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAddHomePageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            addProductButton = new System.Windows.Forms.Button();
            addCustomerButton = new System.Windows.Forms.Button();
            addSupplierButton = new System.Windows.Forms.Button();
            addUserButton = new System.Windows.Forms.Button();
            this.leftsideMainPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.homePageMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePageDataGridView)).BeginInit();
            this.homePageHeaderPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statisticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsPagePanel)).BeginInit();
            this.statisticsPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.customersTab.SuspendLayout();
            this.customersPageMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTabDataGridView)).BeginInit();
            this.customersPageHeaderPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.suppliersTab.SuspendLayout();
            this.suppliersPageMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTabDataGridView)).BeginInit();
            this.suppliersPageHeaderPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.salesAndPurchasingTab.SuspendLayout();
            this.salesAndPurchasingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesAndPurchasingNavigator)).BeginInit();
            this.salesAndPurchasingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesNavigatorPage)).BeginInit();
            this.salesNavigatorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingNavigatorPage)).BeginInit();
            this.purchasingNavigatorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingDataGridView)).BeginInit();
            this.settingsTab.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageSettingsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUnitComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox.Panel)).BeginInit();
            this.currencySettingsGroupBox.Panel.SuspendLayout();
            this.currencySettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupSeparatorComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsDecimalSeparatorComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierStatisticsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsPage)).BeginInit();
            this.customerStatisticsPage.SuspendLayout();
            this.usersTab.SuspendLayout();
            this.usersPageHeaderPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.usersPageMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersPageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // leftsideMainPanel
            // 
            this.leftsideMainPanel.AutoScroll = true;
            this.leftsideMainPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.leftsideMainPanel.Controls.Add(this.nameTextLabel);
            this.leftsideMainPanel.Controls.Add(this.usernameTextLabel);
            this.leftsideMainPanel.Controls.Add(this.nameLabel);
            this.leftsideMainPanel.Controls.Add(this.usernameLabel);
            this.leftsideMainPanel.Controls.Add(this.shoppingCartLeftSidePanelButton);
            this.leftsideMainPanel.Controls.Add(this.logoutButton);
            this.leftsideMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftsideMainPanel.Location = new System.Drawing.Point(0, 0);
            this.leftsideMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftsideMainPanel.Name = "leftsideMainPanel";
            this.leftsideMainPanel.Size = new System.Drawing.Size(202, 548);
            this.leftsideMainPanel.TabIndex = 0;
            // 
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.nameTextLabel.Location = new System.Drawing.Point(88, 75);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(55, 13);
            this.nameTextLabel.TabIndex = 9;
            this.nameTextLabel.Text = "POSeidon";
            // 
            // usernameTextLabel
            // 
            this.usernameTextLabel.AutoSize = true;
            this.usernameTextLabel.Location = new System.Drawing.Point(88, 44);
            this.usernameTextLabel.Name = "usernameTextLabel";
            this.usernameTextLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameTextLabel.TabIndex = 8;
            this.usernameTextLabel.Text = "admin";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 44);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username:";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.mainTabControl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(202, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(978, 548);
            this.mainPanel.TabIndex = 1;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.homeTab);
            this.mainTabControl.Controls.Add(this.statisticsTab);
            this.mainTabControl.Controls.Add(this.customersTab);
            this.mainTabControl.Controls.Add(this.suppliersTab);
            this.mainTabControl.Controls.Add(this.salesAndPurchasingTab);
            this.mainTabControl.Controls.Add(this.usersTab);
            this.mainTabControl.Controls.Add(this.settingsTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainTabControl.ItemSize = new System.Drawing.Size(200, 50);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(30, 3);
            this.mainTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(978, 548);
            this.mainTabControl.TabIndex = 3;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.Transparent;
            this.homeTab.Controls.Add(this.homePageMainPanel);
            this.homeTab.Controls.Add(this.homePageHeaderPanel);
            this.homeTab.Location = new System.Drawing.Point(4, 54);
            this.homeTab.Margin = new System.Windows.Forms.Padding(2);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(970, 490);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            // 
            // homePageMainPanel
            // 
            this.homePageMainPanel.Controls.Add(this.homePageDataGridView);
            this.homePageMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePageMainPanel.Location = new System.Drawing.Point(0, 100);
            this.homePageMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePageMainPanel.Name = "homePageMainPanel";
            this.homePageMainPanel.Size = new System.Drawing.Size(970, 390);
            this.homePageMainPanel.TabIndex = 8;
            // 
            // homePageDataGridView
            // 
            this.homePageDataGridView.AllowUserToAddRows = false;
            this.homePageDataGridView.AllowUserToDeleteRows = false;
            this.homePageDataGridView.AllowUserToOrderColumns = true;
            this.homePageDataGridView.AllowUserToResizeColumns = false;
            this.homePageDataGridView.AllowUserToResizeRows = false;
            this.homePageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.homePageDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.homePageDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homePageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homePageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameHomePageDataGridViewTextBoxColumn,
            this.productPriceHomePageDataGridViewTextBoxColumn,
            this.productStockHomePageDataGridViewTextBoxColumn,
            this.productAddHomePageDataGridViewImageColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.homePageDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.homePageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePageDataGridView.Location = new System.Drawing.Point(0, 0);
            this.homePageDataGridView.MultiSelect = false;
            this.homePageDataGridView.Name = "homePageDataGridView";
            this.homePageDataGridView.ReadOnly = true;
            this.homePageDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.homePageDataGridView.RowTemplate.Height = 24;
            this.homePageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.homePageDataGridView.Size = new System.Drawing.Size(970, 390);
            this.homePageDataGridView.TabIndex = 7;
            this.homePageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomePageDataGridView_CellClick);
            this.homePageDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.HomePageDataGridView_CellFormatting);
            // 
            // homePageHeaderPanel
            // 
            this.homePageHeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homePageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.homePageHeaderPanel.Controls.Add(this.tableLayoutPanel1);
            this.homePageHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePageHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.homePageHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePageHeaderPanel.Name = "homePageHeaderPanel";
            this.homePageHeaderPanel.Size = new System.Drawing.Size(970, 100);
            this.homePageHeaderPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Controls.Add(addProductButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productSearchTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 100);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.productSearchTextBox.Location = new System.Drawing.Point(704, 38);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(231, 24);
            this.productSearchTextBox.TabIndex = 16;
            this.productSearchTextBox.TextChanged += new System.EventHandler(this.ProductSearchTextBox_TextChanged);
            // 
            // statisticsTab
            // 
            this.statisticsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.statisticsTab.Controls.Add(this.statisticsPagePanel);
            this.statisticsTab.Location = new System.Drawing.Point(4, 54);
            this.statisticsTab.Margin = new System.Windows.Forms.Padding(2);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Padding = new System.Windows.Forms.Padding(2);
            this.statisticsTab.Size = new System.Drawing.Size(970, 490);
            this.statisticsTab.TabIndex = 1;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.Enter += new System.EventHandler(this.StatisticsTab_Enter);
            // 
            // statisticsPagePanel
            // 
            this.statisticsPagePanel.Controls.Add(this.statisticsChart);
            this.statisticsPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsPagePanel.Location = new System.Drawing.Point(2, 2);
            this.statisticsPagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.statisticsPagePanel.Name = "statisticsPagePanel";
            this.statisticsPagePanel.Size = new System.Drawing.Size(966, 486);
            this.statisticsPagePanel.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            this.statisticsPagePanel.TabIndex = 7;
            // 
            // statisticsChart
            // 
            chartArea1.AxisY.Title = "Amount";
            chartArea1.Name = "ChartArea1";
            this.statisticsChart.ChartAreas.Add(chartArea1);
            this.statisticsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsChart.Location = new System.Drawing.Point(0, 0);
            this.statisticsChart.Name = "statisticsChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series1.XValueMember = "ProductName";
            series1.YValueMembers = "Amount";
            this.statisticsChart.Series.Add(series1);
            this.statisticsChart.Size = new System.Drawing.Size(966, 486);
            this.statisticsChart.TabIndex = 0;
            this.statisticsChart.Text = "chart1";
            // 
            // customersTab
            // 
            this.customersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.customersTab.Controls.Add(this.customersPageMainPanel);
            this.customersTab.Controls.Add(this.customersPageHeaderPanel);
            this.customersTab.Location = new System.Drawing.Point(4, 54);
            this.customersTab.Margin = new System.Windows.Forms.Padding(2);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(970, 490);
            this.customersTab.TabIndex = 2;
            this.customersTab.Text = "Customers";
            // 
            // customersPageMainPanel
            // 
            this.customersPageMainPanel.Controls.Add(this.customersTabDataGridView);
            this.customersPageMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersPageMainPanel.Location = new System.Drawing.Point(0, 100);
            this.customersPageMainPanel.Name = "customersPageMainPanel";
            this.customersPageMainPanel.Size = new System.Drawing.Size(970, 390);
            this.customersPageMainPanel.TabIndex = 14;
            // 
            // customersTabDataGridView
            // 
            this.customersTabDataGridView.AllowUserToAddRows = false;
            this.customersTabDataGridView.AllowUserToDeleteRows = false;
            this.customersTabDataGridView.AllowUserToResizeColumns = false;
            this.customersTabDataGridView.AllowUserToResizeRows = false;
            this.customersTabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customersTabDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customersTabDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.customersTabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersTabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.deleteCustomerDataGridViewImageColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersTabDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.customersTabDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTabDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customersTabDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.customersTabDataGridView.MultiSelect = false;
            this.customersTabDataGridView.Name = "customersTabDataGridView";
            this.customersTabDataGridView.RowTemplate.Height = 24;
            this.customersTabDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.customersTabDataGridView.Size = new System.Drawing.Size(970, 390);
            this.customersTabDataGridView.TabIndex = 10;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            this.customerFirstNameDataGridViewTextBoxColumn.Width = 108;
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            this.customerLastNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            this.customerPhoneDataGridViewTextBoxColumn.Width = 82;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            this.customerEmailDataGridViewTextBoxColumn.Width = 75;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.Width = 90;
            // 
            // customersPageHeaderPanel
            // 
            this.customersPageHeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customersPageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.customersPageHeaderPanel.Controls.Add(this.tableLayoutPanel2);
            this.customersPageHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.customersPageHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.customersPageHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.customersPageHeaderPanel.Name = "customersPageHeaderPanel";
            this.customersPageHeaderPanel.Size = new System.Drawing.Size(970, 100);
            this.customersPageHeaderPanel.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.customerSearchTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(addCustomerButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(970, 100);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // customerSearchTextBox
            // 
            this.customerSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customerSearchTextBox.Location = new System.Drawing.Point(704, 38);
            this.customerSearchTextBox.Name = "customerSearchTextBox";
            this.customerSearchTextBox.Size = new System.Drawing.Size(231, 24);
            this.customerSearchTextBox.TabIndex = 17;
            // 
            // suppliersTab
            // 
            this.suppliersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.suppliersTab.Controls.Add(this.suppliersPageMainPanel);
            this.suppliersTab.Controls.Add(this.suppliersPageHeaderPanel);
            this.suppliersTab.Location = new System.Drawing.Point(4, 54);
            this.suppliersTab.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersTab.Name = "suppliersTab";
            this.suppliersTab.Size = new System.Drawing.Size(970, 490);
            this.suppliersTab.TabIndex = 5;
            this.suppliersTab.Text = "Suppliers";
            // 
            // suppliersPageMainPanel
            // 
            this.suppliersPageMainPanel.Controls.Add(this.suppliersTabDataGridView);
            this.suppliersPageMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersPageMainPanel.Location = new System.Drawing.Point(0, 100);
            this.suppliersPageMainPanel.Name = "suppliersPageMainPanel";
            this.suppliersPageMainPanel.Size = new System.Drawing.Size(970, 390);
            this.suppliersPageMainPanel.TabIndex = 17;
            // 
            // suppliersTabDataGridView
            // 
            this.suppliersTabDataGridView.AllowUserToAddRows = false;
            this.suppliersTabDataGridView.AllowUserToDeleteRows = false;
            this.suppliersTabDataGridView.AllowUserToResizeColumns = false;
            this.suppliersTabDataGridView.AllowUserToResizeRows = false;
            this.suppliersTabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.suppliersTabDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.suppliersTabDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(210)))), ((int)(((byte)(232)))));
            this.suppliersTabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersTabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierNameDataGridViewTextBoxColumn,
            this.supplierPhoneDataGridViewTextBoxColumn,
            this.supplierEmailDataGridViewTextBoxColumn,
            this.supplierAddressDataGridViewTextBoxColumn,
            this.deleteSupplierDataGridViewImageColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suppliersTabDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.suppliersTabDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersTabDataGridView.Location = new System.Drawing.Point(0, 0);
            this.suppliersTabDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersTabDataGridView.MultiSelect = false;
            this.suppliersTabDataGridView.Name = "suppliersTabDataGridView";
            this.suppliersTabDataGridView.RowTemplate.Height = 24;
            this.suppliersTabDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.suppliersTabDataGridView.Size = new System.Drawing.Size(970, 390);
            this.suppliersTabDataGridView.TabIndex = 9;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // supplierPhoneDataGridViewTextBoxColumn
            // 
            this.supplierPhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.supplierPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.supplierPhoneDataGridViewTextBoxColumn.Name = "supplierPhoneDataGridViewTextBoxColumn";
            this.supplierPhoneDataGridViewTextBoxColumn.Width = 82;
            // 
            // supplierEmailDataGridViewTextBoxColumn
            // 
            this.supplierEmailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.supplierEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.supplierEmailDataGridViewTextBoxColumn.Name = "supplierEmailDataGridViewTextBoxColumn";
            this.supplierEmailDataGridViewTextBoxColumn.Width = 75;
            // 
            // supplierAddressDataGridViewTextBoxColumn
            // 
            this.supplierAddressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.supplierAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.supplierAddressDataGridViewTextBoxColumn.Name = "supplierAddressDataGridViewTextBoxColumn";
            this.supplierAddressDataGridViewTextBoxColumn.Width = 90;
            // 
            // suppliersPageHeaderPanel
            // 
            this.suppliersPageHeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.suppliersPageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.suppliersPageHeaderPanel.Controls.Add(this.tableLayoutPanel3);
            this.suppliersPageHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.suppliersPageHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.suppliersPageHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersPageHeaderPanel.Name = "suppliersPageHeaderPanel";
            this.suppliersPageHeaderPanel.Size = new System.Drawing.Size(970, 100);
            this.suppliersPageHeaderPanel.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.supplierSearchTextBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(addSupplierButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(970, 100);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // supplierSearchTextBox
            // 
            this.supplierSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.supplierSearchTextBox.Location = new System.Drawing.Point(704, 38);
            this.supplierSearchTextBox.Name = "supplierSearchTextBox";
            this.supplierSearchTextBox.Size = new System.Drawing.Size(231, 24);
            this.supplierSearchTextBox.TabIndex = 18;
            this.supplierSearchTextBox.TextChanged += new System.EventHandler(this.SuppliersSearchTextBox_TextChanged);
            // 
            // salesAndPurchasingTab
            // 
            this.salesAndPurchasingTab.BackColor = System.Drawing.Color.PeachPuff;
            this.salesAndPurchasingTab.Controls.Add(this.salesAndPurchasingPanel);
            this.salesAndPurchasingTab.Location = new System.Drawing.Point(4, 54);
            this.salesAndPurchasingTab.Margin = new System.Windows.Forms.Padding(2);
            this.salesAndPurchasingTab.Name = "salesAndPurchasingTab";
            this.salesAndPurchasingTab.Size = new System.Drawing.Size(970, 490);
            this.salesAndPurchasingTab.TabIndex = 3;
            this.salesAndPurchasingTab.Text = "Sales and Purchasing";
            // 
            // salesAndPurchasingPanel
            // 
            this.salesAndPurchasingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.salesAndPurchasingPanel.Controls.Add(this.salesAndPurchasingNavigator);
            this.salesAndPurchasingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesAndPurchasingPanel.Location = new System.Drawing.Point(0, 0);
            this.salesAndPurchasingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.salesAndPurchasingPanel.Name = "salesAndPurchasingPanel";
            this.salesAndPurchasingPanel.Size = new System.Drawing.Size(970, 490);
            this.salesAndPurchasingPanel.TabIndex = 0;
            // 
            // salesAndPurchasingNavigator
            // 
            this.salesAndPurchasingNavigator.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.salesAndPurchasingNavigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.salesAndPurchasingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesAndPurchasingNavigator.Location = new System.Drawing.Point(0, 0);
            this.salesAndPurchasingNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.salesAndPurchasingNavigator.Name = "salesAndPurchasingNavigator";
            this.salesAndPurchasingNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.salesAndPurchasingNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.salesNavigatorPage,
            this.purchasingNavigatorPage});
            this.salesAndPurchasingNavigator.SelectedIndex = 0;
            this.salesAndPurchasingNavigator.Size = new System.Drawing.Size(970, 490);
            this.salesAndPurchasingNavigator.TabIndex = 0;
            this.salesAndPurchasingNavigator.Text = "Sales and Purchasing";
            // 
            // salesNavigatorPage
            // 
            this.salesNavigatorPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.salesNavigatorPage.AutoScroll = true;
            this.salesNavigatorPage.Controls.Add(this.salesHistoryDataGridView);
            this.salesNavigatorPage.Flags = 65534;
            this.salesNavigatorPage.LastVisibleSet = true;
            this.salesNavigatorPage.Margin = new System.Windows.Forms.Padding(2);
            this.salesNavigatorPage.MinimumSize = new System.Drawing.Size(38, 41);
            this.salesNavigatorPage.Name = "salesNavigatorPage";
            this.salesNavigatorPage.Size = new System.Drawing.Size(968, 461);
            this.salesNavigatorPage.Text = "Sales";
            this.salesNavigatorPage.ToolTipTitle = "Page ToolTip";
            this.salesNavigatorPage.UniqueName = "6c08f90acd56447b9d6f9ea6bd5cfcc4";
            this.salesNavigatorPage.Enter += new System.EventHandler(this.SalesNavigatorPage_Enter);
            // 
            // salesHistoryDataGridView
            // 
            this.salesHistoryDataGridView.AllowUserToAddRows = false;
            this.salesHistoryDataGridView.AllowUserToDeleteRows = false;
            this.salesHistoryDataGridView.AllowUserToResizeColumns = false;
            this.salesHistoryDataGridView.AllowUserToResizeRows = false;
            this.salesHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.salesHistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.salesHistoryDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.salesHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameSalesHistoryDataGridViewTextBoxColumn,
            this.productPriceSalesHistoryDataGridViewTextBoxColumn,
            this.productAmountSalesHistoryDataGridViewTextBoxColumn,
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn,
            this.customerNameSalesHistoryDataGridViewTextBoxColumn,
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn,
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn,
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn,
            this.dateSalesHistoryDataGridViewTextBoxColumn});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.salesHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesHistoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.salesHistoryDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.salesHistoryDataGridView.MultiSelect = false;
            this.salesHistoryDataGridView.Name = "salesHistoryDataGridView";
            this.salesHistoryDataGridView.RowTemplate.Height = 24;
            this.salesHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.salesHistoryDataGridView.Size = new System.Drawing.Size(968, 461);
            this.salesHistoryDataGridView.TabIndex = 9;
            this.salesHistoryDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.SalesHistoryDataGridView_CellFormatting);
            // 
            // productNameSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productNameSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productNameSalesHistoryDataGridViewTextBoxColumn.Name = "productNameSalesHistoryDataGridViewTextBoxColumn";
            this.productNameSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameSalesHistoryDataGridViewTextBoxColumn.Width = 92;
            // 
            // productPriceSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.Name = "productPriceSalesHistoryDataGridViewTextBoxColumn";
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.Width = 71;
            // 
            // productAmountSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.Name = "productAmountSalesHistoryDataGridViewTextBoxColumn";
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.Width = 92;
            // 
            // productTotalPriceSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductTotalPrice";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Total";
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.Name = "productTotalPriceSalesHistoryDataGridViewTextBoxColumn";
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.Width = 70;
            // 
            // customerNameSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.Name = "customerNameSalesHistoryDataGridViewTextBoxColumn";
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.Width = 103;
            // 
            // customerPhoneSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.Name = "customerPhoneSalesHistoryDataGridViewTextBoxColumn";
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.Width = 82;
            // 
            // customerEmailSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail";
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Email";
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.Name = "customerEmailSalesHistoryDataGridViewTextBoxColumn";
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.Width = 75;
            // 
            // customerAddressSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Address";
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.Name = "customerAddressSalesHistoryDataGridViewTextBoxColumn";
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.Width = 90;
            // 
            // dateSalesHistoryDataGridViewTextBoxColumn
            // 
            this.dateSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateSalesHistoryDataGridViewTextBoxColumn.Name = "dateSalesHistoryDataGridViewTextBoxColumn";
            this.dateSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateSalesHistoryDataGridViewTextBoxColumn.Width = 72;
            // 
            // purchasingNavigatorPage
            // 
            this.purchasingNavigatorPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.purchasingNavigatorPage.AutoScroll = true;
            this.purchasingNavigatorPage.Controls.Add(this.purchasingDataGridView);
            this.purchasingNavigatorPage.Flags = 65534;
            this.purchasingNavigatorPage.LastVisibleSet = true;
            this.purchasingNavigatorPage.Margin = new System.Windows.Forms.Padding(2);
            this.purchasingNavigatorPage.MinimumSize = new System.Drawing.Size(38, 41);
            this.purchasingNavigatorPage.Name = "purchasingNavigatorPage";
            this.purchasingNavigatorPage.Size = new System.Drawing.Size(968, 461);
            this.purchasingNavigatorPage.Text = "Purchasing";
            this.purchasingNavigatorPage.ToolTipTitle = "Page ToolTip";
            this.purchasingNavigatorPage.UniqueName = "3753607d328a4c3a9448a9b19123061d";
            // 
            // purchasingDataGridView
            // 
            this.purchasingDataGridView.AllowUserToAddRows = false;
            this.purchasingDataGridView.AllowUserToDeleteRows = false;
            this.purchasingDataGridView.AllowUserToResizeColumns = false;
            this.purchasingDataGridView.AllowUserToResizeRows = false;
            this.purchasingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.purchasingDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.purchasingDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.purchasingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productPurchasingDataGridViewTextBoxColumn,
            this.amountPurchasingDataGridViewTextBoxColumn,
            this.supplierPurchasingDataGridViewTextBoxColumn,
            this.phonePurchasingDataGridViewTextBoxColumn,
            this.emailPurchasingDataGridViewTextBoxColumn,
            this.addressPurchasingDataGridViewTextBoxColumn,
            this.totalPurchasingDataGridViewTextBoxColumn,
            this.datePurchasingDataGridViewTextBoxColumn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchasingDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.purchasingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchasingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.purchasingDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.purchasingDataGridView.MultiSelect = false;
            this.purchasingDataGridView.Name = "purchasingDataGridView";
            this.purchasingDataGridView.RowTemplate.Height = 24;
            this.purchasingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.purchasingDataGridView.Size = new System.Drawing.Size(968, 461);
            this.purchasingDataGridView.TabIndex = 9;
            this.purchasingDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PurchasingDataGridView_CellFormatting);
            // 
            // productPurchasingDataGridViewTextBoxColumn
            // 
            this.productPurchasingDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productPurchasingDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productPurchasingDataGridViewTextBoxColumn.Name = "productPurchasingDataGridViewTextBoxColumn";
            this.productPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.productPurchasingDataGridViewTextBoxColumn.Width = 92;
            // 
            // amountPurchasingDataGridViewTextBoxColumn
            // 
            this.amountPurchasingDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            this.amountPurchasingDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountPurchasingDataGridViewTextBoxColumn.Name = "amountPurchasingDataGridViewTextBoxColumn";
            this.amountPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountPurchasingDataGridViewTextBoxColumn.Width = 92;
            // 
            // supplierPurchasingDataGridViewTextBoxColumn
            // 
            this.supplierPurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierPurchasingDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierPurchasingDataGridViewTextBoxColumn.Name = "supplierPurchasingDataGridViewTextBoxColumn";
            this.supplierPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierPurchasingDataGridViewTextBoxColumn.Width = 93;
            // 
            // phonePurchasingDataGridViewTextBoxColumn
            // 
            this.phonePurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierPhone";
            this.phonePurchasingDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phonePurchasingDataGridViewTextBoxColumn.Name = "phonePurchasingDataGridViewTextBoxColumn";
            this.phonePurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonePurchasingDataGridViewTextBoxColumn.Width = 82;
            // 
            // emailPurchasingDataGridViewTextBoxColumn
            // 
            this.emailPurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierEmail";
            this.emailPurchasingDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailPurchasingDataGridViewTextBoxColumn.Name = "emailPurchasingDataGridViewTextBoxColumn";
            this.emailPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailPurchasingDataGridViewTextBoxColumn.Width = 75;
            // 
            // addressPurchasingDataGridViewTextBoxColumn
            // 
            this.addressPurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierAddress";
            this.addressPurchasingDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressPurchasingDataGridViewTextBoxColumn.Name = "addressPurchasingDataGridViewTextBoxColumn";
            this.addressPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressPurchasingDataGridViewTextBoxColumn.Width = 90;
            // 
            // totalPurchasingDataGridViewTextBoxColumn
            // 
            this.totalPurchasingDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.totalPurchasingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.totalPurchasingDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalPurchasingDataGridViewTextBoxColumn.Name = "totalPurchasingDataGridViewTextBoxColumn";
            this.totalPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPurchasingDataGridViewTextBoxColumn.Width = 70;
            // 
            // datePurchasingDataGridViewTextBoxColumn
            // 
            this.datePurchasingDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.datePurchasingDataGridViewTextBoxColumn.HeaderText = "Date";
            this.datePurchasingDataGridViewTextBoxColumn.Name = "datePurchasingDataGridViewTextBoxColumn";
            this.datePurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.datePurchasingDataGridViewTextBoxColumn.Width = 72;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.settingsTab.Controls.Add(this.settingsPanel);
            this.settingsTab.Location = new System.Drawing.Point(4, 54);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(970, 490);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Settings";
            this.settingsTab.Enter += new System.EventHandler(this.SettingsTab_Enter);
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.Controls.Add(this.tableLayoutPanel4);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(970, 490);
            this.settingsPanel.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.currencySettingsGroupBox, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.16327F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.83673F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(970, 490);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.languageSettingsLabel);
            this.panel1.Controls.Add(this.languageSettingsComboBox);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.weightUnitSettingsLabel);
            this.panel1.Controls.Add(this.weightUnitComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 199);
            this.panel1.TabIndex = 17;
            // 
            // languageSettingsLabel
            // 
            this.languageSettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.languageSettingsLabel.Location = new System.Drawing.Point(324, 64);
            this.languageSettingsLabel.Name = "languageSettingsLabel";
            this.languageSettingsLabel.Size = new System.Drawing.Size(67, 20);
            this.languageSettingsLabel.TabIndex = 19;
            this.languageSettingsLabel.Values.Text = "Language:";
            // 
            // languageSettingsComboBox
            // 
            this.languageSettingsComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.languageSettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageSettingsComboBox.DropDownWidth = 121;
            this.languageSettingsComboBox.Location = new System.Drawing.Point(435, 63);
            this.languageSettingsComboBox.Name = "languageSettingsComboBox";
            this.languageSettingsComboBox.Size = new System.Drawing.Size(121, 21);
            this.languageSettingsComboBox.TabIndex = 20;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(553, 108);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 57);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // weightUnitSettingsLabel
            // 
            this.weightUnitSettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weightUnitSettingsLabel.Location = new System.Drawing.Point(324, 17);
            this.weightUnitSettingsLabel.Name = "weightUnitSettingsLabel";
            this.weightUnitSettingsLabel.Size = new System.Drawing.Size(79, 20);
            this.weightUnitSettingsLabel.TabIndex = 17;
            this.weightUnitSettingsLabel.Values.Text = "Weight Unit:";
            // 
            // weightUnitComboBox
            // 
            this.weightUnitComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightUnitComboBox.DropDownWidth = 121;
            this.weightUnitComboBox.Location = new System.Drawing.Point(435, 16);
            this.weightUnitComboBox.Name = "weightUnitComboBox";
            this.weightUnitComboBox.Size = new System.Drawing.Size(121, 21);
            this.weightUnitComboBox.TabIndex = 18;
            // 
            // currencySettingsGroupBox
            // 
            this.currencySettingsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currencySettingsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.currencySettingsGroupBox.CaptionOverlap = 0D;
            this.currencySettingsGroupBox.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.currencySettingsGroupBox.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate;
            this.currencySettingsGroupBox.Location = new System.Drawing.Point(310, 3);
            this.currencySettingsGroupBox.MinimumSize = new System.Drawing.Size(350, 250);
            this.currencySettingsGroupBox.Name = "currencySettingsGroupBox";
            // 
            // currencySettingsGroupBox.Panel
            // 
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsGroupSeparatorComboBox);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsDecimalSeparatorComboBox);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsGroupSeparatorLabel);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsDecimalSeparatorLabel);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsPutSpaceCheckBox);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsSymbolPlacementRightRadioButton);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsSymbolPlacementLeftRadioButton);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsLabel);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsSymbolPlacementLabel);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsComboBox);
            this.currencySettingsGroupBox.Size = new System.Drawing.Size(350, 250);
            this.currencySettingsGroupBox.TabIndex = 16;
            this.currencySettingsGroupBox.Values.Heading = "Currency Settings";
            // 
            // currencySettingsGroupSeparatorComboBox
            // 
            this.currencySettingsGroupSeparatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencySettingsGroupSeparatorComboBox.DropDownWidth = 121;
            this.currencySettingsGroupSeparatorComboBox.Items.AddRange(new object[] {
            ".",
            ","});
            this.currencySettingsGroupSeparatorComboBox.Location = new System.Drawing.Point(131, 164);
            this.currencySettingsGroupSeparatorComboBox.Name = "currencySettingsGroupSeparatorComboBox";
            this.currencySettingsGroupSeparatorComboBox.Size = new System.Drawing.Size(121, 21);
            this.currencySettingsGroupSeparatorComboBox.TabIndex = 21;
            // 
            // currencySettingsDecimalSeparatorComboBox
            // 
            this.currencySettingsDecimalSeparatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencySettingsDecimalSeparatorComboBox.DropDownWidth = 121;
            this.currencySettingsDecimalSeparatorComboBox.Items.AddRange(new object[] {
            ".",
            ","});
            this.currencySettingsDecimalSeparatorComboBox.Location = new System.Drawing.Point(131, 124);
            this.currencySettingsDecimalSeparatorComboBox.Name = "currencySettingsDecimalSeparatorComboBox";
            this.currencySettingsDecimalSeparatorComboBox.Size = new System.Drawing.Size(121, 21);
            this.currencySettingsDecimalSeparatorComboBox.TabIndex = 20;
            // 
            // currencySettingsGroupSeparatorLabel
            // 
            this.currencySettingsGroupSeparatorLabel.Location = new System.Drawing.Point(19, 166);
            this.currencySettingsGroupSeparatorLabel.Name = "currencySettingsGroupSeparatorLabel";
            this.currencySettingsGroupSeparatorLabel.Size = new System.Drawing.Size(104, 20);
            this.currencySettingsGroupSeparatorLabel.TabIndex = 19;
            this.currencySettingsGroupSeparatorLabel.Values.Text = "Group Separator:";
            // 
            // currencySettingsDecimalSeparatorLabel
            // 
            this.currencySettingsDecimalSeparatorLabel.Location = new System.Drawing.Point(19, 126);
            this.currencySettingsDecimalSeparatorLabel.Name = "currencySettingsDecimalSeparatorLabel";
            this.currencySettingsDecimalSeparatorLabel.Size = new System.Drawing.Size(113, 20);
            this.currencySettingsDecimalSeparatorLabel.TabIndex = 18;
            this.currencySettingsDecimalSeparatorLabel.Values.Text = "Decimal Separator:";
            // 
            // currencySettingsPutSpaceCheckBox
            // 
            this.currencySettingsPutSpaceCheckBox.Location = new System.Drawing.Point(19, 96);
            this.currencySettingsPutSpaceCheckBox.Name = "currencySettingsPutSpaceCheckBox";
            this.currencySettingsPutSpaceCheckBox.Size = new System.Drawing.Size(290, 20);
            this.currencySettingsPutSpaceCheckBox.TabIndex = 17;
            this.currencySettingsPutSpaceCheckBox.Values.Text = "Put a space between the amount and the symbol";
            // 
            // currencySettingsSymbolPlacementRightRadioButton
            // 
            this.currencySettingsSymbolPlacementRightRadioButton.Location = new System.Drawing.Point(193, 57);
            this.currencySettingsSymbolPlacementRightRadioButton.Name = "currencySettingsSymbolPlacementRightRadioButton";
            this.currencySettingsSymbolPlacementRightRadioButton.Size = new System.Drawing.Size(51, 20);
            this.currencySettingsSymbolPlacementRightRadioButton.TabIndex = 16;
            this.currencySettingsSymbolPlacementRightRadioButton.Values.Text = "Right";
            // 
            // currencySettingsSymbolPlacementLeftRadioButton
            // 
            this.currencySettingsSymbolPlacementLeftRadioButton.Checked = true;
            this.currencySettingsSymbolPlacementLeftRadioButton.Location = new System.Drawing.Point(131, 58);
            this.currencySettingsSymbolPlacementLeftRadioButton.Name = "currencySettingsSymbolPlacementLeftRadioButton";
            this.currencySettingsSymbolPlacementLeftRadioButton.Size = new System.Drawing.Size(43, 20);
            this.currencySettingsSymbolPlacementLeftRadioButton.TabIndex = 15;
            this.currencySettingsSymbolPlacementLeftRadioButton.Values.Text = "Left";
            // 
            // currencySettingsLabel
            // 
            this.currencySettingsLabel.Location = new System.Drawing.Point(19, 15);
            this.currencySettingsLabel.Name = "currencySettingsLabel";
            this.currencySettingsLabel.Size = new System.Drawing.Size(62, 20);
            this.currencySettingsLabel.TabIndex = 13;
            this.currencySettingsLabel.Values.Text = "Currency:";
            // 
            // currencySettingsSymbolPlacementLabel
            // 
            this.currencySettingsSymbolPlacementLabel.Location = new System.Drawing.Point(19, 58);
            this.currencySettingsSymbolPlacementLabel.Name = "currencySettingsSymbolPlacementLabel";
            this.currencySettingsSymbolPlacementLabel.Size = new System.Drawing.Size(114, 20);
            this.currencySettingsSymbolPlacementLabel.TabIndex = 14;
            this.currencySettingsSymbolPlacementLabel.Values.Text = "Symbol Placement:";
            // 
            // currencySettingsComboBox
            // 
            this.currencySettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencySettingsComboBox.DropDownWidth = 178;
            this.currencySettingsComboBox.Location = new System.Drawing.Point(131, 15);
            this.currencySettingsComboBox.Name = "currencySettingsComboBox";
            this.currencySettingsComboBox.Size = new System.Drawing.Size(178, 21);
            this.currencySettingsComboBox.TabIndex = 12;
            // 
            // supplierStatisticsChart
            // 
            this.supplierStatisticsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea8";
            this.supplierStatisticsChart.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend8";
            this.supplierStatisticsChart.Legends.Add(legend1);
            this.supplierStatisticsChart.Location = new System.Drawing.Point(20, 19);
            this.supplierStatisticsChart.Margin = new System.Windows.Forms.Padding(2);
            this.supplierStatisticsChart.Name = "supplierStatisticsChart";
            this.supplierStatisticsChart.Padding = new System.Windows.Forms.Padding(8);
            this.supplierStatisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea8";
            series2.Legend = "Legend8";
            series2.Name = "Series8";
            this.supplierStatisticsChart.Series.Add(series2);
            this.supplierStatisticsChart.Size = new System.Drawing.Size(570, 494);
            this.supplierStatisticsChart.TabIndex = 0;
            // 
            // customerStatisticsPanel
            // 
            this.customerStatisticsPanel.Location = new System.Drawing.Point(67, 32);
            this.customerStatisticsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.customerStatisticsPanel.Name = "customerStatisticsPanel";
            this.customerStatisticsPanel.Size = new System.Drawing.Size(610, 529);
            this.customerStatisticsPanel.TabIndex = 7;
            // 
            // customerStatisticsChart
            // 
            this.customerStatisticsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea7";
            this.customerStatisticsChart.ChartAreas.Add(chartArea3);
            this.customerStatisticsChart.Location = new System.Drawing.Point(20, 19);
            this.customerStatisticsChart.Margin = new System.Windows.Forms.Padding(2);
            this.customerStatisticsChart.Name = "customerStatisticsChart";
            this.customerStatisticsChart.Padding = new System.Windows.Forms.Padding(8);
            this.customerStatisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea7";
            series3.Name = "test";
            series3.XValueMember = "ProductName";
            series3.YValueMembers = "Amount";
            this.customerStatisticsChart.Series.Add(series3);
            this.customerStatisticsChart.Size = new System.Drawing.Size(569, 400);
            this.customerStatisticsChart.TabIndex = 0;
            // 
            // customerStatisticsPage
            // 
            this.customerStatisticsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.customerStatisticsPage.Controls.Add(this.customerStatisticsPanel);
            this.customerStatisticsPage.Flags = 65534;
            this.customerStatisticsPage.LastVisibleSet = true;
            this.customerStatisticsPage.Margin = new System.Windows.Forms.Padding(2);
            this.customerStatisticsPage.MinimumSize = new System.Drawing.Size(38, 41);
            this.customerStatisticsPage.Name = "customerStatisticsPage";
            this.customerStatisticsPage.Size = new System.Drawing.Size(748, 563);
            this.customerStatisticsPage.Text = "Customer";
            this.customerStatisticsPage.ToolTipTitle = "Page ToolTip";
            this.customerStatisticsPage.UniqueName = "1fbf379b70634940bcf9c585c1b0ac13";
            // 
            // usersTab
            // 
            this.usersTab.Controls.Add(this.usersPageMainPanel);
            this.usersTab.Controls.Add(this.usersPageHeaderPanel);
            this.usersTab.Location = new System.Drawing.Point(4, 54);
            this.usersTab.Name = "usersTab";
            this.usersTab.Padding = new System.Windows.Forms.Padding(3);
            this.usersTab.Size = new System.Drawing.Size(970, 490);
            this.usersTab.TabIndex = 6;
            this.usersTab.Text = "Users";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // usersPageHeaderPanel
            // 
            this.usersPageHeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usersPageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.usersPageHeaderPanel.Controls.Add(this.tableLayoutPanel5);
            this.usersPageHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersPageHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.usersPageHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.usersPageHeaderPanel.Name = "usersPageHeaderPanel";
            this.usersPageHeaderPanel.Size = new System.Drawing.Size(964, 100);
            this.usersPageHeaderPanel.TabIndex = 14;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.usersSearchTextBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(addUserButton, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(964, 100);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // usersSearchTextBox
            // 
            this.usersSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usersSearchTextBox.Location = new System.Drawing.Point(698, 38);
            this.usersSearchTextBox.Name = "usersSearchTextBox";
            this.usersSearchTextBox.Size = new System.Drawing.Size(231, 24);
            this.usersSearchTextBox.TabIndex = 17;
            // 
            // usersPageMainPanel
            // 
            this.usersPageMainPanel.Controls.Add(this.usersPageDataGridView);
            this.usersPageMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersPageMainPanel.Location = new System.Drawing.Point(3, 103);
            this.usersPageMainPanel.Name = "usersPageMainPanel";
            this.usersPageMainPanel.Size = new System.Drawing.Size(964, 384);
            this.usersPageMainPanel.TabIndex = 15;
            // 
            // usersPageDataGridView
            // 
            this.usersPageDataGridView.AllowUserToAddRows = false;
            this.usersPageDataGridView.AllowUserToDeleteRows = false;
            this.usersPageDataGridView.AllowUserToResizeColumns = false;
            this.usersPageDataGridView.AllowUserToResizeRows = false;
            this.usersPageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersPageDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.usersPageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersPageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameUsersDataGridViewTextBoxColumn,
            this.firstNameUsersDataGridViewTextBoxColumn,
            this.lastNameUsersDataGridViewTextBoxColumn,
            this.isAdminUsersDataGridViewCheckBoxColumn,
            this.deleteUsersDataGridViewTextBoxColumn});
            this.usersPageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersPageDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.usersPageDataGridView.Location = new System.Drawing.Point(0, 0);
            this.usersPageDataGridView.MultiSelect = false;
            this.usersPageDataGridView.Name = "usersPageDataGridView";
            this.usersPageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.usersPageDataGridView.Size = new System.Drawing.Size(964, 384);
            this.usersPageDataGridView.TabIndex = 0;
            this.usersPageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersPageDataGridView_CellClick);
            this.usersPageDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersPageDataGridView_CellValueChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Add";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 246;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::POSeidon.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 201;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Delete";
            this.dataGridViewImageColumn3.Image = global::POSeidon.Properties.Resources.delete;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 48;
            // 
            // addProductButton
            // 
            addProductButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            addProductButton.BackColor = System.Drawing.Color.White;
            addProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addProductButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            addProductButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addProductButton.Location = new System.Drawing.Point(3, 8);
            addProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addProductButton.Name = "addProductButton";
            addProductButton.Padding = new System.Windows.Forms.Padding(5);
            addProductButton.Size = new System.Drawing.Size(183, 84);
            addProductButton.TabIndex = 1;
            addProductButton.Text = "ADD PRODUCT";
            addProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            addProductButton.UseVisualStyleBackColor = false;
            addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(941, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // deleteCustomerDataGridViewImageColumn
            // 
            this.deleteCustomerDataGridViewImageColumn.HeaderText = "Delete";
            this.deleteCustomerDataGridViewImageColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.deleteCustomerDataGridViewImageColumn.Name = "deleteCustomerDataGridViewImageColumn";
            this.deleteCustomerDataGridViewImageColumn.Width = 64;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(941, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            addCustomerButton.BackColor = System.Drawing.Color.White;
            addCustomerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addCustomerButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            addCustomerButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addCustomerButton.Location = new System.Drawing.Point(3, 8);
            addCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Padding = new System.Windows.Forms.Padding(5);
            addCustomerButton.Size = new System.Drawing.Size(197, 84);
            addCustomerButton.TabIndex = 1;
            addCustomerButton.Text = "ADD CUSTOMER";
            addCustomerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            addCustomerButton.UseVisualStyleBackColor = false;
            addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // deleteSupplierDataGridViewImageColumn
            // 
            this.deleteSupplierDataGridViewImageColumn.HeaderText = "Delete";
            this.deleteSupplierDataGridViewImageColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.deleteSupplierDataGridViewImageColumn.Name = "deleteSupplierDataGridViewImageColumn";
            this.deleteSupplierDataGridViewImageColumn.Width = 64;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(941, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // addSupplierButton
            // 
            addSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            addSupplierButton.BackColor = System.Drawing.Color.White;
            addSupplierButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addSupplierButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            addSupplierButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addSupplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addSupplierButton.Location = new System.Drawing.Point(3, 8);
            addSupplierButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addSupplierButton.Name = "addSupplierButton";
            addSupplierButton.Padding = new System.Windows.Forms.Padding(5);
            addSupplierButton.Size = new System.Drawing.Size(179, 84);
            addSupplierButton.TabIndex = 1;
            addSupplierButton.Text = "ADD SUPPLIER";
            addSupplierButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            addSupplierButton.UseVisualStyleBackColor = false;
            addSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox4.Location = new System.Drawing.Point(935, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // addUserButton
            // 
            addUserButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            addUserButton.BackColor = System.Drawing.Color.White;
            addUserButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addUserButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            addUserButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addUserButton.Location = new System.Drawing.Point(3, 8);
            addUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addUserButton.Name = "addUserButton";
            addUserButton.Padding = new System.Windows.Forms.Padding(5);
            addUserButton.Size = new System.Drawing.Size(146, 84);
            addUserButton.TabIndex = 1;
            addUserButton.Text = "ADD USER";
            addUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // shoppingCartLeftSidePanelButton
            // 
            this.shoppingCartLeftSidePanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shoppingCartLeftSidePanelButton.AutoSize = true;
            this.shoppingCartLeftSidePanelButton.BackColor = System.Drawing.Color.Transparent;
            this.shoppingCartLeftSidePanelButton.BackgroundImage = global::POSeidon.Properties.Resources.order;
            this.shoppingCartLeftSidePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shoppingCartLeftSidePanelButton.Location = new System.Drawing.Point(12, 448);
            this.shoppingCartLeftSidePanelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shoppingCartLeftSidePanelButton.Name = "shoppingCartLeftSidePanelButton";
            this.shoppingCartLeftSidePanelButton.Size = new System.Drawing.Size(49, 43);
            this.shoppingCartLeftSidePanelButton.TabIndex = 5;
            this.shoppingCartLeftSidePanelButton.UseVisualStyleBackColor = false;
            this.shoppingCartLeftSidePanelButton.Click += new System.EventHandler(this.ShoppingCartLeftSidePanelButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.BackgroundImage = global::POSeidon.Properties.Resources.rsz_1logout_50x60;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutButton.Location = new System.Drawing.Point(154, 449);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(43, 40);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // cancelLogSalesHistoryDataGridViewImageBoxColumn
            // 
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.HeaderText = "Cancel";
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.Name = "cancelLogSalesHistoryDataGridViewImageBoxColumn";
            // 
            // usernameUsersDataGridViewTextBoxColumn
            // 
            this.usernameUsersDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameUsersDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameUsersDataGridViewTextBoxColumn.Name = "usernameUsersDataGridViewTextBoxColumn";
            this.usernameUsersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameUsersDataGridViewTextBoxColumn
            // 
            this.firstNameUsersDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameUsersDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameUsersDataGridViewTextBoxColumn.Name = "firstNameUsersDataGridViewTextBoxColumn";
            // 
            // lastNameUsersDataGridViewTextBoxColumn
            // 
            this.lastNameUsersDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameUsersDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameUsersDataGridViewTextBoxColumn.Name = "lastNameUsersDataGridViewTextBoxColumn";
            // 
            // isAdminUsersDataGridViewCheckBoxColumn
            // 
            this.isAdminUsersDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            this.isAdminUsersDataGridViewCheckBoxColumn.HeaderText = "Admin";
            this.isAdminUsersDataGridViewCheckBoxColumn.Name = "isAdminUsersDataGridViewCheckBoxColumn";
            // 
            // deleteUsersDataGridViewTextBoxColumn
            // 
            this.deleteUsersDataGridViewTextBoxColumn.HeaderText = "Delete";
            this.deleteUsersDataGridViewTextBoxColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.deleteUsersDataGridViewTextBoxColumn.Name = "deleteUsersDataGridViewTextBoxColumn";
            this.deleteUsersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameHomePageDataGridViewTextBoxColumn
            // 
            this.productNameHomePageDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.productNameHomePageDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNameHomePageDataGridViewTextBoxColumn.Name = "productNameHomePageDataGridViewTextBoxColumn";
            this.productNameHomePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceHomePageDataGridViewTextBoxColumn
            // 
            this.productPriceHomePageDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.productPriceHomePageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.productPriceHomePageDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPriceHomePageDataGridViewTextBoxColumn.Name = "productPriceHomePageDataGridViewTextBoxColumn";
            this.productPriceHomePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productStockHomePageDataGridViewTextBoxColumn
            // 
            this.productStockHomePageDataGridViewTextBoxColumn.DataPropertyName = "StockAmountText";
            this.productStockHomePageDataGridViewTextBoxColumn.HeaderText = "Stock Amount";
            this.productStockHomePageDataGridViewTextBoxColumn.Name = "productStockHomePageDataGridViewTextBoxColumn";
            this.productStockHomePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productAddHomePageDataGridViewImageColumn
            // 
            this.productAddHomePageDataGridViewImageColumn.HeaderText = "Add";
            this.productAddHomePageDataGridViewImageColumn.Image = ((System.Drawing.Image)(resources.GetObject("productAddHomePageDataGridViewImageColumn.Image")));
            this.productAddHomePageDataGridViewImageColumn.Name = "productAddHomePageDataGridViewImageColumn";
            this.productAddHomePageDataGridViewImageColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1180, 548);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftsideMainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSeidon";
            this.leftsideMainPanel.ResumeLayout(false);
            this.leftsideMainPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homePageMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homePageDataGridView)).EndInit();
            this.homePageHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statisticsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsPagePanel)).EndInit();
            this.statisticsPagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.customersTab.ResumeLayout(false);
            this.customersPageMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersTabDataGridView)).EndInit();
            this.customersPageHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.suppliersTab.ResumeLayout(false);
            this.suppliersPageMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTabDataGridView)).EndInit();
            this.suppliersPageHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.salesAndPurchasingTab.ResumeLayout(false);
            this.salesAndPurchasingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesAndPurchasingNavigator)).EndInit();
            this.salesAndPurchasingNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesNavigatorPage)).EndInit();
            this.salesNavigatorPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingNavigatorPage)).EndInit();
            this.purchasingNavigatorPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchasingDataGridView)).EndInit();
            this.settingsTab.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageSettingsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUnitComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox.Panel)).EndInit();
            this.currencySettingsGroupBox.Panel.ResumeLayout(false);
            this.currencySettingsGroupBox.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox)).EndInit();
            this.currencySettingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupSeparatorComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsDecimalSeparatorComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierStatisticsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsPage)).EndInit();
            this.customerStatisticsPage.ResumeLayout(false);
            this.usersTab.ResumeLayout(false);
            this.usersPageHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.usersPageMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersPageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftsideMainPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button shoppingCartLeftSidePanelButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.Panel homePageMainPanel;
        private System.Windows.Forms.DataGridView homePageDataGridView;
        private System.Windows.Forms.TabPage statisticsTab;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel statisticsPagePanel;
        private System.Windows.Forms.Panel customerStatisticsPanel;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.DataGridView customersTabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteCustomerDataGridViewImageColumn;
        private System.Windows.Forms.TabPage suppliersTab;
        private System.Windows.Forms.DataGridView suppliersTabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteSupplierDataGridViewImageColumn;
        private System.Windows.Forms.TabPage salesAndPurchasingTab;
        private System.Windows.Forms.Panel salesAndPurchasingPanel;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator salesAndPurchasingNavigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage salesNavigatorPage;
        private System.Windows.Forms.DataGridView salesHistoryDataGridView;
        private ComponentFactory.Krypton.Navigator.KryptonPage purchasingNavigatorPage;
        private System.Windows.Forms.DataGridView purchasingDataGridView;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Panel settingsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox weightUnitComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel weightUnitSettingsLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox currencySettingsGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox currencySettingsGroupSeparatorComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox currencySettingsDecimalSeparatorComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsGroupSeparatorLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsDecimalSeparatorLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox currencySettingsPutSpaceCheckBox;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton currencySettingsSymbolPlacementRightRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton currencySettingsSymbolPlacementLeftRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsSymbolPlacementLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox currencySettingsComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewImageColumn cancelLogPurchasingDataGridViewImageBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNamePurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn cancelLogSalesHistoryDataGridViewImageBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart supplierStatisticsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart customerStatisticsChart;
        private ComponentFactory.Krypton.Navigator.KryptonPage customerStatisticsPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
        private System.Windows.Forms.Panel homePageHeaderPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel customersPageHeaderPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel suppliersPageHeaderPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.TextBox customerSearchTextBox;
        private System.Windows.Forms.Panel customersPageMainPanel;
        private System.Windows.Forms.Panel suppliersPageMainPanel;
        private System.Windows.Forms.TextBox supplierSearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTotalPriceSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonePurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel languageSettingsLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox languageSettingsComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.Label usernameTextLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage usersTab;
        private System.Windows.Forms.Panel usersPageMainPanel;
        private System.Windows.Forms.DataGridView usersPageDataGridView;
        private System.Windows.Forms.Panel usersPageHeaderPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox usersSearchTextBox;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameUsersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameUsersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameUsersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAdminUsersDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteUsersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameHomePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceHomePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockHomePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productAddHomePageDataGridViewImageColumn;
    }
}
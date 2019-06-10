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
            System.Windows.Forms.Button addProductButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Button addCustomerButton;
            System.Windows.Forms.Button addSupplierButton;
            System.Windows.Forms.Button addUserButton;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.leftsideMainPanel = new System.Windows.Forms.Panel();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.usernameTextLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.shoppingCartLeftSidePanelButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.homePageMainPanel = new System.Windows.Forms.Panel();
            this.homePageDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAddHomePageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.homePageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.deleteCustomerDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.customersPageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customerSearchTextBox = new System.Windows.Forms.TextBox();
            this.suppliersTab = new System.Windows.Forms.TabPage();
            this.suppliersPageMainPanel = new System.Windows.Forms.Panel();
            this.suppliersTabDataGridView = new System.Windows.Forms.DataGridView();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteSupplierDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.suppliersPageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
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
            this.usersTab = new System.Windows.Forms.TabPage();
            this.usersPageMainPanel = new System.Windows.Forms.Panel();
            this.usersPageDataGridView = new System.Windows.Forms.DataGridView();
            this.usernameUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminUsersDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.usersPageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.usersSearchTextBox = new System.Windows.Forms.TextBox();
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statisticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsPagePanel)).BeginInit();
            this.statisticsPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.customersTab.SuspendLayout();
            this.customersPageMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTabDataGridView)).BeginInit();
            this.customersPageHeaderPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.suppliersTab.SuspendLayout();
            this.suppliersPageMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTabDataGridView)).BeginInit();
            this.suppliersPageHeaderPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.usersTab.SuspendLayout();
            this.usersPageMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersPageDataGridView)).BeginInit();
            this.usersPageHeaderPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.SuspendLayout();
            // 
            // addProductButton
            // 
            resources.ApplyResources(addProductButton, "addProductButton");
            addProductButton.BackColor = System.Drawing.Color.White;
            addProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addProductButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addProductButton.Name = "addProductButton";
            addProductButton.UseVisualStyleBackColor = false;
            addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // addCustomerButton
            // 
            resources.ApplyResources(addCustomerButton, "addCustomerButton");
            addCustomerButton.BackColor = System.Drawing.Color.White;
            addCustomerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addCustomerButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.UseVisualStyleBackColor = false;
            addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // addSupplierButton
            // 
            resources.ApplyResources(addSupplierButton, "addSupplierButton");
            addSupplierButton.BackColor = System.Drawing.Color.White;
            addSupplierButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addSupplierButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addSupplierButton.Name = "addSupplierButton";
            addSupplierButton.UseVisualStyleBackColor = false;
            addSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // addUserButton
            // 
            resources.ApplyResources(addUserButton, "addUserButton");
            addUserButton.BackColor = System.Drawing.Color.White;
            addUserButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addUserButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addUserButton.Name = "addUserButton";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // leftsideMainPanel
            // 
            resources.ApplyResources(this.leftsideMainPanel, "leftsideMainPanel");
            this.leftsideMainPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.leftsideMainPanel.Controls.Add(this.nameTextLabel);
            this.leftsideMainPanel.Controls.Add(this.usernameTextLabel);
            this.leftsideMainPanel.Controls.Add(this.nameLabel);
            this.leftsideMainPanel.Controls.Add(this.usernameLabel);
            this.leftsideMainPanel.Controls.Add(this.shoppingCartLeftSidePanelButton);
            this.leftsideMainPanel.Controls.Add(this.logoutButton);
            this.leftsideMainPanel.Name = "leftsideMainPanel";
            // 
            // nameTextLabel
            // 
            resources.ApplyResources(this.nameTextLabel, "nameTextLabel");
            this.nameTextLabel.Name = "nameTextLabel";
            // 
            // usernameTextLabel
            // 
            resources.ApplyResources(this.usernameTextLabel, "usernameTextLabel");
            this.usernameTextLabel.Name = "usernameTextLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // shoppingCartLeftSidePanelButton
            // 
            resources.ApplyResources(this.shoppingCartLeftSidePanelButton, "shoppingCartLeftSidePanelButton");
            this.shoppingCartLeftSidePanelButton.BackColor = System.Drawing.Color.Transparent;
            this.shoppingCartLeftSidePanelButton.BackgroundImage = global::POSeidon.Properties.Resources.order;
            this.shoppingCartLeftSidePanelButton.Name = "shoppingCartLeftSidePanelButton";
            this.shoppingCartLeftSidePanelButton.UseVisualStyleBackColor = false;
            this.shoppingCartLeftSidePanelButton.Click += new System.EventHandler(this.ShoppingCartLeftSidePanelButton_Click);
            // 
            // logoutButton
            // 
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.BackgroundImage = global::POSeidon.Properties.Resources.rsz_1logout_50x60;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Controls.Add(this.mainTabControl);
            this.mainPanel.Name = "mainPanel";
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
            resources.ApplyResources(this.mainTabControl, "mainTabControl");
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.Transparent;
            this.homeTab.Controls.Add(this.homePageMainPanel);
            this.homeTab.Controls.Add(this.homePageHeaderPanel);
            resources.ApplyResources(this.homeTab, "homeTab");
            this.homeTab.Name = "homeTab";
            // 
            // homePageMainPanel
            // 
            this.homePageMainPanel.Controls.Add(this.homePageDataGridView);
            resources.ApplyResources(this.homePageMainPanel, "homePageMainPanel");
            this.homePageMainPanel.Name = "homePageMainPanel";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.homePageDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.homePageDataGridView, "homePageDataGridView");
            this.homePageDataGridView.MultiSelect = false;
            this.homePageDataGridView.Name = "homePageDataGridView";
            this.homePageDataGridView.ReadOnly = true;
            this.homePageDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.homePageDataGridView.RowTemplate.Height = 24;
            this.homePageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.homePageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomePageDataGridView_CellClick);
            this.homePageDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.HomePageDataGridView_CellFormatting);
            // 
            // productNameHomePageDataGridViewTextBoxColumn
            // 
            this.productNameHomePageDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.productNameHomePageDataGridViewTextBoxColumn, "productNameHomePageDataGridViewTextBoxColumn");
            this.productNameHomePageDataGridViewTextBoxColumn.Name = "productNameHomePageDataGridViewTextBoxColumn";
            this.productNameHomePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceHomePageDataGridViewTextBoxColumn
            // 
            this.productPriceHomePageDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.productPriceHomePageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.productPriceHomePageDataGridViewTextBoxColumn, "productPriceHomePageDataGridViewTextBoxColumn");
            this.productPriceHomePageDataGridViewTextBoxColumn.Name = "productPriceHomePageDataGridViewTextBoxColumn";
            this.productPriceHomePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productStockHomePageDataGridViewTextBoxColumn
            // 
            this.productStockHomePageDataGridViewTextBoxColumn.DataPropertyName = "StockAmountText";
            resources.ApplyResources(this.productStockHomePageDataGridViewTextBoxColumn, "productStockHomePageDataGridViewTextBoxColumn");
            this.productStockHomePageDataGridViewTextBoxColumn.Name = "productStockHomePageDataGridViewTextBoxColumn";
            this.productStockHomePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productAddHomePageDataGridViewImageColumn
            // 
            resources.ApplyResources(this.productAddHomePageDataGridViewImageColumn, "productAddHomePageDataGridViewImageColumn");
            this.productAddHomePageDataGridViewImageColumn.Image = ((System.Drawing.Image)(resources.GetObject("productAddHomePageDataGridViewImageColumn.Image")));
            this.productAddHomePageDataGridViewImageColumn.Name = "productAddHomePageDataGridViewImageColumn";
            this.productAddHomePageDataGridViewImageColumn.ReadOnly = true;
            // 
            // homePageHeaderPanel
            // 
            resources.ApplyResources(this.homePageHeaderPanel, "homePageHeaderPanel");
            this.homePageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.homePageHeaderPanel.Controls.Add(this.tableLayoutPanel1);
            this.homePageHeaderPanel.Name = "homePageHeaderPanel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(addProductButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productSearchTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // productSearchTextBox
            // 
            resources.ApplyResources(this.productSearchTextBox, "productSearchTextBox");
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.TextChanged += new System.EventHandler(this.ProductSearchTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // statisticsTab
            // 
            this.statisticsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.statisticsTab.Controls.Add(this.statisticsPagePanel);
            resources.ApplyResources(this.statisticsTab, "statisticsTab");
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Enter += new System.EventHandler(this.StatisticsTab_Enter);
            // 
            // statisticsPagePanel
            // 
            this.statisticsPagePanel.Controls.Add(this.statisticsChart);
            resources.ApplyResources(this.statisticsPagePanel, "statisticsPagePanel");
            this.statisticsPagePanel.Name = "statisticsPagePanel";
            this.statisticsPagePanel.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            // 
            // statisticsChart
            // 
            chartArea1.AxisY.Title = "Amount";
            chartArea1.Name = "ChartArea1";
            this.statisticsChart.ChartAreas.Add(chartArea1);
            resources.ApplyResources(this.statisticsChart, "statisticsChart");
            this.statisticsChart.Name = "statisticsChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series1.XValueMember = "ProductName";
            series1.YValueMembers = "Amount";
            this.statisticsChart.Series.Add(series1);
            // 
            // customersTab
            // 
            this.customersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.customersTab.Controls.Add(this.customersPageMainPanel);
            this.customersTab.Controls.Add(this.customersPageHeaderPanel);
            resources.ApplyResources(this.customersTab, "customersTab");
            this.customersTab.Name = "customersTab";
            // 
            // customersPageMainPanel
            // 
            this.customersPageMainPanel.Controls.Add(this.customersTabDataGridView);
            resources.ApplyResources(this.customersPageMainPanel, "customersPageMainPanel");
            this.customersPageMainPanel.Name = "customersPageMainPanel";
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersTabDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.customersTabDataGridView, "customersTabDataGridView");
            this.customersTabDataGridView.MultiSelect = false;
            this.customersTabDataGridView.Name = "customersTabDataGridView";
            this.customersTabDataGridView.RowTemplate.Height = 24;
            this.customersTabDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            resources.ApplyResources(this.customerFirstNameDataGridViewTextBoxColumn, "customerFirstNameDataGridViewTextBoxColumn");
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            resources.ApplyResources(this.customerLastNameDataGridViewTextBoxColumn, "customerLastNameDataGridViewTextBoxColumn");
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            resources.ApplyResources(this.customerPhoneDataGridViewTextBoxColumn, "customerPhoneDataGridViewTextBoxColumn");
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(this.customerEmailDataGridViewTextBoxColumn, "customerEmailDataGridViewTextBoxColumn");
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            resources.ApplyResources(this.customerAddressDataGridViewTextBoxColumn, "customerAddressDataGridViewTextBoxColumn");
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // deleteCustomerDataGridViewImageColumn
            // 
            resources.ApplyResources(this.deleteCustomerDataGridViewImageColumn, "deleteCustomerDataGridViewImageColumn");
            this.deleteCustomerDataGridViewImageColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.deleteCustomerDataGridViewImageColumn.Name = "deleteCustomerDataGridViewImageColumn";
            // 
            // customersPageHeaderPanel
            // 
            resources.ApplyResources(this.customersPageHeaderPanel, "customersPageHeaderPanel");
            this.customersPageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.customersPageHeaderPanel.Controls.Add(this.tableLayoutPanel2);
            this.customersPageHeaderPanel.Name = "customersPageHeaderPanel";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.customerSearchTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(addCustomerButton, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // customerSearchTextBox
            // 
            resources.ApplyResources(this.customerSearchTextBox, "customerSearchTextBox");
            this.customerSearchTextBox.Name = "customerSearchTextBox";
            // 
            // suppliersTab
            // 
            this.suppliersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.suppliersTab.Controls.Add(this.suppliersPageMainPanel);
            this.suppliersTab.Controls.Add(this.suppliersPageHeaderPanel);
            resources.ApplyResources(this.suppliersTab, "suppliersTab");
            this.suppliersTab.Name = "suppliersTab";
            // 
            // suppliersPageMainPanel
            // 
            this.suppliersPageMainPanel.Controls.Add(this.suppliersTabDataGridView);
            resources.ApplyResources(this.suppliersPageMainPanel, "suppliersPageMainPanel");
            this.suppliersPageMainPanel.Name = "suppliersPageMainPanel";
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suppliersTabDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.suppliersTabDataGridView, "suppliersTabDataGridView");
            this.suppliersTabDataGridView.MultiSelect = false;
            this.suppliersTabDataGridView.Name = "suppliersTabDataGridView";
            this.suppliersTabDataGridView.RowTemplate.Height = 24;
            this.suppliersTabDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.supplierNameDataGridViewTextBoxColumn, "supplierNameDataGridViewTextBoxColumn");
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            // 
            // supplierPhoneDataGridViewTextBoxColumn
            // 
            this.supplierPhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            resources.ApplyResources(this.supplierPhoneDataGridViewTextBoxColumn, "supplierPhoneDataGridViewTextBoxColumn");
            this.supplierPhoneDataGridViewTextBoxColumn.Name = "supplierPhoneDataGridViewTextBoxColumn";
            // 
            // supplierEmailDataGridViewTextBoxColumn
            // 
            this.supplierEmailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(this.supplierEmailDataGridViewTextBoxColumn, "supplierEmailDataGridViewTextBoxColumn");
            this.supplierEmailDataGridViewTextBoxColumn.Name = "supplierEmailDataGridViewTextBoxColumn";
            // 
            // supplierAddressDataGridViewTextBoxColumn
            // 
            this.supplierAddressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            resources.ApplyResources(this.supplierAddressDataGridViewTextBoxColumn, "supplierAddressDataGridViewTextBoxColumn");
            this.supplierAddressDataGridViewTextBoxColumn.Name = "supplierAddressDataGridViewTextBoxColumn";
            // 
            // deleteSupplierDataGridViewImageColumn
            // 
            resources.ApplyResources(this.deleteSupplierDataGridViewImageColumn, "deleteSupplierDataGridViewImageColumn");
            this.deleteSupplierDataGridViewImageColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.deleteSupplierDataGridViewImageColumn.Name = "deleteSupplierDataGridViewImageColumn";
            // 
            // suppliersPageHeaderPanel
            // 
            resources.ApplyResources(this.suppliersPageHeaderPanel, "suppliersPageHeaderPanel");
            this.suppliersPageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.suppliersPageHeaderPanel.Controls.Add(this.tableLayoutPanel3);
            this.suppliersPageHeaderPanel.Name = "suppliersPageHeaderPanel";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.supplierSearchTextBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(addSupplierButton, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // supplierSearchTextBox
            // 
            resources.ApplyResources(this.supplierSearchTextBox, "supplierSearchTextBox");
            this.supplierSearchTextBox.Name = "supplierSearchTextBox";
            this.supplierSearchTextBox.TextChanged += new System.EventHandler(this.SuppliersSearchTextBox_TextChanged);
            // 
            // salesAndPurchasingTab
            // 
            this.salesAndPurchasingTab.BackColor = System.Drawing.Color.PeachPuff;
            this.salesAndPurchasingTab.Controls.Add(this.salesAndPurchasingPanel);
            resources.ApplyResources(this.salesAndPurchasingTab, "salesAndPurchasingTab");
            this.salesAndPurchasingTab.Name = "salesAndPurchasingTab";
            // 
            // salesAndPurchasingPanel
            // 
            this.salesAndPurchasingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.salesAndPurchasingPanel.Controls.Add(this.salesAndPurchasingNavigator);
            resources.ApplyResources(this.salesAndPurchasingPanel, "salesAndPurchasingPanel");
            this.salesAndPurchasingPanel.Name = "salesAndPurchasingPanel";
            // 
            // salesAndPurchasingNavigator
            // 
            this.salesAndPurchasingNavigator.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.salesAndPurchasingNavigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            resources.ApplyResources(this.salesAndPurchasingNavigator, "salesAndPurchasingNavigator");
            this.salesAndPurchasingNavigator.Name = "salesAndPurchasingNavigator";
            this.salesAndPurchasingNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.salesAndPurchasingNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.salesNavigatorPage,
            this.purchasingNavigatorPage});
            this.salesAndPurchasingNavigator.SelectedIndex = 0;
            // 
            // salesNavigatorPage
            // 
            this.salesNavigatorPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            resources.ApplyResources(this.salesNavigatorPage, "salesNavigatorPage");
            this.salesNavigatorPage.Controls.Add(this.salesHistoryDataGridView);
            this.salesNavigatorPage.Flags = 65534;
            this.salesNavigatorPage.LastVisibleSet = true;
            this.salesNavigatorPage.Name = "salesNavigatorPage";
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
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.salesHistoryDataGridView, "salesHistoryDataGridView");
            this.salesHistoryDataGridView.MultiSelect = false;
            this.salesHistoryDataGridView.Name = "salesHistoryDataGridView";
            this.salesHistoryDataGridView.RowTemplate.Height = 24;
            this.salesHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.salesHistoryDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.SalesHistoryDataGridView_CellFormatting);
            // 
            // productNameSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productNameSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            resources.ApplyResources(this.productNameSalesHistoryDataGridViewTextBoxColumn, "productNameSalesHistoryDataGridViewTextBoxColumn");
            this.productNameSalesHistoryDataGridViewTextBoxColumn.Name = "productNameSalesHistoryDataGridViewTextBoxColumn";
            this.productNameSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.productPriceSalesHistoryDataGridViewTextBoxColumn, "productPriceSalesHistoryDataGridViewTextBoxColumn");
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.Name = "productPriceSalesHistoryDataGridViewTextBoxColumn";
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productAmountSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            resources.ApplyResources(this.productAmountSalesHistoryDataGridViewTextBoxColumn, "productAmountSalesHistoryDataGridViewTextBoxColumn");
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.Name = "productAmountSalesHistoryDataGridViewTextBoxColumn";
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productTotalPriceSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductTotalPrice";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn, "productTotalPriceSalesHistoryDataGridViewTextBoxColumn");
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.Name = "productTotalPriceSalesHistoryDataGridViewTextBoxColumn";
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            resources.ApplyResources(this.customerNameSalesHistoryDataGridViewTextBoxColumn, "customerNameSalesHistoryDataGridViewTextBoxColumn");
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.Name = "customerNameSalesHistoryDataGridViewTextBoxColumn";
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPhoneSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            resources.ApplyResources(this.customerPhoneSalesHistoryDataGridViewTextBoxColumn, "customerPhoneSalesHistoryDataGridViewTextBoxColumn");
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.Name = "customerPhoneSalesHistoryDataGridViewTextBoxColumn";
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerEmailSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail";
            resources.ApplyResources(this.customerEmailSalesHistoryDataGridViewTextBoxColumn, "customerEmailSalesHistoryDataGridViewTextBoxColumn");
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.Name = "customerEmailSalesHistoryDataGridViewTextBoxColumn";
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerAddressSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            resources.ApplyResources(this.customerAddressSalesHistoryDataGridViewTextBoxColumn, "customerAddressSalesHistoryDataGridViewTextBoxColumn");
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.Name = "customerAddressSalesHistoryDataGridViewTextBoxColumn";
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateSalesHistoryDataGridViewTextBoxColumn
            // 
            this.dateSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "Date";
            resources.ApplyResources(this.dateSalesHistoryDataGridViewTextBoxColumn, "dateSalesHistoryDataGridViewTextBoxColumn");
            this.dateSalesHistoryDataGridViewTextBoxColumn.Name = "dateSalesHistoryDataGridViewTextBoxColumn";
            this.dateSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasingNavigatorPage
            // 
            this.purchasingNavigatorPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            resources.ApplyResources(this.purchasingNavigatorPage, "purchasingNavigatorPage");
            this.purchasingNavigatorPage.Controls.Add(this.purchasingDataGridView);
            this.purchasingNavigatorPage.Flags = 65534;
            this.purchasingNavigatorPage.LastVisibleSet = true;
            this.purchasingNavigatorPage.Name = "purchasingNavigatorPage";
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
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchasingDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.purchasingDataGridView, "purchasingDataGridView");
            this.purchasingDataGridView.MultiSelect = false;
            this.purchasingDataGridView.Name = "purchasingDataGridView";
            this.purchasingDataGridView.RowTemplate.Height = 24;
            this.purchasingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.purchasingDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PurchasingDataGridView_CellFormatting);
            // 
            // productPurchasingDataGridViewTextBoxColumn
            // 
            this.productPurchasingDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            resources.ApplyResources(this.productPurchasingDataGridViewTextBoxColumn, "productPurchasingDataGridViewTextBoxColumn");
            this.productPurchasingDataGridViewTextBoxColumn.Name = "productPurchasingDataGridViewTextBoxColumn";
            this.productPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountPurchasingDataGridViewTextBoxColumn
            // 
            this.amountPurchasingDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            resources.ApplyResources(this.amountPurchasingDataGridViewTextBoxColumn, "amountPurchasingDataGridViewTextBoxColumn");
            this.amountPurchasingDataGridViewTextBoxColumn.Name = "amountPurchasingDataGridViewTextBoxColumn";
            this.amountPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierPurchasingDataGridViewTextBoxColumn
            // 
            this.supplierPurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            resources.ApplyResources(this.supplierPurchasingDataGridViewTextBoxColumn, "supplierPurchasingDataGridViewTextBoxColumn");
            this.supplierPurchasingDataGridViewTextBoxColumn.Name = "supplierPurchasingDataGridViewTextBoxColumn";
            this.supplierPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonePurchasingDataGridViewTextBoxColumn
            // 
            this.phonePurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierPhone";
            resources.ApplyResources(this.phonePurchasingDataGridViewTextBoxColumn, "phonePurchasingDataGridViewTextBoxColumn");
            this.phonePurchasingDataGridViewTextBoxColumn.Name = "phonePurchasingDataGridViewTextBoxColumn";
            this.phonePurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailPurchasingDataGridViewTextBoxColumn
            // 
            this.emailPurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierEmail";
            resources.ApplyResources(this.emailPurchasingDataGridViewTextBoxColumn, "emailPurchasingDataGridViewTextBoxColumn");
            this.emailPurchasingDataGridViewTextBoxColumn.Name = "emailPurchasingDataGridViewTextBoxColumn";
            this.emailPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressPurchasingDataGridViewTextBoxColumn
            // 
            this.addressPurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierAddress";
            resources.ApplyResources(this.addressPurchasingDataGridViewTextBoxColumn, "addressPurchasingDataGridViewTextBoxColumn");
            this.addressPurchasingDataGridViewTextBoxColumn.Name = "addressPurchasingDataGridViewTextBoxColumn";
            this.addressPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPurchasingDataGridViewTextBoxColumn
            // 
            this.totalPurchasingDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.totalPurchasingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.totalPurchasingDataGridViewTextBoxColumn, "totalPurchasingDataGridViewTextBoxColumn");
            this.totalPurchasingDataGridViewTextBoxColumn.Name = "totalPurchasingDataGridViewTextBoxColumn";
            this.totalPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datePurchasingDataGridViewTextBoxColumn
            // 
            this.datePurchasingDataGridViewTextBoxColumn.DataPropertyName = "Date";
            resources.ApplyResources(this.datePurchasingDataGridViewTextBoxColumn, "datePurchasingDataGridViewTextBoxColumn");
            this.datePurchasingDataGridViewTextBoxColumn.Name = "datePurchasingDataGridViewTextBoxColumn";
            this.datePurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersTab
            // 
            this.usersTab.Controls.Add(this.usersPageMainPanel);
            this.usersTab.Controls.Add(this.usersPageHeaderPanel);
            resources.ApplyResources(this.usersTab, "usersTab");
            this.usersTab.Name = "usersTab";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // usersPageMainPanel
            // 
            this.usersPageMainPanel.Controls.Add(this.usersPageDataGridView);
            resources.ApplyResources(this.usersPageMainPanel, "usersPageMainPanel");
            this.usersPageMainPanel.Name = "usersPageMainPanel";
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
            resources.ApplyResources(this.usersPageDataGridView, "usersPageDataGridView");
            this.usersPageDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.usersPageDataGridView.MultiSelect = false;
            this.usersPageDataGridView.Name = "usersPageDataGridView";
            this.usersPageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.usersPageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersPageDataGridView_CellClick);
            this.usersPageDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersPageDataGridView_CellValueChanged);
            // 
            // usernameUsersDataGridViewTextBoxColumn
            // 
            this.usernameUsersDataGridViewTextBoxColumn.DataPropertyName = "Username";
            resources.ApplyResources(this.usernameUsersDataGridViewTextBoxColumn, "usernameUsersDataGridViewTextBoxColumn");
            this.usernameUsersDataGridViewTextBoxColumn.Name = "usernameUsersDataGridViewTextBoxColumn";
            this.usernameUsersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameUsersDataGridViewTextBoxColumn
            // 
            this.firstNameUsersDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            resources.ApplyResources(this.firstNameUsersDataGridViewTextBoxColumn, "firstNameUsersDataGridViewTextBoxColumn");
            this.firstNameUsersDataGridViewTextBoxColumn.Name = "firstNameUsersDataGridViewTextBoxColumn";
            // 
            // lastNameUsersDataGridViewTextBoxColumn
            // 
            this.lastNameUsersDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            resources.ApplyResources(this.lastNameUsersDataGridViewTextBoxColumn, "lastNameUsersDataGridViewTextBoxColumn");
            this.lastNameUsersDataGridViewTextBoxColumn.Name = "lastNameUsersDataGridViewTextBoxColumn";
            // 
            // isAdminUsersDataGridViewCheckBoxColumn
            // 
            this.isAdminUsersDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            resources.ApplyResources(this.isAdminUsersDataGridViewCheckBoxColumn, "isAdminUsersDataGridViewCheckBoxColumn");
            this.isAdminUsersDataGridViewCheckBoxColumn.Name = "isAdminUsersDataGridViewCheckBoxColumn";
            // 
            // deleteUsersDataGridViewTextBoxColumn
            // 
            resources.ApplyResources(this.deleteUsersDataGridViewTextBoxColumn, "deleteUsersDataGridViewTextBoxColumn");
            this.deleteUsersDataGridViewTextBoxColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.deleteUsersDataGridViewTextBoxColumn.Name = "deleteUsersDataGridViewTextBoxColumn";
            this.deleteUsersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersPageHeaderPanel
            // 
            resources.ApplyResources(this.usersPageHeaderPanel, "usersPageHeaderPanel");
            this.usersPageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.usersPageHeaderPanel.Controls.Add(this.tableLayoutPanel5);
            this.usersPageHeaderPanel.Name = "usersPageHeaderPanel";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.usersSearchTextBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(addUserButton, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // usersSearchTextBox
            // 
            resources.ApplyResources(this.usersSearchTextBox, "usersSearchTextBox");
            this.usersSearchTextBox.Name = "usersSearchTextBox";
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.settingsTab.Controls.Add(this.settingsPanel);
            resources.ApplyResources(this.settingsTab, "settingsTab");
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Enter += new System.EventHandler(this.SettingsTab_Enter);
            // 
            // settingsPanel
            // 
            resources.ApplyResources(this.settingsPanel, "settingsPanel");
            this.settingsPanel.Controls.Add(this.tableLayoutPanel4);
            this.settingsPanel.Name = "settingsPanel";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.currencySettingsGroupBox, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.languageSettingsLabel);
            this.panel1.Controls.Add(this.languageSettingsComboBox);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.weightUnitSettingsLabel);
            this.panel1.Controls.Add(this.weightUnitComboBox);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // languageSettingsLabel
            // 
            resources.ApplyResources(this.languageSettingsLabel, "languageSettingsLabel");
            this.languageSettingsLabel.Name = "languageSettingsLabel";
            this.languageSettingsLabel.Values.Text = resources.GetString("languageSettingsLabel.Values.Text");
            // 
            // languageSettingsComboBox
            // 
            resources.ApplyResources(this.languageSettingsComboBox, "languageSettingsComboBox");
            this.languageSettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageSettingsComboBox.DropDownWidth = 121;
            this.languageSettingsComboBox.Items.AddRange(new object[] {
            resources.GetString("languageSettingsComboBox.Items"),
            resources.GetString("languageSettingsComboBox.Items1")});
            this.languageSettingsComboBox.Name = "languageSettingsComboBox";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // weightUnitSettingsLabel
            // 
            resources.ApplyResources(this.weightUnitSettingsLabel, "weightUnitSettingsLabel");
            this.weightUnitSettingsLabel.Name = "weightUnitSettingsLabel";
            this.weightUnitSettingsLabel.Values.Text = resources.GetString("weightUnitSettingsLabel.Values.Text");
            // 
            // weightUnitComboBox
            // 
            resources.ApplyResources(this.weightUnitComboBox, "weightUnitComboBox");
            this.weightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightUnitComboBox.DropDownWidth = 121;
            this.weightUnitComboBox.Name = "weightUnitComboBox";
            // 
            // currencySettingsGroupBox
            // 
            resources.ApplyResources(this.currencySettingsGroupBox, "currencySettingsGroupBox");
            this.currencySettingsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.currencySettingsGroupBox.CaptionOverlap = 0D;
            this.currencySettingsGroupBox.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.currencySettingsGroupBox.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate;
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
            this.currencySettingsGroupBox.Values.Heading = resources.GetString("currencySettingsGroupBox.Values.Heading");
            // 
            // currencySettingsGroupSeparatorComboBox
            // 
            this.currencySettingsGroupSeparatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencySettingsGroupSeparatorComboBox.DropDownWidth = 121;
            this.currencySettingsGroupSeparatorComboBox.Items.AddRange(new object[] {
            resources.GetString("currencySettingsGroupSeparatorComboBox.Items"),
            resources.GetString("currencySettingsGroupSeparatorComboBox.Items1")});
            resources.ApplyResources(this.currencySettingsGroupSeparatorComboBox, "currencySettingsGroupSeparatorComboBox");
            this.currencySettingsGroupSeparatorComboBox.Name = "currencySettingsGroupSeparatorComboBox";
            // 
            // currencySettingsDecimalSeparatorComboBox
            // 
            this.currencySettingsDecimalSeparatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencySettingsDecimalSeparatorComboBox.DropDownWidth = 121;
            this.currencySettingsDecimalSeparatorComboBox.Items.AddRange(new object[] {
            resources.GetString("currencySettingsDecimalSeparatorComboBox.Items"),
            resources.GetString("currencySettingsDecimalSeparatorComboBox.Items1")});
            resources.ApplyResources(this.currencySettingsDecimalSeparatorComboBox, "currencySettingsDecimalSeparatorComboBox");
            this.currencySettingsDecimalSeparatorComboBox.Name = "currencySettingsDecimalSeparatorComboBox";
            // 
            // currencySettingsGroupSeparatorLabel
            // 
            resources.ApplyResources(this.currencySettingsGroupSeparatorLabel, "currencySettingsGroupSeparatorLabel");
            this.currencySettingsGroupSeparatorLabel.Name = "currencySettingsGroupSeparatorLabel";
            this.currencySettingsGroupSeparatorLabel.Values.Text = resources.GetString("currencySettingsGroupSeparatorLabel.Values.Text");
            // 
            // currencySettingsDecimalSeparatorLabel
            // 
            resources.ApplyResources(this.currencySettingsDecimalSeparatorLabel, "currencySettingsDecimalSeparatorLabel");
            this.currencySettingsDecimalSeparatorLabel.Name = "currencySettingsDecimalSeparatorLabel";
            this.currencySettingsDecimalSeparatorLabel.Values.Text = resources.GetString("currencySettingsDecimalSeparatorLabel.Values.Text");
            // 
            // currencySettingsPutSpaceCheckBox
            // 
            resources.ApplyResources(this.currencySettingsPutSpaceCheckBox, "currencySettingsPutSpaceCheckBox");
            this.currencySettingsPutSpaceCheckBox.Name = "currencySettingsPutSpaceCheckBox";
            this.currencySettingsPutSpaceCheckBox.Values.Text = resources.GetString("currencySettingsPutSpaceCheckBox.Values.Text");
            // 
            // currencySettingsSymbolPlacementRightRadioButton
            // 
            resources.ApplyResources(this.currencySettingsSymbolPlacementRightRadioButton, "currencySettingsSymbolPlacementRightRadioButton");
            this.currencySettingsSymbolPlacementRightRadioButton.Name = "currencySettingsSymbolPlacementRightRadioButton";
            this.currencySettingsSymbolPlacementRightRadioButton.Values.Text = resources.GetString("currencySettingsSymbolPlacementRightRadioButton.Values.Text");
            // 
            // currencySettingsSymbolPlacementLeftRadioButton
            // 
            this.currencySettingsSymbolPlacementLeftRadioButton.Checked = true;
            resources.ApplyResources(this.currencySettingsSymbolPlacementLeftRadioButton, "currencySettingsSymbolPlacementLeftRadioButton");
            this.currencySettingsSymbolPlacementLeftRadioButton.Name = "currencySettingsSymbolPlacementLeftRadioButton";
            this.currencySettingsSymbolPlacementLeftRadioButton.Values.Text = resources.GetString("currencySettingsSymbolPlacementLeftRadioButton.Values.Text");
            // 
            // currencySettingsLabel
            // 
            resources.ApplyResources(this.currencySettingsLabel, "currencySettingsLabel");
            this.currencySettingsLabel.Name = "currencySettingsLabel";
            this.currencySettingsLabel.Values.Text = resources.GetString("currencySettingsLabel.Values.Text");
            // 
            // currencySettingsSymbolPlacementLabel
            // 
            resources.ApplyResources(this.currencySettingsSymbolPlacementLabel, "currencySettingsSymbolPlacementLabel");
            this.currencySettingsSymbolPlacementLabel.Name = "currencySettingsSymbolPlacementLabel";
            this.currencySettingsSymbolPlacementLabel.Values.Text = resources.GetString("currencySettingsSymbolPlacementLabel.Values.Text");
            // 
            // currencySettingsComboBox
            // 
            this.currencySettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencySettingsComboBox.DropDownWidth = 178;
            resources.ApplyResources(this.currencySettingsComboBox, "currencySettingsComboBox");
            this.currencySettingsComboBox.Name = "currencySettingsComboBox";
            // 
            // supplierStatisticsChart
            // 
            resources.ApplyResources(this.supplierStatisticsChart, "supplierStatisticsChart");
            chartArea2.Name = "ChartArea8";
            this.supplierStatisticsChart.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend8";
            this.supplierStatisticsChart.Legends.Add(legend1);
            this.supplierStatisticsChart.Name = "supplierStatisticsChart";
            this.supplierStatisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea8";
            series2.Legend = "Legend8";
            series2.Name = "Series8";
            this.supplierStatisticsChart.Series.Add(series2);
            // 
            // customerStatisticsPanel
            // 
            resources.ApplyResources(this.customerStatisticsPanel, "customerStatisticsPanel");
            this.customerStatisticsPanel.Name = "customerStatisticsPanel";
            // 
            // customerStatisticsChart
            // 
            resources.ApplyResources(this.customerStatisticsChart, "customerStatisticsChart");
            chartArea3.Name = "ChartArea7";
            this.customerStatisticsChart.ChartAreas.Add(chartArea3);
            this.customerStatisticsChart.Name = "customerStatisticsChart";
            this.customerStatisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea7";
            series3.Name = "test";
            series3.XValueMember = "ProductName";
            series3.YValueMembers = "Amount";
            this.customerStatisticsChart.Series.Add(series3);
            // 
            // customerStatisticsPage
            // 
            this.customerStatisticsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.customerStatisticsPage.Controls.Add(this.customerStatisticsPanel);
            this.customerStatisticsPage.Flags = 65534;
            this.customerStatisticsPage.LastVisibleSet = true;
            resources.ApplyResources(this.customerStatisticsPage, "customerStatisticsPage");
            this.customerStatisticsPage.Name = "customerStatisticsPage";
            this.customerStatisticsPage.UniqueName = "1fbf379b70634940bcf9c585c1b0ac13";
            // 
            // dataGridViewImageColumn1
            // 
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = global::POSeidon.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            resources.ApplyResources(this.dataGridViewImageColumn3, "dataGridViewImageColumn3");
            this.dataGridViewImageColumn3.Image = global::POSeidon.Properties.Resources.delete;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // cancelLogSalesHistoryDataGridViewImageBoxColumn
            // 
            resources.ApplyResources(this.cancelLogSalesHistoryDataGridViewImageBoxColumn, "cancelLogSalesHistoryDataGridViewImageBoxColumn");
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.Name = "cancelLogSalesHistoryDataGridViewImageBoxColumn";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftsideMainPanel);
            this.Name = "MainForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.suppliersTab.ResumeLayout(false);
            this.suppliersPageMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTabDataGridView)).EndInit();
            this.suppliersPageHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
            this.usersTab.ResumeLayout(false);
            this.usersPageMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersPageDataGridView)).EndInit();
            this.usersPageHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
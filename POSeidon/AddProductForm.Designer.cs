namespace POSeidon
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.existingProductRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.newProductRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.addProductNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.existingProductPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.existingProductSupplierInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.existingProductPurchasePriceTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.existingProductPurchasePriceAddProductLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.existingProductSupplierLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.existingProductSupplierComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.addExistingProductButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.existingProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.existingProductPriceLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.existingProductNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.existingProductAmountLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.existingProductPriceTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.existingProductComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.existingProductWeightUnitLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.existingProductAmountTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.existingProductWeightUnitComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.newProductPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.newProductSupplierInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.newProductPurchasePriceTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newProductPurchasePriceLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductSupplierLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductSupplierComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.addNewProductButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.newProductProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.newProductNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductPriceLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductAmountTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newProductWeightUnitLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductAmountLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductPriceTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newProductNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newProductWeightUnitComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.productTypeLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductTypeComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.addProductTypePanel = new System.Windows.Forms.Panel();
            this.addProductPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.addProductNavigator)).BeginInit();
            this.addProductNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingProductPage)).BeginInit();
            this.existingProductPage.SuspendLayout();
            this.existingProductSupplierInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingProductSupplierComboBox)).BeginInit();
            this.existingProductInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingProductComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.existingProductWeightUnitComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductPage)).BeginInit();
            this.newProductPage.SuspendLayout();
            this.newProductSupplierInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProductSupplierComboBox)).BeginInit();
            this.newProductProductInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProductWeightUnitComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductTypeComboBox)).BeginInit();
            this.addProductTypePanel.SuspendLayout();
            this.addProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // existingProductRadioButton
            // 
            this.existingProductRadioButton.Checked = true;
            this.existingProductRadioButton.Location = new System.Drawing.Point(17, 16);
            this.existingProductRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductRadioButton.Name = "existingProductRadioButton";
            this.existingProductRadioButton.Size = new System.Drawing.Size(110, 20);
            this.existingProductRadioButton.TabIndex = 0;
            this.existingProductRadioButton.TabStop = false;
            this.existingProductRadioButton.Values.Text = "Existing product";
            this.existingProductRadioButton.CheckedChanged += new System.EventHandler(this.ExistingProductRadioButton_CheckedChanged);
            // 
            // newProductRadioButton
            // 
            this.newProductRadioButton.Location = new System.Drawing.Point(17, 67);
            this.newProductRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.newProductRadioButton.Name = "newProductRadioButton";
            this.newProductRadioButton.Size = new System.Drawing.Size(93, 20);
            this.newProductRadioButton.TabIndex = 1;
            this.newProductRadioButton.TabStop = false;
            this.newProductRadioButton.Values.Text = "New product";
            // 
            // addProductNavigator
            // 
            this.addProductNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProductNavigator.Location = new System.Drawing.Point(0, 0);
            this.addProductNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.addProductNavigator.Name = "addProductNavigator";
            this.addProductNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.Panel;
            this.addProductNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.existingProductPage,
            this.newProductPage});
            this.addProductNavigator.SelectedIndex = 1;
            this.addProductNavigator.Size = new System.Drawing.Size(519, 474);
            this.addProductNavigator.TabIndex = 2;
            // 
            // existingProductPage
            // 
            this.existingProductPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.existingProductPage.Controls.Add(this.existingProductSupplierInfoGroupBox);
            this.existingProductPage.Controls.Add(this.existingProductInfoGroupBox);
            this.existingProductPage.Flags = 65534;
            this.existingProductPage.LastVisibleSet = true;
            this.existingProductPage.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductPage.MinimumSize = new System.Drawing.Size(67, 66);
            this.existingProductPage.Name = "existingProductPage";
            this.existingProductPage.Size = new System.Drawing.Size(495, 439);
            this.existingProductPage.StateCommon.Page.Color1 = System.Drawing.Color.WhiteSmoke;
            this.existingProductPage.Text = "Existing Product";
            this.existingProductPage.ToolTipTitle = "Page ToolTip";
            this.existingProductPage.UniqueName = "c78de74bec554c85b82c5e889b4bd26f";
            // 
            // existingProductSupplierInfoGroupBox
            // 
            this.existingProductSupplierInfoGroupBox.Controls.Add(this.existingProductPurchasePriceTextBox);
            this.existingProductSupplierInfoGroupBox.Controls.Add(this.existingProductPurchasePriceAddProductLabel);
            this.existingProductSupplierInfoGroupBox.Controls.Add(this.existingProductSupplierLabel);
            this.existingProductSupplierInfoGroupBox.Controls.Add(this.existingProductSupplierComboBox);
            this.existingProductSupplierInfoGroupBox.Controls.Add(this.addExistingProductButton);
            this.existingProductSupplierInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.existingProductSupplierInfoGroupBox.Location = new System.Drawing.Point(0, 206);
            this.existingProductSupplierInfoGroupBox.Name = "existingProductSupplierInfoGroupBox";
            this.existingProductSupplierInfoGroupBox.Size = new System.Drawing.Size(495, 233);
            this.existingProductSupplierInfoGroupBox.TabIndex = 1;
            this.existingProductSupplierInfoGroupBox.TabStop = false;
            this.existingProductSupplierInfoGroupBox.Text = "Supplier Info";
            // 
            // existingProductPurchasePriceTextBox
            // 
            this.existingProductPurchasePriceTextBox.Location = new System.Drawing.Point(161, 80);
            this.existingProductPurchasePriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductPurchasePriceTextBox.Name = "existingProductPurchasePriceTextBox";
            this.existingProductPurchasePriceTextBox.Size = new System.Drawing.Size(215, 27);
            this.existingProductPurchasePriceTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductPurchasePriceTextBox.StateCommon.Border.Rounding = 5;
            this.existingProductPurchasePriceTextBox.TabIndex = 1;
            // 
            // existingProductPurchasePriceAddProductLabel
            // 
            this.existingProductPurchasePriceAddProductLabel.Location = new System.Drawing.Point(16, 80);
            this.existingProductPurchasePriceAddProductLabel.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductPurchasePriceAddProductLabel.Name = "existingProductPurchasePriceAddProductLabel";
            this.existingProductPurchasePriceAddProductLabel.Size = new System.Drawing.Size(92, 20);
            this.existingProductPurchasePriceAddProductLabel.TabIndex = 26;
            this.existingProductPurchasePriceAddProductLabel.Values.Text = "Purchase Price:";
            // 
            // existingProductSupplierLabel
            // 
            this.existingProductSupplierLabel.Location = new System.Drawing.Point(16, 34);
            this.existingProductSupplierLabel.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductSupplierLabel.Name = "existingProductSupplierLabel";
            this.existingProductSupplierLabel.Size = new System.Drawing.Size(58, 20);
            this.existingProductSupplierLabel.TabIndex = 24;
            this.existingProductSupplierLabel.Values.Text = "Supplier:";
            // 
            // existingProductSupplierComboBox
            // 
            this.existingProductSupplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingProductSupplierComboBox.DropDownWidth = 161;
            this.existingProductSupplierComboBox.Location = new System.Drawing.Point(161, 33);
            this.existingProductSupplierComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductSupplierComboBox.Name = "existingProductSupplierComboBox";
            this.existingProductSupplierComboBox.Size = new System.Drawing.Size(215, 25);
            this.existingProductSupplierComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductSupplierComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            this.existingProductSupplierComboBox.TabIndex = 0;
            // 
            // addExistingProductButton
            // 
            this.addExistingProductButton.Location = new System.Drawing.Point(348, 160);
            this.addExistingProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.addExistingProductButton.Name = "addExistingProductButton";
            this.addExistingProductButton.Size = new System.Drawing.Size(120, 33);
            this.addExistingProductButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addExistingProductButton.StateCommon.Border.Rounding = 5;
            this.addExistingProductButton.TabIndex = 2;
            this.addExistingProductButton.Values.Text = "Add";
            this.addExistingProductButton.Click += new System.EventHandler(this.AddExistingProductButton_Click);
            // 
            // existingProductInfoGroupBox
            // 
            this.existingProductInfoGroupBox.Controls.Add(this.existingProductPriceLabel);
            this.existingProductInfoGroupBox.Controls.Add(this.existingProductNameLabel);
            this.existingProductInfoGroupBox.Controls.Add(this.existingProductAmountLabel);
            this.existingProductInfoGroupBox.Controls.Add(this.existingProductPriceTextBox);
            this.existingProductInfoGroupBox.Controls.Add(this.existingProductComboBox);
            this.existingProductInfoGroupBox.Controls.Add(this.existingProductWeightUnitLabel);
            this.existingProductInfoGroupBox.Controls.Add(this.existingProductAmountTextBox);
            this.existingProductInfoGroupBox.Controls.Add(this.existingProductWeightUnitComboBox);
            this.existingProductInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.existingProductInfoGroupBox.Location = new System.Drawing.Point(0, 0);
            this.existingProductInfoGroupBox.Name = "existingProductInfoGroupBox";
            this.existingProductInfoGroupBox.Size = new System.Drawing.Size(495, 206);
            this.existingProductInfoGroupBox.TabIndex = 0;
            this.existingProductInfoGroupBox.TabStop = false;
            this.existingProductInfoGroupBox.Text = "Product Info";
            // 
            // existingProductPriceLabel
            // 
            this.existingProductPriceLabel.Location = new System.Drawing.Point(19, 84);
            this.existingProductPriceLabel.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductPriceLabel.Name = "existingProductPriceLabel";
            this.existingProductPriceLabel.Size = new System.Drawing.Size(40, 20);
            this.existingProductPriceLabel.TabIndex = 4;
            this.existingProductPriceLabel.Values.Text = "Price:";
            // 
            // existingProductNameLabel
            // 
            this.existingProductNameLabel.Location = new System.Drawing.Point(19, 31);
            this.existingProductNameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductNameLabel.Name = "existingProductNameLabel";
            this.existingProductNameLabel.Size = new System.Drawing.Size(46, 20);
            this.existingProductNameLabel.TabIndex = 3;
            this.existingProductNameLabel.Values.Text = "Name:";
            // 
            // existingProductAmountLabel
            // 
            this.existingProductAmountLabel.Location = new System.Drawing.Point(19, 131);
            this.existingProductAmountLabel.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductAmountLabel.Name = "existingProductAmountLabel";
            this.existingProductAmountLabel.Size = new System.Drawing.Size(57, 20);
            this.existingProductAmountLabel.TabIndex = 5;
            this.existingProductAmountLabel.Values.Text = "Amount:";
            // 
            // existingProductPriceTextBox
            // 
            this.existingProductPriceTextBox.Location = new System.Drawing.Point(165, 81);
            this.existingProductPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductPriceTextBox.Name = "existingProductPriceTextBox";
            this.existingProductPriceTextBox.Size = new System.Drawing.Size(215, 27);
            this.existingProductPriceTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductPriceTextBox.StateCommon.Border.Rounding = 5;
            this.existingProductPriceTextBox.TabIndex = 1;
            // 
            // existingProductComboBox
            // 
            this.existingProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingProductComboBox.DropDownWidth = 161;
            this.existingProductComboBox.Location = new System.Drawing.Point(165, 30);
            this.existingProductComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductComboBox.Name = "existingProductComboBox";
            this.existingProductComboBox.Size = new System.Drawing.Size(215, 25);
            this.existingProductComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            this.existingProductComboBox.TabIndex = 0;
            this.existingProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ExistingProductComboBox_SelectedIndexChanged);
            // 
            // existingProductWeightUnitLabel
            // 
            this.existingProductWeightUnitLabel.AutoSize = false;
            this.existingProductWeightUnitLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.existingProductWeightUnitLabel.Location = new System.Drawing.Point(398, 128);
            this.existingProductWeightUnitLabel.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductWeightUnitLabel.Name = "existingProductWeightUnitLabel";
            this.existingProductWeightUnitLabel.Size = new System.Drawing.Size(36, 21);
            this.existingProductWeightUnitLabel.TabIndex = 20;
            this.existingProductWeightUnitLabel.Values.Text = "pcs";
            // 
            // existingProductAmountTextBox
            // 
            this.existingProductAmountTextBox.Location = new System.Drawing.Point(164, 128);
            this.existingProductAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductAmountTextBox.Name = "existingProductAmountTextBox";
            this.existingProductAmountTextBox.Size = new System.Drawing.Size(215, 27);
            this.existingProductAmountTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductAmountTextBox.StateCommon.Border.Rounding = 5;
            this.existingProductAmountTextBox.TabIndex = 2;
            // 
            // existingProductWeightUnitComboBox
            // 
            this.existingProductWeightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingProductWeightUnitComboBox.DropDownWidth = 61;
            this.existingProductWeightUnitComboBox.Location = new System.Drawing.Point(390, 126);
            this.existingProductWeightUnitComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.existingProductWeightUnitComboBox.Name = "existingProductWeightUnitComboBox";
            this.existingProductWeightUnitComboBox.Size = new System.Drawing.Size(81, 25);
            this.existingProductWeightUnitComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.existingProductWeightUnitComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductWeightUnitComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            this.existingProductWeightUnitComboBox.TabIndex = 6;
            this.existingProductWeightUnitComboBox.Visible = false;
            // 
            // newProductPage
            // 
            this.newProductPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.newProductPage.Controls.Add(this.newProductSupplierInfoGroupBox);
            this.newProductPage.Controls.Add(this.newProductProductInfoGroupBox);
            this.newProductPage.Flags = 65534;
            this.newProductPage.LastVisibleSet = true;
            this.newProductPage.Margin = new System.Windows.Forms.Padding(4);
            this.newProductPage.MinimumSize = new System.Drawing.Size(67, 66);
            this.newProductPage.Name = "newProductPage";
            this.newProductPage.Size = new System.Drawing.Size(519, 474);
            this.newProductPage.StateCommon.Page.Color1 = System.Drawing.Color.WhiteSmoke;
            this.newProductPage.Text = "New Product";
            this.newProductPage.ToolTipTitle = "Page ToolTip";
            this.newProductPage.UniqueName = "383dfda8b9b44f2aa16c37bb0fa934c8";
            // 
            // newProductSupplierInfoGroupBox
            // 
            this.newProductSupplierInfoGroupBox.Controls.Add(this.newProductPurchasePriceTextBox);
            this.newProductSupplierInfoGroupBox.Controls.Add(this.newProductPurchasePriceLabel);
            this.newProductSupplierInfoGroupBox.Controls.Add(this.newProductSupplierLabel);
            this.newProductSupplierInfoGroupBox.Controls.Add(this.newProductSupplierComboBox);
            this.newProductSupplierInfoGroupBox.Controls.Add(this.addNewProductButton);
            this.newProductSupplierInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newProductSupplierInfoGroupBox.Location = new System.Drawing.Point(0, 206);
            this.newProductSupplierInfoGroupBox.Name = "newProductSupplierInfoGroupBox";
            this.newProductSupplierInfoGroupBox.Size = new System.Drawing.Size(519, 268);
            this.newProductSupplierInfoGroupBox.TabIndex = 1;
            this.newProductSupplierInfoGroupBox.TabStop = false;
            this.newProductSupplierInfoGroupBox.Text = "Supplier Info";
            // 
            // newProductPurchasePriceTextBox
            // 
            this.newProductPurchasePriceTextBox.Location = new System.Drawing.Point(162, 82);
            this.newProductPurchasePriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newProductPurchasePriceTextBox.Name = "newProductPurchasePriceTextBox";
            this.newProductPurchasePriceTextBox.Size = new System.Drawing.Size(215, 27);
            this.newProductPurchasePriceTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductPurchasePriceTextBox.StateCommon.Border.Rounding = 5;
            this.newProductPurchasePriceTextBox.TabIndex = 1;
            // 
            // newProductPurchasePriceLabel
            // 
            this.newProductPurchasePriceLabel.Location = new System.Drawing.Point(16, 82);
            this.newProductPurchasePriceLabel.Margin = new System.Windows.Forms.Padding(4);
            this.newProductPurchasePriceLabel.Name = "newProductPurchasePriceLabel";
            this.newProductPurchasePriceLabel.Size = new System.Drawing.Size(92, 20);
            this.newProductPurchasePriceLabel.TabIndex = 22;
            this.newProductPurchasePriceLabel.Values.Text = "Purchase Price:";
            // 
            // newProductSupplierLabel
            // 
            this.newProductSupplierLabel.Location = new System.Drawing.Point(16, 36);
            this.newProductSupplierLabel.Margin = new System.Windows.Forms.Padding(4);
            this.newProductSupplierLabel.Name = "newProductSupplierLabel";
            this.newProductSupplierLabel.Size = new System.Drawing.Size(58, 20);
            this.newProductSupplierLabel.TabIndex = 4;
            this.newProductSupplierLabel.Values.Text = "Supplier:";
            // 
            // newProductSupplierComboBox
            // 
            this.newProductSupplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newProductSupplierComboBox.DropDownWidth = 161;
            this.newProductSupplierComboBox.Location = new System.Drawing.Point(162, 35);
            this.newProductSupplierComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.newProductSupplierComboBox.Name = "newProductSupplierComboBox";
            this.newProductSupplierComboBox.Size = new System.Drawing.Size(215, 25);
            this.newProductSupplierComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductSupplierComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            this.newProductSupplierComboBox.TabIndex = 0;
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Location = new System.Drawing.Point(348, 160);
            this.addNewProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(120, 33);
            this.addNewProductButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addNewProductButton.StateCommon.Border.Rounding = 5;
            this.addNewProductButton.TabIndex = 2;
            this.addNewProductButton.Values.Text = "Add";
            this.addNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // newProductProductInfoGroupBox
            // 
            this.newProductProductInfoGroupBox.Controls.Add(this.newProductNameLabel);
            this.newProductProductInfoGroupBox.Controls.Add(this.newProductPriceLabel);
            this.newProductProductInfoGroupBox.Controls.Add(this.newProductAmountTextBox);
            this.newProductProductInfoGroupBox.Controls.Add(this.newProductWeightUnitLabel);
            this.newProductProductInfoGroupBox.Controls.Add(this.newProductAmountLabel);
            this.newProductProductInfoGroupBox.Controls.Add(this.newProductPriceTextBox);
            this.newProductProductInfoGroupBox.Controls.Add(this.newProductNameTextBox);
            this.newProductProductInfoGroupBox.Controls.Add(this.newProductWeightUnitComboBox);
            this.newProductProductInfoGroupBox.Controls.Add(this.productTypeLabel);
            this.newProductProductInfoGroupBox.Controls.Add(this.newProductTypeComboBox);
            this.newProductProductInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.newProductProductInfoGroupBox.Location = new System.Drawing.Point(0, 0);
            this.newProductProductInfoGroupBox.Name = "newProductProductInfoGroupBox";
            this.newProductProductInfoGroupBox.Size = new System.Drawing.Size(519, 206);
            this.newProductProductInfoGroupBox.TabIndex = 0;
            this.newProductProductInfoGroupBox.TabStop = false;
            this.newProductProductInfoGroupBox.Text = "Product Info";
            // 
            // newProductNameLabel
            // 
            this.newProductNameLabel.Location = new System.Drawing.Point(16, 30);
            this.newProductNameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.newProductNameLabel.Name = "newProductNameLabel";
            this.newProductNameLabel.Size = new System.Drawing.Size(46, 20);
            this.newProductNameLabel.TabIndex = 6;
            this.newProductNameLabel.Values.Text = "Name:";
            // 
            // newProductPriceLabel
            // 
            this.newProductPriceLabel.Location = new System.Drawing.Point(16, 73);
            this.newProductPriceLabel.Margin = new System.Windows.Forms.Padding(4);
            this.newProductPriceLabel.Name = "newProductPriceLabel";
            this.newProductPriceLabel.Size = new System.Drawing.Size(40, 20);
            this.newProductPriceLabel.TabIndex = 7;
            this.newProductPriceLabel.Values.Text = "Price:";
            // 
            // newProductAmountTextBox
            // 
            this.newProductAmountTextBox.Location = new System.Drawing.Point(162, 158);
            this.newProductAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newProductAmountTextBox.Name = "newProductAmountTextBox";
            this.newProductAmountTextBox.Size = new System.Drawing.Size(215, 27);
            this.newProductAmountTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductAmountTextBox.StateCommon.Border.Rounding = 5;
            this.newProductAmountTextBox.TabIndex = 3;
            // 
            // newProductWeightUnitLabel
            // 
            this.newProductWeightUnitLabel.AutoSize = false;
            this.newProductWeightUnitLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.newProductWeightUnitLabel.Location = new System.Drawing.Point(409, 159);
            this.newProductWeightUnitLabel.Margin = new System.Windows.Forms.Padding(4);
            this.newProductWeightUnitLabel.Name = "newProductWeightUnitLabel";
            this.newProductWeightUnitLabel.Size = new System.Drawing.Size(35, 20);
            this.newProductWeightUnitLabel.TabIndex = 19;
            this.newProductWeightUnitLabel.Values.Text = "pcs";
            // 
            // newProductAmountLabel
            // 
            this.newProductAmountLabel.Location = new System.Drawing.Point(17, 155);
            this.newProductAmountLabel.Margin = new System.Windows.Forms.Padding(4);
            this.newProductAmountLabel.Name = "newProductAmountLabel";
            this.newProductAmountLabel.Size = new System.Drawing.Size(57, 20);
            this.newProductAmountLabel.TabIndex = 8;
            this.newProductAmountLabel.Values.Text = "Amount:";
            // 
            // newProductPriceTextBox
            // 
            this.newProductPriceTextBox.Location = new System.Drawing.Point(162, 73);
            this.newProductPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newProductPriceTextBox.Name = "newProductPriceTextBox";
            this.newProductPriceTextBox.Size = new System.Drawing.Size(215, 27);
            this.newProductPriceTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductPriceTextBox.StateCommon.Border.Rounding = 5;
            this.newProductPriceTextBox.TabIndex = 1;
            // 
            // newProductNameTextBox
            // 
            this.newProductNameTextBox.Location = new System.Drawing.Point(161, 30);
            this.newProductNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newProductNameTextBox.Name = "newProductNameTextBox";
            this.newProductNameTextBox.Size = new System.Drawing.Size(215, 27);
            this.newProductNameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductNameTextBox.StateCommon.Border.Rounding = 5;
            this.newProductNameTextBox.TabIndex = 0;
            // 
            // newProductWeightUnitComboBox
            // 
            this.newProductWeightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newProductWeightUnitComboBox.DropDownWidth = 121;
            this.newProductWeightUnitComboBox.Location = new System.Drawing.Point(398, 157);
            this.newProductWeightUnitComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.newProductWeightUnitComboBox.Name = "newProductWeightUnitComboBox";
            this.newProductWeightUnitComboBox.Size = new System.Drawing.Size(81, 25);
            this.newProductWeightUnitComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.newProductWeightUnitComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductWeightUnitComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            this.newProductWeightUnitComboBox.TabIndex = 18;
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.Location = new System.Drawing.Point(16, 115);
            this.productTypeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(39, 20);
            this.productTypeLabel.TabIndex = 16;
            this.productTypeLabel.Values.Text = "Type:";
            // 
            // newProductTypeComboBox
            // 
            this.newProductTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newProductTypeComboBox.DropDownWidth = 161;
            this.newProductTypeComboBox.Items.AddRange(new object[] {
            "Countable",
            "Uncountable"});
            this.newProductTypeComboBox.Location = new System.Drawing.Point(161, 115);
            this.newProductTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.newProductTypeComboBox.Name = "newProductTypeComboBox";
            this.newProductTypeComboBox.Size = new System.Drawing.Size(215, 25);
            this.newProductTypeComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductTypeComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            this.newProductTypeComboBox.TabIndex = 2;
            this.newProductTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.NewProductTypeComboBox_SelectedIndexChanged);
            // 
            // addProductTypePanel
            // 
            this.addProductTypePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductTypePanel.AutoSize = true;
            this.addProductTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addProductTypePanel.Controls.Add(this.existingProductRadioButton);
            this.addProductTypePanel.Controls.Add(this.newProductRadioButton);
            this.addProductTypePanel.Location = new System.Drawing.Point(32, 37);
            this.addProductTypePanel.Name = "addProductTypePanel";
            this.addProductTypePanel.Size = new System.Drawing.Size(200, 103);
            this.addProductTypePanel.TabIndex = 1;
            // 
            // addProductPanel
            // 
            this.addProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addProductPanel.Controls.Add(this.addProductNavigator);
            this.addProductPanel.Location = new System.Drawing.Point(301, 37);
            this.addProductPanel.Name = "addProductPanel";
            this.addProductPanel.Size = new System.Drawing.Size(523, 478);
            this.addProductPanel.TabIndex = 0;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(836, 545);
            this.Controls.Add(this.addProductPanel);
            this.Controls.Add(this.addProductTypePanel);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.addProductNavigator)).EndInit();
            this.addProductNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.existingProductPage)).EndInit();
            this.existingProductPage.ResumeLayout(false);
            this.existingProductSupplierInfoGroupBox.ResumeLayout(false);
            this.existingProductSupplierInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingProductSupplierComboBox)).EndInit();
            this.existingProductInfoGroupBox.ResumeLayout(false);
            this.existingProductInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingProductComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.existingProductWeightUnitComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductPage)).EndInit();
            this.newProductPage.ResumeLayout(false);
            this.newProductSupplierInfoGroupBox.ResumeLayout(false);
            this.newProductSupplierInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProductSupplierComboBox)).EndInit();
            this.newProductProductInfoGroupBox.ResumeLayout(false);
            this.newProductProductInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProductWeightUnitComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductTypeComboBox)).EndInit();
            this.addProductTypePanel.ResumeLayout(false);
            this.addProductTypePanel.PerformLayout();
            this.addProductPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton existingProductRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton newProductRadioButton;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator addProductNavigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage existingProductPage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox existingProductAmountTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox existingProductComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox existingProductPriceTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductAmountLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductPriceLabel;
        private ComponentFactory.Krypton.Navigator.KryptonPage newProductPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel productTypeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newProductNameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newProductAmountTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newProductPriceTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductAmountLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductPriceLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox newProductTypeComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox existingProductWeightUnitComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox newProductWeightUnitComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductWeightUnitLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductWeightUnitLabel;
        private System.Windows.Forms.Panel addProductTypePanel;
        private System.Windows.Forms.Panel addProductPanel;
        private System.Windows.Forms.GroupBox existingProductSupplierInfoGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox existingProductPurchasePriceTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductPurchasePriceAddProductLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductSupplierLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox existingProductSupplierComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addExistingProductButton;
        private System.Windows.Forms.GroupBox existingProductInfoGroupBox;
        private System.Windows.Forms.GroupBox newProductProductInfoGroupBox;
        private System.Windows.Forms.GroupBox newProductSupplierInfoGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductPurchasePriceLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductSupplierLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox newProductSupplierComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addNewProductButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newProductPurchasePriceTextBox;
    }
}
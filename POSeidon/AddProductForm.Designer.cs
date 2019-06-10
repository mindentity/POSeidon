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
            resources.ApplyResources(this.existingProductRadioButton, "existingProductRadioButton");
            this.existingProductRadioButton.Name = "existingProductRadioButton";
            this.existingProductRadioButton.TabStop = false;
            this.existingProductRadioButton.Values.Text = resources.GetString("existingProductRadioButton.Values.Text");
            this.existingProductRadioButton.CheckedChanged += new System.EventHandler(this.ExistingProductRadioButton_CheckedChanged);
            // 
            // newProductRadioButton
            // 
            resources.ApplyResources(this.newProductRadioButton, "newProductRadioButton");
            this.newProductRadioButton.Name = "newProductRadioButton";
            this.newProductRadioButton.TabStop = false;
            this.newProductRadioButton.Values.Text = resources.GetString("newProductRadioButton.Values.Text");
            // 
            // addProductNavigator
            // 
            resources.ApplyResources(this.addProductNavigator, "addProductNavigator");
            this.addProductNavigator.Name = "addProductNavigator";
            this.addProductNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.Panel;
            this.addProductNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.existingProductPage,
            this.newProductPage});
            this.addProductNavigator.SelectedIndex = 0;
            // 
            // existingProductPage
            // 
            this.existingProductPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.existingProductPage.Controls.Add(this.existingProductSupplierInfoGroupBox);
            this.existingProductPage.Controls.Add(this.existingProductInfoGroupBox);
            this.existingProductPage.Flags = 65534;
            this.existingProductPage.LastVisibleSet = true;
            resources.ApplyResources(this.existingProductPage, "existingProductPage");
            this.existingProductPage.Name = "existingProductPage";
            this.existingProductPage.StateCommon.Page.Color1 = System.Drawing.Color.WhiteSmoke;
            this.existingProductPage.UniqueName = "c78de74bec554c85b82c5e889b4bd26f";
            // 
            // existingProductSupplierInfoGroupBox
            // 
            this.existingProductSupplierInfoGroupBox.Controls.Add(this.existingProductPurchasePriceTextBox);
            this.existingProductSupplierInfoGroupBox.Controls.Add(this.existingProductPurchasePriceAddProductLabel);
            this.existingProductSupplierInfoGroupBox.Controls.Add(this.existingProductSupplierLabel);
            this.existingProductSupplierInfoGroupBox.Controls.Add(this.existingProductSupplierComboBox);
            this.existingProductSupplierInfoGroupBox.Controls.Add(this.addExistingProductButton);
            resources.ApplyResources(this.existingProductSupplierInfoGroupBox, "existingProductSupplierInfoGroupBox");
            this.existingProductSupplierInfoGroupBox.Name = "existingProductSupplierInfoGroupBox";
            this.existingProductSupplierInfoGroupBox.TabStop = false;
            // 
            // existingProductPurchasePriceTextBox
            // 
            resources.ApplyResources(this.existingProductPurchasePriceTextBox, "existingProductPurchasePriceTextBox");
            this.existingProductPurchasePriceTextBox.Name = "existingProductPurchasePriceTextBox";
            this.existingProductPurchasePriceTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductPurchasePriceTextBox.StateCommon.Border.Rounding = 5;
            // 
            // existingProductPurchasePriceAddProductLabel
            // 
            resources.ApplyResources(this.existingProductPurchasePriceAddProductLabel, "existingProductPurchasePriceAddProductLabel");
            this.existingProductPurchasePriceAddProductLabel.Name = "existingProductPurchasePriceAddProductLabel";
            this.existingProductPurchasePriceAddProductLabel.Values.Text = resources.GetString("existingProductPurchasePriceAddProductLabel.Values.Text");
            // 
            // existingProductSupplierLabel
            // 
            resources.ApplyResources(this.existingProductSupplierLabel, "existingProductSupplierLabel");
            this.existingProductSupplierLabel.Name = "existingProductSupplierLabel";
            this.existingProductSupplierLabel.Values.Text = resources.GetString("existingProductSupplierLabel.Values.Text");
            // 
            // existingProductSupplierComboBox
            // 
            this.existingProductSupplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingProductSupplierComboBox.DropDownWidth = 161;
            resources.ApplyResources(this.existingProductSupplierComboBox, "existingProductSupplierComboBox");
            this.existingProductSupplierComboBox.Name = "existingProductSupplierComboBox";
            this.existingProductSupplierComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductSupplierComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            // 
            // addExistingProductButton
            // 
            resources.ApplyResources(this.addExistingProductButton, "addExistingProductButton");
            this.addExistingProductButton.Name = "addExistingProductButton";
            this.addExistingProductButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addExistingProductButton.StateCommon.Border.Rounding = 5;
            this.addExistingProductButton.Values.Text = resources.GetString("addExistingProductButton.Values.Text");
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
            resources.ApplyResources(this.existingProductInfoGroupBox, "existingProductInfoGroupBox");
            this.existingProductInfoGroupBox.Name = "existingProductInfoGroupBox";
            this.existingProductInfoGroupBox.TabStop = false;
            // 
            // existingProductPriceLabel
            // 
            resources.ApplyResources(this.existingProductPriceLabel, "existingProductPriceLabel");
            this.existingProductPriceLabel.Name = "existingProductPriceLabel";
            this.existingProductPriceLabel.Values.Text = resources.GetString("existingProductPriceLabel.Values.Text");
            // 
            // existingProductNameLabel
            // 
            resources.ApplyResources(this.existingProductNameLabel, "existingProductNameLabel");
            this.existingProductNameLabel.Name = "existingProductNameLabel";
            this.existingProductNameLabel.Values.Text = resources.GetString("existingProductNameLabel.Values.Text");
            // 
            // existingProductAmountLabel
            // 
            resources.ApplyResources(this.existingProductAmountLabel, "existingProductAmountLabel");
            this.existingProductAmountLabel.Name = "existingProductAmountLabel";
            this.existingProductAmountLabel.Values.Text = resources.GetString("existingProductAmountLabel.Values.Text");
            // 
            // existingProductPriceTextBox
            // 
            resources.ApplyResources(this.existingProductPriceTextBox, "existingProductPriceTextBox");
            this.existingProductPriceTextBox.Name = "existingProductPriceTextBox";
            this.existingProductPriceTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductPriceTextBox.StateCommon.Border.Rounding = 5;
            // 
            // existingProductComboBox
            // 
            this.existingProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingProductComboBox.DropDownWidth = 161;
            resources.ApplyResources(this.existingProductComboBox, "existingProductComboBox");
            this.existingProductComboBox.Name = "existingProductComboBox";
            this.existingProductComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            this.existingProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ExistingProductComboBox_SelectedIndexChanged);
            // 
            // existingProductWeightUnitLabel
            // 
            resources.ApplyResources(this.existingProductWeightUnitLabel, "existingProductWeightUnitLabel");
            this.existingProductWeightUnitLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.existingProductWeightUnitLabel.Name = "existingProductWeightUnitLabel";
            this.existingProductWeightUnitLabel.Values.Text = resources.GetString("existingProductWeightUnitLabel.Values.Text");
            // 
            // existingProductAmountTextBox
            // 
            resources.ApplyResources(this.existingProductAmountTextBox, "existingProductAmountTextBox");
            this.existingProductAmountTextBox.Name = "existingProductAmountTextBox";
            this.existingProductAmountTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductAmountTextBox.StateCommon.Border.Rounding = 5;
            // 
            // existingProductWeightUnitComboBox
            // 
            this.existingProductWeightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingProductWeightUnitComboBox.DropDownWidth = 61;
            resources.ApplyResources(this.existingProductWeightUnitComboBox, "existingProductWeightUnitComboBox");
            this.existingProductWeightUnitComboBox.Name = "existingProductWeightUnitComboBox";
            this.existingProductWeightUnitComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.existingProductWeightUnitComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.existingProductWeightUnitComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            // 
            // newProductPage
            // 
            this.newProductPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.newProductPage.Controls.Add(this.newProductSupplierInfoGroupBox);
            this.newProductPage.Controls.Add(this.newProductProductInfoGroupBox);
            this.newProductPage.Flags = 65534;
            this.newProductPage.LastVisibleSet = true;
            resources.ApplyResources(this.newProductPage, "newProductPage");
            this.newProductPage.Name = "newProductPage";
            this.newProductPage.StateCommon.Page.Color1 = System.Drawing.Color.WhiteSmoke;
            this.newProductPage.UniqueName = "383dfda8b9b44f2aa16c37bb0fa934c8";
            // 
            // newProductSupplierInfoGroupBox
            // 
            this.newProductSupplierInfoGroupBox.Controls.Add(this.newProductPurchasePriceTextBox);
            this.newProductSupplierInfoGroupBox.Controls.Add(this.newProductPurchasePriceLabel);
            this.newProductSupplierInfoGroupBox.Controls.Add(this.newProductSupplierLabel);
            this.newProductSupplierInfoGroupBox.Controls.Add(this.newProductSupplierComboBox);
            this.newProductSupplierInfoGroupBox.Controls.Add(this.addNewProductButton);
            resources.ApplyResources(this.newProductSupplierInfoGroupBox, "newProductSupplierInfoGroupBox");
            this.newProductSupplierInfoGroupBox.Name = "newProductSupplierInfoGroupBox";
            this.newProductSupplierInfoGroupBox.TabStop = false;
            // 
            // newProductPurchasePriceTextBox
            // 
            resources.ApplyResources(this.newProductPurchasePriceTextBox, "newProductPurchasePriceTextBox");
            this.newProductPurchasePriceTextBox.Name = "newProductPurchasePriceTextBox";
            this.newProductPurchasePriceTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductPurchasePriceTextBox.StateCommon.Border.Rounding = 5;
            // 
            // newProductPurchasePriceLabel
            // 
            resources.ApplyResources(this.newProductPurchasePriceLabel, "newProductPurchasePriceLabel");
            this.newProductPurchasePriceLabel.Name = "newProductPurchasePriceLabel";
            this.newProductPurchasePriceLabel.Values.Text = resources.GetString("newProductPurchasePriceLabel.Values.Text");
            // 
            // newProductSupplierLabel
            // 
            resources.ApplyResources(this.newProductSupplierLabel, "newProductSupplierLabel");
            this.newProductSupplierLabel.Name = "newProductSupplierLabel";
            this.newProductSupplierLabel.Values.Text = resources.GetString("newProductSupplierLabel.Values.Text");
            // 
            // newProductSupplierComboBox
            // 
            this.newProductSupplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newProductSupplierComboBox.DropDownWidth = 161;
            resources.ApplyResources(this.newProductSupplierComboBox, "newProductSupplierComboBox");
            this.newProductSupplierComboBox.Name = "newProductSupplierComboBox";
            this.newProductSupplierComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductSupplierComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            // 
            // addNewProductButton
            // 
            resources.ApplyResources(this.addNewProductButton, "addNewProductButton");
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addNewProductButton.StateCommon.Border.Rounding = 5;
            this.addNewProductButton.Values.Text = resources.GetString("addNewProductButton.Values.Text");
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
            resources.ApplyResources(this.newProductProductInfoGroupBox, "newProductProductInfoGroupBox");
            this.newProductProductInfoGroupBox.Name = "newProductProductInfoGroupBox";
            this.newProductProductInfoGroupBox.TabStop = false;
            // 
            // newProductNameLabel
            // 
            resources.ApplyResources(this.newProductNameLabel, "newProductNameLabel");
            this.newProductNameLabel.Name = "newProductNameLabel";
            this.newProductNameLabel.Values.Text = resources.GetString("newProductNameLabel.Values.Text");
            // 
            // newProductPriceLabel
            // 
            resources.ApplyResources(this.newProductPriceLabel, "newProductPriceLabel");
            this.newProductPriceLabel.Name = "newProductPriceLabel";
            this.newProductPriceLabel.Values.Text = resources.GetString("newProductPriceLabel.Values.Text");
            // 
            // newProductAmountTextBox
            // 
            resources.ApplyResources(this.newProductAmountTextBox, "newProductAmountTextBox");
            this.newProductAmountTextBox.Name = "newProductAmountTextBox";
            this.newProductAmountTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductAmountTextBox.StateCommon.Border.Rounding = 5;
            // 
            // newProductWeightUnitLabel
            // 
            resources.ApplyResources(this.newProductWeightUnitLabel, "newProductWeightUnitLabel");
            this.newProductWeightUnitLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.newProductWeightUnitLabel.Name = "newProductWeightUnitLabel";
            this.newProductWeightUnitLabel.Values.Text = resources.GetString("newProductWeightUnitLabel.Values.Text");
            // 
            // newProductAmountLabel
            // 
            resources.ApplyResources(this.newProductAmountLabel, "newProductAmountLabel");
            this.newProductAmountLabel.Name = "newProductAmountLabel";
            this.newProductAmountLabel.Values.Text = resources.GetString("newProductAmountLabel.Values.Text");
            // 
            // newProductPriceTextBox
            // 
            resources.ApplyResources(this.newProductPriceTextBox, "newProductPriceTextBox");
            this.newProductPriceTextBox.Name = "newProductPriceTextBox";
            this.newProductPriceTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductPriceTextBox.StateCommon.Border.Rounding = 5;
            // 
            // newProductNameTextBox
            // 
            resources.ApplyResources(this.newProductNameTextBox, "newProductNameTextBox");
            this.newProductNameTextBox.Name = "newProductNameTextBox";
            this.newProductNameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductNameTextBox.StateCommon.Border.Rounding = 5;
            // 
            // newProductWeightUnitComboBox
            // 
            this.newProductWeightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newProductWeightUnitComboBox.DropDownWidth = 121;
            resources.ApplyResources(this.newProductWeightUnitComboBox, "newProductWeightUnitComboBox");
            this.newProductWeightUnitComboBox.Name = "newProductWeightUnitComboBox";
            this.newProductWeightUnitComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.newProductWeightUnitComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductWeightUnitComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            // 
            // productTypeLabel
            // 
            resources.ApplyResources(this.productTypeLabel, "productTypeLabel");
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Values.Text = resources.GetString("productTypeLabel.Values.Text");
            // 
            // newProductTypeComboBox
            // 
            this.newProductTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newProductTypeComboBox.DropDownWidth = 161;
            this.newProductTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("newProductTypeComboBox.Items"),
            resources.GetString("newProductTypeComboBox.Items1")});
            resources.ApplyResources(this.newProductTypeComboBox, "newProductTypeComboBox");
            this.newProductTypeComboBox.Name = "newProductTypeComboBox";
            this.newProductTypeComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newProductTypeComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            this.newProductTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.NewProductTypeComboBox_SelectedIndexChanged);
            // 
            // addProductTypePanel
            // 
            resources.ApplyResources(this.addProductTypePanel, "addProductTypePanel");
            this.addProductTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addProductTypePanel.Controls.Add(this.existingProductRadioButton);
            this.addProductTypePanel.Controls.Add(this.newProductRadioButton);
            this.addProductTypePanel.Name = "addProductTypePanel";
            // 
            // addProductPanel
            // 
            this.addProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addProductPanel.Controls.Add(this.addProductNavigator);
            resources.ApplyResources(this.addProductPanel, "addProductPanel");
            this.addProductPanel.Name = "addProductPanel";
            // 
            // AddProductForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.addProductPanel);
            this.Controls.Add(this.addProductTypePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
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
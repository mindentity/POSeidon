﻿namespace POSeidon
{
    partial class addProductForm
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
            this.existingProductRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.newProductRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.addProductNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.existingProductPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.existingProductUnitLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.existingProductCurrency = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.existingProductAmountTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.existingProductComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.existingProductPriceTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.existingProductAmountLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.existingProductNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.existingProductPriceLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.newProductTypeComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.productTypeLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newProductUnitLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductCurrencyLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductAmountTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newProductPriceTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newProductAmountLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newProductPriceLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addProductButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.productSupplierLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.productSupplierComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.addProductNavigator)).BeginInit();
            this.addProductNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingProductPage)).BeginInit();
            this.existingProductPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingProductComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductPage)).BeginInit();
            this.newProductPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProductTypeComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // existingProductRadioButton
            // 
            this.existingProductRadioButton.Checked = true;
            this.existingProductRadioButton.Location = new System.Drawing.Point(87, 12);
            this.existingProductRadioButton.Name = "existingProductRadioButton";
            this.existingProductRadioButton.Size = new System.Drawing.Size(110, 20);
            this.existingProductRadioButton.TabIndex = 0;
            this.existingProductRadioButton.Values.Text = "Existing product";
            this.existingProductRadioButton.CheckedChanged += new System.EventHandler(this.ExistingProductRadioButton_CheckedChanged);
            // 
            // newProductRadioButton
            // 
            this.newProductRadioButton.Location = new System.Drawing.Point(87, 51);
            this.newProductRadioButton.Name = "newProductRadioButton";
            this.newProductRadioButton.Size = new System.Drawing.Size(93, 20);
            this.newProductRadioButton.TabIndex = 1;
            this.newProductRadioButton.Values.Text = "New product";
            // 
            // addProductNavigator
            // 
            this.addProductNavigator.Location = new System.Drawing.Point(87, 86);
            this.addProductNavigator.Name = "addProductNavigator";
            this.addProductNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.Panel;
            this.addProductNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.existingProductPage,
            this.newProductPage});
            this.addProductNavigator.SelectedIndex = 0;
            this.addProductNavigator.Size = new System.Drawing.Size(380, 246);
            this.addProductNavigator.TabIndex = 2;
            // 
            // existingProductPage
            // 
            this.existingProductPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.existingProductPage.Controls.Add(this.existingProductUnitLabel);
            this.existingProductPage.Controls.Add(this.existingProductCurrency);
            this.existingProductPage.Controls.Add(this.existingProductAmountTextBox);
            this.existingProductPage.Controls.Add(this.existingProductComboBox);
            this.existingProductPage.Controls.Add(this.existingProductPriceTextBox);
            this.existingProductPage.Controls.Add(this.existingProductAmountLabel);
            this.existingProductPage.Controls.Add(this.existingProductNameLabel);
            this.existingProductPage.Controls.Add(this.existingProductPriceLabel);
            this.existingProductPage.Flags = 65534;
            this.existingProductPage.LastVisibleSet = true;
            this.existingProductPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.existingProductPage.Name = "existingProductPage";
            this.existingProductPage.Size = new System.Drawing.Size(380, 246);
            this.existingProductPage.Text = "Existing Product";
            this.existingProductPage.ToolTipTitle = "Page ToolTip";
            this.existingProductPage.UniqueName = "c78de74bec554c85b82c5e889b4bd26f";
            // 
            // existingProductUnitLabel
            // 
            this.existingProductUnitLabel.Location = new System.Drawing.Point(299, 104);
            this.existingProductUnitLabel.Name = "existingProductUnitLabel";
            this.existingProductUnitLabel.Size = new System.Drawing.Size(33, 20);
            this.existingProductUnitLabel.TabIndex = 7;
            this.existingProductUnitLabel.Values.Text = "Unit";
            // 
            // existingProductCurrency
            // 
            this.existingProductCurrency.Location = new System.Drawing.Point(299, 54);
            this.existingProductCurrency.Name = "existingProductCurrency";
            this.existingProductCurrency.Size = new System.Drawing.Size(59, 20);
            this.existingProductCurrency.TabIndex = 6;
            this.existingProductCurrency.Values.Text = "Currency";
            // 
            // existingProductAmountTextBox
            // 
            this.existingProductAmountTextBox.Location = new System.Drawing.Point(133, 101);
            this.existingProductAmountTextBox.Name = "existingProductAmountTextBox";
            this.existingProductAmountTextBox.Size = new System.Drawing.Size(161, 23);
            this.existingProductAmountTextBox.TabIndex = 2;
            // 
            // existingProductComboBox
            // 
            this.existingProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingProductComboBox.DropDownWidth = 161;
            this.existingProductComboBox.Location = new System.Drawing.Point(133, 12);
            this.existingProductComboBox.Name = "existingProductComboBox";
            this.existingProductComboBox.Size = new System.Drawing.Size(161, 21);
            this.existingProductComboBox.TabIndex = 0;
            this.existingProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ExistingProductComboBox_SelectedIndexChanged);
            // 
            // existingProductPriceTextBox
            // 
            this.existingProductPriceTextBox.Location = new System.Drawing.Point(133, 51);
            this.existingProductPriceTextBox.Name = "existingProductPriceTextBox";
            this.existingProductPriceTextBox.Size = new System.Drawing.Size(161, 23);
            this.existingProductPriceTextBox.TabIndex = 1;
            // 
            // existingProductAmountLabel
            // 
            this.existingProductAmountLabel.Location = new System.Drawing.Point(23, 104);
            this.existingProductAmountLabel.Name = "existingProductAmountLabel";
            this.existingProductAmountLabel.Size = new System.Drawing.Size(57, 20);
            this.existingProductAmountLabel.TabIndex = 5;
            this.existingProductAmountLabel.Values.Text = "Amount:";
            // 
            // existingProductNameLabel
            // 
            this.existingProductNameLabel.Location = new System.Drawing.Point(23, 13);
            this.existingProductNameLabel.Name = "existingProductNameLabel";
            this.existingProductNameLabel.Size = new System.Drawing.Size(46, 20);
            this.existingProductNameLabel.TabIndex = 3;
            this.existingProductNameLabel.Values.Text = "Name:";
            // 
            // existingProductPriceLabel
            // 
            this.existingProductPriceLabel.Location = new System.Drawing.Point(23, 54);
            this.existingProductPriceLabel.Name = "existingProductPriceLabel";
            this.existingProductPriceLabel.Size = new System.Drawing.Size(40, 20);
            this.existingProductPriceLabel.TabIndex = 4;
            this.existingProductPriceLabel.Values.Text = "Price:";
            // 
            // newProductPage
            // 
            this.newProductPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.newProductPage.Controls.Add(this.newProductTypeComboBox);
            this.newProductPage.Controls.Add(this.productTypeLabel);
            this.newProductPage.Controls.Add(this.newProductTextBox);
            this.newProductPage.Controls.Add(this.newProductUnitLabel);
            this.newProductPage.Controls.Add(this.newProductCurrencyLabel);
            this.newProductPage.Controls.Add(this.newProductAmountTextBox);
            this.newProductPage.Controls.Add(this.newProductPriceTextBox);
            this.newProductPage.Controls.Add(this.newProductAmountLabel);
            this.newProductPage.Controls.Add(this.newProductNameLabel);
            this.newProductPage.Controls.Add(this.newProductPriceLabel);
            this.newProductPage.Flags = 65534;
            this.newProductPage.LastVisibleSet = true;
            this.newProductPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.newProductPage.Name = "newProductPage";
            this.newProductPage.Size = new System.Drawing.Size(378, 219);
            this.newProductPage.Text = "New Product";
            this.newProductPage.ToolTipTitle = "Page ToolTip";
            this.newProductPage.UniqueName = "383dfda8b9b44f2aa16c37bb0fa934c8";
            // 
            // newProductTypeComboBox
            // 
            this.newProductTypeComboBox.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.newProductTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newProductTypeComboBox.DropDownWidth = 161;
            this.newProductTypeComboBox.Items.AddRange(new object[] {
            "Countable",
            "Uncountable"});
            this.newProductTypeComboBox.Location = new System.Drawing.Point(133, 103);
            this.newProductTypeComboBox.Name = "newProductTypeComboBox";
            this.newProductTypeComboBox.Size = new System.Drawing.Size(161, 21);
            this.newProductTypeComboBox.TabIndex = 17;
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.Location = new System.Drawing.Point(23, 105);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(39, 20);
            this.productTypeLabel.TabIndex = 16;
            this.productTypeLabel.Values.Text = "Type:";
            // 
            // newProductTextBox
            // 
            this.newProductTextBox.Location = new System.Drawing.Point(133, 12);
            this.newProductTextBox.Name = "newProductTextBox";
            this.newProductTextBox.Size = new System.Drawing.Size(161, 23);
            this.newProductTextBox.TabIndex = 14;
            // 
            // newProductUnitLabel
            // 
            this.newProductUnitLabel.Location = new System.Drawing.Point(299, 140);
            this.newProductUnitLabel.Name = "newProductUnitLabel";
            this.newProductUnitLabel.Size = new System.Drawing.Size(33, 20);
            this.newProductUnitLabel.TabIndex = 13;
            this.newProductUnitLabel.Values.Text = "Unit";
            // 
            // newProductCurrencyLabel
            // 
            this.newProductCurrencyLabel.Location = new System.Drawing.Point(299, 54);
            this.newProductCurrencyLabel.Name = "newProductCurrencyLabel";
            this.newProductCurrencyLabel.Size = new System.Drawing.Size(59, 20);
            this.newProductCurrencyLabel.TabIndex = 12;
            this.newProductCurrencyLabel.Values.Text = "Currency";
            // 
            // newProductAmountTextBox
            // 
            this.newProductAmountTextBox.Location = new System.Drawing.Point(133, 137);
            this.newProductAmountTextBox.Name = "newProductAmountTextBox";
            this.newProductAmountTextBox.Size = new System.Drawing.Size(161, 23);
            this.newProductAmountTextBox.TabIndex = 11;
            // 
            // newProductPriceTextBox
            // 
            this.newProductPriceTextBox.Location = new System.Drawing.Point(132, 51);
            this.newProductPriceTextBox.Name = "newProductPriceTextBox";
            this.newProductPriceTextBox.Size = new System.Drawing.Size(161, 23);
            this.newProductPriceTextBox.TabIndex = 10;
            // 
            // newProductAmountLabel
            // 
            this.newProductAmountLabel.Location = new System.Drawing.Point(23, 140);
            this.newProductAmountLabel.Name = "newProductAmountLabel";
            this.newProductAmountLabel.Size = new System.Drawing.Size(57, 20);
            this.newProductAmountLabel.TabIndex = 8;
            this.newProductAmountLabel.Values.Text = "Amount:";
            // 
            // newProductNameLabel
            // 
            this.newProductNameLabel.Location = new System.Drawing.Point(23, 13);
            this.newProductNameLabel.Name = "newProductNameLabel";
            this.newProductNameLabel.Size = new System.Drawing.Size(46, 20);
            this.newProductNameLabel.TabIndex = 6;
            this.newProductNameLabel.Values.Text = "Name:";
            // 
            // newProductPriceLabel
            // 
            this.newProductPriceLabel.Location = new System.Drawing.Point(23, 54);
            this.newProductPriceLabel.Name = "newProductPriceLabel";
            this.newProductPriceLabel.Size = new System.Drawing.Size(40, 20);
            this.newProductPriceLabel.TabIndex = 7;
            this.newProductPriceLabel.Values.Text = "Price:";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(387, 380);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(90, 25);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Values.Text = "Add";
            // 
            // productSupplierLabel
            // 
            this.productSupplierLabel.Location = new System.Drawing.Point(111, 349);
            this.productSupplierLabel.Name = "productSupplierLabel";
            this.productSupplierLabel.Size = new System.Drawing.Size(58, 20);
            this.productSupplierLabel.TabIndex = 4;
            this.productSupplierLabel.Values.Text = "Supplier:";
            // 
            // productSupplierComboBox
            // 
            this.productSupplierComboBox.DropDownWidth = 161;
            this.productSupplierComboBox.Location = new System.Drawing.Point(221, 347);
            this.productSupplierComboBox.Name = "productSupplierComboBox";
            this.productSupplierComboBox.Size = new System.Drawing.Size(161, 21);
            this.productSupplierComboBox.TabIndex = 5;
            // 
            // addProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 417);
            this.Controls.Add(this.productSupplierComboBox);
            this.Controls.Add(this.productSupplierLabel);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.addProductNavigator);
            this.Controls.Add(this.newProductRadioButton);
            this.Controls.Add(this.existingProductRadioButton);
            this.Name = "addProductForm";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.addProductNavigator)).EndInit();
            this.addProductNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.existingProductPage)).EndInit();
            this.existingProductPage.ResumeLayout(false);
            this.existingProductPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.existingProductComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductPage)).EndInit();
            this.newProductPage.ResumeLayout(false);
            this.newProductPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProductTypeComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton existingProductRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton newProductRadioButton;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator addProductNavigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage existingProductPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductUnitLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductCurrency;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox existingProductAmountTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox existingProductComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox existingProductPriceTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductAmountLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel existingProductPriceLabel;
        private ComponentFactory.Krypton.Navigator.KryptonPage newProductPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel productTypeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newProductTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductUnitLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductCurrencyLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newProductAmountTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newProductPriceTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductAmountLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel newProductPriceLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox newProductTypeComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addProductButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel productSupplierLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox productSupplierComboBox;
    }
}
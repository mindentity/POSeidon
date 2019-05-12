﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class addProductForm : Form
    {
        public addProductForm()
        {
            InitializeComponent();
            newProductTypeComboBox.SelectedIndex = 0;
            existingProductComboBox.DataSource = Controller.Products;
            existingProductComboBox.DisplayMember = "Name";
            productSupplierComboBox.DataSource = Controller.Suppliers;
            productSupplierComboBox.DisplayMember = "Name";
        }

        private void ExistingProductRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            KryptonRadioButton rb = sender as KryptonRadioButton;
            if (rb.Checked)
            {
                addProductNavigator.SelectedIndex = 0;
            }
            else
            {
                addProductNavigator.SelectedIndex = 1;
            }
        }

        private void ExistingProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = existingProductComboBox.SelectedItem as Product;
            existingProductPriceTextBox.Text = product.Price.ToString("C");
        }
    }
}

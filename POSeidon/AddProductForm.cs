using ComponentFactory.Krypton.Toolkit;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class addProductForm : Form
    {
        public addProductForm()
        {
            InitializeComponent();
            existingProductWeightUnitComboBox.DataSource = Controller.Settings.AvailableWeightUnits;
            existingProductWeightUnitComboBox.DisplayMember = "Symbol";
            newProductWeightUnitComboBox.DataSource = Controller.Settings.AvailableWeightUnits;
            newProductWeightUnitComboBox.DisplayMember = "Symbol";
            existingProductComboBox.DataSource = Controller.Products;
            existingProductComboBox.DisplayMember = "Name";
            newProductSupplierComboBox.DataSource = Controller.Suppliers;
            newProductSupplierComboBox.DisplayMember = "Name";
            existingProductSupplierComboBox.DataSource = Controller.Suppliers;
            existingProductSupplierComboBox.DisplayMember = "Name";
            newProductTypeComboBox.SelectedIndex = 0;
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
            var product = existingProductComboBox.SelectedItem as Product;
            existingProductPriceTextBox.Text = product.Price.ToString("C");
            existingProductWeightUnitComboBox.SelectedItem = Controller.Settings.WeightUnit;
            existingProductPurchasePriceTextBox.ResetText();
            existingProductAmountTextBox.ResetText();
            if (product.IsCountable)
            {
                existingProductWeightUnitLabel.Show();
                existingProductWeightUnitComboBox.Hide();
            }
            else
            {
                existingProductWeightUnitLabel.Hide();
                existingProductWeightUnitComboBox.Show();
            }
        }

        private void AddExistingProductButton_Click(object sender, EventArgs e)
        {
            var product = existingProductComboBox.SelectedItem as Product;
            decimal productPrice, purchasePrice;
            double amount;
            try
            {
                productPrice = Decimal.Parse(existingProductPriceTextBox.Text, NumberStyles.Currency);
            }
            catch
            {
                MessageBox.Show("Invalid product price!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (productPrice < 0)
            {
                MessageBox.Show("Price cannot be negative!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                amount = Double.Parse(existingProductAmountTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Invalid product amount!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (amount <= 0)
            {
                MessageBox.Show("Product amount must be positive", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                purchasePrice = Decimal.Parse(existingProductPurchasePriceTextBox.Text, NumberStyles.Currency);
            }
            catch
            {
                MessageBox.Show("Invalid purchase price format!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (purchasePrice <= 0)
            {
                MessageBox.Show("Purchase price cannot be negative", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!product.IsCountable)
            {
                var weightUnit = existingProductWeightUnitComboBox.SelectedItem as WeightUnit;
                amount *= weightUnit.Ratio;
            }
            product.Price = productPrice;
            var supplier = newProductSupplierComboBox.SelectedItem as Supplier;
            if (Controller.AddProduct(product, amount, supplier, purchasePrice))
            {
                Controller.Products.ResetBindings();
                MessageBox.Show("Product added successfully.", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                existingProductComboBox.SelectedIndex = 0;
                existingProductPriceTextBox.ResetText();
                existingProductAmountTextBox.ResetText();
                existingProductSupplierComboBox.SelectedIndex = 0;
                existingProductPurchasePriceTextBox.ResetText();
            }
            else
            {
                MessageBox.Show("Failed to add product!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            decimal productPrice, purchasePrice;
            double amount;
            var name = newProductNameTextBox.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Product name cannot be empty!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                productPrice = Decimal.Parse(newProductPriceTextBox.Text, NumberStyles.Currency);
            }
            catch
            {
                MessageBox.Show("Invalid product price!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (productPrice < 0)
            {
                MessageBox.Show("Price cannot be negative!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                amount = Double.Parse(newProductAmountTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Invalid product amount!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (amount <= 0)
            {
                MessageBox.Show("Product amount must be positive", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                purchasePrice = Decimal.Parse(newProductPurchasePriceTextBox.Text, NumberStyles.Currency);
            }
            catch
            {
                MessageBox.Show("Invalid purchase price format!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (purchasePrice <= 0)
            {
                MessageBox.Show("Purchase price cannot be negative", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var isCountable = newProductTypeComboBox.SelectedIndex == 0;
            if (!isCountable)
            {
                var weightUnit = newProductWeightUnitComboBox.SelectedItem as WeightUnit;
                amount *= weightUnit.Ratio;
            }
            var product = new Product
            {
                Name = name,
                Price = productPrice,
                IsCountable = isCountable,
            };
            var supplier = newProductSupplierComboBox.SelectedItem as Supplier;
            if (Controller.AddProduct(product, amount, supplier, purchasePrice))
            {
                Controller.Products.Add(product);
                MessageBox.Show("Product added successfully.", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newProductAmountTextBox.ResetText();
                newProductNameTextBox.ResetText();
                newProductPriceTextBox.ResetText();
                newProductPurchasePriceTextBox.ResetText();
                newProductTypeComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Failed to add product!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewProductTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newProductTypeComboBox.SelectedIndex == 0)
            {
                newProductWeightUnitLabel.Show();
                newProductWeightUnitComboBox.Hide();
            }
            else
            {
                newProductWeightUnitLabel.Hide();
                newProductWeightUnitComboBox.Show();
            }
        }

    }
}

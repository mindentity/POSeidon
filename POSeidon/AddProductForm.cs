using ComponentFactory.Krypton.Toolkit;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            newProductTypeComboBox.SelectedIndex = 0;
            existingProductComboBox.DataSource = Controller.Products;
            existingProductComboBox.DisplayMember = "Name";
            productSupplierComboBox.DataSource = Controller.Suppliers;
            productSupplierComboBox.DisplayMember = "Name";
            existingProductWeightUnitComboBox.DataSource = Controller.Settings.AvailableWeightUnits;
            existingProductWeightUnitComboBox.DisplayMember = "Symbol";
            newProductWeightUnitComboBox.DataSource = Controller.Settings.AvailableWeightUnits;
            newProductWeightUnitComboBox.DisplayMember = "Symbol";
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

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Product product;
            double amount;
            if (existingProductRadioButton.Checked)
            {
                product = existingProductComboBox.SelectedItem as Product;
                var price = Decimal.Parse(existingProductPriceTextBox.Text, NumberStyles.Currency);
                amount = Double.Parse(existingProductAmountTextBox.Text);
                if (!product.IsCountable)
                {
                    var weightUnit = existingProductWeightUnitComboBox.SelectedItem as WeightUnit;
                    amount *= weightUnit.Ratio;
                }
                product.Price = price;
            }
            else
            {
                var name = newProductNameTextBox.Text;
                var price = Decimal.Parse(newProductPriceTextBox.Text, NumberStyles.Currency);
                amount = Double.Parse(newProductAmountTextBox.Text);
                var isCountable = newProductTypeComboBox.SelectedIndex == 0;
                if (!isCountable)
                {
                    var weightUnit = newProductWeightUnitComboBox.SelectedItem as WeightUnit;
                    amount *= weightUnit.Ratio;
                }
                product = new Product
                {
                    Name = name,
                    Price = price,
                    IsCountable = isCountable,
                };
            }
            var supplier = productSupplierComboBox.SelectedItem as Supplier;
            if (Controller.AddProduct(product, supplier, amount))
            {
                MessageBox.Show("Product is added successfully!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

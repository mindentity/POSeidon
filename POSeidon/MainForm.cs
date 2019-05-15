using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            homepageDataGridView.AutoGenerateColumns = false;
            homepageDataGridView.DataSource = Controller.Products;
            salesHistoryDataGridView.AutoGenerateColumns = true;
            salesHistoryDataGridView.DataSource = Controller.SupplierLogs;
            suppliersTabDataGridView.AutoGenerateColumns = false;
            suppliersTabDataGridView.DataSource = Controller.Suppliers;
            customersTabDataGridView.AutoGenerateColumns = false;
            customersTabDataGridView.DataSource = Controller.Customers;
            currencySettingsComboBox.DataSource = Controller.Settings.AvailableCurrencies;
            weightUnitComboBox.DataSource = Controller.Settings.AvailableWeightUnits;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            addProductForm addProductForm = new addProductForm();
            addProductForm.ShowDialog();
        }

        private void SettingsTab_Enter(object sender, EventArgs e)
        {
            NumberFormatInfo nfi = Controller.Settings.NumberFormat;
            Currency currency = Controller.Settings.AvailableCurrencies.FirstOrDefault(x => x.Symbol == nfi.CurrencySymbol);
            if (currency != null)
            {
                currencySettingsComboBox.SelectedItem = currency;
            }
            currencySettingsDecimalSeparatorComboBox.SelectedItem = nfi.CurrencyDecimalSeparator;
            currencySettingsGroupSeparatorComboBox.SelectedItem = nfi.CurrencyGroupSeparator;
            currencySettingsGroupSizeNumericUpDown.Value = nfi.CurrencyGroupSizes.FirstOrDefault();

            switch (nfi.CurrencyPositivePattern)
            {
                case 0:
                    currencySettingsSymbolPlacementLeftRadioButton.Checked = true;
                    currencySettingsPutSpaceCheckBox.Checked = false;
                    break;
                case 1:
                    currencySettingsSymbolPlacementRightRadioButton.Checked = true;
                    currencySettingsPutSpaceCheckBox.Checked = false;
                    break;
                case 2:
                    currencySettingsSymbolPlacementLeftRadioButton.Checked = true;
                    currencySettingsPutSpaceCheckBox.Checked = true;
                    break;
                case 3:
                    currencySettingsSymbolPlacementRightRadioButton.Checked = true;
                    currencySettingsPutSpaceCheckBox.Checked = true;
                    break;
            }
            weightUnitComboBox.SelectedItem = Controller.Settings.WeightUnit;
        }

        private void HomepageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            
            if (e.ColumnIndex >= 0 && gridView.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                BindingList<Product> products = gridView.DataSource as BindingList<Product>;
                Product product = products.ElementAt(e.RowIndex);
                Controller.ShoppingCart.AddProduct(product, 1);
                MessageBox.Show("Product added to cart.", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShoppingCartLeftSidePanelButton_Click(object sender, EventArgs e)
        {
            if (Controller.ShoppingCart.Items.Count > 0)
            {
                ShoppingCartForm shoppingCartForm = new ShoppingCartForm();
                shoppingCartForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Shopping cart is empty!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var products = from x in Controller.Products
                           where x.Name.IndexOf(productSearchTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0
                           select x;
            homepageDataGridView.DataSource = products.ToList();
        }

        private void SuppliersSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var suppliers = from x in Controller.Suppliers
                            where x.Name.IndexOf(suppliersSearchTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0
                            select x;
            suppliersTabDataGridView.DataSource = suppliers.ToList();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }
    }
}

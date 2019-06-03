using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            homePageDataGridView.AutoGenerateColumns = false;
            homePageDataGridView.DataSource = Controller.Products;

            salesHistoryDataGridView.AutoGenerateColumns = false;
            salesHistoryDataGridView.DataSource = Controller.CustomerLogs;

            purchasingDataGridView.AutoGenerateColumns = false;
            purchasingDataGridView.DataSource = Controller.SupplierLogs;

            suppliersTabDataGridView.AutoGenerateColumns = false;
            suppliersTabDataGridView.DataSource = Controller.Suppliers;

            customersTabDataGridView.AutoGenerateColumns = false;
            customersTabDataGridView.DataSource = Controller.Customers;

            usersPageDataGridView.AutoGenerateColumns = false;
            usersPageDataGridView.DataSource = Controller.Users;

            currencySettingsComboBox.DataSource = Controller.Settings.AvailableCurrencies;
            weightUnitComboBox.DataSource = Controller.Settings.AvailableWeightUnits;

            usernameTextLabel.Text = Controller.User.Username;
            nameTextLabel.Text = Controller.User.FullName;

            if (Controller.User.IsAdmin)
            {
                isAdminUsersDataGridViewCheckBoxColumn.ReadOnly = false;
            }
            else
            {
                isAdminUsersDataGridViewCheckBoxColumn.ReadOnly = true;
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
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

        private void HomePageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            
            if (e.ColumnIndex >= 0 && gridView.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                BindingList<Product> products = (BindingList<Product>) gridView.DataSource;
                Product product = products.ElementAt(e.RowIndex);
                if (Controller.ShoppingCart.AddProduct(product))
                {
                    MessageBox.Show("Product added to cart.", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Not enough stock!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            homePageDataGridView.DataSource = new BindingList<Product>(products.ToList());
        }

        private void SuppliersSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var suppliers = from x in Controller.Suppliers
                            where x.Name.IndexOf(supplierSearchTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0
                            select x;
            suppliersTabDataGridView.DataSource = suppliers.ToList();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }


        private void SalesNavigatorPage_Enter(object sender, EventArgs e)
        {
            Controller.SupplierLogs.ResetBindings();
        }

        private void StatisticsTab_Enter(object sender, EventArgs e)
        {
            var data = from x in Controller.CustomerLogs
                       group x.ProductAmount by x.ProductName into g
                       select new
                       {
                           ProductName = g.Key,
                           Amount = g.Sum()
                       };
            statisticsChart.DataSource = data.ToList();
            statisticsChart.DataBind();
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            addSupplierForm.ShowDialog();
        }

        private void SalesHistoryDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (salesHistoryDataGridView.Columns[e.ColumnIndex].HeaderText == "Amount")
            {
                CustomerLog log = (CustomerLog) salesHistoryDataGridView.Rows[e.RowIndex].DataBoundItem;
                if (log.IsProductCountable)
                {
                    e.Value += " pcs";
                }
                else
                {
                    e.Value += $" {Controller.Settings.WeightUnit.Symbol}";
                }
            }
        }

        private void PurchasingDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (purchasingDataGridView.Columns[e.ColumnIndex].HeaderText == "Amount")
            {
                SupplierLog log = (SupplierLog) purchasingDataGridView.Rows[e.RowIndex].DataBoundItem;
                if (log.IsProductCountable)
                {
                    e.Value += " pcs";
                }
                else
                {
                    e.Value += $" {Controller.Settings.WeightUnit.Symbol}";
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Controller.Settings.NumberFormat.CurrencyDecimalSeparator = (string) currencySettingsDecimalSeparatorComboBox.SelectedItem;
            Controller.Settings.NumberFormat.CurrencyGroupSeparator = (string) currencySettingsGroupSeparatorComboBox.SelectedItem;
            Controller.Settings.NumberFormat.CurrencySymbol = ((Currency) currencySettingsComboBox.SelectedItem).Symbol;
            if (currencySettingsSymbolPlacementLeftRadioButton.Checked)
            {
                Controller.Settings.NumberFormat.CurrencyPositivePattern = 0;
            }
            else
            {
                Controller.Settings.NumberFormat.CurrencyPositivePattern = 1;
            }
            if (currencySettingsPutSpaceCheckBox.Checked)
            {
                Controller.Settings.NumberFormat.CurrencyPositivePattern += 2;
            }
            var cultureInfo = Thread.CurrentThread.CurrentCulture.Clone() as CultureInfo;
            cultureInfo.NumberFormat = Controller.Settings.NumberFormat;
            Controller.Settings.WeightUnit = (WeightUnit)weightUnitComboBox.SelectedItem;
            if (DBUtils.UpdateSettings())
            {
                Thread.CurrentThread.CurrentCulture = cultureInfo;
                MessageBox.Show("Settings are saved.", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save the settings!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsersPageDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var user = usersPageDataGridView.Rows[e.RowIndex].DataBoundItem as User;
                Controller.UpdateUser(user);
            }
        }

        private void HomePageDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (homePageDataGridView.Columns[e.ColumnIndex].HeaderText == "Price")
            {
                var product = (Product) homePageDataGridView.Rows[e.RowIndex].DataBoundItem;
                if (product.IsCountable)
                {
                    e.Value = $"{String.Format("{0:C}", e.Value)} / pcs";
                }
                else
                {
                    e.Value = $"{String.Format("{0:C}", e.Value)} / kg";
                }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void UsersPageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && usersPageDataGridView.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                BindingList<User> users = (BindingList<User>) usersPageDataGridView.DataSource;
                User user = users.ElementAt(e.RowIndex);
                if (Controller.User.IsAdmin == false)
                {
                    MessageBox.Show("You do not have permission for this operation!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (Controller.DeleteUser(user))
                {
                    MessageBox.Show("User deleted.", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to delete user!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerFormButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
                Address = addressTextBox.Text
            };
            if (Controller.AddCustomer(customer))
            {
                Controller.Customers.ResetBindings();
                MessageBox.Show("Customer added successfully.", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add customer!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

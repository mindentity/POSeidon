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
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void AddSupplierFormButton_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
                Address = addressTextBox.Text
            };
            if (Controller.AddSupplier(supplier))
            {
                Controller.Suppliers.ResetBindings();
                MessageBox.Show("Supplier added successfully.", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add supplier!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

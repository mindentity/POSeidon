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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string password1 = passwordTextBox.Text;
            string password2 = passwordAgainTextBox.Text;
            if (password1 == password2)
            {
                string username = usernameTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                bool isAdmin = adminCheckBox.Checked;
                if (Controller.AddUser(firstName, lastName, username, password1, isAdmin))
                {
                    MessageBox.Show("User added successfully.", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add user!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.Clear();
                    passwordAgainTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordAgainTextBox.Clear();
            }
        }
    }
}

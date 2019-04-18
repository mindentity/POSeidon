using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace POSeidon
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (DBUtils.Auth(usernameTextBox.Text, passwordTextBox.Text))
            {
                MessageBox.Show("Authentication completed!");
                this.Hide();
                Homepage f2 = new Homepage(); //this is the change, code for redirect  
                f2.ShowDialog();
            }
        }

    }
}

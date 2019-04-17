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


        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (DBUtils.Auth(usernameTextBox.Text, passwordTextBox.Text))
            {
                MessageBox.Show("Authentication completed!");
            }
        }

    }
}

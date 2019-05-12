using System;
using System.Windows.Forms;

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
            try
            {
                DBUtils.Auth(usernameTextBox.Text, passwordTextBox.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

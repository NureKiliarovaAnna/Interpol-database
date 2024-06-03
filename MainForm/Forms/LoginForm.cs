using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Enabled = false;
            txtUsername.TextChanged += new EventHandler(CheckLoginButtonState);
            txtPassword.TextChanged += new EventHandler(CheckLoginButtonState);
        }

        private void CheckLoginButtonState(object sender, EventArgs e)
        {
            btnLogin.Enabled = !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль");
            }
        }
    }
}
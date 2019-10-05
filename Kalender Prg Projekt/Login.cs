using System;
using System.Windows.Forms;

namespace Kalender_Prg_Projekt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signInButton1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT Password FROM tbl_user WHERE tbl_user.Username = '{usernameTextbox1.Text}'";
            if(SqlQuery.getString(query) == passwordTextbox1.Text)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }

        }

        private void SignUpLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            this.Hide();
            signup.Show();
        }
    }
}

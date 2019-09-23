using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

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
            if(SQL_Query.Query_String(query) == passwordTextbox1.Text)
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

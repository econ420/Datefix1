using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kalender_Prg_Projekt
{
    public partial class DateFix : Form
    {
        public int activeUserID = 0; //wenn der wert auf Null ist, ist kein nutzer eingeloggt. Sobald sich ein Nutzer einloggt wird der Wert auf die Nutzer ID Gesetzt
        string query = "";

        public DateFix()
        {
            InitializeComponent();
            if(activeUserID == 0)
            {
                accountInformationsPanel1.Hide();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }


        public void showAccountInformation()
        {
            accountLoginPanel1.Hide();
            accountInformationsPanel1.Show();
            this.query = $"SELECT Username FROM tbl_user WHERE tbl_user.ID = '{this.activeUserID}'";
            usernameInformationTextBox1.Text = SQL_Query.Query_String(query);
            this.query = $"SELECT Firstname FROM tbl_user WHERE tbl_user.ID = '{this.activeUserID}'";
            firstnameInformationTextBox1.Text = SQL_Query.Query_String(query);
            this.query = $"SELECT Lastname FROM tbl_user WHERE tbl_user.ID = '{this.activeUserID}'";
            lastnameInforamtionTextBox1.Text = SQL_Query.Query_String(query);
            this.query = $"SELECT Birthdate FROM tbl_user WHERE tbl_user.ID = '{this.activeUserID}'";
            birthdateInformationTextBox1.Text = SQL_Query.Query_String(query);
        }



        private void SignInAccountButton1_Click(object sender, EventArgs e)
        {
            this.query = $"SELECT * FROM tbl_user WHERE tbl_user.Username = '{usernameAccountTextbox1.Text}'";
            if(SQL_Query.Query_Compare(query))
            {
                if (Password.checkHashedPassword(passwordAccountTextbox1.Text, usernameAccountTextbox1.Text))
                {
                    Console.Write("Sign In successfull");
                    query = $"SELECT ID FROM tbl_user WHERE tbl_user.Username = '{usernameAccountTextbox1.Text}'";
                    setActiveUserID(SQL_Query.Query_Int(query));
                    showAccountInformation();
                }
                else
                {
                    MessageBox.Show("False");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
        }

        private void SignUpAccountLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            //this.Hide();
            signup.ShowDialog();
        }
    }
}

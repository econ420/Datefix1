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
            string query1 = $"SELECT Birthdate FROM tbl_user WHERE tbl_user.ID = '{3}'";
            query = SQL_Query.Query_String(query1).Substring(0, 10);
            var split = query.Split('.');
            int year, month, day;

            int.TryParse(split[0], out day);
            int.TryParse(split[1], out month);
            int.TryParse(split[2], out year);


            //MessageBox.Show(SQL_Query.Query_String(query));
            appointmentsAppointmentsTextBox1.Text = "Du hast keine Termine in nächster Zeit.";
            birthdayAppointmentsTextBox2.Text = "In nächster Zeit hat keiner Geburstag.";
            query = $@"SELECT 'Username','Firstname','Lastname','Birthdate','E-mail'
                              FROM tbl_users
                              WHERE userId = '{activeUserID}'";
            if (activeUserID == 0)
            {
                accountInformationsPanel1.Hide();
            }


            SQL_Query.Query_DataGridview(query, dataGridView1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var popupNewContact = new NewContact();
            popupNewContact.ShowDialog();
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

        public void setActiveUserID(int dummy)
        {
            activeUserID = dummy;
        }

        private void SignInAccountButton1_Click(object sender, EventArgs e)
        {
            this.query = $"SELECT * FROM tbl_user WHERE tbl_user.Username = '{usernameAccountTextbox1.Text}'";
            if (SQL_Query.Query_Compare(query))
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


        private void AppointmentstextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void BirthdaytextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void SignUpAccountLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            //this.Hide();
            signup.ShowDialog();
        }
    }
}

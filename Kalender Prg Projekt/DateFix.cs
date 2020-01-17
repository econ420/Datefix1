﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Kalender_Prg_Projekt
{
    public partial class DateFix : Form
    {
        private Models.User user;

        public Models.User User
        {
            get => user;
            set
            {
                if (this.user != value)
                {
                    user = value;

                    if (this.User != null)
                    {
                        string query = $@"SELECT 'Username','Firstname','Lastname','Birthdate','E-mail'
                              FROM tbl_users
                              WHERE userId = '{this.User.Id}'";

                        dataGridView1.DataSource = SqlQuery.getDataSource(query).GetBinding();
                    }
                }


            }
        }
        

        public DateFix()
        {
            InitializeComponent();
            

            Getnextevents();
            GetNextBirthdays();

            if (this.User == null)
            {
                accountInformationsPanel1.Hide();
            }

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
            usernameInformationTextBox1.Text = this.User.Username;
            firstnameInformationTextBox1.Text = this.User.Firstname;
            lastnameInforamtionTextBox1.Text = this.User.Lastname;
            birthdateInformationTextBox1.Text = this.User.Birthday.ToShortDateString();
        }

        private void SignInAccountButton1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM tbl_user WHERE tbl_user.Username = '{usernameAccountTextbox1.Text}'";
            if (SqlQuery.exists(query))
            {
                if (Password.checkHashedPassword(passwordAccountTextbox1.Text, usernameAccountTextbox1.Text))
                {
                    query = $"SELECT ID FROM tbl_user WHERE tbl_user.Username = '{usernameAccountTextbox1.Text}'";
                    int id = SqlQuery.getInt(query);
                    Models.User user = new Models.User();
                    user.Birthday = SqlQuery.getDateTime($"SELECT Birthdate FROM tbl_user WHERE tbl_user.ID = '{id}'");
                    user.Firstname = SqlQuery.getString($"SELECT Firstname FROM tbl_user WHERE tbl_user.ID = '{id}'");
                    user.Lastname = SqlQuery.getString($"SELECT Lastname FROM tbl_user WHERE tbl_user.ID = '{id}'");
                    user.Username = SqlQuery.getString($"SELECT Username FROM tbl_user WHERE tbl_user.ID = '{id}'");
                    this.User = user;
                    showAccountInformation();
                }
                else
                {
                    MessageBox.Show("Password is wrong");
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
            signup.ShowDialog();
        }


        private void GetNextBirthdays()
        {
            string query = "SELECT Username,' ', Birthdate FROM tbl_user WHERE MONTH(Birthdate) = MONTH(NOW())";    //Auslesen der Geburstage dieses Monats 


            birthdayAppointmentsTextBox2.Text = SqlQuery.getRowString(query).Replace(" 00:00:00","\r\n");       //Löschung der Uhrzeit weil das sonst dämlich aussieht 

        }


        private void Getnextevents()
        {
            string query = "SELECT eventDescription,' ', eventDate From,' - ', eventDeadline tbl_events WHERE MONTH(eventDate) = MONTH (NOW())";
            appointmentsAppointmentsTextBox1.Text = SqlQuery.getRowString(query);    //Hier soll er die Daten vom Tabelle Event in der Box Angeben die in diesen Monat sind 

        }

        private void EventCreatelinklabe1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void DateFix_Load(object sender, EventArgs e)
        {

        }

        private void NewEventButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
    
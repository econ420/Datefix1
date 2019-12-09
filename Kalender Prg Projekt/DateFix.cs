using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace Kalender_Prg_Projekt
{
    public partial class DateFix : Form
    {
        List<string> monthnames = new List<string>();
        int monthSelector = 0;
        int yearSelector = 0;

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
            resizeCalendar();
            string query1 = $"SELECT Birthdate FROM tbl_user WHERE tbl_user.ID = '{3}'";
            ////MessageBox.Show(SqlQuery.getDateTime(query1).ToShortDateString());

            appointmentsAppointmentsTextBox1.Text = "Du hast keine Termine in nächster Zeit.";
            birthdayAppointmentsTextBox2.Text = "In nächster Zeit hat keiner Geburstag.";

            GetNextBirthdays();

            if (this.User == null)
            {
                accountInformationsPanel1.Hide();
            }
            GenerateCalendar();

            //Set min size
            this.MinimumSize = new Size(816, 490);

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


        private void AppointmentstextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void BirthdaytextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void SignUpAccountLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            signup.ShowDialog();
        }


        private void GetNextBirthdays()
        {
            string query = "SELECT Username, Birthdate FROM tbl_user WHERE MONTH(Birthdate) = MONTH(NOW())";
            

            birthdayAppointmentsTextBox2.Text = SqlQuery.getRowString(query);

        }


        private void GenerateCalendar()
        {
            monthnames.Add("Januar");
            monthnames.Add("Februar");
            monthnames.Add("März");
            monthnames.Add("April");
            monthnames.Add("Mai");
            monthnames.Add("Juni");
            monthnames.Add("Juli");
            monthnames.Add("August");
            monthnames.Add("September");
            monthnames.Add("Oktober");
            monthnames.Add("November");
            monthnames.Add("Dezember");

            DateTime date = DateTime.Now;
            monthNameLabel1.Text = monthnames[date.Month - 1];
            monthSelector = date.Month - 1;
            yearSelector = date.Year;

            //TODO erweiterung des Kalenders um die Funktion des anzeigens der Tage

            int days = DateTime.DaysInMonth(yearSelector, monthSelector + 1);
            label1.Text = days.ToString();

        }

        private void prevMonthButton1_Click(object sender, EventArgs e)
        {
            monthSelector--;
            if(monthSelector < 0)
            {
                monthSelector = 11;
                yearSelector--;
            }
            monthNameLabel1.Text = monthnames[monthSelector];

            DateTime date = DateTime.Now;
            int days = DateTime.DaysInMonth(yearSelector, monthSelector + 1);
            label1.Text = days.ToString();
        }

        private void nextMonthButton1_Click(object sender, EventArgs e)
        {
            monthSelector++;
            if (monthSelector > 11)
            {
                monthSelector = 0;
                yearSelector++;
            }
            monthNameLabel1.Text = monthnames[monthSelector];

            DateTime date = DateTime.Now;
            int days = DateTime.DaysInMonth(yearSelector, monthSelector + 1);
            label1.Text = days.ToString();
        }

        private void resizeCalendar()
        {
            double factor = 0;

            int maxSize = calendarPanel2.Width;

            factor = 100.0 / 7.0;
            factor = factor / 100.0;
            sundayMonthDayPanel1.Width = Convert.ToInt32(maxSize * factor);
            mondayMonthDayPanel1.Width = Convert.ToInt32(maxSize * factor);
            tuesdayMonthDayPanel1.Width = Convert.ToInt32(maxSize * factor);
            wednesdayMonthDayPanel1.Width = Convert.ToInt32(maxSize * factor);
            thursdayMonthDayPanel1.Width = Convert.ToInt32(maxSize * factor);
            fridayMonthDayPanel1.Width = Convert.ToInt32(maxSize * factor);
            saturdayMonthDayPanel1.Width = Convert.ToInt32(maxSize * factor);

            
            maxSize = sundayMonthDayPanel2.Height;
            factor = 100.0 / 6.0;
            factor = factor / 100.0;
            sunday1.Height = Convert.ToInt32(maxSize * factor);
            sunday2.Height = Convert.ToInt32(maxSize * factor);
            sunday3.Height = Convert.ToInt32(maxSize * factor);
            sunday4.Height = Convert.ToInt32(maxSize * factor);
            sunday5.Height = Convert.ToInt32(maxSize * factor);
            sunday6.Height = Convert.ToInt32(maxSize * factor);

            monday1.Height = Convert.ToInt32(maxSize * factor);
            monday2.Height = Convert.ToInt32(maxSize * factor);
            monday3.Height = Convert.ToInt32(maxSize * factor);
            monday4.Height = Convert.ToInt32(maxSize * factor);
            monday5.Height = Convert.ToInt32(maxSize * factor);
            monday6.Height = Convert.ToInt32(maxSize * factor);

            tuesday1.Height = Convert.ToInt32(maxSize * factor);
            tuesday2.Height = Convert.ToInt32(maxSize * factor);
            tuesday3.Height = Convert.ToInt32(maxSize * factor);
            tuesday4.Height = Convert.ToInt32(maxSize * factor);
            tuesday5.Height = Convert.ToInt32(maxSize * factor);
            tuesday6.Height = Convert.ToInt32(maxSize * factor);

        }

        private void DateFix_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                resizeCalendar();
            }
        }

        private void DateFix_ResizeEnd(object sender, EventArgs e)
        {
            resizeCalendar();
        }
    }
}

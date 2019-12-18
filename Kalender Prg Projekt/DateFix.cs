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
        List<Label> labels = new List<Label>();
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

        private void loginEnter_KeyDown_Tabcontrol(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter) && (tabControl1.SelectedTab == accountTabPage1) && (passwordAccountTextbox1.Focused || usernameAccountTextbox1.Focused))
            {
                userLogin();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SignInAccountButton1_Click(object sender, EventArgs e)
        {
            userLogin();
        }

        private void userLogin()
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


        private void GenerateDaysFromMonth(string dayName,int dayCount)
        {
            sunday1.Text = "0";
            monday1.Text = "0";
            tuesday1.Text = "0";
            wednesday1.Text = "0";
            thursday1.Text = "0";
            friday1.Text = "0";
            saturday1.Text = "0";
            if (sundayMonthDayLabel1.Text == dayName)
            {
                sunday1.Text = "1";
            }
            else if (mondayMonthDayLabel1.Text == dayName)
            {
                monday1.Text = "1";
            }
            else if (tuesdayMonthDayLabel1.Text == dayName)
            {
                tuesday1.Text = "1";
            }
            else if (wednesdayMonthDayLabel1.Text == dayName)
            {
                wednesday1.Text = "1";
            }
            else if (thursdayMonthDayLabel1.Text == dayName)
            {
                thursday1.Text = "1";
            }
            else if (fridayMonthDayLabel1.Text == dayName)
            {
                friday1.Text = "1";
            }
            else if (saturdayMonthDayLabel1.Text == dayName)
            {
                saturday1.Text = "1";
            }
        }

        private void GenerateCalendar()
        {
            addLabelstoList();
            DateTime date = DateTime.Now;
            monthSelector = date.Month - 1;
            yearSelector = date.Year;
            date = new DateTime(yearSelector, monthSelector + 1, 1);
            monthNameLabel1.Text = date.ToString("MMMMMMMMMMMMM") + " " + yearSelector;

            //TODO erweiterung des Kalenders um die Funktion des anzeigens der Tage

            int days = DateTime.DaysInMonth(yearSelector, monthSelector + 1);
            label1.Text = days.ToString();

            GenerateDaysFromMonth(date.ToString("dddd"), days);

        }




        private void prevMonthButton1_Click(object sender, EventArgs e)
        {
            monthSelector--;
            if(monthSelector < 0)
            {
                monthSelector = 11;
                yearSelector--;
            }
            DateTime date = new DateTime(yearSelector, monthSelector + 1, 1);
            monthNameLabel1.Text = date.ToString("MMMMMMMMMMMMM") + " " + yearSelector;
            int days = DateTime.DaysInMonth(yearSelector, monthSelector + 1);
            label1.Text = days.ToString();
            GenerateDaysFromMonth(date.ToString("dddd"), days);
        }

        private void nextMonthButton1_Click(object sender, EventArgs e)
        {
            monthSelector++;
            if (monthSelector > 11)
            {
                monthSelector = 0;
                yearSelector++;
            }

            DateTime date = new DateTime(yearSelector, monthSelector + 1, 1);
            monthNameLabel1.Text = date.ToString("MMMMMMMMMMMMM") + " " + yearSelector;
            int days = DateTime.DaysInMonth(yearSelector, monthSelector + 1);
            label1.Text = days.ToString();
            GenerateDaysFromMonth(date.ToString("dddd"), days);
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


            sunday6.Height = Convert.ToInt32(maxSize * factor);
            sunday5.Height = Convert.ToInt32(maxSize * factor);
            sunday4.Height = Convert.ToInt32(maxSize * factor);
            sunday3.Height = Convert.ToInt32(maxSize * factor);
            sunday2.Height = Convert.ToInt32(maxSize * factor);
            sunday1.Height = Convert.ToInt32(maxSize * factor);

            monday6.Height = Convert.ToInt32(maxSize * factor);
            monday5.Height = Convert.ToInt32(maxSize * factor);
            monday4.Height = Convert.ToInt32(maxSize * factor);
            monday3.Height = Convert.ToInt32(maxSize * factor);
            monday2.Height = Convert.ToInt32(maxSize * factor);
            monday1.Height = Convert.ToInt32(maxSize * factor);

            tuesday6.Height = Convert.ToInt32(maxSize * factor);
            tuesday5.Height = Convert.ToInt32(maxSize * factor);
            tuesday4.Height = Convert.ToInt32(maxSize * factor);
            tuesday3.Height = Convert.ToInt32(maxSize * factor);
            tuesday2.Height = Convert.ToInt32(maxSize * factor);
            tuesday1.Height = Convert.ToInt32(maxSize * factor);

            wednesday6.Height = Convert.ToInt32(maxSize * factor);
            wednesday5.Height = Convert.ToInt32(maxSize * factor);
            wednesday4.Height = Convert.ToInt32(maxSize * factor);
            wednesday3.Height = Convert.ToInt32(maxSize * factor);
            wednesday2.Height = Convert.ToInt32(maxSize * factor);
            wednesday1.Height = Convert.ToInt32(maxSize * factor);

            thursday6.Height = Convert.ToInt32(maxSize * factor);
            thursday5.Height = Convert.ToInt32(maxSize * factor);
            thursday4.Height = Convert.ToInt32(maxSize * factor);
            thursday3.Height = Convert.ToInt32(maxSize * factor);
            thursday2.Height = Convert.ToInt32(maxSize * factor);
            thursday1.Height = Convert.ToInt32(maxSize * factor);

            friday6.Height = Convert.ToInt32(maxSize * factor);
            friday5.Height = Convert.ToInt32(maxSize * factor);
            friday4.Height = Convert.ToInt32(maxSize * factor);
            friday3.Height = Convert.ToInt32(maxSize * factor);
            friday2.Height = Convert.ToInt32(maxSize * factor);
            friday1.Height = Convert.ToInt32(maxSize * factor);

            saturday6.Height = Convert.ToInt32(maxSize * factor);
            saturday5.Height = Convert.ToInt32(maxSize * factor);
            saturday4.Height = Convert.ToInt32(maxSize * factor);
            saturday3.Height = Convert.ToInt32(maxSize * factor);
            saturday2.Height = Convert.ToInt32(maxSize * factor);
            saturday1.Height = Convert.ToInt32(maxSize * factor);
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

        private void addLabelstoList()
        {
            labels.Add(sunday1);
            labels.Add(monday1);
            labels.Add(tuesday1);
            labels.Add(wednesday1);
            labels.Add(thursday1);
            labels.Add(friday1);
            labels.Add(saturday1);

            labels.Add(sunday2);
            labels.Add(monday2);
            labels.Add(tuesday2);
            labels.Add(wednesday2);
            labels.Add(thursday2);
            labels.Add(friday2);
            labels.Add(saturday2);

            labels.Add(sunday3);
            labels.Add(monday3);
            labels.Add(tuesday3);
            labels.Add(wednesday3);
            labels.Add(thursday3);
            labels.Add(friday3);
            labels.Add(saturday3);

            labels.Add(sunday4);
            labels.Add(monday4);
            labels.Add(tuesday4);
            labels.Add(wednesday4);
            labels.Add(thursday4);
            labels.Add(friday4);
            labels.Add(saturday4);

            labels.Add(sunday5);
            labels.Add(monday5);
            labels.Add(tuesday5);
            labels.Add(wednesday5);
            labels.Add(thursday5);
            labels.Add(friday5);
            labels.Add(saturday5);

            labels.Add(sunday6);
            labels.Add(monday6);
            labels.Add(tuesday6);
            labels.Add(wednesday6);
            labels.Add(thursday6);
            labels.Add(friday6);
            labels.Add(saturday6);
        }


    }
}

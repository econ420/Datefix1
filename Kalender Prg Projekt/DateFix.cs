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
        List<Label> CalendarDays = new List<Label>();
        Label label = new Label();
        Point daysLocation = new Point(0, 0);

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


        

        private void GenerateCalendar()
        {
            DateTime date = DateTime.Now;
            monthSelector = date.Month - 1;
            yearSelector = date.Year;
            date = new DateTime(yearSelector, monthSelector + 1, 1);
            monthNameLabel1.Text = date.ToString("MMMMMMMMMMMMM") + " " + yearSelector;

            int days = DateTime.DaysInMonth(yearSelector, monthSelector + 1);
            List<string> dayNames = new List<string>();
            dayNames.Add("Sonntag");
            dayNames.Add("Montag");
            dayNames.Add("Dienstag");
            dayNames.Add("Mittwoch");
            dayNames.Add("Donnerstag");
            dayNames.Add("Freitag");
            dayNames.Add("Samstag");


            double factor = 0;
            factor = 100.0 / 7.0;
            factor = factor / 100.0;
            Size labelSize = new Size(Convert.ToInt32(calendarDaysPanel1.Width * factor), Convert.ToInt32(calendarDaysPanel1.Height * 100 / 7 / 100));
            string dummy = "labelDays";
            int row = 0;
            int colum = Convert.ToInt32(calendarDaysPanel1.Width * factor);



            for (int i = 0; i < 49; i++)
            {
                if(i%7 == 0 && i!= 0)
                {
                    row += calendarDaysPanel1.Height/7;
                    daysLocation = new Point(0, row);
                }

                label = new Label();
                label.Font = new Font("Serif", 12);
                if (i % 2 == 0)
                {
                    label.BackColor = System.Drawing.Color.LightGray;
                }
                else
                {
                    label.BackColor = System.Drawing.Color.Transparent;
                }
                if (i < 7)
                {
                    label.Location = daysLocation;
                    label.Size = labelSize;
                    label.Text = dayNames[i];
                    label.Name = dummy + i;
                    labels.Add(label);
                    calendarDaysPanel1.Controls.Add(label);
                }
                else
                {
                    label.Location = daysLocation;
                    label.Size = labelSize;
                    label.Text = (i-6).ToString();
                    label.Name = dummy + i;
                    labels.Add(label);
                    calendarDaysPanel1.Controls.Add(label);
                }
                daysLocation.Offset(colum, 0);
            }
            setValueForDay(GetStartdateofMonth(date.ToString("dddd")), days, GetDaysPrevMonth(monthSelector, yearSelector));
        }


        private int GetStartdateofMonth(string dayName)
        {
            List<string> dayNames = new List<string>();
            dayNames.Add("Sonntag");
            dayNames.Add("Montag");
            dayNames.Add("Dienstag");
            dayNames.Add("Mittwoch");
            dayNames.Add("Donnerstag");
            dayNames.Add("Freitag");
            dayNames.Add("Samstag");

            int dummy = 0;

            for (int i = 0; i < 7; i++)
            {
                if (dayName == dayNames[i])
                {
                    dummy = i;
                }
            }
            return dummy;
        }


        private int GetDaysPrevMonth(int monthSelector, int yearSelector)
        {
            int daysPrevMonth = 0;
            if (monthSelector - 1 < 0)
            {
                daysPrevMonth = DateTime.DaysInMonth(yearSelector - 1, 11) + 1;
            }
            else
            {
                daysPrevMonth = DateTime.DaysInMonth(yearSelector, monthSelector);
            }
            return daysPrevMonth;
        }

        private void setValueForDay(int startDay, int numberOfDays, int daysPrevMonth)
        {
            bool firstRun = true;
            for (int i = 7; i < 49; i++)
            {

                if (firstRun == true)
                {
                    i += startDay;
                }
                if(startDay != 0)
                {
                    int x = 0;
                    for (int j = startDay; j > 0; j--)
                    {
                        labels[j + 6].Text = (daysPrevMonth - x).ToString();
                        x++;
                    }
                }
                if ((i - startDay - 7 + 1) <= numberOfDays)
                {
                    labels[i].Text = (i - startDay - 7 + 1).ToString();
                }
                else
                {
                    labels[i].Text = (i - startDay - 7 + 1 - numberOfDays).ToString();
                }


                firstRun = false;
            }
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

            setValueForDay(GetStartdateofMonth(date.ToString("dddd")), days, GetDaysPrevMonth(monthSelector, yearSelector));
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

            setValueForDay(GetStartdateofMonth(date.ToString("dddd")), days, GetDaysPrevMonth(monthSelector, yearSelector));
        }

       
    }
}

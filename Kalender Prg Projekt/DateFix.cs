using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

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
        int selectedRow=0;

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

            appointmentsAppointmentsTextBox1.Text = "Du hast keine Termine in nächster Zeit.";
            birthdayAppointmentsTextBox2.Text = "In nächster Zeit hat keiner Geburstag.";

            if (this.User == null)
            {
                accountInformationsPanel1.Hide();
                AppointmentsPanel1.Hide();
                BirthdayPanel1.Hide();
            }
            loadDatagrid();
            GenerateCalendar();
        }

        private void loadDatagrid()
        {
            if (this.User == null)
            {
                contactsPanel1.Hide();
            }
            else
            {
                contactsPanel1.Show();
                string query = $"SELECT ID, Firstname, Lastname, Username, E_Mail, Address FROM tbl_contacts WHERE UID= '{this.User.Id}' ";
                dataGridView1.DataSource = SqlQuery.getDataSource(query).GetBinding();
            }


        }
        private void NewContactButton1_Click(object sender, EventArgs e)
        {
            var popupNewContact = new NewContact(user.Id);
            popupNewContact.ShowDialog();
            loadDatagrid();
            GetNextBirthdays();
        }

        public void showAccountInformation()
        {
            accountLoginPanel1.Hide();
            accountInformationsPanel1.Show();
            usernameInformationTextBox1.Text = this.User.Username;
            firstnameInformationTextBox1.Text = this.User.Firstname;
            lastnameInforamtionTextBox1.Text = this.User.Lastname;
            birthdateInformationTextBox1.Text = this.User.Birthday.ToShortDateString();
            loadDatagrid();
        }

        private void SignInAccountButton1_Click(object sender, EventArgs e)
        {
            userLogin();
        }


        private void SignUpAccountLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            signup.ShowDialog();
        }


        private void GetNextBirthdays()
        {
            string query = $"SELECT Firstname,' ', Lastname,' ', Birthdate FROM tbl_contacts WHERE MONTH(Birthdate) = MONTH(NOW()) AND UID= '{this.User.Id}'";    //Auslesen der Geburstage dieses Monats 
            birthdayAppointmentsTextBox2.Text = SqlQuery.getRowString(query).Replace(" 00:00:00","\r\n");       //Löschung der Uhrzeit weil das sonst dämlich aussieht 

        }


        private void Getnextevents()
        {
            string query = $"SELECT eventDescription,' ', eventDate, ' - ', eventDeadline, '|' From tbl_events WHERE MONTH(eventDate) = MONTH(NOW()) AND UID= '{this.User.Id}'";
            appointmentsAppointmentsTextBox1.Text = SqlQuery.getRowString(query).Replace(" 00:00:00", "\r").Replace("|", "\r\n");    //Hier soll er die Daten vom Tabelle Event in der Box Angeben die in diesen Monat sind 

        }


        private void DateFix_Load(object sender, EventArgs e)
        {

        }

        private void NewEventButton1_Click(object sender, EventArgs e)    
        {
            CreateEvent createEvent = new CreateEvent(user.Id);
            createEvent.ShowDialog();
            Getnextevents();
        }

        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten Sie diesen Kontakte wirklich unwiderruflich löschen?", "Kontakte löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //DataGridViewRow row = this.dataGridView1.Rows[0];
                //int selectedRow = Convert.ToInt32(row.Cells["ID"].Value);
                string query = $"DELETE FROM tbl_contacts WHERE ID = {selectedRow}";
                SqlQuery.delete(query);
                loadDatagrid();
            }
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex == 0)
                {
                    try
                    {
                        DataGridViewRow row = this.dataGridView1.Rows[0];
                        this.selectedRow = Convert.ToInt32(row.Cells["ID"].Value);
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                        this.selectedRow = Convert.ToInt32(row.Cells["ID"].Value);
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.ToString());
                    }
                }
                //loadDatagrid();
            }
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
                    user.Id = id;
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
            Getnextevents();
            GetNextBirthdays();
            AppointmentsPanel1.Show();
            BirthdayPanel1.Show();

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
                if (i % 7 == 0 && i != 0)
                {
                    row += calendarDaysPanel1.Height / 7;
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
                    label.Text = (i - 6).ToString();
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
                if (startDay != 0)
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
            if (monthSelector < 0)
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
    
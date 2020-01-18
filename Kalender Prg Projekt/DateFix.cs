using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Kalender_Prg_Projekt
{
    public partial class DateFix : Form
    {
        int selectedRow=0;

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
            //MessageBox.Show(SqlQuery.getDateTime(query1).ToShortDateString());

            appointmentsAppointmentsTextBox1.Text = "Du hast keine Termine in nächster Zeit.";
            birthdayAppointmentsTextBox2.Text = "In nächster Zeit hat keiner Geburstag.";

            if (this.User == null)
            {
                accountInformationsPanel1.Hide();
            }
            loadDatagrid();
        }

        private void loadDatagrid()
        {
            if (this.User == null)
            {
                panel2.Hide();
            }
            //string testquery = "SELECT Birthdate FROM tbl_contacts";
            //var dummy = SqlQuery.getDataSource(testquery);
            else
            {
                panel2.Show();
                string query = $"SELECT ID, Firstname, Lastname, Username, E_Mail, Address FROM tbl_contacts WHERE UID= '{this.User.Id}' ";
                dataGridView1.DataSource = SqlQuery.getDataSource(query).GetBinding();
            }


        }
        private void NewContactButton1_Click(object sender, EventArgs e)
        {
            var popupNewContact = new NewContact(user.Id);
            popupNewContact.Show();

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

        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten Sie diesen Artikel wirklich unwiderruflich löschen?", "Artikel löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = this.dataGridView1.Rows[0];
                int selectedRow = Convert.ToInt32(row.Cells["ID"].Value);
                //string query = $"SELECT count(*) FROM tbl_contacts WHERE ID = {selectedRow}";
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
                        this.selectedRow = Convert.ToInt32(row.Cells["Nummer"].Value);
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
                        this.selectedRow = Convert.ToInt32(row.Cells["Nummer"].Value);
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.ToString());
                    }
                }
                loadDatagrid();
            }
        }
    }
}

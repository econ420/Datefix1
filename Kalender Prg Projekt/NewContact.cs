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
    public partial class NewContact : Form
    {
        int loggedInID = 0;
        public NewContact()
        {
            InitializeComponent();
        }

        public NewContact(int Id)
        {
            InitializeComponent();
            loggedInID = Id;
        }

        private void Speichern_Click_1(object sender, EventArgs e)
        {
            if (txtBoxFirstname.Text == "" || txtBoxFirstname.Text == null)
            {
                labError.Visible = true;
            }
            else if (txtBoxLastname.Text == "" || txtBoxLastname.Text == null)
            {
                labError.Visible = true;
            }
            else if (txtBoxUsername.Text == "" || txtBoxUsername.Text == null)
            {
                labError.Visible = true;

            }
            else if (txtBoxEmail.Text == "" || txtBoxEmail.Text == null)
            {
                labError.Visible = true;

            }
            else if (txtBoxAdresse.Text == "" || txtBoxAdresse.Text == null)
            {
                labError.Visible = true;

            }
            else
            {
                Utilities utilities = new Utilities();
                string query = $"INSERT INTO tbl_contacts (`ID`, `UID` , `Firstname` , `Lastname`, `Username`, `Birthdate`,`E_Mail`,`Address`) VALUES (NULL,'{loggedInID}','{txtBoxFirstname.Text}', '{txtBoxLastname.Text}', '{txtBoxUsername.Text}','{utilities.formatdate(birthdateDateTimePicker1.Value.ToString())}', '{txtBoxEmail.Text}','{txtBoxAdresse.Text}')";
                SqlQuery.insert(query);
                MessageBox.Show("Nutzer Angelegt");
                this.Close();
            }
        }
    }
}
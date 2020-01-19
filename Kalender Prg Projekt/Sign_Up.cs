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
    public partial class Sign_Up : Form
    {
        string query = "";

        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Sign_Up_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Sign_UpButton1_Click(object sender, EventArgs e)
        {
            Utilities utilities = new Utilities();

            //utilities.formatdate(birthdateDateTimePicker1.Value.ToString())

            this.query = $"SELECT * FROM tbl_user WHERE tbl_user.Username = '{usernameTextbox1.Text}'";
            if (SqlQuery.exists(query))
            {
                MessageBox.Show("Username Vergeben");
            }
            else
            {
                if (passwordTextbox1.Text == passwordConfirmTextbox1.Text && passwordTextbox1.Text != "")
                {
                    this.query = $"INSERT INTO tbl_user (`ID` , `Firstname` , `Lastname`, `Username`, `Password`, `Birthdate`, `E-Mail`, `Address`) VALUES (NULL, '{firstnameTextbox1.Text}', '{lastnameTextbox1.Text}', '{usernameTextbox1.Text}', '{Password.passwordHash(passwordTextbox1.Text)}', '{utilities.formatdate(birthdateDateTimePicker1.Value.ToString())}', '{emailTextbox1.Text}', '{addressTextbox1.Text}')";
                    SqlQuery.insert(query);
                    MessageBox.Show("Nutzer Angelegt");
                }
                else
                {
                    MessageBox.Show("Passwort Falsch");
                }
            }
        }

        private void PasswordConfirmationCorrect_Textchanged(object sender, EventArgs e)
        {
            //dummy
        }
    }
}

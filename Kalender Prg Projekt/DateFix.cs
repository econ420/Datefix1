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
        public int activeUserID = 1;
        public DateFix()
        {
            InitializeComponent();
            string query1 = $"SELECT Birthdate FROM tbl_user WHERE tbl_user.ID = '{activeUserID = 3}'";     
            string query =  SQL_Query.Query_String(query1).Substring(0,10);
            var split = query.Split('.');
            int year, month, day;

            int.TryParse(split[0], out day);
            int.TryParse(split[1], out month);
            int.TryParse(split[2], out year);
           

            MessageBox.Show(SQL_Query.Query_String(query));
            appointmentsAppointmentsTextBox1.Text = "Du hast keine Termine in nächster Zeit.";
            birthdayAppointmentsTextBox2.Text = "In nächster Zeit hat keiner Geburstag.";
        }



        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void AppointmentstextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void BirthdaytextBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

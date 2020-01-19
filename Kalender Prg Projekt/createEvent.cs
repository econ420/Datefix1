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
    public partial class CreateEvent : Form
    {
        int loggedInID = 0;

        public CreateEvent()
        {
            InitializeComponent();
        }

        public CreateEvent(int Id)
        {
            InitializeComponent();
            loggedInID = Id;
        }

        private void saveEvent_Click(object sender, EventArgs e)
        {
            int result = DateTime.Compare(eventStartDateTimePicker1.Value, eventEndtDateTimePicker1.Value);

            if (maskedTextBox1.Text == "" || maskedTextBox1.Text == null)
            {
                MessageBox.Show("Bitte Füllen sie alle Felder aus");
            }
            else if (result > 0)
            {
                MessageBox.Show("Fehlerhaftes Datum, Bitte Füllen sie alle Felder Richtig aus");

            }
            else
            {
                Utilities utilities = new Utilities();
                string query = $"INSERT INTO tbl_events (`eventID`, `UID` , `eventDescription` , `eventDate`, `eventDeadline`) VALUES (NULL,'{loggedInID}','{maskedTextBox1.Text}', '{utilities.formatdate(eventStartDateTimePicker1.Value.ToString())}', '{utilities.formatdate(eventEndtDateTimePicker1.Value.ToString())}')";
                SqlQuery.insert(query);
                MessageBox.Show("Termin Angelegt");
                this.Close();
            }

        }
    }
}

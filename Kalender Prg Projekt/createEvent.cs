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
        string query = "";
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
            if (maskedTextBox1.Text == "" || maskedTextBox1.Text == null)
            {
                MessageBox.Show("Bitte Füllen sie alle Felder aus");
            }
            else if (maskedTextBox3.Text == "" || maskedTextBox3.Text == null)
            {
                MessageBox.Show("Bitte Füllen sie alle Felder aus");
            }
            else if (maskedTextBox2.Text == "" || maskedTextBox2.Text == null)
            {
                MessageBox.Show("Bitte Füllen sie alle Felder aus");

            }
            else if (maskedTextBox4.Text == "" || maskedTextBox4.Text == null)
            {
                MessageBox.Show("Bitte Füllen sie alle Felder aus");

            }
            else
            {

            }

        }
    }
}

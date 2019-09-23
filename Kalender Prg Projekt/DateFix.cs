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
        public DateFix()
        {
            InitializeComponent();
            contactListContactsListview.View = View.Details;
            ColumnHeader firstname = new ColumnHeader();
            firstname.Text = "Vorname";
            firstname.Width = 156;
            firstname.TextAlign = HorizontalAlignment.Center;
            contactListContactsListview.Columns.Add(firstname);

            ColumnHeader surname = new ColumnHeader();
            surname.Text = "Nachname";
            surname.Width = 156;
            surname.TextAlign = HorizontalAlignment.Center;
            contactListContactsListview.Columns.Add(surname);

            ColumnHeader address = new ColumnHeader();
            address.Text = "Adresse";
            address.Width = 156;
            address.TextAlign = HorizontalAlignment.Center;
            contactListContactsListview.Columns.Add(address);

            ColumnHeader email = new ColumnHeader();
            email.Text = "E-mail";
            email.Width = 156;
            email.TextAlign = HorizontalAlignment.Center;
            contactListContactsListview.Columns.Add(email);

            ColumnHeader department = new ColumnHeader();
            department.Text = "Abteilung";
            department.Width = 156;
            department.TextAlign = HorizontalAlignment.Center;
            contactListContactsListview.Columns.Add(department);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ContactsTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

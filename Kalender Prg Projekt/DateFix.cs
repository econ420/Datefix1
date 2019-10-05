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
        int activeUserID = 0;

        public DateFix()
        {
            InitializeComponent();
            string query = $@"SELECT 'Username','Firstname','Lastname','Birthdate','E-mail'
                              FROM tbl_users
                              WHERE userId = '{activeUserID}'";

            SQL_Query.Query_DataGridview(query, dataGridView1);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            var popupNewContact = new NewContact(); 
            popupNewContact.ShowDialog();
        }
    }
}

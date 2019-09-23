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
        }

        private void DateFix_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        public void setActiveUserID (int dummy)
        {
            activeUserID = dummy;
        }

        private void SignInAccountButton1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM tbl_user WHERE tbl_user.Username = '{usernameAccountTextbox1.Text}'";
            if (SQL_Query.Query_Compare(query))
            {
                Console.Write("Sign In successfull");
                DateFix dateFix = new DateFix();
                query = $"SELECT ID FROM tbl_user WHERE tbl_user.Username = '{usernameAccountTextbox1.Text}'";
                dateFix.setActiveUserID(SQL_Query.Query_Int(query));
                this.Close();
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}

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
        }


        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }
    }
}

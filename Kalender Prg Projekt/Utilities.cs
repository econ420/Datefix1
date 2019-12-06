using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender_Prg_Projekt
{
    class Utilities
    {
        public Utilities()
        {

        }
        public string formatdate(string date)
        {
            DateTime oDate = Convert.ToDateTime(date);
            date = oDate.Year + "-" + oDate.Month + "-" + oDate.Day;
            return date;
        }
    }

}

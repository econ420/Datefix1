using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalender_Prg_Projekt
{
    public static class DataTableExtensions
    {
        public static BindingSource GetBinding(this DataTable table)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;
            return bindingSource;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Controllers.UI.Util
{
    internal class Helper
    {
        public static void ResetRowColorDatagridView(DataGridView dataGridView)
        {
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}

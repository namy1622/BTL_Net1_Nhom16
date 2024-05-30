using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Color
    {
        colorDataGirdView colorDTGV = new colorDataGirdView();
        public void colorDataGridView1(DataGridView dtgv)
        {
            colorDTGV.color_dtgv(dtgv);
        }
    }
}

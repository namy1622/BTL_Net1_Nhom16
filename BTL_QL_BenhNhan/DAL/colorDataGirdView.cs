using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class colorDataGirdView
    {
        

        public void color_dtgv(DataGridView dtgv)
        {

            // Thiết lập màu sắc cho các hàng
            Color lightBlue = Color.FromArgb(173, 216, 230); // Màu xanh dương nhạt
            Color complementaryColor = Color.FromArgb(230, 230, 250); // Màu hợp với màu xanh dương nhạt (Lavender)
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = lightBlue;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = complementaryColor;
                }
            }

            // Thiết lập màu sắc cho header
            dtgv.EnableHeadersVisualStyles = false;
            dtgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy; // Màu nền của header
            dtgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Màu chữ của header
            dtgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Phông chữ của header
        }
    
    }
}

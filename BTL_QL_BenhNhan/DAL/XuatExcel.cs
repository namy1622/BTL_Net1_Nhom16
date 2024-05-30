using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class XuatExcel
    {
        public void toExcel(DataGridView dtgvToExcel)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);

            for (int i = 1; i < dtgvToExcel.Columns.Count + 1; i++)
            {
                excelApp.Cells[1, i] = dtgvToExcel.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dtgvToExcel.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvToExcel.Columns.Count; j++)
                {
                    excelApp.Cells[i + 2, j + 1] = dtgvToExcel.Rows[i].Cells[j].Value.ToString();
                }
            }
            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
        }
        
    }
}

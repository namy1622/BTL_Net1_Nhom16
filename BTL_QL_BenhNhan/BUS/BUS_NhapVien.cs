using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhapVien
    {
        public void InsertNhapVienAndBN(DTO_NhapVien_q data)
        {
            DAL_NhapVien.InsertNhapVienAndBN(data);
        }
    }
}

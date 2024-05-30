using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class DTO_Khoa
    {
        private int ma;
        private string ten;
        private DateTime ngayThanhLap;

        public int Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgayThanhLap { get => ngayThanhLap; set => ngayThanhLap = value; }
        public DTO_Khoa(int ma, string ten, DateTime ngayThanhLap)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.NgayThanhLap = ngayThanhLap;
        }
    }
}

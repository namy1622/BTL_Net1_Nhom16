using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BacSi_q
    {
        private int ma;
        private string ten;
        private bool gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string trinhDo;
        private string chucVu;
        private int maKhoa;




        public int Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int MaKhoa { get => maKhoa; set => maKhoa = value; }

        public DTO_BacSi_q(int ma, string ten, bool gioiTinh, DateTime ngaySinh, string diaChi, string trinhDo, string chucVu, int maKhoa)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.trinhDo = trinhDo;
            this.chucVu = chucVu;
            this.maKhoa = maKhoa;
        }
    }
}

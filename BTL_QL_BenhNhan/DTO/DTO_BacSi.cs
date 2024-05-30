using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BacSi
    {
        private int maBaSi;
        private string hoTen;
        private byte gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string trinhDo;
        private string chucVu;

        public DTO_BacSi()
        {
        }

        public DTO_BacSi(int maBaSi, string hoTen, byte gioiTinh, DateTime ngaySinh,
                         string diaChi, string trinhDo, string chucVu)
        {
            this.maBaSi = maBaSi;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.trinhDo = trinhDo;
            this.chucVu = chucVu;
        }

        public int MaBaSi { get => maBaSi; set => maBaSi = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public byte GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}

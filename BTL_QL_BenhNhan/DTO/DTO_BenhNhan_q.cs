using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BenhNhan_q
    {
        private int ma;
        private string ten;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string CCCD;
        private float canNang;
        private int chieuCao;
        private string BHYT;
        private string tinhTrang;
        private string diaChi;
        //private int maBacSi;
        //private int maKhoa;

        private String maBacSi;
        private String maKhoa;



        public int Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
        public float CanNang { get => canNang; set => canNang = value; }
        public int ChieuCao { get => chieuCao; set => chieuCao = value; }
        public string BHYT1 { get => BHYT; set => BHYT = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public String MaBacSi { get => maBacSi; set => maBacSi = value; }
        public String MaKhoa { get => maKhoa; set => maKhoa = value; }

        public DTO_BenhNhan_q(int ma, string ten, string gioiTinh, DateTime ngaySinh, string cCCD, float canNang, int chieuCao, string bHYT, string tinhTrang, string diaChi, /*int maBacSi, int maKhoa*/ String maBacSi, String maKhoa)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            CCCD = cCCD;
            this.canNang = canNang;
            this.chieuCao = chieuCao;
            BHYT = bHYT;
            this.tinhTrang = tinhTrang;
            this.diaChi = diaChi;
            this.maBacSi = maBacSi;
            this.maKhoa = maKhoa;
        }
    }
}

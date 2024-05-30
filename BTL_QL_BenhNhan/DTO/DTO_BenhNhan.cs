using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BenhNhan
    {
        private int maBenhNhan;
        private string hoTen;
        private byte gioiTinh;
        private DateTime ngaySinh;
        private string cccd;
        private float canNang;
        private int chieuCao;
        private string bhyt;
        private string tinhTrang;
        private string diaChi;



        //
        private string maBacSi;  // thuực chất là tênBacSi  
        private string maKhoa; // thực chất là tenKhoa
        private DateTime ngayNhap;
        private DateTime ngayXuat;
        private byte anhBN;
        public DTO_BenhNhan()
        {
        }

        public DTO_BenhNhan(string hoTen, byte gioiTinh, string tinhTrang, string diaChi, string maKhoa, DateTime ngayNhap, DateTime ngayXuat, byte anhBN)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.tinhTrang = tinhTrang;
            this.diaChi = diaChi;
            this.MaKhoa = maKhoa;
            this.ngayNhap = ngayNhap;
            this.ngayXuat = ngayXuat;
            this.anhBN = anhBN;
        }

        public DTO_BenhNhan(int maBenhNhan, string hoTen, byte gioiTinh, DateTime ngaySinh, string cccd, 
                            float canNang, int chieuCao, string bhyt, string tinhTrang, string diaChi, string maBacSi, string maKhoa)
        {
            this.maBenhNhan = maBenhNhan;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
            this.canNang = canNang;
            this.chieuCao = chieuCao;
            this.bhyt = bhyt;
            this.tinhTrang = tinhTrang;
            this.diaChi = diaChi;
            this.MaBacSi = maBacSi;
            this.MaKhoa = maKhoa;
        }

        public int MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public byte GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string CCCD { get => cccd; set => cccd = value; }
        public float CanNang { get => canNang; set => canNang = value; }
        public int ChieuCao { get => chieuCao; set => chieuCao = value; }
        public string BHYT1 { get => bhyt; set => bhyt = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaBacSi { get => maBacSi; set => maBacSi = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}

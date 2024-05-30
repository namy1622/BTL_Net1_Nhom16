using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BenhAn
    {
        private string ten;
        private string gioiTinh;
        private int maKhoa;
        private string tinhTrang;
        private string diachi;
        private string ngayNhap;
        private string ngayXuat;
        private byte[] anhBenhNhan;
        public DTO_BenhAn()
        {

        }
        public DTO_BenhAn(string ten, string gioiTinh, int maKhoa, string tinhTrang, string diachi, string ngayNhap, string ngayXuat, byte[] anhBenhNhan)
        {
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.maKhoa = maKhoa;
            this.tinhTrang = tinhTrang;
            this.diachi = diachi;
            this.ngayNhap = ngayNhap;
            this.ngayXuat = ngayXuat;
            this.anhBenhNhan = anhBenhNhan;
        }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        public byte[] AnhBenhNhan { get => anhBenhNhan; set => anhBenhNhan = value; }
    }
}

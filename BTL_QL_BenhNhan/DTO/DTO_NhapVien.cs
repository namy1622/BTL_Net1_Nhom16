using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhapVien
    {
        private int maNhapVien;
        private int maBenhNhan;
        private string benh;
        private DateTime ngayNhapVien;
        private int maPhong;
        private DateTime ngayXuat;
        private int maHoaDon;

        private byte[] anhBenhNhan;
        public DTO_NhapVien()
        {
        }

        public DTO_NhapVien(byte[] anhBenhNhan)
        {
            this.anhBenhNhan = anhBenhNhan;
        }

        public DTO_NhapVien(int maNhapVien, int maBenhNhan, string benh, DateTime ngayNhapVien,
                            int maPhong, DateTime ngayXuat, int maHoaDon, byte[] anhBenhNhan)
        {
            this.maNhapVien = maNhapVien;
            this.maBenhNhan = maBenhNhan;
            this.benh = benh;
            this.ngayNhapVien = ngayNhapVien;
            this.maPhong = maPhong;
            this.ngayXuat = ngayXuat;
            this.maHoaDon = maHoaDon;
            this.anhBenhNhan = anhBenhNhan;

        }

        public int MaNhapVien { get => maNhapVien; set => maNhapVien = value; }
        public int MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public string Benh { get => benh; set => benh = value; }
        public DateTime NgayNhapVien { get => ngayNhapVien; set => ngayNhapVien = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public byte[] AnhBenhNhan { get => anhBenhNhan; set => anhBenhNhan = value; }
    }
}

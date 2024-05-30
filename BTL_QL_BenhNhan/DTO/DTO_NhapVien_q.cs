using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhapVien_q
    {
        // nhập viện
        public string ngayNhap;
        public string tinhTrang;
        public string lyDoKham;
        public string maPhong;
        //bệnh nhân
        public string ten;
        public string gioiTinh;
        public string ngaySinh;
        public string diaChi;
        public string canNang;
        public string chieuCao;
        public string maBacSi;
        public string maKhoa;
        public string CCCD;
        public string BHYT;
        public byte[] imageByte;
        public DTO_NhapVien_q()
        {

        }
        public DTO_NhapVien_q(string ngaynhap, string tinhtrang, string lydokham, string maphong, string ten, string gioitinh, string ngaysinh, string diachi, string cannang, string chieucao, string mabacsi, string makhoa, string cccd, string bhyt, byte[] imageByte)
        {
            this.imageByte = imageByte;
            this.ngayNhap = ngaynhap;
            this.tinhTrang = tinhtrang;
            this.lyDoKham = lydokham;
            this.maPhong = maphong;
            this.ten = ten;
            this.gioiTinh = gioitinh;
            this.ngaySinh = ngaysinh;
            this.diaChi = diachi;
            this.canNang = cannang;
            this.chieuCao = chieucao;
            this.maBacSi = mabacsi;
            this.maKhoa = makhoa;
            this.CCCD = cccd;
            this.BHYT = bhyt;
        }

        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string LyDoKham { get => lyDoKham; set => lyDoKham = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string CanNang { get => canNang; set => canNang = value; }
        public string ChieuCao { get => chieuCao; set => chieuCao = value; }
        public string MaBacSi { get => maBacSi; set => maBacSi = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string CCCDS { get => CCCD; set => CCCD = value; }
        public string BHYTS { get => BHYT; set => BHYT = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
       // private int _id;
        private string _taiKhoan;
        private string _matKhau;
        private string _soDienThoai;

        private string _emailXacNhan;

        public DTO_TaiKhoan( string taiKhoan, string matKhau, string soDienThoai)
        {
            //this._id = id;
            this._taiKhoan = taiKhoan;
            this._matKhau = matKhau;
            this._soDienThoai = soDienThoai;

        }

        public DTO_TaiKhoan(string emailXacNhan)
        {
            this._emailXacNhan = emailXacNhan;
        }

        //public int Id { get => _id; set => _id = value; }
        public string Tai_Khoan { get => _taiKhoan; set => _taiKhoan = value; }
        public string Mat_Khau { get => _matKhau; set => _matKhau = value; }
        public string So_Dien_Thoai { get => _soDienThoai; set => _soDienThoai = value; }
        public string EmailXacNhan { get => _emailXacNhan; set => _emailXacNhan = value; }
    }
}

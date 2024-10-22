using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL khachHangDAL = new KhachHangDAL();

        public List<KhachHang> LayTatCaKhachHang()
        {
            return khachHangDAL.LayTatCaKhachHang();
        }

        public bool CheckKhachHangTonTai(string maKhachHang)
        {
            return khachHangDAL.CheckKhachHangTonTai(maKhachHang);
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            return khachHangDAL.ThemKhachHang(khachHang);
        }

        public bool SuaKhachHang(KhachHang khachHang)
        {
            return khachHangDAL.SuaKhachHang(khachHang);
        }

        public bool XoaKhachHang(string maKhachHang)
        {
            return khachHangDAL.XoaKhachHang(maKhachHang);
        }
    }
}

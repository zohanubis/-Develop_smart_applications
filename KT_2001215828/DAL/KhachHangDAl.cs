using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class KhachHangDAL
    {
        private QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();

        // Lấy tất cả khách hàng
        public List<KhachHang> LayTatCaKhachHang()
        {
            return db.KhachHangs.ToList();
        }

        public bool CheckKhachHangTonTai(string maKhachHang)
        {
            return db.KhachHangs.Any(k => k.MaKhachHang == maKhachHang);
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            try
            {
                if (CheckKhachHangTonTai(khachHang.MaKhachHang))
                {
                    return false; 
                }
                db.KhachHangs.InsertOnSubmit(khachHang);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaKhachHang(KhachHang khachHang)
        {
            try
            {
                KhachHang kh = db.KhachHangs.SingleOrDefault(k => k.MaKhachHang == khachHang.MaKhachHang);
                if (kh != null)
                {
                    kh.HoTen = khachHang.HoTen;
                    kh.DiaChi = khachHang.DiaChi;
                    kh.DienThoai = khachHang.DienThoai;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaKhachHang(string maKhachHang)
        {
            try
            {
                KhachHang kh = db.KhachHangs.SingleOrDefault(k => k.MaKhachHang == maKhachHang);
                if (kh != null)
                {
                    db.KhachHangs.DeleteOnSubmit(kh);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}

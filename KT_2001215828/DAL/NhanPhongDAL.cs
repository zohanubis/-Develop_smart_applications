using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class NhanPhongDAL
    {
        private QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();

        public List<NhanPhong> LayTatCaNhanPhong()
        {
            return db.NhanPhongs.ToList();
        }

        public bool ThemNhanPhong(NhanPhong nhanPhong)
        {
            try
            {
                db.NhanPhongs.InsertOnSubmit(nhanPhong);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaNhanPhong(NhanPhong nhanPhong)
        {
            try
            {
                NhanPhong np = db.NhanPhongs.SingleOrDefault(n => n.MaNhanPhong == nhanPhong.MaNhanPhong);
                if (np != null)
                {
                    np.MaKhachHang = nhanPhong.MaKhachHang;
                    np.MaPhong = nhanPhong.MaPhong;
                    np.NgayVao = nhanPhong.NgayVao;
                    np.NgayDi = nhanPhong.NgayDi;
                    np.ThanhTien = nhanPhong.ThanhTien;
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

        // Xóa thông tin nhận phòng
        public bool XoaNhanPhong(string maNhanPhong)
        {
            try
            {
                NhanPhong np = db.NhanPhongs.SingleOrDefault(n => n.MaNhanPhong == maNhanPhong);
                if (np != null)
                {
                    db.NhanPhongs.DeleteOnSubmit(np);
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

using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class PhongDAL
    {
        private QuanLyKhachSanDataContext db = new QuanLyKhachSanDataContext();

        // Lấy tất cả phòng
        public List<Phong> LayTatCaPhong()
        {
            return db.Phongs.ToList();
        }

        // Kiểm tra nếu mã phòng tồn tại
        public bool CheckPhongTonTai(string maPhong)
        {
            return db.Phongs.Any(p => p.MaPhong == maPhong);
        }

        // Thêm phòng
        public bool ThemPhong(Phong phong)
        {
            try
            {
                if (CheckPhongTonTai(phong.MaPhong))
                {
                    return false; // Trả về false nếu mã phòng đã tồn tại
                }
                db.Phongs.InsertOnSubmit(phong);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Sửa thông tin phòng
        public bool SuaPhong(Phong phong)
        {
            try
            {
                Phong p = db.Phongs.SingleOrDefault(ph => ph.MaPhong == phong.MaPhong);
                if (p != null)
                {
                    p.SoNguoi = phong.SoNguoi;
                    p.DonGia = phong.DonGia;
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

        // Xóa phòng
        public bool XoaPhong(string maPhong)
        {
            try
            {
                Phong phong = db.Phongs.SingleOrDefault(p => p.MaPhong == maPhong);
                if (phong != null)
                {
                    db.Phongs.DeleteOnSubmit(phong);
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

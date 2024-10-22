using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class NhanPhongBLL
    {
        private NhanPhongDAL nhanPhongDAL = new NhanPhongDAL();
        private KhachHangBLL khachHangBLL = new KhachHangBLL();
        private PhongBLL phongBLL = new PhongBLL();

        // Lấy tất cả thông tin nhận phòng
        public List<NhanPhong> LayTatCaNhanPhong()
        {
            return nhanPhongDAL.LayTatCaNhanPhong();
        }

        // Thêm mới nhận phòng
        public bool ThemNhanPhong(NhanPhong nhanPhong)
        {
            // Kiểm tra khóa ngoại: Mã khách hàng và mã phòng phải tồn tại
            if (!khachHangBLL.CheckKhachHangTonTai(nhanPhong.MaKhachHang) ||
                !phongBLL.CheckPhongTonTai(nhanPhong.MaPhong))
            {
                return false; // Trả về false nếu khóa ngoại không hợp lệ
            }

            return nhanPhongDAL.ThemNhanPhong(nhanPhong);
        }

        // Sửa thông tin nhận phòng
        public bool SuaNhanPhong(NhanPhong nhanPhong)
        {
            // Kiểm tra khóa ngoại: Mã khách hàng và mã phòng phải tồn tại
            if (!khachHangBLL.CheckKhachHangTonTai(nhanPhong.MaKhachHang) ||
                !phongBLL.CheckPhongTonTai(nhanPhong.MaPhong))
            {
                return false; // Trả về false nếu khóa ngoại không hợp lệ
            }

            return nhanPhongDAL.SuaNhanPhong(nhanPhong);
        }

        // Xóa thông tin nhận phòng
        public bool XoaNhanPhong(string maNhanPhong)
        {
            return nhanPhongDAL.XoaNhanPhong(maNhanPhong);
        }
    }
}

using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class DiemBLL
    {
        private DiemDAL diemDal = new DiemDAL();

        public List<Diem> LayDiemTheoSinhVienMonHoc(string maSinhVien, string maMonHoc)
        {
            return diemDal.GetDiemBySinhVienMonHoc(maSinhVien, maMonHoc);
        }

        // Thêm điểm
        public bool ThemDiem(Diem diem, out string error)
        {
            error = "";

            if (string.IsNullOrEmpty(diem.MaSinhVien))
            {
                error = "Mã sinh viên không được để trống.";
                return false;
            }

            if (string.IsNullOrEmpty(diem.MaMonHoc))
            {
                error = "Mã môn học không được để trống.";
                return false;
            }

            if (diem.Diem1 < 0 || diem.Diem1 > 10)
            {
                error = "Điểm không hợp lệ. Điểm phải từ 0 đến 10.";
                return false;
            }

            return diemDal.ThemDiem(diem);
        }

        public bool SuaDiem(Diem diem, out string error)
        {
            error = "";

            if (string.IsNullOrEmpty(diem.MaSinhVien))
            {
                error = "Mã sinh viên không được để trống.";
                return false;
            }

            if (string.IsNullOrEmpty(diem.MaMonHoc))
            {
                error = "Mã môn học không được để trống.";
                return false;
            }

            if (diem.Diem1 < 0 || diem.Diem1 > 10)
            {
                error = "Điểm không hợp lệ. Điểm phải từ 0 đến 10.";
                return false;
            }

            return diemDal.SuaDiem(diem);
        }

        public bool XoaDiem(string maSinhVien, string maMonHoc)
        {
            return diemDal.XoaDiem(maSinhVien, maMonHoc);
        }
    }
}

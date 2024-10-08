using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class SinhVienBLL
    {
        private SinhVienDAL sinhVienDal = new SinhVienDAL();

        public List<SinhVien> LayDanhSachSinhVienTheoLop(string maLop)
        {
            return sinhVienDal.GetSinhVienByLop(maLop);
        }
    }
}

using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class PhongBLL
    {
        private PhongDAL phongDAL = new PhongDAL();

        public List<Phong> LayTatCaPhong()
        {
            return phongDAL.LayTatCaPhong();
        }

        public bool CheckPhongTonTai(string maPhong)
        {
            return phongDAL.CheckPhongTonTai(maPhong);
        }

        public bool ThemPhong(Phong phong)
        {
            return phongDAL.ThemPhong(phong);
        }

        public bool SuaPhong(Phong phong)
        {
            return phongDAL.SuaPhong(phong);
        }

        public bool XoaPhong(string maPhong)
        {
            return phongDAL.XoaPhong(maPhong);
        }
    }
}

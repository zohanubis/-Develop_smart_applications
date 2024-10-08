using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class MonHocBLL
    {
        MonHocDAL dalMH = new MonHocDAL();
        public MonHocBLL() { }

        public List<MonHoc> GetMonHoc()
        {
            return dalMH.LoadMH();
        }
        public bool ThemMonHoc(MonHoc pMonHoc, out string error)
        {
            error = "";

            if (string.IsNullOrEmpty(pMonHoc.MaMonHoc))
            {
                error = "Mã môn học không được để trống.";
                return false;
            }

            if (string.IsNullOrEmpty(pMonHoc.TenMonHoc))
            {
                error = "Tên môn học không được để trống.";
                return false;
            }

            if (dalMH.LoadMH().Exists(mh => mh.MaMonHoc == pMonHoc.MaMonHoc))
            {
                error = "Mã môn học đã tồn tại.";
                return false;
            }

            return dalMH.ThemMonHoc(pMonHoc);
        }
        public bool XoaMonHoc(string maMonHoc)
        {
            return dalMH.XoaMonHoc(maMonHoc);
        }

        public bool SuaMonHoc(MonHoc monHoc)
        {
            return dalMH.SuaMonHoc(monHoc);
        }

        public bool KiemTraKhoaNgoai(string maMonHoc)
        {
            return dalMH.KiemTraKhoaNgoai(maMonHoc);
        }

    }
}

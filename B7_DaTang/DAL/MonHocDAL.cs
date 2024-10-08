using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class MonHocDAL
    {
        QLSINHVIENDataContext qlsv = new QLSINHVIENDataContext();
        public MonHocDAL() {  }

        public List<MonHoc> LoadMH()
        {
            return qlsv.MonHocs.Select(mh => mh).ToList<MonHoc>();
        }
        public bool ThemMonHoc(MonHoc pMonHoc)
        {
            try
            {
                qlsv.MonHocs.InsertOnSubmit(pMonHoc);
                qlsv.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaMonHoc(string maMonHoc)
        {
            try
            {
                var monHoc = qlsv.MonHocs.SingleOrDefault(mh => mh.MaMonHoc == maMonHoc);
                if (monHoc != null)
                {
                    qlsv.MonHocs.DeleteOnSubmit(monHoc);
                    qlsv.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaMonHoc(MonHoc monHoc)
        {
            try
            {
                var existingMonHoc = qlsv.MonHocs.SingleOrDefault(mh => mh.MaMonHoc == monHoc.MaMonHoc);
                if (existingMonHoc != null)
                {
                    existingMonHoc.TenMonHoc = monHoc.TenMonHoc;
                    qlsv.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool KiemTraKhoaNgoai(string maMonHoc)
        {
            return qlsv.Diems.Any(d => d.MaMonHoc == maMonHoc);
        }

    }
}

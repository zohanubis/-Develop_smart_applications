using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class SinhVienDAL
    {
        private QLSINHVIENDataContext qlsv = new QLSINHVIENDataContext();

        public List<SinhVien> GetSinhVienByLop(string maLop)
        {
            var sinhViens = from sv in qlsv.SinhViens
                            where sv.MaLop == maLop
                            select sv;
            return sinhViens.ToList();
        }
    }
}

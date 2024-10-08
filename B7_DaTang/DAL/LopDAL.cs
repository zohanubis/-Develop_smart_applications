using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LopDAL
    {
        private QLSINHVIENDataContext qlsv = new QLSINHVIENDataContext();

        public List<Lop> GetLopByKhoa(string maKhoa)
        {
            var lops = from lp in qlsv.Lops
                       where lp.MaKhoa == maKhoa
                       select lp;
            return lops.ToList();
        }
    }
}

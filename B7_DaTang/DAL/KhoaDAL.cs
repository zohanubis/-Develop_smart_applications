using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KhoaDAL
    {
        private QLSINHVIENDataContext qlsv = new QLSINHVIENDataContext();

        public KhoaDAL() { }

        public List<Khoa> GetAllKhoa ()
        {
            var khoas = from kh in qlsv.Khoas
                        select kh;
            return khoas.ToList();
        }
    }
}

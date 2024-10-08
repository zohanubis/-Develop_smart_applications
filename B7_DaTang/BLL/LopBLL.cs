using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class LopBLL
    {
        private LopDAL lopDal = new LopDAL();

        public List<Lop> LayDanhSachLopTheoKhoa(string maKhoa)
        {
            return lopDal.GetLopByKhoa(maKhoa);
        }
    }
}

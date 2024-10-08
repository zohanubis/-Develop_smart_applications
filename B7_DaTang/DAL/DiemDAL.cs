using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DiemDAL
    {
        QLSINHVIENDataContext qlsv = new QLSINHVIENDataContext();
        public DiemDAL() { }
        public List<SinhVien> GetSinhVienByLop(string maLop)
        {
            var sinhViens = from sv in qlsv.SinhViens
                            where sv.MaLop == maLop
                            select sv;
            return sinhViens.ToList();
        }

        public List<Diem> GetDiemBySinhVienMonHoc(string maSinhVien, string maMonHoc)
        {
            var diems = from d in qlsv.Diems
                        where d.MaSinhVien == maSinhVien && d.MaMonHoc == maMonHoc
                        select d;
            return diems.ToList();
        }

        // Thêm điểm
        public bool ThemDiem(Diem diem)
        {
            try
            {
                qlsv.Diems.InsertOnSubmit(diem);
                qlsv.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaDiem(Diem diem)
        {
            try
            {
                var diemCu = qlsv.Diems.SingleOrDefault(d => d.MaSinhVien == diem.MaSinhVien && d.MaMonHoc == diem.MaMonHoc);
                if (diemCu != null)
                {
                    diemCu.Diem1 = diem.Diem1;
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

        public bool XoaDiem(string maSinhVien, string maMonHoc)
        {
            try
            {
                var diem = qlsv.Diems.SingleOrDefault(d => d.MaSinhVien == maSinhVien && d.MaMonHoc == maMonHoc);
                if (diem != null)
                {
                    qlsv.Diems.DeleteOnSubmit(diem);
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
    }
}

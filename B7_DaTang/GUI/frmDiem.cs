using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmDiem : Form
    {
        private KhoaBLL bllKhoa = new KhoaBLL();
        private LopBLL bllLop = new LopBLL();
        private SinhVienBLL bllSinhVien = new SinhVienBLL();
        private DiemBLL bllDiem = new DiemBLL();
        private MonHocBLL bllMonHoc = new MonHocBLL();

        public frmDiem()
        {
            InitializeComponent();
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhoa();
            LoadDanhSachMonHoc(); 
        }

        private void LoadDanhSachKhoa()
        {
            List<Khoa> khoas = bllKhoa.LayDanhSachKhoa();
            cmbKhoa.DataSource = khoas;
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
        }

        private void LoadDanhSachMonHoc()
        {
            List<MonHoc> monHocs = bllMonHoc.GetMonHoc();
            cmbMonHoc.DataSource = monHocs;
            cmbMonHoc.DisplayMember = "TenMonHoc";
            cmbMonHoc.ValueMember = "MaMonHoc";
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoa = cmbKhoa.SelectedValue.ToString();
            LoadDanhSachLop(maKhoa);
        }

        private void LoadDanhSachLop(string maKhoa)
        {
            List<Lop> lops = bllLop.LayDanhSachLopTheoKhoa(maKhoa);
            cmbLop.DataSource = lops;
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cmbLop.SelectedValue.ToString();
            LoadDanhSachSinhVien(maLop);
        }

        private void LoadDanhSachSinhVien(string maLop)
        {
            List<SinhVien> sinhViens = bllSinhVien.LayDanhSachSinhVienTheoLop(maLop);
            dataGridViewSinhVien.DataSource = sinhViens;
        }

        private void dataGridViewSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSinhVien.CurrentRow != null)
            {
                string maSinhVien = dataGridViewSinhVien.CurrentRow.Cells["MaSinhVien"].Value.ToString();
                LoadDanhSachDiem(maSinhVien);
            }
        }

        private void LoadDanhSachDiem(string maSinhVien)
        {
            string maMonHoc = cmbMonHoc.SelectedValue.ToString();
            List<Diem> diems = bllDiem.LayDiemTheoSinhVienMonHoc(maSinhVien, maMonHoc);
            dataGridViewDiem.DataSource = diems;
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            Diem diem = new Diem
            {
                MaSinhVien = txtMaSinhVien.Text,
                MaMonHoc = cmbMonHoc.SelectedValue.ToString(),
                Diem1 = float.Parse(txtDiem.Text)
            };

            string error;
            if (bllDiem.ThemDiem(diem, out error))
            {
                MessageBox.Show("Thêm điểm thành công!");
                LoadDanhSachDiem(txtMaSinhVien.Text);  
            }
            else
            {
                MessageBox.Show("Thêm điểm thất bại: " + error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text;
            string maMonHoc = cmbMonHoc.SelectedValue.ToString();

            if (bllDiem.XoaDiem(maSinhVien, maMonHoc))
            {
                MessageBox.Show("Xóa điểm thành công!");
                LoadDanhSachDiem(maSinhVien); 
            }
            else
            {
                MessageBox.Show("Xóa điểm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Diem diem = new Diem
            {
                MaSinhVien = txtMaSinhVien.Text,
                MaMonHoc = cmbMonHoc.SelectedValue.ToString(),
                Diem1 = float.Parse(txtDiem.Text)
            };

            string error;
            if (bllDiem.SuaDiem(diem, out error))
            {
                MessageBox.Show("Sửa điểm thành công!");
                LoadDanhSachDiem(txtMaSinhVien.Text); 
            }
            else
            {
                MessageBox.Show("Sửa điểm thất bại: " + error);
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

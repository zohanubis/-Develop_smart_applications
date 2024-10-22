using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmQuanLyKhachSan : Form
    {
        private NhanPhongBLL nhanPhongBLL = new NhanPhongBLL();
        private KhachHangBLL khachHangBLL = new KhachHangBLL();
        private PhongBLL phongBLL = new PhongBLL();

        public frmQuanLyKhachSan()
        {
            InitializeComponent();
            LoadDanhSachNhanPhong();
            LoadDanhSachMaKhachHang();
            LoadDanhSachMaPhong();
            txtMaNhanPhong.Enabled = false; // Tự động phát sinh, không cho phép chỉnh sửa trực tiếp
        }

        // Nạp danh sách nhận phòng
        private void LoadDanhSachNhanPhong()
        {
            dgvNhanPhong.DataSource = nhanPhongBLL.LayTatCaNhanPhong();
        }

        // Nạp danh sách mã khách hàng
        private void LoadDanhSachMaKhachHang()
        {
            cboMaKhachHang.DataSource = khachHangBLL.LayTatCaKhachHang();
            cboMaKhachHang.DisplayMember = "HoTen";
            cboMaKhachHang.ValueMember = "MaKhachHang";
        }

        // Nạp danh sách mã phòng
        private void LoadDanhSachMaPhong()
        {
            cboMaPhong.DataSource = phongBLL.LayTatCaPhong();
            cboMaPhong.DisplayMember = "MaPhong";
            cboMaPhong.ValueMember = "MaPhong";
        }

        // Phát sinh mã nhận phòng tự động
        private string PhatSinhMaNhanPhong()
        {
            string maPhong = cboMaPhong.SelectedValue.ToString();
            int count = nhanPhongBLL.LayTatCaNhanPhong().Count(n => n.MaPhong == maPhong) + 1;
            return $"{maPhong}-{count:D3}"; // Ví dụ: A101-001
        }

        // Thêm mới nhận phòng
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNhanPhong.Text = PhatSinhMaNhanPhong();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            dtpNgayVao.Value = DateTime.Now;
            dtpNgayRa.Value = DateTime.Now;
        }

        // Lưu thông tin nhận phòng
        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanPhong nhanPhong = new NhanPhong
            {
                MaNhanPhong = txtMaNhanPhong.Text,
                MaKhachHang = cboMaKhachHang.SelectedValue.ToString(),
                MaPhong = cboMaPhong.SelectedValue.ToString(),
                NgayVao = dtpNgayVao.Value,
                NgayDi = dtpNgayRa.Value,
                ThanhTien = TinhThanhTien()
            };

            // Kiểm tra xem đây là thêm mới hay cập nhật
            if (nhanPhongBLL.LayTatCaNhanPhong().Any(n => n.MaNhanPhong == nhanPhong.MaNhanPhong))
            {
                if (nhanPhongBLL.SuaNhanPhong(nhanPhong))
                {
                    MessageBox.Show("Cập nhật thông tin nhận phòng thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin.");
                }
            }
            else
            {
                if (nhanPhongBLL.ThemNhanPhong(nhanPhong))
                {
                    MessageBox.Show("Thêm mới thông tin nhận phòng thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể thêm mới thông tin.");
                }
            }

            LoadDanhSachNhanPhong();
        }

        // Tính thành tiền
        private decimal TinhThanhTien()
        {
            try
            {
                decimal donGia = decimal.Parse(txtDonGia.Text);
                TimeSpan soNgay = dtpNgayRa.Value.Date - dtpNgayVao.Value.Date;
                return donGia * (decimal)soNgay.TotalDays;
            }
            catch
            {
                return 0;
            }
        }

        // Chọn dữ liệu từ DataGridView để sửa hoặc xóa
        private void dgvNhanPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanPhong.Rows[e.RowIndex];
                txtMaNhanPhong.Text = row.Cells["MaNhanPhong"].Value.ToString();
                cboMaKhachHang.SelectedValue = row.Cells["MaKhachHang"].Value.ToString();
                cboMaPhong.SelectedValue = row.Cells["MaPhong"].Value.ToString();
                dtpNgayVao.Value = DateTime.Parse(row.Cells["NgayVao"].Value.ToString());
                dtpNgayRa.Value = DateTime.Parse(row.Cells["NgayDi"].Value.ToString());
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
            }
        }

        // Xóa thông tin nhận phòng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNhanPhong = txtMaNhanPhong.Text;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (nhanPhongBLL.XoaNhanPhong(maNhanPhong))
                {
                    MessageBox.Show("Xóa thông tin nhận phòng thành công!");
                    LoadDanhSachNhanPhong();
                }
                else
                {
                    MessageBox.Show("Không thể xóa thông tin.");
                }
            }
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Nút Tải Lại
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDanhSachNhanPhong();
        }

        // Chức năng Tìm Kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();
            var results = nhanPhongBLL.LayTatCaNhanPhong()
                .Where(n => n.MaNhanPhong.ToLower().Contains(keyword) ||
                            n.MaKhachHang.ToLower().Contains(keyword) ||
                            n.MaPhong.ToLower().Contains(keyword)).ToList();

            dgvNhanPhong.DataSource = results;
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaNhanPhong.Text))
            {
                txtMaNhanPhong.Enabled = false; // Không cho phép thay đổi mã nhận phòng khi sửa
                btnLuu.Enabled = true; // Kích hoạt nút lưu để cập nhật thông tin
                MessageBox.Show("Bạn có thể sửa thông tin, sau đó nhấn 'Lưu' để cập nhật.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }
    }
}

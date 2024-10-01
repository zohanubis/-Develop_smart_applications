using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B45_XayDungModule.Module_DNTableAdapters;

namespace B45_XayDungModule
{
    public partial class frmThemNguoiDungVaoNhom : Form
    {
        public frmThemNguoiDungVaoNhom()
        {
            InitializeComponent();
            qL_NhomNguoiDungComboBox.SelectedIndexChanged += QL_NhomNguoiDungComboBox_SelectedIndexChanged;
        }

        private void QL_NhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNhom = qL_NhomNguoiDungComboBox.SelectedValue.ToString();

            try
            {
                this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.Fill(this.module_DN.QL_NguoiDungNhomNguoiDung_DK, maNhom);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void qL_NguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.module_DN);
        }

        private void frmThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // Load dữ liệu cho bảng QL_NhomNguoiDung
            this.qL_NhomNguoiDungTableAdapter.Fill(this.module_DN.QL_NhomNguoiDung);
            // Load dữ liệu cho bảng QL_NguoiDung
            this.qL_NguoiDungTableAdapter.Fill(this.module_DN.QL_NguoiDung);
            // Load dữ liệu ban đầu cho DataGridView người dùng thuộc nhóm
            if (qL_NhomNguoiDungComboBox.Items.Count > 0)
            {
                string maNhom = qL_NhomNguoiDungComboBox.SelectedValue.ToString();
                this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.Fill(this.module_DN.QL_NguoiDungNhomNguoiDung_DK, maNhom);
            }
        }
      
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.Fill(this.module_DN.QL_NguoiDungNhomNguoiDung_DK, nhomNDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Logic cho nút Insert - Thêm người dùng vào nhóm
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (qL_NguoiDungDataGridView.SelectedRows.Count > 0)
            {
                string tenDangNhap = qL_NguoiDungDataGridView.SelectedRows[0].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                string maNhom = qL_NhomNguoiDungComboBox.SelectedValue.ToString();

                try
                {
                    // Kiểm tra xem người dùng đã thuộc nhóm chưa
                    var existingRows = module_DN.QL_NguoiDungNhomNguoiDung_DK.Where(r => r.TenDangNhap == tenDangNhap && r.MaNhomNguoiDung == maNhom);
                    if (existingRows.Any())
                    {
                        MessageBox.Show("Người dùng đã thuộc nhóm này.");
                        return;
                    }

                    // Thêm người dùng vào nhóm
                    this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.Insert(tenDangNhap, maNhom, "Ghi chú (nếu cần)");

                    MessageBox.Show("Thêm người dùng vào nhóm thành công!");
                    // Cập nhật lại DataGridView
                    this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.Fill(this.module_DN.QL_NguoiDungNhomNguoiDung_DK, maNhom);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng để thêm.");
            }
        }

        // Logic cho nút Delete - Xóa người dùng khỏi nhóm
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (qL_NguoiDungNhomNguoiDung_DKDataGridView.SelectedRows.Count > 0)
            {
                string tenDangNhap = qL_NguoiDungNhomNguoiDung_DKDataGridView.SelectedRows[0].Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                string maNhom = qL_NhomNguoiDungComboBox.SelectedValue.ToString();

                try
                {
                    // Xóa người dùng khỏi nhóm
                    this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.Xoa(tenDangNhap, maNhom);

                    MessageBox.Show("Xóa người dùng khỏi nhóm thành công!");
                    // Cập nhật lại DataGridView
                    this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.Fill(this.module_DN.QL_NguoiDungNhomNguoiDung_DK, maNhom);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa người dùng: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng để xóa.");
            }
        }
    }
}

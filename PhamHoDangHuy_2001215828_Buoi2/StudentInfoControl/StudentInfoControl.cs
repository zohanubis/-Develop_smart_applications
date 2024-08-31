using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SqlClass;
using System.Data.SqlTypes;

namespace StudentInfoControl
{
    public partial class StudentInfoControl : UserControl
    {
        private SqlHelper sqlHelper = new SqlHelper();
        public StudentInfoControl()
        {
            InitializeComponent();
        }

        private void txtMSSV_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadStudentInfo(txtMSSV.Text);
            }
        }
        private void LoadStudentInfo(string mssv)
        {
            string query = $"SELECT HoTen, NgaySinh, GioiTinh, MaLop, CMND FROM SinhVien WHERE Mssv = '{mssv}'";

            try
            {
                SqlDataReader reader = sqlHelper.ExecuteReader(query);

                if (reader.Read())
                {
                    lblHoTen.Text = reader["HoTen"].ToString();
                    lblNgaySinh.Text = reader["NgaySinh"].ToString();
                    lblGioiTinh.Text = reader["GioiTinh"].ToString();
                    lblMaLop.Text = reader["MaLop"].ToString();
                    lblCMND.Text = reader["CMND"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên với mã số này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearStudentInfo();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy thông tin sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearStudentInfo()
        {
            lblHoTen.Text = string.Empty;
            lblNgaySinh.Text = string.Empty;
            lblGioiTinh.Text = string.Empty;
            lblMaLop.Text = string.Empty;
            lblCMND.Text = string.Empty;
        }
    }
}

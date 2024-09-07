using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
using System.Data.SqlClient;


namespace StudentInfo
{
    public partial class StudentInfoControl: UserControl
    {
        private SqlClass dtsqlClass = new SqlClass();

        private String _cnn;

        public String Cnn
        {
            get { return _cnn; }
            set { _cnn = value; }
        }

        public StudentInfoControl()
        {
            InitializeComponent();
            this.txtMSSV.KeyDown += txtMSSV_KeyDown;

        }

        private void txtMSSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadStudentInfo(txtMSSV.Text.Trim());
            }
        }

        private void LoadStudentInfo(string mssv)
        {
            try
            {
                string query = "SELECT HoTen, NgaySinh, GioiTinh, MaLop, CMND FROM SinhVien WHERE MSSV = @MSSV";
                SqlParameter[] parameters = {
                new SqlParameter("@MSSV", mssv)
            };

                using (SqlDataReader reader = dtsqlClass.ExcuteReader(query))
                {

                    if (reader.Read())
                    {
                        lblHoTen.Text = reader["HoTen"].ToString();
                        lblNgaySinh.Text = DateTime.Parse(reader["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
                        lblGioiTinh.Text = reader["GioiTinh"].ToString();
                        lblMaLop.Text = reader["MaLop"].ToString();
                        lblCMND.Text = reader["CMND"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin sinh viên.");
                    }
                    reader.Close();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using SqlClassLibrary;

namespace UserControlSinhVien
{
    public partial class UserControlSinhVien : UserControl
    {
        SqlClass sqlClass = new SqlClass();

        private string _cnn;

        public string ConnectionString
        {
            get { return _cnn; }
            set { _cnn = value; }
        }

        public UserControlSinhVien()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_cnn))
            {
                MessageBox.Show("Chưa có chuỗi kết nối, vui lòng thiết lập trước!");
                return;
            }

            // Khởi tạo SqlClass với chuỗi kết nối đã truyền từ MainForm
            SqlClass sqlHelper = new SqlClass();
            sqlHelper.CreateConnection(_cnn);

            string mssv = txtMSSV.Text.Trim();

            if (string.IsNullOrEmpty(mssv))
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên!");
                return;
            }

            // Truy vấn SQL để lấy thông tin sinh viên
            string query = $"SELECT * FROM SinhVien WHERE MSSV = '{mssv}'";

            DataTable studentInfo = sqlHelper.ExecuteQuery(query);

            if (studentInfo.Rows.Count > 0)
            {
                DataRow row = studentInfo.Rows[0];
                txtStudentName.Text = row["HoTen"].ToString();
                txtBirthdate.Text = Convert.ToDateTime(row["NgaySinh"]).ToString("dd/MM/yyyy");
                txtGender.Text = row["GioiTinh"].ToString();
                txtClassID.Text = row["MaLop"].ToString();
                txtCMND.Text = row["CMND"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với MSSV này.");
            }
        }
    }
}

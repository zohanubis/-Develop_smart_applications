using System.Data.Sql;
using System.Data.SqlClient;

namespace UserControlSinhVien
{
    public partial class UserControlSinhVien : UserControl
    {
        // Đối tượng SqlConnection
        private SqlConnection _cnn;

        // Thuộc tính cho SqlConnection, kết nối với chuỗi truyền vào từ MainForm
        public SqlConnection Connection
        {
            get { return _cnn; }
            set { _cnn = value; }
        }

        public string MSSV { get; set; }
        public UserControlSinhVien()
        {
            InitializeComponent();
        }
        // Hàm gọi khi nhấn Enter sau khi nhập MSSV
        public void LoadStudentInfo(string mssv)
        {
            if (_cnn == null)
            {
                MessageBox.Show("Chưa có kết nối đến cơ sở dữ liệu.");
                return;
            }

            try
            {
                _cnn.Open();
                string query = "SELECT * FROM SinhVien WHERE MSSV = @MSSV";
                SqlCommand command = new SqlCommand(query, _cnn);
                command.Parameters.AddWithValue("@MSSV", mssv);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Cập nhật thông tin lên giao diện
                    lblMSSV.Text = reader["MSSV"].ToString();
                    lblTenSinhVien.Text = reader["TenSinhVien"].ToString();
                    lblMaLop.Text = reader["MaLop"].ToString();
                    lblNgaySinh.Text = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy");
                    lblGioiTinh.Text = reader["GioiTinh"].ToString();
                    lblCMND.Text = reader["CMND"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin sinh viên.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin sinh viên: " + ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
        }
    }
}

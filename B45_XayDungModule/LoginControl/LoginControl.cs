using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginControl
{
    public partial class LoginControl : UserControl
    {
        private string cnn;

        public string Cnn { get => cnn; set => cnn = value; }


        public event EventHandler LoginSuccessful;
        public event EventHandler LoginCancelled;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /// Logic đăng nhập sử dụng chuỗi kết nối
            if (string.IsNullOrEmpty(Cnn))
            {
                MessageBox.Show("Chuỗi kết nối không được cấu hình.", "Lỗi");
                return;
            }

            // Ví dụ: Thực hiện kiểm tra đăng nhập với cơ sở dữ liệu
            if (CheckLogin(txtUsername.Text, txtPassword.Text))
            {
                LoginSuccessful?.Invoke(this, EventArgs.Empty);  // Phát sinh sự kiện đăng nhập thành công
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginCancelled?.Invoke(this, EventArgs.Empty); 
        }
        private bool CheckLogin(string username, string password)
        {
           using(SqlConnection conn  = new SqlConnection(Cnn))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM QL_NguoiDung WHERE TenDangNhap = @username AND MatKhau = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = (int)cmd.ExecuteScalar();

                    return result == 1;
                }
                catch (Exception ex){
                    MessageBox.Show("Lỗi kết nối hoặc truy vấn SQL: " + ex.Message, "Lỗi");
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}

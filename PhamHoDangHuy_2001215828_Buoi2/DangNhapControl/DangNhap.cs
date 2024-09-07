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


namespace DangNhapControl
{
    public partial class DangNhap : UserControl
    {
        private SqlClass sqlClass;
        private String cnn = "Data Source=A102PC21\\CSSQL08;Initial Catalog=QuanLiNguoiDung;Persist Security Info=True;User ID=sa;Password=123";

        public DangNhap()
        {
            InitializeComponent();
            this.btnLogin.Click += btnLogin_Click;
            sqlClass = new SqlClass();
        }

        void btnLogin_Click(object sender, EventArgs e)
        {

            sqlClass.CreateConnection(cnn);
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin.");
            }
        }
        private bool ValidateLogin(string username, string password)
        {
            sqlClass.CreateConnection(cnn);
            string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };

            object result = sqlClass.ExecuteScalarWithParameters(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

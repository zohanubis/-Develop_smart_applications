using SqlClass;
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



namespace LoginControl
{
    public partial class LoginControl : UserControl
    {
        private SqlHelper sqlHelper = new SqlHelper();
        private String _cnn;

        public string Cnn { get => _cnn; set => _cnn = value; }

        public LoginControl()
        {
            InitializeComponent();
            this.btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
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
            string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };

            object result = sqlHelper.ExecuteScalarWithParameters(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }
    }
}

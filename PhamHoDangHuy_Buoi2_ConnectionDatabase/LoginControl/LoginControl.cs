using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using ThuVien;

namespace LoginControl
{
    public partial class LoginControl: UserControl
    {
        private SqlClass dtsqlClass =new SqlClass();

        private String _cnn;

        public String Cnn
        {
            get { return _cnn; }
            set { _cnn = value; }
        }

        public LoginControl()
        {
            InitializeComponent();
            this.btnLogin.Click += btnLogin_Click;
        }

        void btnLogin_Click(object sender, EventArgs e)
        {
            dtsqlClass.CreateConnection(_cnn);
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
            dtsqlClass.CreateConnection(_cnn);
            string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };

            object result = dtsqlClass.ExecuteScalarWithParameters(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }
    }
}

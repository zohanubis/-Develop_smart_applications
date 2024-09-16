using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_PhamHoDangHuy.GUI
{
    public partial class frmDangNhap : Form
    {
        private MainForm mainForm;
        public frmDangNhap(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Giả lập kiểm tra đăng nhập
            if (username == "admin" && password == "123456")
            {
                mainForm.UpdateStatusBar($"Chào mừng người dùng: {username}");
                this.Close();
            }
            else {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

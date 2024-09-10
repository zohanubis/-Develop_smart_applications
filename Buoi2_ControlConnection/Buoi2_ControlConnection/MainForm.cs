using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_ControlConnection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Thiết lập chuỗi kết nối khi form load
            string connectionString = "Data Source=DESKTOP-EKR82M7;Initial Catalog=QuanLiNguoiDung;Persist Security Info=True;User ID=sa;Password=123456;";

            userControlSinhVien1.ConnectionString = connectionString;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            this.Close();
        }
    }
}

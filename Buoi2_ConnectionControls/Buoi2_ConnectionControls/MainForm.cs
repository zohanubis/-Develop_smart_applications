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

namespace Buoi2_ConnectionControls
{
    public partial class MainForm : Form
    {
        private SqlConnection _connection;

        public MainForm()
        {
            InitializeComponent();
            // Khởi tạo chuỗi kết nối
            string connectionString = "Data Source=DESKTOP-EKR82M7;Initial Catalog=QuanLiNguoiDung;Persist Security Info=True;User ID=sa;Password=123456;Trust Server Certificate=True";
            _connection = new SqlConnection(connectionString);

            // Truyền chuỗi kết nối vào UserControl
        }
    }
}

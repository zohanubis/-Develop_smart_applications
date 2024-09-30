using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B45_XayDungModule
{
    public partial class frmCauHinh : Form
    {
        public frmCauHinh()
        {
            InitializeComponent();
            this.btnSave.Click += BtnSave_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // // Logic để lưu cấu hình vào Settings hoặc nơi lưu trữ tùy chọn
            //string serverName = cmbServerName.Text;
            //string username = txtUsername.Text;
            //string password = txtPassword.Text;
            //string database = cmbDatabase.Text;

            //// Ví dụ lưu vào Settings (hoặc sử dụng phương pháp khác)
            //Properties.Settings.Default.ServerName = serverName;
            //Properties.Settings.Default.Username = username;
            //Properties.Settings.Default.Password = password;
            //Properties.Settings.Default.Database = database;
            //Properties.Settings.Default.Save();

            //MessageBox.Show("Cấu hình đã được lưu!", "Thông báo");
            //this.Close(); // Đóng form sau khi lưu
        }
    }
}

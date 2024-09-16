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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Xin chào người dùng ...";
            frmDangNhap frmLogin = new frmDangNhap(this);
            frmLogin.ShowDialog();
        }

        public void UpdateStatusBar(string message)
        {
            toolStripStatusLabel.Text = message;
        }
    }
}

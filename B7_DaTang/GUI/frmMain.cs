using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Mở form Quản lý Điểm
        private void quanLyDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiem frmDiem = new frmDiem();
            frmDiem.MdiParent = this;  // Đặt frmMain là MDI Parent
            frmDiem.Show();
        }

        // Mở form Quản lý Môn Học
        private void quanLyMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc frmMonHoc = new frmMonHoc();
            frmMonHoc.MdiParent = this;  // Đặt frmMain là MDI Parent
            frmMonHoc.Show();
        }
    }
}

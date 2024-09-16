using System;
using System.Windows.Forms; 

namespace StudentManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            if (!string.IsNullOrEmpty(mssv))
            {
                studentInfoControl1.LoadStudentInfo(mssv);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

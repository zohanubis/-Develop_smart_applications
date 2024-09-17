using System;
using System.IO;
using System.Windows.Forms;

namespace StudentInfoControl
{
    public partial class StudentInfoControl : UserControl
    {
        
        public StudentInfoControl()
        {
            InitializeComponent();
        }
        public void LoadStudentInfo(string studentId)
        {
            try
            {
                string[] lines = File.ReadAllLines("students.txt");
                foreach (string line in lines)
                {
                    var parts = line.Split('|');
                    if (parts[0] == studentId)
                    { 
                        txtMSSV.Text = parts[0];
                        txtTenSinhVien.Text = parts[1];
                        txtNgaySinh.Text = parts[2];
                        txtMaLop.Text = parts[3];
                        txtCMND.Text = parts[4];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file:{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

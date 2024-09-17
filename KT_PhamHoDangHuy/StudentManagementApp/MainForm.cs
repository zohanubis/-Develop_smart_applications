using System;
using System.Windows.Forms;
using ThuVien; 
using CustomControls; 

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

        private void BtnCheckPassword_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            bool isStrong = PasswordValidator.IsStrongPassword(password);

            if (isStrong)
            {
                lblPasswordStrength.Text = "Mật khẩu mạnh";
                lblPasswordStrength.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblPasswordStrength.Text = "Mật khẩu yếu";
                lblPasswordStrength.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void BtnGenerateCode_Click(object sender, EventArgs e)
        {
            int userDefinedValue = 99;
            string generatedCode = CodeGenerator.GenerateAutoCode(userDefinedValue);
            txtGeneratedCode.Text = generatedCode;
        }
    }
}

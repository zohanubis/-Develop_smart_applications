using System.Windows.Forms;
namespace StudentManagementApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private CustomControls.MaSinhTuDong_Textbox maSinhTuDongTextBox; // Custom Control từ bài 1
        private TextBox txtPassword;
        private Label lblPasswordStrength;
        private Button btnCheckPassword;
        private TextBox txtGeneratedCode;
        private Button btnGenerateCode;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.maSinhTuDongTextBox = new CustomControls.MaSinhTuDong_Textbox();
            this.txtPassword = new TextBox();
            this.lblPasswordStrength = new Label();
            this.btnCheckPassword = new Button();
            this.txtGeneratedCode = new TextBox();
            this.btnGenerateCode = new Button();

            this.SuspendLayout();

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Location = new System.Drawing.Point(220, 53);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(0, 16);
            this.lblPasswordStrength.TabIndex = 2;
            // 
            // btnCheckPassword
            // 
            this.btnCheckPassword.Location = new System.Drawing.Point(12, 80);
            this.btnCheckPassword.Name = "btnCheckPassword";
            this.btnCheckPassword.Size = new System.Drawing.Size(100, 23);
            this.btnCheckPassword.TabIndex = 3;
            this.btnCheckPassword.Text = "Kiểm Tra";
            this.btnCheckPassword.UseVisualStyleBackColor = true;
            this.btnCheckPassword.Click += new System.EventHandler(this.BtnCheckPassword_Click);
            // 
            // txtGeneratedCode
            // 
            this.txtGeneratedCode.Location = new System.Drawing.Point(12, 130);
            this.txtGeneratedCode.Name = "txtGeneratedCode";
            this.txtGeneratedCode.ReadOnly = true;
            this.txtGeneratedCode.Size = new System.Drawing.Size(200, 22);
            this.txtGeneratedCode.TabIndex = 4;
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Location = new System.Drawing.Point(12, 160);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateCode.TabIndex = 5;
            this.btnGenerateCode.Text = "Sinh Mã";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.BtnGenerateCode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 220);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.txtGeneratedCode);
            this.Controls.Add(this.btnCheckPassword);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.maSinhTuDongTextBox);
            this.Name = "MainForm";
            this.Text = "Quản lý Sinh Viên";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

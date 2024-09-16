using System.Windows.Forms;
namespace StudentManagementApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private StudentInfoControl.StudentInfoControl studentInfoControl1;
        private TextBox txtMSSV;
        private Button btnTimKiem;

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
            this.studentInfoControl1 = new StudentInfoControl.StudentInfoControl();
            this.txtMSSV = new TextBox();
            this.btnTimKiem = new Button();
            this.SuspendLayout();
            // 
            // studentInfoControl1
            // 
            this.studentInfoControl1.Location = new System.Drawing.Point(12, 50);
            this.studentInfoControl1.Name = "studentInfoControl1";
            this.studentInfoControl1.Size = new System.Drawing.Size(300, 160);
            this.studentInfoControl1.TabIndex = 0;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(12, 12);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(200, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(220, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 220);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.studentInfoControl1);
            this.Name = "MainForm";
            this.Text = "Quản lý Sinh Viên";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

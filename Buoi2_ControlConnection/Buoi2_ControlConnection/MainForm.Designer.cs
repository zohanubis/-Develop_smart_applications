namespace Buoi2_ControlConnection
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.userControlSinhVien1 = new UserControlSinhVien.UserControlSinhVien();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            // 
            // userControlSinhVien1
            // 
            this.userControlSinhVien1.Location = new System.Drawing.Point(12, 50);
            this.userControlSinhVien1.Name = "userControlSinhVien1";
            this.userControlSinhVien1.Size = new System.Drawing.Size(450, 300);
            this.userControlSinhVien1.TabIndex = 0;

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(380, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Quản Lý Thông Tin Sinh Viên";

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.userControlSinhVien1);
            this.Name = "MainForm";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private UserControlSinhVien.UserControlSinhVien userControlSinhVien1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
    }
}


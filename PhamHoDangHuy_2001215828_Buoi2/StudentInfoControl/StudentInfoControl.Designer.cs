namespace StudentInfoControl
{
    partial class StudentInfoControl
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose để giải phóng tài nguyên
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Khởi tạo các thành phần giao diện
        private void InitializeComponent()
        {
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();

            // txtMSSV
            this.txtMSSV.Location = new System.Drawing.Point(20, 20);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(150, 20);
            this.txtMSSV.TabIndex = 0;
            this.txtMSSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMSSV_KeyDown);

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 60);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(70, 13);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên: ";

            // lblNgaySinh
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 100);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 13);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh: ";

            // lblGioiTinh
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 140);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(61, 13);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới tính: ";

            // lblMaLop
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(20, 180);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(55, 13);
            this.lblMaLop.TabIndex = 4;
            this.lblMaLop.Text = "Mã lớp: ";

            // lblCMND
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(20, 220);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(55, 13);
            this.lblCMND.TabIndex = 5;
            this.lblCMND.Text = "CMND: ";

            // StudentInfoControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.lblCMND);
            this.Name = "StudentInfoControl";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Khai báo các điều khiển trong giao diện
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblCMND;
    }
}

using System.Windows.Forms;
namespace StudentInfoControl
{
    partial class StudentInfoControl
    {
        private Label lblMSSV;
        private TextBox txtMSSV;
        private Label lblTenSinhVien;
        private TextBox txtTenSinhVien;
        private Label lblNgaySinh;
        private TextBox txtNgaySinh;
        private Label lblMaLop;
        private TextBox txtMaLop;
        private Label lblCMND;
        private TextBox txtCMND;

        private void InitializeComponent()
        {
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblTenSinhVien = new System.Windows.Forms.Label();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(10, 10);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(48, 16);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV:";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(100, 7);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(150, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // lblTenSinhVien
            // 
            this.lblTenSinhVien.AutoSize = true;
            this.lblTenSinhVien.Location = new System.Drawing.Point(10, 40);
            this.lblTenSinhVien.Name = "lblTenSinhVien";
            this.lblTenSinhVien.Size = new System.Drawing.Size(93, 16);
            this.lblTenSinhVien.TabIndex = 2;
            this.lblTenSinhVien.Text = "Tên Sinh Viên:";
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Location = new System.Drawing.Point(100, 37);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(150, 22);
            this.txtTenSinhVien.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(10, 70);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(72, 16);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(100, 67);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(150, 22);
            this.txtNgaySinh.TabIndex = 5;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(10, 100);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(55, 16);
            this.lblMaLop.TabIndex = 6;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(100, 97);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(150, 22);
            this.txtMaLop.TabIndex = 7;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(10, 130);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(50, 16);
            this.lblCMND.TabIndex = 8;
            this.lblCMND.Text = "CMND:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(100, 127);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(150, 22);
            this.txtCMND.TabIndex = 9;
            // 
            // StudentInfoControl
            // 
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lblTenSinhVien);
            this.Controls.Add(this.txtTenSinhVien);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.txtCMND);
            this.Name = "StudentInfoControl";
            this.Size = new System.Drawing.Size(300, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

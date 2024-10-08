namespace GUI
{
    partial class frmDiem
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.dataGridViewDiem = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox(); // Sử dụng ComboBox thay cho TextBox cho môn học
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.labelLop = new System.Windows.Forms.Label();
            this.labelMonHoc = new System.Windows.Forms.Label();
            this.labelMaSinhVien = new System.Windows.Forms.Label();
            this.labelDiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(50, 30);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(150, 24);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(50, 70);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(150, 24);
            this.cmbLop.TabIndex = 1;
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLop_SelectedIndexChanged);
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(30, 110);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(300, 250);
            this.dataGridViewSinhVien.TabIndex = 2;
            // 
            // dataGridViewDiem
            // 
            this.dataGridViewDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiem.Location = new System.Drawing.Point(350, 30);
            this.dataGridViewDiem.Name = "dataGridViewDiem";
            this.dataGridViewDiem.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewDiem.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(350, 190);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(450, 190);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(550, 190);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(650, 190);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 30);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(480, 240);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(150, 24);
            this.cmbMonHoc.TabIndex = 8;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(480, 280);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(150, 22);
            this.txtMaSinhVien.TabIndex = 9;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(480, 320);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(150, 22);
            this.txtDiem.TabIndex = 10;
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(650, 240);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(75, 30);
            this.btnWord.TabIndex = 11;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(650, 280);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 30);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Location = new System.Drawing.Point(10, 30);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(41, 17);
            this.labelKhoa.TabIndex = 13;
            this.labelKhoa.Text = "Khoa";
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Location = new System.Drawing.Point(10, 70);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(32, 17);
            this.labelLop.TabIndex = 14;
            this.labelLop.Text = "Lớp";
            // 
            // labelMonHoc
            // 
            this.labelMonHoc.AutoSize = true;
            this.labelMonHoc.Location = new System.Drawing.Point(400, 240);
            this.labelMonHoc.Name = "labelMonHoc";
            this.labelMonHoc.Size = new System.Drawing.Size(65, 17);
            this.labelMonHoc.TabIndex = 15;
            this.labelMonHoc.Text = "Môn học";
            // 
            // labelMaSinhVien
            // 
            this.labelMaSinhVien.AutoSize = true;
            this.labelMaSinhVien.Location = new System.Drawing.Point(400, 280);
            this.labelMaSinhVien.Name = "labelMaSinhVien";
            this.labelMaSinhVien.Size = new System.Drawing.Size(84, 17);
            this.labelMaSinhVien.TabIndex = 16;
            this.labelMaSinhVien.Text = "Mã sinh viên";
            // 
            // labelDiem
            // 
            this.labelDiem.AutoSize = true;
            this.labelDiem.Location = new System.Drawing.Point(400, 320);
            this.labelDiem.Name = "labelDiem";
            this.labelDiem.Size = new System.Drawing.Size(41, 17);
            this.labelDiem.TabIndex = 17;
            this.labelDiem.Text = "Điểm";
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.labelDiem);
            this.Controls.Add(this.labelMaSinhVien);
            this.Controls.Add(this.labelMonHoc);
            this.Controls.Add(this.labelLop);
            this.Controls.Add(this.labelKhoa);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.cmbMonHoc);  // Thay thế TextBox MonHoc bằng ComboBox
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewDiem);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.cmbKhoa);
            this.Name = "frmDiem";
            this.Text = "Quản Lý Điểm";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.DataGridView dataGridViewDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cmbMonHoc;  // ComboBox cho Môn học
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.Label labelMonHoc;
        private System.Windows.Forms.Label labelMaSinhVien;
        private System.Windows.Forms.Label labelDiem;
    }
}

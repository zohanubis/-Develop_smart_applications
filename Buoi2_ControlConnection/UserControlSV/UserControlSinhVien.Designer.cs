namespace UserControlSinhVien
{
    partial class UserControlSinhVien
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblClassID = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(20, 20);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(84, 16);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã sinh viên:";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(115, 17);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(200, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(325, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(20, 60);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(89, 16);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "Tên sinh viên:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(115, 57);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(285, 22);
            this.txtStudentName.TabIndex = 4;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(20, 100);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(70, 16);
            this.lblBirthdate.TabIndex = 5;
            this.lblBirthdate.Text = "Ngày sinh:";
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(115, 97);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.ReadOnly = true;
            this.txtBirthdate.Size = new System.Drawing.Size(285, 22);
            this.txtBirthdate.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 140);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 16);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Giới tính:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(115, 137);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(285, 22);
            this.txtGender.TabIndex = 8;
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Location = new System.Drawing.Point(20, 180);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(51, 16);
            this.lblClassID.TabIndex = 9;
            this.lblClassID.Text = "Mã lớp:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(115, 174);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.ReadOnly = true;
            this.txtClassID.Size = new System.Drawing.Size(285, 22);
            this.txtClassID.TabIndex = 10;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(20, 220);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(50, 16);
            this.lblCMND.TabIndex = 11;
            this.lblCMND.Text = "CMND:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(115, 217);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(285, 22);
            this.txtCMND.TabIndex = 12;
            // 
            // UserControlSinhVien
            // 
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.txtCMND);
            this.Name = "UserControlSinhVien";
            this.Size = new System.Drawing.Size(420, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;

        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.TextBox txtBirthdate;

        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;

        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.TextBox txtClassID;

        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtCMND;
    }
}

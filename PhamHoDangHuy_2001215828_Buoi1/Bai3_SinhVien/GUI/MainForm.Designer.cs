namespace Bai3_SinhVien.GUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.ComboBox cmbEthnicity;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblEthnicity;
        private System.Windows.Forms.Label lblProvinces;

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.cmbEthnicity = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();

            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblEthnicity = new System.Windows.Forms.Label();
            this.lblProvinces = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ tên:";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 1;
            this.txtName.PlaceholderText = "Họ tên";

            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 60);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 20);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Số điện thoại:";

            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(150, 55);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 27);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.PlaceholderText = "Số điện thoại";

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 27);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.PlaceholderText = "Email";

            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(30, 140);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(80, 20);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Ngày sinh:";

            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(150, 135);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(200, 27);
            this.txtBirthDate.TabIndex = 7;
            this.txtBirthDate.PlaceholderText = "Ngày sinh";

            // 
            // lblEthnicity
            // 
            this.lblEthnicity.AutoSize = true;
            this.lblEthnicity.Location = new System.Drawing.Point(30, 180);
            this.lblEthnicity.Name = "lblEthnicity";
            this.lblEthnicity.Size = new System.Drawing.Size(63, 20);
            this.lblEthnicity.TabIndex = 8;
            this.lblEthnicity.Text = "Dân tộc:";

            // 
            // cmbEthnicity
            // 
            this.cmbEthnicity.FormattingEnabled = true;
            this.cmbEthnicity.Location = new System.Drawing.Point(150, 175);
            this.cmbEthnicity.Name = "cmbEthnicity";
            this.cmbEthnicity.Size = new System.Drawing.Size(200, 28);
            this.cmbEthnicity.TabIndex = 9;

            // 
            // lblProvinces
            // 
            this.lblProvinces.AutoSize = true;
            this.lblProvinces.Location = new System.Drawing.Point(380, 20);
            this.lblProvinces.Name = "lblProvinces";
            this.lblProvinces.Size = new System.Drawing.Size(70, 20);
            this.lblProvinces.TabIndex = 10;
            this.lblProvinces.Text = "Tỉnh/Thành:";

            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(380, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 144);
            this.listBox1.TabIndex = 11;

            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(50, 220);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(100, 30);
            this.btnCreateNew.TabIndex = 12;
            this.btnCreateNew.Text = "Tạo Mới";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(170, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 270);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.lblEthnicity);
            this.Controls.Add(this.cmbEthnicity);
            this.Controls.Add(this.lblProvinces);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.btnSave);
            this.Name = "MainForm";
            this.Text = "Quản lý thông tin cá nhân";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

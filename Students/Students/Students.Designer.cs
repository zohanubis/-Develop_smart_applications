namespace Students
{
    partial class Students
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvInputData;
        private System.Windows.Forms.DataGridView dgvResultData;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtNV1;
        private System.Windows.Forms.TextBox txtNV2;
        private System.Windows.Forms.TextBox txtNV3;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblNV1;
        private System.Windows.Forms.Label lblNV2;
        private System.Windows.Forms.Label lblNV3;

        private System.Windows.Forms.Button btnImportExcel;

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
            this.dgvInputData = new System.Windows.Forms.DataGridView();
            this.dgvResultData = new System.Windows.Forms.DataGridView();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtNV1 = new System.Windows.Forms.TextBox();
            this.txtNV2 = new System.Windows.Forms.TextBox();
            this.txtNV3 = new System.Windows.Forms.TextBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblNV1 = new System.Windows.Forms.Label();
            this.lblNV2 = new System.Windows.Forms.Label();
            this.lblNV3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultData)).BeginInit();
            this.SuspendLayout();

            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnImportExcel.Location = new System.Drawing.Point(420, 17);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(100, 23);
            this.btnImportExcel.Text = "Import Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            this.Controls.Add(this.btnImportExcel);
            // 
            // dgvInputData
            // 
            this.dgvInputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputData.Location = new System.Drawing.Point(12, 80);
            this.dgvInputData.Name = "dgvInputData";
            this.dgvInputData.Size = new System.Drawing.Size(500, 150);
            this.dgvInputData.TabIndex = 0;
            // 
            // dgvResultData
            // 
            this.dgvResultData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultData.Location = new System.Drawing.Point(12, 310);
            this.dgvResultData.Name = "dgvResultData";
            this.dgvResultData.Size = new System.Drawing.Size(500, 150);
            this.dgvResultData.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(200, 250);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Xử lý";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(233, 17);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Thêm";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(314, 17);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 4;
            this.btnDeleteStudent.Text = "Xóa";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(70, 20);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(125, 20);
            this.txtMSSV.TabIndex = 5;
            // 
            // txtNV1
            // 
            this.txtNV1.Location = new System.Drawing.Point(70, 50);
            this.txtNV1.Name = "txtNV1";
            this.txtNV1.Size = new System.Drawing.Size(60, 20);
            this.txtNV1.TabIndex = 6;
            // 
            // txtNV2
            // 
            this.txtNV2.Location = new System.Drawing.Point(180, 50);
            this.txtNV2.Name = "txtNV2";
            this.txtNV2.Size = new System.Drawing.Size(60, 20);
            this.txtNV2.TabIndex = 7;
            // 
            // txtNV3
            // 
            this.txtNV3.Location = new System.Drawing.Point(290, 50);
            this.txtNV3.Name = "txtNV3";
            this.txtNV3.Size = new System.Drawing.Size(60, 20);
            this.txtNV3.TabIndex = 8;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(12, 23);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(40, 13);
            this.lblMSSV.TabIndex = 9;
            this.lblMSSV.Text = "MSSV:";
            // 
            // lblNV1
            // 
            this.lblNV1.AutoSize = true;
            this.lblNV1.Location = new System.Drawing.Point(12, 53);
            this.lblNV1.Name = "lblNV1";
            this.lblNV1.Size = new System.Drawing.Size(31, 13);
            this.lblNV1.TabIndex = 10;
            this.lblNV1.Text = "NV1:";
            // 
            // lblNV2
            // 
            this.lblNV2.AutoSize = true;
            this.lblNV2.Location = new System.Drawing.Point(140, 53);
            this.lblNV2.Name = "lblNV2";
            this.lblNV2.Size = new System.Drawing.Size(31, 13);
            this.lblNV2.TabIndex = 11;
            this.lblNV2.Text = "NV2:";
            // 
            // lblNV3
            // 
            this.lblNV3.AutoSize = true;
            this.lblNV3.Location = new System.Drawing.Point(250, 53);
            this.lblNV3.Name = "lblNV3";
            this.lblNV3.Size = new System.Drawing.Size(31, 13);
            this.lblNV3.TabIndex = 12;
            this.lblNV3.Text = "NV3:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(534, 481);
            this.Controls.Add(this.lblNV3);
            this.Controls.Add(this.lblNV2);
            this.Controls.Add(this.lblNV1);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.txtNV3);
            this.Controls.Add(this.txtNV2);
            this.Controls.Add(this.txtNV1);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.dgvResultData);
            this.Controls.Add(this.dgvInputData);
            this.Name = "Form1";
            this.Text = "Ứng dụng K-Means vào xếp phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
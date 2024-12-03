using System.Windows.Forms;

namespace GUI
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridView dgvKmeans;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtMarried;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGraduated;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.TextBox txtSpendingScore;
        private System.Windows.Forms.TextBox txtFamilySize;
        private System.Windows.Forms.TextBox txtVar1;
        private System.Windows.Forms.ComboBox cboSegmentation;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMarried;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGraduated;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblSpendingScore;
        private System.Windows.Forms.Label lblFamilySize;
        private System.Windows.Forms.Label lblVar1;
        private System.Windows.Forms.Label lblSegmentation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRunKmeans;
        private System.Windows.Forms.ComboBox cboSpendingFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboClusterFilter;
        private System.Windows.Forms.Button btnClusterFilter;

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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.dgvKmeans = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtMarried = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGraduated = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.txtSpendingScore = new System.Windows.Forms.TextBox();
            this.txtFamilySize = new System.Windows.Forms.TextBox();
            this.txtVar1 = new System.Windows.Forms.TextBox();
            this.cboSegmentation = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMarried = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGraduated = new System.Windows.Forms.Label();
            this.lblProfession = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblSpendingScore = new System.Windows.Forms.Label();
            this.lblFamilySize = new System.Windows.Forms.Label();
            this.lblVar1 = new System.Windows.Forms.Label();
            this.lblSegmentation = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRunKmeans = new System.Windows.Forms.Button();
            this.cboSpendingFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboClusterFilter = new System.Windows.Forms.ComboBox();
            this.btnClusterFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKmeans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 162);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(826, 282);
            this.dgvData.TabIndex = 0;
            // 
            // dgvKmeans
            // 
            this.dgvKmeans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKmeans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKmeans.ColumnHeadersHeight = 29;
            this.dgvKmeans.Location = new System.Drawing.Point(844, 60);
            this.dgvKmeans.Name = "dgvKmeans";
            this.dgvKmeans.RowHeadersWidth = 51;
            this.dgvKmeans.Size = new System.Drawing.Size(421, 384);
            this.dgvKmeans.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(140, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(219, 22);
            this.txtID.TabIndex = 2;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(140, 60);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(58, 22);
            this.txtGender.TabIndex = 3;
            // 
            // txtMarried
            // 
            this.txtMarried.Location = new System.Drawing.Point(278, 100);
            this.txtMarried.Name = "txtMarried";
            this.txtMarried.Size = new System.Drawing.Size(81, 22);
            this.txtMarried.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(140, 100);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(58, 22);
            this.txtAge.TabIndex = 5;
            // 
            // txtGraduated
            // 
            this.txtGraduated.Location = new System.Drawing.Point(278, 54);
            this.txtGraduated.Name = "txtGraduated";
            this.txtGraduated.Size = new System.Drawing.Size(81, 22);
            this.txtGraduated.TabIndex = 6;
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(140, 132);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(200, 22);
            this.txtProfession.TabIndex = 7;
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(520, 21);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(34, 22);
            this.txtExperience.TabIndex = 8;
            // 
            // txtSpendingScore
            // 
            this.txtSpendingScore.Location = new System.Drawing.Point(520, 64);
            this.txtSpendingScore.Name = "txtSpendingScore";
            this.txtSpendingScore.Size = new System.Drawing.Size(75, 22);
            this.txtSpendingScore.TabIndex = 9;
            // 
            // txtFamilySize
            // 
            this.txtFamilySize.Location = new System.Drawing.Point(680, 20);
            this.txtFamilySize.Name = "txtFamilySize";
            this.txtFamilySize.Size = new System.Drawing.Size(34, 22);
            this.txtFamilySize.TabIndex = 10;
            // 
            // txtVar1
            // 
            this.txtVar1.Location = new System.Drawing.Point(661, 64);
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new System.Drawing.Size(59, 22);
            this.txtVar1.TabIndex = 11;
            // 
            // cboSegmentation
            // 
            this.cboSegmentation.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboSegmentation.Location = new System.Drawing.Point(520, 97);
            this.cboSegmentation.Name = "cboSegmentation";
            this.cboSegmentation.Size = new System.Drawing.Size(200, 24);
            this.cboSegmentation.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(20, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(120, 25);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "Mã số (ID):";
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(20, 60);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(120, 25);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "Giới tính:";
            // 
            // lblMarried
            // 
            this.lblMarried.Location = new System.Drawing.Point(213, 100);
            this.lblMarried.Name = "lblMarried";
            this.lblMarried.Size = new System.Drawing.Size(76, 25);
            this.lblMarried.TabIndex = 14;
            this.lblMarried.Text = "Kết hôn:";
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(20, 100);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(67, 25);
            this.lblAge.TabIndex = 15;
            this.lblAge.Text = "Tuổi:";
            // 
            // lblGraduated
            // 
            this.lblGraduated.Location = new System.Drawing.Point(204, 57);
            this.lblGraduated.Name = "lblGraduated";
            this.lblGraduated.Size = new System.Drawing.Size(100, 25);
            this.lblGraduated.TabIndex = 16;
            this.lblGraduated.Text = "Tốt nghiệp:";
            // 
            // lblProfession
            // 
            this.lblProfession.Location = new System.Drawing.Point(20, 132);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(120, 25);
            this.lblProfession.TabIndex = 17;
            this.lblProfession.Text = "Nghề nghiệp:";
            // 
            // lblExperience
            // 
            this.lblExperience.Location = new System.Drawing.Point(400, 20);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(120, 25);
            this.lblExperience.TabIndex = 18;
            this.lblExperience.Text = "Kinh nghiệm:";
            // 
            // lblSpendingScore
            // 
            this.lblSpendingScore.Location = new System.Drawing.Point(400, 60);
            this.lblSpendingScore.Name = "lblSpendingScore";
            this.lblSpendingScore.Size = new System.Drawing.Size(120, 25);
            this.lblSpendingScore.TabIndex = 19;
            this.lblSpendingScore.Text = "Điểm tiêu dùng:";
            // 
            // lblFamilySize
            // 
            this.lblFamilySize.Location = new System.Drawing.Point(560, 20);
            this.lblFamilySize.Name = "lblFamilySize";
            this.lblFamilySize.Size = new System.Drawing.Size(120, 25);
            this.lblFamilySize.TabIndex = 20;
            this.lblFamilySize.Text = "Số người trong gia đình:";
            // 
            // lblVar1
            // 
            this.lblVar1.Location = new System.Drawing.Point(608, 63);
            this.lblVar1.Name = "lblVar1";
            this.lblVar1.Size = new System.Drawing.Size(47, 25);
            this.lblVar1.TabIndex = 21;
            this.lblVar1.Text = "Var1:";
            // 
            // lblSegmentation
            // 
            this.lblSegmentation.Location = new System.Drawing.Point(400, 96);
            this.lblSegmentation.Name = "lblSegmentation";
            this.lblSegmentation.Size = new System.Drawing.Size(120, 25);
            this.lblSegmentation.TabIndex = 22;
            this.lblSegmentation.Text = "Phân loại:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(738, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(738, 46);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(738, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRunKmeans
            // 
            this.btnRunKmeans.Location = new System.Drawing.Point(738, 126);
            this.btnRunKmeans.Name = "btnRunKmeans";
            this.btnRunKmeans.Size = new System.Drawing.Size(100, 30);
            this.btnRunKmeans.TabIndex = 11;
            this.btnRunKmeans.Text = "Run K-means";
            this.btnRunKmeans.UseVisualStyleBackColor = true;
            // 
            // cboSpendingFilter
            // 
            this.cboSpendingFilter.FormattingEnabled = true;
            this.cboSpendingFilter.Items.AddRange(new object[] {
            "High",
            "Average",
            "Low"});
            this.cboSpendingFilter.Location = new System.Drawing.Point(403, 132);
            this.cboSpendingFilter.Name = "cboSpendingFilter";
            this.cboSpendingFilter.Size = new System.Drawing.Size(225, 24);
            this.cboSpendingFilter.TabIndex = 12;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(645, 131);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 25);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // cboClusterFilter
            // 
            this.cboClusterFilter.FormattingEnabled = true;
            this.cboClusterFilter.Items.AddRange(new object[] {
            "Cluster 0",
            "Cluster 1",
            "Cluster 2",
            "Cluster 3"});
            this.cboClusterFilter.Location = new System.Drawing.Point(844, 11);
            this.cboClusterFilter.Name = "cboClusterFilter";
            this.cboClusterFilter.Size = new System.Drawing.Size(241, 24);
            this.cboClusterFilter.TabIndex = 14;
            // 
            // btnClusterFilter
            // 
            this.btnClusterFilter.Location = new System.Drawing.Point(1091, 11);
            this.btnClusterFilter.Name = "btnClusterFilter";
            this.btnClusterFilter.Size = new System.Drawing.Size(174, 25);
            this.btnClusterFilter.TabIndex = 15;
            this.btnClusterFilter.Text = "Lọc Cluster";
            this.btnClusterFilter.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(1277, 459);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.dgvKmeans);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtMarried);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtGraduated);
            this.Controls.Add(this.txtProfession);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.txtSpendingScore);
            this.Controls.Add(this.txtFamilySize);
            this.Controls.Add(this.txtVar1);
            this.Controls.Add(this.cboSegmentation);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblMarried);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGraduated);
            this.Controls.Add(this.lblProfession);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblSpendingScore);
            this.Controls.Add(this.lblFamilySize);
            this.Controls.Add(this.lblVar1);
            this.Controls.Add(this.lblSegmentation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRunKmeans);
            this.Controls.Add(this.cboSpendingFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cboClusterFilter);
            this.Controls.Add(this.btnClusterFilter);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKmeans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

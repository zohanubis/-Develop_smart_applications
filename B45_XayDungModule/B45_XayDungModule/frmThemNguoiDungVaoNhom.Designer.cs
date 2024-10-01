using System.Windows.Forms;
namespace B45_XayDungModule
{
    partial class frmThemNguoiDungVaoNhom
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
            this.components = new System.ComponentModel.Container();
            this.module_DN = new B45_XayDungModule.Module_DN();
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungTableAdapter = new B45_XayDungModule.Module_DNTableAdapters.QL_NguoiDungTableAdapter();
            this.tableAdapterManager = new B45_XayDungModule.Module_DNTableAdapters.TableAdapterManager();
            this.qL_NhomNguoiDungTableAdapter = new B45_XayDungModule.Module_DNTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungNhomNguoiDung_DKTableAdapter = new B45_XayDungModule.Module_DNTableAdapters.QL_NguoiDungNhomNguoiDung_DKTableAdapter();
            this.qL_NguoiDungNhomNguoiDung_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.nhomNDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nhomNDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.qL_NguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.qL_NhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            // Cấu hình các cột cho DataGridView qL_NguoiDungDataGridView
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn(); // TenDangNhap
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn(); // MatKhau
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn(); // HoatDong

            // Cấu hình các cột cho DataGridView qL_NguoiDungNhomNguoiDung_DKDataGridView
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn(); // TenDangNhap
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn(); // MaNhomNguoiDung
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn(); // GhiChu

            ((System.ComponentModel.ISupportInitialize)(this.module_DN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKDataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // module_DN
            // 
            this.module_DN.DataSetName = "Module_DN";
            this.module_DN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            this.qL_NguoiDungBindingSource.DataSource = this.module_DN;
            // 
            // qL_NguoiDungTableAdapter
            // 
            this.qL_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDung_DKTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = this.qL_NguoiDungTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = B45_XayDungModule.Module_DNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.module_DN;
            // 
            // qL_NguoiDungNhomNguoiDung_DKTableAdapter
            // 
            this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NguoiDungNhomNguoiDung_DKBindingSource
            // 
            this.qL_NguoiDungNhomNguoiDung_DKBindingSource.DataMember = "QL_NguoiDungNhomNguoiDung_DK";
            this.qL_NguoiDungNhomNguoiDung_DKBindingSource.DataSource = this.module_DN;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhomNDToolStripLabel,
            this.nhomNDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1000, 27);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // nhomNDToolStripLabel
            // 
            this.nhomNDToolStripLabel.Name = "nhomNDToolStripLabel";
            this.nhomNDToolStripLabel.Size = new System.Drawing.Size(75, 24);
            this.nhomNDToolStripLabel.Text = "NhomND:";
            // 
            // nhomNDToolStripTextBox
            // 
            this.nhomNDToolStripTextBox.Name = "nhomNDToolStripTextBox";
            this.nhomNDToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // qL_NguoiDungDataGridView
            // 
            this.qL_NguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1, // TenDangNhap
            this.dataGridViewTextBoxColumn2, // MatKhau
            this.dataGridViewCheckBoxColumn1 // HoatDong
            });
            this.qL_NguoiDungDataGridView.DataSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungDataGridView.Location = new System.Drawing.Point(12, 60);
            this.qL_NguoiDungDataGridView.Name = "qL_NguoiDungDataGridView";
            this.qL_NguoiDungDataGridView.RowHeadersWidth = 51;
            this.qL_NguoiDungDataGridView.RowTemplate.Height = 24;
            this.qL_NguoiDungDataGridView.Size = new System.Drawing.Size(450, 350);
            this.qL_NguoiDungDataGridView.TabIndex = 1;
            // 
            // Cấu hình cột cho qL_NguoiDungDataGridView
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Đăng Nhập";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mật Khẩu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HoatDong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Hoạt Động";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // qL_NhomNguoiDungComboBox
            // 
            this.qL_NhomNguoiDungComboBox.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungComboBox.DisplayMember = "TenNhom";
            this.qL_NhomNguoiDungComboBox.FormattingEnabled = true;
            this.qL_NhomNguoiDungComboBox.Location = new System.Drawing.Point(500, 20);
            this.qL_NhomNguoiDungComboBox.Name = "qL_NhomNguoiDungComboBox";
            this.qL_NhomNguoiDungComboBox.Size = new System.Drawing.Size(300, 24);
            this.qL_NhomNguoiDungComboBox.TabIndex = 1;
            this.qL_NhomNguoiDungComboBox.ValueMember = "MaNhom";
            // 
            // qL_NguoiDungNhomNguoiDung_DKDataGridView
            // 
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3, // TenDangNhap
            this.dataGridViewTextBoxColumn4, // MaNhomNguoiDung
            this.dataGridViewTextBoxColumn5 // GhiChu
            });
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.DataSource = this.qL_NguoiDungNhomNguoiDung_DKBindingSource;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Location = new System.Drawing.Point(500, 60);
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Name = "qL_NguoiDungNhomNguoiDung_DKDataGridView";
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.RowHeadersWidth = 51;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.RowTemplate.Height = 24;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Size = new System.Drawing.Size(450, 350);
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.TabIndex = 3;
            // 
            // Cấu hình cột cho qL_NguoiDungNhomNguoiDung_DKDataGridView
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Đăng Nhập";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã Nhóm";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ghi Chú";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(300, 420);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 30);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Thêm >>";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(600, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "<< Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 

            // Thêm các điều khiển vào form
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.qL_NguoiDungNhomNguoiDung_DKDataGridView);
            this.Controls.Add(this.qL_NhomNguoiDungComboBox);
            this.Controls.Add(this.qL_NguoiDungDataGridView);
            this.Controls.Add(this.fillToolStrip);

            // Các thuộc tính khác của form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Name = "frmThemNguoiDungVaoNhom";
            this.Text = "Thêm Người Dùng Vào Nhóm";
            this.Load += new System.EventHandler(this.frmThemNguoiDungVaoNhom_Load);

            ((System.ComponentModel.ISupportInitialize)(this.module_DN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Module_DN module_DN;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private Module_DNTableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter;
        private Module_DNTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView qL_NguoiDungDataGridView;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private Module_DNTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private System.Windows.Forms.ComboBox qL_NhomNguoiDungComboBox;
        private System.Windows.Forms.BindingSource qL_NguoiDungNhomNguoiDung_DKBindingSource;
        private Module_DNTableAdapters.QL_NguoiDungNhomNguoiDung_DKTableAdapter qL_NguoiDungNhomNguoiDung_DKTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel nhomNDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nhomNDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView qL_NguoiDungNhomNguoiDung_DKDataGridView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1; // TenDangNhap
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2; // MatKhau
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1; // HoatDong
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3; // TenDangNhap
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4; // MaNhomNguoiDung
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5; // GhiChu
    }
}

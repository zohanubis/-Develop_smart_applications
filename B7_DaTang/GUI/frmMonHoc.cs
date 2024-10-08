using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmMonHoc : Form
    {
        MonHocBLL bllMonHoc = new MonHocBLL();

        public frmMonHoc()
        {
            InitializeComponent();
            this.btnThem.Click += btnThem_Click;
            this.btnSua.Click += btnSua_Click;
            this.btnXoa.Click += btnXoa_Click;
            this.txtMaMH.TextChanged += txtMaMH_TextChanged;
            this.txtTenMH.TextChanged += txtTenMH_TextChanged;
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
        }

        private void LoadMonHoc()
        {
            dataGridViewMH.DataSource = bllMonHoc.GetMonHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblError.Text = ""; 
            MonHoc monHoc = new MonHoc
            {
                MaMonHoc = txtMaMH.Text,
                TenMonHoc = txtTenMH.Text
            };

            string error;
            if (bllMonHoc.ThemMonHoc(monHoc, out error))
            {
                LoadMonHoc(); 
            }
            else
            {
                lblError.Text = error; 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMonHoc = txtMaMH.Text;

            if (bllMonHoc.XoaMonHoc(maMonHoc))
            {
                MessageBox.Show("Xóa môn học thành công!");
                LoadMonHoc();  
            }
            else
            {
                MessageBox.Show("Xóa môn học thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MonHoc monHoc = new MonHoc
            {
                MaMonHoc = txtMaMH.Text,
                TenMonHoc = txtTenMH.Text
            };

            if (bllMonHoc.SuaMonHoc(monHoc))
            {
                MessageBox.Show("Sửa môn học thành công!");
                LoadMonHoc();  
            }
            else
            {
                MessageBox.Show("Sửa môn học thất bại!");
            }
        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void txtTenMH_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void dataGridViewMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMH.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells["MaMonHoc"].Value.ToString();
                txtTenMH.Text = row.Cells["TenMonHoc"].Value.ToString();
            }
        }
    }
}

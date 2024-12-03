using Accord.MachineLearning;
using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Students
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            InitializeInputDataGrid();
            InitializeResultDataGrid();
        }

        private void InitializeInputDataGrid()
        {
            dgvInputData.ColumnCount = 4;
            dgvInputData.Columns[0].Name = "MSSV";
            dgvInputData.Columns[1].Name = "NV1";
            dgvInputData.Columns[2].Name = "NV2";
            dgvInputData.Columns[3].Name = "NV3";
        }

        private void InitializeResultDataGrid()
        {
            dgvResultData.ColumnCount = 5;
            dgvResultData.Columns[0].Name = "MSSV";
            dgvResultData.Columns[1].Name = "Phòng";
            dgvResultData.Columns[2].Name = "NV1";
            dgvResultData.Columns[3].Name = "NV2";
            dgvResultData.Columns[4].Name = "NV3";
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Thêm dữ liệu từ các TextBox vào DataGridView
            dgvInputData.Rows.Add(txtMSSV.Text, txtNV1.Text, txtNV2.Text, txtNV3.Text);
            // Xóa nội dung trong các TextBox sau khi thêm
            txtMSSV.Clear();
            txtNV1.Clear();
            txtNV2.Clear();
            txtNV3.Clear();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            // Xóa dòng được chọn trong DataGridView
            if (dgvInputData.SelectedRows.Count > 0)
            {
                dgvInputData.Rows.RemoveAt(dgvInputData.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Chuyển dữ liệu từ dgvInputData sang mảng double[][]
            double[][] data = new double[dgvInputData.RowCount - 1][];
            string[] mssv = new string[dgvInputData.RowCount - 1];
            for (int i = 0; i < dgvInputData.RowCount - 1; i++)
            {
                mssv[i] = dgvInputData.Rows[i].Cells[0].Value != null
             ? dgvInputData.Rows[i].Cells[0].Value.ToString()
             : string.Empty;

                data[i] = new double[]
                {
                    Convert.ToDouble(dgvInputData.Rows[i].Cells[1].Value),
                    Convert.ToDouble(dgvInputData.Rows[i].Cells[2].Value),
                    Convert.ToDouble(dgvInputData.Rows[i].Cells[3].Value)
                };

            }

            // Khởi tạo thuật toán KMeans với số cụm k = 2
            var kmeans = new KMeans(k: 2);
            var clusters = kmeans.Learn(data);
            int[] labels = clusters.Decide(data);

            // Hiển thị kết quả trên dgvResultData
            dgvResultData.Rows.Clear();
            for (int i = 0; i < labels.Length; i++)
            {
                dgvResultData.Rows.Add(mssv[i], "Phòng " + (labels[i] + 1), data[i][0], data[i][1], data[i][2]);
            }
        }
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Open(openFileDialog.FileName);
                Excel.Worksheet worksheet = workbook.Sheets[1];
                Excel.Range range = worksheet.UsedRange;

                dgvInputData.Rows.Clear();

                for (int row = 2; row <= range.Rows.Count; row++) // Bắt đầu từ hàng 2 để bỏ qua tiêu đề
                {
                    int rowIndex = dgvInputData.Rows.Add();
                    dgvInputData.Rows[rowIndex].Cells[0].Value = range.Cells[row, 1].Value2.ToString(); // MSSV
                    dgvInputData.Rows[rowIndex].Cells[1].Value = range.Cells[row, 2].Value2.ToString(); // NV1
                    dgvInputData.Rows[rowIndex].Cells[2].Value = range.Cells[row, 3].Value2.ToString(); // NV2
                    dgvInputData.Rows[rowIndex].Cells[3].Value = range.Cells[row, 4].Value2.ToString(); // NV3
                }

                workbook.Close(false);
                Marshal.ReleaseComObject(workbook);
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            }
        }
    }
}
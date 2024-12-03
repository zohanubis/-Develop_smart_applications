using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTO;
using BLL;
using MLAI;


namespace GUI
{
    public partial class FrmMain : Form
    {
        private TrainDataBLL trainDataBLL = new TrainDataBLL();

        public FrmMain()
        {
            InitializeComponent();

            LoadData();
            this.dgvData.CellClick += DgvData_CellClick;

            this.btnAdd.Click += BtnAdd_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnFilter.Click += BtnFilter_Click;
            this.btnClusterFilter.Click += BtnClusterFilter_Click;
            this.btnRunKmeans.Click += BtnRunKmeans_Click; 
        }

        private void BtnClusterFilter_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ ComboBox
                var selectedCluster = cboClusterFilter.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedCluster))
                {
                    MessageBox.Show("Vui lòng chọn một cụm để lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy Cluster ID từ ComboBox (ví dụ: "Cluster 0" -> 0)
                int clusterID = int.Parse(selectedCluster.Replace("Cluster ", ""));

                // Tạo danh sách để chứa dữ liệu lọc
                var filteredData = new List<dynamic>();

                // Duyệt qua tất cả các dòng trong dgvKmeans
                foreach (DataGridViewRow row in dgvKmeans.Rows)
                {
                    // Kiểm tra xem dòng có hợp lệ không (tránh dòng trống)
                    if (row.Cells["Cluster"].Value != null && row.Cells["DataPoint"].Value != null)
                    {
                        // Nếu Cluster khớp với clusterID được chọn, thêm vào danh sách lọc
                        if (Convert.ToInt32(row.Cells["Cluster"].Value) == clusterID)
                        {
                            filteredData.Add(new
                            {
                                Cluster = row.Cells["Cluster"].Value,
                                DataPoint = row.Cells["DataPoint"].Value
                            });
                        }
                    }
                }

                // Gán dữ liệu lọc vào dgvKmeans
                dgvKmeans.DataSource = filteredData;

                // Hiển thị thông báo nếu không có dữ liệu
                if (filteredData.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu phù hợp với Cluster đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc Cluster: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ ComboBox
                var selectedFilter = cboSpendingFilter.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedFilter))
                {
                    MessageBox.Show("Vui lòng chọn một tiêu chí lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển tiêu chí lọc sang số
                int filterValue = SpendingScoreToNumeric(selectedFilter);

                // Lấy dữ liệu từ BLL
                var data = trainDataBLL.GetAllData();

                // Lọc dữ liệu theo điểm tiêu dùng
                var filteredData = data.Where(d => SpendingScoreToNumeric(d.Spending_Score) == filterValue).ToList();

                // Gán dữ liệu vào DataGridView
                dgvData.DataSource = filteredData;

                // Hiển thị thông báo nếu không có dữ liệu
                if (filteredData.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu phù hợp với tiêu chí lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int SpendingScoreToNumeric(string score)
        {
            switch (score)
            {
                case "Low":
                    return 1;
                case "Average":
                    return 2;
                case "High":
                    return 3;
                default:
                    return 0;
            }
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return; // Xác thực dữ liệu

                // Lấy dữ liệu từ các TextBox
                Train_Data_ newData = new Train_Data_
                {
                    ID = double.Parse(txtID.Text),
                    Gender = txtGender.Text,
                    Ever_Married = txtMarried.Text,
                    Age = double.Parse(txtAge.Text),
                    Graduated = txtGraduated.Text,
                    Profession = txtProfession.Text,
                    Work_Experience = double.Parse(txtExperience.Text),
                    Spending_Score = txtSpendingScore.Text,
                    Family_Size = double.Parse(txtFamilySize.Text),
                    Var_1 = txtVar1.Text,
                    Segmentation = cboSegmentation.SelectedItem.ToString()
                };

                // Thêm dữ liệu thông qua BLL
                if (trainDataBLL.AddData(newData))
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Reload dữ liệu
                    ResetTextBoxes(); // Reset TextBox
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return; // Xác thực dữ liệu

                // Kiểm tra nếu không có dòng nào được chọn
                if (dgvData.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy dữ liệu từ các TextBox
                Train_Data_ updatedData = new Train_Data_
                {
                    ID = double.Parse(txtID.Text),
                    Gender = txtGender.Text,
                    Ever_Married = txtMarried.Text,
                    Age = double.Parse(txtAge.Text),
                    Graduated = txtGraduated.Text,
                    Profession = txtProfession.Text,
                    Work_Experience = double.Parse(txtExperience.Text),
                    Spending_Score = txtSpendingScore.Text,
                    Family_Size = double.Parse(txtFamilySize.Text),
                    Var_1 = txtVar1.Text,
                    Segmentation = cboSegmentation.SelectedItem.ToString()
                };

                // Cập nhật dữ liệu thông qua BLL
                if (trainDataBLL.UpdateData(updatedData))
                {
                    MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Reload dữ liệu
                    ResetTextBoxes(); // Reset TextBox
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có dòng nào được chọn
                if (dgvData.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID của dòng được chọn
                double id = double.Parse(dgvData.CurrentRow.Cells["ID"].Value.ToString());

                // Xóa dữ liệu thông qua BLL
                if (trainDataBLL.DeleteData(id))
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Reload dữ liệu
                    ResetTextBoxes(); // Reset TextBox
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRunKmeans_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ BLL
                var data = trainDataBLL.GetAllData();

                if (data == null || data.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để phân cụm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sử dụng KmeansClass từ dự án MLAI
                KmeansClass kmeans = new KmeansClass(4);
                var result = kmeans.RunKmeans(data);

                // Hiển thị kết quả phân cụm trên dgvKmeans
                dgvKmeans.DataSource = result.SelectMany(kvp => kvp.Value.Select(v => new
                {
                    Cluster = kvp.Key,
                    DataPoint = ConvertDataPointToText(v) // Chuyển đổi DataPoint về dạng text
                })).ToList();

                MessageBox.Show("Phân cụm K-means hoàn thành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phân cụm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ConvertDataPointToText(double[] dataPoint)
        {
            // Chuyển đổi từng cột trong DataPoint
            string gender = (dataPoint[0] == 1) ? "Male" : "Female";
            string married = (dataPoint[1] == 1) ? "Yes" : "No";
            string age = dataPoint[2].ToString();
            string graduated = (dataPoint[3] == 1) ? "Yes" : "No";
            string profession = ProfessionFromNumeric((int)dataPoint[4]);
            string workExperience = dataPoint[5].ToString();
            string spendingScore = SpendingScoreFromNumeric((int)dataPoint[6]);
            string familySize = dataPoint[7].ToString();

            // Kết hợp thành chuỗi
            return $"{gender}, {married}, {age}, {graduated}, {profession}, {workExperience}, {spendingScore}, {familySize}";
        }

        private string ProfessionFromNumeric(int value)
        {
            var professions = new Dictionary<int, string>
            {
                { 1, "Healthcare" },
                { 2, "Engineer" },
                { 3, "Artist" },
                { 4, "Doctor" },
                { 5, "Lawyer" },
                { 6, "Entertainment" },
                { 7, "Homemaker" },
                { 8, "Other" }
            };

            return professions.ContainsKey(value) ? professions[value] : "Unknown";
        }

        private string SpendingScoreFromNumeric(int value)
        {
            switch (value)
            {
                case 1: return "Low";
                case 2: return "Average";
                case 3: return "High";
                default: return "Unknown";
            }
        }


        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtGender.Text = dgvData.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                txtMarried.Text = dgvData.Rows[e.RowIndex].Cells["Ever_Married"].Value.ToString();
                txtAge.Text = dgvData.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                txtGraduated.Text = dgvData.Rows[e.RowIndex].Cells["Graduated"].Value.ToString();
                txtProfession.Text = dgvData.Rows[e.RowIndex].Cells["Profession"].Value.ToString();
                txtExperience.Text = dgvData.Rows[e.RowIndex].Cells["Work_Experience"].Value.ToString();
                txtSpendingScore.Text = dgvData.Rows[e.RowIndex].Cells["Spending_Score"].Value.ToString();
                txtFamilySize.Text = dgvData.Rows[e.RowIndex].Cells["Family_Size"].Value.ToString();
                txtVar1.Text = dgvData.Rows[e.RowIndex].Cells["Var_1"].Value.ToString();
                cboSegmentation.SelectedItem = dgvData.Rows[e.RowIndex].Cells["Segmentation"].Value.ToString();
            }
        }

        private void LoadData()
        {
            try
            {
                var data = trainDataBLL.GetAllData(); // Lấy dữ liệu từ BLL
                dgvData.DataSource = data; // Gán dữ liệu vào DataGridView
                FormatDataGridView(); // Cải thiện giao diện DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetTextBoxes()
        {
            txtID.Clear();
            txtGender.Clear();
            txtMarried.Clear();
            txtAge.Clear();
            txtGraduated.Clear();
            txtProfession.Clear();
            txtExperience.Clear();
            txtSpendingScore.Clear();
            txtFamilySize.Clear();
            txtVar1.Clear();
            cboSegmentation.SelectedIndex = -1;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtGender.Text) ||
                cboSegmentation.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtID.Text, out _) || !double.TryParse(txtAge.Text, out _))
            {
                MessageBox.Show("ID và Tuổi phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void FormatDataGridView()
        {
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.Columns["ID"].HeaderText = "Mã số";
            dgvData.Columns["Gender"].HeaderText = "Giới tính";
            dgvData.Columns["Ever_Married"].HeaderText = "Kết hôn";
            dgvData.Columns["Age"].HeaderText = "Tuổi";
            dgvData.Columns["Graduated"].HeaderText = "Tốt nghiệp";
            dgvData.Columns["Profession"].HeaderText = "Nghề nghiệp";
            dgvData.Columns["Work_Experience"].HeaderText = "Kinh nghiệm";
            dgvData.Columns["Spending_Score"].HeaderText = "Điểm tiêu dùng";
            dgvData.Columns["Family_Size"].HeaderText = "Số người trong gia đình";
            dgvData.Columns["Var_1"].HeaderText = "Var_1";
            dgvData.Columns["Segmentation"].HeaderText = "Phân loại";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

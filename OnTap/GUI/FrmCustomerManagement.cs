using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.MachineLearning;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees;
using BLL;
using DTO;
using MLLibrary;

namespace GUI
{
    public partial class FrmCustomerManagement : Form
    {
        CustomerBLL customerBLL = new CustomerBLL();
        public FrmCustomerManagement()
        {
            InitializeComponent();
            this.btnAdd.Click += btnAdd_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.btnEdit.Click += btnEdit_Click;
            this.btnRefresh.Click += btnRefresh_Click;

            this.btnRunKMeans.Click += btnRunKMeans_Click;
            this.btnRunID3.Click += btnRunID3_Click;
            LoadDataDGV();
        }
        private void btnRunID3_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu đã rời rạc
                var (features, labels) = LoadDiscreteData();

                // Định nghĩa các thuộc tính rời rạc
                DecisionVariable[] attributes =
                {
            new DecisionVariable("credit_score", 4),  // Low, Medium, High
            new DecisionVariable("age", 4),          // Young, Middle-aged, Senior
            new DecisionVariable("balance", 4),      // Low, Medium, High
            new DecisionVariable("products_number", 10), // Max 10 products
            new DecisionVariable("estimated_salary", 4), // Low, Medium, High
            new DecisionVariable("tenure", 10),      // Max 10 years
            new DecisionVariable("credit_card", 2),  // Yes, No
            new DecisionVariable("active_member", 2) // Yes, No
        };

                // Kiểm tra dữ liệu rời rạc
                ValidateDiscreteData(features, attributes);

                // Tạo cây quyết định
                DecisionTree tree = new DecisionTree(attributes, 2); // 2 nhãn: Churn, Not Churn
                var teacher = new ID3Learning(tree);

                // Huấn luyện
                teacher.Learn(features, labels);

                // Dự đoán và tính toán độ chính xác
                int[] predictions = tree.Decide(features);
                double accuracy = labels.Zip(predictions, (actual, predicted) => actual == predicted ? 1 : 0).Average() * 100;

                // Đổ kết quả vào DataGridView
                var results = labels.Select((label, index) => new
                {
                    CustomerIndex = index + 1,
                    Actual = label == 1 ? "Churn" : "Not Churn",
                    Predicted = predictions[index] == 1 ? "Churn" : "Not Churn"
                }).ToList();

                dgvResults.DataSource = results;

                MessageBox.Show($"ID3 Accuracy: {accuracy:0.00}%", "Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }



        void btnRunKMeans_Click(object sender, EventArgs e)
        {
            var (features, labels) = LoadData();

            // Sử dụng KMeans từ MLLibrary
            KMeansClassifier kmeans = new KMeansClassifier();
            double accuracy = kmeans.RunKMeans(features, labels);

            // Lấy kết quả phân cụm
            KMeans kmeansInstance = new KMeans(2); // 2 cụm
            var clusters = kmeansInstance.Learn(features);
            int[] predictions = clusters.Decide(features);

            // Đổ kết quả vào DataGridView
            var results = labels.Select((label, index) => new
            {
                CustomerIndex = index + 1,
                Actual = label,
                Predicted = predictions[index]
            }).ToList();

            dgvResults.DataSource = results;

            MessageBox.Show($"K-means Accuracy: {accuracy:0.00}%", "Result");
        }

        private int Discretize(double value, double[] bins)
        {
            for (int i = 0; i < bins.Length - 1; i++)
            {
                if (value >= bins[i] && value < bins[i + 1])
                {
                    return i; // Trả về nhóm tương ứng
                }
            }
            return bins.Length - 2; // Gán vào nhóm cuối cùng nếu vượt quá
        }



        private (int[][] discreteFeatures, int[] labels) LoadDiscreteData()
        {
            var data = customerBLL.GetAllCustomers().Select(c => new
            {
                c.credit_score,
                c.age,
                c.balance,
                c.products_number,
                c.estimated_salary,
                c.tenure,
                CreditCard = c.credit_card.HasValue && c.credit_card.Value ? 1 : 0,
                ActiveMember = c.active_member.HasValue && c.active_member.Value ? 1 : 0,
                c.churn
            }).ToList();

            // Định nghĩa ngưỡng (bins)
            double[] creditScoreBins = { 300, 500, 700, 850 }; // Low, Medium, High
            double[] ageBins = { 0, 25, 45, 65, 100 };         // Young, Middle-aged, Senior
            double[] balanceBins = { 0, 10000, 50000, 100000, double.MaxValue }; // Low, Medium, High
            double[] salaryBins = { 0, 20000, 60000, 100000, double.MaxValue };  // Low, Medium, High

            // Chuyển đổi dữ liệu liên tục
            int[][] discreteFeatures = data.Select(d => new int[]
            {
                Discretize(d.credit_score ?? 0, creditScoreBins),
                Discretize(d.age ?? 0, ageBins),
                Discretize(d.balance ?? 0.0, balanceBins),
                d.products_number ?? 0, // Đã rời rạc
                Discretize(d.estimated_salary ?? 0.0, salaryBins),
                d.tenure ?? 0, // Đã rời rạc
                d.CreditCard, // Đã rời rạc
                d.ActiveMember // Đã rời rạc
            }).ToArray();

            int[] labels = data.Select(d => d.churn ?? false ? 1 : 0).ToArray();

            return (discreteFeatures, labels);
        }


        private (double[][] inputFeatures, int[] outputLabels) LoadData()
        {
            var data = customerBLL.GetAllCustomers().Select(c => new
            {
                c.credit_score,
                c.age,
                c.balance,
                c.products_number,
                c.estimated_salary,
                c.tenure,
                CreditCard = c.credit_card.HasValue && c.credit_card.Value ? 1 : 0,
                ActiveMember = c.active_member.HasValue && c.active_member.Value ? 1 : 0,
                c.churn
            }).ToList();

            // Chuyển đổi dữ liệu đầu vào
            double[][] inputFeatures = data.Select(d => new double[]
            {
                Convert.ToDouble(d.credit_score),      // Chuyển sang double
                Convert.ToDouble(d.age),              // Chuyển sang double
                Convert.ToDouble(d.balance),          // Chuyển sang double
                Convert.ToDouble(d.products_number),  // Chuyển sang double
                Convert.ToDouble(d.estimated_salary), // Chuyển sang double
                Convert.ToDouble(d.tenure),           // Chuyển sang double
                Convert.ToDouble(d.CreditCard),       // Chuyển sang double
                Convert.ToDouble(d.ActiveMember)      // Chuyển sang double
            }).ToArray();

            // Chuyển đổi dữ liệu đầu ra
            int[] outputLabels = data.Select(d => Convert.ToInt32(d.churn)).ToArray();

            return (inputFeatures, outputLabels);
        }

        private void ValidateDiscreteData(int[][] features, DecisionVariable[] attributes)
        {
            foreach (var feature in features)
            {
                for (int i = 0; i < feature.Length; i++)
                {
                    if (feature[i] < 0 || feature[i] >= attributes[i].Range.Length)
                    {
                        throw new ArgumentException($"Invalid value {feature[i]} at column {i}. Expected value between 0 and {attributes[i].Range.Length - 1}");
                    }
                }
            }
        }

        void btnRefresh_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    Customer updatedCustomer = new Customer
                    {
                        customer_id = txtCustomerId.Text,
                        credit_score = int.Parse(txtCreditScore.Text),
                        country = txtCountry.Text,
                        gender = txtGender.Text,
                        age = int.Parse(txtAge.Text),
                        tenure = int.Parse(txtTenure.Text),
                        balance = float.Parse(txtBalance.Text),
                        products_number = int.Parse(txtProductsNumber.Text),
                        credit_card = chkCreditCard.Checked,
                        active_member = chkActiveMember.Checked,
                        estimated_salary = float.Parse(txtEstimatedSalary.Text),
                        churn = churnComboBox.SelectedItem.ToString() == "Yes"
                    };

                    if (customerBLL.UpdateCustomer(updatedCustomer))
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công!");
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để chỉnh sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    string customerId = dgvCustomers.SelectedRows[0].Cells["customer_id"].Value.ToString();
                    if (customerBLL.DeleteCustomer(customerId))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = new Customer
                {
                    customer_id = txtCustomerId.Text,
                    credit_score = int.Parse(txtCreditScore.Text),
                    country = txtCountry.Text,
                    gender = txtGender.Text,
                    age = int.Parse(txtAge.Text),
                    tenure = int.Parse(txtTenure.Text),
                    balance = float.Parse(txtBalance.Text),
                    products_number = int.Parse(txtProductsNumber.Text),
                    credit_card = chkCreditCard.Checked,
                    active_member = chkActiveMember.Checked,
                    estimated_salary = float.Parse(txtEstimatedSalary.Text),
                    churn = churnComboBox.SelectedItem.ToString() == "Yes"
                };

                if (customerBLL.AddCustomer(newCustomer))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadDataDGV()
        {
            dgvCustomers.DataSource = customerBLL.GetAllCustomers();
        }

    }
}

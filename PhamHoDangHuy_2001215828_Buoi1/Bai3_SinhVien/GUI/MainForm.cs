using Bai3_SinhVien.Model;
using Bai3_SinhVien.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bai3_SinhVien.GUI
{
    public partial class MainForm : Form
    {
        private readonly PersonalInfoService _service;

        public MainForm()
        {
            InitializeComponent();
            _service = new PersonalInfoService();
            LoadForm();
        }

        private void LoadForm()
        {
            try
            {
                // Load provinces into ListBox
                listBox1.Items.AddRange(_service.GetProvinces().ToArray());
                if (listBox1.Items.Count > 0)
                {
                    listBox1.SelectedIndex = 0;
                }

                // Load ethnicities into ComboBox
                cmbEthnicity.DataSource = _service.GetEthnicities().ToList();
                cmbEthnicity.SelectedIndex = -1; // Set no selection by default

                // Configure AutoComplete for ComboBox
                cmbEthnicity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbEthnicity.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Optional: Any additional logic for form load
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtBirthDate.Clear();
            cmbEthnicity.SelectedIndex = -1; // Clear ComboBox selection

            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0; // Reset ListBox selection
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var info = new PersonalInfo
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    BirthDate = txtBirthDate.Text,
                    Ethnicity = cmbEthnicity.SelectedItem?.ToString(), // Use ComboBox value
                    Province = listBox1.SelectedItem?.ToString()
                };

                var validationResult = _service.ValidateInfo(info);
                if (validationResult.IsValid)
                {
                    _service.SaveInfo(info);
                    MessageBox.Show("Data saved successfully.");
                }
                else
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
    }
}

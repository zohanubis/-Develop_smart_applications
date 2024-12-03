namespace GUI
{
    partial class FrmCustomerManagement
    {
        private System.ComponentModel.IContainer components = null;

        // Các điều khiển chính
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvResults;

        // Các TextBox
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtCreditScore;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtTenure;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtProductsNumber;
        private System.Windows.Forms.TextBox txtEstimatedSalary;

        // CheckBox và ComboBox
        private System.Windows.Forms.CheckBox chkCreditCard;
        private System.Windows.Forms.CheckBox chkActiveMember;
        private System.Windows.Forms.ComboBox churnComboBox;

        // Các Button
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRunID3;
        private System.Windows.Forms.Button btnRunKMeans;

        // Các Label
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCreditScore;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTenure;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblProductsNumber;
        private System.Windows.Forms.Label lblEstimatedSalary;
        private System.Windows.Forms.Label lblChurn;
        private System.Windows.Forms.Label lblAccuracyID3;
        private System.Windows.Forms.Label lblAccuracyKMeans;

        /// <summary>
        /// Dispose resources.
        /// </summary>
        /// <param name="disposing">Disposing resources</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initialize components for FrmCustomerManagement
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Khởi tạo DataGridView chính
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Size = new System.Drawing.Size(760, 250);
            this.dgvCustomers.Name = "dgvCustomers";

            // Khởi tạo DataGridView hiển thị kết quả
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.dgvResults.Location = new System.Drawing.Point(12, 600);
            this.dgvResults.Size = new System.Drawing.Size(760, 150);
            this.dgvResults.Name = "dgvResults";

            // Các TextBox và Label
            int labelX = 20, textBoxX = 150, yStart = 280, spacingY = 30;

            // Customer ID
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerId.Text = "Customer ID:";
            this.lblCustomerId.Location = new System.Drawing.Point(labelX, yStart);
            this.Controls.Add(this.lblCustomerId);

            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtCustomerId.Location = new System.Drawing.Point(textBoxX, yStart);
            this.txtCustomerId.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtCustomerId);

            // Credit Score
            this.lblCreditScore = new System.Windows.Forms.Label();
            this.lblCreditScore.Text = "Credit Score:";
            this.lblCreditScore.Location = new System.Drawing.Point(labelX, yStart + spacingY);
            this.Controls.Add(this.lblCreditScore);

            this.txtCreditScore = new System.Windows.Forms.TextBox();
            this.txtCreditScore.Location = new System.Drawing.Point(textBoxX, yStart + spacingY);
            this.txtCreditScore.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtCreditScore);

            // Country
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCountry.Text = "Country:";
            this.lblCountry.Location = new System.Drawing.Point(labelX, yStart + 2 * spacingY);
            this.Controls.Add(this.lblCountry);

            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCountry.Location = new System.Drawing.Point(textBoxX, yStart + 2 * spacingY);
            this.txtCountry.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtCountry);

            // Gender
            this.lblGender = new System.Windows.Forms.Label();
            this.lblGender.Text = "Gender:";
            this.lblGender.Location = new System.Drawing.Point(labelX, yStart + 3 * spacingY);
            this.Controls.Add(this.lblGender);

            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtGender.Location = new System.Drawing.Point(textBoxX, yStart + 3 * spacingY);
            this.txtGender.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtGender);

            // Age
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAge.Text = "Age:";
            this.lblAge.Location = new System.Drawing.Point(labelX, yStart + 4 * spacingY);
            this.Controls.Add(this.lblAge);

            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAge.Location = new System.Drawing.Point(textBoxX, yStart + 4 * spacingY);
            this.txtAge.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtAge);

            // Balance
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalance.Text = "Balance:";
            this.lblBalance.Location = new System.Drawing.Point(labelX, yStart + 5 * spacingY);
            this.Controls.Add(this.lblBalance);

            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtBalance.Location = new System.Drawing.Point(textBoxX, yStart + 5 * spacingY);
            this.txtBalance.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtBalance);

            // Products Number
            this.lblProductsNumber = new System.Windows.Forms.Label();
            this.lblProductsNumber.Text = "Products Number:";
            this.lblProductsNumber.Location = new System.Drawing.Point(labelX, yStart + 6 * spacingY);
            this.Controls.Add(this.lblProductsNumber);

            this.txtProductsNumber = new System.Windows.Forms.TextBox();
            this.txtProductsNumber.Location = new System.Drawing.Point(textBoxX, yStart + 6 * spacingY);
            this.txtProductsNumber.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtProductsNumber);

            // Estimated Salary
            this.lblEstimatedSalary = new System.Windows.Forms.Label();
            this.lblEstimatedSalary.Text = "Estimated Salary:";
            this.lblEstimatedSalary.Location = new System.Drawing.Point(labelX, yStart + 7 * spacingY);
            this.Controls.Add(this.lblEstimatedSalary);

            this.txtEstimatedSalary = new System.Windows.Forms.TextBox();
            this.txtEstimatedSalary.Location = new System.Drawing.Point(textBoxX, yStart + 7 * spacingY);
            this.txtEstimatedSalary.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtEstimatedSalary);

            // Buttons
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(400, yStart);
            this.Controls.Add(this.btnAdd);

            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEdit.Text = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(500, yStart);
            this.Controls.Add(this.btnEdit);

            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(600, yStart);
            this.Controls.Add(this.btnDelete);

            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(700, yStart);
            this.Controls.Add(this.btnRefresh);

            // Run K-means
            this.btnRunKMeans = new System.Windows.Forms.Button();
            this.btnRunKMeans.Text = "Run K-means";
            this.btnRunKMeans.Location = new System.Drawing.Point(20, 550);
            this.Controls.Add(this.btnRunKMeans);

            // Run ID3
            this.btnRunID3 = new System.Windows.Forms.Button();
            this.btnRunID3.Text = "Run ID3";
            this.btnRunID3.Location = new System.Drawing.Point(150, 550);
            this.Controls.Add(this.btnRunID3);

            // Labels for Accuracy
            this.lblAccuracyKMeans = new System.Windows.Forms.Label();
            this.lblAccuracyKMeans.Text = "K-means Accuracy:";
            this.lblAccuracyKMeans.Location = new System.Drawing.Point(300, 550);
            this.Controls.Add(this.lblAccuracyKMeans);

            this.lblAccuracyID3 = new System.Windows.Forms.Label();
            this.lblAccuracyID3.Text = "ID3 Accuracy:";
            this.lblAccuracyID3.Location = new System.Drawing.Point(300, 580);
            this.Controls.Add(this.lblAccuracyID3);

            // ComboBox for Churn
            this.lblChurn = new System.Windows.Forms.Label();
            this.lblChurn.Text = "Churn:";
            this.lblChurn.Location = new System.Drawing.Point(20, yStart + 8 * spacingY);
            this.Controls.Add(this.lblChurn);

            this.churnComboBox = new System.Windows.Forms.ComboBox();
            this.churnComboBox.Location = new System.Drawing.Point(150, yStart + 8 * spacingY);
            this.churnComboBox.Size = new System.Drawing.Size(200, 20);
            this.churnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.churnComboBox.Items.AddRange(new object[] { "Yes", "No" });
            this.Controls.Add(this.churnComboBox);

            // CheckBox for Credit Card
            this.chkCreditCard = new System.Windows.Forms.CheckBox();
            this.chkCreditCard.Text = "Credit Card";
            this.chkCreditCard.Location = new System.Drawing.Point(400, yStart + spacingY);
            this.Controls.Add(this.chkCreditCard);

            // CheckBox for Active Member
            this.chkActiveMember = new System.Windows.Forms.CheckBox();
            this.chkActiveMember.Text = "Active Member";
            this.chkActiveMember.Location = new System.Drawing.Point(400, yStart + 2 * spacingY);
            this.Controls.Add(this.chkActiveMember);

            // Final Form Setup
            this.ClientSize = new System.Drawing.Size(800, 780);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.dgvResults);
            this.Name = "FrmCustomerManagement";
            this.Text = "Customer Management";

            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


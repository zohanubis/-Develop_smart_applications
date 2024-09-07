using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Card_Validator;

namespace CardValidatorApp.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnValidate_Click(object sender, EventArgs e)
        {

            Card_Validator validator = new Card_Validator("Name", txtCardNo.Text);

            if (validator.Validate())
            {
                lblThongBao.Text = "Valid card number: " + validator.CardNo;
            }
            else
            {
                lblThongBao.Text = "Invalid card number";
                MessageBox.Show("Invalid card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

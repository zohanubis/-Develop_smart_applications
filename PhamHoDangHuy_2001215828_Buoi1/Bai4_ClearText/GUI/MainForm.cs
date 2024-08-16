using Bai4_ClearText.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_ClearText.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void btnProcessTextBoxes_Click(object sender, EventArgs e)
        {
            if (radioButtonPanel1.Checked)
            {
                ClearTextService.ClearTextBoxesInContainer(panel1);
            }
            else if (radioButtonPanel2.Checked) {
                ClearTextService.ClearTextBoxesInContainer(panel2);
            }
            //else if (radioButtonPanel2.Checked == false && radioButtonPanel1.Checked == false) {
            //    ClearTextService.ClearAllTextBoxes();
            //}
            else
            {
                MessageBox.Show("Vui lòng chọn một panel để xử lý.");
            }
        }
    }
}

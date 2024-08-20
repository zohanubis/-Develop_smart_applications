using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamHoDangHuy_2001215828_Buoi2.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLoginForm();
        }
        public void UpdateStatusBar(string message)
        {
            statusBar1.Text = message;
        }
        private void ShowLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Owner = this;
            loginForm.ShowDialog();
        }

    }
}

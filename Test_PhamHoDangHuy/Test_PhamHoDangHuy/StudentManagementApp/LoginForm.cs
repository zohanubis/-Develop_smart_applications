using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.btnDangNhap.Click += btnDangNhap_Click;
            this.btnHuy.Click += btnHuy_Click;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

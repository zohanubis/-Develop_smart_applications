using LoginControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B45_XayDungModule
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            loginControl.Dock = DockStyle.Fill;

            loginControl.Cnn = Properties.Resources.cnn;
            loginControl.LoginSuccessful += LoginControl_LoginSuccessful;

            loginControl.LoginCancelled += LoginControl_LoginCancelled;
            this.Controls.Add(loginControl);
        }

        private void LoginControl_LoginCancelled(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginControl_LoginSuccessful(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }
    }
}

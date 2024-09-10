using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigUserControl
{
    public partial class ConfigUserControl : UserControl
    {
        public ConfigUserControl()
        {
            InitializeComponent();
        }

        // Event khi người dùng nhấn lưu
        public event EventHandler SaveClicked;
        public event EventHandler CancelClicked;

        public string ServerName => txtServerName.Text;
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;
        public string Database => cmbDatabase.Text;

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

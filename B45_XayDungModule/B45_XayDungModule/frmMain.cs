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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //this.menuItemAddUserToGroup.Click += MenuItemAddUserToGroup_Click;
            //this.menuItemUserGroup.Click += MenuItemUserGroup_Click;
           //this.menuItemUser.Click += MenuItemUser_Click;
            //this.menuItemRoleManagement.Click += MenuItemRoleManagement_Click;
        }

        private void MenuItemRoleManagement_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItemUser_Click(object sender, EventArgs e)
        {
            frmNguoiDung frm = new frmNguoiDung();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MenuItemUserGroup_Click(object sender, EventArgs e)
        {
        }

        private void MenuItemAddUserToGroup_Click(object sender, EventArgs e)
        {
            frmThemNguoiDungVaoNhom frm = new frmThemNguoiDungVaoNhom();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginControl;
namespace PhamHoDangHuy_Buoi2_ConnectionDatabase.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            loginControl1.Cnn = "Data Source=DESKTOP-EKR82M7;Initial Catalog=QuanLiNguoiDung;Persist Security Info=True;User ID=sa;Password=123456;Trust Server Certificate=True";
            
        }
    }
}

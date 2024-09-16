using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDataGridView
{
    public partial class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            InitializeComponent();
        }
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);
            if (e.RowIndex % 2 == 0)
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}

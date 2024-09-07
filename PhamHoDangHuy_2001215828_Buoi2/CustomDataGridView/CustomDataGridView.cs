using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace CustomDataGridView
{
    public class CustomDataGridView : DataGridView
    {
        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        {
            base.OnRowPrePaint(e);
            if (e.RowIndex % 2 == 0)
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorDepth.Depth24Bit;
            }
            else
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorDepth.Depth16Bit;
            }
        }
    }
}
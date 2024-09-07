using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace HoverButton
{
    public class HoverButton : Button
    {
        private Color orignalColor;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            orignalColor = this.BackColor;
            this.BackColor = Color.LightGreen;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = orignalColor;
        }

    }
}

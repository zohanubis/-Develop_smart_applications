using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoverButton
{
    public partial class HoverButton : Button
    {
        private Color originalColor;
        public HoverButton()
        {
            originalColor = this.BackColor;
            this.MouseEnter += HoverButton_MouseEnter;
            this.MouseLeave += HoverButton_MouseLeave;
        }

        private void HoverButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void HoverButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = originalColor;
        }
    }
}

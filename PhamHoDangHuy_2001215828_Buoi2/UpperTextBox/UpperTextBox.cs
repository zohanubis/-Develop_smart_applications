using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UpperTextBox
{
    public class UpperTextBox :TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            base.OnKeyPress(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            this.Text = this.Text.ToUpper();
            this.SelectionStart = this.Text.Length;
            base.OnTextChanged(e);
        }
    }
}

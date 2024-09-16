using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailTextBox
{
    public partial class MailTextBox : TextBox
    {
        private ErrorProvider errorProvider;
        public MailTextBox()
        {
            errorProvider = new ErrorProvider();
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if(!this.Text.Contains("@") || !this.Text.EndsWith(".com"))
            {
                errorProvider.SetError(this, "Email phải chứa @ và kết thúc bằng `.com`");
            }
            else
            {
                errorProvider.SetError(this, string.Empty);
            }
        }
    }
}

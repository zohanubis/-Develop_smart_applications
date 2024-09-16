using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassTextBox
{
    public partial class PassTextBox : TextBox
    {
        private ErrorProvider errorProvider;
        public PassTextBox()
        {
            errorProvider = new ErrorProvider();
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if(this.Text.Length < 6 || !Regex.IsMatch(this.Text, @"^a-ZA-Z0-9"))
            {
                errorProvider.SetError(this, "Mât khẩu phải chứa ít nhất 6 ký tự và một kí tự đặc biệt");
            }
            else
            {
                errorProvider.SetError(this,string.Empty);
            }
        }
    }
}

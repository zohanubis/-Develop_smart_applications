using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace UserTextBox
{
    public class UserTextBox :TextBox
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        protected override void OnTextChanged(EventArgs e)
        {
 	            base.OnTextChanged(e);
                ValidateUsername();
        }
        private void ValidateUsername()
        {
            if (Regex.IsMatch(this.Text, @"[^a-zA-Z0-9]"))
            {
                errorProvider.SetError(this, "Khong nhap ki tu dac biet cho username");
            }
            else
            {
                errorProvider.SetError(this, string.Empty);
            }
        }
    }
}

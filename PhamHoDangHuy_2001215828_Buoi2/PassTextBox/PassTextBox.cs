using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace PassTextBox
{
   public class PassTextBox : TextBox
    {
    private ErrorProvider errorProvider = new ErrorProvider();

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        ValidatePassword();
    }

    private void ValidatePassword()
    {
        if (this.Text.Length < 6 || !Regex.IsMatch(this.Text, @"[!|<>@#$%^&*(),.?\"))
        {
            errorProvider.SetError(this, "Password must be at least 6 characters long and contain at least one special character.");
        }
        else
        {
            errorProvider.SetError(this, string.Empty);
        }
    }
}

}

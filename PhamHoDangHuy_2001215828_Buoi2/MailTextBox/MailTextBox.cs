using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace MailTextBox
{
    public class MailTextBox : TextBox
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        protected override void OnTextChanged(EventArgs e)
        {
 	    
            base.OnTextChanged(e);
            ValidateEmail();
        }
    
        private void ValidateEmail(){
            if(!this.Text.Contains("@") || !this.Text.EndsWith(".com")){
                errorProvider.SetError(this, "Email must contain '@' and end with .com");
            }
            else
            {
                errorProvider.SetError(this,string.Empty);
            }
        }
    }
}

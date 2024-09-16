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

namespace UserTextBox
{
    public partial class UserTextBox : TextBox
    {
        private ErrorProvider _errorProvider;
        public UserTextBox()
        {
            _errorProvider = new ErrorProvider();
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (Regex.IsMatch(this.Text, @"[^a-zA-Z0-9]")) {
                _errorProvider.SetError(this, "Tên người dùng không được chứa các kí tự đặc biệt");
            }
            else
            {
                _errorProvider.SetError(this,string.Empty);
            }
        }
    }
}

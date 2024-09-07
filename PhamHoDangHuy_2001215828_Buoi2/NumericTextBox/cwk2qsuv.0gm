using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericTextBox
{
    public class NumericTextBox : TextBox
    {
        private System.Windows.Forms.ErrorProvider errorProvider = new ErrorProvider();
        public NumericTextBox()
        {
            this.KeyPress += NumericTextBox_KeyPress;
            this.TextChanged +=NumericTextBox_TextChanged;
        }

        void NumericTextBox_TextChanged(object sender, EventArgs e)
        {
            if(this.TextLength > 5){
                errorProvider.SetError(this,"Qua 5 ki tu");
            }
            else{
                errorProvider.Clear();
            }
        }

        void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NumbericTextBox
{
    public class NumbericTexBox :TextBox
    {
        private System.Windows.Forms.ErrorProvider  errorProvider = new ErrorProvider;
        public NumebericTextBox()
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

        void NumericTextBox_KeyPress(object sender, KeyPressEven
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class MaSinhTuDong_Textbox : TextBox
    {
        public MaSinhTuDong_Textbox()
        {
             this.ReadOnly= true; 
            GenerateMaSinhVien();
        }
        private void GenerateMaSinhVien()
        {
            string datePart = DateTime.Now.ToString("ddMMyy");

            string letterPart = GenerateRandomLetters(3);

            string numberPart = GenerateRandomNumbers(3);

            this.Text = $"{datePart}{letterPart}{numberPart}";
        }

        private string GenerateRandomLetters(int length)
        {
            Random random = new Random();
            string letters = "abcdefghijklmnopqrstuvwxyz";
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = letters[random.Next(letters.Length)];
            }
            return new string(result);
        }

        private string GenerateRandomNumbers(int length)
        {
            Random random = new Random();
            string numbers = "0123456789";
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = numbers[random.Next(numbers.Length)];
            }
            return new string(result);
        }
    }
}

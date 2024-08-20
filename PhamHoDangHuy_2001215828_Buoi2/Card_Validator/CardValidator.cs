using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Validator
{
    public class CardValidator
    {
        public string Name { get; set; }
        public string CardNo { get; set; }
        public CardValidator(string Name, string CardNo)
        {
            this.Name = Name;
            this.CardNo = CardNo;
        }
        public bool Validate()
        {
            int CardLength = CardNo.Length;
            if (CardLength == 5)
                return true;
            else
                return false;
        }
    }
}

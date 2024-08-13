using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamHoDangHuy_2001215828_Buoi1.Service
{
    internal class HandleFoods
    {
        
        private FoodsService foodService;

        public HandleFoods()
        {
            foodService = new FoodsService();
        }

        public string[] GetFoods()
        {
            return foodService.GetFoods();
        }
        public void ClearAllTextBoxes(Control container)
        {
            foreach (Control item in container.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty;
                }

                if (item.HasChildren)
                {
                    ClearAllTextBoxes(item);
                }
            }
        }
    }
}

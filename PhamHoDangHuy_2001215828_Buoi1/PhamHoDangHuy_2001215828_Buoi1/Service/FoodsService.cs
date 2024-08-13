using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamHoDangHuy_2001215828_Buoi1.Service
{
    internal class FoodsService
    {
        public string[] GetFoods()
        {
            return new string[]
            {
                "Grain", "Bread", "Beans", "Eggs", "Chicken", "Milk",
                "Fruit", "Vegetables", "Pasta", "Rice", "Fish", "Beef"
             };
        }
    }
}

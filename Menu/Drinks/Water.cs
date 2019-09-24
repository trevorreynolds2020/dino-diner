using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water: Drink
    {
        public bool Lemon = false;
        
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ice = true;
            Ingredients.Add("Water");
        }

        public void AddLemon()
        {
            Lemon = true;
        }
    }
}

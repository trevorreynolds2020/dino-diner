using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        public enum SadasaurusFlavor
        {
            Cola,
            Orange,
            Rootbear,
            Lime,
            Cherry,
            Vanilla,
            Grape,
            Cream
        }
        public Sodasaurus()
        {
            Price = 0;
            Calories = 0;
            Ice = true;
        }
    }
}

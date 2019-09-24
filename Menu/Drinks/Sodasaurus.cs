using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        public SodasaurusFlavor Flavor;
        public Size size;
        public enum SodasaurusFlavor
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

        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get { return size; }
        }
        public Sodasaurus()
        {
            Price = 0;
            Calories = 0;
            Ice = true;
            Ingredients.Add("Waters");
            Ingredients.Add("Natural Flavors");
            Ingredients.Add("Cane Sugar");
        }
    }
}

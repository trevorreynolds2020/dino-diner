using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink
    {
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor {
            get { return flavor; } 
            set { flavor = value; }
        }
        public Size size;
        public double Price { get; set; } = 1.5;

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
            Ingredients.Add("Water");
            Ingredients.Add("Natural Flavors");
            Ingredients.Add("Cane Sugar");
        }

        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
    }
}

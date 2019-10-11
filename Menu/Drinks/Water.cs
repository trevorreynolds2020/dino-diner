using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water:Drink
    {
        public bool Lemon = false;
        public Size size;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .1;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = .1;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = .1;
                        Calories = 0;
                        break;
                }
            }
            get { return size; }
        }

        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ice = true;
            ingredients.Add("Water");
        }

        public void AddLemon()
        {
            Lemon = true;
        }

        public override string ToString()
        {
            return $"{Size} Water";
        }
    }
}

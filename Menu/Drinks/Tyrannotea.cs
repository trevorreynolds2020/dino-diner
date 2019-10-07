using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea:Drink
    {
        public bool Sweet { get; set; } = false;
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
                        Price = .99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
            get { return size; }
        }
        public Tyrannotea()
        {
            Price = 0;
            Calories = 0;
            Ice = true;
            Ingredients.Add("Water");
            Ingredients.Add("Tea");
            Ingredients.Add("Lemon");
            Ingredients.Add("Cane Sugar");
        }

        public void AddLemon()
        {
            Lemon = true;
        }

        public void AddSweetner()
        {
            Sweet = true;
            Calories *= 2;
        }
        public void NoSweetner()
        {
            if(Sweet)
            {
                Sweet = false;
                Calories /= 2;
            }
        }

        public override string ToString()
        {
            if (Sweet) return $"{Size} Sweet Tyrannotea";
            else return $"{Size} Tyrannotea";
        }
    }
}

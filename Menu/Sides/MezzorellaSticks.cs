using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Enum for the size
        /// </summary>
        private Size size;
        /// <summary>
        /// Gets info about food item based on the size enum
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
            get { return size; }
        }

        /// <summary>
        /// Adds info about the item
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            Ingredients.Add("Breading");
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Vegetable Oil");

        }

        public override string ToString()
        {
            return $"{Size} Mezzorella Sticks";
        }
    }
}

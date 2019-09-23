using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public abstract class Drink
    {
        protected List<string> ingredients = new List<string>();

        // define enum for size?
       // public Size size { get; set; }
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients { get { return ingredients; } }
        public bool Ice { get; set; }

        public void HoldIce()
        {
            Ice = false;
        }
    }
}

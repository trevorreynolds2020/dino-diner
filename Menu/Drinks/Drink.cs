using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
//    public enum Size { Small, Medium, Large };
    public abstract class Drink
    {
        protected List<string> ingredients = new List<string>();
        public virtual Size Size { get; set; }
        public double Price { get; set; }
        public uint Calories { get; set; }
        public virtual List<string> Ingredients { get { return ingredients; } }
        public bool Ice { get; set; } = true;

        public void HoldIce()
        {
            Ice = false;
        }
    }
}

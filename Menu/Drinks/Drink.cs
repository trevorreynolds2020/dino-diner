using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem
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

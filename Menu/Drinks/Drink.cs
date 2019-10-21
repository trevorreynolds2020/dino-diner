using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem, IOrderItem
    {
        protected List<string> ingredients = new List<string>();
        public virtual Size Size { get; set; }
        public double Price { get; set; }
        public uint Calories { get; set; }
        public virtual List<string> Ingredients { get { return new List<string>(ingredients); } }
        public bool Ice { get; set; } = true;
        public abstract string Description { get; }
        public abstract string[] Special { get; }

        public void HoldIce()
        {
            Ice = false;
        }
    }
}

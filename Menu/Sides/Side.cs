using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Size of side
    /// </summary>

    /// <summary>
    /// Relevant details about the side
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem
    {
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get { return new List<string>(ingredients); } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; } //should be abstract
        public abstract string Description { get; }
        public abstract string[] Special { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Contains a list of ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Size enum for drink
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// Stores the price of drink
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Stores calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Lists out the ingredients
        /// </summary>
        public virtual List<string> Ingredients { get { return new List<string>(ingredients); } }
        /// <summary>
        /// Indicates whether or not to use ice
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Description of drink (from ToString method)
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// List of special instructions on drink
        /// </summary>
        public abstract string[] Special { get; }
        /// <summary>
        /// Variable to handle property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Sets ice to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}

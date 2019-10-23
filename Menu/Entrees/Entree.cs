using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Stores price of entree
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }
        /// <summary>
        /// Stores string representation of the entree
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// Tracks special instructions
        /// </summary>
        public abstract string[] Special { get; }
        /// <summary>
        /// Handles property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
        
}

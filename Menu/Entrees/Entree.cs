using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, INotifyPropertyChanged, IOrderItem
    {

        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }
        public abstract string Description { get; }
        public abstract string[] Special { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
        
}

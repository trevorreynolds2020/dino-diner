using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Water:Drink, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Indicates whether or not to use lemon
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// small, medium, or large
        /// </summary>
        public Size size;
        /// <summary>
        /// An event handler for PropertChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Calls PropertChangedEventHandler if a specific property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void INotifyIfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// small, medium, or large
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .1;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = .1;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = .1;
                        Calories = 0;
                        break;
                }
               // INotifyIfPropertyChanged("Price");
               // INotifyIfPropertyChanged("Calories");
                INotifyIfPropertyChanged("Description");
            }
            get { return size; }
        }
        /// <summary>
        /// Constructs an instance of water
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ice = true;
            ingredients.Add("Water");
        }
        /// <summary>
        /// Adds lemon
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
            INotifyIfPropertyChanged("Description");
        }
        /// <summary>
        /// Returns a string "water"
        /// </summary>
        /// <returns> "Water" </returns>
        public override string ToString()
        {
            return $"{Size} Water";
        }
        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// Special order instructions
        /// if no special instructions return an empty array
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}

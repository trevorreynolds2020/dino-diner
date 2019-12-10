using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Backing variable for the flavor
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Calls enum to get small, medium, large
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return flavor; } 
            set { flavor = value; INotifyIfPropertyChanged("Description"); }
        }
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
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
                INotifyIfPropertyChanged("Price");
                INotifyIfPropertyChanged("Calories");
                INotifyIfPropertyChanged("Description");
            }
            get { return size; }
        }
        /// <summary>
        /// Constructs soda with default price and calories
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            Ice = true;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }

       
        /// <summary>
        /// Returns a string with the details of soda
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
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
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Holds ice
        /// </summary>
        public override void HoldIce()
        {
            this.Ice = false;
            INotifyIfPropertyChanged("Special");
        }
    }
}

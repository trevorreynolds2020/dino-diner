using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, INotifyPropertyChanged
    {
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor {
            get { return flavor; } 
            set { flavor = value; }
        }
        public Size size;
        public double Price { get; set; } = 1.5;

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
            }
            get { return size; }
        }
        public Sodasaurus()
        {
            Price = 0;
            Calories = 0;
            Ice = true;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }

        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        // special instructions?
    }
}

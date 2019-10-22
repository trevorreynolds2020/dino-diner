using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Water:Drink, INotifyPropertyChanged, IOrderItem
    {
        public bool Lemon = false;
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
            }
            get { return size; }
        }

        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ice = true;
            ingredients.Add("Water");
        }

        public void AddLemon()
        {
            Lemon = true;
            INotifyIfPropertyChanged("Ingredients");
            INotifyIfPropertyChanged("Special");
        }

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
